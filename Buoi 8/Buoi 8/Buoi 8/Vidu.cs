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
        SqlConnection conn;
        SqlDataAdapter adapter;
        string connStr = @"Data Source = .\TQK; Initial Catalog=QLSVDN;Integrated Security=True";
        DataSet dsLop = new DataSet();
        DataSet dsKhoa = new DataSet();
        DataSet dsLopKhoa = new DataSet();
        DataColumn[] Key = new DataColumn[1]; // Tạo một mảng Key là mảng một chiều Cột
        string strSqlLop = "SELECT * FROM LOP";
        string strSqlKhoa = "SELECT * FROM KHOA";
        string strSqlLopKhoa = "SELECT L.MaLop, L.TenLop, K.TenKhoa FROM LOP L, KHOA K WHERE L.MaKhoa = K.MaKhoa";

        public Vidu()
        {
            InitializeComponent();
            conn = new SqlConnection(connStr);

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            adapter = new SqlDataAdapter(strSqlLop, conn);
            adapter.Fill(dsLop, "LOP"); // Đặt tên cho bảng là LOP

            Key[0] = dsLop.Tables[0].Columns[0]; // Gán cột thứ nhất (MaKHoa) cho mảng Key[]
            dsLop.Tables[0].PrimaryKey = Key; // Gán PrimaryKey của DataSet là mảng Key[] 
        }

        private void Vidu_Load(object sender, EventArgs e)
        {
            adapter = new SqlDataAdapter(strSqlKhoa, conn);

            adapter.Fill(dsKhoa, "KHOA"); //Đặt tên cho bảng là KHOA
            
            cbbKhoa.DataSource = dsKhoa.Tables[0];
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
            //cbbKhoa.Text = dgvLop.Rows[dem].Cells[2].Value.ToString();
        }

        private void cbbKhoa_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            /*dsLop.Clear();
            string strSqlLopTheoKhoa = "SELECT L.MaLop, L.TenLop, K.TenKhoa FROM LOP L, KHOA K WHERE L.MaKhoa = K.MaKhoa AND K.TenKhoa = '" + cbbKhoa.Text + "'";
            adapter = new SqlDataAdapter(strSqlLopTheoKhoa, conn);
            adapter.Fill(dsLopKhoa, "LOP"); // Đặt tên cho bảng là LOP
            dgvLop.DataSource = dsLopKhoa.Tables[0];/*/
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DataRow dr = dsLop.Tables[0].Rows.Find(txbMaLop.Text); // Hàm Find chỉ tìm kiếm khóa chính, nên phải set khóa chính cho DataSet
            if (dr != null)
            {
                dr["TenLop"] = txbTenLop.Text;
            }
            SqlCommandBuilder sqlCB = new SqlCommandBuilder(adapter);
            adapter.Update(dsLop, "LOP");
            dgvLop.DataSource = dsLop.Tables[0]; // Refresh DataGridView
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataRow dr = dsLop.Tables[0].Rows.Find(txbMaLop.Text); // Hàm Find chỉ tìm kiếm khóa chính, nên phải set khóa chính cho DataSet
            if (dr != null)
            {
                dr.Delete();
            }
            SqlCommandBuilder sqlCB = new SqlCommandBuilder(adapter);
            adapter.Update(dsLop, "LOP"); // Chỉ hoạt động với DataSet lấy dữ liệu từ 1 bảng
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DataRow drNew = dsLop.Tables[0].NewRow();
            drNew["MaLop"] = txbMaLop.Text;
            drNew["TenLop"] = txbTenLop.Text;
            drNew["MaKhoa"] = cbbKhoa.SelectedValue.ToString();
            dsLop.Tables[0].Rows.Add(drNew);

            SqlCommandBuilder sqlCB = new SqlCommandBuilder(adapter);
            adapter.Update(dsLop, "LOP");
        }
    }
}
