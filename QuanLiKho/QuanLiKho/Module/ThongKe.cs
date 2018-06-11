using QuanLiKho.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiKho.Module
{
    public class ThongKe
    {
        
        private static ThongKe instance;

        public static ThongKe Instance
        {
            get { if (instance == null) instance = new ThongKe(); return ThongKe.instance; }
            private set { ThongKe.instance = value; }
        }
        private ThongKe() { }
        public DataTable  HienDSNhap(DateTime ngayBatDau,DateTime ngayKetThuc)
        {
            string query = "SELECT PhieuNhap.MaPhieuNhap,NgayNhap,TenNCC,TenHang,ChiTietPhieuNhap.SoLuong,DonGiaNhap FROM dbo.NhaCungCap,dbo.PhieuNhap,dbo.ChiTietPhieuNhap,dbo.HangHoa WHERE NhaCungCap.MaNCC=PhieuNhap.MaNCC AND PhieuNhap.MaPhieuNhap=ChiTietPhieuNhap.MaPhieuNhap AND ChiTietPhieuNhap.MaHang=HangHoa.MaHang AND NgayNhap BETWEEN '"+ngayBatDau+"' AND'"+ngayKetThuc+"'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public bool CheckHienDSNhap(DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            string query = "SELECT PhieuNhap.MaPhieuNhap,NgayNhap,TenNCC,TenHang,ChiTietPhieuNhap.SoLuong,DonGiaNhap FROM dbo.NhaCungCap,dbo.PhieuNhap,dbo.ChiTietPhieuNhap,dbo.HangHoa WHERE NhaCungCap.MaNCC=PhieuNhap.MaNCC AND PhieuNhap.MaPhieuNhap=ChiTietPhieuNhap.MaPhieuNhap AND ChiTietPhieuNhap.MaHang=HangHoa.MaHang AND NgayNhap BETWEEN '" + ngayBatDau + "' AND'" + ngayKetThuc + "'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data.Rows.Count > 0;
        }

        public DataTable HienDSXuat(DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            string query = "SELECT PhieuXuat.MaPhieuXuat,NgayXuat,TenKH,TenHang,ChiTietPhieuXuat.SoLuong,DonGiaXuat FROM dbo.KhachHang,dbo.PhieuXuat,dbo.ChiTietPhieuXuat,dbo.HangHoa WHERE KhachHang.MaKH=PhieuXuat.MaKH AND PhieuXuat.MaPhieuXuat=ChiTietPhieuXuat.MaPhieuXuat AND ChiTietPhieuXuat.MaHang=HangHoa.MaHang AND NgayXuat BETWEEN '"+ngayBatDau+"' AND '"+ngayKetThuc+"'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public bool CheckHienDSXuat(DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            string query = "SELECT PhieuXuat.MaPhieuXuat,NgayXuat,TenKH,TenHang,ChiTietPhieuXuat.SoLuong,DonGiaXuat FROM dbo.KhachHang,dbo.PhieuXuat,dbo.ChiTietPhieuXuat,dbo.HangHoa WHERE KhachHang.MaKH=PhieuXuat.MaKH AND PhieuXuat.MaPhieuXuat=ChiTietPhieuXuat.MaPhieuXuat AND ChiTietPhieuXuat.MaHang=HangHoa.MaHang AND NgayXuat BETWEEN '" + ngayBatDau + "' AND '" + ngayKetThuc + "'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data.Rows.Count > 0;
        } 

        public int HienLai(DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            string query = "";
            int result=0;
            return result;
        }
        public DataTable SapXepSoLuongTuCaoToiThap()
        {
            string query = "SELECT* FROM dbo.HangHoa ORDER BY SoLuong DESC";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public DataTable SapXepSoLuongTuThapToiCao()
        {
            string query = "SELECT* FROM dbo.HangHoa ORDER BY SoLuong";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public DataTable SapXepTheoNganhHang()
        {
            string query = "";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
    }
}
