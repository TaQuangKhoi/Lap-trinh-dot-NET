using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bai_Tap_2___Dang_Ky_Tai_Khoan;

namespace Bai_Tap_2___Dang_Ky_Tai_Khoan
{
    public partial class DangKyTaiKhoan : Form
    {
        public DangKyTaiKhoan()
        {
            InitializeComponent();
        }

        private void buttonDangKy_Click(object sender, EventArgs e)
        {
            if(txtBoxTenDangNhap.Text.Equals(""))
            {
                MessageBox.Show("Tên đăng nhập không được để trống!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBoxTenDangNhap.Focus();
            } else if (txtBoxEmail.Text.Equals(""))
            {
                MessageBox.Show("Email không được để trống!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBoxEmail.Focus();
            } else if (txtBoxMatKhau.Text.Equals(""))
            {
                MessageBox.Show("Mật khẩu không được để trống!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBoxMatKhau.Focus();
            } else if (txtBoxXNMatKhau.Text.Equals(""))
            {
                MessageBox.Show("Bạn phải xác nhận mật khẩu!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBoxXNMatKhau.Focus();
            } else if (!KiemTra.Email(txtBoxEmail.Text))
            {
                MessageBox.Show("Email vừa nhập không hợp lệ!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBoxEmail.Focus();
                
            }
        }
    }
    
}
