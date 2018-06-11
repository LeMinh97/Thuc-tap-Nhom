using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiKhachSan.Data
{
    public class cbDichVu
    {
        public cbDichVu(string maDichVu, string tenDichVu)
        {
            this.MaDichVu = maDichVu;
            this.TenDichVu = tenDichVu;
        }

        public cbDichVu(DataRow row)
        {
            this.MaDichVu = row["MaDichVu"].ToString();
            this.TenDichVu = row["TenDichVu"].ToString();
        }

        private string maDichVu;

        public string MaDichVu
        {
            get { return maDichVu; }
            set { maDichVu = value; }
        }

        private string tenDichVu;

        public string TenDichVu
        {
            get { return tenDichVu; }
            set { tenDichVu = value; }
        }
    }
}
