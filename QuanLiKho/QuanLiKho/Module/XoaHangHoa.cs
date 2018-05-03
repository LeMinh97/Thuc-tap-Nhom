using QuanLiKho.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiKho.Module
{
    public class XoaHangHoa
    {
        private static XoaHangHoa instance;

        public static XoaHangHoa Instance
        {
            get { if (instance == null) instance = new XoaHangHoa(); return XoaHangHoa.instance; }
            private set { XoaHangHoa.instance = value; }
        }
        private XoaHangHoa() { }

        public bool XoaHang(string maHang)
        {
            string query = "DELETE dbo.HangHoa WHERE MaHang='"+maHang+"'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
