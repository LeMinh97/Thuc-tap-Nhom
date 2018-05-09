using QuanLiKho.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiKho.Module
{
    public class SuaXuatHang
    {
        private static SuaXuatHang instance;

        public static SuaXuatHang Instance
        {
            get { if (instance == null) instance = new SuaXuatHang(); return SuaXuatHang.instance; }
            private set { SuaXuatHang.instance = value; }
        }
        private SuaXuatHang() { }

        public bool SuaPhieuXuat(string maPX, DateTime ngayXuat, string maKH)
        {
            string query = "UPDATE dbo.PhieuXuat SET NgayXuat='"+ngayXuat+"',MaKH='"+maKH+"' WHERE MaPhieuXuat='"+maPX+"'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool SuaChiTietPhieuXuat(string maPX, string maHang, int soLuong, int donGiaXuat)
        {
            string query = "UPDATE dbo.ChiTietPhieuXuat SET SoLuong="+soLuong+",DonGiaXuat="+donGiaXuat+" WHERE MaPhieuXuat='"+maPX+"' AND MaHang='"+maHang+"'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
