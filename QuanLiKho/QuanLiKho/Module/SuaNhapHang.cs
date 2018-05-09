using QuanLiKho.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiKho.Module
{
    public class SuaNhapHang
    {
        private static SuaNhapHang instance;

        public static SuaNhapHang Instance
        {
            get { if (instance == null) instance = new SuaNhapHang(); return SuaNhapHang.instance; }
            private set { SuaNhapHang.instance = value; }
        }
        private SuaNhapHang() { }
        public bool SuaPhieuNhap(string maPhieuNhap, DateTime ngayNhap, string maNCC)
        {
            string query = "UPDATE dbo.PhieuNhap SET NgayNhap='"+ngayNhap+"', MaNCC='"+maNCC+"' WHERE MaPhieuNhap='"+maPhieuNhap+"'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool SuaChiTietPhieuNhap(string maPhieuNhap, string maHang, int soLuong, int donGiaNhap)
        {
            string query = "UPDATE dbo.ChiTietPhieuNhap SET SoLuong="+soLuong+",DonGiaNhap="+donGiaNhap+" WHERE MaPhieuNhap='"+maPhieuNhap+"' AND MaHang='"+maHang+"'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
