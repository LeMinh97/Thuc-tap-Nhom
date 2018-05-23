using QuanLiKhachSan.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiKhachSan.Module
{
    public class KhachHang
    {
        private static KhachHang instance;

        public static KhachHang Instance
        {
            get { if (instance == null) instance = new KhachHang(); return KhachHang.instance; }
            private set { KhachHang.instance = value; }
        }
        private KhachHang() { }

        public bool ThemKhachHang(string maKH, string tenKH, string gioiTinh, DateTime ngaySinh, string soCMT, string sdt)
        {
            string query = "INSERT dbo.KhachHang( MaKhachHang ,TenKhachHang ,GioiTinh ,NgaySinh ,SoCMT ,SDT) VALUES  ( '"+maKH+"' ,N'"+tenKH+"' ,N'"+gioiTinh+"' ,'"+ngaySinh+"', '"+soCMT+"' , '"+sdt+"' )";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool SuaKhachHang(string maKH, string tenKH, string gioiTinh, DateTime ngaySinh, string soCMT, string sdt)
        {
            string query = "UPDATE dbo.KhachHang SET TenKhachHang=N'"+tenKH+"',GioiTinh=N'"+gioiTinh+"',NgaySinh='"+ngaySinh+"',SoCMT='"+soCMT+"',SDT='"+sdt+"' WHERE MaKhachHang='"+maKH+"'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool XoaKhachHang(string maKH)
        {
            string query = "DELETE dbo.KhachHang WHERE MaKhachHang='"+maKH+"'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public DataTable TkTheoTatCa(string maTK)
        {
            string query = "SELECT * FROM dbo.KhachHang WHERE ( dbo.ChuyenDoiKiTuUnicode(MaKhachHang) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%' OR dbo.ChuyenDoiKiTuUnicode(TenKhachHang) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%' OR dbo.ChuyenDoiKiTuUnicode(GioiTinh) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%' OR dbo.ChuyenDoiKiTuUnicode(NgaySinh) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%' OR dbo.ChuyenDoiKiTuUnicode(SoCMT) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%' OR dbo.ChuyenDoiKiTuUnicode(SDT) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%')";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public bool CheckTkTheoTatCa(string maTK)
        {
            string query = "SELECT * FROM dbo.KhachHang WHERE ( dbo.ChuyenDoiKiTuUnicode(MaKhachHang) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%' OR dbo.ChuyenDoiKiTuUnicode(TenKhachHang) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%' OR dbo.ChuyenDoiKiTuUnicode(GioiTinh) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%' OR dbo.ChuyenDoiKiTuUnicode(NgaySinh) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%' OR dbo.ChuyenDoiKiTuUnicode(SoCMT) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%' OR dbo.ChuyenDoiKiTuUnicode(SDT) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%')";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data.Rows.Count > 0;
        }
        public DataTable TkTheoMaKhachHang(string maTK)
        {
            string query = "SELECT * FROM dbo.KhachHang WHERE dbo.ChuyenDoiKiTuUnicode(MaKhachHang) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'"+maTK+"')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public bool CheckTkTheoMaKhachHang(string maTK)
        {
            string query = "SELECT * FROM dbo.KhachHang WHERE dbo.ChuyenDoiKiTuUnicode(MaKhachHang) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data.Rows.Count > 0;
        }
        public DataTable TkTheoTenKhachHang(string maTK)
        {
            string query = "SELECT * FROM dbo.KhachHang WHERE dbo.ChuyenDoiKiTuUnicode(TenKhachHang) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public bool CheckTkTheoTenKhachHang(string maTK)
        {
            string query = "SELECT * FROM dbo.KhachHang WHERE dbo.ChuyenDoiKiTuUnicode(MaKhachHang) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data.Rows.Count > 0;
        }
        public DataTable TkTheoGioiTinh(string maTK)
        {
            string query = "SELECT * FROM dbo.KhachHang WHERE dbo.ChuyenDoiKiTuUnicode(GioiTinh) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public bool CheckTkTheoGioiTinh(string maTK)
        {
            string query = "SELECT * FROM dbo.KhachHang WHERE dbo.ChuyenDoiKiTuUnicode(GioiTinh) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data.Rows.Count > 0;
        }

        public DataTable TkTheoNgaySinh(string maTK)
        {
            string query = "SELECT * FROM dbo.KhachHang WHERE dbo.ChuyenDoiKiTuUnicode(NgaySinh) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public bool CheckTkTheoNgaySinh(string maTK)
        {
            string query = "SELECT * FROM dbo.KhachHang WHERE dbo.ChuyenDoiKiTuUnicode(NgaySinh) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data.Rows.Count > 0;
        }

        public DataTable TkTheoSoCMT(string maTK)
        {
            string query = "SELECT * FROM dbo.Phong WHERE dbo.ChuyenDoiKiTuUnicode(SoCMT) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public bool CheckTkTheoSoCMT(string maTK)
        {
            string query = "SELECT * FROM dbo.Phong WHERE dbo.ChuyenDoiKiTuUnicode(SoCMT) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data.Rows.Count > 0;
        }

        public DataTable TkTheoSDT(string maTK)
        {
            string query = "SELECT * FROM dbo.Phong WHERE dbo.ChuyenDoiKiTuUnicode(SDT) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public bool CheckTkTheoSDT(string maTK)
        {
            string query = "SELECT * FROM dbo.Phong WHERE dbo.ChuyenDoiKiTuUnicode(SDT) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data.Rows.Count > 0;
        }
    }
}
