using QuanLiThuVien.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiThuVien.DAO
{
    public class DSNhaXBDAO
    {
        private static DSNhaXBDAO instance;

        public static DSNhaXBDAO Instance
        {
            get { if (instance == null) instance = new DSNhaXBDAO(); return DSNhaXBDAO.instance; }
            private set { DSNhaXBDAO.instance = value; }
        }
        private DSNhaXBDAO() { }
        public List<DSNhaXB> LayDSNhaXB()
        {
            List<DSNhaXB> list = new List<DSNhaXB>();
            string query = "SELECT * FROM dbo.NhaXB";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                DSNhaXB dsNXB = new DSNhaXB(item);
                list.Add(dsNXB);
            }
            return list;
        }
        
    }
}
