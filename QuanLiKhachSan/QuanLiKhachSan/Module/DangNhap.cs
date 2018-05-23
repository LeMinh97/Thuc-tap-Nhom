using QuanLiKhachSan.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiKhachSan.Module
{
    public class DangNhap
    {
        private static DangNhap instance;

        public static DangNhap Instance
        {
            get { if (instance == null) instance = new DangNhap(); return instance; }
            private set { instance = value; }
        }

        private DangNhap() { }

        public bool KtDangNhap(string username, string password)
        {
            string query = "SELECT* FROM dbo.TaiKhoan WHERE TenDN=N'" + username + "' AND MatKhau=N'" + password + "'";
            DataTable result = DataProvider.Instance.ExcuteQuery(query);
            return result.Rows.Count > 0;
        }

    }
}
