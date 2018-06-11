using QuanLiKhachSan.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiKhachSan.Views
{
    public partial class fr_Main : Form
    {
        private TaiKhoan tkDangNhap;

        public TaiKhoan TkDangNhap
        {
            get { return tkDangNhap; }
            set { tkDangNhap = value; }
        }
        public fr_Main(TaiKhoan TKDN)
        {
            InitializeComponent();
            this.TkDangNhap = TKDN;
            HienTenTaiKhoan();
        }

        private void HienTenTaiKhoan()
        {
            lbHienTenTaiKhoan.Text = lbHienTenTaiKhoan.Text + TkDangNhap.LoaiTK + ": " + TkDangNhap.TenND;
        }

        private void TaiKhoanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TkDangNhap.LoaiTK.ToString() == "Quản lí")
            {
                fr_TaiKhoan f = new fr_TaiKhoan(TkDangNhap);
                this.Hide();
                f.Show();
            }
            else MessageBox.Show("Mục này chỉ dành cho Quản lí", "Thông báo");
        }

        private void DangNhapLaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr_DangNhap f = new fr_DangNhap();
            this.Hide();
            f.Show();
        }

        private void ThoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát", "Thông Báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void ThuePhongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr_ThuePhong f = new fr_ThuePhong(TkDangNhap);
            this.Hide();
            f.Show();
        }

        private void TraPhongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr_TraPhong f = new fr_TraPhong(TkDangNhap);
            this.Hide();
            f.Show();
        }

        private void SdDichVuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr_SDDichVu f = new fr_SDDichVu(TkDangNhap);
            this.Hide();
            f.Show();
        }

        private void phòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr_Phong f = new fr_Phong(TkDangNhap);
            this.Hide();
            f.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr_KhachHang f = new fr_KhachHang(TkDangNhap);
            this.Hide();
            f.Show();
        }

        private void vậtDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr_VatDung f = new fr_VatDung(TkDangNhap);
            this.Hide();
            f.Show();
        }

        private void HuongDanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr_HuongDan f = new fr_HuongDan(TkDangNhap);
            f.Show();
        }

        private void trợGiúpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr_TroGiup f = new fr_TroGiup(TkDangNhap);
            f.Show();
        }
    }
}
