namespace Buoi_8
{
    partial class Vidu
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
            this.cbbKhoa = new System.Windows.Forms.ComboBox();
            this.dgvLop = new System.Windows.Forms.DataGridView();
            this.btnHien = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbMaLop = new System.Windows.Forms.TextBox();
            this.txbTenLop = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Khoa";
            // 
            // cbbKhoa
            // 
            this.cbbKhoa.FormattingEnabled = true;
            this.cbbKhoa.Location = new System.Drawing.Point(97, 108);
            this.cbbKhoa.Name = "cbbKhoa";
            this.cbbKhoa.Size = new System.Drawing.Size(195, 21);
            this.cbbKhoa.TabIndex = 1;
            this.cbbKhoa.SelectedIndexChanged += new System.EventHandler(this.cbbKhoa_SelectedIndexChanged_1);
            // 
            // dgvLop
            // 
            this.dgvLop.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLop.Location = new System.Drawing.Point(45, 206);
            this.dgvLop.Name = "dgvLop";
            this.dgvLop.Size = new System.Drawing.Size(437, 150);
            this.dgvLop.TabIndex = 2;
            this.dgvLop.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLop_CellClick);
            this.dgvLop.SelectionChanged += new System.EventHandler(this.dgvLop_SelectionChanged);
            // 
            // btnHien
            // 
            this.btnHien.Location = new System.Drawing.Point(45, 177);
            this.btnHien.Name = "btnHien";
            this.btnHien.Size = new System.Drawing.Size(75, 23);
            this.btnHien.TabIndex = 3;
            this.btnHien.Text = "Tất Cả";
            this.btnHien.UseVisualStyleBackColor = true;
            this.btnHien.Click += new System.EventHandler(this.btnHien_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã lớp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tên lớp";
            // 
            // txbMaLop
            // 
            this.txbMaLop.Location = new System.Drawing.Point(97, 29);
            this.txbMaLop.Name = "txbMaLop";
            this.txbMaLop.Size = new System.Drawing.Size(195, 20);
            this.txbMaLop.TabIndex = 6;
            // 
            // txbTenLop
            // 
            this.txbTenLop.Location = new System.Drawing.Point(97, 63);
            this.txbTenLop.Name = "txbTenLop";
            this.txbTenLop.Size = new System.Drawing.Size(195, 20);
            this.txbTenLop.TabIndex = 7;
            // 
            // Vidu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 510);
            this.Controls.Add(this.txbTenLop);
            this.Controls.Add(this.txbMaLop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnHien);
            this.Controls.Add(this.dgvLop);
            this.Controls.Add(this.cbbKhoa);
            this.Controls.Add(this.label1);
            this.Name = "Vidu";
            this.Text = "Vidu";
            this.Load += new System.EventHandler(this.Vidu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbKhoa;
        private System.Windows.Forms.DataGridView dgvLop;
        private System.Windows.Forms.Button btnHien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbMaLop;
        private System.Windows.Forms.TextBox txbTenLop;
    }
}