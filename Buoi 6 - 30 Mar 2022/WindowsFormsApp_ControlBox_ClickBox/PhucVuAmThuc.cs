using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_ControlBox_ClickBox
{
    public partial class PhucVuAmThuc : Form
    {
        int TongTien = 0;
        public PhucVuAmThuc()
        {
            InitializeComponent();
        }

        string[,] HuuNghi = new string[4, 2]
        {
            {"Cơm", "20"},
            {"Mì Xào", "40" },
            {"Thịt Kho", "50" },
            {"Vịt nướng", "140" },
        };
        string[,] BaHung = new string[3, 2]
        {
            //Súp 140, Lẩu 250, Tàu Hủ Chiên 15
            {"Súp", "140"},
            {"Lẩu", "250" },
            {"Tàu Hủ Chiên ", "15" }
        };
        string[,] HoMay = new string[5, 2]
        {
            //Gà nướng 130, Nước ngọt 14, Bia 20 / chai - 240 / thùng, Heo quay 300, Nem Nướng 150
            {"Gà nướng", "130"},
            {"Nước ngọt", "14" },
            {"Bia", "240" },
            {"Heo quay", "300" },
            {"Nem Nướng ", "150" }
        };
        string[,] LamDuong = new string[4, 2]
        {
            //Há cảo 50, Bấp Cải 30, Cua 500k / kg, Vịt quay 180
            {"Há cảo", "50"},
            {"Bấp Cải", "30" },
            {"Cua", "500" },
            {"Vịt quay", "180" },
        };


        public bool KiemTraTrung(string SanPham)
        {
            int i = 0;
            int d = lBxDanhSachDaChon.Items.Count;
            bool KiemTra = false;
            for (i = 0; i < d; i++)
            {
                if (lBxDanhSachDaChon.Items[i].ToString() == SanPham)
                {
                    KiemTra = true;
                }
            }
            return KiemTra;
        }


        private void PhucVuAmThuc_Load(object sender, EventArgs e)
        {
            cBxChonNhaHang.Items.Add("Nhà Hàng Hữu Nghị");
            cBxChonNhaHang.Items.Add("Nhà Hàng Bá Hùng");
            cBxChonNhaHang.Items.Add("Nhà Hàng Hồ Mây"); 
            cBxChonNhaHang.Items.Add("Nhà Hàng Lâm Đường"); 
        }

        private void cBxChonNhaHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBxChonNhaHang.SelectedIndex == 0)
            {
                //Cơm 20, Mì Xào 40, Thịt Kho 50, Vịt nướng 140
                lBxDanhSachMonAn.Items.Clear();

                MonAn Com = new MonAn("Cơm", 20);
                lBxDanhSachMonAn.Items.Add("Cơm");

                MonAn MiXao = new MonAn("Mì Xào", 40);
                lBxDanhSachMonAn.Items.Add("Mì Xào");

                MonAn ThitKho = new MonAn("Thịt kho", 50);
                lBxDanhSachMonAn.Items.Add("Thịt kho");

                MonAn VitNuong = new MonAn("Vịt nướng", 140);
                lBxDanhSachMonAn.Items.Add("Vịt nướng");

            }
            else if (cBxChonNhaHang.SelectedIndex == 1)
            {
                //Súp 140, Lẩu 250, Tàu Hủ Chiên 15
                lBxDanhSachMonAn.Items.Clear();
                lBxDanhSachMonAn.Items.Add("Súp");
                lBxDanhSachMonAn.Items.Add("Lẩu");
                lBxDanhSachMonAn.Items.Add("Tàu Hủ Chiên");
            }
            else if (cBxChonNhaHang.SelectedIndex == 2)
            {
                //Gà nướng 130, Nước ngọt 14, Bia 20 / chai - 240 / thùng, Heo quay 300, Nem Nướng 150
                lBxDanhSachMonAn.Items.Clear();
                lBxDanhSachMonAn.Items.Add("Gà nướng");
                lBxDanhSachMonAn.Items.Add("Nước ngọt");
                lBxDanhSachMonAn.Items.Add("Bia");
                lBxDanhSachMonAn.Items.Add("Heo quay");
                lBxDanhSachMonAn.Items.Add("Nai Nướng");
            }
            else if (cBxChonNhaHang.SelectedIndex == 3)
            {
                //Há cảo 50, Bấp Cải 30, Cua 500k / kg, Vịt quay 180
                lBxDanhSachMonAn.Items.Clear();
                lBxDanhSachMonAn.Items.Add("Há cảo");
                lBxDanhSachMonAn.Items.Add("Bấp Cải");
                lBxDanhSachMonAn.Items.Add("Cua");
                lBxDanhSachMonAn.Items.Add("Vịt quay");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (KiemTraTrung(lBxDanhSachMonAn.SelectedItem.ToString()) == true){
                MessageBox.Show("Sản phẩm đã tồn tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                lBxDanhSachDaChon.Items.Add(lBxDanhSachMonAn.SelectedItem);
                TongTien = TongTien + Int32.Parse(tBxGiaTien.Text);
                tBxTongTien.Text = TongTien.ToString();
                tBxTongSoMon.Text = lBxDanhSachDaChon.Items.Count.ToString();
            }
        }

        private void btnThemTatCa_Click(object sender, EventArgs e)
        {
            lBxDanhSachDaChon.Items.AddRange(lBxDanhSachMonAn.Items);
            tBxTongSoMon.Text = lBxDanhSachDaChon.Items.Count.ToString();
            int d = lBxDanhSachMonAn.Items.Count;
            int soMonTrung = 0;
            if (cBxChonNhaHang.SelectedIndex == 0)
            {
                for (int i = 0; i < d; i++)
                {
                    if (KiemTraTrung(lBxDanhSachMonAn.Items[i].ToString()) == true)
                    {
                        soMonTrung++;
                        //MessageBox.Show("Có Sản phẩm đã tồn tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        lBxDanhSachDaChon.Items.Add(lBxDanhSachMonAn.SelectedItem);
                        TongTien = TongTien + Int32.Parse(tBxGiaTien.Text);
                        tBxTongTien.Text = TongTien.ToString();
                        tBxTongSoMon.Text = lBxDanhSachDaChon.Items.Count.ToString();
                    }
                }
            }
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            lBxDanhSachDaChon.Items.Remove(lBxDanhSachDaChon.SelectedItem);
            tBxTongSoMon.Text = lBxDanhSachDaChon.Items.Count.ToString();

        }

        private void lBxDanhSachMonAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Hiện Tên và Giá của món ăn
            if (cBxChonNhaHang.SelectedIndex == 0)
            {
                tBxTenMonDaChon.Text = lBxDanhSachMonAn.SelectedItem.ToString();
                if (lBxDanhSachMonAn.SelectedIndex == 0)
                {
                    tBxGiaTien.Text = "20";
                }
                if (lBxDanhSachMonAn.SelectedIndex == 1)
                {
                    tBxGiaTien.Text = "40";
                }
                if (lBxDanhSachMonAn.SelectedIndex == 2)
                {
                    tBxGiaTien.Text = "50";
                }
                if (lBxDanhSachMonAn.SelectedIndex == 3)
                {
                    tBxGiaTien.Text = "140";
                }
            }
            if (cBxChonNhaHang.SelectedIndex == 1)
            {
                tBxTenMonDaChon.Text = lBxDanhSachMonAn.SelectedItem.ToString();
                if (lBxDanhSachMonAn.SelectedIndex == 0)
                {
                    tBxGiaTien.Text = "140";
                }
                if (lBxDanhSachMonAn.SelectedIndex == 1)
                {
                    tBxGiaTien.Text = "250";
                }
                if (lBxDanhSachMonAn.SelectedIndex == 2)
                {
                    tBxGiaTien.Text = "15";
                }
            }
            if (cBxChonNhaHang.SelectedIndex == 2)
            {
                tBxTenMonDaChon.Text = lBxDanhSachMonAn.SelectedItem.ToString();
                if (lBxDanhSachMonAn.SelectedIndex == 0)
                {
                    tBxGiaTien.Text = "130";
                }
                if (lBxDanhSachMonAn.SelectedIndex == 1)
                {
                    tBxGiaTien.Text = "14";
                }
                if (lBxDanhSachMonAn.SelectedIndex == 2)
                {
                    tBxGiaTien.Text = "250";
                }
                if (lBxDanhSachMonAn.SelectedIndex == 3)
                {
                    tBxGiaTien.Text = "50";
                }
                if (lBxDanhSachMonAn.SelectedIndex == 4)
                {
                    tBxGiaTien.Text = "150";
                }
            }
            if (cBxChonNhaHang.SelectedIndex == 3)
            {
                tBxTenMonDaChon.Text = lBxDanhSachMonAn.SelectedItem.ToString();
                if (lBxDanhSachMonAn.SelectedIndex == 0)
                {
                    tBxGiaTien.Text = "50";
                }
                if (lBxDanhSachMonAn.SelectedIndex == 1)
                {
                    tBxGiaTien.Text = "30";
                }
                if (lBxDanhSachMonAn.SelectedIndex == 2)
                {
                    tBxGiaTien.Text = "500";
                }
                if (lBxDanhSachMonAn.SelectedIndex == 3)
                {
                    tBxGiaTien.Text = "180";
                }
            }
        }

        private void btnXoaTatCa_Click(object sender, EventArgs e)
        {
            lBxDanhSachDaChon.Items.Clear();
            tBxTongSoMon.Text = lBxDanhSachDaChon.Items.Count.ToString();
            tBxTongTien.Text = 0;
        }
    }
}
