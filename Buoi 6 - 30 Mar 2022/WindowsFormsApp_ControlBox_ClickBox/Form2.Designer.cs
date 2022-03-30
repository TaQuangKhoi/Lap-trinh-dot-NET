namespace WindowsFormsApp_ControlBox_ClickBox
{
    partial class Form2
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
            this.cBxChonTruong = new System.Windows.Forms.ComboBox();
            this.lblDiemChuan = new System.Windows.Forms.Label();
            this.tBxDiemChuan = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cBxChonTruong
            // 
            this.cBxChonTruong.FormattingEnabled = true;
            this.cBxChonTruong.Location = new System.Drawing.Point(101, 50);
            this.cBxChonTruong.Name = "cBxChonTruong";
            this.cBxChonTruong.Size = new System.Drawing.Size(200, 21);
            this.cBxChonTruong.TabIndex = 0;
            this.cBxChonTruong.SelectedIndexChanged += new System.EventHandler(this.cBxChonTruong_SelectedIndexChanged);
            // 
            // lblDiemChuan
            // 
            this.lblDiemChuan.AutoSize = true;
            this.lblDiemChuan.Location = new System.Drawing.Point(379, 53);
            this.lblDiemChuan.Name = "lblDiemChuan";
            this.lblDiemChuan.Size = new System.Drawing.Size(65, 13);
            this.lblDiemChuan.TabIndex = 1;
            this.lblDiemChuan.Text = "Điểm Chuẩn";
            // 
            // tBxDiemChuan
            // 
            this.tBxDiemChuan.Location = new System.Drawing.Point(450, 51);
            this.tBxDiemChuan.Name = "tBxDiemChuan";
            this.tBxDiemChuan.Size = new System.Drawing.Size(100, 20);
            this.tBxDiemChuan.TabIndex = 2;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tBxDiemChuan);
            this.Controls.Add(this.lblDiemChuan);
            this.Controls.Add(this.cBxChonTruong);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cBxChonTruong;
        private System.Windows.Forms.Label lblDiemChuan;
        private System.Windows.Forms.TextBox tBxDiemChuan;
    }
}