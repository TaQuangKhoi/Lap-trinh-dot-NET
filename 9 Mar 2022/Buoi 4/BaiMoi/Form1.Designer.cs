namespace BaiMoi
{
    partial class F_BoiSo_UocSo
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
            this.lblUocSo_BoiSo = new System.Windows.Forms.Label();
            this.lblNhapSoA = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUocSo = new System.Windows.Forms.Label();
            this.lblBoiSo = new System.Windows.Forms.Label();
            this.txtBxNhapSoA = new System.Windows.Forms.TextBox();
            this.txtBxNhapSoB = new System.Windows.Forms.TextBox();
            this.txtBxUocSo = new System.Windows.Forms.TextBox();
            this.txtBxBoiSo = new System.Windows.Forms.TextBox();
            this.btnThucHien = new System.Windows.Forms.Button();
            this.btnTiepTuc = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUocSo_BoiSo
            // 
            this.lblUocSo_BoiSo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblUocSo_BoiSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUocSo_BoiSo.Location = new System.Drawing.Point(0, 0);
            this.lblUocSo_BoiSo.Name = "lblUocSo_BoiSo";
            this.lblUocSo_BoiSo.Size = new System.Drawing.Size(485, 100);
            this.lblUocSo_BoiSo.TabIndex = 0;
            this.lblUocSo_BoiSo.Text = "Ước Số Chung - Bội Số Chung";
            this.lblUocSo_BoiSo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNhapSoA
            // 
            this.lblNhapSoA.AutoSize = true;
            this.lblNhapSoA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhapSoA.Location = new System.Drawing.Point(80, 150);
            this.lblNhapSoA.Name = "lblNhapSoA";
            this.lblNhapSoA.Size = new System.Drawing.Size(76, 18);
            this.lblNhapSoA.TabIndex = 1;
            this.lblNhapSoA.Text = "Nhập số a";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nhập số b";
            // 
            // lblUocSo
            // 
            this.lblUocSo.AutoSize = true;
            this.lblUocSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUocSo.Location = new System.Drawing.Point(80, 238);
            this.lblUocSo.Name = "lblUocSo";
            this.lblUocSo.Size = new System.Drawing.Size(157, 18);
            this.lblUocSo.TabIndex = 3;
            this.lblUocSo.Text = "Ước số chung lớn nhất";
            // 
            // lblBoiSo
            // 
            this.lblBoiSo.AutoSize = true;
            this.lblBoiSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoiSo.Location = new System.Drawing.Point(80, 279);
            this.lblBoiSo.Name = "lblBoiSo";
            this.lblBoiSo.Size = new System.Drawing.Size(156, 18);
            this.lblBoiSo.TabIndex = 4;
            this.lblBoiSo.Text = "Bội số chung nhỏ nhất";
            // 
            // txtBxNhapSoA
            // 
            this.txtBxNhapSoA.Location = new System.Drawing.Point(207, 148);
            this.txtBxNhapSoA.Name = "txtBxNhapSoA";
            this.txtBxNhapSoA.Size = new System.Drawing.Size(200, 20);
            this.txtBxNhapSoA.TabIndex = 5;
            this.txtBxNhapSoA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBxNhapSoA_KeyPress);
            // 
            // txtBxNhapSoB
            // 
            this.txtBxNhapSoB.Location = new System.Drawing.Point(207, 191);
            this.txtBxNhapSoB.Name = "txtBxNhapSoB";
            this.txtBxNhapSoB.Size = new System.Drawing.Size(200, 20);
            this.txtBxNhapSoB.TabIndex = 6;
            this.txtBxNhapSoB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBxNhapSoB_KeyPress);
            // 
            // txtBxUocSo
            // 
            this.txtBxUocSo.Location = new System.Drawing.Point(257, 239);
            this.txtBxUocSo.Name = "txtBxUocSo";
            this.txtBxUocSo.ReadOnly = true;
            this.txtBxUocSo.Size = new System.Drawing.Size(150, 20);
            this.txtBxUocSo.TabIndex = 7;
            // 
            // txtBxBoiSo
            // 
            this.txtBxBoiSo.Location = new System.Drawing.Point(257, 280);
            this.txtBxBoiSo.Name = "txtBxBoiSo";
            this.txtBxBoiSo.ReadOnly = true;
            this.txtBxBoiSo.Size = new System.Drawing.Size(150, 20);
            this.txtBxBoiSo.TabIndex = 8;
            // 
            // btnThucHien
            // 
            this.btnThucHien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThucHien.Location = new System.Drawing.Point(81, 359);
            this.btnThucHien.Name = "btnThucHien";
            this.btnThucHien.Size = new System.Drawing.Size(100, 40);
            this.btnThucHien.TabIndex = 9;
            this.btnThucHien.Text = "Thực Hiện";
            this.btnThucHien.UseVisualStyleBackColor = true;
            this.btnThucHien.Click += new System.EventHandler(this.btnThucHien_Click);
            // 
            // btnTiepTuc
            // 
            this.btnTiepTuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTiepTuc.Location = new System.Drawing.Point(187, 359);
            this.btnTiepTuc.Name = "btnTiepTuc";
            this.btnTiepTuc.Size = new System.Drawing.Size(100, 40);
            this.btnTiepTuc.TabIndex = 10;
            this.btnTiepTuc.Text = "Tiếp Tục";
            this.btnTiepTuc.UseVisualStyleBackColor = true;
            this.btnTiepTuc.Click += new System.EventHandler(this.btnTiepTuc_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(307, 359);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 40);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // F_BoiSo_UocSo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTiepTuc);
            this.Controls.Add(this.btnThucHien);
            this.Controls.Add(this.txtBxBoiSo);
            this.Controls.Add(this.txtBxUocSo);
            this.Controls.Add(this.txtBxNhapSoB);
            this.Controls.Add(this.txtBxNhapSoA);
            this.Controls.Add(this.lblBoiSo);
            this.Controls.Add(this.lblUocSo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNhapSoA);
            this.Controls.Add(this.lblUocSo_BoiSo);
            this.Name = "F_BoiSo_UocSo";
            this.Text = "Ước Số Chung - Bội Số Chung";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUocSo_BoiSo;
        private System.Windows.Forms.Label lblNhapSoA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUocSo;
        private System.Windows.Forms.Label lblBoiSo;
        private System.Windows.Forms.TextBox txtBxNhapSoA;
        private System.Windows.Forms.TextBox txtBxNhapSoB;
        private System.Windows.Forms.TextBox txtBxUocSo;
        private System.Windows.Forms.TextBox txtBxBoiSo;
        private System.Windows.Forms.Button btnThucHien;
        private System.Windows.Forms.Button btnTiepTuc;
        private System.Windows.Forms.Button btnThoat;
    }
}

