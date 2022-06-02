
namespace usingADO.NET
{
	partial class frmQLSV
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.cboClass = new System.Windows.Forms.ComboBox();
			this.txtID = new System.Windows.Forms.TextBox();
			this.txtFullNameSV = new System.Windows.Forms.TextBox();
			this.btnReset = new System.Windows.Forms.Button();
			this.btnReload = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.lvDSSinhVien = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(44, 41);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 19);
			this.label1.TabIndex = 0;
			this.label1.Text = "Lớp";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(44, 85);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(23, 19);
			this.label2.TabIndex = 1;
			this.label2.Text = "Id";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(44, 127);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(125, 19);
			this.label3.TabIndex = 2;
			this.label3.Text = "Họ tên sinh viên";
			// 
			// cboClass
			// 
			this.cboClass.FormattingEnabled = true;
			this.cboClass.Location = new System.Drawing.Point(200, 34);
			this.cboClass.Name = "cboClass";
			this.cboClass.Size = new System.Drawing.Size(371, 27);
			this.cboClass.TabIndex = 3;
			// 
			// txtID
			// 
			this.txtID.Location = new System.Drawing.Point(200, 77);
			this.txtID.Name = "txtID";
			this.txtID.ReadOnly = true;
			this.txtID.Size = new System.Drawing.Size(371, 27);
			this.txtID.TabIndex = 4;
			// 
			// txtFullNameSV
			// 
			this.txtFullNameSV.Location = new System.Drawing.Point(200, 119);
			this.txtFullNameSV.Name = "txtFullNameSV";
			this.txtFullNameSV.Size = new System.Drawing.Size(371, 27);
			this.txtFullNameSV.TabIndex = 5;
			// 
			// btnReset
			// 
			this.btnReset.AutoSize = true;
			this.btnReset.Location = new System.Drawing.Point(200, 163);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(110, 29);
			this.btnReset.TabIndex = 6;
			this.btnReset.Text = "Mặc định";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// btnReload
			// 
			this.btnReload.AutoSize = true;
			this.btnReload.Location = new System.Drawing.Point(358, 163);
			this.btnReload.Name = "btnReload";
			this.btnReload.Size = new System.Drawing.Size(91, 29);
			this.btnReload.TabIndex = 7;
			this.btnReload.Text = "Tải lại";
			this.btnReload.UseVisualStyleBackColor = true;
			this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
			// 
			// btnSave
			// 
			this.btnSave.AutoSize = true;
			this.btnSave.Location = new System.Drawing.Point(492, 163);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(79, 29);
			this.btnSave.TabIndex = 8;
			this.btnSave.Text = "Lưu";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 233);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(157, 19);
			this.label4.TabIndex = 9;
			this.label4.Text = "Danh sách sinh viên";
			// 
			// txtSearch
			// 
			this.txtSearch.Location = new System.Drawing.Point(358, 225);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(259, 27);
			this.txtSearch.TabIndex = 10;
			this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
			// 
			// lvDSSinhVien
			// 
			this.lvDSSinhVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
			this.lvDSSinhVien.FullRowSelect = true;
			this.lvDSSinhVien.GridLines = true;
			this.lvDSSinhVien.HideSelection = false;
			this.lvDSSinhVien.Location = new System.Drawing.Point(12, 258);
			this.lvDSSinhVien.Name = "lvDSSinhVien";
			this.lvDSSinhVien.Size = new System.Drawing.Size(605, 318);
			this.lvDSSinhVien.TabIndex = 11;
			this.lvDSSinhVien.UseCompatibleStateImageBehavior = false;
			this.lvDSSinhVien.View = System.Windows.Forms.View.Details;
			this.lvDSSinhVien.SelectedIndexChanged += new System.EventHandler(this.lvDSSinhVien_SelectedIndexChanged);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "MSSV";
			this.columnHeader1.Width = 100;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Họ Tên";
			this.columnHeader2.Width = 350;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Lớp";
			this.columnHeader3.Width = 100;
			// 
			// frmQLSV
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(629, 588);
			this.Controls.Add(this.lvDSSinhVien);
			this.Controls.Add(this.txtSearch);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnReload);
			this.Controls.Add(this.btnReset);
			this.Controls.Add(this.txtFullNameSV);
			this.Controls.Add(this.txtID);
			this.Controls.Add(this.cboClass);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximizeBox = false;
			this.Name = "frmQLSV";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Bài tập quản lý sinh viên - Trần Nhật Duật - 2012254";
			this.Load += new System.EventHandler(this.frmQLSV_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cboClass;
		private System.Windows.Forms.TextBox txtID;
		private System.Windows.Forms.TextBox txtFullNameSV;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.Button btnReload;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.ListView lvDSSinhVien;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
	}
}

