using QuanLiKhachSan.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiKhachSan.DAO
{
    public class cbDoDungDAO
    {
        private static cbDoDungDAO instance;

        public static cbDoDungDAO Instance
        {
            get { if (instance == null) instance = new cbDoDungDAO(); return cbDoDungDAO.instance; }
            private set { cbDoDungDAO.instance = value; }
        }
        private cbDoDungDAO() { }
        public List<cbDoDung> LayDSTenDoDung()
        {
            List<cbDoDung> list = new List<cbDoDung>();
            string query = "SELECT MaDoDung,TenDoDung FROM dbo.DoDung";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                cbDoDung dsDoDung = new cbDoDung(item);
                list.Add(dsDoDung);
            }
            return list;
        }
    }
}
