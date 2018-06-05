namespace LibraryManagementSystem
{
    partial class frmEditBook
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditBook));
            this.lblStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMBenterid = new System.Windows.Forms.TextBox();
            this.btnMBeditdel = new System.Windows.Forms.Button();
            this.pictureMB = new System.Windows.Forms.PictureBox();
            this.textMBauthor = new System.Windows.Forms.TextBox();
            this.comboMBcateg = new System.Windows.Forms.ComboBox();
            this.comboMBlang = new System.Windows.Forms.ComboBox();
            this.btnMBopenpdf = new System.Windows.Forms.Button();
            this.labelMBpdfsize = new System.Windows.Forms.Label();
            this.textMBpdfurl = new System.Windows.Forms.TextBox();
            this.MBcombobtype = new System.Windows.Forms.ComboBox();
            this.label48 = new System.Windows.Forms.Label();
            this.labelMBpicsize = new System.Windows.Forms.Label();
            this.btnMBgbooksapi = new System.Windows.Forms.Button();
            this.btnMBopenfile = new System.Windows.Forms.Button();
            this.label34 = new System.Windows.Forms.Label();
            this.textMBimgurl = new System.Windows.Forms.TextBox();
            this.textMBdesc = new System.Windows.Forms.TextBox();
            this.btnMBdelete = new System.Windows.Forms.Button();
            this.label32 = new System.Windows.Forms.Label();
            this.btnMBeditsave = new System.Windows.Forms.Button();
            this.label33 = new System.Windows.Forms.Label();
            this.textMBdateadd = new System.Windows.Forms.TextBox();
            this.textMBshelf = new System.Windows.Forms.TextBox();
            this.textMBpage = new System.Windows.Forms.TextBox();
            this.textMBisbn = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.textMBprice = new System.Windows.Forms.TextBox();
            this.textMBpub = new System.Windows.Forms.TextBox();
            this.textMByear = new System.Windows.Forms.TextBox();
            this.textMBtitle = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.openFileDialogMBpic = new System.Windows.Forms.OpenFileDialog();
            this.BDlabelenlarge = new System.Windows.Forms.Label();
            this.textMBbookno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textMBbid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMB)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.BackColor = System.Drawing.Color.Lavender;
            this.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStatus.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(1, 711);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(1350, 36);
            this.lblStatus.TabIndex = 186;
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 23);
            this.label1.TabIndex = 185;
            this.label1.Text = "Nhập Mã cuốn sách :";
            // 
            // txtMBenterid
            // 
            this.txtMBenterid.AcceptsReturn = true;
            this.txtMBenterid.BackColor = System.Drawing.SystemColors.Window;
            this.txtMBenterid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMBenterid.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMBenterid.Location = new System.Drawing.Point(333, 24);
            this.txtMBenterid.Margin = new System.Windows.Forms.Padding(4);
            this.txtMBenterid.Name = "txtMBenterid";
            this.txtMBenterid.Size = new System.Drawing.Size(317, 30);
            this.txtMBenterid.TabIndex = 0;
            // 
            // btnMBeditdel
            // 
            this.btnMBeditdel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMBeditdel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMBeditdel.Location = new System.Drawing.Point(675, 13);
            this.btnMBeditdel.Margin = new System.Windows.Forms.Padding(4);
            this.btnMBeditdel.Name = "btnMBeditdel";
            this.btnMBeditdel.Size = new System.Drawing.Size(286, 48);
            this.btnMBeditdel.TabIndex = 21;
            this.btnMBeditdel.Text = "Tìm kiếm";
            this.btnMBeditdel.UseVisualStyleBackColor = true;
            this.btnMBeditdel.Click += new System.EventHandler(this.btnMBeditdel_Click);
            // 
            // pictureMB
            // 
            this.pictureMB.BackColor = System.Drawing.Color.Transparent;
            this.pictureMB.Location = new System.Drawing.Point(1072, 13);
            this.pictureMB.Margin = new System.Windows.Forms.Padding(4);
            this.pictureMB.Name = "pictureMB";
            this.pictureMB.Size = new System.Drawing.Size(255, 369);
            this.pictureMB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureMB.TabIndex = 174;
            this.pictureMB.TabStop = false;
            this.pictureMB.Click += new System.EventHandler(this.pictureMB_Click);
            // 
            // textMBauthor
            // 
            this.textMBauthor.BackColor = System.Drawing.SystemColors.Window;
            this.textMBauthor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textMBauthor.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMBauthor.Location = new System.Drawing.Point(172, 238);
            this.textMBauthor.Margin = new System.Windows.Forms.Padding(4);
            this.textMBauthor.Name = "textMBauthor";
            this.textMBauthor.Size = new System.Drawing.Size(683, 30);
            this.textMBauthor.TabIndex = 4;
            // 
            // comboMBcateg
            // 
            this.comboMBcateg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMBcateg.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboMBcateg.FormattingEnabled = true;
            this.comboMBcateg.Location = new System.Drawing.Point(172, 459);
            this.comboMBcateg.Margin = new System.Windows.Forms.Padding(4);
            this.comboMBcateg.Name = "comboMBcateg";
            this.comboMBcateg.Size = new System.Drawing.Size(320, 31);
            this.comboMBcateg.TabIndex = 6;
            this.comboMBcateg.SelectedIndexChanged += new System.EventHandler(this.comboMBcateg_SelectedIndexChanged);
            // 
            // comboMBlang
            // 
            this.comboMBlang.BackColor = System.Drawing.SystemColors.Window;
            this.comboMBlang.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboMBlang.FormattingEnabled = true;
            this.comboMBlang.Items.AddRange(new object[] {
            "English",
            "Malayalam"});
            this.comboMBlang.Location = new System.Drawing.Point(172, 533);
            this.comboMBlang.Margin = new System.Windows.Forms.Padding(4);
            this.comboMBlang.Name = "comboMBlang";
            this.comboMBlang.Size = new System.Drawing.Size(244, 31);
            this.comboMBlang.TabIndex = 11;
            // 
            // btnMBopenpdf
            // 
            this.btnMBopenpdf.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMBopenpdf.Location = new System.Drawing.Point(1072, 647);
            this.btnMBopenpdf.Margin = new System.Windows.Forms.Padding(4);
            this.btnMBopenpdf.Name = "btnMBopenpdf";
            this.btnMBopenpdf.Size = new System.Drawing.Size(135, 44);
            this.btnMBopenpdf.TabIndex = 17;
            this.btnMBopenpdf.Tag = "";
            this.btnMBopenpdf.Text = "Thêm file PDF";
            this.btnMBopenpdf.UseVisualStyleBackColor = true;
            this.btnMBopenpdf.Click += new System.EventHandler(this.btnMBopenpdf_Click);
            // 
            // labelMBpdfsize
            // 
            this.labelMBpdfsize.AutoSize = true;
            this.labelMBpdfsize.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMBpdfsize.Location = new System.Drawing.Point(889, 661);
            this.labelMBpdfsize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMBpdfsize.Name = "labelMBpdfsize";
            this.labelMBpdfsize.Size = new System.Drawing.Size(50, 23);
            this.labelMBpdfsize.TabIndex = 181;
            this.labelMBpdfsize.Text = "Size:";
            // 
            // textMBpdfurl
            // 
            this.textMBpdfurl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textMBpdfurl.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMBpdfurl.Location = new System.Drawing.Point(413, 658);
            this.textMBpdfurl.Margin = new System.Windows.Forms.Padding(4);
            this.textMBpdfurl.Name = "textMBpdfurl";
            this.textMBpdfurl.Size = new System.Drawing.Size(445, 30);
            this.textMBpdfurl.TabIndex = 154;
            // 
            // MBcombobtype
            // 
            this.MBcombobtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MBcombobtype.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MBcombobtype.FormattingEnabled = true;
            this.MBcombobtype.Items.AddRange(new object[] {
            "Bản cứng",
            "Ebook",
            "Bản cứng và Ebook"});
            this.MBcombobtype.Location = new System.Drawing.Point(172, 657);
            this.MBcombobtype.Margin = new System.Windows.Forms.Padding(4);
            this.MBcombobtype.Name = "MBcombobtype";
            this.MBcombobtype.Size = new System.Drawing.Size(203, 31);
            this.MBcombobtype.TabIndex = 16;
            this.MBcombobtype.SelectedIndexChanged += new System.EventHandler(this.MBcombobtype_SelectedIndexChanged);
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label48.Location = new System.Drawing.Point(8, 667);
            this.label48.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(120, 23);
            this.label48.TabIndex = 180;
            this.label48.Text = "Loại lưu trữ :";
            // 
            // labelMBpicsize
            // 
            this.labelMBpicsize.AutoSize = true;
            this.labelMBpicsize.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMBpicsize.Location = new System.Drawing.Point(1136, 476);
            this.labelMBpicsize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMBpicsize.Name = "labelMBpicsize";
            this.labelMBpicsize.Size = new System.Drawing.Size(50, 23);
            this.labelMBpicsize.TabIndex = 179;
            this.labelMBpicsize.Text = "Size:";
            // 
            // btnMBgbooksapi
            // 
            this.btnMBgbooksapi.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMBgbooksapi.Location = new System.Drawing.Point(873, 219);
            this.btnMBgbooksapi.Margin = new System.Windows.Forms.Padding(4);
            this.btnMBgbooksapi.Name = "btnMBgbooksapi";
            this.btnMBgbooksapi.Size = new System.Drawing.Size(172, 110);
            this.btnMBgbooksapi.TabIndex = 19;
            this.btnMBgbooksapi.Text = "Lấy thông tin sách từ Google Books";
            this.btnMBgbooksapi.UseVisualStyleBackColor = true;
            this.btnMBgbooksapi.Click += new System.EventHandler(this.btnMBgbooksapi_Click);
            // 
            // btnMBopenfile
            // 
            this.btnMBopenfile.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMBopenfile.Location = new System.Drawing.Point(1128, 422);
            this.btnMBopenfile.Margin = new System.Windows.Forms.Padding(4);
            this.btnMBopenfile.Name = "btnMBopenfile";
            this.btnMBopenfile.Size = new System.Drawing.Size(135, 44);
            this.btnMBopenfile.TabIndex = 8;
            this.btnMBopenfile.Text = "Thêm hình ảnh";
            this.btnMBopenfile.UseVisualStyleBackColor = true;
            this.btnMBopenfile.Click += new System.EventHandler(this.btnMBopenfile_Click);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(8, 618);
            this.label34.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(131, 23);
            this.label34.TabIndex = 176;
            this.label34.Text = "Ảnh bìa sách :";
            // 
            // textMBimgurl
            // 
            this.textMBimgurl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textMBimgurl.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMBimgurl.Location = new System.Drawing.Point(172, 614);
            this.textMBimgurl.Margin = new System.Windows.Forms.Padding(4);
            this.textMBimgurl.Name = "textMBimgurl";
            this.textMBimgurl.Size = new System.Drawing.Size(515, 30);
            this.textMBimgurl.TabIndex = 15;
            // 
            // textMBdesc
            // 
            this.textMBdesc.BackColor = System.Drawing.SystemColors.Window;
            this.textMBdesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textMBdesc.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMBdesc.Location = new System.Drawing.Point(172, 276);
            this.textMBdesc.Margin = new System.Windows.Forms.Padding(4);
            this.textMBdesc.Multiline = true;
            this.textMBdesc.Name = "textMBdesc";
            this.textMBdesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textMBdesc.Size = new System.Drawing.Size(686, 171);
            this.textMBdesc.TabIndex = 5;
            // 
            // btnMBdelete
            // 
            this.btnMBdelete.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMBdelete.Location = new System.Drawing.Point(873, 101);
            this.btnMBdelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnMBdelete.Name = "btnMBdelete";
            this.btnMBdelete.Size = new System.Drawing.Size(172, 110);
            this.btnMBdelete.TabIndex = 20;
            this.btnMBdelete.Text = "Xóa sách";
            this.btnMBdelete.UseVisualStyleBackColor = true;
            this.btnMBdelete.Click += new System.EventHandler(this.btnMBdelete_Click);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(8, 278);
            this.label32.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(70, 23);
            this.label32.TabIndex = 173;
            this.label32.Text = "Mô tả :";
            // 
            // btnMBeditsave
            // 
            this.btnMBeditsave.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMBeditsave.Location = new System.Drawing.Point(873, 337);
            this.btnMBeditsave.Margin = new System.Windows.Forms.Padding(4);
            this.btnMBeditsave.Name = "btnMBeditsave";
            this.btnMBeditsave.Size = new System.Drawing.Size(172, 110);
            this.btnMBeditsave.TabIndex = 18;
            this.btnMBeditsave.Text = "Lưu các \r\nthay đổi";
            this.btnMBeditsave.UseVisualStyleBackColor = true;
            this.btnMBeditsave.Click += new System.EventHandler(this.btnMBeditsave_Click);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(8, 464);
            this.label33.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(89, 23);
            this.label33.TabIndex = 163;
            this.label33.Text = "Thể loại :";
            // 
            // textMBdateadd
            // 
            this.textMBdateadd.BackColor = System.Drawing.SystemColors.Window;
            this.textMBdateadd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textMBdateadd.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMBdateadd.Location = new System.Drawing.Point(928, 562);
            this.textMBdateadd.Margin = new System.Windows.Forms.Padding(4);
            this.textMBdateadd.Name = "textMBdateadd";
            this.textMBdateadd.Size = new System.Drawing.Size(142, 30);
            this.textMBdateadd.TabIndex = 14;
            // 
            // textMBshelf
            // 
            this.textMBshelf.BackColor = System.Drawing.SystemColors.Window;
            this.textMBshelf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textMBshelf.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMBshelf.Location = new System.Drawing.Point(928, 527);
            this.textMBshelf.Margin = new System.Windows.Forms.Padding(4);
            this.textMBshelf.Name = "textMBshelf";
            this.textMBshelf.Size = new System.Drawing.Size(142, 30);
            this.textMBshelf.TabIndex = 12;
            // 
            // textMBpage
            // 
            this.textMBpage.BackColor = System.Drawing.SystemColors.Window;
            this.textMBpage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textMBpage.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMBpage.Location = new System.Drawing.Point(928, 492);
            this.textMBpage.Margin = new System.Windows.Forms.Padding(4);
            this.textMBpage.Name = "textMBpage";
            this.textMBpage.Size = new System.Drawing.Size(142, 30);
            this.textMBpage.TabIndex = 10;
            // 
            // textMBisbn
            // 
            this.textMBisbn.BackColor = System.Drawing.SystemColors.Window;
            this.textMBisbn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textMBisbn.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMBisbn.Location = new System.Drawing.Point(661, 111);
            this.textMBisbn.Margin = new System.Windows.Forms.Padding(4);
            this.textMBisbn.Name = "textMBisbn";
            this.textMBisbn.Size = new System.Drawing.Size(197, 30);
            this.textMBisbn.TabIndex = 2;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(8, 76);
            this.label36.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(139, 23);
            this.label36.TabIndex = 172;
            this.label36.Text = "Mã cuốn sách :";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(511, 112);
            this.label37.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(98, 23);
            this.label37.TabIndex = 171;
            this.label37.Text = "Số ISBN  :";
            // 
            // textMBprice
            // 
            this.textMBprice.BackColor = System.Drawing.SystemColors.Window;
            this.textMBprice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textMBprice.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMBprice.Location = new System.Drawing.Point(172, 574);
            this.textMBprice.Margin = new System.Windows.Forms.Padding(4);
            this.textMBprice.Name = "textMBprice";
            this.textMBprice.Size = new System.Drawing.Size(129, 30);
            this.textMBprice.TabIndex = 13;
            // 
            // textMBpub
            // 
            this.textMBpub.BackColor = System.Drawing.SystemColors.Window;
            this.textMBpub.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textMBpub.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMBpub.Location = new System.Drawing.Point(172, 497);
            this.textMBpub.Margin = new System.Windows.Forms.Padding(4);
            this.textMBpub.Name = "textMBpub";
            this.textMBpub.Size = new System.Drawing.Size(454, 30);
            this.textMBpub.TabIndex = 9;
            // 
            // textMByear
            // 
            this.textMByear.BackColor = System.Drawing.SystemColors.Window;
            this.textMByear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textMByear.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMByear.Location = new System.Drawing.Point(928, 458);
            this.textMByear.Margin = new System.Windows.Forms.Padding(4);
            this.textMByear.Name = "textMByear";
            this.textMByear.Size = new System.Drawing.Size(142, 30);
            this.textMByear.TabIndex = 7;
            // 
            // textMBtitle
            // 
            this.textMBtitle.BackColor = System.Drawing.SystemColors.Window;
            this.textMBtitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textMBtitle.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMBtitle.Location = new System.Drawing.Point(172, 149);
            this.textMBtitle.Margin = new System.Windows.Forms.Padding(4);
            this.textMBtitle.Multiline = true;
            this.textMBtitle.Name = "textMBtitle";
            this.textMBtitle.Size = new System.Drawing.Size(682, 67);
            this.textMBtitle.TabIndex = 3;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.Location = new System.Drawing.Point(793, 564);
            this.label38.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(115, 23);
            this.label38.TabIndex = 170;
            this.label38.Text = "Ngày nhập :";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.Location = new System.Drawing.Point(864, 529);
            this.label39.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(44, 23);
            this.label39.TabIndex = 169;
            this.label39.Text = "Kệ :";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.Location = new System.Drawing.Point(813, 494);
            this.label40.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(95, 23);
            this.label40.TabIndex = 168;
            this.label40.Text = "Số trang :";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.Location = new System.Drawing.Point(8, 587);
            this.label41.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(50, 23);
            this.label41.TabIndex = 167;
            this.label41.Text = "Giá :";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.Location = new System.Drawing.Point(8, 545);
            this.label42.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(93, 23);
            this.label42.TabIndex = 166;
            this.label42.Text = "Language";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.Location = new System.Drawing.Point(8, 508);
            this.label43.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(137, 23);
            this.label43.TabIndex = 165;
            this.label43.Text = "Nhà xuất bản :";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.Location = new System.Drawing.Point(753, 460);
            this.label44.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(155, 23);
            this.label44.TabIndex = 164;
            this.label44.Text = "Năm phát hành :";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.Location = new System.Drawing.Point(8, 241);
            this.label45.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(84, 23);
            this.label45.TabIndex = 162;
            this.label45.Text = "Tác giả :";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.Location = new System.Drawing.Point(8, 158);
            this.label46.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(100, 23);
            this.label46.TabIndex = 160;
            this.label46.Text = "Tựa sách :";
            // 
            // BDlabelenlarge
            // 
            this.BDlabelenlarge.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BDlabelenlarge.Location = new System.Drawing.Point(1072, 385);
            this.BDlabelenlarge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BDlabelenlarge.Name = "BDlabelenlarge";
            this.BDlabelenlarge.Size = new System.Drawing.Size(255, 25);
            this.BDlabelenlarge.TabIndex = 187;
            this.BDlabelenlarge.Text = "Nhấp để xem kích thước lớn hơn";
            this.BDlabelenlarge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textMBbookno
            // 
            this.textMBbookno.BackColor = System.Drawing.SystemColors.Window;
            this.textMBbookno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textMBbookno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textMBbookno.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMBbookno.Location = new System.Drawing.Point(172, 110);
            this.textMBbookno.Margin = new System.Windows.Forms.Padding(4);
            this.textMBbookno.Name = "textMBbookno";
            this.textMBbookno.Size = new System.Drawing.Size(317, 30);
            this.textMBbookno.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 23);
            this.label2.TabIndex = 189;
            this.label2.Text = "Mã tựa sách :";
            // 
            // textMBbid
            // 
            this.textMBbid.AutoSize = true;
            this.textMBbid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textMBbid.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMBbid.Location = new System.Drawing.Point(172, 74);
            this.textMBbid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.textMBbid.Name = "textMBbid";
            this.textMBbid.Size = new System.Drawing.Size(42, 25);
            this.textMBbid.TabIndex = 190;
            this.textMBbid.Text = "000";
            // 
            // frmEditBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 753);
            this.Controls.Add(this.pictureMB);
            this.Controls.Add(this.textMBbid);
            this.Controls.Add(this.textMBbookno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BDlabelenlarge);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMBenterid);
            this.Controls.Add(this.btnMBeditdel);
            this.Controls.Add(this.textMBauthor);
            this.Controls.Add(this.comboMBcateg);
            this.Controls.Add(this.comboMBlang);
            this.Controls.Add(this.btnMBopenpdf);
            this.Controls.Add(this.labelMBpdfsize);
            this.Controls.Add(this.textMBpdfurl);
            this.Controls.Add(this.MBcombobtype);
            this.Controls.Add(this.label48);
            this.Controls.Add(this.labelMBpicsize);
            this.Controls.Add(this.btnMBgbooksapi);
            this.Controls.Add(this.btnMBopenfile);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.textMBimgurl);
            this.Controls.Add(this.textMBdesc);
            this.Controls.Add(this.btnMBdelete);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.btnMBeditsave);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.textMBdateadd);
            this.Controls.Add(this.textMBshelf);
            this.Controls.Add(this.textMBpage);
            this.Controls.Add(this.textMBisbn);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.label37);
            this.Controls.Add(this.textMBprice);
            this.Controls.Add(this.textMBpub);
            this.Controls.Add(this.textMByear);
            this.Controls.Add(this.textMBtitle);
            this.Controls.Add(this.label38);
            this.Controls.Add(this.label39);
            this.Controls.Add(this.label40);
            this.Controls.Add(this.label41);
            this.Controls.Add(this.label42);
            this.Controls.Add(this.label43);
            this.Controls.Add(this.label44);
            this.Controls.Add(this.label45);
            this.Controls.Add(this.label46);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmEditBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chỉnh sửa hoặc Xóa sách";
            this.Load += new System.EventHandler(this.frmEditBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureMB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMBenterid;
        private System.Windows.Forms.Button btnMBeditdel;
        private System.Windows.Forms.PictureBox pictureMB;
        private System.Windows.Forms.TextBox textMBauthor;
        private System.Windows.Forms.ComboBox comboMBcateg;
        private System.Windows.Forms.ComboBox comboMBlang;
        private System.Windows.Forms.Button btnMBopenpdf;
        private System.Windows.Forms.Label labelMBpdfsize;
        private System.Windows.Forms.TextBox textMBpdfurl;
        private System.Windows.Forms.ComboBox MBcombobtype;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label labelMBpicsize;
        private System.Windows.Forms.Button btnMBgbooksapi;
        private System.Windows.Forms.Button btnMBopenfile;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox textMBimgurl;
        private System.Windows.Forms.TextBox textMBdesc;
        private System.Windows.Forms.Button btnMBdelete;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Button btnMBeditsave;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox textMBdateadd;
        private System.Windows.Forms.TextBox textMBshelf;
        private System.Windows.Forms.TextBox textMBpage;
        private System.Windows.Forms.TextBox textMBisbn;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.TextBox textMBprice;
        private System.Windows.Forms.TextBox textMBpub;
        private System.Windows.Forms.TextBox textMByear;
        private System.Windows.Forms.TextBox textMBtitle;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.OpenFileDialog openFileDialogMBpic;
        private System.Windows.Forms.Label BDlabelenlarge;
        private System.Windows.Forms.TextBox textMBbookno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label textMBbid;

    }
}