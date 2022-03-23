namespace Buoi5
{
    partial class fNhap3diem
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
            this.rd_DaiHoc_KhoaHocTuNhien = new System.Windows.Forms.RadioButton();
            this.rd_DaiHoc_BachKhoa = new System.Windows.Forms.RadioButton();
            this.txt_DiemToan = new System.Windows.Forms.TextBox();
            this.label_DiemToan = new System.Windows.Forms.Label();
            this.rd_DaiHoc_BRVT = new System.Windows.Forms.RadioButton();
            this.txt_DiemVan = new System.Windows.Forms.TextBox();
            this.label_DiemVan = new System.Windows.Forms.Label();
            this.txt_DiemAnh = new System.Windows.Forms.TextBox();
            this.label_DiemAnh = new System.Windows.Forms.Label();
            this.btn_XetTuyen = new System.Windows.Forms.Button();
            this.labelShowDH1 = new System.Windows.Forms.Label();
            this.labelShowDH2 = new System.Windows.Forms.Label();
            this.labelShowDH3 = new System.Windows.Forms.Label();
            this.gbChonTruong = new System.Windows.Forms.GroupBox();
            this.gbChonNganh = new System.Windows.Forms.GroupBox();
            this.rdXayDung = new System.Windows.Forms.RadioButton();
            this.rdDuLich = new System.Windows.Forms.RadioButton();
            this.rdCNTT = new System.Windows.Forms.RadioButton();
            this.rdKinhTe = new System.Windows.Forms.RadioButton();
            this.lblXetTuyen = new System.Windows.Forms.Label();
            this.gbDiemUuTien = new System.Windows.Forms.GroupBox();
            this.cbDTTS = new System.Windows.Forms.CheckBox();
            this.cbVC = new System.Windows.Forms.CheckBox();
            this.cbCTBLS = new System.Windows.Forms.CheckBox();
            this.cbHSGQG = new System.Windows.Forms.CheckBox();
            this.gbChonTruong.SuspendLayout();
            this.gbChonNganh.SuspendLayout();
            this.gbDiemUuTien.SuspendLayout();
            this.SuspendLayout();
            // 
            // rd_DaiHoc_KhoaHocTuNhien
            // 
            this.rd_DaiHoc_KhoaHocTuNhien.AutoSize = true;
            this.rd_DaiHoc_KhoaHocTuNhien.Location = new System.Drawing.Point(6, 66);
            this.rd_DaiHoc_KhoaHocTuNhien.Name = "rd_DaiHoc_KhoaHocTuNhien";
            this.rd_DaiHoc_KhoaHocTuNhien.Size = new System.Drawing.Size(160, 17);
            this.rd_DaiHoc_KhoaHocTuNhien.TabIndex = 9;
            this.rd_DaiHoc_KhoaHocTuNhien.Text = "Đại học Khoa Học Tự Nhiên";
            this.rd_DaiHoc_KhoaHocTuNhien.UseVisualStyleBackColor = true;
            this.rd_DaiHoc_KhoaHocTuNhien.CheckedChanged += new System.EventHandler(this.rdKHTN_CheckedChanged);
            this.rd_DaiHoc_KhoaHocTuNhien.Click += new System.EventHandler(this.rdKHTN_Click);
            // 
            // rd_DaiHoc_BachKhoa
            // 
            this.rd_DaiHoc_BachKhoa.AutoSize = true;
            this.rd_DaiHoc_BachKhoa.Location = new System.Drawing.Point(6, 43);
            this.rd_DaiHoc_BachKhoa.Name = "rd_DaiHoc_BachKhoa";
            this.rd_DaiHoc_BachKhoa.Size = new System.Drawing.Size(118, 17);
            this.rd_DaiHoc_BachKhoa.TabIndex = 8;
            this.rd_DaiHoc_BachKhoa.Text = "Đại học Bách Khoa";
            this.rd_DaiHoc_BachKhoa.UseVisualStyleBackColor = true;
            this.rd_DaiHoc_BachKhoa.CheckedChanged += new System.EventHandler(this.rdBK_CheckedChanged);
            this.rd_DaiHoc_BachKhoa.Click += new System.EventHandler(this.rdBK_Click);
            // 
            // txt_DiemToan
            // 
            this.txt_DiemToan.Location = new System.Drawing.Point(77, 97);
            this.txt_DiemToan.Name = "txt_DiemToan";
            this.txt_DiemToan.Size = new System.Drawing.Size(238, 20);
            this.txt_DiemToan.TabIndex = 6;
            this.txt_DiemToan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_DiemToan_KeyPress);
            // 
            // label_DiemToan
            // 
            this.label_DiemToan.AutoSize = true;
            this.label_DiemToan.Location = new System.Drawing.Point(12, 100);
            this.label_DiemToan.Name = "label_DiemToan";
            this.label_DiemToan.Size = new System.Drawing.Size(55, 13);
            this.label_DiemToan.TabIndex = 5;
            this.label_DiemToan.Text = "Điểm toán";
            // 
            // rd_DaiHoc_BRVT
            // 
            this.rd_DaiHoc_BRVT.AutoSize = true;
            this.rd_DaiHoc_BRVT.Location = new System.Drawing.Point(6, 20);
            this.rd_DaiHoc_BRVT.Name = "rd_DaiHoc_BRVT";
            this.rd_DaiHoc_BRVT.Size = new System.Drawing.Size(147, 17);
            this.rd_DaiHoc_BRVT.TabIndex = 7;
            this.rd_DaiHoc_BRVT.Text = "Đại học Bà Rịa Vũng Tàu";
            this.rd_DaiHoc_BRVT.UseVisualStyleBackColor = true;
            this.rd_DaiHoc_BRVT.CheckedChanged += new System.EventHandler(this.rdDHBRVT_CheckedChanged);
            this.rd_DaiHoc_BRVT.Click += new System.EventHandler(this.rdDHBRVT_Click);
            // 
            // txt_DiemVan
            // 
            this.txt_DiemVan.Location = new System.Drawing.Point(77, 123);
            this.txt_DiemVan.Name = "txt_DiemVan";
            this.txt_DiemVan.Size = new System.Drawing.Size(238, 20);
            this.txt_DiemVan.TabIndex = 11;
            this.txt_DiemVan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_DiemVan_KeyPress);
            // 
            // label_DiemVan
            // 
            this.label_DiemVan.AutoSize = true;
            this.label_DiemVan.Location = new System.Drawing.Point(12, 126);
            this.label_DiemVan.Name = "label_DiemVan";
            this.label_DiemVan.Size = new System.Drawing.Size(52, 13);
            this.label_DiemVan.TabIndex = 10;
            this.label_DiemVan.Text = "Điểm văn";
            // 
            // txt_DiemAnh
            // 
            this.txt_DiemAnh.Location = new System.Drawing.Point(77, 149);
            this.txt_DiemAnh.Name = "txt_DiemAnh";
            this.txt_DiemAnh.Size = new System.Drawing.Size(238, 20);
            this.txt_DiemAnh.TabIndex = 13;
            this.txt_DiemAnh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_DiemAnh_KeyPress);
            // 
            // label_DiemAnh
            // 
            this.label_DiemAnh.AutoSize = true;
            this.label_DiemAnh.Location = new System.Drawing.Point(12, 152);
            this.label_DiemAnh.Name = "label_DiemAnh";
            this.label_DiemAnh.Size = new System.Drawing.Size(52, 13);
            this.label_DiemAnh.TabIndex = 12;
            this.label_DiemAnh.Text = "Điểm anh";
            // 
            // btn_XetTuyen
            // 
            this.btn_XetTuyen.Location = new System.Drawing.Point(215, 412);
            this.btn_XetTuyen.Name = "btn_XetTuyen";
            this.btn_XetTuyen.Size = new System.Drawing.Size(100, 30);
            this.btn_XetTuyen.TabIndex = 14;
            this.btn_XetTuyen.Text = "Xét tuyển";
            this.btn_XetTuyen.UseVisualStyleBackColor = true;
            this.btn_XetTuyen.Click += new System.EventHandler(this.btn_XetTuyen_Click);
            // 
            // labelShowDH1
            // 
            this.labelShowDH1.AutoSize = true;
            this.labelShowDH1.Location = new System.Drawing.Point(278, 22);
            this.labelShowDH1.Name = "labelShowDH1";
            this.labelShowDH1.Size = new System.Drawing.Size(22, 13);
            this.labelShowDH1.TabIndex = 15;
            this.labelShowDH1.Text = "     ";
            // 
            // labelShowDH2
            // 
            this.labelShowDH2.AutoSize = true;
            this.labelShowDH2.Location = new System.Drawing.Point(278, 45);
            this.labelShowDH2.Name = "labelShowDH2";
            this.labelShowDH2.Size = new System.Drawing.Size(22, 13);
            this.labelShowDH2.TabIndex = 16;
            this.labelShowDH2.Text = "     ";
            // 
            // labelShowDH3
            // 
            this.labelShowDH3.AutoSize = true;
            this.labelShowDH3.Location = new System.Drawing.Point(278, 68);
            this.labelShowDH3.Name = "labelShowDH3";
            this.labelShowDH3.Size = new System.Drawing.Size(22, 13);
            this.labelShowDH3.TabIndex = 17;
            this.labelShowDH3.Text = "     ";
            // 
            // gbChonTruong
            // 
            this.gbChonTruong.Controls.Add(this.rd_DaiHoc_BachKhoa);
            this.gbChonTruong.Controls.Add(this.rd_DaiHoc_BRVT);
            this.gbChonTruong.Controls.Add(this.labelShowDH3);
            this.gbChonTruong.Controls.Add(this.rd_DaiHoc_KhoaHocTuNhien);
            this.gbChonTruong.Controls.Add(this.labelShowDH2);
            this.gbChonTruong.Controls.Add(this.labelShowDH1);
            this.gbChonTruong.Location = new System.Drawing.Point(12, 177);
            this.gbChonTruong.Name = "gbChonTruong";
            this.gbChonTruong.Size = new System.Drawing.Size(303, 103);
            this.gbChonTruong.TabIndex = 18;
            this.gbChonTruong.TabStop = false;
            this.gbChonTruong.Text = "Chọn trường";
            // 
            // gbChonNganh
            // 
            this.gbChonNganh.Controls.Add(this.rdXayDung);
            this.gbChonNganh.Controls.Add(this.rdDuLich);
            this.gbChonNganh.Controls.Add(this.rdCNTT);
            this.gbChonNganh.Controls.Add(this.rdKinhTe);
            this.gbChonNganh.Location = new System.Drawing.Point(12, 286);
            this.gbChonNganh.Name = "gbChonNganh";
            this.gbChonNganh.Size = new System.Drawing.Size(143, 120);
            this.gbChonNganh.TabIndex = 19;
            this.gbChonNganh.TabStop = false;
            this.gbChonNganh.Text = "Chọn ngành";
            // 
            // rdXayDung
            // 
            this.rdXayDung.AutoSize = true;
            this.rdXayDung.Location = new System.Drawing.Point(6, 89);
            this.rdXayDung.Name = "rdXayDung";
            this.rdXayDung.Size = new System.Drawing.Size(70, 17);
            this.rdXayDung.TabIndex = 10;
            this.rdXayDung.Text = "Xây dựng";
            this.rdXayDung.UseVisualStyleBackColor = true;
            // 
            // rdDuLich
            // 
            this.rdDuLich.AutoSize = true;
            this.rdDuLich.Location = new System.Drawing.Point(6, 43);
            this.rdDuLich.Name = "rdDuLich";
            this.rdDuLich.Size = new System.Drawing.Size(58, 17);
            this.rdDuLich.TabIndex = 8;
            this.rdDuLich.Text = "Du lịch";
            this.rdDuLich.UseVisualStyleBackColor = true;
            // 
            // rdCNTT
            // 
            this.rdCNTT.AutoSize = true;
            this.rdCNTT.Location = new System.Drawing.Point(6, 20);
            this.rdCNTT.Name = "rdCNTT";
            this.rdCNTT.Size = new System.Drawing.Size(121, 17);
            this.rdCNTT.TabIndex = 7;
            this.rdCNTT.Text = "Công nghệ thông tin";
            this.rdCNTT.UseVisualStyleBackColor = true;
            // 
            // rdKinhTe
            // 
            this.rdKinhTe.AutoSize = true;
            this.rdKinhTe.Location = new System.Drawing.Point(6, 66);
            this.rdKinhTe.Name = "rdKinhTe";
            this.rdKinhTe.Size = new System.Drawing.Size(58, 17);
            this.rdKinhTe.TabIndex = 9;
            this.rdKinhTe.Text = "Kinh tế";
            this.rdKinhTe.UseVisualStyleBackColor = true;
            // 
            // lblXetTuyen
            // 
            this.lblXetTuyen.AutoSize = true;
            this.lblXetTuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXetTuyen.Location = new System.Drawing.Point(5, 9);
            this.lblXetTuyen.Name = "lblXetTuyen";
            this.lblXetTuyen.Size = new System.Drawing.Size(325, 73);
            this.lblXetTuyen.TabIndex = 20;
            this.lblXetTuyen.Text = "Xét Tuyển";
            // 
            // gbDiemUuTien
            // 
            this.gbDiemUuTien.Controls.Add(this.cbDTTS);
            this.gbDiemUuTien.Controls.Add(this.cbVC);
            this.gbDiemUuTien.Controls.Add(this.cbCTBLS);
            this.gbDiemUuTien.Controls.Add(this.cbHSGQG);
            this.gbDiemUuTien.Location = new System.Drawing.Point(161, 286);
            this.gbDiemUuTien.Name = "gbDiemUuTien";
            this.gbDiemUuTien.Size = new System.Drawing.Size(154, 120);
            this.gbDiemUuTien.TabIndex = 20;
            this.gbDiemUuTien.TabStop = false;
            this.gbDiemUuTien.Text = "Điểm ưu tiên";
            // 
            // cbDTTS
            // 
            this.cbDTTS.AutoSize = true;
            this.cbDTTS.Location = new System.Drawing.Point(6, 89);
            this.cbDTTS.Name = "cbDTTS";
            this.cbDTTS.Size = new System.Drawing.Size(104, 17);
            this.cbDTTS.TabIndex = 3;
            this.cbDTTS.Text = "Dân tộc thiểu số";
            this.cbDTTS.UseVisualStyleBackColor = true;
            // 
            // cbVC
            // 
            this.cbVC.AutoSize = true;
            this.cbVC.Location = new System.Drawing.Point(6, 66);
            this.cbVC.Name = "cbVC";
            this.cbVC.Size = new System.Drawing.Size(72, 17);
            this.cbVC.TabIndex = 2;
            this.cbVC.Text = "Vùng cao";
            this.cbVC.UseVisualStyleBackColor = true;
            // 
            // cbCTBLS
            // 
            this.cbCTBLS.AutoSize = true;
            this.cbCTBLS.Location = new System.Drawing.Point(6, 43);
            this.cbCTBLS.Name = "cbCTBLS";
            this.cbCTBLS.Size = new System.Drawing.Size(133, 17);
            this.cbCTBLS.TabIndex = 1;
            this.cbCTBLS.Text = "Con thương binh liệt sĩ";
            this.cbCTBLS.UseVisualStyleBackColor = true;
            // 
            // cbHSGQG
            // 
            this.cbHSGQG.AutoSize = true;
            this.cbHSGQG.Location = new System.Drawing.Point(6, 20);
            this.cbHSGQG.Name = "cbHSGQG";
            this.cbHSGQG.Size = new System.Drawing.Size(131, 17);
            this.cbHSGQG.TabIndex = 0;
            this.cbHSGQG.Text = "Học sinh giỏi quốc gia";
            this.cbHSGQG.UseVisualStyleBackColor = true;
            // 
            // fNhap3diem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 454);
            this.Controls.Add(this.gbDiemUuTien);
            this.Controls.Add(this.lblXetTuyen);
            this.Controls.Add(this.gbChonNganh);
            this.Controls.Add(this.gbChonTruong);
            this.Controls.Add(this.btn_XetTuyen);
            this.Controls.Add(this.txt_DiemAnh);
            this.Controls.Add(this.label_DiemAnh);
            this.Controls.Add(this.txt_DiemVan);
            this.Controls.Add(this.label_DiemVan);
            this.Controls.Add(this.txt_DiemToan);
            this.Controls.Add(this.label_DiemToan);
            this.Name = "fNhap3diem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập điểm 3 môn";
            this.gbChonTruong.ResumeLayout(false);
            this.gbChonTruong.PerformLayout();
            this.gbChonNganh.ResumeLayout(false);
            this.gbChonNganh.PerformLayout();
            this.gbDiemUuTien.ResumeLayout(false);
            this.gbDiemUuTien.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rd_DaiHoc_KhoaHocTuNhien;
        private System.Windows.Forms.RadioButton rd_DaiHoc_BachKhoa;
        private System.Windows.Forms.TextBox txt_DiemToan;
        private System.Windows.Forms.Label label_DiemToan;
        private System.Windows.Forms.RadioButton rd_DaiHoc_BRVT;
        private System.Windows.Forms.TextBox txt_DiemVan;
        private System.Windows.Forms.Label label_DiemVan;
        private System.Windows.Forms.TextBox txt_DiemAnh;
        private System.Windows.Forms.Label label_DiemAnh;
        private System.Windows.Forms.Button btn_XetTuyen;
        private System.Windows.Forms.Label labelShowDH1;
        private System.Windows.Forms.Label labelShowDH2;
        private System.Windows.Forms.Label labelShowDH3;
        private System.Windows.Forms.GroupBox gbChonTruong;
        private System.Windows.Forms.GroupBox gbChonNganh;
        private System.Windows.Forms.RadioButton rdXayDung;
        private System.Windows.Forms.RadioButton rdDuLich;
        private System.Windows.Forms.RadioButton rdCNTT;
        private System.Windows.Forms.RadioButton rdKinhTe;
        private System.Windows.Forms.Label lblXetTuyen;
        private System.Windows.Forms.GroupBox gbDiemUuTien;
        private System.Windows.Forms.CheckBox cbDTTS;
        private System.Windows.Forms.CheckBox cbVC;
        private System.Windows.Forms.CheckBox cbCTBLS;
        private System.Windows.Forms.CheckBox cbHSGQG;
    }
}