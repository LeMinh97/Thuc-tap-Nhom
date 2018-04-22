using QuanLiThuVien.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiThuVien.DAO
{
    public class MTCuonSachDAO
    {
        private static MTCuonSachDAO instance;

        public static MTCuonSachDAO Instance
        {
            get { if (instance == null) instance = new MTCuonSachDAO(); return MTCuonSachDAO.instance; }
            private set { MTCuonSachDAO.instance = value; }
        }
        private MTCuonSachDAO() { }

        public List<MTCuonSach> LayDSCuonSach()
        {
            List<MTCuonSach> list = new List<MTCuonSach>();
            string query = "SELECT * FROM dbo.CuonSach";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                MTCuonSach mtCS = new MTCuonSach(item);
                list.Add(mtCS);
            }
            return list;
        }
    }
}
