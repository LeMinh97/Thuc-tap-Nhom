using QuanLiKhachSan.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiKhachSan.Module
{
    public class Phong
    {
        private static Phong instance;

        public static Phong Instance
        {
            get { if (instance == null) instance = new Phong(); return Phong.instance; }
            private set { Phong.instance = value; }
        }
        private Phong() { }

        public bool ThemPhong(string maPhong, string loaiPhong, string moTa,int tinhTrang, int donGiaGio)
        {
            string query = "INSERT dbo.Phong( MaPhong ,LoaiPhong ,MoTa ,TinhTrang ,DonGiaGio) VALUES  ( '"+maPhong+"' ,N'"+loaiPhong+"' ,N'"+moTa+"' ,"+tinhTrang+" , "+donGiaGio+" )";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool SuaPhong(string maPhong, string loaiPhong, string moTa, int tinhTrang, int donGiaGio)
        {
            string query = "UPDATE dbo.Phong SET LoaiPhong=N'"+loaiPhong+"',MoTa=N'"+moTa+"', TinhTrang="+tinhTrang+", DonGiaGio="+donGiaGio+" WHERE MaPhong='"+maPhong+"'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool XoaPhong(string maPhong)
        {
            string query = "DELETE dbo.Phong WHERE MaPhong='" + maPhong + "'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public DataTable TkTheoTatCa(string maTK)
        {
            string query = "SELECT * FROM dbo.Phong WHERE ( dbo.ChuyenDoiKiTuUnicode(TinhTrang) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%' OR dbo.ChuyenDoiKiTuUnicode(MoTa) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%' OR dbo.ChuyenDoiKiTuUnicode(LoaiPhong) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%' OR dbo.ChuyenDoiKiTuUnicode(MaPhong) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%' OR dbo.ChuyenDoiKiTuUnicode(DonGiaGio) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%')";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public bool CheckTkTheoTatCa(string maTK)
        {
            string query = "SELECT * FROM dbo.Phong WHERE ( dbo.ChuyenDoiKiTuUnicode(TinhTrang) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%' OR dbo.ChuyenDoiKiTuUnicode(MoTa) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%' OR dbo.ChuyenDoiKiTuUnicode(LoaiPhong) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%' OR dbo.ChuyenDoiKiTuUnicode(MaPhong) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%' OR dbo.ChuyenDoiKiTuUnicode(DonGiaGio) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%')";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data.Rows.Count > 0;
        }
        public DataTable TkTheoMaPhong(string maTK)
        {
            string query = "SELECT * FROM dbo.Phong WHERE dbo.ChuyenDoiKiTuUnicode(MaPhong) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'"+maTK+"')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public bool CheckTkTheoMaPhong(string maTK)
        {
            string query = "SELECT * FROM dbo.Phong WHERE dbo.ChuyenDoiKiTuUnicode(MaPhong) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data.Rows.Count > 0;
        }
        public DataTable TkTheoLoaiPhong(string maTK)
        {
            string query = "SELECT * FROM dbo.Phong WHERE dbo.ChuyenDoiKiTuUnicode(LoaiPhong) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public bool CheckTkTheoLoaiPhong(string maTK)
        {
            string query = "SELECT * FROM dbo.Phong WHERE dbo.ChuyenDoiKiTuUnicode(LoaiPhong) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data.Rows.Count > 0;
        }
        public DataTable TkTheoMoTa(string maTK)
        {
            string query = "SELECT * FROM dbo.Phong WHERE dbo.ChuyenDoiKiTuUnicode(MoTa) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public bool CheckTkTheoMoTa(string maTK)
        {
            string query = "SELECT * FROM dbo.Phong WHERE dbo.ChuyenDoiKiTuUnicode(MoTa) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data.Rows.Count > 0;
        }

        public DataTable TkTheoTinhTrang(string maTK)
        {
            string query = "SELECT * FROM dbo.Phong WHERE dbo.ChuyenDoiKiTuUnicode(TinhTrang) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public bool CheckTkTheoTinhTrang(string maTK)
        {
            string query = "SELECT * FROM dbo.Phong WHERE dbo.ChuyenDoiKiTuUnicode(TinhTrang) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data.Rows.Count > 0;
        }

        public DataTable TkTheoDonGiaGio(string maTK)
        {
            string query = "SELECT * FROM dbo.Phong WHERE dbo.ChuyenDoiKiTuUnicode(DonGiaGio) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public bool CheckTkTheoDonGiaGio(string maTK)
        {
            string query = "SELECT * FROM dbo.Phong WHERE dbo.ChuyenDoiKiTuUnicode(DonGiaGio) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data.Rows.Count > 0;
        }

    }
}
