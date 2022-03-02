using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_tap_1
{
    public partial class FormCongTruNhanChia : Form
    {
        public FormCongTruNhanChia()
        {
            InitializeComponent();

        }
        bool isNumber(string str)
        {
            for (int i = 1; i < str.Length; i++)
            {
                if (!Char.IsDigit(str[i]))
                {
                    return false;
                }
            }
            return true;
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            if (!isNumber(txtBoxNumberA.Text) || txtBoxNumberA.Text.Equals(""))
            {
                MessageBox.Show("Số không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBoxNumberA.Focus();
            }
            else if (!isNumber(txtBoxNumberB.Text) || txtBoxNumberB.Text.Equals(""))
            {
                MessageBox.Show("Số không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBoxNumberB.Focus();
            }
            else
            {
                double KetQua = double.Parse(txtBoxNumberA.Text) + double.Parse(txtBoxNumberB.Text);
                txtBoxResult.Text = KetQua.ToString();
            }
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            if (!isNumber(txtBoxNumberA.Text) || txtBoxNumberA.Text.Equals(""))
            {
                MessageBox.Show("Số không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBoxNumberA.Focus();
            }
            else if (!isNumber(txtBoxNumberB.Text) || txtBoxNumberB.Text.Equals(""))
            {
                MessageBox.Show("Số không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBoxNumberB.Focus();
            }
            else
            {
                double KetQua = double.Parse(txtBoxNumberA.Text) - double.Parse(txtBoxNumberB.Text);
                txtBoxResult.Text = KetQua.ToString();
            }
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            if (!isNumber(txtBoxNumberA.Text) || txtBoxNumberA.Text.Equals(""))
            {
                MessageBox.Show("Số không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBoxNumberA.Focus();
            }
            else if (!isNumber(txtBoxNumberB.Text) || txtBoxNumberB.Text.Equals(""))
            {
                MessageBox.Show("Số không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBoxNumberB.Focus();
            }
            else
            {
                double KetQua = double.Parse(txtBoxNumberA.Text) * double.Parse(txtBoxNumberB.Text);
                txtBoxResult.Text = KetQua.ToString();
            }
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            if (!isNumber(txtBoxNumberA.Text) || txtBoxNumberA.Text.Equals(""))
            {
                MessageBox.Show("Số không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBoxNumberA.Focus();
            }
            else if (!isNumber(txtBoxNumberB.Text) || txtBoxNumberB.Text.Equals("") || double.Parse(txtBoxNumberB.Text) == 0 )
            {
                MessageBox.Show("Số không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBoxNumberB.Focus();
            }
            else
            {
                double KetQua = double.Parse(txtBoxNumberA.Text) / double.Parse(txtBoxNumberB.Text);
                txtBoxResult.Text = KetQua.ToString();
            }
        }

        private void txtBoxNumberA_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxNumberA.Text.Length > 0 && !Char.IsDigit(txtBoxNumberA.Text[txtBoxNumberA.Text.Length - 1]))
            {
                this.errorProviderNumberA.SetError(txtBoxNumberA, "Không phải số");
            }
            else
            {
                this.errorProviderNumberA.Clear();
            }
        }
        private void txtBoxNumberB_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxNumberB.Text.Length > 0 && !Char.IsDigit(txtBoxNumberB.Text[txtBoxNumberB.Text.Length - 1]))
            {
                this.errorProviderNumberB.SetError(txtBoxNumberB, "Không phải số");
            }
            else
            {
                this.errorProviderNumberB.Clear();
            }
        }
    }
}
