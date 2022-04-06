namespace Buoi_7
{
    partial class FormCapNhatThongTinSinhVien
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
            this.lbCapNhatThongTinhSinhVien = new System.Windows.Forms.Label();
            this.lvwDanhSachSinhVien = new System.Windows.Forms.ListView();
            this.clMSSV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clNgaySinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clGioiTinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tBxMSSV = new System.Windows.Forms.TextBox();
            this.tBxTen = new System.Windows.Forms.TextBox();
            this.tBxNgaySinh = new System.Windows.Forms.TextBox();
            this.tBxGioiTinh = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbCapNhatThongTinhSinhVien
            // 
            this.lbCapNhatThongTinhSinhVien.AutoSize = true;
            this.lbCapNhatThongTinhSinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCapNhatThongTinhSinhVien.Location = new System.Drawing.Point(12, 9);
            this.lbCapNhatThongTinhSinhVien.Name = "lbCapNhatThongTinhSinhVien";
            this.lbCapNhatThongTinhSinhVien.Size = new System.Drawing.Size(331, 25);
            this.lbCapNhatThongTinhSinhVien.TabIndex = 0;
            this.lbCapNhatThongTinhSinhVien.Text = "Cập Nhật Thông Tin Sinh Viên";
            // 
            // lvwDanhSachSinhVien
            // 
            this.lvwDanhSachSinhVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clMSSV,
            this.clTen,
            this.clNgaySinh,
            this.clGioiTinh});
            this.lvwDanhSachSinhVien.HideSelection = false;
            this.lvwDanhSachSinhVien.Location = new System.Drawing.Point(17, 37);
            this.lvwDanhSachSinhVien.Name = "lvwDanhSachSinhVien";
            this.lvwDanhSachSinhVien.Size = new System.Drawing.Size(544, 300);
            this.lvwDanhSachSinhVien.TabIndex = 1;
            this.lvwDanhSachSinhVien.UseCompatibleStateImageBehavior = false;
            this.lvwDanhSachSinhVien.View = System.Windows.Forms.View.Details;
            // 
            // clMSSV
            // 
            this.clMSSV.Text = "Mã Sinh Viên";
            this.clMSSV.Width = 87;
            // 
            // clTen
            // 
            this.clTen.Text = "Tên";
            this.clTen.Width = 159;
            // 
            // clNgaySinh
            // 
            this.clNgaySinh.Text = "Ngày Sinh";
            this.clNgaySinh.Width = 100;
            // 
            // clGioiTinh
            // 
            this.clGioiTinh.Text = "Giới Tính";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(578, 37);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(578, 85);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(575, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "MSSV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(575, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(575, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ngày Sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(575, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Giới Tính";
            // 
            // tBxMSSV
            // 
            this.tBxMSSV.Location = new System.Drawing.Point(637, 155);
            this.tBxMSSV.Name = "tBxMSSV";
            this.tBxMSSV.Size = new System.Drawing.Size(100, 20);
            this.tBxMSSV.TabIndex = 8;
            // 
            // tBxTen
            // 
            this.tBxTen.Location = new System.Drawing.Point(637, 185);
            this.tBxTen.Name = "tBxTen";
            this.tBxTen.Size = new System.Drawing.Size(100, 20);
            this.tBxTen.TabIndex = 9;
            // 
            // tBxNgaySinh
            // 
            this.tBxNgaySinh.Location = new System.Drawing.Point(637, 215);
            this.tBxNgaySinh.Name = "tBxNgaySinh";
            this.tBxNgaySinh.Size = new System.Drawing.Size(100, 20);
            this.tBxNgaySinh.TabIndex = 10;
            // 
            // tBxGioiTinh
            // 
            this.tBxGioiTinh.Location = new System.Drawing.Point(637, 254);
            this.tBxGioiTinh.Name = "tBxGioiTinh";
            this.tBxGioiTinh.Size = new System.Drawing.Size(100, 20);
            this.tBxGioiTinh.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(578, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Cập Nhật";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormCapNhatThongTinSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tBxGioiTinh);
            this.Controls.Add(this.tBxNgaySinh);
            this.Controls.Add(this.tBxTen);
            this.Controls.Add(this.tBxMSSV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.lvwDanhSachSinhVien);
            this.Controls.Add(this.lbCapNhatThongTinhSinhVien);
            this.Name = "FormCapNhatThongTinSinhVien";
            this.Text = "Cập Nhật Thông Tin Sinh Viên";
            this.Load += new System.EventHandler(this.FormCapNhatThongTinSinhVien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCapNhatThongTinhSinhVien;
        private System.Windows.Forms.ListView lvwDanhSachSinhVien;
        private System.Windows.Forms.ColumnHeader clTen;
        private System.Windows.Forms.ColumnHeader clMSSV;
        private System.Windows.Forms.ColumnHeader clNgaySinh;
        private System.Windows.Forms.ColumnHeader clGioiTinh;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tBxMSSV;
        private System.Windows.Forms.TextBox tBxTen;
        private System.Windows.Forms.TextBox tBxNgaySinh;
        private System.Windows.Forms.TextBox tBxGioiTinh;
        private System.Windows.Forms.Button button1;
    }
}