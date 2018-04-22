using QuanLiThuVien.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiThuVien.DAO
{
    public class DSNhanhDAO
    {
        private static DSNhanhDAO instance;

        public static DSNhanhDAO Instance
        {
            get { if (instance == null) instance = new DSNhanhDAO(); return DSNhanhDAO.instance; }
            private set { DSNhanhDAO.instance = value; }
        }
        private DSNhanhDAO() { }
        public List<DSNhanh> LayDSNhanh()
        {
            List<DSNhanh> list = new List<DSNhanh>();
            string query = "SELECT * FROM dbo.Nhanh";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                DSNhanh dsNhanh = new DSNhanh(item);
                list.Add(dsNhanh);
            }
            return list;
        }
    }
}
