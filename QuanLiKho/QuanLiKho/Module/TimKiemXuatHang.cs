using QuanLiKho.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiKho.Module
{
    public class TimKiemXuatHang
    {
        private static TimKiemXuatHang instance;

        public static TimKiemXuatHang Instance
        {
            get { if (instance == null) instance = new TimKiemXuatHang(); return TimKiemXuatHang.instance; }
            private set { TimKiemXuatHang.instance = value; }
        }
        private TimKiemXuatHang() { }

        // tk cho phieu xuat
        public DataTable TkPhieuXuatTheoTatCa(string maTK)
        {
            string query = "SELECT MaPhieuXuat,NgayXuat,TenKH FROM dbo.PhieuXuat, dbo.KhachHang WHERE KhachHang.MaKH=PhieuXuat.MaKH AND (dbo.ChuyenDoiKiTuUnicode(MaPhieuXuat) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'"+maTK+"')+N'%' OR dbo.ChuyenDoiKiTuUnicode(NgayXuat) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'"+maTK+"')+N'%' OR dbo.ChuyenDoiKiTuUnicode(TenKH) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'"+maTK+"')+N'%')";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public bool CheckTkPhieuXuatTheoTatCa(string maTK)
        {
            string query = "SELECT MaPhieuXuat,NgayXuat,TenKH FROM dbo.PhieuXuat, dbo.KhachHang WHERE KhachHang.MaKH=PhieuXuat.MaKH AND (dbo.ChuyenDoiKiTuUnicode(MaPhieuXuat) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%' OR dbo.ChuyenDoiKiTuUnicode(NgayXuat) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%' OR dbo.ChuyenDoiKiTuUnicode(TenKH) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%')";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data.Rows.Count > 0;
        }

        public DataTable TkPhieuXuatTheoMaPhieuXuat(string maTK)
        {
            string query = "SELECT MaPhieuXuat,NgayXuat,TenKH FROM dbo.PhieuXuat, dbo.KhachHang WHERE KhachHang.MaKH=PhieuXuat.MaKH AND dbo.ChuyenDoiKiTuUnicode(MaPhieuXuat) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'"+maTK+"')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public bool CheckTkPhieuXuatTheoMaPhieuXuat(string maTK)
        {
            string query = "SELECT MaPhieuXuat,NgayXuat,TenKH FROM dbo.PhieuXuat, dbo.KhachHang WHERE KhachHang.MaKH=PhieuXuat.MaKH AND dbo.ChuyenDoiKiTuUnicode(MaPhieuXuat) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data.Rows.Count > 0;
        }

        public DataTable TkPhieuXuatTheoNgayXuat(string maTK)
        {
            string query = "SELECT MaPhieuXuat,NgayXuat,TenKH FROM dbo.PhieuXuat, dbo.KhachHang WHERE KhachHang.MaKH=PhieuXuat.MaKH AND dbo.ChuyenDoiKiTuUnicode(NgayXuat) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'"+maTK+"')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public bool CheckTkPhieuXuatTheoNgayXuat(string maTK)
        {
            string query = "SELECT MaPhieuXuat,NgayXuat,TenKH FROM dbo.PhieuXuat, dbo.KhachHang WHERE KhachHang.MaKH=PhieuXuat.MaKH AND dbo.ChuyenDoiKiTuUnicode(NgayXuat) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'"+maTK+"')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data.Rows.Count > 0;
        }

        public DataTable TkPhieuXuatTheoTenKhachHang(string maTK)
        {
            string query = "SELECT MaPhieuXuat,NgayXuat,TenKH FROM dbo.PhieuXuat, dbo.KhachHang WHERE KhachHang.MaKH=PhieuXuat.MaKH AND dbo.ChuyenDoiKiTuUnicode(TenKH) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'"+maTK+"')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public bool CheckTkPhieuXuatTheoTenKhachHang(string maTK)
        {
            string query = "SELECT MaPhieuXuat,NgayXuat,TenKH FROM dbo.PhieuXuat, dbo.KhachHang WHERE KhachHang.MaKH=PhieuXuat.MaKH AND dbo.ChuyenDoiKiTuUnicode(TenKH) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'"+maTK+"')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data.Rows.Count > 0;
        }

        // tk cho chi tiet phieu xuat
        public DataTable TkCTPXTheoTatCa(string maTK)
        {
            string query = "SELECT MaPhieuXuat,TenHang,ChiTietPhieuXuat.SoLuong,DonGiaXuat FROM dbo.ChiTietPhieuXuat,dbo.HangHoa WHERE ChiTietPhieuXuat.MaHang=HangHoa.MaHang AND dbo.ChuyenDoiKiTuUnicode(DonGiaXuat) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%' OR dbo.ChuyenDoiKiTuUnicode(MaPhieuXuat) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%' OR dbo.ChuyenDoiKiTuUnicode(TenHang) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%' OR dbo.ChuyenDoiKiTuUnicode(ChiTietPhieuXuat.SoLuong) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public bool CheckTkCTPXTheoTatCa(string maTK)
        {
            string query = "SELECT MaPhieuXuat,TenHang,ChiTietPhieuXuat.SoLuong,DonGiaXuat FROM dbo.ChiTietPhieuXuat,dbo.HangHoa WHERE ChiTietPhieuXuat.MaHang=HangHoa.MaHang AND dbo.ChuyenDoiKiTuUnicode(DonGiaXuat) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%' OR dbo.ChuyenDoiKiTuUnicode(MaPhieuXuat) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%' OR dbo.ChuyenDoiKiTuUnicode(TenHang) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%' OR dbo.ChuyenDoiKiTuUnicode(ChiTietPhieuXuat.SoLuong) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data.Rows.Count > 0;
        }
        public DataTable TkCTPXTheoMaPhieuXuat(string maTK)
        {
            string query = "SELECT MaPhieuXuat,TenHang,ChiTietPhieuXuat.SoLuong,DonGiaXuat FROM dbo.ChiTietPhieuXuat,dbo.HangHoa WHERE ChiTietPhieuXuat.MaHang=HangHoa.MaHang AND dbo.ChuyenDoiKiTuUnicode(MaPhieuXuat) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'"+maTK+"')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public bool CheckTkCTPXTheoMaPhieuXuat(string maTK)
        {
            string query = "SELECT MaPhieuXuat,TenHang,ChiTietPhieuXuat.SoLuong,DonGiaXuat FROM dbo.ChiTietPhieuXuat,dbo.HangHoa WHERE ChiTietPhieuXuat.MaHang=HangHoa.MaHang AND dbo.ChuyenDoiKiTuUnicode(MaPhieuXuat) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data.Rows.Count > 0;
        }
        public DataTable TkCTPXTheoTenHang(string maTK)
        {
            string query = "SELECT MaPhieuXuat,TenHang,ChiTietPhieuXuat.SoLuong,DonGiaXuat FROM dbo.ChiTietPhieuXuat,dbo.HangHoa WHERE ChiTietPhieuXuat.MaHang=HangHoa.MaHang AND dbo.ChuyenDoiKiTuUnicode(TenHang) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'"+maTK+"')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public bool CheckTkCTPXTheoTenHang(string maTK)
        {
            string query = "SELECT MaPhieuXuat,TenHang,ChiTietPhieuXuat.SoLuong,DonGiaXuat FROM dbo.ChiTietPhieuXuat,dbo.HangHoa WHERE ChiTietPhieuXuat.MaHang=HangHoa.MaHang AND dbo.ChuyenDoiKiTuUnicode(TenHang) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data.Rows.Count > 0;
        }
        public DataTable TkCTPXTheoSoLuong(string maTK)
        {
            string query = "SELECT MaPhieuXuat,TenHang,ChiTietPhieuXuat.SoLuong,DonGiaXuat FROM dbo.ChiTietPhieuXuat,dbo.HangHoa WHERE ChiTietPhieuXuat.MaHang=HangHoa.MaHang AND dbo.ChuyenDoiKiTuUnicode(ChiTietPhieuXuat.SoLuong) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'"+maTK+"')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public bool CheckTkCTPXTheoSoLuong(string maTK)
        {
            string query = "SELECT MaPhieuXuat,TenHang,ChiTietPhieuXuat.SoLuong,DonGiaXuat FROM dbo.ChiTietPhieuXuat,dbo.HangHoa WHERE ChiTietPhieuXuat.MaHang=HangHoa.MaHang AND dbo.ChuyenDoiKiTuUnicode(ChiTietPhieuXuat.SoLuong) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data.Rows.Count > 0;
        }
        public DataTable TkCTPXTheoDonGiaXuat(string maTK)
        {
            string query = "SELECT MaPhieuXuat,TenHang,ChiTietPhieuXuat.SoLuong,DonGiaXuat FROM dbo.ChiTietPhieuXuat,dbo.HangHoa WHERE ChiTietPhieuXuat.MaHang=HangHoa.MaHang AND dbo.ChuyenDoiKiTuUnicode(DonGiaXuat) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'"+maTK+"')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public bool CheckTkCTPXTheoDonGiaXuat(string maTK)
        {
            string query = "SELECT MaPhieuXuat,TenHang,ChiTietPhieuXuat.SoLuong,DonGiaXuat FROM dbo.ChiTietPhieuXuat,dbo.HangHoa WHERE ChiTietPhieuXuat.MaHang=HangHoa.MaHang AND dbo.ChuyenDoiKiTuUnicode(DonGiaXuat) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data.Rows.Count > 0;
        }
    }
}
