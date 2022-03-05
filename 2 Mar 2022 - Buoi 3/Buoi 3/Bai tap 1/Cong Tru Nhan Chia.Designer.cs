namespace Bai_tap_1
{
    partial class FormCongTruNhanChia
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
            this.lblNumberA = new System.Windows.Forms.Label();
            this.lblNumberB = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtBoxNumberA = new System.Windows.Forms.TextBox();
            this.txtBoxNumberB = new System.Windows.Forms.TextBox();
            this.txtBoxResult = new System.Windows.Forms.TextBox();
            this.btnCong = new System.Windows.Forms.Button();
            this.btnTru = new System.Windows.Forms.Button();
            this.btnNhan = new System.Windows.Forms.Button();
            this.btnChia = new System.Windows.Forms.Button();
            this.errorProviderNumberA = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderNumberB = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNumberA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNumberB)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumberA
            // 
            this.lblNumberA.AutoSize = true;
            this.lblNumberA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberA.Location = new System.Drawing.Point(88, 38);
            this.lblNumberA.Name = "lblNumberA";
            this.lblNumberA.Size = new System.Drawing.Size(46, 20);
            this.lblNumberA.TabIndex = 0;
            this.lblNumberA.Text = "Số a";
            // 
            // lblNumberB
            // 
            this.lblNumberB.AutoSize = true;
            this.lblNumberB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberB.Location = new System.Drawing.Point(88, 86);
            this.lblNumberB.Name = "lblNumberB";
            this.lblNumberB.Size = new System.Drawing.Size(46, 20);
            this.lblNumberB.TabIndex = 1;
            this.lblNumberB.Text = "Số b";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(88, 132);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(71, 20);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "Kết quả";
            // 
            // txtBoxNumberA
            // 
            this.txtBoxNumberA.Location = new System.Drawing.Point(192, 37);
            this.txtBoxNumberA.Name = "txtBoxNumberA";
            this.txtBoxNumberA.Size = new System.Drawing.Size(200, 20);
            this.txtBoxNumberA.TabIndex = 3;
            this.txtBoxNumberA.TextChanged += new System.EventHandler(this.txtBoxNumberA_TextChanged);
            // 
            // txtBoxNumberB
            // 
            this.txtBoxNumberB.Location = new System.Drawing.Point(192, 86);
            this.txtBoxNumberB.Name = "txtBoxNumberB";
            this.txtBoxNumberB.Size = new System.Drawing.Size(200, 20);
            this.txtBoxNumberB.TabIndex = 4;
            this.txtBoxNumberB.TextChanged += new System.EventHandler(this.txtBoxNumberB_TextChanged);
            // 
            // txtBoxResult
            // 
            this.txtBoxResult.Location = new System.Drawing.Point(192, 132);
            this.txtBoxResult.Name = "txtBoxResult";
            this.txtBoxResult.Size = new System.Drawing.Size(200, 20);
            this.txtBoxResult.TabIndex = 5;
            // 
            // btnCong
            // 
            this.btnCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCong.Location = new System.Drawing.Point(92, 177);
            this.btnCong.Name = "btnCong";
            this.btnCong.Size = new System.Drawing.Size(50, 50);
            this.btnCong.TabIndex = 6;
            this.btnCong.Text = "+";
            this.btnCong.UseVisualStyleBackColor = true;
            this.btnCong.Click += new System.EventHandler(this.btnCong_Click);
            // 
            // btnTru
            // 
            this.btnTru.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTru.Location = new System.Drawing.Point(175, 177);
            this.btnTru.Name = "btnTru";
            this.btnTru.Size = new System.Drawing.Size(50, 50);
            this.btnTru.TabIndex = 7;
            this.btnTru.Text = "-";
            this.btnTru.UseVisualStyleBackColor = true;
            this.btnTru.Click += new System.EventHandler(this.btnTru_Click);
            // 
            // btnNhan
            // 
            this.btnNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhan.Location = new System.Drawing.Point(260, 177);
            this.btnNhan.Name = "btnNhan";
            this.btnNhan.Size = new System.Drawing.Size(50, 50);
            this.btnNhan.TabIndex = 8;
            this.btnNhan.Text = "x";
            this.btnNhan.UseVisualStyleBackColor = true;
            this.btnNhan.Click += new System.EventHandler(this.btnNhan_Click);
            // 
            // btnChia
            // 
            this.btnChia.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChia.Location = new System.Drawing.Point(342, 177);
            this.btnChia.Name = "btnChia";
            this.btnChia.Size = new System.Drawing.Size(50, 50);
            this.btnChia.TabIndex = 9;
            this.btnChia.Text = "/";
            this.btnChia.UseVisualStyleBackColor = true;
            this.btnChia.Click += new System.EventHandler(this.btnChia_Click);
            // 
            // errorProviderNumberA
            // 
            this.errorProviderNumberA.ContainerControl = this;
            // 
            // errorProviderNumberB
            // 
            this.errorProviderNumberB.ContainerControl = this;
            // 
            // FormCongTruNhanChia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.btnChia);
            this.Controls.Add(this.btnNhan);
            this.Controls.Add(this.btnTru);
            this.Controls.Add(this.btnCong);
            this.Controls.Add(this.txtBoxResult);
            this.Controls.Add(this.txtBoxNumberB);
            this.Controls.Add(this.txtBoxNumberA);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblNumberB);
            this.Controls.Add(this.lblNumberA);
            this.Name = "FormCongTruNhanChia";
            this.Text = "Tính Cộng Trừ Nhân Chia";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNumberA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNumberB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumberA;
        private System.Windows.Forms.Label lblNumberB;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtBoxNumberA;
        private System.Windows.Forms.TextBox txtBoxNumberB;
        private System.Windows.Forms.TextBox txtBoxResult;
        private System.Windows.Forms.Button btnCong;
        private System.Windows.Forms.Button btnTru;
        private System.Windows.Forms.Button btnNhan;
        private System.Windows.Forms.Button btnChia;
        private System.Windows.Forms.ErrorProvider errorProviderNumberA;
        private System.Windows.Forms.ErrorProvider errorProviderNumberB;
    }
}

