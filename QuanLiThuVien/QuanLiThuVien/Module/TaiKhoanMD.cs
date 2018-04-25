using QuanLiThuVien.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiThuVien.Module
{
    public class TaiKhoanMD
    {
        private static TaiKhoanMD instance;

        public static TaiKhoanMD Instance
        {
            get { if (instance == null) instance = new TaiKhoanMD(); return TaiKhoanMD.instance; }
            private set { TaiKhoanMD.instance = value; }
        }
        private TaiKhoanMD() { }
        public bool ThemTK(string tenDN,string tenND,string matKhau,int maLoaiTK)
        {
            string query = "INSERT dbo.NguoiDung( TenDN, TenND, MatKhau, MaLoaiTK )VALUES  ( N'"+tenDN+"', N'"+tenND+"', N'"+matKhau+"',"+maLoaiTK+" )";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool SuaTK(string tenDN, string tenND, string matKhau, int maLoaiTK)
        {
            string query = "UPDATE dbo.NguoiDung SET TenND=N'"+tenND+"', MatKhau=N'"+matKhau+"', MaLoaiTK="+maLoaiTK+" WHERE TenDN=N'"+tenDN+"'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool XoaTK(string tenDN)
        {
            string query = "DELETE dbo.NguoiDung WHERE TenDN=N'"+tenDN+"'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public DataTable TkTheoTatCa(string maTK)
        {
            string query = "SELECT TenDN,TenND,MatKhau,LoaiTK FROM dbo.NguoiDung,dbo.LoaiTK WHERE LoaiTK.MaLoaiTK=NguoiDung.MaLoaiTK AND dbo.fuConvertToUnsign1(TenDN) LIKE N'%'+dbo.fuConvertToUnsign1(N'" + maTK + "')+N'%' OR dbo.fuConvertToUnsign1(TenND) LIKE N'%'+dbo.fuConvertToUnsign1(N'" + maTK + "')+N'%' OR dbo.fuConvertToUnsign1(LoaiTK) LIKE N'%'+dbo.fuConvertToUnsign1(N'" + maTK + "')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public bool CheckTkTheoTatCa(string maTK)
        {
            string query = "SELECT TenDN,TenND,MatKhau,LoaiTK FROM dbo.NguoiDung,dbo.LoaiTK WHERE LoaiTK.MaLoaiTK=NguoiDung.MaLoaiTK AND dbo.fuConvertToUnsign1(TenDN) LIKE N'%'+dbo.fuConvertToUnsign1(N'" + maTK + "')+N'%' OR dbo.fuConvertToUnsign1(TenND) LIKE N'%'+dbo.fuConvertToUnsign1(N'" + maTK + "')+N'%' OR dbo.fuConvertToUnsign1(LoaiTK) LIKE N'%'+dbo.fuConvertToUnsign1(N'" + maTK + "')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data.Rows.Count > 0;
        }
        public DataTable TkTheoTenDangNhap(string maTK)
        {
            string query = "SELECT TenDN,TenND,MatKhau,LoaiTK FROM dbo.NguoiDung,dbo.LoaiTK WHERE LoaiTK.MaLoaiTK=NguoiDung.MaLoaiTK AND dbo.fuConvertToUnsign1(TenDN) LIKE N'%'+dbo.fuConvertToUnsign1(N'"+maTK+"')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public bool CheckTkTheoTenDangNhap(string maTK)
        {
            string query = "SELECT TenDN,TenND,MatKhau,LoaiTK FROM dbo.NguoiDung,dbo.LoaiTK WHERE LoaiTK.MaLoaiTK=NguoiDung.MaLoaiTK AND dbo.fuConvertToUnsign1(TenDN) LIKE N'%'+dbo.fuConvertToUnsign1(N'" + maTK + "')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data.Rows.Count > 0;
        }
        public DataTable TkTheoTenNguoiDung(string maTK)
        {
            string query = "SELECT TenDN,TenND,MatKhau,LoaiTK FROM dbo.NguoiDung,dbo.LoaiTK WHERE LoaiTK.MaLoaiTK=NguoiDung.MaLoaiTK AND dbo.fuConvertToUnsign1(TenND) LIKE N'%'+dbo.fuConvertToUnsign1(N'"+maTK+"')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public bool CheckTkTheoTenNguoiDung(string maTK)
        {
            string query = "SELECT TenDN,TenND,MatKhau,LoaiTK FROM dbo.NguoiDung,dbo.LoaiTK WHERE LoaiTK.MaLoaiTK=NguoiDung.MaLoaiTK AND dbo.fuConvertToUnsign1(TenND) LIKE N'%'+dbo.fuConvertToUnsign1(N'" + maTK + "')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data.Rows.Count > 0;
        }
        public DataTable TkTheoLoaiTK(string maTK)
        {
            string query = "SELECT TenDN,TenND,MatKhau,LoaiTK FROM dbo.NguoiDung,dbo.LoaiTK WHERE LoaiTK.MaLoaiTK=NguoiDung.MaLoaiTK AND dbo.fuConvertToUnsign1(LoaiTK) LIKE N'%'+dbo.fuConvertToUnsign1(N'"+maTK+"')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public bool CheckTkTheoLoaiTK(string maTK)
        {
            string query = "SELECT TenDN,TenND,MatKhau,LoaiTK FROM dbo.NguoiDung,dbo.LoaiTK WHERE LoaiTK.MaLoaiTK=NguoiDung.MaLoaiTK AND dbo.fuConvertToUnsign1(LoaiTK) LIKE N'%'+dbo.fuConvertToUnsign1(N'" + maTK + "')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data.Rows.Count > 0;
        }
    }
}
