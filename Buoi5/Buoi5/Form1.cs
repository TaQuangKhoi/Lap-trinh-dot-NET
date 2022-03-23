using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi5
{
    public partial class fBuoi5 : Form
    {
        public fBuoi5()
        {
            InitializeComponent();
        }


        private void txt_NhapDiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void rdDHBRVT_Click(object sender, EventArgs e)
        {
            if (rdDHBRVT.Checked == true && txt_NhapDiem.Text != "")
            {
                if (txt_NhapDiem.Text == "")
                {
                    MessageBox.Show("Không được rỗng", "Thông báo");
                }
                else
                {
                    if (Convert.ToDouble(txt_NhapDiem.Text) >= 0 && Convert.ToDouble(txt_NhapDiem.Text) < 30)
                    {
                        if (Convert.ToDouble(txt_NhapDiem.Text) >= 18)
                        {
                            MessageBox.Show("Trúng tuyển Đại Học Bà Rịa Vũng Tàu", "Thông báo");
                        }
                        else
                        {
                            MessageBox.Show("Chia buồn", "Thông báo");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nhập lại", "Thông báo");
                        txt_NhapDiem.Text = "";
                        txt_NhapDiem.Focus();
                    }
                }
            }
        }

        private void rdBK_Click(object sender, EventArgs e)
        {
            if (rdBK.Checked == true && txt_NhapDiem.Text != "")
            {
                if (txt_NhapDiem.Text == "")
                {
                    MessageBox.Show("Không được rỗng", "Thông báo");
                }
                else
                {
                    if (Convert.ToDouble(txt_NhapDiem.Text) >= 0 && Convert.ToDouble(txt_NhapDiem.Text) < 30)
                    {
                        if (Convert.ToDouble(txt_NhapDiem.Text) >= 22)
                        {
                            MessageBox.Show("Trúng tuyển Đại Học Bách Khoa", "Thông báo");
                        }
                        else
                        {
                            MessageBox.Show("Chia buồn", "Thông báo");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nhập lại", "Thông báo");
                        txt_NhapDiem.Text = "";
                        txt_NhapDiem.Focus();
                    }
                }
            }
        }

        private void rdKHTN_Click(object sender, EventArgs e)
        {
            if (rdKHTN.Checked == true && txt_NhapDiem.Text != "")
            {
                if (txt_NhapDiem.Text == "")
                {
                    MessageBox.Show("Không được rỗng", "Thông báo");
                }
                else
                {
                    if (Convert.ToDouble(txt_NhapDiem.Text) >= 0 && Convert.ToDouble(txt_NhapDiem.Text) < 30)
                    {
                        if (Convert.ToDouble(txt_NhapDiem.Text) >= 24)
                        {
                            MessageBox.Show("Trúng tuyển Đại Học Khoa Học Tự Nhiên", "Thông báo");
                        }
                        else
                        {
                            MessageBox.Show("Chia buồn", "Thông báo");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nhập lại", "Thông báo");
                        txt_NhapDiem.Text = "";
                        txt_NhapDiem.Focus();
                    }
                }
            }
        }
    }
}
