using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiMoi
{
    public partial class F_BoiSo_UocSo : Form
    {
        public F_BoiSo_UocSo()
        {
            InitializeComponent();
        }

        private void txtBxNhapSoA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar) && (Keys)e.KeyChar != Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtBxNhapSoB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && (Keys)e.KeyChar != Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            if(txtBxNhapSoA.Text.Equals(""))
            {
                MessageBox.Show("Bạn chưa nhập số a", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBxNhapSoA.Focus();
            }
            else if (txtBxNhapSoB.Text.Equals(""))
            {
                MessageBox.Show("Bạn chưa nhập số b", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBxNhapSoB.Focus();
            }
            else
            {
                txtBxUocSo.Text = UCLN(int.Parse(txtBxNhapSoA.Text), int.Parse(txtBxNhapSoB.Text)).ToString();
                txtBxBoiSo.Text = BCNN(int.Parse(txtBxNhapSoA.Text), int.Parse(txtBxNhapSoB.Text)).ToString();
            }
        }
        private int UCLN(int numberA, int numberB)
        {
            int result = 1;
            if (numberA > numberB) // 9 > 3 => 3
            {
                for (int i = numberB; i > 0; i--)
                {
                    if(numberA % i == 0 && numberB % i == 0)
                    {
                        result = i;
                        break;
                    }
                }
            }
            else
            {
                for (int i = numberA; i > 0; i--)
                {
                    if (numberA % i == 0 && numberB % i == 0)
                    {
                        result = i;
                        break;
                    }
                }
            }
            return result;
        }
        private int BCNN(int numberA, int numberB)
        {
            int result;
            return result = (numberA * numberB) / UCLN(numberA, numberB);
        }

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            txtBxNhapSoA.Clear();
            txtBxNhapSoB.Clear();
            txtBxUocSo.Clear();
            txtBxBoiSo.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc thoát hay không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(dr == DialogResult.Yes)
            {
                Close();
            }
            else
            {
                return;
            }
        }
    }
}
