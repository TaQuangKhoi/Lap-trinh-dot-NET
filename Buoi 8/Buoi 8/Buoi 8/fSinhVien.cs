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
    public partial class fSinhVien : Form
    {
        public fSinhVien()
        {
            InitializeComponent();
        }
        SqlConnection conn;

        private void btnThem_Click(object sender, EventArgs e)
        {
            string query = "INSERT SINHVIEN VALUES('" + txbMSV.Text + "', '" + txbTenSV.Text + "', '" + Convert.ToDateTime(dtpNgaySinh.Value) + "', '" + cbbLop.Text+ "')";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
        }

        private void fSinhVien_Load(object sender, EventArgs e)
        {
            string connStr = @"Data Source = DESKTOP-AN8O8G6\TQK; Initial Catalog=QLSVDN;Integrated Security=True";
            conn = new SqlConnection(connStr);

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }
    }
}
