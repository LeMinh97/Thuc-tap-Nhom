using QuanLiKho.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiKho.Module
{
    public class TimKiemNhapHang
    {
        private static TimKiemNhapHang instance;

        public static TimKiemNhapHang Instance
        {
            get { if (instance == null) instance = new TimKiemNhapHang(); return TimKiemNhapHang.instance; }
            private set { TimKiemNhapHang.instance = value; }
        }
        private TimKiemNhapHang() { }

        public DataTable TkPhieuNhapTheoTatCa(string maTK)
        {
            string query = "SELECT MaPhieuNhap,NgayNhap,TenNCC FROM dbo.PhieuNhap,dbo.NhaCungCap WHERE NhaCungCap.MaNCC=PhieuNhap.MaNCC AND (dbo.ChuyenDoiKiTuUnicode(TenNCC) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%' OR dbo.ChuyenDoiKiTuUnicode(MaPhieuNhap) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%' OR dbo.ChuyenDoiKiTuUnicode(NgayNhap) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%')";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public bool CheckTkPhieuNhapTheoTatCa(string maTK)
        {
            string query = "SELECT MaPhieuNhap,NgayNhap,TenNCC FROM dbo.PhieuNhap,dbo.NhaCungCap WHERE NhaCungCap.MaNCC=PhieuNhap.MaNCC AND (dbo.ChuyenDoiKiTuUnicode(TenNCC) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%' OR dbo.ChuyenDoiKiTuUnicode(MaPhieuNhap) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%' OR dbo.ChuyenDoiKiTuUnicode(NgayNhap) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%')";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data.Rows.Count > 0;
        }

        public DataTable TkPhieuNhapTheoMaPhieuNhap(string maTK)
        {
            string query = "SELECT MaPhieuNhap,NgayNhap,TenNCC FROM dbo.PhieuNhap,dbo.NhaCungCap WHERE NhaCungCap.MaNCC=PhieuNhap.MaNCC AND dbo.ChuyenDoiKiTuUnicode(MaPhieuNhap) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'"+maTK+"')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public bool CheckTkPhieuNhapTheoMaPhieuNhap(string maTK)
        {
            string query = "SELECT MaPhieuNhap,NgayNhap,TenNCC FROM dbo.PhieuNhap,dbo.NhaCungCap WHERE NhaCungCap.MaNCC=PhieuNhap.MaNCC AND dbo.ChuyenDoiKiTuUnicode(MaPhieuNhap) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data.Rows.Count > 0;
        }

        public DataTable TkPhieuNhapTheoNgayNhap(string maTK)
        {
            string query = "SELECT MaPhieuNhap,NgayNhap,TenNCC FROM dbo.PhieuNhap,dbo.NhaCungCap WHERE NhaCungCap.MaNCC=PhieuNhap.MaNCC AND dbo.ChuyenDoiKiTuUnicode(NgayNhap) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'"+maTK+"')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public bool CheckTkPhieuNhapTheoNgayNhap(string maTK)
        {
            string query = "SELECT MaPhieuNhap,NgayNhap,TenNCC FROM dbo.PhieuNhap,dbo.NhaCungCap WHERE NhaCungCap.MaNCC=PhieuNhap.MaNCC AND dbo.ChuyenDoiKiTuUnicode(NgayNhap) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data.Rows.Count > 0;
        }

        public DataTable TkPhieuNhapTheoTenNCC(string maTK)
        {
            string query = "SELECT MaPhieuNhap,NgayNhap,TenNCC FROM dbo.PhieuNhap,dbo.NhaCungCap WHERE NhaCungCap.MaNCC=PhieuNhap.MaNCC AND dbo.ChuyenDoiKiTuUnicode(TenNCC) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'"+maTK+"')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public bool CheckTkPhieuNhapTheoTenNCC(string maTK)
        {
            string query = "SELECT MaPhieuNhap,NgayNhap,TenNCC FROM dbo.PhieuNhap,dbo.NhaCungCap WHERE NhaCungCap.MaNCC=PhieuNhap.MaNCC AND dbo.ChuyenDoiKiTuUnicode(TenNCC) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data.Rows.Count > 0;
        }

        // tk cho chi tiet phieu nhap
        public DataTable TkCTPNTheoTatCa(string maTK)
        {
            string query = "SELECT MaPhieuNhap,TenHang,ChiTietPhieuNhap.SoLuong,DonGiaNhap FROM dbo.ChiTietPhieuNhap,dbo.HangHoa WHERE ChiTietPhieuNhap.MaHang=HangHoa.MaHang AND (dbo.ChuyenDoiKiTuUnicode(DonGiaNhap) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%' OR dbo.ChuyenDoiKiTuUnicode(MaPhieuNhap) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%' OR dbo.ChuyenDoiKiTuUnicode(TenHang) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%' OR dbo.ChuyenDoiKiTuUnicode(ChiTietPhieuNhap.SoLuong) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%')";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public bool CheckTkCTPNTheoTatCa(string maTK)
        {
            string query = "SELECT MaPhieuNhap,TenHang,ChiTietPhieuNhap.SoLuong,DonGiaNhap FROM dbo.ChiTietPhieuNhap,dbo.HangHoa WHERE ChiTietPhieuNhap.MaHang=HangHoa.MaHang AND (dbo.ChuyenDoiKiTuUnicode(DonGiaNhap) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%' OR dbo.ChuyenDoiKiTuUnicode(MaPhieuNhap) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%' OR dbo.ChuyenDoiKiTuUnicode(TenHang) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%' OR dbo.ChuyenDoiKiTuUnicode(ChiTietPhieuNhap.SoLuong) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%')";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data.Rows.Count > 0;
        }
        public DataTable TkCTPNTheoMaPhieuNhap(string maTK)
        {
            string query = "SELECT MaPhieuNhap,TenHang,ChiTietPhieuNhap.SoLuong,DonGiaNhap FROM dbo.ChiTietPhieuNhap,dbo.HangHoa WHERE ChiTietPhieuNhap.MaHang=HangHoa.MaHang AND dbo.ChuyenDoiKiTuUnicode(MaPhieuNhap) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public bool CheckTkCTPNTheoMaPhieuNhap(string maTK)
        {
            string query = "SELECT MaPhieuNhap,TenHang,ChiTietPhieuNhap.SoLuong,DonGiaNhap FROM dbo.ChiTietPhieuNhap,dbo.HangHoa WHERE ChiTietPhieuNhap.MaHang=HangHoa.MaHang AND dbo.ChuyenDoiKiTuUnicode(MaPhieuNhap) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data.Rows.Count > 0;
        }
        public DataTable TkCTPNTheoTenHang(string maTK)
        {
            string query = "SELECT MaPhieuNhap,TenHang,ChiTietPhieuNhap.SoLuong,DonGiaNhap FROM dbo.ChiTietPhieuNhap,dbo.HangHoa WHERE ChiTietPhieuNhap.MaHang=HangHoa.MaHang AND dbo.ChuyenDoiKiTuUnicode(TenHang) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public bool CheckTkCTPNTheoTenHang(string maTK)
        {
            string query = "SELECT MaPhieuNhap,TenHang,ChiTietPhieuNhap.SoLuong,DonGiaNhap FROM dbo.ChiTietPhieuNhap,dbo.HangHoa WHERE ChiTietPhieuNhap.MaHang=HangHoa.MaHang AND dbo.ChuyenDoiKiTuUnicode(TenHang) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data.Rows.Count > 0;
        }
        public DataTable TkCTPNTheoSoLuong(string maTK)
        {
            string query = "SELECT MaPhieuNhap,TenHang,ChiTietPhieuNhap.SoLuong,DonGiaNhap FROM dbo.ChiTietPhieuNhap,dbo.HangHoa WHERE ChiTietPhieuNhap.MaHang=HangHoa.MaHang AND dbo.ChuyenDoiKiTuUnicode(ChiTietPhieuNhap.SoLuong) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public bool CheckTkCTPNTheoSoLuong(string maTK)
        {
            string query = "SELECT MaPhieuNhap,TenHang,ChiTietPhieuNhap.SoLuong,DonGiaNhap FROM dbo.ChiTietPhieuNhap,dbo.HangHoa WHERE ChiTietPhieuNhap.MaHang=HangHoa.MaHang AND dbo.ChuyenDoiKiTuUnicode(ChiTietPhieuNhap.SoLuong) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data.Rows.Count > 0;
        }
        public DataTable TkCTPNTheoDonGiaNhap(string maTK)
        {
            string query = "SELECT MaPhieuNhap,TenHang,ChiTietPhieuNhap.SoLuong,DonGiaNhap FROM dbo.ChiTietPhieuNhap,dbo.HangHoa WHERE ChiTietPhieuNhap.MaHang=HangHoa.MaHang AND dbo.ChuyenDoiKiTuUnicode(DonGiaNhap) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public bool CheckTkCTPNTheoDonGiaNhap(string maTK)
        {
            string query = "SELECT MaPhieuNhap,TenHang,ChiTietPhieuNhap.SoLuong,DonGiaNhap FROM dbo.ChiTietPhieuNhap,dbo.HangHoa WHERE ChiTietPhieuNhap.MaHang=HangHoa.MaHang AND dbo.ChuyenDoiKiTuUnicode(DonGiaNhap) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data.Rows.Count > 0;
        }
    }
}
