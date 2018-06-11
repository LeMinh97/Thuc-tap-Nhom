using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiKhachSan.Data
{
    public class cbDoDung
    {
        public cbDoDung(string maDoDung, string tenDoDung)
        {
            this.MaDoDung = maDoDung;
            this.TenDoDung = tenDoDung;
        }

        public cbDoDung(DataRow row)
        {
            this.MaDoDung = row["MaDoDung"].ToString();
            this.TenDoDung = row["TenDoDung"].ToString();
        }

        private string maDoDung;

        public string MaDoDung
        {
            get { return maDoDung; }
            set { maDoDung = value; }
        }

        private string tenDoDung;

        public string TenDoDung
        {
            get { return tenDoDung; }
            set { tenDoDung = value; }
        }
    }
}
