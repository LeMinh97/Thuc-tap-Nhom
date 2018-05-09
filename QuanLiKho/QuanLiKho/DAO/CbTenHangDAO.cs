using QuanLiKho.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiKho.DAO
{
    public class CbTenHangDAO
    {
        private static CbTenHangDAO instance;

        public static CbTenHangDAO Instance
        {
            get { if (instance == null) instance = new CbTenHangDAO(); return CbTenHangDAO.instance; }
            private set { CbTenHangDAO.instance = value; }
        }
        private CbTenHangDAO() { }
        public List<CbTenHang> LayDSTenHang()
        {
            List<CbTenHang> list = new List<CbTenHang>();
            string query = "SELECT * FROM dbo.HangHoa";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                CbTenHang dsTenHang = new CbTenHang(item);
                list.Add(dsTenHang);
            }
            return list;
        }
    }
}
