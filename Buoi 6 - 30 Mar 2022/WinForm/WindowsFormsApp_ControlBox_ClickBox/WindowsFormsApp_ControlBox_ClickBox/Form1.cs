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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        public bool KiemTraTrung (string SanPham)
        {
            int i = 0;
            int d = lBxSanPham.Items.Count;
            bool KiemTra = false;
            for (i = 0; i < d; i++)
            {
                if (lBxSanPham.Items[i].ToString() == SanPham)
                {
                    KiemTra = true;
                }
            }
            return KiemTra;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lBxSanPham.Items.Add("Sua");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            lBxSanPham.Items.Remove(lBxSanPham.SelectedItem);
        }

        private void lBxSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lBxSanPham.SelectedItem != null)
            {
                tBxSanPhamDangChon.Text = lBxSanPham.SelectedItem.ToString();
            }
        }

        private void btnChuyen_Click(object sender, EventArgs e)
        {
            lBxSanPham2.Items.AddRange(lBxSanPham.Items);
        }

        private void lBxSanPham_SizeChanged(object sender, EventArgs e)
        {
            tBxSoLuong.Text = lBxSanPham.Items.Count.ToString();
        }

        private void tBxNhapSP_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (KiemTraTrung(tBxNhapSP.Text) == true)
            {
                MessageBox.Show("Sản phẩm đã tồn tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                lBxSanPham.Items.Add(tBxNhapSP.Text);
            }
        }
    }
}
