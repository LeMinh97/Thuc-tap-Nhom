using QuanLiKho.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiKho.Module
{
    public class ThemHangHoa
    {
        private static ThemHangHoa instance;

        public static ThemHangHoa Instance
        {
            get { if (instance == null) instance = new ThemHangHoa(); return ThemHangHoa.instance; }
            private set { ThemHangHoa.instance = value; }
        }
        private ThemHangHoa() { }
        public bool ThemHang(string maHang, string tenHang, string nganhHang, string donViTinh, int soLuong)
        {
            string query = "INSERT dbo.HangHoa( MaHang , TenHang , NganhHang , DVT , SoLuong ) VALUES  ( '"+maHang+"' , N'"+tenHang+"' , N'"+nganhHang+"' , N'"+donViTinh+"' , "+soLuong+")";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
