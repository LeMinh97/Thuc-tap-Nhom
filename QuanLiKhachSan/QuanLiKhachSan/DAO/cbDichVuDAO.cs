using QuanLiKhachSan.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiKhachSan.DAO
{
    public class cbDichVuDAO
    {
        private static cbDichVuDAO instance;

        public static cbDichVuDAO Instance
        {
            get { if (instance == null) instance = new cbDichVuDAO(); return cbDichVuDAO.instance; }
            private set { cbDichVuDAO.instance = value; }
        }
        private cbDichVuDAO() { }

        public List<cbDichVu> LayDSTenDichVu()
        {
            List<cbDichVu> list = new List<cbDichVu>();
            string query = "SELECT MaDichVu,TenDichVu FROM dbo.DichVu";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                cbDichVu dsDichVu = new cbDichVu(item);
                list.Add(dsDichVu);
            }
            return list;
        }
    }
}
