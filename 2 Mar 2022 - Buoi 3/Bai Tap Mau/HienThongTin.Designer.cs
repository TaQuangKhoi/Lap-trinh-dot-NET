namespace Bai_Tap_Mau
{
    partial class HienThongTin
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
            this.lblTen = new System.Windows.Forms.Label();
            this.lblNamSinh = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen.Location = new System.Drawing.Point(94, 39);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(51, 20);
            this.lblTen.TabIndex = 0;
            this.lblTen.Text = "label1";
            // 
            // lblNamSinh
            // 
            this.lblNamSinh.AutoSize = true;
            this.lblNamSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamSinh.Location = new System.Drawing.Point(94, 91);
            this.lblNamSinh.Name = "lblNamSinh";
            this.lblNamSinh.Size = new System.Drawing.Size(51, 20);
            this.lblNamSinh.TabIndex = 1;
            this.lblNamSinh.Text = "label1";
            // 
            // HienThongTin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 161);
            this.Controls.Add(this.lblNamSinh);
            this.Controls.Add(this.lblTen);
            this.Name = "HienThongTin";
            this.Text = "HienThongTin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label lblNamSinh;
    }
}