using QuanLiKho.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiKho.DAO
{
    public class CbMaPhieuNhapDAO
    {
        private static CbMaPhieuNhapDAO instance;

        public static CbMaPhieuNhapDAO Instance
        {
            get { if (instance == null) instance = new CbMaPhieuNhapDAO(); return CbMaPhieuNhapDAO.instance; }
            private set { CbMaPhieuNhapDAO.instance = value; }
        }
        private CbMaPhieuNhapDAO() { }
        public List<CbMaPhieuNhap> LayDSMaPhieuNhap()
        {
            List<CbMaPhieuNhap> list = new List<CbMaPhieuNhap>();
            string query = "SELECT* FROM dbo.PhieuNhap";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                CbMaPhieuNhap dsMaPN = new CbMaPhieuNhap(item);
                list.Add(dsMaPN);
            }
            return list;
        }
    }
}
