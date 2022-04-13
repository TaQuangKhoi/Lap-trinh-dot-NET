using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi_8
{
    public partial class QuanLySinhVien : Form
    {
        public QuanLySinhVien()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void khoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fKhoa = new fKhoa();
            OpenForm(fKhoa);
        }

        void OpenForm(Form f)
        {
            foreach (Form item in this.MdiChildren) // Tắt tất cả các form khác
            {
                item.Close();
            }

            // Hiện form con và thiết lập cho form con
            f.MdiParent = this; // Lệnh để đưa Form vào trong Mdi
            f.Dock = DockStyle.Fill;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Show(); // Hiện Form lên
        }
    }
}
