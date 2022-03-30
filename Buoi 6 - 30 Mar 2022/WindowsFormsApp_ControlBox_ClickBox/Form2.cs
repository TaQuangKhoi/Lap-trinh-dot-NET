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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cBxChonTruong.Items.Add("Đại Học Bà Rịa Vũng Tàu");
            cBxChonTruong.Items.Add("Đại Học Bách Khoa");
            cBxChonTruong.Items.Add("Đại Học Khoa Hoc Tự Nhiên");
            cBxChonTruong.Items.Add("Đại Học Luật");
        }

        private void cBxChonTruong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cBxChonTruong.SelectedIndex == 0)
            {
                tBxDiemChuan.Text = "18";
            }
            else if (cBxChonTruong.SelectedIndex == 1)
            {
                tBxDiemChuan.Text = "24";
            }
            else if (cBxChonTruong.SelectedIndex == 3)
            {
                tBxDiemChuan.Text = "20";
            }
            else if (cBxChonTruong.SelectedIndex == 4)
            {
                tBxDiemChuan.Text = "19";
            }
        }
    }
}
