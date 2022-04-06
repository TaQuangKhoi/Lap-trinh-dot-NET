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

        // Các Array ở dưới là định lưu trữ dữ liệu của các món của từng nhà hàng
        string[,] HuuNghi = new string[4, 2]
        {
            {"Cơm", "20"},
            {"Mì Xào", "40" },
            {"Thịt Kho", "50" },
            {"Vịt nướng", "140" }
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
            {"Vịt quay", "180" }
        };
        string[,] TatCa = new string[16, 2]
        {
            {"Cơm", "20"},
            {"Mì Xào", "40" },
            {"Thịt Kho", "50" },
            {"Vịt nướng", "140" },
            {"Súp", "140"},
            {"Lẩu", "250" },
            {"Tàu Hủ Chiên ", "15" },
            {"Gà nướng", "130"},
            {"Nước ngọt", "14" },
            {"Bia", "240" },
            {"Heo quay", "300" },
            {"Nem Nướng ", "150" },
            {"Há cảo", "50"},
            {"Bấp Cải", "30" },
            {"Cua", "500" },
            {"Vịt quay", "180" }
        };


        // Kiểm Tra Sản Phẩm đã có trong ListBoxDanhSachDaChon chưa?
        public bool KiemTraTrung(string SanPham, ListBox lb)
        {
            int i = 0;
            int d = lb.Items.Count;
            bool KiemTra = false;
            for (i = 0; i < d; i++)
            {
                if (lb.Items[i].ToString() == SanPham)
                {
                    KiemTra = true;
                }
            }
            return KiemTra;
        }
        public bool TimGia(string SanPham, string[,]lb, out int i)
        {
            bool KiemTra = false;
            for (i = 0; i < 16; i++)
            {
                if (lb[i,0].ToString() == SanPham)
                {
                    KiemTra = true;
                    break;
                }
            }
            return KiemTra;
        }

        // Thêm các nhà hàng vào ComboBox khi
        private void PhucVuAmThuc_Load(object sender, EventArgs e)
        {
            coBxChonNhaHang.Items.Add("Nhà Hàng Hữu Nghị");
            coBxChonNhaHang.Items.Add("Nhà Hàng Bá Hùng");
            coBxChonNhaHang.Items.Add("Nhà Hàng Hồ Mây");
            coBxChonNhaHang.Items.Add("Nhà Hàng Lâm Đường");
        }

        // Hiện các món tuỳ theo nhà hàng được chọn
        private void cBxChonNhaHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (coBxChonNhaHang.SelectedIndex == 0)
            {
                // Cơm 20, Mì Xào 40, Thịt Kho 50, Vịt nướng 140
                lBxDanhSachMonAn.Items.Clear();

                // MonAn Com = new MonAn("Cơm", 20);
                lBxDanhSachMonAn.Items.Add("Cơm");

                // MonAn MiXao = new MonAn("Mì Xào", 40);
                lBxDanhSachMonAn.Items.Add("Mì Xào");

                // MonAn ThitKho = new MonAn("Thịt kho", 50);
                lBxDanhSachMonAn.Items.Add("Thịt kho");

                // MonAn VitNuong = new MonAn("Vịt nướng", 140);
                lBxDanhSachMonAn.Items.Add("Vịt nướng");

            }
            else if (coBxChonNhaHang.SelectedIndex == 1)
            {
                // Súp 140, Lẩu 250, Tàu Hủ Chiên 15
                lBxDanhSachMonAn.Items.Clear();
                lBxDanhSachMonAn.Items.Add("Súp");
                lBxDanhSachMonAn.Items.Add("Lẩu");
                lBxDanhSachMonAn.Items.Add("Tàu Hủ Chiên");
            }
            else if (coBxChonNhaHang.SelectedIndex == 2)
            {
                //Gà nướng 130, Nước ngọt 14, Bia 20 / chai - 240 / thùng, Heo quay 300, Nem Nướng 150
                lBxDanhSachMonAn.Items.Clear();
                lBxDanhSachMonAn.Items.Add("Gà nướng");
                lBxDanhSachMonAn.Items.Add("Nước ngọt");
                lBxDanhSachMonAn.Items.Add("Bia");
                lBxDanhSachMonAn.Items.Add("Heo quay");
                lBxDanhSachMonAn.Items.Add("Nai Nướng");
            }
            else if (coBxChonNhaHang.SelectedIndex == 3)
            {
                //Há cảo 50, Bấp Cải 30, Cua 500k / kg, Vịt quay 180
                lBxDanhSachMonAn.Items.Clear();
                lBxDanhSachMonAn.Items.Add("Há cảo");
                lBxDanhSachMonAn.Items.Add("Bấp Cải");
                lBxDanhSachMonAn.Items.Add("Cua");
                lBxDanhSachMonAn.Items.Add("Vịt quay");
            }
        }

        // Nút Thêm - Tính Tổng Tiền và Tổng Số Món
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (lBxDanhSachMonAn.SelectedItem == null)
            {
                MessageBox.Show("Chưa chọn Sản phẩm", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (KiemTraTrung(lBxDanhSachMonAn.SelectedItem.ToString(), lBxDanhSachDaChon) == true)
            {
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

        // Thêm Tất Cả Các Món Của Nhà Hàng
        private void btnThemTatCa_Click(object sender, EventArgs e)
        {
            // lBxDanhSachDaChon.Items.AddRange(lBxDanhSachMonAn.Items);
            // tBxTongSoMon.Text = lBxDanhSachDaChon.Items.Count.ToString();

            int d = lBxDanhSachMonAn.Items.Count;
            int soMonTrung = 0; //Số món trùng

            for (int i = 0; i < d; i++)
            {
                if (KiemTraTrung(lBxDanhSachMonAn.Items[i].ToString(), lBxDanhSachDaChon) == true)
                {
                    soMonTrung++;
                    // MessageBox.Show("Có Sản phẩm đã tồn tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    // lBxDanhSachDaChon.Items.Add(lBxDanhSachMonAn.SelectedItem);
                    lBxDanhSachDaChon.Items.Add(lBxDanhSachMonAn.Items[i]);
                    // Tính tổng tiền tuỳ từng nhà hàng đang chọn
                    if (coBxChonNhaHang.SelectedIndex == 0)
                    {
                        TongTien = TongTien + Int32.Parse(HuuNghi[i,1]);
                    }
                    else if (coBxChonNhaHang.SelectedIndex == 1)
                    {
                        TongTien = TongTien + Int32.Parse(BaHung[i, 1]);
                    }
                    else if (coBxChonNhaHang.SelectedIndex == 2)
                    {
                        TongTien = TongTien + Int32.Parse(HoMay[i, 1]);
                    }
                    else if (coBxChonNhaHang.SelectedIndex == 3)
                    {
                        TongTien = TongTien + Int32.Parse(LamDuong[i, 1]);
                    }
                    tBxTongTien.Text = TongTien.ToString();
                    tBxTongSoMon.Text = lBxDanhSachDaChon.Items.Count.ToString();
                }
            }
            
        }

        // Nút Xoá một món
        private void btnXoa_Click(object sender, EventArgs e)
        {
            int i;
            TongTien = TongTien - Int32.Parse(TatCa[0, 1]);

            for (i = 0; i < 16; i++)
            {
                if (TatCa[i,0] == lBxDanhSachDaChon.SelectedItems.ToString())
                {
                    lBxDanhSachDaChon.Items.Remove(lBxDanhSachDaChon.SelectedItem);
                    tBxTongSoMon.Text = lBxDanhSachDaChon.Items.Count.ToString();
                    tBxTongTien.Text = TongTien.ToString();
                    break;
                }
            }
        }

        private void lBxDanhSachMonAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Hiện Tên và Giá của món ăn
            if (coBxChonNhaHang.SelectedIndex == 0)
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
            if (coBxChonNhaHang.SelectedIndex == 1)
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
            if (coBxChonNhaHang.SelectedIndex == 2)
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
            if (coBxChonNhaHang.SelectedIndex == 3)
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
            tBxTongTien.Text = "";
        }
    }
}
