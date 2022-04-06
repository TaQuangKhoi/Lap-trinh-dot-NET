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
    public partial class FormQuanLySV : Form
    {
        public FormQuanLySV()
        {
            InitializeComponent();
            //IsMdiContainer = true; chạy với OpenForm() của Sơn
        }

        private void tm1_Tick(object sender, EventArgs e)
        {
            //lbThoiGian.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void CapNhatThongTinSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form FormCapNhatThongTinSV = new FormCapNhatThongTinSinhVien();
            //FormCapNhatThongTinSV.Show();
            OpenChildForm(FormCapNhatThongTinSV, panelFormCon);
        }

        // By Thịnh và Khôi
        void OpenChildForm(Form f, Panel p)
        {
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;

            p.Controls.Add(f);
            p.Tag = f;
            f.BringToFront();
            f.Show();
            this.Text = f.Text;
        }

        // sơn dùng MDI, không cần panel
        void OpenForm(Form f)
        {
            foreach (Form item in this.MdiChildren) // Đóng tất cả các form khác 
            {
                item.Close();
            }
            f.Show();
            f.MdiParent = this;
            f.Dock = DockStyle.Fill;
            f.FormBorderStyle = FormBorderStyle.None;
        }

        private void capNhatThongTinToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
