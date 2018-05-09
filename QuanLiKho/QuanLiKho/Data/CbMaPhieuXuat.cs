using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiKho.Data
{
    public class CbMaPhieuXuat
    {
        public CbMaPhieuXuat(string maPhieuXuat, DateTime ngayXuat, string maKhachHang)
        {
            this.MaPhieuXuat = maPhieuXuat;
            this.MaKhachHang = maKhachHang;
            this.NgayXuat = ngayXuat;
        }
        public CbMaPhieuXuat(DataRow row)
        {
            this.MaPhieuXuat = row["MaPhieuXuat"].ToString();
            this.MaKhachHang = row["MaKH"].ToString();
            this.NgayXuat = (DateTime)row["NgayXuat"];
        }
        private string maPhieuXuat;

        public string MaPhieuXuat
        {
            get { return maPhieuXuat; }
            set { maPhieuXuat = value; }
        }

        private DateTime ngayXuat;

        public DateTime NgayXuat
        {
            get { return ngayXuat; }
            set { ngayXuat = value; }
        }
        private string maKhachHang;

        public string MaKhachHang
        {
            get { return maKhachHang; }
            set { maKhachHang = value; }
        }
    }
}
