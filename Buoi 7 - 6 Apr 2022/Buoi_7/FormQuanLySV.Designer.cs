namespace Buoi_7
{
    partial class FormQuanLySV
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
            this.components = new System.ComponentModel.Container();
            this.tm1 = new System.Windows.Forms.Timer(this.components);
            this.menuQuanLySinhVien = new System.Windows.Forms.MenuStrip();
            this.capNhatThongTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cậpNhậtThôngTinSinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cậpNhậtPhòngBanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cậpNhậtMônHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cậpNhậtĐiểmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêBáoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.theoThángToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.theoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.càiĐặtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelFormCon = new System.Windows.Forms.Panel();
            this.menuQuanLySinhVien.SuspendLayout();
            this.SuspendLayout();
            // 
            // tm1
            // 
            this.tm1.Enabled = true;
            this.tm1.Tick += new System.EventHandler(this.tm1_Tick);
            // 
            // menuQuanLySinhVien
            // 
            this.menuQuanLySinhVien.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.capNhatThongTinToolStripMenuItem,
            this.thốngKêBáoCáoToolStripMenuItem,
            this.tàiKhoảnToolStripMenuItem,
            this.trợGiúpToolStripMenuItem});
            this.menuQuanLySinhVien.Location = new System.Drawing.Point(0, 0);
            this.menuQuanLySinhVien.Name = "menuQuanLySinhVien";
            this.menuQuanLySinhVien.Size = new System.Drawing.Size(800, 24);
            this.menuQuanLySinhVien.TabIndex = 1;
            this.menuQuanLySinhVien.Text = "menuStrip1";
            // 
            // capNhatThongTinToolStripMenuItem
            // 
            this.capNhatThongTinToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cậpNhậtThôngTinSinhViênToolStripMenuItem,
            this.cậpNhậtPhòngBanToolStripMenuItem,
            this.cậpNhậtMônHọcToolStripMenuItem,
            this.cậpNhậtĐiểmToolStripMenuItem});
            this.capNhatThongTinToolStripMenuItem.Name = "capNhatThongTinToolStripMenuItem";
            this.capNhatThongTinToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
            this.capNhatThongTinToolStripMenuItem.Text = "Cập Nhật Thông Tin";
            this.capNhatThongTinToolStripMenuItem.Click += new System.EventHandler(this.capNhatThongTinToolStripMenuItem_Click);
            // 
            // cậpNhậtThôngTinSinhViênToolStripMenuItem
            // 
            this.cậpNhậtThôngTinSinhViênToolStripMenuItem.Name = "cậpNhậtThôngTinSinhViênToolStripMenuItem";
            this.cậpNhậtThôngTinSinhViênToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.cậpNhậtThôngTinSinhViênToolStripMenuItem.Text = "Cập Nhật Thông Tin Sinh Viên";
            this.cậpNhậtThôngTinSinhViênToolStripMenuItem.Click += new System.EventHandler(this.CapNhatThongTinSVToolStripMenuItem_Click);
            // 
            // cậpNhậtPhòngBanToolStripMenuItem
            // 
            this.cậpNhậtPhòngBanToolStripMenuItem.Name = "cậpNhậtPhòngBanToolStripMenuItem";
            this.cậpNhậtPhòngBanToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.cậpNhậtPhòngBanToolStripMenuItem.Text = "Cập Nhật Phòng Ban";
            // 
            // cậpNhậtMônHọcToolStripMenuItem
            // 
            this.cậpNhậtMônHọcToolStripMenuItem.Name = "cậpNhậtMônHọcToolStripMenuItem";
            this.cậpNhậtMônHọcToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.cậpNhậtMônHọcToolStripMenuItem.Text = "Cập Nhật Môn Học";
            // 
            // cậpNhậtĐiểmToolStripMenuItem
            // 
            this.cậpNhậtĐiểmToolStripMenuItem.Name = "cậpNhậtĐiểmToolStripMenuItem";
            this.cậpNhậtĐiểmToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.cậpNhậtĐiểmToolStripMenuItem.Text = "Cập Nhật Điểm";
            // 
            // thốngKêBáoCáoToolStripMenuItem
            // 
            this.thốngKêBáoCáoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.theoThángToolStripMenuItem,
            this.theoToolStripMenuItem});
            this.thốngKêBáoCáoToolStripMenuItem.Name = "thốngKêBáoCáoToolStripMenuItem";
            this.thốngKêBáoCáoToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.thốngKêBáoCáoToolStripMenuItem.Text = "Thống Kê Báo Cáo";
            // 
            // theoThángToolStripMenuItem
            // 
            this.theoThángToolStripMenuItem.Name = "theoThángToolStripMenuItem";
            this.theoThángToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.theoThángToolStripMenuItem.Text = "Danh sách sinh viên còn nợ học phí";
            // 
            // theoToolStripMenuItem
            // 
            this.theoToolStripMenuItem.Name = "theoToolStripMenuItem";
            this.theoToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.theoToolStripMenuItem.Text = "Học Bổng";
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.càiĐặtToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.tàiKhoảnToolStripMenuItem.Text = "Tài Khoản";
            // 
            // càiĐặtToolStripMenuItem
            // 
            this.càiĐặtToolStripMenuItem.Name = "càiĐặtToolStripMenuItem";
            this.càiĐặtToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.càiĐặtToolStripMenuItem.Text = "Cài Đặt";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            // 
            // trợGiúpToolStripMenuItem
            // 
            this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            this.trợGiúpToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.trợGiúpToolStripMenuItem.Text = "Trợ Giúp";
            // 
            // panelFormCon
            // 
            this.panelFormCon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormCon.Location = new System.Drawing.Point(0, 24);
            this.panelFormCon.Name = "panelFormCon";
            this.panelFormCon.Size = new System.Drawing.Size(800, 426);
            this.panelFormCon.TabIndex = 2;
            // 
            // FormQuanLySV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelFormCon);
            this.Controls.Add(this.menuQuanLySinhVien);
            this.MainMenuStrip = this.menuQuanLySinhVien;
            this.Name = "FormQuanLySV";
            this.Text = "Quản Lý Sinh Viên";
            this.menuQuanLySinhVien.ResumeLayout(false);
            this.menuQuanLySinhVien.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tm1;
        private System.Windows.Forms.MenuStrip menuQuanLySinhVien;
        private System.Windows.Forms.ToolStripMenuItem capNhatThongTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêBáoCáoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cậpNhậtThôngTinSinhViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cậpNhậtPhòngBanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cậpNhậtMônHọcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cậpNhậtĐiểmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem theoThángToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem theoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem càiĐặtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.Panel panelFormCon;
    }
}

