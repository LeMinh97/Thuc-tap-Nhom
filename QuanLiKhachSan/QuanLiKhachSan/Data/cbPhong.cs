using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiKhachSan.Data
{
    public class cbPhong
    {
        public cbPhong(string maPhong, string loaiPhong, string moTa, bool tinhTrang, int donGiaGio)
        {
            this.MaPhong = maPhong;
            this.LoaiPhong = loaiPhong;
            this.MoTa = moTa;
            this.TinhTrang = tinhTrang;
            this.DonGiaGio = donGiaGio;
        }

        public cbPhong(DataRow row)
        {
            this.MaPhong = row["MaPhong"].ToString();
            this.LoaiPhong = row["LoaiPhong"].ToString();
            this.MoTa = row["MoTa"].ToString();
            this.TinhTrang = (bool)row["TinhTrang"];
            this.DonGiaGio = (int)row["DonGiaGio"];
        }
        private string maPhong;

        public string MaPhong
        {
            get { return maPhong; }
            set { maPhong = value; }
        }
        private string loaiPhong;

        public string LoaiPhong
        {
            get { return loaiPhong; }
            set { loaiPhong = value; }
        }

        private string moTa;

        public string MoTa
        {
            get { return moTa; }
            set { moTa = value; }
        }

        private bool tinhTrang;

        public bool TinhTrang
        {
            get { return tinhTrang; }
            set { tinhTrang = value; }
        }

        private int donGiaGio;

        public int DonGiaGio
        {
            get { return donGiaGio; }
            set { donGiaGio = value; }
        }
    }
}
