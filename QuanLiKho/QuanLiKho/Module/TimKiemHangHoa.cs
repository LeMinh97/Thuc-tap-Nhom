using QuanLiKho.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiKho.Module
{
    public class TimKiemHangHoa
    {
        private static TimKiemHangHoa instance;

        public static TimKiemHangHoa Instance
        {
            get { if (instance == null) instance = new TimKiemHangHoa(); return TimKiemHangHoa.instance; }
            private set { TimKiemHangHoa.instance = value; }
        }
        private TimKiemHangHoa() { }

        public DataTable TimKiemTheoTatCa(string maTK)
        {
            string query = "SELECT * FROM dbo.HangHoa WHERE dbo.ChuyenDoiKiTuUnicode(MaHang) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%' OR dbo.ChuyenDoiKiTuUnicode(TenHang) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%' OR dbo.ChuyenDoiKiTuUnicode(NganhHang) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%' OR dbo.ChuyenDoiKiTuUnicode(DVT) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public bool CheckTimKiemTheoTatCa(string maTK)
        {
            string query = "SELECT * FROM dbo.HangHoa WHERE dbo.ChuyenDoiKiTuUnicode(MaHang) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%' OR dbo.ChuyenDoiKiTuUnicode(TenHang) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%' OR dbo.ChuyenDoiKiTuUnicode(NganhHang) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%' OR dbo.ChuyenDoiKiTuUnicode(DVT) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data.Rows.Count > 0;
        }

        public DataTable TimKiemTheoMaHang(string maTK)
        {
            string query = "SELECT * FROM dbo.HangHoa WHERE dbo.ChuyenDoiKiTuUnicode(MaHang) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'"+maTK+"')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public bool CheckTimKiemTheoMaHang(string maTK)
        {
            string query = "SELECT * FROM dbo.HangHoa WHERE dbo.ChuyenDoiKiTuUnicode(MaHang) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data.Rows.Count > 0;
        }

        public DataTable TimKiemTheoTenHang(string maTK)
        {
            string query = "SELECT * FROM dbo.HangHoa WHERE dbo.ChuyenDoiKiTuUnicode(TenHang) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'"+maTK+"')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public bool CheckTimKiemTheoTenHang(string maTK)
        {
            string query = "SELECT * FROM dbo.HangHoa WHERE dbo.ChuyenDoiKiTuUnicode(TenHang) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data.Rows.Count > 0;
        }

        public DataTable TimKiemTheoNganhHang(string maTK)
        {
            string query = "SELECT * FROM dbo.HangHoa WHERE dbo.ChuyenDoiKiTuUnicode(NganhHang) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'"+maTK+"')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public bool CheckTimKiemTheoNganhHang(string maTK)
        {
            string query = "SELECT * FROM dbo.HangHoa WHERE dbo.ChuyenDoiKiTuUnicode(NganhHang) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data.Rows.Count > 0;
        }
        public DataTable TimKiemTheoDVT(string maTK)
        {
            string query = "SELECT * FROM dbo.HangHoa WHERE dbo.ChuyenDoiKiTuUnicode(DVT) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'"+maTK+"')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public bool CheckTimKiemTheoDVT(string maTK)
        {
            string query = "SELECT * FROM dbo.HangHoa WHERE dbo.ChuyenDoiKiTuUnicode(DVT) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data.Rows.Count > 0;
        }
    }
}
