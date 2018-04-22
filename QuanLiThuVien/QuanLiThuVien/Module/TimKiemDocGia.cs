using QuanLiThuVien.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiThuVien.Module
{
    public class TimKiemDocGia
    {
        private static TimKiemDocGia instance;

        public static TimKiemDocGia Instance
        {
            get { if (instance == null) instance = new TimKiemDocGia(); return TimKiemDocGia.instance; }
            private set { TimKiemDocGia.instance = value; }
        }

        private TimKiemDocGia() { }

        public DataTable TkTatCa(string text)
        {
            string query = "SELECT* FROM dbo.NguoiDoc WHERE dbo.fuConvertToUnsign1(TenNguoiDoc) LIKE N'%'+dbo.fuConvertToUnsign1(N'" + text + "')+N'%' OR dbo.fuConvertToUnsign1(MaNguoiDoc) LIKE N'%'+dbo.fuConvertToUnsign1(N'" + text + "')+N'%' OR dbo.fuConvertToUnsign1(DiaChi) LIKE N'%'+dbo.fuConvertToUnsign1(N'" + text + "')+N'%'OR dbo.fuConvertToUnsign1(SDT) LIKE N'%'+dbo.fuConvertToUnsign1(N'" + text + "')+N'%'";
            DataTable data = new DataTable();
            data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public bool CheckTkTatCa(string text)
        {
            string query = "SELECT* FROM dbo.NguoiDoc WHERE dbo.fuConvertToUnsign1(TenNguoiDoc) LIKE N'%'+dbo.fuConvertToUnsign1(N'" + text + "')+N'%' OR dbo.fuConvertToUnsign1(MaNguoiDoc) LIKE N'%'+dbo.fuConvertToUnsign1(N'" + text + "')+N'%' OR dbo.fuConvertToUnsign1(DiaChi) LIKE N'%'+dbo.fuConvertToUnsign1(N'" + text + "')+N'%'OR dbo.fuConvertToUnsign1(SDT) LIKE N'%'+dbo.fuConvertToUnsign1(N'" + text + "')+N'%'";
            DataTable data = new DataTable();
            data = DataProvider.Instance.ExcuteQuery(query);
            return data.Rows.Count > 0;
        }
        
        public DataTable TkMaND(string text)
        {
            string query = "SELECT* FROM dbo.NguoiDoc WHERE dbo.fuConvertToUnsign1(MaNguoiDoc) LIKE N'%'+dbo.fuConvertToUnsign1(N'" + text + "')+N'%'";
            DataTable data = new DataTable();
            data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public bool CheckTkMaND(string text)
        {
            string query = "SELECT* FROM dbo.NguoiDoc WHERE dbo.fuConvertToUnsign1(MaNguoiDoc) LIKE N'%'+dbo.fuConvertToUnsign1(N'" + text + "')+N'%'";
            DataTable data = new DataTable();
            data = DataProvider.Instance.ExcuteQuery(query);
            return data.Rows.Count > 0;
        }
        

        public DataTable TkTenND(string text)
        {
            string query = "SELECT* FROM dbo.NguoiDoc WHERE dbo.fuConvertToUnsign1(TenNguoiDoc) LIKE N'%'+dbo.fuConvertToUnsign1(N'" + text + "')+N'%'";
            DataTable data = new DataTable();
            data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public bool CheckTkTenND(string text)
        {
            string query = "SELECT* FROM dbo.NguoiDoc WHERE dbo.fuConvertToUnsign1(TenNguoiDoc) LIKE N'%'+dbo.fuConvertToUnsign1(N'" + text + "')+N'%'";
            DataTable data = new DataTable();
            data = DataProvider.Instance.ExcuteQuery(query);
            return data.Rows.Count > 0;
        }


        public DataTable TkDiaChi(string text)
        {
            string query = "SELECT* FROM dbo.NguoiDoc WHERE dbo.fuConvertToUnsign1(DiaChi) LIKE N'%'+dbo.fuConvertToUnsign1(N'" + text + "')+N'%'";
            DataTable data = new DataTable();
            data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public bool CheckTkDiaChi(string text)
        {
            string query = "SELECT* FROM dbo.NguoiDoc WHERE dbo.fuConvertToUnsign1(DiaChi) LIKE N'%'+dbo.fuConvertToUnsign1(N'" + text + "')+N'%'";
            DataTable data = new DataTable();
            data = DataProvider.Instance.ExcuteQuery(query);
            return data.Rows.Count > 0;
        }


        public DataTable TkSDT(string text)
        {
            string query = "SELECT* FROM dbo.NguoiDoc WHERE dbo.fuConvertToUnsign1(SDT) LIKE N'%'+dbo.fuConvertToUnsign1(N'" + text + "')+N'%'";
            DataTable data = new DataTable();
            data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public bool CheckTkSDT(string text)
        {
            string query = "SELECT* FROM dbo.NguoiDoc WHERE dbo.fuConvertToUnsign1(SDT) LIKE N'%'+dbo.fuConvertToUnsign1(N'" + text + "')+N'%'";
            DataTable data = new DataTable();
            data = DataProvider.Instance.ExcuteQuery(query);
            return data.Rows.Count > 0;
        }
    }
}
