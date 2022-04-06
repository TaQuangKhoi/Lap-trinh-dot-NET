using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi_7
{
    public partial class FormCapNhatThongTinSinhVien : Form
    {
        public FormCapNhatThongTinSinhVien()
        {
            InitializeComponent();
        }

        private void FormCapNhatThongTinSinhVien_Load(object sender, EventArgs e)
        {
            lvwDanhSachSinhVien.Items.Add("20035435"); // Thêm dữ liệu cho dòng index 0
            lvwDanhSachSinhVien.Items[0].SubItems.Add("Tạ Quang Khôi");
            lvwDanhSachSinhVien.Items[0].SubItems.Add("27/08/2002");
            lvwDanhSachSinhVien.Items[0].SubItems.Add("Nam");

            lvwDanhSachSinhVien.Items.Add("20035000"); // Thêm dữ liệu cho dòng index 0
            lvwDanhSachSinhVien.Items[1].SubItems.Add("Phan Trung Long");
            lvwDanhSachSinhVien.Items[1].SubItems.Add("02/05/2002");
            lvwDanhSachSinhVien.Items[1].SubItems.Add("Nam");

            lvwDanhSachSinhVien.Items.Add("20034070"); // Thêm dữ liệu cho dòng index 0
            lvwDanhSachSinhVien.Items[2].SubItems.Add("Trần Trọng Tiến");
            lvwDanhSachSinhVien.Items[2].SubItems.Add("02/02/2001");
            lvwDanhSachSinhVien.Items[2].SubItems.Add("Nam");

            lvwDanhSachSinhVien.Items.Add("20035000"); // Thêm dữ liệu cho dòng index 0
            lvwDanhSachSinhVien.Items[3].SubItems.Add("Lê Quốc Khánh");
            lvwDanhSachSinhVien.Items[3].SubItems.Add("02/09/2001");
            lvwDanhSachSinhVien.Items[3].SubItems.Add("Nam");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // lvwDanhSachSinhVien.Items.Remove(lvwDanhSachSinhVien.FocusedItem);
            // Hai cách đều chạy giống nhau
            lvwDanhSachSinhVien.FocusedItem.Remove();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int d = lvwDanhSachSinhVien.Items.Count;
            if (tBxMSSV.Text.Equals("") || tBxTen.Text.Equals("") || tBxNgaySinh.Text.Equals("") || tBxGioiTinh.Text.Equals(""))
            {
                MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (KiemTraTrung(lvwDanhSachSinhVien, tBxMSSV.Text.ToString()))
            {
                MessageBox.Show("Mã sinh viên đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                lvwDanhSachSinhVien.Items.Add(tBxMSSV.Text.ToString());
                lvwDanhSachSinhVien.Items[d].SubItems.Add(tBxTen.Text.ToString());
                lvwDanhSachSinhVien.Items[d].SubItems.Add(tBxNgaySinh.Text.ToString());
                lvwDanhSachSinhVien.Items[d].SubItems.Add(tBxGioiTinh.Text.ToString());
            }
        }
        bool KiemTraTrung(ListView lv, string MSSV)
        {
            for (int i = 0; i < lvwDanhSachSinhVien.Items.Count; i++)
            {
                if (lv.Items[i].Text == MSSV)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
