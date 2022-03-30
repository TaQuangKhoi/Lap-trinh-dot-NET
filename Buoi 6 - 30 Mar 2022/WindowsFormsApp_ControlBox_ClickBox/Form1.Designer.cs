namespace WindowsFormsApp_ControlBox_ClickBox
{
    partial class Form1
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
            this.lBxSanPham = new System.Windows.Forms.ListBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.tBxSanPhamDangChon = new System.Windows.Forms.TextBox();
            this.lblSanPhamDangChon = new System.Windows.Forms.Label();
            this.lBxSanPham2 = new System.Windows.Forms.ListBox();
            this.btnChuyen = new System.Windows.Forms.Button();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.tBxSoLuong = new System.Windows.Forms.TextBox();
            this.tBxNhapSP = new System.Windows.Forms.TextBox();
            this.lblNhapSp = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lBxSanPham
            // 
            this.lBxSanPham.FormattingEnabled = true;
            this.lBxSanPham.Items.AddRange(new object[] {
            "Banh",
            "Keo",
            "Nuoc ngot",
            "Bia",
            "Ruou"});
            this.lBxSanPham.Location = new System.Drawing.Point(148, 150);
            this.lBxSanPham.Name = "lBxSanPham";
            this.lBxSanPham.Size = new System.Drawing.Size(80, 95);
            this.lBxSanPham.TabIndex = 1;
            this.lBxSanPham.SelectedIndexChanged += new System.EventHandler(this.lBxSanPham_SelectedIndexChanged);
            this.lBxSanPham.SizeChanged += new System.EventHandler(this.lBxSanPham_SizeChanged);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(151, 265);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xoa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // tBxSanPhamDangChon
            // 
            this.tBxSanPhamDangChon.Location = new System.Drawing.Point(263, 179);
            this.tBxSanPhamDangChon.Name = "tBxSanPhamDangChon";
            this.tBxSanPhamDangChon.Size = new System.Drawing.Size(100, 20);
            this.tBxSanPhamDangChon.TabIndex = 3;
            // 
            // lblSanPhamDangChon
            // 
            this.lblSanPhamDangChon.AutoSize = true;
            this.lblSanPhamDangChon.Location = new System.Drawing.Point(260, 150);
            this.lblSanPhamDangChon.Name = "lblSanPhamDangChon";
            this.lblSanPhamDangChon.Size = new System.Drawing.Size(113, 13);
            this.lblSanPhamDangChon.TabIndex = 4;
            this.lblSanPhamDangChon.Text = "Sản Phẩm Đang Chọn";
            // 
            // lBxSanPham2
            // 
            this.lBxSanPham2.FormattingEnabled = true;
            this.lBxSanPham2.Location = new System.Drawing.Point(402, 150);
            this.lBxSanPham2.Name = "lBxSanPham2";
            this.lBxSanPham2.Size = new System.Drawing.Size(80, 95);
            this.lBxSanPham2.TabIndex = 5;
            // 
            // btnChuyen
            // 
            this.btnChuyen.Location = new System.Drawing.Point(263, 265);
            this.btnChuyen.Name = "btnChuyen";
            this.btnChuyen.Size = new System.Drawing.Size(75, 23);
            this.btnChuyen.TabIndex = 6;
            this.btnChuyen.Text = "Đưa qua";
            this.btnChuyen.UseVisualStyleBackColor = true;
            this.btnChuyen.Click += new System.EventHandler(this.btnChuyen_Click);
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Location = new System.Drawing.Point(148, 110);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(103, 13);
            this.lblSoLuong.TabIndex = 7;
            this.lblSoLuong.Text = "Tổng Số Sản Phẩm:";
            // 
            // tBxSoLuong
            // 
            this.tBxSoLuong.Location = new System.Drawing.Point(257, 107);
            this.tBxSoLuong.Name = "tBxSoLuong";
            this.tBxSoLuong.Size = new System.Drawing.Size(34, 20);
            this.tBxSoLuong.TabIndex = 8;
            // 
            // tBxNhapSP
            // 
            this.tBxNhapSP.Location = new System.Drawing.Point(257, 62);
            this.tBxNhapSP.Name = "tBxNhapSP";
            this.tBxNhapSP.Size = new System.Drawing.Size(100, 20);
            this.tBxNhapSP.TabIndex = 9;
            this.tBxNhapSP.TextChanged += new System.EventHandler(this.tBxNhapSP_TextChanged);
            // 
            // lblNhapSp
            // 
            this.lblNhapSp.AutoSize = true;
            this.lblNhapSp.Location = new System.Drawing.Point(151, 69);
            this.lblNhapSp.Name = "lblNhapSp";
            this.lblNhapSp.Size = new System.Drawing.Size(85, 13);
            this.lblNhapSp.TabIndex = 10;
            this.lblNhapSp.Text = "Nhập Sản Phẩm";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(380, 58);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lblNhapSp);
            this.Controls.Add(this.tBxNhapSP);
            this.Controls.Add(this.tBxSoLuong);
            this.Controls.Add(this.lblSoLuong);
            this.Controls.Add(this.btnChuyen);
            this.Controls.Add(this.lBxSanPham2);
            this.Controls.Add(this.lblSanPhamDangChon);
            this.Controls.Add(this.tBxSanPhamDangChon);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.lBxSanPham);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lBxSanPham;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox tBxSanPhamDangChon;
        private System.Windows.Forms.Label lblSanPhamDangChon;
        private System.Windows.Forms.ListBox lBxSanPham2;
        private System.Windows.Forms.Button btnChuyen;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.TextBox tBxSoLuong;
        private System.Windows.Forms.TextBox tBxNhapSP;
        private System.Windows.Forms.Label lblNhapSp;
        private System.Windows.Forms.Button btnThem;
    }
}

