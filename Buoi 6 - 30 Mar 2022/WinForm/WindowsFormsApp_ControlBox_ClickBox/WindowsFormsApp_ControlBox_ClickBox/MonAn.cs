using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_ControlBox_ClickBox
{
    public class MonAn
    {
        public string TenMonAn;
        public int GiaTien;
        public MonAn()
        {
            TenMonAn = "";
            GiaTien = 0;
        }
        public MonAn(string TenMonAn, int GiaTien)
        {
            this.TenMonAn = TenMonAn;
            this.GiaTien = GiaTien;
        }
    }
}
