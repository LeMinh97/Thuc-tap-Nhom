using QuanLiKho.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiKho.Module
{
    public class XoaXuatHang
    {
        private static XoaXuatHang instance;

        public static XoaXuatHang Instance
        {
            get { if (instance == null) instance = new XoaXuatHang(); return XoaXuatHang.instance; }
            private set { XoaXuatHang.instance = value; }
        }
        private XoaXuatHang() { }
        public bool XoaPhieuXuat(string maPX)
        {
            string query = "DELETE dbo.PhieuXuat WHERE MaPhieuXuat='"+maPX+"'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool XoaChiTietPhieuXuat(string maPX, string maHang)
        {
            string query = "DELETE dbo.ChiTietPhieuXuat WHERE MaPhieuXuat='"+maPX+"' AND MaHang='"+maHang+"'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
