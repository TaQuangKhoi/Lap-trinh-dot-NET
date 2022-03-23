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
    public partial class fNhap3diem : Form
    {
        public fNhap3diem()
        {
            InitializeComponent();
        }

        private void txt_DiemToan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txt_DiemVan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txt_DiemAnh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btn_XetTuyen_Click(object sender, EventArgs e)
        {
            double DiemToan, DiemVan, DiemAnh, Tong;
            if (txt_DiemToan.Text != "" && txt_DiemVan.Text != "" && txt_DiemAnh.Text != "")
            {
                DiemToan = Convert.ToDouble(txt_DiemToan.Text);
                DiemVan = Convert.ToDouble(txt_DiemVan.Text);
                DiemAnh = Convert.ToDouble(txt_DiemAnh.Text);
                Tong = DiemToan + DiemVan + DiemAnh;
                if(cbHSGQG.Checked == true)
                {
                    Tong = Tong + 1;
                }
                if(cbCTBLS.Checked == true)
                {
                    Tong = Tong + 1.5;
                }
                if (cbVC.Checked == true)
                {
                    Tong = Tong + 2;
                }
                if (cbDTTS.Checked == true)
                {
                    Tong = Tong + 0.5;
                }
                if (DiemToan < 0 || DiemToan > 10)
                {
                    MessageBox.Show("Nhập lại", "Thông báo");
                    txt_DiemToan.Text = "";
                    txt_DiemToan.Focus();
                }
                else if (DiemVan < 0 || DiemVan > 10)
                {
                    MessageBox.Show("Nhập lại", "Thông báo");
                    txt_DiemVan.Text = "";
                    txt_DiemVan.Focus();
                }
                else if (DiemAnh < 0 || DiemAnh > 10)
                {
                    MessageBox.Show("Nhập lại", "Thông báo");
                    txt_DiemAnh.Text = "";
                    txt_DiemAnh.Focus();
                }
                else
                {
                    if(DiemToan <= 3 || DiemVan <= 3 || DiemAnh <= 3)
                    {
                        MessageBox.Show("Rất tiếc bạn có ít nhất 1 điểm liệt", "Thông báo");
                    }
                    else
                    {
                        if (rdDHBRVT.Checked == false && rdBK.Checked == false && rdKHTN.Checked == false)
                        {
                            MessageBox.Show("Vui lòng chọn trường", "Thông báo");
                        }
                        else
                        {
                            if (Tong >= 24 && rdKHTN.Checked == true)
                            {
                                if (rdCNTT.Checked == true || rdDuLich.Checked == true || rdKinhTe.Checked == true || rdXayDung.Checked == true)
                                {
                                    if (rdCNTT.Checked == true)
                                    {
                                        MessageBox.Show("Điểm của bạn là: " + Tong + " Bạn đã trúng tuyển " + rdKHTN.Text + " ngành " + rdCNTT.Text, "Thông báo");
                                    }
                                    else if (rdDuLich.Checked == true)
                                    {
                                        MessageBox.Show("Điểm của bạn là: " + Tong + " Bạn đã trúng tuyển " + rdKHTN.Text + " ngành " + rdDuLich.Text, "Thông báo");
                                    }
                                    else if (rdKinhTe.Checked == true)
                                    {
                                        MessageBox.Show("Điểm của bạn là: " + Tong + " Bạn đã trúng tuyển " + rdKHTN.Text + " ngành " + rdKinhTe.Text, "Thông báo");
                                    }
                                    else
                                    {
                                        MessageBox.Show("Điểm của bạn là: " + Tong + " Bạn đã trúng tuyển " + rdKHTN.Text + " ngành " + rdXayDung.Text, "Thông báo");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Vui lòng chọn ngành", "Thông báo");
                                }
                            }
                            else if (Tong >= 22 && rdBK.Checked == true)
                            {
                                if (rdCNTT.Checked == true || rdDuLich.Checked == true || rdKinhTe.Checked == true || rdXayDung.Checked == true)
                                {
                                    if (rdCNTT.Checked == true)
                                    {
                                        MessageBox.Show("Điểm của bạn là: " + Tong + " Bạn đã trúng tuyển " + rdBK.Text + " ngành " + rdCNTT.Text, "Thông báo");
                                    }
                                    else if (rdDuLich.Checked == true)
                                    {
                                        MessageBox.Show("Điểm của bạn là: " + Tong + " Bạn đã trúng tuyển " + rdBK.Text + " ngành " + rdDuLich.Text, "Thông báo");
                                    }
                                    else if (rdKinhTe.Checked == true)
                                    {
                                        MessageBox.Show("Điểm của bạn là: " + Tong + " Bạn đã trúng tuyển " + rdBK.Text + " ngành " + rdKinhTe.Text, "Thông báo");
                                    }
                                    else
                                    {
                                        MessageBox.Show("Điểm của bạn là: " + Tong + " Bạn đã trúng tuyển " + rdBK.Text + " ngành " + rdXayDung.Text, "Thông báo");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Vui lòng chọn ngành", "Thông báo");
                                }
                            }
                            else if (Tong >= 18 && rdDHBRVT.Checked == true)
                            {
                                if (rdCNTT.Checked == true || rdDuLich.Checked == true || rdKinhTe.Checked == true || rdXayDung.Checked == true)
                                {
                                    if (rdCNTT.Checked == true)
                                    {
                                        MessageBox.Show("Điểm của bạn là: " + Tong + " Bạn đã trúng tuyển " + rdDHBRVT.Text + " ngành " + rdCNTT.Text, "Thông báo");
                                    }
                                    else if (rdDuLich.Checked == true)
                                    {
                                        MessageBox.Show("Điểm của bạn là: " + Tong + " Bạn đã trúng tuyển " + rdDHBRVT.Text + " ngành " + rdDuLich.Text, "Thông báo");
                                    }
                                    else if (rdKinhTe.Checked == true)
                                    {
                                        MessageBox.Show("Điểm của bạn là: " + Tong + " Bạn đã trúng tuyển " + rdDHBRVT.Text + " ngành " + rdKinhTe.Text, "Thông báo");
                                    }
                                    else
                                    {
                                        MessageBox.Show("Điểm của bạn là: " + Tong + " Bạn đã trúng tuyển " + rdDHBRVT.Text + " ngành " + rdXayDung.Text, "Thông báo");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Vui lòng chọn ngành", "Thông báo");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Bạn đã rớt trường này", "Thông báo");
                            }
                        }
                    }
                }
            }
            else
            {
                
                MessageBox.Show("Không được rỗng", "Thông báo");
            }
        }

        private void rdDHBRVT_Click(object sender, EventArgs e)
        {
            if (rdDHBRVT.Checked == true)
            {
                labelShowDH1.Text = "18";
                labelShowDH2.Text = "";
                labelShowDH3.Text = "";
            }
        }

        private void rdBK_Click(object sender, EventArgs e)
        {
            if (rdBK.Checked == true)
            {
                labelShowDH2.Text = "22";
                labelShowDH1.Text = "";
                labelShowDH3.Text = "";
            }
        }

        private void rdKHTN_Click(object sender, EventArgs e)
        {
            if (rdKHTN.Checked == true)
            {
                labelShowDH3.Text = "24";
                labelShowDH1.Text = "";
                labelShowDH2.Text = "";
            }
        }

        private void rdDHBRVT_CheckedChanged(object sender, EventArgs e)
        {
            if (rdDHBRVT.Checked == true)
            {
                rdCNTT.Enabled = true;
                rdDuLich.Enabled = true;
                rdKinhTe.Enabled = true;
                rdXayDung.Enabled = true;
            }
        }

        private void rdBK_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBK.Checked == true)
            {
                rdCNTT.Enabled = true;
                rdDuLich.Enabled = true;
                rdKinhTe.Enabled = false;
                rdXayDung.Enabled = false;
            }
        }

        private void rdKHTN_CheckedChanged(object sender, EventArgs e)
        {
            if (rdKHTN.Checked == true)
            {
                rdCNTT.Enabled = true;
                rdDuLich.Enabled = true;
                rdKinhTe.Enabled = true;
                rdXayDung.Enabled = false;
            }
        }
    }
}
