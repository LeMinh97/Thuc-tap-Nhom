using QuanLiThuVien.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiThuVien.Module
{
    public class ThemDauSach
    {
        private static ThemDauSach instance;

        public static ThemDauSach Instance
        {
            get { if (instance == null) instance = new ThemDauSach(); return ThemDauSach.instance; }
            private set { ThemDauSach.instance = value; }
        }

        private ThemDauSach() { }

        public bool ThemDS(string MaDS, string TenDS, string TheLoai, string MaNXB, string MaNhanh)
        {
            string query = "INSERT dbo.DauSach( MaDauSach, TenDauSach, TheLoai, MaNhaXB, MaNhanh ) VALUES  ( '"+MaDS+"', N'"+TenDS+"', N'"+TheLoai+"', '"+MaNXB+"', '"+MaNhanh+"' )";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

    }
}
