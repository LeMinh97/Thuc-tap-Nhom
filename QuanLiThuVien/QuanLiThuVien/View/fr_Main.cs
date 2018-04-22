using QuanLiThuVien.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiThuVien.View
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
            HienTenNguoiDung();
        }
      
        private void HienTenNguoiDung()
        {
            lbTenNguoiDung.Text = lbTenNguoiDung.Text + TkDangNhap.LoaiTK + ": " + TkDangNhap.TenND;
        }

        private void độcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr_NguoiDoc f = new fr_NguoiDoc(TkDangNhap);
            this.Hide();
            f.Show();
        }

        private void đầuSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr_DauSach f = new fr_DauSach(TkDangNhap);
            this.Hide();
            f.Show();
        }

        private void mượnTrảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr_MuonTra f = new fr_MuonTra(TkDangNhap);
            this.Hide();
            f.Show();
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
