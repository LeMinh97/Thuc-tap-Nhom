using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT6
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBanHang hoadon = new FormBanHang();
            hoadon.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKH kh = new FormKH();
            kh.Show();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhanVien nv = new frmNhanVien();
            nv.Show();
        }

        private void tìmHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimHang tim = new TimHang();
            tim.Show();
        }

        private void nhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNhapHang nhap = new FormNhapHang();
            nhap.Show();
        }
    }
}
