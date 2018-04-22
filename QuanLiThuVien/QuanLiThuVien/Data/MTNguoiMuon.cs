using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiThuVien.Data
{
    public class MTNguoiMuon
    {
        public MTNguoiMuon(string maNguoiMuon, string tenNguoiMuon, string diaChi, string sdt)
        {
            this.MaNguoiMuon = maNguoiMuon;
            this.TenNguoiMuon = tenNguoiMuon;
            this.DiaChi = diaChi;
            this.Sdt = sdt;
        }

        public MTNguoiMuon(DataRow row)
        {
            this.MaNguoiMuon = row["MaNguoiDoc"].ToString();
            this.TenNguoiMuon = row["TenNguoiDoc"].ToString();
            this.DiaChi = row["DiaChi"].ToString();
            this.Sdt = row["SDT"].ToString();
        }
        private string maNguoiMuon;

        public string MaNguoiMuon
        {
            get { return maNguoiMuon; }
            set { maNguoiMuon = value; }
        }
        private string tenNguoiMuon;

        public string TenNguoiMuon
        {
            get { return tenNguoiMuon; }
            set { tenNguoiMuon = value; }
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
