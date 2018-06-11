using QuanLiKho.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiKho.Views
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
        private void fr_Main_Load(object sender, EventArgs e)
        {

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

        private void hangHoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr_HangHoa f = new fr_HangHoa(TkDangNhap);
            this.Hide();
            f.Show();
        }

        private void nhapHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr_NhapHang f = new fr_NhapHang(TkDangNhap);
            this.Hide();
            f.Show();
        }

        private void xuatHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr_XuatHang f = new fr_XuatHang(TkDangNhap);
            this.Hide();
            f.Show();
        }

        private void thongKeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr_ThongKe f = new fr_ThongKe(TkDangNhap);
            this.Hide();
            f.Show();
        }

        private void hướngDẫnToolStripMenuItem_Click(object sender, EventArgs e)
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
