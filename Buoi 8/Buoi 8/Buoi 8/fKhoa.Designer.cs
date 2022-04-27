namespace Buoi_8
{
    partial class fKhoa
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
            this.lblCapNhatThongTinKhoa = new System.Windows.Forms.Label();
            this.lblTenKhoa = new System.Windows.Forms.Label();
            this.txbTenKhoa = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnHien = new System.Windows.Forms.Button();
            this.lblTongSoKhoa = new System.Windows.Forms.Label();
            this.txbTongSoKhoa = new System.Windows.Forms.TextBox();
            this.lblMaKhoa = new System.Windows.Forms.Label();
            this.txbMaKhoa = new System.Windows.Forms.TextBox();
            this.lvKhoa = new System.Windows.Forms.ListView();
            this.clhMaKhoa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhTenKhoa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnHienLuoi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCapNhatThongTinKhoa
            // 
            this.lblCapNhatThongTinKhoa.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCapNhatThongTinKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapNhatThongTinKhoa.Location = new System.Drawing.Point(0, 0);
            this.lblCapNhatThongTinKhoa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCapNhatThongTinKhoa.Name = "lblCapNhatThongTinKhoa";
            this.lblCapNhatThongTinKhoa.Size = new System.Drawing.Size(889, 50);
            this.lblCapNhatThongTinKhoa.TabIndex = 0;
            this.lblCapNhatThongTinKhoa.Text = "Cập Nhật Thông Tin Khoa";
            this.lblCapNhatThongTinKhoa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTenKhoa
            // 
            this.lblTenKhoa.AutoSize = true;
            this.lblTenKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenKhoa.Location = new System.Drawing.Point(279, 152);
            this.lblTenKhoa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenKhoa.Name = "lblTenKhoa";
            this.lblTenKhoa.Size = new System.Drawing.Size(65, 16);
            this.lblTenKhoa.TabIndex = 2;
            this.lblTenKhoa.Text = "Tên Khoa";
            // 
            // txbTenKhoa
            // 
            this.txbTenKhoa.Location = new System.Drawing.Point(381, 149);
            this.txbTenKhoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbTenKhoa.Name = "txbTenKhoa";
            this.txbTenKhoa.Size = new System.Drawing.Size(224, 26);
            this.txbTenKhoa.TabIndex = 4;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(210, 210);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(84, 34);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(328, 210);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(84, 34);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(449, 210);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(84, 34);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(582, 210);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(84, 34);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnHien
            // 
            this.btnHien.Location = new System.Drawing.Point(469, 273);
            this.btnHien.Name = "btnHien";
            this.btnHien.Size = new System.Drawing.Size(105, 40);
            this.btnHien.TabIndex = 10;
            this.btnHien.Text = "Hiện";
            this.btnHien.UseVisualStyleBackColor = true;
            this.btnHien.Click += new System.EventHandler(this.btnHien_Click);
            // 
            // lblTongSoKhoa
            // 
            this.lblTongSoKhoa.AutoSize = true;
            this.lblTongSoKhoa.Location = new System.Drawing.Point(206, 286);
            this.lblTongSoKhoa.Name = "lblTongSoKhoa";
            this.lblTongSoKhoa.Size = new System.Drawing.Size(110, 20);
            this.lblTongSoKhoa.TabIndex = 11;
            this.lblTongSoKhoa.Text = "Tổng Số Khoa";
            // 
            // txbTongSoKhoa
            // 
            this.txbTongSoKhoa.Location = new System.Drawing.Point(337, 280);
            this.txbTongSoKhoa.Name = "txbTongSoKhoa";
            this.txbTongSoKhoa.Size = new System.Drawing.Size(100, 26);
            this.txbTongSoKhoa.TabIndex = 12;
            // 
            // lblMaKhoa
            // 
            this.lblMaKhoa.AutoSize = true;
            this.lblMaKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaKhoa.Location = new System.Drawing.Point(279, 96);
            this.lblMaKhoa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaKhoa.Name = "lblMaKhoa";
            this.lblMaKhoa.Size = new System.Drawing.Size(60, 16);
            this.lblMaKhoa.TabIndex = 1;
            this.lblMaKhoa.Text = "Mã Khoa";
            // 
            // txbMaKhoa
            // 
            this.txbMaKhoa.Location = new System.Drawing.Point(381, 90);
            this.txbMaKhoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbMaKhoa.Name = "txbMaKhoa";
            this.txbMaKhoa.Size = new System.Drawing.Size(224, 26);
            this.txbMaKhoa.TabIndex = 3;
            // 
            // lvKhoa
            // 
            this.lvKhoa.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clhMaKhoa,
            this.clhTenKhoa});
            this.lvKhoa.HideSelection = false;
            this.lvKhoa.Location = new System.Drawing.Point(123, 327);
            this.lvKhoa.Name = "lvKhoa";
            this.lvKhoa.Size = new System.Drawing.Size(543, 233);
            this.lvKhoa.TabIndex = 13;
            this.lvKhoa.UseCompatibleStateImageBehavior = false;
            this.lvKhoa.View = System.Windows.Forms.View.Details;
            // 
            // clhMaKhoa
            // 
            this.clhMaKhoa.Text = "Mã Khoa";
            this.clhMaKhoa.Width = 131;
            // 
            // clhTenKhoa
            // 
            this.clhTenKhoa.Text = "Tên Khoa";
            this.clhTenKhoa.Width = 388;
            // 
            // btnHienLuoi
            // 
            this.btnHienLuoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHienLuoi.Location = new System.Drawing.Point(688, 327);
            this.btnHienLuoi.Name = "btnHienLuoi";
            this.btnHienLuoi.Size = new System.Drawing.Size(162, 40);
            this.btnHienLuoi.TabIndex = 14;
            this.btnHienLuoi.Text = "Hiện Lên Lưới";
            this.btnHienLuoi.UseVisualStyleBackColor = true;
            this.btnHienLuoi.Click += new System.EventHandler(this.btnHienLuoi_Click);
            // 
            // fKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 595);
            this.Controls.Add(this.txbMaKhoa);
            this.Controls.Add(this.btnHienLuoi);
            this.Controls.Add(this.lblMaKhoa);
            this.Controls.Add(this.lvKhoa);
            this.Controls.Add(this.txbTongSoKhoa);
            this.Controls.Add(this.lblTongSoKhoa);
            this.Controls.Add(this.btnHien);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txbTenKhoa);
            this.Controls.Add(this.lblTenKhoa);
            this.Controls.Add(this.lblCapNhatThongTinKhoa);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "fKhoa";
            this.Text = "fKhoa";
            this.Load += new System.EventHandler(this.fKhoa_Load);
            this.SizeChanged += new System.EventHandler(this.fKhoa_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCapNhatThongTinKhoa;
        private System.Windows.Forms.Label lblTenKhoa;
        private System.Windows.Forms.TextBox txbTenKhoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnHien;
        private System.Windows.Forms.Label lblTongSoKhoa;
        private System.Windows.Forms.TextBox txbTongSoKhoa;
        private System.Windows.Forms.Label lblMaKhoa;
        private System.Windows.Forms.TextBox txbMaKhoa;
        private System.Windows.Forms.ListView lvKhoa;
        private System.Windows.Forms.ColumnHeader clhMaKhoa;
        private System.Windows.Forms.ColumnHeader clhTenKhoa;
        private System.Windows.Forms.Button btnHienLuoi;
    }
}