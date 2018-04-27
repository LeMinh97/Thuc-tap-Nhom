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

    }
}
