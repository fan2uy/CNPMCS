namespace LibraryManagementSystem
{
    partial class BooksAPIForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BooksAPIForm));
            this.btnSearch = new System.Windows.Forms.Button();
            this.textQuery = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panelBook = new System.Windows.Forms.Panel();
            this.labelNoImage = new System.Windows.Forms.Label();
            this.textTitle = new System.Windows.Forms.TextBox();
            this.labelPub = new System.Windows.Forms.Label();
            this.labelPage = new System.Windows.Forms.Label();
            this.labelAuth = new System.Windows.Forms.Label();
            this.picbox = new System.Windows.Forms.PictureBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.pictureLoading = new System.Windows.Forms.PictureBox();
            this.labelSearchstatus = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnprev = new System.Windows.Forms.Button();
            this.btnstop = new System.Windows.Forms.Button();
            this.labelSearchPageNo = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.labelPercent = new System.Windows.Forms.Label();
            this.flowLayoutPanel.SuspendLayout();
            this.panelBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(697, 14);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(160, 52);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // textQuery
            // 
            this.textQuery.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textQuery.Location = new System.Drawing.Point(141, 23);
            this.textQuery.Margin = new System.Windows.Forms.Padding(4);
            this.textQuery.Name = "textQuery";
            this.textQuery.Size = new System.Drawing.Size(532, 30);
            this.textQuery.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tên sách :";
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanel.Controls.Add(this.panelBook);
            this.flowLayoutPanel.Location = new System.Drawing.Point(3, 128);
            this.flowLayoutPanel.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(1329, 743);
            this.flowLayoutPanel.TabIndex = 7;
            // 
            // panelBook
            // 
            this.panelBook.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelBook.BackColor = System.Drawing.SystemColors.Control;
            this.panelBook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBook.Controls.Add(this.labelNoImage);
            this.panelBook.Controls.Add(this.textTitle);
            this.panelBook.Controls.Add(this.labelPub);
            this.panelBook.Controls.Add(this.labelPage);
            this.panelBook.Controls.Add(this.labelAuth);
            this.panelBook.Controls.Add(this.picbox);
            this.panelBook.Controls.Add(this.btnSelect);
            this.panelBook.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelBook.Location = new System.Drawing.Point(4, 4);
            this.panelBook.Margin = new System.Windows.Forms.Padding(4);
            this.panelBook.Name = "panelBook";
            this.panelBook.Size = new System.Drawing.Size(667, 225);
            this.panelBook.TabIndex = 0;
            // 
            // labelNoImage
            // 
            this.labelNoImage.AutoSize = true;
            this.labelNoImage.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoImage.Location = new System.Drawing.Point(52, 98);
            this.labelNoImage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNoImage.Name = "labelNoImage";
            this.labelNoImage.Size = new System.Drawing.Size(93, 23);
            this.labelNoImage.TabIndex = 7;
            this.labelNoImage.Text = "No Image";
            // 
            // textTitle
            // 
            this.textTitle.BackColor = System.Drawing.SystemColors.Control;
            this.textTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textTitle.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.textTitle.Location = new System.Drawing.Point(213, 14);
            this.textTitle.Margin = new System.Windows.Forms.Padding(4);
            this.textTitle.Multiline = true;
            this.textTitle.Name = "textTitle";
            this.textTitle.ReadOnly = true;
            this.textTitle.Size = new System.Drawing.Size(435, 82);
            this.textTitle.TabIndex = 6;
            this.textTitle.Text = "Title";
            // 
            // labelPub
            // 
            this.labelPub.AutoSize = true;
            this.labelPub.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPub.Location = new System.Drawing.Point(212, 175);
            this.labelPub.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPub.Name = "labelPub";
            this.labelPub.Size = new System.Drawing.Size(45, 23);
            this.labelPub.TabIndex = 5;
            this.labelPub.Text = "NXB";
            // 
            // labelPage
            // 
            this.labelPage.AutoSize = true;
            this.labelPage.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPage.Location = new System.Drawing.Point(212, 146);
            this.labelPage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPage.Name = "labelPage";
            this.labelPage.Size = new System.Drawing.Size(82, 23);
            this.labelPage.TabIndex = 4;
            this.labelPage.Text = "Số trang";
            // 
            // labelAuth
            // 
            this.labelAuth.AutoSize = true;
            this.labelAuth.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAuth.Location = new System.Drawing.Point(212, 119);
            this.labelAuth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAuth.Name = "labelAuth";
            this.labelAuth.Size = new System.Drawing.Size(71, 23);
            this.labelAuth.TabIndex = 3;
            this.labelAuth.Text = "Tác giả";
            // 
            // picbox
            // 
            this.picbox.BackColor = System.Drawing.Color.Gainsboro;
            this.picbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picbox.Location = new System.Drawing.Point(8, 5);
            this.picbox.Margin = new System.Windows.Forms.Padding(4);
            this.picbox.Name = "picbox";
            this.picbox.Size = new System.Drawing.Size(182, 210);
            this.picbox.TabIndex = 1;
            this.picbox.TabStop = false;
            // 
            // btnSelect
            // 
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSelect.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.Location = new System.Drawing.Point(533, 167);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(128, 52);
            this.btnSelect.TabIndex = 0;
            this.btnSelect.Text = "Chọn";
            this.btnSelect.UseVisualStyleBackColor = true;
            // 
            // pictureLoading
            // 
            this.pictureLoading.BackColor = System.Drawing.SystemColors.Control;
            this.pictureLoading.Image = global::LibraryManagementSystem.Properties.Resources.gif3;
            this.pictureLoading.Location = new System.Drawing.Point(688, 138);
            this.pictureLoading.Margin = new System.Windows.Forms.Padding(4);
            this.pictureLoading.Name = "pictureLoading";
            this.pictureLoading.Size = new System.Drawing.Size(188, 166);
            this.pictureLoading.TabIndex = 1;
            this.pictureLoading.TabStop = false;
            this.pictureLoading.Visible = false;
            // 
            // labelSearchstatus
            // 
            this.labelSearchstatus.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearchstatus.Location = new System.Drawing.Point(33, 81);
            this.labelSearchstatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSearchstatus.Name = "labelSearchstatus";
            this.labelSearchstatus.Size = new System.Drawing.Size(641, 27);
            this.labelSearchstatus.TabIndex = 8;
            this.labelSearchstatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(928, 66);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(133, 52);
            this.btnNext.TabIndex = 9;
            this.btnNext.Text = "Kế tiếp >>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnprev
            // 
            this.btnprev.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprev.Location = new System.Drawing.Point(697, 69);
            this.btnprev.Margin = new System.Windows.Forms.Padding(4);
            this.btnprev.Name = "btnprev";
            this.btnprev.Size = new System.Drawing.Size(133, 52);
            this.btnprev.TabIndex = 10;
            this.btnprev.Text = "<< Trở lại";
            this.btnprev.UseVisualStyleBackColor = true;
            this.btnprev.Click += new System.EventHandler(this.btnprev_Click);
            // 
            // btnstop
            // 
            this.btnstop.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstop.Location = new System.Drawing.Point(865, 14);
            this.btnstop.Margin = new System.Windows.Forms.Padding(4);
            this.btnstop.Name = "btnstop";
            this.btnstop.Size = new System.Drawing.Size(133, 52);
            this.btnstop.TabIndex = 11;
            this.btnstop.Text = "Tạm dừng";
            this.btnstop.UseVisualStyleBackColor = true;
            this.btnstop.Click += new System.EventHandler(this.btnstop_Click);
            // 
            // labelSearchPageNo
            // 
            this.labelSearchPageNo.AutoSize = true;
            this.labelSearchPageNo.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearchPageNo.Location = new System.Drawing.Point(848, 80);
            this.labelSearchPageNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSearchPageNo.Name = "labelSearchPageNo";
            this.labelSearchPageNo.Size = new System.Drawing.Size(57, 23);
            this.labelSearchPageNo.TabIndex = 12;
            this.labelSearchPageNo.Text = "Page ";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(1008, 34);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(315, 28);
            this.progressBar1.Step = 1;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1324, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 18);
            this.label2.TabIndex = 14;
            // 
            // labelPercent
            // 
            this.labelPercent.AutoSize = true;
            this.labelPercent.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPercent.Location = new System.Drawing.Point(1159, 5);
            this.labelPercent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPercent.Name = "labelPercent";
            this.labelPercent.Size = new System.Drawing.Size(45, 23);
            this.labelPercent.TabIndex = 15;
            this.labelPercent.Text = "0 %";
            // 
            // BooksAPIForm
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 876);
            this.Controls.Add(this.labelPercent);
            this.Controls.Add(this.pictureLoading);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.labelSearchPageNo);
            this.Controls.Add(this.btnstop);
            this.Controls.Add(this.btnprev);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.labelSearchstatus);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textQuery);
            this.Controls.Add(this.btnSearch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BooksAPIForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Google Books";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BooksAPIForm_Load);
            this.flowLayoutPanel.ResumeLayout(false);
            this.panelBook.ResumeLayout(false);
            this.panelBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLoading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox textQuery;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Panel panelBook;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.PictureBox picbox;
        private System.Windows.Forms.Label labelAuth;
        private System.Windows.Forms.Label labelPage;
        private System.Windows.Forms.Label labelPub;
        private System.Windows.Forms.Label labelSearchstatus;
        private System.Windows.Forms.TextBox textTitle;
        private System.Windows.Forms.Label labelNoImage;
        private System.Windows.Forms.PictureBox pictureLoading;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnprev;
        private System.Windows.Forms.Button btnstop;
        private System.Windows.Forms.Label labelSearchPageNo;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelPercent;
    }
}