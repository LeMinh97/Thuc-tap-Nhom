using QuanLiKho.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiKho.DAO
{
    public class CbMaPhieuXuatDAO
    {
        private static CbMaPhieuXuatDAO instance;

        public static CbMaPhieuXuatDAO Instance
        {
            get { if (instance == null) instance = new CbMaPhieuXuatDAO(); return CbMaPhieuXuatDAO.instance; }
            private set { CbMaPhieuXuatDAO.instance = value; }
        }
        private CbMaPhieuXuatDAO() { }
        public List<CbMaPhieuXuat> LayDSMaPhieuXuat()
        {
            List<CbMaPhieuXuat> list = new List<CbMaPhieuXuat>();
            string query = "SELECT * FROM dbo.PhieuXuat";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                CbMaPhieuXuat dsMaPhieuXuat = new CbMaPhieuXuat(item);
                list.Add(dsMaPhieuXuat);
            }
            return list;
        }
    }
}
