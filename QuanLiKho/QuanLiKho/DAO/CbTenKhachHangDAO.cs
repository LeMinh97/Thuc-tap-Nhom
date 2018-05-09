using QuanLiKho.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiKho.DAO
{
    public class CbTenKhachHangDAO
    {
        private static CbTenKhachHangDAO instance;

        public static CbTenKhachHangDAO Instance
        {
            get { if (instance == null) instance = new CbTenKhachHangDAO(); return CbTenKhachHangDAO.instance; }
            private set { CbTenKhachHangDAO.instance = value; }
        }
        private CbTenKhachHangDAO() { }

        public List<CbTenKhachHang> LayDSTenKhachHang()
        {
            List<CbTenKhachHang> list = new List<CbTenKhachHang>();
            string query = "SELECT * FROM dbo.KhachHang";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                CbTenKhachHang dsTenKH = new CbTenKhachHang(item);
                list.Add(dsTenKH);
            }
            return list;
        }
    }
}
