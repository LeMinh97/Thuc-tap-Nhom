using QuanLiKho.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiKho.DAO
{
    public class CbTenNCCDAO
    {
        private static CbTenNCCDAO instance;

        public static CbTenNCCDAO Instance
        {
            get { if (instance == null) instance = new CbTenNCCDAO(); return CbTenNCCDAO.instance; }
            private set { CbTenNCCDAO.instance = value; }
        }
        private CbTenNCCDAO() { }
        public List<CbTenNCC> LayDSTenNCC()
        {
            List<CbTenNCC> list = new List<CbTenNCC>();
            string query = "SELECT* FROM dbo.NhaCungCap";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                CbTenNCC dsTenNCC = new CbTenNCC(item);
                list.Add(dsTenNCC);
            }
            return list;
        }
    }
}
