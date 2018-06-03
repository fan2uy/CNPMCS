namespace LibraryManagementSystem
{
    partial class frmCategories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCategories));
            this.datagridCateg = new System.Windows.Forms.DataGridView();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pnlAddCateg = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtAddCateg = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtAddShelf = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddOk = new System.Windows.Forms.Button();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.pnlEditCateg = new System.Windows.Forms.Panel();
            this.picCloseEdit = new System.Windows.Forms.PictureBox();
            this.txtEditCateg = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEditShelf = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnMakeDefault = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagridCateg)).BeginInit();
            this.pnlAddCateg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlEditCateg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCloseEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // datagridCateg
            // 
            this.datagridCateg.AllowDrop = true;
            this.datagridCateg.AllowUserToAddRows = false;
            this.datagridCateg.AllowUserToDeleteRows = false;
            this.datagridCateg.AllowUserToResizeRows = false;
            this.datagridCateg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridCateg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridCateg.Location = new System.Drawing.Point(12, 57);
            this.datagridCateg.Name = "datagridCateg";
            this.datagridCateg.ReadOnly = true;
            this.datagridCateg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridCateg.Size = new System.Drawing.Size(656, 324);
            this.datagridCateg.TabIndex = 54;
            // 
            // btnEdit
            // 
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEdit.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(238, 12);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(211, 39);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit ";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(12, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(220, 37);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(455, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(213, 39);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // pnlAddCateg
            // 
            this.pnlAddCateg.BackColor = System.Drawing.Color.White;
            this.pnlAddCateg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAddCateg.Controls.Add(this.pictureBox1);
            this.pnlAddCateg.Controls.Add(this.txtAddCateg);
            this.pnlAddCateg.Controls.Add(this.label19);
            this.pnlAddCateg.Controls.Add(this.txtAddShelf);
            this.pnlAddCateg.Controls.Add(this.label5);
            this.pnlAddCateg.Controls.Add(this.btnAddOk);
            this.pnlAddCateg.Location = new System.Drawing.Point(117, 72);
            this.pnlAddCateg.Name = "pnlAddCateg";
            this.pnlAddCateg.Size = new System.Drawing.Size(445, 296);
            this.pnlAddCateg.TabIndex = 86;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LibraryManagementSystem.Properties.Resources.exit;
            this.pictureBox1.Location = new System.Drawing.Point(411, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 31);
            this.pictureBox1.TabIndex = 90;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtAddCateg
            // 
            this.txtAddCateg.BackColor = System.Drawing.SystemColors.Window;
            this.txtAddCateg.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddCateg.Location = new System.Drawing.Point(178, 40);
            this.txtAddCateg.Name = "txtAddCateg";
            this.txtAddCateg.Size = new System.Drawing.Size(238, 25);
            this.txtAddCateg.TabIndex = 0;
            this.txtAddCateg.TextChanged += new System.EventHandler(this.textBDbookid_TextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(19, 43);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(129, 20);
            this.label19.TabIndex = 87;
            this.label19.Text = "Category Name : ";
            // 
            // txtAddShelf
            // 
            this.txtAddShelf.BackColor = System.Drawing.SystemColors.Window;
            this.txtAddShelf.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddShelf.Location = new System.Drawing.Point(178, 88);
            this.txtAddShelf.Multiline = true;
            this.txtAddShelf.Name = "txtAddShelf";
            this.txtAddShelf.Size = new System.Drawing.Size(238, 91);
            this.txtAddShelf.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 85;
            this.label5.Text = "Shelf :";
            // 
            // btnAddOk
            // 
            this.btnAddOk.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOk.Location = new System.Drawing.Point(112, 222);
            this.btnAddOk.Name = "btnAddOk";
            this.btnAddOk.Size = new System.Drawing.Size(220, 37);
            this.btnAddOk.TabIndex = 2;
            this.btnAddOk.Text = "OK";
            this.btnAddOk.UseVisualStyleBackColor = true;
            this.btnAddOk.Click += new System.EventHandler(this.btnAddOk_Click);
            // 
            // btnViewAll
            // 
            this.btnViewAll.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAll.Location = new System.Drawing.Point(107, 387);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(220, 37);
            this.btnViewAll.TabIndex = 3;
            this.btnViewAll.Text = "View All";
            this.btnViewAll.UseVisualStyleBackColor = true;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // pnlEditCateg
            // 
            this.pnlEditCateg.BackColor = System.Drawing.Color.White;
            this.pnlEditCateg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEditCateg.Controls.Add(this.picCloseEdit);
            this.pnlEditCateg.Controls.Add(this.txtEditCateg);
            this.pnlEditCateg.Controls.Add(this.label2);
            this.pnlEditCateg.Controls.Add(this.txtEditShelf);
            this.pnlEditCateg.Controls.Add(this.label3);
            this.pnlEditCateg.Controls.Add(this.btnSave);
            this.pnlEditCateg.Location = new System.Drawing.Point(115, 71);
            this.pnlEditCateg.Name = "pnlEditCateg";
            this.pnlEditCateg.Size = new System.Drawing.Size(445, 296);
            this.pnlEditCateg.TabIndex = 0;
            // 
            // picCloseEdit
            // 
            this.picCloseEdit.Image = global::LibraryManagementSystem.Properties.Resources.exit;
            this.picCloseEdit.Location = new System.Drawing.Point(411, 3);
            this.picCloseEdit.Name = "picCloseEdit";
            this.picCloseEdit.Size = new System.Drawing.Size(31, 31);
            this.picCloseEdit.TabIndex = 90;
            this.picCloseEdit.TabStop = false;
            this.picCloseEdit.Click += new System.EventHandler(this.picCloseEdit_Click);
            // 
            // txtEditCateg
            // 
            this.txtEditCateg.BackColor = System.Drawing.SystemColors.Window;
            this.txtEditCateg.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditCateg.Location = new System.Drawing.Point(178, 40);
            this.txtEditCateg.Name = "txtEditCateg";
            this.txtEditCateg.Size = new System.Drawing.Size(238, 25);
            this.txtEditCateg.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 87;
            this.label2.Text = "Category Name :";
            // 
            // txtEditShelf
            // 
            this.txtEditShelf.BackColor = System.Drawing.SystemColors.Window;
            this.txtEditShelf.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditShelf.Location = new System.Drawing.Point(178, 88);
            this.txtEditShelf.Multiline = true;
            this.txtEditShelf.Name = "txtEditShelf";
            this.txtEditShelf.Size = new System.Drawing.Size(238, 91);
            this.txtEditShelf.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 85;
            this.label3.Text = "Shelf :";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(122, 222);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(220, 37);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.BackColor = System.Drawing.Color.Lavender;
            this.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStatus.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(0, 441);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(677, 30);
            this.lblStatus.TabIndex = 136;
            this.lblStatus.Text = "Status";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMakeDefault
            // 
            this.btnMakeDefault.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakeDefault.Location = new System.Drawing.Point(339, 387);
            this.btnMakeDefault.Name = "btnMakeDefault";
            this.btnMakeDefault.Size = new System.Drawing.Size(220, 37);
            this.btnMakeDefault.TabIndex = 4;
            this.btnMakeDefault.Text = "Make Default Catgeory";
            this.btnMakeDefault.UseVisualStyleBackColor = true;
            this.btnMakeDefault.Click += new System.EventHandler(this.btnMakeDefault_Click);
            // 
            // frmCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 471);
            this.Controls.Add(this.pnlEditCateg);
            this.Controls.Add(this.pnlAddCateg);
            this.Controls.Add(this.btnMakeDefault);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnViewAll);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.datagridCateg);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCategories";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Categories";
            this.Load += new System.EventHandler(this.frmCategories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridCateg)).EndInit();
            this.pnlAddCateg.ResumeLayout(false);
            this.pnlAddCateg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlEditCateg.ResumeLayout(false);
            this.pnlEditCateg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCloseEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView datagridCateg;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel pnlAddCateg;
        private System.Windows.Forms.Button btnAddOk;
        private System.Windows.Forms.TextBox txtAddCateg;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtAddShelf;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.Panel pnlEditCateg;
        private System.Windows.Forms.PictureBox picCloseEdit;
        private System.Windows.Forms.TextBox txtEditCateg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEditShelf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnMakeDefault;
    }
}