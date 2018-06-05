using System;

using System.IO;


using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Data;
using Glass;

using System.Data.SQLite;
using System.Security.Cryptography;
/*
 *This Project Uses Multiple panels.Click view->other windows->document outline.
 *Then right click on panel and select BringToFront for a viewing a panel. 
  */
namespace LibraryManagementSystem
{
    



    public partial class MainForm : Form
    {
        public static string newmid;
        public static string msg;
       
        public static string globalstrLoggedUser;
        public static string globalstrLoggedUserType;
        public static string gtitle, gauthor, gpages, gpublisher, glang, gisbn, gdesc, gpubyear = "";
        public static Image gimg = null;
      public static  BooksAPIForm bform = null;
        Color init = Color.DarkBlue;
        // Color clkd = Color.DarkSeaGreen;
        Color clkd = Color.DarkGreen;
        Glass.GlassButton clickedButton = new GlassButton();

        //static string cur = Environment.CurrentDirectory;
        //old- gives-warning- Environment.SpecialFolder.ApplicationData 
        //c:\programdata folder.gives readonly file error- Environment.SpecialFolder.CommonApplicationData
      //  public static string datafolder =Environment.ExpandEnvironmentVariables(@"%systemdrive%\ProgramData\LibraryManagementSystem");
        public static string datafolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "LibraryManagementSystem");
       static string connstr = "Data Source="+datafolder+@"\librarydb.db;Version=3";
        public static SQLiteConnection con = new SQLiteConnection(connstr);





        //Global variables



        byte[] byteArrayMBimage = null;


        string selectallbooks = "SELECT BookID as 'Mã cuốn sách',Title as 'Tựa sách', Author as 'Tác giả', Available as 'Có sẵn'," +
                                "BookNo as 'Mã tựa sách',Category as 'Thể loại',Publisher as 'Nhà xuất bản', Language as 'Ngôn ngữ'," +
                                "Year as 'Năm',Price as 'Giá',Pages as 'Số trang',Shelf as 'Kệ',DateAdded as 'Ngày nhập',Type 'Loại lưu trữ'," +
                                "ISBN as 'Số ISBN' FROM BookDetails ";
        public MainForm()
        {
            InitializeComponent();
           // MessageBox.Show(connstr);

           // MessageBox.Show(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData));

        }
        private void loadlang()
        {
            string langs = LibraryManagementSystem.Properties.Settings.Default.languagelist;
            if (string.IsNullOrEmpty(langs.Trim()))
                return;

            string[] langarray = langs.Split(',');
            comboMBlang.Items.Clear();
            foreach (string item in langarray)
            {
                comboMBlang.Items.Add(item);
            }

            if (comboMBlang.Items.Count > 0)
                comboMBlang.SelectedIndex = 0;

        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            loadlang();
            treeViewExplore.Nodes.Add("nodeCateg", "Thể loại");
            bool BDhasdel = LibraryManagementSystem.Properties.Settings.Default.BookDetails;
            int bookid =readonlyNextID(BDhasdel, "BookDetails");
            textMBbid.Text = bookid.ToString();

            if (globalstrLoggedUserType == "User")
            {
                btnMenuPackages.Enabled = false;
                btnMenuUsers.Enabled = false;
                btnMenuExport.Enabled = false;


            }


            pnlISshow.Hide();
            BDlabelenlarge.Text = "";
            this.Activate();

            //Form Load-Connection Open
            //   con.Open();

            //Make treeViewExplore
          //  treeViewExplore.Nodes.Add("nodeAll", "All");
          //  treeViewExplore.Nodes.Add("nodeCateg", "Categories");
         //   treeViewExplore.Nodes["nodeCateg"].Tag = "noContentNode";



            //load category and fill grid
            loadCategory();

            // int r=fillGrid(selectallbooks+" ORDER BY Title");


            //load ExploreBooks search combobox
            comboSearchFields.SelectedIndex = 0;
            panelIScontainer.Hide();
            MBcombobtype.SelectedIndex = 0;
            
            if(comboMBlang.Items.Count!=0)
            comboMBlang.SelectedIndex = 0;


            //Issuedetails click 
            btnIDisudet_Click(null, null);

            //Managemembers 
            viewall(10);

            comboMMfields.SelectedIndex = 0;

            comboMBcateg.SelectedItem = Properties.Settings.Default.defaultcateg.ToString();
       
            comboIDfield.SelectedIndex = 0;

            fillGrid(selectallbooks + " ORDER BY BookID LIMIT 10 ");
            textMBdateadd.Text = DateTime.Today.ToString("dd/MM/yyyy");
            labelBDavail.Text = "";

            comboBDid.SelectedIndex = 0;

        }
        private void UserValidate()
        {
            /*  if (globalstrLoggedUserType != "a")
          {
              btnMBdelete.Enabled = false;
          }
          else 
          {
              btnMBdelete.Enabled = true;
          }*/
        }
        private int fillGrid(string cmdtext)
        {
            SQLiteCommand com = new SQLiteCommand(cmdtext, con);
            SQLiteDataReader dtr;
            dtr = com.ExecuteReader();
            DataTable tableExplore = new DataTable();

            tableExplore.Load(dtr);
            dtr.Close();

            gridviewExplore.DataSource = tableExplore;

            return tableExplore.Rows.Count;
        }

        private void loadCategory()
        {
            

            SQLiteCommand cmd = new SQLiteCommand("select Category from Categories", con);
            SQLiteDataReader dr = cmd.ExecuteReader();
          treeViewExplore.Nodes["nodeCateg"].Nodes.Clear();
            

            comboMBcateg.Items.Clear();
            while (dr.Read())
            {
                treeViewExplore.Nodes["nodeCateg"].Nodes.Add(dr[0].ToString());
               
                comboMBcateg.Items.Add(dr[0].ToString());
            }
            treeViewExplore.ExpandAll();
            dr.Close();
        }

