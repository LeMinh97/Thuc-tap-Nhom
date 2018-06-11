using QuanLiKhachSan.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiKhachSan.Module
{
    public class SuDungDichVu
    {
        private static SuDungDichVu instance;

        public static SuDungDichVu Instance
        {
            get { if (instance == null) instance = new SuDungDichVu(); return SuDungDichVu.instance; }
            private set { SuDungDichVu.instance = value; }
        }
        private SuDungDichVu() { }
        public bool ThemSDDV(string maPhong, string maDichVu, DateTime ngayDung, int soLuong, string thanhToan)
        {
            string query = "INSERT dbo.SuDungDichVu( MaPhong , MaDichVu , NgayDung , SoLuong ,ThanhToan) VALUES  ( '"+maPhong+"' , '"+maDichVu+"' ,'"+ngayDung+"',"+soLuong+" ,N'"+thanhToan+"')";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool SuaSDDV(string maPhong, string maDichVu, DateTime ngayDung, int soLuong, string thanhToan)
        {
            string query = "UPDATE dbo.SuDungDichVu SET SoLuong="+soLuong+", ThanhToan=N'"+thanhToan+"' WHERE MaPhong='" + maPhong + "' AND MaDichVu='"+maDichVu+"' AND NgayDung='"+ngayDung+"'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool XoaSDDV(string maPhong, string maDichVu, DateTime ngayDung)
        {
            string query = "DELETE dbo.SuDungDichVu WHERE MaPhong='" + maPhong + "' AND MaDichVu='" + maDichVu + "' AND NgayDung='" + ngayDung + "'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public DataTable TkTheoTatCa(string maTK)
        {
            string query = "SELECT MaPhong,TenDichVu,NgayDung,SoLuong,ThanhToan FROM dbo.SuDungDichVu,dbo.DichVu WHERE DichVu.MaDichVu=SuDungDichVu.MaDichVu AND (dbo.ChuyenDoiKiTuUnicode(MaPhong) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%' OR dbo.ChuyenDoiKiTuUnicode(TenDichVu) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%' OR dbo.ChuyenDoiKiTuUnicode(NgayDung) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%' OR dbo.ChuyenDoiKiTuUnicode(SoLuong) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%' OR dbo.ChuyenDoiKiTuUnicode(ThanhToan) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%' )";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public bool CheckTkTheoTatCa(string maTK)
        {
            string query = "SELECT MaPhong,TenDichVu,NgayDung,SoLuong,ThanhToan FROM dbo.SuDungDichVu,dbo.DichVu WHERE DichVu.MaDichVu=SuDungDichVu.MaDichVu AND dbo.ChuyenDoiKiTuUnicode(MaPhong) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data.Rows.Count > 0;
        }
        public DataTable TkTheoMaPhong(string maTK)
        {
            string query = "SELECT MaPhong,TenDichVu,NgayDung,SoLuong,ThanhToan FROM dbo.SuDungDichVu,dbo.DichVu WHERE DichVu.MaDichVu=SuDungDichVu.MaDichVu AND dbo.ChuyenDoiKiTuUnicode(MaPhong) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'"+maTK+"')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public bool CheckTkTheoMaPhong(string maTK)
        {
            string query = "SELECT MaPhong,TenDichVu,NgayDung,SoLuong,ThanhToan FROM dbo.SuDungDichVu,dbo.DichVu WHERE DichVu.MaDichVu=SuDungDichVu.MaDichVu AND dbo.ChuyenDoiKiTuUnicode(MaPhong) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data.Rows.Count > 0;
        }
        public DataTable TkTheoTenDichVu(string maTK)
        {
            string query = "SELECT MaPhong,TenDichVu,NgayDung,SoLuong,ThanhToan FROM dbo.SuDungDichVu,dbo.DichVu WHERE DichVu.MaDichVu=SuDungDichVu.MaDichVu AND dbo.ChuyenDoiKiTuUnicode(TenDichVu) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public bool CheckTkTheoTenDichVu(string maTK)
        {
            string query = "SELECT MaPhong,TenDichVu,NgayDung,SoLuong,ThanhToan FROM dbo.SuDungDichVu,dbo.DichVu WHERE DichVu.MaDichVu=SuDungDichVu.MaDichVu AND dbo.ChuyenDoiKiTuUnicode(TenDichVu) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data.Rows.Count > 0;
        }
        public DataTable TkTheoNgayDung(string maTK)
        {
            string query = "SELECT MaPhong,TenDichVu,NgayDung,SoLuong,ThanhToan FROM dbo.SuDungDichVu,dbo.DichVu WHERE DichVu.MaDichVu=SuDungDichVu.MaDichVu AND dbo.ChuyenDoiKiTuUnicode(NgayDung) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public bool CheckTkTheoNgayDung(string maTK)
        {
            string query = "SELECT MaPhong,TenDichVu,NgayDung,SoLuong,ThanhToan FROM dbo.SuDungDichVu,dbo.DichVu WHERE DichVu.MaDichVu=SuDungDichVu.MaDichVu AND dbo.ChuyenDoiKiTuUnicode(NgayDung) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data.Rows.Count > 0;
        }

        public DataTable TkTheoSoLuong(string maTK)
        {
            string query = "SELECT MaPhong,TenDichVu,NgayDung,SoLuong,ThanhToan FROM dbo.SuDungDichVu,dbo.DichVu WHERE DichVu.MaDichVu=SuDungDichVu.MaDichVu AND dbo.ChuyenDoiKiTuUnicode(SoLuong) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public bool CheckTkTheoSoLuong(string maTK)
        {
            string query = "SELECT MaPhong,TenDichVu,NgayDung,SoLuong,ThanhToan FROM dbo.SuDungDichVu,dbo.DichVu WHERE DichVu.MaDichVu=SuDungDichVu.MaDichVu AND dbo.ChuyenDoiKiTuUnicode(SoLuong) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data.Rows.Count > 0;
        }

        public DataTable TkTheoThanhToan(string maTK)
        {
            string query = "SELECT MaPhong,TenDichVu,NgayDung,SoLuong,ThanhToan FROM dbo.SuDungDichVu,dbo.DichVu WHERE DichVu.MaDichVu=SuDungDichVu.MaDichVu AND dbo.ChuyenDoiKiTuUnicode(ThanhToan) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public bool CheckTkTheoThanhToan(string maTK)
        {
            string query = "SELECT MaPhong,TenDichVu,NgayDung,SoLuong,ThanhToan FROM dbo.SuDungDichVu,dbo.DichVu WHERE DichVu.MaDichVu=SuDungDichVu.MaDichVu AND dbo.ChuyenDoiKiTuUnicode(ThanhToan) LIKE N'%'+dbo.ChuyenDoiKiTuUnicode(N'" + maTK + "')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data.Rows.Count > 0;
        }
    }
}
