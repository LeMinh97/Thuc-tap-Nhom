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
        public bool ThemThuePhong(string maKH, string maPhong, DateTime ngayThue, int thoiGianO,string thanhToan)
        {
            string query = "INSERT dbo.ThuePhong( MaKhachHang ,MaPhong ,NgayThue ,ThoiGianO ,ThanhToan) VALUES  ( '"+maKH+"' , '"+maPhong+"' , '"+ngayThue+"' , "+thoiGianO+" , N'"+thanhToan+"' )";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            string query1 = "UPDATE dbo.Phong SET TinhTrang=N'OK' WHERE MaPhong='"+maPhong+"'";
            DataProvider.Instance.ExecuteNonQuery(query1);
            return result > 0;
        }
        public bool SuaThuePhong(string maKH, string maPhong, DateTime ngayThue, int thoiGianO, string thanhToan)
        {
            string query = "UPDATE dbo.ThuePhong SET ThanhToan=N'"+thanhToan+"', ThoiGianO="+thoiGianO+" WHERE MaKhachHang='"+maKH+"' AND MaPhong='"+maPhong+"' AND NgayThue='"+ngayThue+"'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool XoaThuePhong(string maKH, string maPhong, DateTime ngayThue)
        {
            string query1 = "UPDATE dbo.Phong SET TinhTrang=N'Chưa' WHERE MaPhong='" + maPhong + "'";
            DataProvider.Instance.ExecuteNonQuery(query1);
            string query = "DELETE dbo.ThuePhong WHERE MaPhong='" + maPhong + "' AND MaKhachHang='" + maKH + "' AND NgayThue='" + ngayThue + "'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public DataTable TkTheoTatCa(string maTK)
        {
            string query = "SELECT TenKhachHang,MaPhong,NgayThue,ThoiGianO,ThanhToan FROM dbo.ThuePhong,dbo.KhachHang WHERE KhachHang.MaKhachHang=ThuePhong.MaKhachHang AND (dbo.ChuyenDoiKiTuUnicode(MaPhong) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%' OR dbo.ChuyenDoiKiTuUnicode(TenKhachHang) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%' OR dbo.ChuyenDoiKiTuUnicode(NgayThue) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%' OR dbo.ChuyenDoiKiTuUnicode(ThoiGianO) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%' OR dbo.ChuyenDoiKiTuUnicode(ThanhToan) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%')";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public bool CheckTkTheoTatCa(string maTK)
        {
            string query = "SELECT TenKhachHang,MaPhong,NgayThue,ThoiGianO,ThanhToan FROM dbo.ThuePhong,dbo.KhachHang WHERE KhachHang.MaKhachHang=ThuePhong.MaKhachHang AND (dbo.ChuyenDoiKiTuUnicode(MaPhong) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%' OR dbo.ChuyenDoiKiTuUnicode(TenKhachHang) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%' OR dbo.ChuyenDoiKiTuUnicode(NgayThue) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%' OR dbo.ChuyenDoiKiTuUnicode(ThoiGianO) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%' OR dbo.ChuyenDoiKiTuUnicode(ThanhToan) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%')";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data.Rows.Count > 0;
        }
        public DataTable TkTheoMaPhong(string maTK)
        {
            string query = "SELECT TenKhachHang,MaPhong,NgayThue,ThoiGianO,ThanhToan FROM dbo.ThuePhong,dbo.KhachHang WHERE KhachHang.MaKhachHang=ThuePhong.MaKhachHang AND dbo.ChuyenDoiKiTuUnicode(MaPhong) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public bool CheckTkTheoMaPhong(string maTK)
        {
            string query = "SELECT TenKhachHang,MaPhong,NgayThue,ThoiGianO,ThanhToan FROM dbo.ThuePhong,dbo.KhachHang WHERE KhachHang.MaKhachHang=ThuePhong.MaKhachHang AND dbo.ChuyenDoiKiTuUnicode(MaPhong) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data.Rows.Count > 0;
        }
        public DataTable TkTheoTenKhachHang(string maTK)
        {
            string query = "SELECT TenKhachHang,MaPhong,NgayThue,ThoiGianO,ThanhToan FROM dbo.ThuePhong,dbo.KhachHang WHERE KhachHang.MaKhachHang=ThuePhong.MaKhachHang AND dbo.ChuyenDoiKiTuUnicode(TenKhachHang) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public bool CheckTkTheoTenKhachHang(string maTK)
        {
            string query = "SELECT TenKhachHang,MaPhong,NgayThue,ThoiGianO,ThanhToan FROM dbo.ThuePhong,dbo.KhachHang WHERE KhachHang.MaKhachHang=ThuePhong.MaKhachHang AND dbo.ChuyenDoiKiTuUnicode(TenKhachHang) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data.Rows.Count > 0;
        }
        public DataTable TkTheoNgayThue(string maTK)
        {
            string query = "SELECT TenKhachHang,MaPhong,NgayThue,ThoiGianO,ThanhToan FROM dbo.ThuePhong,dbo.KhachHang WHERE KhachHang.MaKhachHang=ThuePhong.MaKhachHang AND dbo.ChuyenDoiKiTuUnicode(NgayThue) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public bool CheckTkTheoNgayThue(string maTK)
        {
            string query = "SELECT TenKhachHang,MaPhong,NgayThue,ThoiGianO,ThanhToan FROM dbo.ThuePhong,dbo.KhachHang WHERE KhachHang.MaKhachHang=ThuePhong.MaKhachHang AND dbo.ChuyenDoiKiTuUnicode(NgayThue) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data.Rows.Count > 0;
        }

        public DataTable TkTheoThoiGianO(string maTK)
        {
            string query = "SELECT TenKhachHang,MaPhong,NgayThue,ThoiGianO,ThanhToan FROM dbo.ThuePhong,dbo.KhachHang WHERE KhachHang.MaKhachHang=ThuePhong.MaKhachHang AND dbo.ChuyenDoiKiTuUnicode(ThoiGianO) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public bool CheckTkTheoThoiGianO(string maTK)
        {
            string query = "SELECT TenKhachHang,MaPhong,NgayThue,ThoiGianO,ThanhToan FROM dbo.ThuePhong,dbo.KhachHang WHERE KhachHang.MaKhachHang=ThuePhong.MaKhachHang AND dbo.ChuyenDoiKiTuUnicode(ThoiGianO) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data.Rows.Count > 0;
        }

        public DataTable TkTheoThanhToan(string maTK)
        {
            string query = "SELECT TenKhachHang,MaPhong,NgayThue,ThoiGianO,ThanhToan FROM dbo.ThuePhong,dbo.KhachHang WHERE KhachHang.MaKhachHang=ThuePhong.MaKhachHang AND dbo.ChuyenDoiKiTuUnicode(ThanhToan) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public bool CheckTkTheoThanhToan(string maTK)
        {
            string query = "SELECT TenKhachHang,MaPhong,NgayThue,ThoiGianO,ThanhToan FROM dbo.ThuePhong,dbo.KhachHang WHERE KhachHang.MaKhachHang=ThuePhong.MaKhachHang AND dbo.ChuyenDoiKiTuUnicode(ThanhToan) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data.Rows.Count > 0;
        }
    }
}
