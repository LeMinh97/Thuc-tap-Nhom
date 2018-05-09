using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiKho.Data
{
    public class CbTenNCC
    {
        public CbTenNCC(string maNCC,string tenNCC,string diaChi,string sdt)
        {
            this.MaNCC = maNCC;
            this.TenNCC = tenNCC;
            this.DiaChi = diaChi;
            this.Sdt = sdt;
        }

        public CbTenNCC(DataRow row)
        {
            this.MaNCC = row["MaNCC"].ToString();
            this.TenNCC = row["TenNCC"].ToString();
            this.DiaChi = row["DiaChi"].ToString();
            this.Sdt = row["SDT"].ToString();
        }
        private string maNCC;

        public string MaNCC
        {
            get { return maNCC; }
            set { maNCC = value; }
        }
        private string tenNCC;

        public string TenNCC
        {
            get { return tenNCC; }
            set { tenNCC = value; }
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
