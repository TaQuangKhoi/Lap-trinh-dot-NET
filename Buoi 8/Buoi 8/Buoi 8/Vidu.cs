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
    public partial class Vidu : Form
    {
        public Vidu()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        SqlDataAdapter adapter;
        string connStr = @"Data Source = .\TQK; Initial Catalog=QLSVDN;Integrated Security=True";
        DataSet dsLop = new DataSet();
        string strSqlLop = "SELECT L.MaLop, L.TenLop, K.TenKhoa FROM LOP L, KHOA K WHERE L.MaKhoa = K.MaKhoa";


        private void Vidu_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(connStr);

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            string strSqlKhoa = "SELECT * FROM KHOA";
            adapter = new SqlDataAdapter(strSqlKhoa, conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "KHOA"); //Đặt tên cho bảng là KHOA
            cbbKhoa.DataSource = ds.Tables[0];
            cbbKhoa.DisplayMember = "TenKhoa";
            cbbKhoa.ValueMember = "MaKhoa";

            adapter = new SqlDataAdapter(strSqlLop, conn);
            adapter.Fill(dsLop, "LOP"); // Đặt tên cho bảng là LOP
            dgvLop.DataSource = dsLop.Tables[0];
        }

        private void btnHien_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(connStr);

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            dsLop.Clear();
            adapter = new SqlDataAdapter(strSqlLop, conn);
            adapter.Fill(dsLop, "LOP"); // Đặt tên cho bảng là LOP
            dgvLop.DataSource = dsLop.Tables[0];
        }

        private void dgvLop_SelectionChanged(object sender, EventArgs e)
        {
            // Cách 1
            /*txbMaLop.DataBindings.Clear();
            txbTenLop.DataBindings.Clear();*/
            /*
            txbMaLop.DataBindings.Add("Text", dsLop.Tables[0], "MaLop");
            txbTenLop.DataBindings.Add("Text", dsLop.Tables[0], "TenLop"); */
        }

        private void dgvLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Cách 2
            int dem = e.RowIndex;
            txbMaLop.Text = dgvLop.Rows[dem].Cells[0].Value.ToString();
            txbTenLop.Text = dgvLop.Rows[dem].Cells[1].Value.ToString();
            cbbKhoa.Text = dgvLop.Rows[dem].Cells[2].Value.ToString();
        }

        private void cbbKhoa_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            dsLop.Clear();
            string strSqlLopTheoKhoa = "SELECT L.MaLop, L.TenLop, K.TenKhoa FROM LOP L, KHOA K WHERE L.MaKhoa = K.MaKhoa AND K.TenKhoa = '" + cbbKhoa.Text + "'";
            adapter = new SqlDataAdapter(strSqlLopTheoKhoa, conn);
            adapter.Fill(dsLop, "LOP"); // Đặt tên cho bảng là LOP
            dgvLop.DataSource = dsLop.Tables[0];
        }
    }
}
