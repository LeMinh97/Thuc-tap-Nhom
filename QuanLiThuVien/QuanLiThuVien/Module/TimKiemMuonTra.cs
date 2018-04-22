using QuanLiThuVien.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiThuVien.Module
{
    public class TimKiemMuonTra
    {
        private static TimKiemMuonTra instance;

        public static TimKiemMuonTra Instance
        {
            get { if (instance == null) instance = new TimKiemMuonTra(); return TimKiemMuonTra.instance; }
            private set { TimKiemMuonTra.instance = value; }
        }
        private TimKiemMuonTra() { }
        public DataTable TkMTTheoTatCa(string maTK)
        {
            string query = "SELECT TenNguoiDoc, CuonSach.MaCuonSach, NgayMuon, NgayTra FROM dbo.PhieuMuon, dbo.NguoiDoc, dbo.CuonSach WHERE dbo.PhieuMuon.MaNguoiDoc=dbo.NguoiDoc.MaNguoiDoc AND dbo.PhieuMuon.MaCuonSach=dbo.CuonSach.MaCuonSach AND dbo.fuConvertToUnsign1(TenNguoiDoc) LIKE N'%'+dbo.fuConvertToUnsign1(N'" + maTK + "')+N'%' OR dbo.fuConvertToUnsign1(CuonSach.MaCuonSach) LIKE N'%'+dbo.fuConvertToUnsign1(N'" + maTK + "')+N'%' OR dbo.fuConvertToUnsign1(NgayMuon) LIKE N'%'+dbo.fuConvertToUnsign1(N'" + maTK + "')+N'%' OR dbo.fuConvertToUnsign1(NgayTra) LIKE N'%'+dbo.fuConvertToUnsign1(N'" + maTK + "')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public bool CheckTkMTTheoTatCa(string maTK)
        {
            string query = "SELECT TenNguoiDoc, CuonSach.MaCuonSach, NgayMuon, NgayTra FROM dbo.PhieuMuon, dbo.NguoiDoc, dbo.CuonSach WHERE dbo.PhieuMuon.MaNguoiDoc=dbo.NguoiDoc.MaNguoiDoc AND dbo.PhieuMuon.MaCuonSach=dbo.CuonSach.MaCuonSach AND dbo.fuConvertToUnsign1(TenNguoiDoc) LIKE N'%'+dbo.fuConvertToUnsign1(N'" + maTK + "')+N'%' OR dbo.fuConvertToUnsign1(CuonSach.MaCuonSach) LIKE N'%'+dbo.fuConvertToUnsign1(N'" + maTK + "')+N'%' OR dbo.fuConvertToUnsign1(NgayMuon) LIKE N'%'+dbo.fuConvertToUnsign1(N'" + maTK + "')+N'%' OR dbo.fuConvertToUnsign1(NgayTra) LIKE N'%'+dbo.fuConvertToUnsign1(N'" + maTK + "')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data.Rows.Count > 0;
        }

        public DataTable TkMTTheoTenNM(string maTK)
        {
            string query = "SELECT TenNguoiDoc, CuonSach.MaCuonSach, NgayMuon, NgayTra FROM dbo.PhieuMuon, dbo.NguoiDoc, dbo.CuonSach WHERE dbo.PhieuMuon.MaNguoiDoc=dbo.NguoiDoc.MaNguoiDoc AND dbo.PhieuMuon.MaCuonSach=dbo.CuonSach.MaCuonSach AND dbo.fuConvertToUnsign1(TenNguoiDoc) LIKE N'%'+dbo.fuConvertToUnsign1(N'"+maTK+"')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public bool CheckTkMTTheoTenNM(string maTK)
        {
            string query = "SELECT TenNguoiDoc, CuonSach.MaCuonSach, NgayMuon, NgayTra FROM dbo.PhieuMuon, dbo.NguoiDoc, dbo.CuonSach WHERE dbo.PhieuMuon.MaNguoiDoc=dbo.NguoiDoc.MaNguoiDoc AND dbo.PhieuMuon.MaCuonSach=dbo.CuonSach.MaCuonSach AND dbo.fuConvertToUnsign1(TenNguoiDoc) LIKE N'%'+dbo.fuConvertToUnsign1(N'" + maTK + "')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data.Rows.Count > 0;
        }

        public DataTable TkMTTheoMaCS(string maTK)
        {
            string query = "SELECT TenNguoiDoc, CuonSach.MaCuonSach, NgayMuon, NgayTra FROM dbo.PhieuMuon, dbo.NguoiDoc, dbo.CuonSach WHERE dbo.PhieuMuon.MaNguoiDoc=dbo.NguoiDoc.MaNguoiDoc AND dbo.PhieuMuon.MaCuonSach=dbo.CuonSach.MaCuonSach AND dbo.fuConvertToUnsign1(CuonSach.MaCuonSach) LIKE N'%'+dbo.fuConvertToUnsign1(N'"+maTK+"')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public bool CheckTkMTTheoMaCS(string maTK)
        {
            string query = "SELECT TenNguoiDoc, CuonSach.MaCuonSach, NgayMuon, NgayTra FROM dbo.PhieuMuon, dbo.NguoiDoc, dbo.CuonSach WHERE dbo.PhieuMuon.MaNguoiDoc=dbo.NguoiDoc.MaNguoiDoc AND dbo.PhieuMuon.MaCuonSach=dbo.CuonSach.MaCuonSach AND dbo.fuConvertToUnsign1(CuonSach.MaCuonSach) LIKE N'%'+dbo.fuConvertToUnsign1(N'" + maTK + "')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data.Rows.Count > 0;
        }

        public DataTable TkMTTheoNgayMuon(string maTK)
        {
            string query = "SELECT TenNguoiDoc, CuonSach.MaCuonSach, NgayMuon, NgayTra FROM dbo.PhieuMuon, dbo.NguoiDoc, dbo.CuonSach WHERE dbo.PhieuMuon.MaNguoiDoc=dbo.NguoiDoc.MaNguoiDoc AND dbo.PhieuMuon.MaCuonSach=dbo.CuonSach.MaCuonSach AND dbo.fuConvertToUnsign1(NgayMuon) LIKE N'%'+dbo.fuConvertToUnsign1(N'"+maTK+"')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public bool CheckTkMTTheoNgayMuon(string maTK)
        {
            string query = "SELECT TenNguoiDoc, CuonSach.MaCuonSach, NgayMuon, NgayTra FROM dbo.PhieuMuon, dbo.NguoiDoc, dbo.CuonSach WHERE dbo.PhieuMuon.MaNguoiDoc=dbo.NguoiDoc.MaNguoiDoc AND dbo.PhieuMuon.MaCuonSach=dbo.CuonSach.MaCuonSach AND dbo.fuConvertToUnsign1(NgayMuon) LIKE N'%'+dbo.fuConvertToUnsign1(N'" + maTK + "')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data.Rows.Count > 0;
        }

        public DataTable TkMTTheoNgayTra(string maTK)
        {
            string query = "SELECT TenNguoiDoc, CuonSach.MaCuonSach, NgayMuon, NgayTra FROM dbo.PhieuMuon, dbo.NguoiDoc, dbo.CuonSach WHERE dbo.PhieuMuon.MaNguoiDoc=dbo.NguoiDoc.MaNguoiDoc AND dbo.PhieuMuon.MaCuonSach=dbo.CuonSach.MaCuonSach AND dbo.fuConvertToUnsign1(NgayTra) LIKE N'%'+dbo.fuConvertToUnsign1(N'" + maTK + "')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public bool CheckTkMTTheoNgayTra(string maTK)
        {
            string query = "SELECT TenNguoiDoc, CuonSach.MaCuonSach, NgayMuon, NgayTra FROM dbo.PhieuMuon, dbo.NguoiDoc, dbo.CuonSach WHERE dbo.PhieuMuon.MaNguoiDoc=dbo.NguoiDoc.MaNguoiDoc AND dbo.PhieuMuon.MaCuonSach=dbo.CuonSach.MaCuonSach AND dbo.fuConvertToUnsign1(NgayTra) LIKE N'%'+dbo.fuConvertToUnsign1(N'" + maTK + "')+N'%'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data.Rows.Count > 0;
        }

    }
}
