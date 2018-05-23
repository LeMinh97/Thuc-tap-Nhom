using QuanLiKhachSan.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiKhachSan.Module
{
    public class ThuePhong
    {
        private static ThuePhong instance;

        public static ThuePhong Instance
        {
            get { if (instance == null) instance = new ThuePhong(); return ThuePhong.instance; }
            private set { ThuePhong.instance = value; }
        }
        private ThuePhong() { }
        public bool ThemThuePhong(string maKH, string maPhong, DateTime ngayThue, int thoiGian)
        {
            string query = "INSERT dbo.ThuePhong( MaKhachHang ,MaPhong ,NgayThue ,ThoiGian) VALUES  ( '"+maKH+"' ,'"+maPhong+"' ,'"+ngayThue+"' ,"+thoiGian+")";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            string query1 = "UPDATE dbo.Phong SET TinhTrang=1 WHERE MaPhong='"+maPhong+"'";
            DataProvider.Instance.ExecuteNonQuery(query1);
            return result > 0;
        }
        public bool SuaThuePhong(string maKH, string maPhong, DateTime ngayThue, int thoiGian)
        {
            string query = "UPDATE dbo.ThuePhong SET NgayThue='"+ngayThue+"', ThoiGian="+thoiGian+" WHERE MaKhachHang='"+maKH+"' AND MaPhong='"+maPhong+"'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool XoaThuePhong(string maKH, string maPhong)
        {
            string query1 = "UPDATE dbo.Phong SET TinhTrang=0 WHERE MaPhong='" + maPhong + "'";
            DataProvider.Instance.ExecuteNonQuery(query1);
            string query = "DELETE dbo.ThuePhong WHERE MaPhong='" + maPhong + "' AND MaKhachHang='"+maKH+"'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public DataTable TkTheoTatCa(string maTK)
        {
            string query = "SELECT TenKhachHang,MaPhong,NgayThue,ThoiGian FROM dbo.ThuePhong,dbo.KhachHang WHERE KhachHang.MaKhachHang=ThuePhong.MaKhachHang AND (dbo.ChuyenDoiKiTuUnicode(MaPhong) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%' OR dbo.ChuyenDoiKiTuUnicode(TenKhachHang) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%' OR dbo.ChuyenDoiKiTuUnicode(NgayThue) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%' OR dbo.ChuyenDoiKiTuUnicode(ThoiGian) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%')";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public bool CheckTkTheoTatCa(string maTK)
        {
            string query = "SELECT TenKhachHang,MaPhong,NgayThue,ThoiGian FROM dbo.ThuePhong,dbo.KhachHang WHERE KhachHang.MaKhachHang=ThuePhong.MaKhachHang AND (dbo.ChuyenDoiKiTuUnicode(MaPhong) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%' OR dbo.ChuyenDoiKiTuUnicode(TenKhachHang) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%' OR dbo.ChuyenDoiKiTuUnicode(NgayThue) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%' OR dbo.ChuyenDoiKiTuUnicode(ThoiGian) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%')";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data.Rows.Count > 0;
        }
        public DataTable TkTheoMaPhong(string maTK)
        {
            string query = "SELECT TenKhachHang,MaPhong,NgayThue,ThoiGian FROM dbo.ThuePhong,dbo.KhachHang WHERE KhachHang.MaKhachHang=ThuePhong.MaKhachHang AND dbo.ChuyenDoiKiTuUnicode(MaPhong) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'"+maTK+"')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public bool CheckTkTheoMaPhong(string maTK)
        {
            string query = "SELECT TenKhachHang,MaPhong,NgayThue,ThoiGian FROM dbo.ThuePhong,dbo.KhachHang WHERE KhachHang.MaKhachHang=ThuePhong.MaKhachHang AND dbo.ChuyenDoiKiTuUnicode(MaPhong) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data.Rows.Count > 0;
        }
        public DataTable TkTheoTenKhachHang(string maTK)
        {
            string query = "SELECT TenKhachHang,MaPhong,NgayThue,ThoiGian FROM dbo.ThuePhong,dbo.KhachHang WHERE KhachHang.MaKhachHang=ThuePhong.MaKhachHang AND dbo.ChuyenDoiKiTuUnicode(TenKhachHang) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public bool CheckTkTheoTenKhachHang(string maTK)
        {
            string query = "SELECT TenKhachHang,MaPhong,NgayThue,ThoiGian FROM dbo.ThuePhong,dbo.KhachHang WHERE KhachHang.MaKhachHang=ThuePhong.MaKhachHang AND dbo.ChuyenDoiKiTuUnicode(TenKhachHang) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data.Rows.Count > 0;
        }
        public DataTable TkTheoNgayThue(string maTK)
        {
            string query = "SELECT TenKhachHang,MaPhong,NgayThue,ThoiGian FROM dbo.ThuePhong,dbo.KhachHang WHERE KhachHang.MaKhachHang=ThuePhong.MaKhachHang AND dbo.ChuyenDoiKiTuUnicode(NgayThue) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public bool CheckTkTheoNgayThue(string maTK)
        {
            string query = "SELECT TenKhachHang,MaPhong,NgayThue,ThoiGian FROM dbo.ThuePhong,dbo.KhachHang WHERE KhachHang.MaKhachHang=ThuePhong.MaKhachHang AND dbo.ChuyenDoiKiTuUnicode(NgayThue) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data.Rows.Count > 0;
        }

        public DataTable TkTheoThoiGianO(string maTK)
        {
            string query = "SELECT TenKhachHang,MaPhong,NgayThue,ThoiGian FROM dbo.ThuePhong,dbo.KhachHang WHERE KhachHang.MaKhachHang=ThuePhong.MaKhachHang AND dbo.ChuyenDoiKiTuUnicode(ThoiGian) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public bool CheckTkTheoThoiGianO(string maTK)
        {
            string query = "SELECT TenKhachHang,MaPhong,NgayThue,ThoiGian FROM dbo.ThuePhong,dbo.KhachHang WHERE KhachHang.MaKhachHang=ThuePhong.MaKhachHang AND dbo.ChuyenDoiKiTuUnicode(ThoiGian) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data.Rows.Count > 0;
        }
    }
}
