using QuanLiKho.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiKho.Module
{
    public class XoaNhapHang
    {
        private static XoaNhapHang instance;

        public static XoaNhapHang Instance
        {
            get { if (instance == null) instance = new XoaNhapHang(); return XoaNhapHang.instance; }
            private set { XoaNhapHang.instance = value; }
        }
        private XoaNhapHang() { }
        public bool XoaPhieuNhap(string maPhieuNhap)
        {
            string query = "DELETE dbo.PhieuNhap WHERE MaPhieuNhap='"+maPhieuNhap+"'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool XoaChiTietPhieuNhap(string maPhieuNhap,string maHang)
        {
            string query = "DELETE dbo.ChiTietPhieuNhap WHERE MaPhieuNhap='"+maPhieuNhap+"' AND MaHang='"+maHang+"'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
