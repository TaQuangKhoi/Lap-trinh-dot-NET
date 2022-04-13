﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Buoi_8
{
    public partial class QuanLySinhVien : Form
    {
        Form fKhoa = new fKhoa();
        public QuanLySinhVien()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }


        private void Khoa_Click(object sender, EventArgs e)
        {
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

        private void QuanLySinhVien_Load(object sender, EventArgs e)
        {
            
        }
    }
}