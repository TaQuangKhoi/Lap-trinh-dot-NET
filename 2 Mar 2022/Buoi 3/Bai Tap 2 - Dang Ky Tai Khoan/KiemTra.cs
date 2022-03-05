using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_Tap_2___Dang_Ky_Tai_Khoan
{
    internal class KiemTra
    {
        internal static bool Email(string email)
        {
            //Kiểm tra có chứa @ không? 
            if (!email.Contains("@"))
            {
                return false;
            }
            //Nếu không chứa ".com" -> Sai 
            if (!email.Contains(".com"))
            {
                return false;
            }
            //Tìm vị trí @ trong chuỗi email
            int index1 = email.IndexOf("@");
            int index2 = email.IndexOf(".com"); //Lấy ra tên miền nếu có của email
            string domain = email.Substring(index1 + 1, index2 - index1 - 1);
            //Tại đây bạn có thể thêm miền nào muốn vào đây
            //Nếu không nằm trong đây trả về false 
            if (domain != "gmail" && domain != "hotmail" && domain != "outlook")
            {
                return false;
            }
            return true;
        }
    }
}
