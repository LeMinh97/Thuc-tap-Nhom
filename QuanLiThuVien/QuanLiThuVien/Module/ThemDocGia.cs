using QuanLiThuVien.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiThuVien.Module
{
    public class ThemDocGia
    {
        private static ThemDocGia instance;

        public static ThemDocGia Instance
        {
            get { if (instance == null) instance = new ThemDocGia(); return ThemDocGia.instance; }
            private set { ThemDocGia.instance = value; }
        }
        private ThemDocGia() { }

        public bool ThemND(string MaND, string TenND, string DiaChi, string SDT)
        {
            string query = "INSERT dbo.NguoiDoc( MaNguoiDoc,TenNguoiDoc, DiaChi, SDT ) VALUES  ( '" + MaND + "', N'" + TenND + "', N'" + DiaChi + "', N'" + SDT + "' )";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;

        }
    }
}
