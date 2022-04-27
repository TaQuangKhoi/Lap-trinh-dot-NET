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
            string connStr = @"Data Source = .\TQK; Initial Catalog=QLSVDN;Integrated Security=True";
            conn = new SqlConnection(connStr);

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        
        
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (KiemTra.KiemTraMaKhoa(txbMaKhoa.Text) == 0)
            {
                MessageBox.Show("Trùng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (KiemTra.KiemTraMaKhoa(txbMaKhoa.Text) == 2)
            {
                MessageBox.Show("Độ dài vượt quá 4 ký tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string queryThem = "INSERT INTO KHOA VALUES('" + txbMaKhoa.Text + "', '" + txbTenKhoa.Text + "')";
                SqlCommand cmdThem = new SqlCommand(queryThem, conn);
                cmdThem.ExecuteNonQuery();
            }
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

        private void btnHien_Click(object sender, EventArgs e)
        {
            string query = "SELECT COUNT(*) FROM KHOA";
            SqlCommand cmd = new SqlCommand(query, conn);
            int TongSoKhoa = (int)cmd.ExecuteScalar();
            // ExecuteScalar() trả về giá trị ô đầu tiên của dòng đầu tiên của bảng SELECT
            txbTongSoKhoa.Text = TongSoKhoa.ToString();
        }

        private void btnHienLuoi_Click(object sender, EventArgs e)
        {
            lvKhoa.Items.Clear();
            int i = 0;
            string query = "SELECT * FROM KHOA";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader table;
            table = cmd.ExecuteReader(); // ExecuteReader() trả về một bảng dữ liệu
            while (table.Read())
            {
                lvKhoa.Items.Add(table["MaKhoa"].ToString());
                lvKhoa.Items[i].SubItems.Add(table["TenKhoa"].ToString());
                i++;
            }
            table.Close();
        }
    }
}
