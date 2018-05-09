using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiKho.Data
{
    public class CbTenKhachHang
    {
        public CbTenKhachHang(string maKH,string tenKH,string gioiTinh,string diaChi,string sdt)
        {
            this.MaKH = maKH;
            this.TenKhachHang = tenKH;
            this.GioiTinh = gioiTinh;
            this.DiaChi = diaChi;
            this.Sdt = sdt;
        }

        public CbTenKhachHang(DataRow row)
        {
            this.MaKH = row["MaKH"].ToString();
            this.TenKhachHang = row["TenKH"].ToString();
            this.GioiTinh = row["GioiTinh"].ToString();
            this.DiaChi = row["DiaChi"].ToString();
            this.Sdt = row["SDT"].ToString();
        }
        private string maKH;

        public string MaKH
        {
            get { return maKH; }
            set { maKH = value; }
        }
        private string tenKhachHang;

        public string TenKhachHang
        {
            get { return tenKhachHang; }
            set { tenKhachHang = value; }
        }

        private string gioiTinh;

        public string GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }

        private string diaChi;

        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }
        private string sdt;

        public string Sdt
        {
            get { return sdt; }
            set { sdt = value; }
        }
    }
}
