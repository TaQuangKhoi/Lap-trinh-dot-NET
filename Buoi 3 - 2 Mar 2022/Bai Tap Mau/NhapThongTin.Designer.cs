namespace Bai_Tap_Mau
{
    partial class NhapThongTin
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
            this.lblYourName = new System.Windows.Forms.Label();
            this.lblYearofBirth = new System.Windows.Forms.Label();
            this.txtBxYourName = new System.Windows.Forms.TextBox();
            this.txtBxYearofBirth = new System.Windows.Forms.TextBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.errorProviderChuNhapTen = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderChuNhapTen)).BeginInit();
            this.SuspendLayout();
            // 
            // lblYourName
            // 
            this.lblYourName.AutoSize = true;
            this.lblYourName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYourName.Location = new System.Drawing.Point(47, 46);
            this.lblYourName.Name = "lblYourName";
            this.lblYourName.Size = new System.Drawing.Size(98, 20);
            this.lblYourName.TabIndex = 0;
            this.lblYourName.Text = "Your Name";
            // 
            // lblYearofBirth
            // 
            this.lblYearofBirth.AutoSize = true;
            this.lblYearofBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYearofBirth.Location = new System.Drawing.Point(47, 112);
            this.lblYearofBirth.Name = "lblYearofBirth";
            this.lblYearofBirth.Size = new System.Drawing.Size(111, 20);
            this.lblYearofBirth.TabIndex = 1;
            this.lblYearofBirth.Text = "Year of Birth";
            // 
            // txtBxYourName
            // 
            this.txtBxYourName.Location = new System.Drawing.Point(241, 46);
            this.txtBxYourName.Name = "txtBxYourName";
            this.txtBxYourName.Size = new System.Drawing.Size(200, 20);
            this.txtBxYourName.TabIndex = 1;
            this.txtBxYourName.Leave += new System.EventHandler(this.textBoxYourName_Leave);
            // 
            // txtBxYearofBirth
            // 
            this.txtBxYearofBirth.Location = new System.Drawing.Point(241, 112);
            this.txtBxYearofBirth.Name = "txtBxYearofBirth";
            this.txtBxYearofBirth.Size = new System.Drawing.Size(200, 20);
            this.txtBxYearofBirth.TabIndex = 2;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(51, 185);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 3;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(208, 185);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(366, 185);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 5;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // errorProviderChuNhapTen
            // 
            this.errorProviderChuNhapTen.ContainerControl = this;
            // 
            // NhapThongTin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.txtBxYearofBirth);
            this.Controls.Add(this.txtBxYourName);
            this.Controls.Add(this.lblYearofBirth);
            this.Controls.Add(this.lblYourName);
            this.Name = "NhapThongTin";
            this.Text = "Nhập Thông Tin";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderChuNhapTen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblYourName;
        private System.Windows.Forms.Label lblYearofBirth;
        private System.Windows.Forms.TextBox txtBxYourName;
        private System.Windows.Forms.TextBox txtBxYearofBirth;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.ErrorProvider errorProviderChuNhapTen;
    }
}

