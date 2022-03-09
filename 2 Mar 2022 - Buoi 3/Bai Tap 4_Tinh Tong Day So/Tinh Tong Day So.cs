using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_Tap_4_Tinh_Tong_Day_So
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int Tong = 0;
        int TongChan = 0;
        int TongLe = 0;

        private void btnNhap_Click(object sender, EventArgs e)
        {
            Chay();
        }
        private void TinhTongCongDan() // Cộng Dần Dần Các Số
        {
            Tong += int.Parse(txtBxNhapSo.Text);
            txtBxTongDay.Text = Tong.ToString();
            
        }
        private void TinhTongChanLe()
        {
            if (int.Parse(txtBxNhapSo.Text) % 2 == 0)
            {
                TongChan += int.Parse(txtBxNhapSo.Text);
                txtBxTongChan.Text = TongChan.ToString();
            }
            else
            {
                TongLe += int.Parse(txtBxNhapSo.Text);
                txtBxTongLe.Text = TongLe.ToString();
            }
        }
        private void TinhTongList()
        {
            Tong = 0;
            for (int i = 0; i < DaySo.Count; i++)
            {
                Tong+= DaySo[i];
            }
            txtBxTongDay.Text = Tong.ToString();
        }
        private void Chay()
        {
            if (txtBxNhapSo.Text.Equals(""))
            {
                MessageBox.Show("Bạn không được để trống số", "Ê Ê", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtBxDayVuaNhap.Text.Equals(""))
            {
                txtBxDayVuaNhap.Text = txtBxNhapSo.Text;
                TinhTong();
                txtBxNhapSo.Clear();
                txtBxNhapSo.Focus();
            }
            else
            {
                txtBxDayVuaNhap.Text = txtBxDayVuaNhap.Text + " + " + txtBxNhapSo.Text;
                TinhTong();
                txtBxNhapSo.Clear();
                txtBxNhapSo.Focus();
            }
        }
        private void txtBxNhapSo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtBxNhapSo_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Chay();
            }
        }
    }
}
