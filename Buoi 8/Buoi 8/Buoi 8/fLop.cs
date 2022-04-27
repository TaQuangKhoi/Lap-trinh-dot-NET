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
    public partial class fLop : Form
    {
        SqlConnection conn;

        public fLop()
        {
            InitializeComponent();
        }

        private void btnHienLuoi_Click(object sender, EventArgs e)
        {
            lvLop.Items.Clear();
            int i = 0;
            string query = "SELECT * FROM LOP";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader table;
            table = cmd.ExecuteReader(); // ExecuteReader() trả về một bảng dữ liệu
            while (table.Read())
            {
                lvLop.Items.Add(table["MaLop"].ToString());
                lvLop.Items[i].SubItems.Add(table["TenLop"].ToString());
                lvLop.Items[i].SubItems.Add(table["MaKhoa"].ToString());
                i++;
            }
            table.Close();
        }

        private void btnHien_Click(object sender, EventArgs e)
        {
            string query = "SELECT COUNT(*) FROM KHOA";
            SqlCommand cmd = new SqlCommand(query, conn);
            int TongSoKhoa = (int)cmd.ExecuteScalar();
            // ExecuteScalar() trả về giá trị ô đầu tiên của dòng đầu tiên của bảng SELECT
            txbTongSoKhoa.Text = TongSoKhoa.ToString();
        }

        private void fLop_Load(object sender, EventArgs e)
        {
            string connStr = @"Data Source = .\TQK; Initial Catalog=QLSVDN;Integrated Security=True";
            conn = new SqlConnection(connStr);

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string queryKhoa = "SELECT MaKhoa FROM KHOA";
            SqlCommand cmd = new SqlCommand(queryKhoa, conn);
            SqlDataReader table;
            table = cmd.ExecuteReader();
            while (table.Read())
            {
                cbbMaKhoa.Items.Add(table["MaKhoa"].ToString());
            }
            table.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (KiemTra.KiemTraMaLop(txbMaLop.Text) == 0)
            {
                MessageBox.Show("Trùng mã lớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (KiemTra.KiemTraMaLop(txbMaLop.Text) == 2)
            {
                MessageBox.Show("Độ dài vượt quá 4 ký tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string queryThem = "INSERT INTO LOP VALUES('" + txbMaLop.Text + "', '" + txbTenLop.Text + "', '" + cbbMaKhoa.Text + "')";
                SqlCommand cmdThem = new SqlCommand(queryThem, conn);
                cmdThem.ExecuteNonQuery();
            }
        }

        private void lvLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lblDeBug.Text = lvLop.FocusedItem.Index;
            int i = lvLop.FocusedItem.Index;
            txbMaLop.Text = lvLop.SelectedItems[i].Text;
            //txbTenLop.Text = lvLop.SelectedItems[i].SubItems[1].Text;
            //cbbMaKhoa.Text = lvLop.SelectedItems[i].SubItems[2].Text;
        }
    }
}