        private void treeViewExplore_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeViewExplore.SelectedNode == null)
            {
                return;
            }
            if (treeViewExplore.SelectedNode.Text=="Categories")
            {
                return;
            }
            TreeNode selnode = treeViewExplore.SelectedNode;
            int res = 0;
    
                    res = fillGrid(string.Format(selectallbooks + " where Category='{0}' ORDER BY BookID", selnode.Text));
                if (res == 0)
                {
                    lblStatus.Text = "Không có sách trong thể loại " + selnode.Text;
                }
                else
                {
                    lblStatus.Text = "Tìm thấy " + res + " sách trong thể loại " + selnode.Text;
                }
           
            

        }

        private void btnSearchBooks_Click(object sender, EventArgs e)
        {
            string searchterm;
            string selectcmd;
            searchterm = textSearchTerm.Text.Replace(" ", "");
            if (string.IsNullOrEmpty(searchterm))
            {
                lblStatus.Text = "Nhập từ khóa tìm kiếm để tìm kiếm sách.";
                return;
            }

            selectcmd = string.Format(selectallbooks + " where REPLACE({0}, ' ', '') LIKE('%{1}%')", comboSearchFields.Text, searchterm);
            SQLiteCommand cmd = new SQLiteCommand(selectcmd, con);
            SQLiteDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows == true)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                gridviewExplore.DataSource = dt;


                lblStatus.Text = string.Format("Tìm thấy {2} sách cho từ khóa '{0}' trong mục {1}.", searchterm, comboSearchFields.Text, dt.Rows.Count);
            }
            else
            {

                gridviewExplore.DataSource = null;
                lblStatus.Text = lblStatus.Text = string.Format("Không tìm thấy sách cho từ khóa '{0}' trong mục {1}.", searchterm, comboSearchFields.Text);

            }
            dr.Close();

        }

        private void btnBDok_Click(object sender, EventArgs e)
        {
            bookdetailsFill(textBDbookidok.Text);
        }

        private void bookdetailsFill(string bookid)
        {
            string available = "False";

            object retval = null;

            byte[] img = null;
            string haspdf = "false";
            string price = "";
            if (String.IsNullOrEmpty(bookid.Trim()))
            {
                MessageBox.Show("Vui lòng nhập mã cuốn sách hoặc mã tựa sách.", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBDbookidok.Clear();
                return;
            }
            string cmdtext;
            if(comboBDid.Text== "Mã cuốn sách")
            cmdtext = String.Format("select * from BookDetails where BookID='{0}';", bookid);
            else
            cmdtext = String.Format("select * from BookDetails where BookNo='{0}';", bookid);

            SQLiteCommand cmd = new SQLiteCommand(cmdtext, con);
          
            SQLiteDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows == false)
            {
                MessageBox.Show("Không tìm thấy sách.", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBDbookidok.Clear();
                dr.Close();
                return;
            }

            while (dr.Read())
            {

                textBDbookid.Text = dr["BookID"].ToString();
                textBDbookno.Text = dr["BookNo"].ToString();
                textBDisbn.Text = dr["ISBN"].ToString();
                textBDtitle.Text = dr["Title"].ToString();
                textBDauthor.Text = dr["Author"].ToString();
                textBDcateg.Text = dr["Category"].ToString();
                textBDdescription.Text = dr["Description"].ToString();
                textBDyear.Text = dr["Year"].ToString();
                textBDpublisher.Text = dr["Publisher"].ToString();
                textBDlang.Text = dr["Language"].ToString();
                price = dr["Price"].ToString();
                textBDpages.Text = dr["Pages"].ToString();
                textBDshelf.Text = dr["Shelf"].ToString();
                textBDtype.Text = dr["Type"].ToString();
                textBDdateadded.Text = dr["DateAdded"].ToString();
                retval = dr["Image"];
                haspdf = dr["HasPdf"].ToString();
                available = dr["Available"].ToString();

            }



            if (available == "True")
            {
                labelBDavail.Text = "Sách này có sẵn";
                labelBDavail.ForeColor = Color.Green;
                btnBDissuedet.Hide();


            }
            else
            {

                labelBDavail.Text = "Sách này không có sẵn";
                labelBDavail.ForeColor = Color.Red;
                btnBDissuedet.Show();

            }





            textBDbookidok.Clear();
            if (!(retval is DBNull))
            {
                picBookCover.Show();
                img = (byte[])retval;
       
                System.IO.MemoryStream myMemoryStream = new System.IO.MemoryStream(img);
                System.Drawing.Image myImage = System.Drawing.Image.FromStream(myMemoryStream);
                picBookCover.Image = myImage;
                MBpicboxsetsizemode(picBookCover);
                if (picBookCover.SizeMode == PictureBoxSizeMode.Zoom)
                    BDlabelenlarge.Text = "Nhấp để xem kích thức lớn hơn";
                else
                    BDlabelenlarge.Text = "";

            }
            else
            {
             
                picBookCover.Hide();
                BDlabelenlarge.Text = "";
            }
            //Read Pdf
           // MessageBox.Show(haspdf);
            if (haspdf == "True")
            {
                btnBDviewebook.Show();
                btnBDebookfolder.Show();


            }
            else
            {
                btnBDviewebook.Hide();
                btnBDebookfolder.Hide();
            }

            textBDprice.Text = price;




        }

        private void gridviewExplore_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBDid.SelectedIndex = 0;
            cmdBookDetails_Click(null, null);
            bookdetailsFill(gridviewExplore.SelectedRows[0].Cells["BookID"].Value.ToString());


        }

        //Glass button color change function
        private void navigate(GlassButton newclickedbutton)
        {
            clickedButton.BackColor = init;
            clickedButton.GlowColor = Color.Cyan;
            clickedButton = newclickedbutton;
            clickedButton.BackColor = clkd;
            clickedButton.GlowColor = Color.YellowGreen;


        }


        //things to do when clicking a specific glassbutton:
        private void cmdBookDetails_Click(object sender, EventArgs e)
        {
            navigate(cmdBookDetails);
            panelBookDetails.BringToFront();
            this.AcceptButton = btnBDok;
            textBDbookidok.Focus();
        }
        private void cmdExplore_Click(object sender, EventArgs e)
        {
            navigate(cmdExplore);
            panelExplore.BringToFront();

            textSearchTerm.Focus();
        }
        private void cmdIssueSubmitBook_Click(object sender, EventArgs e)
        {
            navigate(cmdIssueSubmitBook);
            panelIssueSubmit.BringToFront();
            this.AcceptButton = btnISok;
            textISbid.Focus();
        }
        private void cmdIssueDetails_Click(object sender, EventArgs e)
        {
            navigate(cmdIssueDetails);
            panelIssueDetails.BringToFront();
            textIDsearch.Focus();

        }
        private void cmdManageBooks_Click(object sender, EventArgs e)
        {

            navigate(cmdManageBooks);
            panelManageBooks.BringToFront();
            textMBisbn.Focus();

        }
        private void cmdManageMembers_Click(object sender, EventArgs e)
        {
            navigate(cmdManageMembers);
            panelManageMembers.BringToFront();
            textMMsearchterm.Focus();
        }



        private void MainForm_Shown(object sender, EventArgs e)
        {
       

            lblUsersStatus.Text = globalstrLoggedUser ;
            lblUserType.Text = globalstrLoggedUserType;

            string lastview = Properties.Settings.Default.lastview;
            switch (lastview)
            {
                case "0": cmdExplore_Click(null, null);
                    break;
                case "1": cmdBookDetails_Click(null, null);
                    break;
                case "2": cmdIssueSubmitBook_Click(null, null);
                    break;
                case "3": cmdIssueDetails_Click(null, null);
                    break;
                case "4": cmdManageBooks_Click(null, null);
                    break;
                case "5": cmdManageMembers_Click(null, null);
                    break;
                case "6": cmdMenu_Click(null, null);
                    break;
            }

        }


        private bool checksubmit(string bookid, string memid)
        {
            SQLiteCommand com = new SQLiteCommand(con);
            com.CommandText = String.Format("select count(BookID) from IssueDetails where BookID={0} AND MemberID={1};", bookid, memid);
            int c = Convert.ToInt32(com.ExecuteScalar());
            if (c == 0)
                return false;
            else
                return true;
        }
        private void prepareIssue()
        {
            panelIScontainer.Show();
            groupIssue.BringToFront();

            textISIBissuedate.Text = DateTime.Today.ToString("dd/MM/yyyy");

            int dti = Properties.Settings.Default.daysToIssue;
            textISIBduedate.Text = DateTime.Today.AddDays(dti).ToString("dd/MM/yyyy");
            textISIBdays.Text = dti.ToString();
            btnISissue.Focus();

        }

        private void prepareSubmit(string bookid, string memid)
        {
            panelIScontainer.Show();
            groupSubmit.BringToFront();
            SQLiteCommand com = new SQLiteCommand(con);
            SQLiteDataReader dtr;

            com.CommandText = String.Format("select IssueDate,DueDate from IssueDetails where BookID={0} AND MemberID={1};", bookid, memid);
            dtr = com.ExecuteReader();
            dtr.Read();
            string id = dtr["IssueDate"].ToString();
            string dd = dtr["DueDate"].ToString();
            textISSBissuedate.Text = id;
            textISSBduedate.Text = dd;

            textISSBsubmitdate.Text = DateTime.Today.ToString("dd/MM/yyyy");

            DateTime duedate = DateTime.ParseExact(dd, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            TimeSpan ts = DateTime.Today - duedate;
            if (ts.Days > 0)
            {
                int dailyFine = Properties.Settings.Default.dailyFine;
                int fine = ts.Days * dailyFine;
                textISSBfine.Text = fine.ToString();
               // MessageBox.Show("Days:" + ts.Days + "  dailyfine:" + dailyFine + "  FineTotal:" + fine);
            }
            else
            {
                textISSBfine.Text = "0";
            }
            btnISsubmitbook.Focus();
        }

        private void getMemBookDetails(string bookid, string memid)
        {

            pnlISshow.Show();



            SQLiteCommand com = new SQLiteCommand(con);
            SQLiteDataReader dtr;

            com.CommandText = String.Format("select Name from MemberDetails where MemberID={0};", memid);
            string name = com.ExecuteScalar().ToString();
            textIsName.Text = name;

            com.CommandText = String.Format("select Title,Author from BookDetails where BookID={0};", bookid);
            dtr = com.ExecuteReader();
            dtr.Read();
            textIStitle.Text = dtr["Title"].ToString();
            textISauthor.Text = dtr["Author"].ToString();


        }

        private bool ISvalidate()
        {
            string bookid = textISbid.Text;
            string memid = textISmid.Text;
            string msg;

            //bookid validate
            if (String.IsNullOrEmpty(bookid.Trim()))
            {
                msg = "Vui lòng nhập Mã cuốn sách.";
                MessageBox.Show(msg);
                textISbid.Clear();
                return false;

            }

            //member id validate
            if (String.IsNullOrEmpty(memid.Trim()))
            {
                msg = "Vui lòng nhập Mã độc giả.";
                MessageBox.Show(msg);
                textISmid.Clear();
                return false;
            }

            //check whether book exists
            SQLiteCommand com = new SQLiteCommand(con);
            com.CommandText = String.Format("select count(BookID) from BookDetails where BookID={0};", bookid);
            int c = Convert.ToInt32(com.ExecuteScalar());
            if (c == 0)
            {
                MessageBox.Show("Không tìm thấy sách ! Mã cuốn sách:" + bookid);
                return false;
            }

            //check whether member exists
            com = new SQLiteCommand(con);
            com.CommandText = String.Format("select count(MemberID) from MemberDetails where MemberID='{0}'", memid);
            int c1 = Convert.ToInt32(com.ExecuteScalar());
            if (c1 == 0)
            {
                MessageBox.Show("Không tìm thấy độc giả ! Mã độc giả:" + memid);
                return false;
            }
            return true;

        }

        private bool bookavail(string bid)
        {
            //check for book availability.
            SQLiteCommand com = new SQLiteCommand(con);
            com.CommandText = String.Format("select Available from BookDetails where BookID={0};", bid);
            string avail = com.ExecuteScalar().ToString();
            if (avail == "False")
            {
                MessageBox.Show("Sách không có sẵn để cho mượn.");
                return false;

            }
            return true;
        }

        private bool checkPackageLimit(string memid)
        {
            SQLiteCommand com = new SQLiteCommand(con);
            com.CommandText = String.Format("select count(MemberID) from SetPackages where MemberID={0} ;", memid);
            int c = Convert.ToInt32(com.ExecuteScalar());

            if (c == 0)
            {
                MessageBox.Show("Độc giả chưa kích hoạt gói dịch vụ.\nTắt gói dịch vụ để cài đặt giới hạn sách tối đa có thể mượn.");
                return false;
            }


            DateTime pkgst; string pkgst_txt = ""; bool foundmatchingpkg = false;
            while (true)
            {
                com.CommandText = String.Format("select count(MemberID) from SetPackages where MemberID={0} ;", memid);
                int c1 = Convert.ToInt32(com.ExecuteScalar());
                if (c1 == 0)
                    break;
                com.CommandText = String.Format("select min(StartDate) from SetPackages where MemberID={0} ;", memid);
                string stdate = com.ExecuteScalar().ToString();
                com.CommandText = String.Format("select EndDate from SetPackages where MemberID={0} AND StartDate='{1}' ;", memid, stdate);
                string endate = com.ExecuteScalar().ToString();
                DateTime end = DateTime.ParseExact(endate, "yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture);
                DateTime start = DateTime.ParseExact(stdate, "yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture);
                DateTime tod = DateTime.Today;
                if (tod >= start && tod <= end)
                {
                    pkgst = start;
                    pkgst_txt = stdate;
                    foundmatchingpkg = true;
                    break;

                }
                else
                {
                    com.CommandText = String.Format("DELETE from SetPackages where MemberID={0} AND StartDate='{1}'  ;", memid, stdate);
                    com.ExecuteNonQuery();

                }
            }
            if (foundmatchingpkg == false)
            {
                MessageBox.Show("Gói dịch vụ hiện tại đã hết hạn cho thành viên này.");
                return false;
            }
            else
            {
                com.CommandText = String.Format("select MaxBooks from SetPackages where MemberID={0} AND StartDate='{1}' ;", memid, pkgst_txt);
                int maxb = Convert.ToInt32(com.ExecuteScalar());

                com.CommandText = String.Format("select count(BookID) from IssueDetails where MemberID={0};", memid);
                int pendingbook = Convert.ToInt32(com.ExecuteScalar());

                if (pendingbook >= maxb)
                {
                    MessageBox.Show("Thành viên đã đạt đến giới hạn tối đa đối với số lượng sách có thể mượn được chỉ định trong gói dịch vụ");
                    return false;
                }
                else
                {
                    return true;
                }

            }




        }

        private bool checkMaxBookLimit(string mid)
        {
            SQLiteCommand com = new SQLiteCommand(con);
            com.CommandText = String.Format("select count(BookID) from IssueDetails where MemberID={0};", mid);
            int pendingbook = Convert.ToInt32(com.ExecuteScalar());

            if (pendingbook >= Properties.Settings.Default.maxBooks)
            {
                MessageBox.Show("Thành viên đã đạt đến giới hạn tối đa số lượng sách có thể mượn.");
                return false;
            }
            else
            {
                return true;
            }
        }
        private void btnISok_Click(object sender, EventArgs e)
        {
            panelIScontainer.Hide();
            textISauthor.Clear(); textISbid2.Clear(); textISmid2.Clear(); textIsName.Clear();
            textIStitle.Clear();

            if (!ISvalidate())
                return;

            string bid = textISbid.Text;
            string mid = textISmid.Text;
            textISbid2.Text = bid;
            textISmid2.Text = mid;

            textISbid.Clear(); textISmid.Clear();

            if (checksubmit(bid, mid))
            {
                //code for submitting book
                getMemBookDetails(bid, mid);
                prepareSubmit(bid, mid);
            }
            else
            {
                //code for issuing book
                if (!bookavail(bid))
                    return;

                if (Properties.Settings.Default.usePackages)
                {
                    if (!checkPackageLimit(mid))
                        return;
                }
                else
                {
                    if (!checkMaxBookLimit(mid))
                        return;
                }
                getMemBookDetails(bid, mid);
                prepareIssue();
            }

            //code ends..   


        }

        private void btnBDissuedet_Click(object sender, EventArgs e)
        {
            btnIDisudet_Click(null, null);
            textIDsearch.Text = textBDbookid.Text;
            comboIDfield.SelectedIndex = 0;
            btnIDsearch_Click(null, null);
            cmdIssueDetails_Click(null, null);

        }



        private void btnISissue_Click(object sender, EventArgs e)
        {
            try
            {
            SQLiteCommand com = new SQLiteCommand(con);

            string bid = textISbid2.Text;
            string mid = textISmid2.Text;
            
                string cmdtext ="INSERT INTO IssueDetails(BookID,MemberID,IssueDate,DueDate,BookTitle,MemberName) VALUES(@bid,@mid,@id,@dd,@title,@memname); ";
                com.CommandText = cmdtext;

                com.Parameters.Add(new SQLiteParameter("@bid",bid));
                com.Parameters.Add(new SQLiteParameter("@mid",mid));
                com.Parameters.Add(new SQLiteParameter("@id",textISIBissuedate.Text));
                com.Parameters.Add(new SQLiteParameter("@dd",textISIBduedate.Text));
                com.Parameters.Add(new SQLiteParameter("@title",textIStitle.Text));
                com.Parameters.Add(new SQLiteParameter("@memname",textIsName.Text));

                com.ExecuteNonQuery();

                cmdtext = String.Format("UPDATE BookDetails SET Available='{0}' WHERE BookID={1};", false.ToString(), bid);
                com.CommandText = cmdtext;
                com.ExecuteNonQuery();
                panelIScontainer.Hide();
                lblStatus.Text = "Sách " + bid + " đã mượn thành công";
                pnlISshow.Hide();
                dataGridID.DataSource = null;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Message :" + ex.Message + "\n Source :" + ex.Source);
            }

        }



        private void btnISIBchgdue_Click(object sender, EventArgs e)
        {
            textISIBduedate.Text = DateTime.ParseExact(textISIBissuedate.Text, "dd/MM/yyyy", null).AddDays(Convert.ToInt32(textISIBdays.Text)).ToString("dd/MM/yyyy");
        }

        private void btnISsubmitbook_Click(object sender, EventArgs e)
        {
            string bid = textISbid2.Text;
            string mid = textISmid2.Text;
            SQLiteCommand cmd = new SQLiteCommand(con);

            try
            {
                string fine;
                fine = textISSBfine.Text;
                string cmdtext = String.Format("DELETE FROM IssueDetails WHERE BookID={0} AND MemberID='{1}';", bid, mid);
                cmd.CommandText = cmdtext;
                cmd.ExecuteNonQuery();
                cmdtext = "INSERT INTO SubmittedBooks(BookID,MemberID,IssueDate,DueDate,SubmitDate,Fine,BookTitle,MemberName) VALUES(@bid,@mid,@id,@dd,@sd,@fine,@title,@memname);";
                cmd.CommandText = cmdtext;

                cmd.Parameters.Add(new SQLiteParameter("@bid",bid));
                cmd.Parameters.Add(new SQLiteParameter("@mid",mid));
                cmd.Parameters.Add(new SQLiteParameter("@id",textISSBissuedate.Text));
                cmd.Parameters.Add(new SQLiteParameter("@dd",textISSBduedate.Text));
                cmd.Parameters.Add(new SQLiteParameter("@sd",textISSBsubmitdate.Text));
                cmd.Parameters.Add(new SQLiteParameter("@fine",fine));
                cmd.Parameters.Add(new SQLiteParameter("@title",  textIStitle.Text));
                cmd.Parameters.Add(new SQLiteParameter("@memname", textIsName.Text));

                cmd.ExecuteNonQuery();

                cmdtext = String.Format("UPDATE BookDetails SET Available='{0}' WHERE BookID={1};", true.ToString(), bid);
                cmd.CommandText = cmdtext;
                cmd.ExecuteNonQuery();
                panelIScontainer.Hide();
                pnlISshow.Hide();
                lblStatus.Text = "Sách " + bid + " đã trả thành công";


                btnIDextendDD.Hide();
                btnIDsubmitbook.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Message :" + ex.Message + "\n Source :" + ex.Source);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
      

            if (clickedButton.Tag != null)
                Properties.Settings.Default.lastview = clickedButton.Tag.ToString();
            Properties.Settings.Default.Save();

        }

        private void btnIDsubdet_Click(object sender, EventArgs e) 
        {
            SQLiteCommand com = new SQLiteCommand(con);
            SQLiteDataReader dtr;

            btnIDsubdet.BackColor = Color.LightBlue;
            btnIDisudet.BackColor = Color.WhiteSmoke;

            labelIDfine.Show();
            labelIDsubd.Show();
            textIDfine.Show();
            textIDsubdate.Show();


            btnIDextendDD.Hide();
            btnIDsubmitbook.Hide();

            string cmdtext = "select BookID as 'Mã cuốn sách',MemberID as 'Mã độc giả',BookTitle as 'Tựa sách',MemberName as 'Tên độc giả',IssueDate as 'Ngày mượn',DueDate as 'Ngày hết hạn',SubmitDate as 'Ngày trả',Fine as 'Phí trễ hạn' from SubmittedBooks; ";
            com.CommandText = cmdtext;
            dtr = com.ExecuteReader();
            if (dtr.HasRows == true)
            {
                DataTable dt = new DataTable();
                dt.Load(dtr);
                dtr.Close();
                dataGridID.DataSource = dt;

                textIDbid.Text = dataGridID.SelectedRows[0].Cells["Mã cuốn sách"].Value.ToString();
                textIDmid.Text = dataGridID.SelectedRows[0].Cells["Mã độc giả"].Value.ToString();
                textIDtitle.Text = dataGridID.SelectedRows[0].Cells["Tựa sách"].Value.ToString();
                textIDname.Text = dataGridID.SelectedRows[0].Cells["Tên độc giả"].Value.ToString();
                textIDidate.Text = dataGridID.SelectedRows[0].Cells["Ngày mượn"].Value.ToString();

                DateTime dta = Convert.ToDateTime(dataGridID.SelectedRows[0].Cells["Ngày hết hạn"].Value.ToString(), System.Globalization.CultureInfo.CreateSpecificCulture("en-IN").DateTimeFormat);

                textIDdd.Text = dta.ToString("dd/MM/yyyy");

                textIDsubdate.Text = dataGridID.SelectedRows[0].Cells["Ngày trả"].Value.ToString();
                textIDfine.Text = dataGridID.SelectedRows[0].Cells["Phí trễ hạn"].Value.ToString();

                dataGridID.Show();
                lblStatus.Text = "Tìm danh sách thành công.";
            }
            else
            {
                dataGridID.Hide();
                lblStatus.Text = "Danh sách trống.";
            }
            dtr.Close();
        }
        private void btnIDisudetFillGrid()
        {

        }
        private void btnIDisudet_Click(object sender, EventArgs e)
        {
            SQLiteCommand com = new SQLiteCommand(con);
            SQLiteDataReader dtr;

            btnIDisudet.BackColor = Color.LightBlue;
            btnIDsubdet.BackColor = Color.WhiteSmoke;
            labelIDfine.Hide();
            labelIDsubd.Hide();
            textIDfine.Hide();
            textIDsubdate.Hide();


            btnIDsubmitbook.Show();
            btnIDextendDD.Show();


            string cmdtext = "select BookID as 'Mã cuốn sách',MemberID as 'Mã độc giả',BookTitle as 'Tựa sách',MemberName as 'Tên độc giả',IssueDate as 'Ngày mượn',DueDate as 'Ngày hết hạn' from IssueDetails; ";
            com.CommandText = cmdtext;
           dtr = com.ExecuteReader();
            if (dtr.HasRows == true)
            {
                DataTable dt = new DataTable();
                dt.Load(dtr);
                dtr.Close();

                dataGridID.DataSource = dt;

                textIDbid.Text = dataGridID.SelectedRows[0].Cells["Mã cuốn sách"].Value.ToString();
                textIDmid.Text = dataGridID.SelectedRows[0].Cells["Mã độc giả"].Value.ToString();
                textIDtitle.Text = dataGridID.SelectedRows[0].Cells["Tựa sách"].Value.ToString();
                textIDname.Text = dataGridID.SelectedRows[0].Cells["Tên độc giả"].Value.ToString();
                textIDidate.Text = dataGridID.SelectedRows[0].Cells["Ngày mượn"].Value.ToString();

                DateTime dta = Convert.ToDateTime(dataGridID.SelectedRows[0].Cells["Ngày hết hạn"].Value.ToString(), System.Globalization.CultureInfo.CreateSpecificCulture("en-IN").DateTimeFormat);

                textIDdd.Text = dta.ToString("dd/MM/yyyy");



                dataGridID.Show();
                lblStatus.Text = "Tìm danh sách thành công.";
            }
            else
            {

                btnIDsubmitbook.Hide();
                dataGridID.Hide();
                lblStatus.Text = "Danh sách trống.";
            }

        }

        private void dataGridID_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            textIDbid.Text = dataGridID.SelectedRows[0].Cells["Mã cuốn sách"].Value.ToString();
            textIDmid.Text = dataGridID.SelectedRows[0].Cells["Mã độc giả"].Value.ToString();
            textIDtitle.Text = dataGridID.SelectedRows[0].Cells["Tựa sách"].Value.ToString();
            textIDname.Text = dataGridID.SelectedRows[0].Cells["Tên độc giả"].Value.ToString();
            textIDidate.Text = dataGridID.SelectedRows[0].Cells["Ngày mượn"].Value.ToString();

            DateTime dta = Convert.ToDateTime(dataGridID.SelectedRows[0].Cells["Ngày hết hạn"].Value.ToString(), System.Globalization.CultureInfo.CreateSpecificCulture("en-IN").DateTimeFormat);

            textIDdd.Text = dta.ToString("dd/MM/yyyy");
            if (btnIDsubdet.BackColor == Color.LightBlue)
            {

                textIDsubdate.Text = dataGridID.SelectedRows[0].Cells["Ngày trả"].Value.ToString();
                textIDfine.Text = dataGridID.SelectedRows[0].Cells["Phí trễ hạn"].Value.ToString();
            }

        }

        private void btnIDchdate_Click(object sender, EventArgs e)
        {



        }




        private void btnMBeditdel_Click(object sender, EventArgs e)
        {
            frmEditBook eb = new frmEditBook();
            eb.ShowDialog();

            bool BDhasdel = LibraryManagementSystem.Properties.Settings.Default.BookDetails;
            int bookid = readonlyNextID(BDhasdel, "BookDetails");
            textMBbid.Text = bookid.ToString();
        }

        private void btnMBadd2_Click(object sender, EventArgs e)
        {



            if (string.IsNullOrEmpty(textMBtitle.Text))
            {
                MessageBox.Show("Nhập tựa sách");
                return;
            }
            if (MBcombobtype.Text != "Bản cứng" && textMBpdfurl.Text == "")
            {
                MessageBox.Show("Chọn file PDF");
                return;
            }
            string price = null;
            if (string.IsNullOrEmpty(textMBprice.Text.Trim()) != true)
            {
                price = textMBprice.Text.Trim();
            }


            bool BDhasdel = LibraryManagementSystem.Properties.Settings.Default.BookDetails;
            int bookid =getNextID(BDhasdel, "BookDetails");
            string haspdf;
            if (String.IsNullOrEmpty(textMBpdfurl.Text))
            {
                haspdf = "False";
            }
            else
            {
                haspdf = "True";
            }

            SQLiteCommand comm = new SQLiteCommand(con);
            string cmdtext = @"INSERT INTO BookDetails
(BookID,BookNo,ISBN,Title,Author,Description,Category,Publisher,Language,
Year,Pages,Shelf,DateAdded,Type,Available,Price,HasPdf)
VALUES(@bid,@bookno,@isbn,@title,@author,@desc,@categ,@pub,@lang,
@year,@pages,@shelf,@date,@type,@avail,@price,@haspdf);";

            comm.CommandText = cmdtext;
            comm.Parameters.Add(new SQLiteParameter("@bid", bookid));
            comm.Parameters.Add(new SQLiteParameter("@bookno", textMBbookno.Text));
            comm.Parameters.Add(new SQLiteParameter("@isbn", textMBisbn.Text));
            comm.Parameters.Add(new SQLiteParameter("@title", textMBtitle.Text));
            comm.Parameters.Add(new SQLiteParameter("@author", textMBauthor.Text));

            comm.Parameters.Add(new SQLiteParameter("@desc", textMBdesc.Text));
            comm.Parameters.Add(new SQLiteParameter("@categ", comboMBcateg.Text));
            comm.Parameters.Add(new SQLiteParameter("@pub", textMBpub.Text));
            comm.Parameters.Add(new SQLiteParameter("@lang", comboMBlang.Text));

            comm.Parameters.Add(new SQLiteParameter("@year", textMByear.Text));
            comm.Parameters.Add(new SQLiteParameter("@pages", textMBpage.Text));
            comm.Parameters.Add(new SQLiteParameter("@shelf", textMBshelf.Text));
            comm.Parameters.Add(new SQLiteParameter("@date", textMBdateadd.Text));

            comm.Parameters.Add(new SQLiteParameter("@type", MBcombobtype.Text));
            comm.Parameters.Add(new SQLiteParameter("@avail", "True"));
            comm.Parameters.Add(new SQLiteParameter("@price", textMBprice.Text));
            comm.Parameters.Add(new SQLiteParameter("@haspdf", haspdf));


            comm.ExecuteNonQuery();



            if (byteArrayMBimage != null)
            {

                comm.CommandText = string.Format("UPDATE BookDetails SET Image=@Picture WHERE BookID={0};", bookid);
                comm.Connection = con;
                comm.Parameters.Add("@Picture", System.Data.DbType.Binary);
                comm.Parameters["@Picture"].Value = byteArrayMBimage;
                comm.ExecuteNonQuery();

            }
            if (!String.IsNullOrEmpty(textMBpdfurl.Text))
            {
                string fileName = bookid.ToString() + ".pdf"; ;
                string source = textMBpdfurl.Text;
                //string cur = Environment.CurrentDirectory + @"\Ebooks";
                string cur =datafolder + @"\Ebooks";

                string destination = Path.Combine(cur, fileName);

                File.Copy(source, destination, true);


            }

            lblStatus.Text = "Tựa sách '" + textMBtitle.Text + "' Mã cuốn sách: " + bookid + " đã thêm thành công. " + "Thêm sách khác ..";
            btnMBclear_Click(null, null);



        }


        public static int getNextID(bool hasdeleted, string tablename)
        {
            int id;
            int count;
            SQLiteCommand com = new SQLiteCommand(con);
            try
            {
                com.CommandText = String.Format("select count(*) from {0}", tablename);
                count = Convert.ToInt32(com.ExecuteScalar());
                if (count == 0)
                {
                    id = 1;
                }
                else
                {
                    if (hasdeleted == true)
                    {

                        com.CommandText = String.Format("select count(deletedID) from DeletedID where tablename='{0}'", tablename);
                        int delcount = Convert.ToInt32(com.ExecuteScalar());
                        if (delcount == 0)
                        {
                            id = Convert.ToInt32(count) + 1;
                            switch (tablename)
                            {
                                case "BookDetails":
                                    LibraryManagementSystem.Properties.Settings.Default.BookDetails = false;
                                    break;
                                case "MemberDetails":
                                    LibraryManagementSystem.Properties.Settings.Default.MemberDetails = false;
                                    break;
                                case "Categories":
                                    LibraryManagementSystem.Properties.Settings.Default.Categories = false;
                                    break;
                                case "Packages":
                                    LibraryManagementSystem.Properties.Settings.Default.Packages = false;
                                    break;

                            }
                            Properties.Settings.Default.Save();
                            return id;
                        }

                        com.CommandText = String.Format("select min(deletedID) from DeletedID where tablename='{0}'", tablename);
                        id = Convert.ToInt32(com.ExecuteScalar());
                        com.CommandText = String.Format("delete from DeletedID where tablename='{0}' and DeletedID={1}", tablename, id);
                        com.ExecuteNonQuery();

                    }
                    else
                    {
                        id = Convert.ToInt32(count) + 1;
                    }


                }
                return id;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tạo mã tăng tự động :" + ex.Message + "\n Source :" + ex.Source);
                return 1;
            }

        }

        //no delete from deletedid table
        public static int readonlyNextID(bool hasdeleted, string tablename)
        {
            int id;
            int count;
            SQLiteCommand com = new SQLiteCommand(con);
            try
            {
                com.CommandText = String.Format("select count(*) from {0}", tablename);
                count = Convert.ToInt32(com.ExecuteScalar());
                if (count == 0)
                {
                    id = 1;
                }
                else
                {
                    if (hasdeleted == true)
                    {

                        com.CommandText = String.Format("select count(deletedID) from DeletedID where tablename='{0}'", tablename);
                        int delcount = Convert.ToInt32(com.ExecuteScalar());
                        if (delcount == 0)
                        {
                            id = Convert.ToInt32(count) + 1;
                            return id;
                        }

                        com.CommandText = String.Format("select min(deletedID) from DeletedID where tablename='{0}'", tablename);
                        id = Convert.ToInt32(com.ExecuteScalar());
                       // com.CommandText = String.Format("delete from DeletedID where tablename='{0}' and DeletedID={1}", tablename, id);
                        //com.ExecuteNonQuery();

                    }
                    else
                    {
                        id = Convert.ToInt32(count) + 1;
                    }


                }
                return id;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tạo mã tăng tự động :" + ex.Message + "\n Source :" + ex.Source);
                return 1;
            }

        }

        private void MBclear()
        {
            foreach (Control c in panelManageBooks.Controls)
            {
                if (c is TextBox)
                {
                    if (c.Name == "textMBshelf")
                        continue;
                    c.Text = "";

                }
            }
            labelMBpicsize.Hide();
            textMBdateadd.Text = DateTime.Today.ToString("dd/MM/yyyy");

            byteArrayMBimage = null;

            pictureMB.Image = null;
            comboMBcateg.SelectedItem = Properties.Settings.Default.defaultcateg.ToString();

            bool BDhasdel = LibraryManagementSystem.Properties.Settings.Default.BookDetails;
            int bookid =readonlyNextID(BDhasdel, "BookDetails");
            textMBbid.Text = bookid.ToString();
        }



        private void btnMBeditsave_Click(object sender, EventArgs e)
        {


        }

        private void btnMBopenfile_Click(object sender, EventArgs e)
        {
            try
            {

                long imageFileLength = 0;

                this.openFileDialogMBpic.ShowDialog();
                string strFn = this.openFileDialogMBpic.FileName;
                if (strFn == "")
                    return;
                this.pictureMB.Image = Image.FromFile(strFn);
                FileInfo fiImage = new FileInfo(strFn);
                imageFileLength = fiImage.Length;

                FileStream fs = new FileStream(strFn, FileMode.Open, FileAccess.Read, FileShare.Read);
                byteArrayMBimage = new byte[Convert.ToInt32(imageFileLength)];
                fs.Read(byteArrayMBimage, 0, Convert.ToInt32(imageFileLength));
                fs.Close();

                textMBimgurl.Text = strFn;
                labelMBpicsize.Text = "Size : " + Convert.ToString(Math.Round(imageFileLength / 1024.00, 2)) + " KB ";
                labelMBpicsize.Show();
                openFileDialogMBpic.FileName = "";

                MBpicboxsetsizemode(pictureMB);
                if (pictureMB.SizeMode != PictureBoxSizeMode.CenterImage)
                    labelMBenlarge.Text = "Nhấp để xem kích thước lớn hơn";
                else
                    labelMBenlarge.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi mở tệp :" + ex.Message);
            }
        }

        private void pictureMB_Click(object sender, EventArgs e)
        {

            if (pictureMB.Dock == DockStyle.None)
            {
                pictureMB.Dock = DockStyle.Fill;
                MBpicboxsetsizemode(pictureMB);
            }
            else
            {
                pictureMB.Dock = DockStyle.None;
                MBpicboxsetsizemode(pictureMB);

            }

        }
        public static void MBpicboxsetsizemode(PictureBox pic)
        {

            if (pic.Image == null)
                return;
            if (pic.Image.Size.Height < pic.Size.Height && pic.Image.Size.Width < pic.Size.Width)
            {
                pic.SizeMode = PictureBoxSizeMode.CenterImage;
            }
            else
            {
                pic.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }
        private void picBookCover_Click(object sender, EventArgs e)
        {
            if (picBookCover.Image == null)
                return;
            if (picBookCover.Dock == DockStyle.Fill)
            {
                picBookCover.Dock = DockStyle.None;

                MBpicboxsetsizemode(picBookCover);
                return;
            }
            if (picBookCover.SizeMode == PictureBoxSizeMode.Zoom)
            {
                picBookCover.Dock = DockStyle.Fill;

                MBpicboxsetsizemode(picBookCover);

            }




        }



        private void pictureMB_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMBopenpdf_Click(object sender, EventArgs e)
        {
            try
            {

                long imageFileLength = 0;
                openFileDialogMBpic.Filter = "Pdf Files|*.pdf|All Files|*.*";
                this.openFileDialogMBpic.ShowDialog();
                string strFn = this.openFileDialogMBpic.FileName;
                if (strFn == "")
                    return;

                FileInfo fiImage = new FileInfo(strFn);
                imageFileLength = fiImage.Length;


                textMBpdfurl.Text = strFn;
                labelMBpdfsize.Text = "Size : " + Convert.ToString(Math.Round(imageFileLength / 1024.00, 2)) + " KB ";

                openFileDialogMBpic.Filter = "";
                openFileDialogMBpic.FileName = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void pictureMB_Click_1(object sender, EventArgs e)
        {

        }

        private void btnMBopenfile_Click_1(object sender, EventArgs e)
        {

        }

        private void MBcombobtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MBcombobtype.Text == "Bản cứng")
            {
                textMBpdfurl.Hide();
                labelMBpdfsize.Hide();
                btnMBopenpdf.Hide();

                textMBpdfurl.Clear();
            }
            else
            {
                textMBpdfurl.Show();
                labelMBpdfsize.Show();
                btnMBopenpdf.Show();
            }
        }

        private void btnMBgbooksapi_Click(object sender, EventArgs e)
        {

            if (bform == null)
            {
                bform = new BooksAPIForm();

            }

            bform.ShowDialog();
            textMBtitle.Text = gtitle;
            textMBauthor.Text = gauthor;
            textMBdesc.Text = gdesc;
            textMBpub.Text = gpublisher;
            textMBpage.Text = gpages;
            textMByear.Text = gpubyear;
            textMBisbn.Text = gisbn;
            if (gimg != null)
            {
                pictureMB.Image = gimg;

                MemoryStream ms = new MemoryStream();
                gimg.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byteArrayMBimage = ms.ToArray();

                MBpicboxsetsizemode(pictureMB);
            }
            if (pictureMB.SizeMode != PictureBoxSizeMode.CenterImage)
                labelMBenlarge.Text = "Click to Enlarge";
            else
                labelMBenlarge.Text = "";
        }



        private void textMBenterbid_Click(object sender, EventArgs e)
        {
            this.AcceptButton = btnMBeditdel;
        }



        private void btnMBdelete_Click(object sender, EventArgs e)
        {

        }

        private void btnBDviewebook_Click(object sender, EventArgs e)
        {
            try
            {
                string fpath;
                fpath = @"\Ebooks\" + textBDbookid.Text + ".pdf";

                //fpath = AppDomain.CurrentDomain.BaseDirectory + fpath;
                fpath = datafolder + fpath;


                System.Diagnostics.Process.Start(fpath);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       /* private void btnBDopenpdffolder_Click(object sender, EventArgs e)
        {
            string fpath = @"DownloadedEbooks\" + textBDtitle.Text + " " + textBDbookid.Text + ".pdf";
            string arg = "/select, " + AppDomain.CurrentDomain.BaseDirectory + fpath;

            System.Diagnostics.Process.Start("explorer.exe", arg);
        }*/

        private void panelManageMembers_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMMadd_Click(object sender, EventArgs e)
        {
            frmAddMem add = new frmAddMem();



            DialogResult dr = add.ShowDialog();

            if (dr == DialogResult.OK && LibraryManagementSystem.Properties.Settings.Default.usePackages==true)
            {
                frmSetPackage.openwithmid = newmid;
                frmSetPackage pk = new frmSetPackage();
                pk.ShowDialog();
            
            }

            btnMMviewall_Click(null, null);

            
        }


        private void btnMMviewall_Click(object sender, EventArgs e)
        {
            viewall(0);
        }

        private void viewall(int limit)
        {
            SQLiteCommand cmd = new SQLiteCommand(con);
            SQLiteDataReader dr;

            if(limit==0)
            cmd.CommandText = "SELECT MemberID as 'Mã độc giả',Name as 'Họ tên',RollNo as 'MSSV',Course as 'Khóa',AdmissionYear as 'Năm nhập học',PhoneNumber as 'SĐT',Dob as 'Ngày sinh',Email from MemberDetails ORDER BY MemberID";
            else
                cmd.CommandText = "SELECT MemberID as 'Mã độc giả',Name as 'Họ tên',RollNo as 'MSSV',Course as 'Khóa',AdmissionYear as 'Năm nhập học',PhoneNumber as 'SĐT',Dob as 'Ngày sinh',Email from MemberDetails ORDER BY MemberID limit " + limit.ToString();


            dr = cmd.ExecuteReader();
            if (dr.HasRows == true)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridMM.DataSource = dt;



                lblStatus.Text = "Tìm thấy tất cả " + dt.Rows.Count + " độc giả.";
            }
            else
            {


                lblStatus.Text = "Danh sách độc giả trống.";
                dataGridMM.DataSource = null;
            }
            dr.Close();
        }
        private void mmsearch()
        {
            string searchterm;
            string selectcmd="";
            try
            {
                searchterm = textMMsearchterm.Text;
                if (string.IsNullOrEmpty(searchterm))
                {
                    lblStatus.Text = "Nhập từ khóa để tìm kiếm độc giả.";
                    return;
                }
                if (comboMMfields.Text == "Mã độc giả")
                selectcmd = string.Format("SELECT MemberID as 'Mã độc giả',Name as 'Họ tên',RollNo as 'MSSV',Course as 'Khóa',AdmissionYear as 'Năm nhập học'," +
                    "PhoneNumber as 'SĐT',Dob as 'Ngày sinh',Email  from MemberDetails where MemberID LIKE('%{0}%')", searchterm);
                if (comboMMfields.Text == "Họ tên")
                    selectcmd = string.Format("SELECT MemberID as 'Mã độc giả',Name as 'Họ tên',RollNo as 'MSSV',Course as 'Khóa',AdmissionYear as 'Năm nhập học'," +
                        "PhoneNumber as 'SĐT',Dob as 'Ngày sinh',Email  from MemberDetails where Name LIKE('%{0}%')", searchterm);
                if (comboMMfields.Text == "MSSV")
                    selectcmd = string.Format("SELECT MemberID as 'Mã độc giả',Name as 'Họ tên',RollNo as 'MSSV',Course as 'Khóa',AdmissionYear as 'Năm nhập học'," +
                        "PhoneNumber as 'SĐT',Dob as 'Ngày sinh',Email  from MemberDetails where RollNo LIKE('%{0}%')", searchterm);
                if (comboMMfields.Text == "Khóa")
                    selectcmd = string.Format("SELECT MemberID as 'Mã độc giả',Name as 'Họ tên',RollNo as 'MSSV',Course as 'Khóa',AdmissionYear as 'Năm nhập học'," +
                        "PhoneNumber as 'SĐT',Dob as 'Ngày sinh',Email  from MemberDetails where Course LIKE('%{0}%')", searchterm);
                if (comboMMfields.Text == "Năm nhập học")
                    selectcmd = string.Format("SELECT MemberID as 'Mã độc giả',Name as 'Họ tên',RollNo as 'MSSV',Course as 'Khóa',AdmissionYear as 'Năm nhập học'," +
                        "PhoneNumber as 'SĐT',Dob as 'Ngày sinh',Email  from MemberDetails where AdmissionYear LIKE('%{0}%')", searchterm);
                if (comboMMfields.Text == "SĐT")
                    selectcmd = string.Format("SELECT MemberID as 'Mã độc giả',Name as 'Họ tên',RollNo as 'MSSV',Course as 'Khóa',AdmissionYear as 'Năm nhập học'," +
                        "PhoneNumber as 'SĐT',Dob as 'Ngày sinh',Email  from MemberDetails where PhoneNumber LIKE('%{0}%')", searchterm);
                if (comboMMfields.Text == "Ngày sinh")
                    selectcmd = string.Format("SELECT MemberID as 'Mã độc giả',Name as 'Họ tên',RollNo as 'MSSV',Course as 'Khóa',AdmissionYear as 'Năm nhập học'," +
                        "PhoneNumber as 'SĐT',Dob as 'Ngày sinh',Email  from MemberDetails where Dob LIKE('%{0}%')", searchterm);
                if (comboMMfields.Text == "Email")
                    selectcmd = string.Format("SELECT MemberID as 'Mã độc giả',Name as 'Họ tên',RollNo as 'MSSV',Course as 'Khóa',AdmissionYear as 'Năm nhập học'," +
                        "PhoneNumber as 'SĐT',Dob as 'Ngày sinh',Email  from MemberDetails where Email LIKE('%{0}%')", searchterm);
                SQLiteCommand cmd = new SQLiteCommand(selectcmd, con);
                SQLiteDataReader dr;
                dr = cmd.ExecuteReader();
                if (dr.HasRows == true)
                {
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    dataGridMM.DataSource = dt;



                    lblStatus.Text = string.Format("Tìm thấy {2} độc giả cho từ khóa '{0}' trong mục {1}.", searchterm, comboMMfields.Text, dt.Rows.Count);
                }
                else
                {

                    dataGridMM.DataSource = null;
                    lblStatus.Text = lblStatus.Text = string.Format("Không tìm được độc giả cho từ khóa '{0}' trong mục {1}.", searchterm, comboMMfields.Text);

                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnMMsearch_Click(object sender, EventArgs e)
        {
            
        }

        private void textMMsearchterm_Click(object sender, EventArgs e)
        {
            
        }
        private void idsearch()
        {
            try
            {
                string searchterm;
                string selectcmd="";

                searchterm = textIDsearch.Text;
                if (string.IsNullOrEmpty(searchterm))
                {
                    lblStatus.Text = "Nhập từ khóa để tìm kiếm.";
                    return;
                }

                if (btnIDisudet.BackColor == Color.LightBlue)
                {
                    if(comboIDfield.Text== "Mã cuốn sách")
                        selectcmd = string.Format("select * from IssueDetails where BookID LIKE('%{0}%')", searchterm);
                    if (comboIDfield.Text == "Mã độc giả")
                        selectcmd = string.Format("select * from IssueDetails where MemberID LIKE('%{0}%')", searchterm);
                    if (comboIDfield.Text == "Tựa sách")
                        selectcmd = string.Format("select * from IssueDetails where BookTitle LIKE('%{0}%')", searchterm);
                    if (comboIDfield.Text == "Tên độc giả")
                        selectcmd = string.Format("select * from IssueDetails where MemberName LIKE('%{0}%')", searchterm);
                    if (comboIDfield.Text == "Ngày mượn")
                        selectcmd = string.Format("select * from IssueDetails where IssueDate LIKE('%{0}%')", searchterm);
                    if (comboIDfield.Text == "Ngày hết hạn")
                        selectcmd = string.Format("select * from IssueDetails where DueDate LIKE('%{0}%')", searchterm);
                }
                else
                {
                    //selectcmd = string.Format("select * from SubmittedBooks where {0} LIKE('%{0}%')", searchterm);
                    if (comboIDfield.Text == "Mã cuốn sách")
                        selectcmd = string.Format("select * from IssueDetails where BookID LIKE('%{0}%')", searchterm);
                    if (comboIDfield.Text == "Mã độc giả")
                        selectcmd = string.Format("select * from IssueDetails where MemberID LIKE('%{0}%')", searchterm);
                    if (comboIDfield.Text == "Tựa sách")
                        selectcmd = string.Format("select * from IssueDetails where BookTitle LIKE('%{0}%')", searchterm);
                    if (comboIDfield.Text == "Tên độc giả")
                        selectcmd = string.Format("select * from IssueDetails where MemberName LIKE('%{0}%')", searchterm);
                    if (comboIDfield.Text == "Ngày mượn")
                        selectcmd = string.Format("select * from IssueDetails where IssueDate LIKE('%{0}%')", searchterm);
                    if (comboIDfield.Text == "Ngày hết hạn")
                        selectcmd = string.Format("select * from IssueDetails where DueDate LIKE('%{0}%')", searchterm);
                }
                SQLiteCommand cmd = new SQLiteCommand(con);
                SQLiteDataReader dr;
                cmd.CommandText = selectcmd;
                dr = cmd.ExecuteReader();
                if (dr.HasRows == true)
                {
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    dataGridID.DataSource = dt;

                    textIDbid.Text = dataGridID.SelectedRows[0].Cells["BookID"].Value.ToString();
                    textIDmid.Text = dataGridID.SelectedRows[0].Cells["MemberID"].Value.ToString();
                    textIDtitle.Text = dataGridID.SelectedRows[0].Cells["BookTitle"].Value.ToString();
                    textIDname.Text = dataGridID.SelectedRows[0].Cells["MemberName"].Value.ToString();
                    textIDidate.Text = dataGridID.SelectedRows[0].Cells["IssueDate"].Value.ToString();
                    textIDdd.Text = dataGridID.SelectedRows[0].Cells["DueDate"].Value.ToString();
                    


                    if (btnIDsubdet.BackColor == Color.LightBlue)
                    {

                        textIDsubdate.Text = dataGridID.SelectedRows[0].Cells["SubmitDate"].Value.ToString();
                        textIDfine.Text = dataGridID.SelectedRows[0].Cells["Fine"].Value.ToString();
                    }

                }
                else
                {


                    lblStatus.Text = lblStatus.Text = "Không tìm thấy dữ liệu .";
                    dataGridID.DataSource = null;

                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnIDsearch_Click(object sender, EventArgs e)
        {

            
            
        }

        private void btnBDIssueSub_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBDbookid.Text))
            {
                return;
            }

            textISbid.Text = textBDbookid.Text;
            cmdIssueSubmitBook_Click(null, null);
        }


        private void textIDsearch_Enter(object sender, EventArgs e)
        {
           
        }


        private void btnBDManage_Click(object sender, EventArgs e)
        {
            //textMBenterbid.Text = textBDbookid.Text;
            frmEditBook.bid = textBDbookid.Text;
            frmEditBook eb = new frmEditBook();
            eb.ShowDialog();

            bool BDhasdel = LibraryManagementSystem.Properties.Settings.Default.BookDetails;
            int bookid =readonlyNextID(BDhasdel, "BookDetails");
            textMBbid.Text = bookid.ToString();
        }

        private void btnIDsubmitbook_Click(object sender, EventArgs e)
        {
            textISbid.Text = textIDbid.Text;
            textISmid.Text = textIDmid.Text;
            btnISok_Click(null, null);
            cmdIssueSubmitBook_Click(null, null);
        }

        private void dataGridID_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnIDisudet.BackColor == Color.LightBlue)
                btnIDsubmitbook_Click(null, null);
        }

        private void button2_Click(object sender, EventArgs e)
        {


        }

        private void btnEBviewall_Click(object sender, EventArgs e)
        {
            int res=fillGrid(selectallbooks + " ORDER BY BookID ");
            lblStatus.Text = "Tìm thấy tất cả " + res + " cuốn sách ";
        }


        private void treeViewExplore_Click(object sender, EventArgs e)
        {



        }


        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("width:" + this.Width.ToString() + "height:" + this.Height.ToString());

        }


        private void explore_Search()
        {
            SQLiteCommand com = new SQLiteCommand(con);
            SQLiteDataReader dtr;

            string searchterm;
            string selectcmd="";
            searchterm = textSearchTerm.Text.Replace(" ", "");
            if (string.IsNullOrEmpty(searchterm))
            {
                lblStatus.Text = "Nhập từ khóa tìm kiếm để tìm kiếm sách.";
                return;
            }
            //"SELECT BookID as 'Mã cuốn sách',Title as 'Tựa sách', Author as 'Tác giả', Available as 'Có sẵn'," +
           // "BookNo as 'Mã tựa sách',Category as 'Thể loại',Publisher as 'Nhà xuất bản', Language as 'Ngôn ngữ'," +
            //"Year as 'Năm',Price as 'Giá',Pages as 'Số trang',Shelf as 'Kệ',DateAdded as 'Ngày nhập',Type 'Loại lưu trữ'," +
           // "ISBN as 'Số ISBN' FROM BookDetails ";
            if (comboIDfield.Text == "Mã cuốn sách")
                selectcmd = string.Format(selectallbooks + " where REPLACE( BookID, ' ', '') LIKE('%{0}%')", searchterm);
            if (comboIDfield.Text == "Tựa sách")
                selectcmd = string.Format(selectallbooks + " where REPLACE( Title, ' ', '') LIKE('%{0}%')", searchterm);
            if (comboIDfield.Text == "Tác giả")
                selectcmd = string.Format(selectallbooks + " where REPLACE( Author, ' ', '') LIKE('%{0}%')", searchterm);
            if (comboIDfield.Text == "Mã tựa sách")
                selectcmd = string.Format(selectallbooks + " where REPLACE( BookNo, ' ', '') LIKE('%{0}%')", searchterm);
            if (comboIDfield.Text == "Số ISBN")
                selectcmd = string.Format(selectallbooks + " where REPLACE( ISBN, ' ', '') LIKE('%{0}%')", searchterm);
            if (comboIDfield.Text == "Ngôn ngữ sách")
                selectcmd = string.Format(selectallbooks + " where REPLACE( Language, ' ', '') LIKE('%{0}%')", searchterm);
            if (comboIDfield.Text == "Nhà xuất bản")
                selectcmd = string.Format(selectallbooks + " where REPLACE( Publisher, ' ', '') LIKE('%{0}%')", searchterm);
            if (comboIDfield.Text == "Kệ sách")
                selectcmd = string.Format(selectallbooks + " where REPLACE( Shelf, ' ', '') LIKE('%{0}%')", searchterm);
            if (comboIDfield.Text == "Loại lưu trữ")
                selectcmd = string.Format(selectallbooks + " where REPLACE( Type, ' ', '') LIKE('%{0}%')", searchterm);
            if (comboIDfield.Text == "Ngày nhập sách")
                selectcmd = string.Format(selectallbooks + " where REPLACE( DateAdded, ' ', '') LIKE('%{0}%')", searchterm);
            if (comboIDfield.Text == "Năm phát hành")
                selectcmd = string.Format(selectallbooks + " where REPLACE( Year, ' ', '') LIKE('%{0}%')", searchterm);

            com.CommandText = selectcmd;
            dtr = com.ExecuteReader();
            if (dtr.HasRows == true)
            {
                DataTable dt = new DataTable();
                dt.Load(dtr);
                dtr.Close();
                gridviewExplore.DataSource = dt;


                lblStatus.Text = string.Format("Tìm thấy {2} sách cho từ khóa '{0}' trong mục {1} .", searchterm, comboSearchFields.Text, dt.Rows.Count);
            }
            else
            {

                gridviewExplore.DataSource = null;
                lblStatus.Text = lblStatus.Text = string.Format("Không tìm thấy sách cho từ từ khóa '{0}' trong mục {1}.", searchterm, comboSearchFields.Text);

            }

        }
        private void textSearchTerm_TextChanged(object sender, EventArgs e)
        {
            explore_Search();

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void cmdMenu_Click(object sender, EventArgs e)
        {

            navigate(cmdMenu);
            panelExtraMenu.BringToFront();
        }



        private void btnMMdetails_Click(object sender, EventArgs e)
        {
            if (dataGridMM.RowCount == 0)
                return;

            frmMemberDetails.openwithmid = dataGridMM.SelectedRows[0].Cells["Mã độc giả"].Value.ToString();
            frmMemberDetails md = new frmMemberDetails();
            md.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (dataGridMM.RowCount == 0)
                return;

            frmSetPackage.openwithmid = dataGridMM.SelectedRows[0].Cells["Mã độc giả"].Value.ToString();
            frmSetPackage pf = new frmSetPackage();
            pf.ShowDialog();
            lblStatus.Text = msg;
        }

        private void btnEditDetails_Click(object sender, EventArgs e)
        {
            if (dataGridMM.RowCount == 0)
                return;
            frmEditMembers.openwithmid = dataGridMM.SelectedRows[0].Cells["Mã độc giả"].Value.ToString();
            frmEditMembers em = new frmEditMembers();
            em.ShowDialog();
            btnMMviewall_Click(null, null);
        }

        private void btnMenuAbout_Click(object sender, EventArgs e)
        {
            SplashForm.focusclose = true;
            SplashForm sf = new SplashForm();
            sf.Show();
        }

        private void btnMenuCateg_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(Properties.Settings.Default.adminFirstUse.ToString());
           // MessageBox.Show(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
            frmCategories cat = new frmCategories();
            cat.ShowDialog();
            loadCategory();
            if (string.IsNullOrEmpty(Properties.Settings.Default.defaultcateg.ToString()))
            {
                if(comboMBcateg.Items.Count!=0)
                comboMBcateg.SelectedIndex = 0;
            }
            else
            {
                comboMBcateg.SelectedItem = Properties.Settings.Default.defaultcateg.ToString();
            }

        }

        private void btnMBclear_Click(object sender, EventArgs e)
        {
            MBclear();
        }


        private void btnMenuLang_Click(object sender, EventArgs e)
        {
            frmLang la = new frmLang();
            la.ShowDialog();
            loadlang();

        }

        private void btnMenuPackages_Click(object sender, EventArgs e)
        {
            frmPackages pkg = new frmPackages();
            pkg.ShowDialog();
        }

        private void btnMenuUsers_Click(object sender, EventArgs e)
        {
            frmManageUsers mu = new frmManageUsers();
            mu.ShowDialog();
        }

        private void dataGridID_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateIDdd_ValueChanged(object sender, EventArgs e)
        {
        }

        private void lblStatus_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void btnMenuUserDetails_Click(object sender, EventArgs e)
        {
            //frmUserDetails ud = new frmUserDetails();
            //ud.ShowDialog();

            using (var ud = new frmUserDetails())
            {
                if (ud.ShowDialog() != DialogResult.OK)
                    return;
            }
        }

        private void dataGridMM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridMM_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridMM.RowCount == 0)
                return;

            frmMemberDetails.openwithmid = dataGridMM.SelectedRows[0].Cells["MemberID"].Value.ToString();
            frmMemberDetails md = new frmMemberDetails();
            md.Show();
        }

        private void dataGridMM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           


        }

        private void btnMenuOptions_Click(object sender, EventArgs e)
        {
            frmOptions opt = new frmOptions();
            opt.ShowDialog();
        }

        private void comboSearchFields_SelectedIndexChanged(object sender, EventArgs e)
        {
            explore_Search();
        }

        private void treeViewExplore_Leave(object sender, EventArgs e)
        {
            treeViewExplore.SelectedNode = null;
        }

        private void textSearchTerm_Enter(object sender, EventArgs e)
        {
            explore_Search();
        }

        private void btnIDextendDD_Click(object sender, EventArgs e)
        {
            DateTime dt = Convert.ToDateTime(textIDdd.Text, System.Globalization.CultureInfo.CreateSpecificCulture("en-IN").DateTimeFormat);
            frmExtendDueDate dd = new frmExtendDueDate(dt, textIDbid.Text, textIDmid.Text);

            DialogResult dr = dd.ShowDialog();

            if (dr == DialogResult.OK)
            {
                dataGridID.SelectedRows[0].Cells["DueDate"].Value = dd.returndate;
                textIDdd.Text = dd.returndate;
            }
       
            //end of class MainForm
        }

        private void textIDsearch_TextChanged(object sender, EventArgs e)
        {
            idsearch();
        }

        private void comboIDfield_SelectedIndexChanged(object sender, EventArgs e)
        {
            idsearch();
        }

        private void textIDsearch_Enter_1(object sender, EventArgs e)
        {
            idsearch();
        }

        private void comboMMfields_SelectedIndexChanged(object sender, EventArgs e)
        {
            mmsearch();
        }

        private void textMMsearchterm_TextChanged(object sender, EventArgs e)
        {
            mmsearch();
        }

        private void textMMsearchterm_Enter(object sender, EventArgs e)
        {
            mmsearch();
        }

        private void btnMBcopy_Click(object sender, EventArgs e)
        {
            frmBookCopy bc = new frmBookCopy();

            DialogResult drs = bc.ShowDialog();
            string bn="";
            if (drs == DialogResult.OK)
            {
              bn = bc.returnbn;
                
            }


            //code for bookdetails




            object retval=null;
            byte[] img = null;

            string price = "";
            if (String.IsNullOrEmpty(bn))
            {
                
                return;
            }
            string cmdtext = String.Format("select * from BookDetails where BookNo='{0}';", bn);
            SQLiteCommand cmd = new SQLiteCommand(cmdtext, con);

            SQLiteDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows == false)
            {
               
                dr.Close();
                return;
            }

            while (dr.Read())
            {

              
                textMBisbn.Text = dr["ISBN"].ToString();
                textMBbookno.Text = dr["BookNo"].ToString();
                textMBtitle.Text = dr["Title"].ToString();
                textMBauthor.Text = dr["Author"].ToString();
                comboMBcateg.Text= dr["Category"].ToString();
               textMBdesc.Text= dr["Description"].ToString();

               textMByear.Text = dr["Year"].ToString();
                textMBpub.Text= dr["Publisher"].ToString();
               comboMBlang.Text = dr["Language"].ToString();
                price = dr["Price"].ToString();
               textMBpage.Text= dr["Pages"].ToString();
               textMBshelf.Text= dr["Shelf"].ToString();
               MBcombobtype.Text = dr["Type"].ToString();
               textMBdateadd.Text = dr["DateAdded"].ToString();
                retval = dr["Image"];
               

            }


            if (!(retval is DBNull))
            {
                img = (byte[])retval;
                System.IO.MemoryStream myMemoryStream = new System.IO.MemoryStream(img);
                System.Drawing.Image myImage = System.Drawing.Image.FromStream(myMemoryStream);
               pictureMB.Image = myImage;

               MemoryStream ms = new MemoryStream();
               pictureMB.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
               byteArrayMBimage = ms.GetBuffer();
                /*
               ImageConverter converter = new ImageConverter();
               byteArrayMBimage=(byte[])converter.ConvertTo(pictureMB.Image, typeof(byte[]));
                */

                MBpicboxsetsizemode(pictureMB);
                if (pictureMB.SizeMode == PictureBoxSizeMode.Zoom)
                    labelMBenlarge.Text = "Click to Enlarge";
                else
                    labelMBenlarge.Text= "";

            }
            else
            {
                labelMBenlarge.Text = "";
            }
    
            

            textBDprice.Text = price;

        }

        private void btnEBissret_Click(object sender, EventArgs e)
        {
            if (gridviewExplore.RowCount == 0)
                return;
            textISbid.Text = gridviewExplore.SelectedRows[0].Cells["BookID"].Value.ToString();
            cmdIssueSubmitBook_Click(null, null);
        }

        private void btnMMissret_Click(object sender, EventArgs e)
        {
            if (dataGridMM.RowCount == 0)
                return;
            textISmid.Text = dataGridMM.SelectedRows[0].Cells["Mã độc giả"].Value.ToString();
            cmdIssueSubmitBook_Click(null, null);
        }

        private void panelExtraMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMenuLibInfo_Click(object sender, EventArgs e)
        {
            frmLibInfo li = new frmLibInfo();
            li.ShowDialog();
        }

        private void lblUsersStatus_Click(object sender, EventArgs e)
        {

        }

       
        
        private void btnMenuExport_Click(object sender, EventArgs e)
        {
            frmExport ex = new frmExport();
            ex.ShowDialog();
        }

        private void btnMMBooksToSubmit_Click(object sender, EventArgs e)
        {
            if (dataGridMM.RowCount == 0)
                return;
            textIDsearch.Text= dataGridMM.SelectedRows[0].Cells["Mã độc giả"].Value.ToString();
            comboIDfield.Text = "MemberID";
            cmdIssueDetails_Click(null, null);
        }

        private void btnMenuHelp_Click(object sender, EventArgs e)
        {
            try
            {
                string fpath;
                fpath = @"\lmshelp.chm";

                fpath = datafolder + fpath;


                System.Diagnostics.Process.Start(fpath);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboMBcateg_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(comboMBcateg.Text))
            {
                return;
            }
           
            SQLiteCommand com = new SQLiteCommand(con);
            com.CommandText = String.Format("select Shelf from Categories where Category='{0}';",comboMBcateg.Text);
         

            string shelf = com.ExecuteScalar().ToString();
            textMBshelf.Text = shelf;
        }

        private void MainForm_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void btnMenuLang_Click_1(object sender, EventArgs e)
        {

        }

        private void btnMenuCourses_Click(object sender, EventArgs e)
        {
            frmCourses cs = new frmCourses();
            cs.ShowDialog();
        }

        private void btnMMexploreMembers_Click(object sender, EventArgs e)
        {
            frmExploreMembers em = new frmExploreMembers();
            em.ShowDialog();
        }

        private void btnBDebookfolder_Click(object sender, EventArgs e)
        {
            try
            {
                string fpath;
                fpath = @"\Ebooks\" ;

                //fpath = AppDomain.CurrentDomain.BaseDirectory + fpath;
                fpath = datafolder + fpath;


                System.Diagnostics.Process.Start(fpath);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       

        
        


    }
    public static class StringCipher
    {
        public static string enckey="87hjsi$hs8jnglwoxhjk";
        // This constant string is used as a "salt" value for the PasswordDeriveBytes function calls.
        // This size of the IV (in bytes) must = (keysize / 8).  Default keysize is 256, so the IV must be
        // 32 bytes long.  Using a 16 character string here gives us 32 bytes when converted to a byte array.
        private static readonly byte[] initVectorBytes = Encoding.ASCII.GetBytes("tu89geji340t89u2");

        // This constant is used to determine the keysize of the encryption algorithm.
        private const int keysize = 256;

        public static string Encrypt(string plainText, string passPhrase)
        {
            byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            PasswordDeriveBytes password = new PasswordDeriveBytes(passPhrase, null);

            byte[] keyBytes = password.GetBytes(keysize / 8);
            using (RijndaelManaged symmetricKey = new RijndaelManaged())
            {
                symmetricKey.Mode = CipherMode.CBC;
                using (ICryptoTransform encryptor = symmetricKey.CreateEncryptor(keyBytes, initVectorBytes))
                {
                    using (MemoryStream memoryStream = new MemoryStream())
                    {
                        using (CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                        {
                            cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
                            cryptoStream.FlushFinalBlock();
                            byte[] cipherTextBytes = memoryStream.ToArray();
                            return Convert.ToBase64String(cipherTextBytes);
                        }
                    }
                }
            }

        }

        public static string Decrypt(string cipherText, string passPhrase)
        {
            byte[] cipherTextBytes = Convert.FromBase64String(cipherText);
            PasswordDeriveBytes password = new PasswordDeriveBytes(passPhrase, null);

            byte[] keyBytes = password.GetBytes(keysize / 8);
            using (RijndaelManaged symmetricKey = new RijndaelManaged())
            {
                symmetricKey.Mode = CipherMode.CBC;
                using (ICryptoTransform decryptor = symmetricKey.CreateDecryptor(keyBytes, initVectorBytes))
                {
                    using (MemoryStream memoryStream = new MemoryStream(cipherTextBytes))
                    {
                        using (CryptoStream cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read))
                        {
                            byte[] plainTextBytes = new byte[cipherTextBytes.Length];
                            int decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
                            return Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount);
                        }
                    }
                }
            }

        }
    }
}


   
    

