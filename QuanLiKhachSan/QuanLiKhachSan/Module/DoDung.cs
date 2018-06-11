using QuanLiKhachSan.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiKhachSan.Module
{
    public class DoDung
    {
        private static DoDung instance;

        public static DoDung Instance
        {
            get { if (instance == null) instance = new DoDung(); return DoDung.instance; }
            private set { DoDung.instance = value; }
        }
        private DoDung() { }
        public bool ThemDoDung(string maPhong, string maDoDung, DateTime ngayKT, int soLgBD, int soLGDD)
        {
            string query = "INSERT dbo.DoDungTheoPhong( MaPhong , MaDoDung ,NgayKT ,SoLuongBanDau ,SoLuongDaDung) VALUES  ( '"+maPhong+"' , '"+maDoDung+"' , '"+ngayKT+"' , "+soLgBD+" , "+soLGDD+" )";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool SuaDoDung(string maPhong, string maDoDung, DateTime ngayKT, int soLgBD, int soLGDD)
        {
            string query = "UPDATE dbo.DoDungTheoPhong SET SoLuongBanDau=" + soLgBD + ",SoLuongDaDung="+soLGDD+" WHERE MaPhong='" + maPhong + "' AND MaDoDung='"+maDoDung+"' AND NgayKT='"+ngayKT+"'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool XoaDoDung(string maPhong, string maDoDung, DateTime ngayKT)
        {
            string query = "DELETE dbo.DoDungTheoPhong WHERE MaPhong='" + maPhong + "' AND MaDoDung='" + maDoDung + "' AND NgayKT='" + ngayKT + "'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public DataTable TkTheoTatCa(string maTK)
        {
            string query = "SELECT MaPhong,TenDoDung,NgayKT,SoLuongBanDau,SoLuongDaDung FROM dbo.DoDungTheoPhong,dbo.DoDung WHERE DoDungTheoPhong.MaDoDung=DoDung.MaDoDung AND (dbo.ChuyenDoiKiTuUnicode(MaPhong) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%' OR dbo.ChuyenDoiKiTuUnicode(TenDoDung) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%' OR dbo.ChuyenDoiKiTuUnicode(NgayKT) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%' OR dbo.ChuyenDoiKiTuUnicode(SoLuongBanDau) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%' OR dbo.ChuyenDoiKiTuUnicode(SoLuongDaDung) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%' )";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public bool CheckTkTheoTatCa(string maTK)
        {
            string query = "SELECT MaPhong,TenDoDung,NgayKT,SoLuongBanDau,SoLuongDaDung FROM dbo.DoDungTheoPhong,dbo.DoDung WHERE DoDungTheoPhong.MaDoDung=DoDung.MaDoDung AND (dbo.ChuyenDoiKiTuUnicode(MaPhong) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%' OR dbo.ChuyenDoiKiTuUnicode(TenDoDung) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%' OR dbo.ChuyenDoiKiTuUnicode(NgayKT) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%' OR dbo.ChuyenDoiKiTuUnicode(SoLuongBanDau) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%' OR dbo.ChuyenDoiKiTuUnicode(SoLuongDaDung) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%' )";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data.Rows.Count > 0;
        }
        public DataTable TkTheoMaPhong(string maTK)
        {
            string query = "SELECT MaPhong,TenDoDung,NgayKT,SoLuongBanDau,SoLuongDaDung FROM dbo.DoDungTheoPhong,dbo.DoDung WHERE DoDungTheoPhong.MaDoDung=DoDung.MaDoDung AND dbo.ChuyenDoiKiTuUnicode(MaPhong) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'"+maTK+"')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public bool CheckTkTheoMaPhong(string maTK)
        {
            string query = "SELECT MaPhong,TenDoDung,NgayKT,SoLuongBanDau,SoLuongDaDung FROM dbo.DoDungTheoPhong,dbo.DoDung WHERE DoDungTheoPhong.MaDoDung=DoDung.MaDoDung AND dbo.ChuyenDoiKiTuUnicode(MaPhong) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data.Rows.Count > 0;
        }
        public DataTable TkTheoTenDoDung(string maTK)
        {
            string query = "SELECT MaPhong,TenDoDung,NgayKT,SoLuongBanDau,SoLuongDaDung FROM dbo.DoDungTheoPhong,dbo.DoDung WHERE DoDungTheoPhong.MaDoDung=DoDung.MaDoDung AND dbo.ChuyenDoiKiTuUnicode(TenDoDung) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public bool CheckTkTheoTenDoDung(string maTK)
        {
            string query = "SELECT MaPhong,TenDoDung,NgayKT,SoLuongBanDau,SoLuongDaDung FROM dbo.DoDungTheoPhong,dbo.DoDung WHERE DoDungTheoPhong.MaDoDung=DoDung.MaDoDung AND dbo.ChuyenDoiKiTuUnicode(TenDoDung) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data.Rows.Count > 0;
        }
        public DataTable TkTheoNgayKT(string maTK)
        {
            string query = "SELECT MaPhong,TenDoDung,NgayKT,SoLuongBanDau,SoLuongDaDung FROM dbo.DoDungTheoPhong,dbo.DoDung WHERE DoDungTheoPhong.MaDoDung=DoDung.MaDoDung AND dbo.ChuyenDoiKiTuUnicode(NgayKT) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public bool CheckTkTheoNgayKT(string maTK)
        {
            string query = "SELECT MaPhong,TenDoDung,NgayKT,SoLuongBanDau,SoLuongDaDung FROM dbo.DoDungTheoPhong,dbo.DoDung WHERE DoDungTheoPhong.MaDoDung=DoDung.MaDoDung AND dbo.ChuyenDoiKiTuUnicode(NgayKT) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data.Rows.Count > 0;
        }

        public DataTable TkTheoSoLgBanDau(string maTK)
        {
            string query = "SELECT MaPhong,TenDoDung,NgayKT,SoLuongBanDau,SoLuongDaDung FROM dbo.DoDungTheoPhong,dbo.DoDung WHERE DoDungTheoPhong.MaDoDung=DoDung.MaDoDung AND dbo.ChuyenDoiKiTuUnicode(SoLuongBanDau) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public bool CheckTkTheoSoLuongBanDau(string maTK)
        {
            string query = "SELECT MaPhong,TenDoDung,NgayKT,SoLuongBanDau,SoLuongDaDung FROM dbo.DoDungTheoPhong,dbo.DoDung WHERE DoDungTheoPhong.MaDoDung=DoDung.MaDoDung AND dbo.ChuyenDoiKiTuUnicode(SoLuongBanDau) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data.Rows.Count > 0;
        }

        public DataTable TkTheoSoLgDaDung(string maTK)
        {
            string query = "SELECT MaPhong,TenDoDung,NgayKT,SoLuongBanDau,SoLuongDaDung FROM dbo.DoDungTheoPhong,dbo.DoDung WHERE DoDungTheoPhong.MaDoDung=DoDung.MaDoDung AND dbo.ChuyenDoiKiTuUnicode(SoLuongDaDung) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public bool CheckTkTheoSoLuongDaDung(string maTK)
        {
            string query = "SELECT MaPhong,TenDoDung,NgayKT,SoLuongBanDau,SoLuongDaDung FROM dbo.DoDungTheoPhong,dbo.DoDung WHERE DoDungTheoPhong.MaDoDung=DoDung.MaDoDung AND dbo.ChuyenDoiKiTuUnicode(SoLuongDaDung) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data.Rows.Count > 0;
        }
    }
}
