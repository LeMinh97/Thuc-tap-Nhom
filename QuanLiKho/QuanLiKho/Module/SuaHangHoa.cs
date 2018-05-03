using QuanLiKho.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiKho.Module
{
    public class SuaHangHoa
    {
        private static SuaHangHoa instance;

        public static SuaHangHoa Instance
        {
            get { if (instance == null) instance = new SuaHangHoa(); return SuaHangHoa.instance; }
            private set { SuaHangHoa.instance = value; }
        }
        private SuaHangHoa() { }

        public bool SuaHang(string maHang,string tenHang, string nganhHang, string dvt,int soLuong)
        {
            string query = "UPDATE dbo.HangHoa SET TenHang=N'"+tenHang+"',NganhHang=N'"+nganhHang+"',DVT=N'"+dvt+"', SoLuong="+soLuong+" WHERE MaHang='"+maHang+"'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
