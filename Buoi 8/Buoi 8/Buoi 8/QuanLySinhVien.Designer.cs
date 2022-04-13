namespace Buoi_8
{
    partial class QuanLySinhVien
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.CapNhatThongTin = new System.Windows.Forms.ToolStripMenuItem();
            this.Khoa = new System.Windows.Forms.ToolStripMenuItem();
            this.Lop = new System.Windows.Forms.ToolStripMenuItem();
            this.SinhVien = new System.Windows.Forms.ToolStripMenuItem();
            this.Diem = new System.Windows.Forms.ToolStripMenuItem();
            this.MonHoc = new System.Windows.Forms.ToolStripMenuItem();
            this.BaoCaoThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.TroGiup = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CapNhatThongTin,
            this.BaoCaoThongKe,
            this.TroGiup});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // CapNhatThongTin
            // 
            this.CapNhatThongTin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Khoa,
            this.Lop,
            this.SinhVien,
            this.MonHoc,
            this.Diem});
            this.CapNhatThongTin.Name = "CapNhatThongTin";
            this.CapNhatThongTin.Size = new System.Drawing.Size(125, 20);
            this.CapNhatThongTin.Text = "Cập Nhật Thông Tin";
            // 
            // Khoa
            // 
            this.Khoa.Name = "Khoa";
            this.Khoa.Size = new System.Drawing.Size(180, 22);
            this.Khoa.Text = "Khoa";
            this.Khoa.Click += new System.EventHandler(this.khoaToolStripMenuItem_Click);
            // 
            // Lop
            // 
            this.Lop.Name = "Lop";
            this.Lop.Size = new System.Drawing.Size(180, 22);
            this.Lop.Text = "Lớp";
            // 
            // SinhVien
            // 
            this.SinhVien.Name = "SinhVien";
            this.SinhVien.Size = new System.Drawing.Size(180, 22);
            this.SinhVien.Text = "Sinh Viên";
            // 
            // Diem
            // 
            this.Diem.Name = "Diem";
            this.Diem.Size = new System.Drawing.Size(180, 22);
            this.Diem.Text = "Điểm";
            // 
            // MonHoc
            // 
            this.MonHoc.Name = "MonHoc";
            this.MonHoc.Size = new System.Drawing.Size(180, 22);
            this.MonHoc.Text = "Môn Học";
            // 
            // BaoCaoThongKe
            // 
            this.BaoCaoThongKe.Name = "BaoCaoThongKe";
            this.BaoCaoThongKe.Size = new System.Drawing.Size(116, 20);
            this.BaoCaoThongKe.Text = "Báo Cáo Thống Kê";
            // 
            // TroGiup
            // 
            this.TroGiup.Name = "TroGiup";
            this.TroGiup.Size = new System.Drawing.Size(63, 20);
            this.TroGiup.Text = "Trợ Giúp";
            // 
            // QuanLySinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "QuanLySinhVien";
            this.Text = "Quản Lý Sinh Viên";
            this.Load += new System.EventHandler(this.QuanLySinhVien_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem CapNhatThongTin;
        private System.Windows.Forms.ToolStripMenuItem Khoa;
        private System.Windows.Forms.ToolStripMenuItem Lop;
        private System.Windows.Forms.ToolStripMenuItem SinhVien;
        private System.Windows.Forms.ToolStripMenuItem MonHoc;
        private System.Windows.Forms.ToolStripMenuItem Diem;
        private System.Windows.Forms.ToolStripMenuItem BaoCaoThongKe;
        private System.Windows.Forms.ToolStripMenuItem TroGiup;
    }
}

