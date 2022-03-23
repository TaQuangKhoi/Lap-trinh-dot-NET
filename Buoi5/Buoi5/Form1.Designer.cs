namespace Buoi5
{
    partial class fBuoi5
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
            this.rdDHBRVT = new System.Windows.Forms.RadioButton();
            this.label_NhapDiem = new System.Windows.Forms.Label();
            this.txt_NhapDiem = new System.Windows.Forms.TextBox();
            this.rdBK = new System.Windows.Forms.RadioButton();
            this.rdKHTN = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // rdDHBRVT
            // 
            this.rdDHBRVT.AutoSize = true;
            this.rdDHBRVT.Location = new System.Drawing.Point(15, 32);
            this.rdDHBRVT.Name = "rdDHBRVT";
            this.rdDHBRVT.Size = new System.Drawing.Size(147, 17);
            this.rdDHBRVT.TabIndex = 2;
            this.rdDHBRVT.Text = "Đại học Bà Rịa Vũng Tàu";
            this.rdDHBRVT.UseVisualStyleBackColor = true;
            this.rdDHBRVT.Click += new System.EventHandler(this.rdDHBRVT_Click);
            // 
            // label_NhapDiem
            // 
            this.label_NhapDiem.AutoSize = true;
            this.label_NhapDiem.Location = new System.Drawing.Point(12, 9);
            this.label_NhapDiem.Name = "label_NhapDiem";
            this.label_NhapDiem.Size = new System.Drawing.Size(59, 13);
            this.label_NhapDiem.TabIndex = 0;
            this.label_NhapDiem.Text = "Nhập điểm";
            // 
            // txt_NhapDiem
            // 
            this.txt_NhapDiem.Location = new System.Drawing.Point(77, 6);
            this.txt_NhapDiem.Name = "txt_NhapDiem";
            this.txt_NhapDiem.Size = new System.Drawing.Size(238, 20);
            this.txt_NhapDiem.TabIndex = 1;
            this.txt_NhapDiem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_NhapDiem_KeyPress);
            // 
            // rdBK
            // 
            this.rdBK.AutoSize = true;
            this.rdBK.Location = new System.Drawing.Point(15, 55);
            this.rdBK.Name = "rdBK";
            this.rdBK.Size = new System.Drawing.Size(118, 17);
            this.rdBK.TabIndex = 3;
            this.rdBK.Text = "Đại học Bách Khoa";
            this.rdBK.UseVisualStyleBackColor = true;
            this.rdBK.Click += new System.EventHandler(this.rdBK_Click);
            // 
            // rdKHTN
            // 
            this.rdKHTN.AutoSize = true;
            this.rdKHTN.Location = new System.Drawing.Point(15, 78);
            this.rdKHTN.Name = "rdKHTN";
            this.rdKHTN.Size = new System.Drawing.Size(160, 17);
            this.rdKHTN.TabIndex = 4;
            this.rdKHTN.Text = "Đại học Khoa Học Tự Nhiên";
            this.rdKHTN.UseVisualStyleBackColor = true;
            this.rdKHTN.Click += new System.EventHandler(this.rdKHTN_Click);
            // 
            // fBuoi5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 154);
            this.Controls.Add(this.rdKHTN);
            this.Controls.Add(this.rdBK);
            this.Controls.Add(this.txt_NhapDiem);
            this.Controls.Add(this.label_NhapDiem);
            this.Controls.Add(this.rdDHBRVT);
            this.Name = "fBuoi5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bài học buổi 5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdDHBRVT;
        private System.Windows.Forms.Label label_NhapDiem;
        private System.Windows.Forms.TextBox txt_NhapDiem;
        private System.Windows.Forms.RadioButton rdBK;
        private System.Windows.Forms.RadioButton rdKHTN;
    }
}

