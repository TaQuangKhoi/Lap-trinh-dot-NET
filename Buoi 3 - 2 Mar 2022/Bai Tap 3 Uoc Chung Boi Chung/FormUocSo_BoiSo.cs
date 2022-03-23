using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_Tap_3_Uoc_Chung_Boi_Chung
{
    public partial class FormUocSoChung_BoiSoChung : Form
    {
        public FormUocSoChung_BoiSoChung()
        {
            InitializeComponent();
        }

        private void txtBxNhapSoA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && (Keys)e.KeyChar != Keys.Back)
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

        private void buttonThucHien_Click(object sender, EventArgs e)
        {
            if (txtBxNhapSoA.Text.Equals(""))
            {
                MessageBox.Show("Bạn chưa nhập số a","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }else if (txtBxNhapSoB.Text.Equals(""))
            {
                MessageBox.Show("Bạn chưa nhập số b", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            } else { 
                txtBxUocSo.Text = UCLN(int.Parse(txtBxNhapSoA.Text), int.Parse(txtBxNhapSoB.Text)).ToString();
                txtBxboiSo.Text = BCNN(int.Parse(txtBxNhapSoA.Text), int.Parse(txtBxNhapSoB.Text)).ToString();
            }
        }

        private void buttonTiepTuc_Click(object sender, EventArgs e)
        {
            txtBxNhapSoA.Clear();
            txtBxNhapSoB.Clear();
            txtBxUocSo.Clear();
            txtBxboiSo.Clear();
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát?", "Khoan Khoan", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                Application.Exit();
            } else { return; }
        }

        private int UCLN(int numberA, int numberB)
        {
            int result = 0;
            if (numberA > numberB)
            {
                for (int i = numberB; i > 0 ; i--)
                {
                    if(numberA % i == 0 && numberB % i == 0)
                    {
                        result = i;
                        break;
                    }
                }
            } else {
                for (int i = numberA; i > 0 ; i--)
                {
                    if (numberB % i == 0 && numberA % i == 0)
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
            return numberA * numberB / UCLN(numberA, numberB);
        }
    }
}
