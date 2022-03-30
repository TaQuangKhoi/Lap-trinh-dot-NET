namespace WindowsFormsApp_ControlBox_ClickBox
{
    partial class PhucVuAmThuc
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
            this.cBxChonNhaHang = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lBxDanhSachMonAn = new System.Windows.Forms.ListBox();
            this.lBxDanhSachDaChon = new System.Windows.Forms.ListBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnThemTatCa = new System.Windows.Forms.Button();
            this.btnXoaTatCa = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tBxTenMonDaChon = new System.Windows.Forms.TextBox();
            this.tBxTongSoMon = new System.Windows.Forms.TextBox();
            this.tBxTongTien = new System.Windows.Forms.TextBox();
            this.tBxGiaTien = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn Nhà Hàng";
            // 
            // cBxChonNhaHang
            // 
            this.cBxChonNhaHang.FormattingEnabled = true;
            this.cBxChonNhaHang.Location = new System.Drawing.Point(222, 78);
            this.cBxChonNhaHang.Name = "cBxChonNhaHang";
            this.cBxChonNhaHang.Size = new System.Drawing.Size(121, 21);
            this.cBxChonNhaHang.TabIndex = 1;
            this.cBxChonNhaHang.SelectedIndexChanged += new System.EventHandler(this.cBxChonNhaHang_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Danh sách Món ăn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(308, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Danh sách Đã chọn";
            // 
            // lBxDanhSachMonAn
            // 
            this.lBxDanhSachMonAn.FormattingEnabled = true;
            this.lBxDanhSachMonAn.Location = new System.Drawing.Point(74, 150);
            this.lBxDanhSachMonAn.Name = "lBxDanhSachMonAn";
            this.lBxDanhSachMonAn.Size = new System.Drawing.Size(120, 108);
            this.lBxDanhSachMonAn.TabIndex = 4;
            this.lBxDanhSachMonAn.SelectedIndexChanged += new System.EventHandler(this.lBxDanhSachMonAn_SelectedIndexChanged);
            // 
            // lBxDanhSachDaChon
            // 
            this.lBxDanhSachDaChon.FormattingEnabled = true;
            this.lBxDanhSachDaChon.Location = new System.Drawing.Point(300, 150);
            this.lBxDanhSachDaChon.Name = "lBxDanhSachDaChon";
            this.lBxDanhSachDaChon.Size = new System.Drawing.Size(120, 108);
            this.lBxDanhSachDaChon.TabIndex = 5;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnThem.Location = new System.Drawing.Point(209, 151);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = ">";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnThemTatCa
            // 
            this.btnThemTatCa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnThemTatCa.Location = new System.Drawing.Point(209, 180);
            this.btnThemTatCa.Name = "btnThemTatCa";
            this.btnThemTatCa.Size = new System.Drawing.Size(75, 23);
            this.btnThemTatCa.TabIndex = 7;
            this.btnThemTatCa.Text = ">>>";
            this.btnThemTatCa.UseVisualStyleBackColor = false;
            this.btnThemTatCa.Click += new System.EventHandler(this.btnThemTatCa_Click);
            // 
            // btnXoaTatCa
            // 
            this.btnXoaTatCa.BackColor = System.Drawing.Color.Red;
            this.btnXoaTatCa.Location = new System.Drawing.Point(209, 238);
            this.btnXoaTatCa.Name = "btnXoaTatCa";
            this.btnXoaTatCa.Size = new System.Drawing.Size(75, 23);
            this.btnXoaTatCa.TabIndex = 9;
            this.btnXoaTatCa.Text = "<<<";
            this.btnXoaTatCa.UseVisualStyleBackColor = false;
            this.btnXoaTatCa.Click += new System.EventHandler(this.btnXoaTatCa_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Red;
            this.btnXoa.Location = new System.Drawing.Point(209, 209);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "<";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 344);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tổng số món đã chọn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 387);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tổng tiền";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(500, 50);
            this.label6.TabIndex = 12;
            this.label6.Text = "Phục Vụ Ăn Uống";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(71, 299);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Tên món ăn đã chọn";
            // 
            // tBxTenMonDaChon
            // 
            this.tBxTenMonDaChon.Location = new System.Drawing.Point(196, 299);
            this.tBxTenMonDaChon.Name = "tBxTenMonDaChon";
            this.tBxTenMonDaChon.Size = new System.Drawing.Size(100, 20);
            this.tBxTenMonDaChon.TabIndex = 14;
            // 
            // tBxTongSoMon
            // 
            this.tBxTongSoMon.Location = new System.Drawing.Point(196, 344);
            this.tBxTongSoMon.Name = "tBxTongSoMon";
            this.tBxTongSoMon.Size = new System.Drawing.Size(100, 20);
            this.tBxTongSoMon.TabIndex = 15;
            // 
            // tBxTongTien
            // 
            this.tBxTongTien.Location = new System.Drawing.Point(196, 387);
            this.tBxTongTien.Name = "tBxTongTien";
            this.tBxTongTien.Size = new System.Drawing.Size(100, 20);
            this.tBxTongTien.TabIndex = 16;
            // 
            // tBxGiaTien
            // 
            this.tBxGiaTien.Location = new System.Drawing.Point(345, 299);
            this.tBxGiaTien.Name = "tBxGiaTien";
            this.tBxGiaTien.Size = new System.Drawing.Size(100, 20);
            this.tBxGiaTien.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(300, 302);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Giá tiền";
            // 
            // PhucVuAmThuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tBxGiaTien);
            this.Controls.Add(this.tBxTongTien);
            this.Controls.Add(this.tBxTongSoMon);
            this.Controls.Add(this.tBxTenMonDaChon);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnXoaTatCa);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThemTatCa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lBxDanhSachDaChon);
            this.Controls.Add(this.lBxDanhSachMonAn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cBxChonNhaHang);
            this.Controls.Add(this.label1);
            this.Name = "PhucVuAmThuc";
            this.Text = "PhucVuAmThuc";
            this.Load += new System.EventHandler(this.PhucVuAmThuc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBxChonNhaHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lBxDanhSachMonAn;
        private System.Windows.Forms.ListBox lBxDanhSachDaChon;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThemTatCa;
        private System.Windows.Forms.Button btnXoaTatCa;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tBxTenMonDaChon;
        private System.Windows.Forms.TextBox tBxTongSoMon;
        private System.Windows.Forms.TextBox tBxTongTien;
        private System.Windows.Forms.TextBox tBxGiaTien;
        private System.Windows.Forms.Label label8;
    }
}