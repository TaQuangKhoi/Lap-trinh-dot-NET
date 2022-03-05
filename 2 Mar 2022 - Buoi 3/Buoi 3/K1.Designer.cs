namespace Buoi_3
{
    partial class K1
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
            this.labelNhapTenNhanVien = new System.Windows.Forms.Label();
            this.txtBoxNhapTenNhanVien = new System.Windows.Forms.TextBox();
            this.buttonHienThi = new System.Windows.Forms.Button();
            this.labelTenNhanVien = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNhapTenNhanVien
            // 
            this.labelNhapTenNhanVien.AutoSize = true;
            this.labelNhapTenNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNhapTenNhanVien.Location = new System.Drawing.Point(50, 100);
            this.labelNhapTenNhanVien.Name = "labelNhapTenNhanVien";
            this.labelNhapTenNhanVien.Size = new System.Drawing.Size(150, 16);
            this.labelNhapTenNhanVien.TabIndex = 0;
            this.labelNhapTenNhanVien.Text = "Nhap Ten Nhan Vien";
            // 
            // txtBoxNhapTenNhanVien
            // 
            this.txtBoxNhapTenNhanVien.Location = new System.Drawing.Point(237, 96);
            this.txtBoxNhapTenNhanVien.Name = "txtBoxNhapTenNhanVien";
            this.txtBoxNhapTenNhanVien.Size = new System.Drawing.Size(150, 20);
            this.txtBoxNhapTenNhanVien.TabIndex = 1;
            // 
            // buttonHienThi
            // 
            this.buttonHienThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHienThi.Location = new System.Drawing.Point(53, 219);
            this.buttonHienThi.Name = "buttonHienThi";
            this.buttonHienThi.Size = new System.Drawing.Size(114, 23);
            this.buttonHienThi.TabIndex = 2;
            this.buttonHienThi.Text = "Hiển Thị Tên";
            this.buttonHienThi.UseVisualStyleBackColor = true;
            this.buttonHienThi.Click += new System.EventHandler(this.buttonHienThi_Click);
            // 
            // labelTenNhanVien
            // 
            this.labelTenNhanVien.AutoSize = true;
            this.labelTenNhanVien.Location = new System.Drawing.Point(234, 224);
            this.labelTenNhanVien.Name = "labelTenNhanVien";
            this.labelTenNhanVien.Size = new System.Drawing.Size(35, 13);
            this.labelTenNhanVien.TabIndex = 3;
            this.labelTenNhanVien.Text = "label1";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(53, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Hiển Thị Form NV";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(53, 386);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Đóng";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // K1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelTenNhanVien);
            this.Controls.Add(this.buttonHienThi);
            this.Controls.Add(this.txtBoxNhapTenNhanVien);
            this.Controls.Add(this.labelNhapTenNhanVien);
            this.Name = "K1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNhapTenNhanVien;
        private System.Windows.Forms.TextBox txtBoxNhapTenNhanVien;
        private System.Windows.Forms.Button buttonHienThi;
        private System.Windows.Forms.Label labelTenNhanVien;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

