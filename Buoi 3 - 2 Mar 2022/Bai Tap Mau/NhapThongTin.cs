using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_Tap_Mau
{
    public partial class NhapThongTin : Form
    {
        public NhapThongTin()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if(txtBxYourName.Text == "")
            {
                MessageBox.Show("Bạn phải nhập tên", "Khoan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else if (txtBxYearofBirth.Text == "")
            {
                MessageBox.Show("Bạn phải nhập năm sinh", "Khoan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            HienThongTin hienThongTin = new HienThongTin(txtBxYourName.Text, txtBxYearofBirth.Text);
            hienThongTin.Show();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBxYearofBirth.Clear();
            txtBxYourName.Clear();
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBoxYourName_Leave(object sender, EventArgs e)
        {
            if (txtBxYourName.Text.Trim().Length == 0)
            {
                Control control = (Control)sender;
                this.errorProviderChuNhapTen.SetError(control, "Bạn phải nhập tên");
            } else
            {
                this.errorProviderChuNhapTen.Clear();
            }
        }
    }
}
