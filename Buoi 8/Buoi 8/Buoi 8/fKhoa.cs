using System;
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
    public partial class fKhoa : Form
    {
        SqlConnection conn;
        // SqlConnection conn; Khai báo đối tượng
        // conn = new SqlConnection("Data Source = DESKTOP-AN8O8G6.TQK; Initial Catalog=QLSVDN;Integrated Security=True"); Khởi tạo đối tượng
        // Data Source = DESKTOP-AN8O8G6.TQK Đường link tới Server
        // Initial Catalog=QLSVDN Chọn database
        // Integrated Security=True" Tự động quyền thực thi
        // SqlConnection conn = new SqlConnection(); Khai báo và Khởi tạo cùng một dòng
        // Có thể lưu conn string tron Setting của project

        public fKhoa()
        {
            InitializeComponent();
        }

        private void fKhoa_SizeChanged(object sender, EventArgs e)
        {
            
        }

        private void fKhoa_Load(object sender, EventArgs e)
        {

            string connStr = @"Data Source = DESKTOP-AN8O8G6\TQK; Initial Catalog=QLSVDN;Integrated Security=True";
            conn = new SqlConnection(connStr);

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            /*
            if (conn.State == ConnectionState.Open)
            {
               
                MessageBox.Show("da the ket noi");
            }
            */

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO KHOA VALUES('"+txbMaKhoa.Text+"', '"+txbTenKhoa.Text+"')";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM KHOA WHERE MaKhoa = '" + txbMaKhoa.Text + "')";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string query = "UPDATE KHOA SET TenKhoa = '" + txbTenKhoa.Text + "' WHERE MaKhoa = '" + txbMaKhoa.Text + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
