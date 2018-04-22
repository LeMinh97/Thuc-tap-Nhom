using QuanLiThuVien.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiThuVien.Module
{
    public class TimKiemDauSach
    {
        private static TimKiemDauSach instance;
        public static TimKiemDauSach Instance
        {
            get { if (instance == null) instance = new TimKiemDauSach(); return TimKiemDauSach.instance; }
            private set { TimKiemDauSach.instance = value; }
        }
        private TimKiemDauSach() { }
        public DataTable TkDSTheoTatCa(string maTK)
        {
            string query = "SELECT MaDauSach,TenDauSach,TheLoai,TenNXB,TenNhanh FROM dbo.DauSach,dbo.Nhanh,dbo.NhaXB WHERE dbo.fuConvertToUnsign1(MaDauSach) LIKE N'%'+dbo.fuConvertToUnsign1(N'" + maTK + "')+N'%' OR dbo.fuConvertToUnsign1(TenDauSach) LIKE N'%'+dbo.fuConvertToUnsign1(N'" + maTK + "')+N'%' OR dbo.fuConvertToUnsign1(TheLoai) LIKE N'%'+dbo.fuConvertToUnsign1(N'" + maTK + "')+N'%' OR dbo.fuConvertToUnsign1(TenNXB) LIKE N'%'+dbo.fuConvertToUnsign1(N'" + maTK + "')+N'%' OR dbo.fuConvertToUnsign1(TenNhanh) LIKE N'%'+dbo.fuConvertToUnsign1(N'" + maTK + "')+N'%' AND dbo.DauSach.MaNhanh=dbo.Nhanh.MaNhanh AND dbo.DauSach.MaNhaXB=dbo.NhaXB.MaNXB ";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public bool CheckTkDSTheoTatCa(string maTK)
        {
            string query = "SELECT MaDauSach,TenDauSach,TheLoai,TenNXB,TenNhanh FROM dbo.DauSach,dbo.Nhanh,dbo.NhaXB WHERE dbo.fuConvertToUnsign1(MaDauSach) LIKE N'%'+dbo.fuConvertToUnsign1(N'" + maTK + "')+N'%' OR dbo.fuConvertToUnsign1(TenDauSach) LIKE N'%'+dbo.fuConvertToUnsign1(N'" + maTK + "')+N'%' OR dbo.fuConvertToUnsign1(TheLoai) LIKE N'%'+dbo.fuConvertToUnsign1(N'" + maTK + "')+N'%' OR dbo.fuConvertToUnsign1(TenNXB) LIKE N'%'+dbo.fuConvertToUnsign1(N'" + maTK + "')+N'%' OR dbo.fuConvertToUnsign1(TenNhanh) LIKE N'%'+dbo.fuConvertToUnsign1(N'" + maTK + "')+N'%' AND dbo.DauSach.MaNhanh=dbo.Nhanh.MaNhanh AND dbo.DauSach.MaNhaXB=dbo.NhaXB.MaNXB ";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data.Rows.Count > 0;
        }

        public DataTable TkDSTheoMaDS(string maTK)
        {
            string query = "SELECT MaDauSach,TenDauSach,TheLoai,TenNXB,TenNhanh FROM dbo.DauSach,dbo.Nhanh,dbo.NhaXB WHERE dbo.fuConvertToUnsign1(MaDauSach) LIKE N'%'+dbo.fuConvertToUnsign1(N'"+maTK+"')+N'%' AND dbo.DauSach.MaNhanh=dbo.Nhanh.MaNhanh AND dbo.DauSach.MaNhaXB=dbo.NhaXB.MaNXB";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public bool CheckTkDSTheoMaDS(string maTK)
        {
            string query = "SELECT MaDauSach,TenDauSach,TheLoai,TenNXB,TenNhanh FROM dbo.DauSach,dbo.Nhanh,dbo.NhaXB WHERE dbo.fuConvertToUnsign1(MaDauSach) LIKE N'%'+dbo.fuConvertToUnsign1(N'" + maTK + "')+N'%' AND dbo.DauSach.MaNhanh=dbo.Nhanh.MaNhanh AND dbo.DauSach.MaNhaXB=dbo.NhaXB.MaNXB";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data.Rows.Count > 0;
        }

        public DataTable TkDSTheoTenDS(string maTK)
        {
            string query = "SELECT MaDauSach,TenDauSach,TheLoai,TenNXB,TenNhanh FROM dbo.DauSach,dbo.Nhanh,dbo.NhaXB WHERE dbo.fuConvertToUnsign1(TenDauSach) LIKE N'%'+dbo.fuConvertToUnsign1(N'"+maTK+"')+N'%' AND dbo.DauSach.MaNhanh=dbo.Nhanh.MaNhanh AND dbo.DauSach.MaNhaXB=dbo.NhaXB.MaNXB";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public bool CheckTkDSTheoTenDS(string maTK)
        {
            string query = "SELECT MaDauSach,TenDauSach,TheLoai,TenNXB,TenNhanh FROM dbo.DauSach,dbo.Nhanh,dbo.NhaXB WHERE dbo.fuConvertToUnsign1(TenDauSach) LIKE N'%'+dbo.fuConvertToUnsign1(N'" + maTK + "')+N'%' AND dbo.DauSach.MaNhanh=dbo.Nhanh.MaNhanh AND dbo.DauSach.MaNhaXB=dbo.NhaXB.MaNXB";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data.Rows.Count > 0;
        }

        public DataTable TkDSTheoTheLoai(string maTK)
        {
            string query = "SELECT MaDauSach,TenDauSach,TheLoai,TenNXB,TenNhanh FROM dbo.DauSach,dbo.Nhanh,dbo.NhaXB WHERE dbo.fuConvertToUnsign1(TheLoai) LIKE N'%'+dbo.fuConvertToUnsign1(N'"+maTK+"')+N'%' AND dbo.DauSach.MaNhanh=dbo.Nhanh.MaNhanh AND dbo.DauSach.MaNhaXB=dbo.NhaXB.MaNXB";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public bool CheckTkDSTheoTheLoai(string maTK)
        {
            string query = "SELECT MaDauSach,TenDauSach,TheLoai,TenNXB,TenNhanh FROM dbo.DauSach,dbo.Nhanh,dbo.NhaXB WHERE dbo.fuConvertToUnsign1(TheLoai) LIKE N'%'+dbo.fuConvertToUnsign1(N'" + maTK + "')+N'%' AND dbo.DauSach.MaNhanh=dbo.Nhanh.MaNhanh AND dbo.DauSach.MaNhaXB=dbo.NhaXB.MaNXB";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data.Rows.Count > 0;
        }

        public DataTable TkDSTheoNhaXB(string maTK)
        {
            string query = "SELECT MaDauSach,TenDauSach,TheLoai,TenNXB,TenNhanh FROM dbo.DauSach,dbo.Nhanh,dbo.NhaXB WHERE dbo.fuConvertToUnsign1(TenNXB) LIKE N'%'+dbo.fuConvertToUnsign1(N'"+maTK+"')+N'%' AND dbo.DauSach.MaNhanh=dbo.Nhanh.MaNhanh AND dbo.DauSach.MaNhaXB=dbo.NhaXB.MaNXB";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public bool CheckTkDSTheoNhaXB(string maTK)
        {
            string query = "SELECT MaDauSach,TenDauSach,TheLoai,TenNXB,TenNhanh FROM dbo.DauSach,dbo.Nhanh,dbo.NhaXB WHERE dbo.fuConvertToUnsign1(TenNXB) LIKE N'%'+dbo.fuConvertToUnsign1(N'" + maTK + "')+N'%' AND dbo.DauSach.MaNhanh=dbo.Nhanh.MaNhanh AND dbo.DauSach.MaNhaXB=dbo.NhaXB.MaNXB";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data.Rows.Count > 0;
        }

        public DataTable TkDSTheoNhanh(string maTK)
        {
            string query = "SELECT MaDauSach,TenDauSach,TheLoai,TenNXB,TenNhanh FROM dbo.DauSach,dbo.Nhanh,dbo.NhaXB WHERE dbo.fuConvertToUnsign1(TenNhanh) LIKE N'%'+dbo.fuConvertToUnsign1(N'"+maTK+"')+N'%' AND dbo.DauSach.MaNhanh=dbo.Nhanh.MaNhanh AND dbo.DauSach.MaNhaXB=dbo.NhaXB.MaNXB";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public bool CheckTkDSTheoNhanh(string maTK)
        {
            string query = "SELECT MaDauSach,TenDauSach,TheLoai,TenNXB,TenNhanh FROM dbo.DauSach,dbo.Nhanh,dbo.NhaXB WHERE dbo.fuConvertToUnsign1(TenNhanh) LIKE N'%'+dbo.fuConvertToUnsign1(N'" + maTK + "')+N'%' AND dbo.DauSach.MaNhanh=dbo.Nhanh.MaNhanh AND dbo.DauSach.MaNhaXB=dbo.NhaXB.MaNXB";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data.Rows.Count > 0;
        }
    }
}
