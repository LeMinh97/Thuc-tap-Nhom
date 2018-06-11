using QuanLiKhachSan.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiKhachSan.DAO
{
    public class cbPhongDAO
    {
        private static cbPhongDAO instance;

        public static cbPhongDAO Instance
        {
            get { if (instance == null) instance = new cbPhongDAO(); return cbPhongDAO.instance; }
            private set { cbPhongDAO.instance = value; }
        }
        private cbPhongDAO() { }
        public List<cbPhong> LayDSPhong()
        {
            List<cbPhong> list = new List<cbPhong>();
            string query = "SELECT * FROM dbo.Phong";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                cbPhong dsPhong = new cbPhong(item);
                list.Add(dsPhong);
            }
            return list;
        }
        public List<cbPhong> LayDSPhongTrong()
        {
            List<cbPhong> list = new List<cbPhong>();
            string query = "SELECT * FROM dbo.Phong WHERE TinhTrang=N'Chưa'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                cbPhong dsPhong = new cbPhong(item);
                list.Add(dsPhong);
            }
            return list;
        }

        public List<cbPhong> LayDSPhongDat()
        {
            List<cbPhong> list = new List<cbPhong>();
            string query = "SELECT * FROM dbo.Phong WHERE TinhTrang=N'OK'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                cbPhong dsPhong = new cbPhong(item);
                list.Add(dsPhong);
            }
            return list;
        }
    }
}
