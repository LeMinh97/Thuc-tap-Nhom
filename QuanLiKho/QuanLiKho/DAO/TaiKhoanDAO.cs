using QuanLiKho.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiKho.DAO
{
    public class TaiKhoanDAO
    {
        private static TaiKhoanDAO instance;

        public static TaiKhoanDAO Instance
        {
            get { if (instance == null) instance = new TaiKhoanDAO(); return TaiKhoanDAO.instance; }
            private set { TaiKhoanDAO.instance = value; }
        }
        private TaiKhoanDAO() { }
        public TaiKhoan LayTKtuTenDN(string tenDN)
        {
            string query = "SELECT TenDN,TenND,MatKhau,LoaiTK FROM dbo.TaiKhoan,dbo.LoaiTK WHERE TaiKhoan.MaLoaiTK=LoaiTK.MaLoaiTK AND TenDN='" + tenDN + "'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                return new TaiKhoan(item);
            }
            return null;
        }

        public bool ThemTK(string tenDN, string tenND, string matKhau, string maLoaiTK)
        {
            string query = "INSERT dbo.TaiKhoan( TenDN, TenND, MatKhau, MaLoaiTK )VALUES  ( N'" + tenDN + "', N'" + tenND + "', N'" + matKhau + "','" + maLoaiTK + "' )";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool SuaTK(string tenDN, string tenND, string matKhau, string maLoaiTK)
        {
            string query = "UPDATE dbo.TaiKhoan SET TenND=N'" + tenND + "', MatKhau=N'" + matKhau + "', MaLoaiTK='" + maLoaiTK + "' WHERE TenDN=N'" + tenDN + "'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool XoaTK(string tenDN)
        {
            string query = "DELETE dbo.TaiKhoan WHERE TenDN=N'" + tenDN + "'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public DataTable TkTheoTatCa(string maTK)
        {
            string query = "SELECT TenDN,TenND,MatKhau,LoaiTK FROM dbo.TaiKhoan,dbo.LoaiTK WHERE LoaiTK.MaLoaiTK=TaiKhoan.MaLoaiTK AND dbo.ChuyenDoiKiTuUnicode(TenDN) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%' OR dbo.ChuyenDoiKiTuUnicode(TenND) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%' OR dbo.ChuyenDoiKiTuUnicode(LoaiTK) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public bool CheckTkTheoTatCa(string maTK)
        {
            string query = "SELECT TenDN,TenND,MatKhau,LoaiTK FROM dbo.TaiKhoan,dbo.LoaiTK WHERE LoaiTK.MaLoaiTK=TaiKhoan.MaLoaiTK AND dbo.ChuyenDoiKiTuUnicode(TenDN) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%' OR dbo.ChuyenDoiKiTuUnicode(TenND) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%' OR dbo.ChuyenDoiKiTuUnicode(LoaiTK) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data.Rows.Count > 0;
        }
        public DataTable TkTheoTenDangNhap(string maTK)
        {
            string query = "SELECT TenDN,TenND,MatKhau,LoaiTK FROM dbo.TaiKhoan,dbo.LoaiTK WHERE LoaiTK.MaLoaiTK=TaiKhoan.MaLoaiTK AND dbo.ChuyenDoiKiTuUnicode(TenDN) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public bool CheckTkTheoTenDangNhap(string maTK)
        {
            string query = "SELECT TenDN,TenND,MatKhau,LoaiTK FROM dbo.TaiKhoan,dbo.LoaiTK WHERE LoaiTK.MaLoaiTK=TaiKhoan.MaLoaiTK AND dbo.ChuyenDoiKiTuUnicode(TenDN) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data.Rows.Count > 0;
        }
        public DataTable TkTheoTenTaiKhoan(string maTK)
        {
            string query = "SELECT TenDN,TenND,MatKhau,LoaiTK FROM dbo.TaiKhoan,dbo.LoaiTK WHERE LoaiTK.MaLoaiTK=TaiKhoan.MaLoaiTK AND dbo.ChuyenDoiKiTuUnicode(TenND) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public bool CheckTkTheoTenTaiKhoan(string maTK)
        {
            string query = "SELECT TenDN,TenND,MatKhau,LoaiTK FROM dbo.TaiKhoan,dbo.LoaiTK WHERE LoaiTK.MaLoaiTK=TaiKhoan.MaLoaiTK AND dbo.ChuyenDoiKiTuUnicode(TenND) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data.Rows.Count > 0;
        }
        public DataTable TkTheoLoaiTK(string maTK)
        {
            string query = "SELECT TenDN,TenND,MatKhau,LoaiTK FROM dbo.TaiKhoan,dbo.LoaiTK WHERE LoaiTK.MaLoaiTK=TaiKhoan.MaLoaiTK AND dbo.ChuyenDoiKiTuUnicode(LoaiTK) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public bool CheckTkTheoLoaiTK(string maTK)
        {
            string query = "SELECT TenDN,TenND,MatKhau,LoaiTK FROM dbo.TaiKhoan,dbo.LoaiTK WHERE LoaiTK.MaLoaiTK=TaiKhoan.MaLoaiTK AND dbo.ChuyenDoiKiTuUnicode(LoaiTK) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data.Rows.Count > 0;
        }

    }
}
