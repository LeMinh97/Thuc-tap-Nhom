using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiThuVien.Data
{
    public class MTCuonSach
    {
        public MTCuonSach(string maCS, string namXB, string tinhTrang, string maDS)
        {
            this.MaCuonSach=maCS;
            this.NamXB = namXB;
            this.TinhTrang = tinhTrang;
            this.MaDauSach = maDS;
        }

        public MTCuonSach(DataRow row)
        {
            this.MaCuonSach = row["MaCuonSach"].ToString();
            this.NamXB = row["NamXB"].ToString();
            this.TinhTrang = row["TinhTrang"].ToString();
            this.MaDauSach = row["MaDauSach"].ToString();
        }
        private string maCuonSach;

        public string MaCuonSach
        {
            get { return maCuonSach; }
            set { maCuonSach = value; }
        }
        private string namXB;

        public string NamXB
        {
            get { return namXB; }
            set { namXB = value; }
        }
        private string tinhTrang;

        public string TinhTrang
        {
            get { return tinhTrang; }
            set { tinhTrang = value; }
        }
        private string maDauSach;

        public string MaDauSach
        {
            get { return maDauSach; }
            set { maDauSach = value; }
        }

    }
}
