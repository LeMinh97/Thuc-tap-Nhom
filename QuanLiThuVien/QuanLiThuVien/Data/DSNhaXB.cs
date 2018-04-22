using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiThuVien.Data
{
    public class DSNhaXB
    {
        public DSNhaXB(string maNXB, string tenNXB, string diaChi, string sdt)
        {
            this.MaNXB = maNXB;
            this.TenNXB = tenNXB;
            this.DiaChi = diaChi;
            this.Sdt = sdt;
        }

        public DSNhaXB(DataRow row)
        {
            this.MaNXB = row["MaNXB"].ToString();
            this.TenNXB = row["TenNXB"].ToString();
            this.DiaChi = row["DiaChi"].ToString();
            this.Sdt = row["SDT"].ToString();
        }
        private string maNXB;

        public string MaNXB
        {
            get { return maNXB; }
            set { maNXB = value; }
        }

        private string tenNXB;

        public string TenNXB
        {
            get { return tenNXB; }
            set { tenNXB = value; }
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
