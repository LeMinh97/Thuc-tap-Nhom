using QuanLiKho.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiKho.Module
{
    public class ThemNhapHang
    {
        private static ThemNhapHang instance;

        public static ThemNhapHang Instance
        {
            get { if (instance == null) instance = new ThemNhapHang(); return ThemNhapHang.instance; }
            private set { ThemNhapHang.instance = value; }
        }
        private ThemNhapHang() { }
        public bool ThemPhieuNhap(string maPhieuNhap,DateTime ngayNhap,string maNCC)
        {
            string query = "INSERT dbo.PhieuNhap( MaPhieuNhap, NgayNhap, MaNCC ) VALUES  ( '"+maPhieuNhap+"','"+ngayNhap+"','"+maNCC+"' )";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool ThemChiTietPhieuNhap(string maPhieuNhap,string maHang, int soLuong, int donGiaNhap)
        {
            string query = "INSERT dbo.ChiTietPhieuNhap( MaPhieuNhap , MaHang , SoLuong ,DonGiaNhap)VALUES  ( '"+maPhieuNhap+"' ,'"+maHang+"',"+soLuong+","+donGiaNhap+" )";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            string query1 = "UPDATE dbo.HangHoa SET SoLuong=SoLuong+" + soLuong + " WHERE MaHang='" + maHang + "'";
            DataProvider.Instance.ExecuteNonQuery(query1);
            return result > 0;
        }
    }
}
