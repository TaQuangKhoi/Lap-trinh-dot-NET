using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Buoi_8
{
    public static class KiemTra
    {
        static SqlConnection conn;

        public static int KiemTraMaKhoa(string MaKhoa)
        {
            // 0 Trùng Mã
            // 1 Không Trùng Mã
            // 2 Vượt quá 4 ký tự
            string connStr = @"Data Source = .\TQK; Initial Catalog=QLSVDN;Integrated Security=True";
            conn = new SqlConnection(connStr);

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            int dem = 0;
            string queryKiemTraTrung = "SELECT COUNT(*) FROM KHOA WHERE MaKhoa = '" + MaKhoa + "'";
            SqlCommand cmdKiemTra = new SqlCommand(queryKiemTraTrung, conn);
            dem = (int)cmdKiemTra.ExecuteScalar(); // nếu bị lỗi ở chổ này có thể do code SQL viết nhầm ký tự
            if (MaKhoa.Length > 4)
            {
                return 2;
            }
            else if (dem >= 1)
            {
                return 0;
            }
            return 1;
        }

        public static int KiemTraMaLop(string MaLop)
        {
            // 0 Trùng Mã
            // 1 Không Trùng Mã
            // 2 Vượt quá 4 ký tự
            string connStr = @"Data Source = .\TQK; Initial Catalog=QLSVDN;Integrated Security=True";
            conn = new SqlConnection(connStr);

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            int dem = 0;
            string queryKiemTraTrung = "SELECT COUNT(*) FROM LOP WHERE MaLop = '" + MaLop + "'";
            SqlCommand cmdKiemTra = new SqlCommand(queryKiemTraTrung, conn);
            dem = (int)cmdKiemTra.ExecuteScalar(); // nếu bị lỗi ở chổ này có thể do code SQL viết nhầm ký tự
            if (MaLop.Length > 4)
            {
                return 2;
            }
            else if (dem >= 1)
            {
                return 0;
            }
            return 1;
        }
    }
}
