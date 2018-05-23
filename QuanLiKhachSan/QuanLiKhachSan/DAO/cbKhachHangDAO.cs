using QuanLiKhachSan.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiKhachSan.DAO
{
    public class cbKhachHangDAO
    {
        private static cbKhachHangDAO instance;

        public static cbKhachHangDAO Instance
        {
            get { if (instance == null) instance = new cbKhachHangDAO(); return cbKhachHangDAO.instance; }
            private set { cbKhachHangDAO.instance = value; }
        }
        private cbKhachHangDAO() { }
        public List<cbKhachHang> LayDSKhachHang()
        {
            List<cbKhachHang> list = new List<cbKhachHang>();
            string query = "SELECT * FROM dbo.KhachHang";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                cbKhachHang dsKhachHang = new cbKhachHang(item);
                list.Add(dsKhachHang);
            }
            return list;
        }
    }
}
