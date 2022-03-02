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
            
            HienThongTin hienThongTin = new HienThongTin();
            hienThongTin.Show();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {

        }
        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBoxYourName_Leave(object sender, EventArgs e)
        {
            if (textBoxYourName.Text.Trim().Length == 0)
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
