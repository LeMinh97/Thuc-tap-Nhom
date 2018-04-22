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
    public partial class fr_TaiKhoan : Form
    {
        private TaiKhoan tkDangNhap;

        public TaiKhoan TkDangNhap
        {
            get { return tkDangNhap; }
            set { tkDangNhap = value; }
        }
        public fr_TaiKhoan(TaiKhoan TKDN)
        {
            InitializeComponent();
            this.TkDangNhap = TKDN;
            LoadDSTaiKhoan();
            RefreshText();
        }
        void LoadDSTaiKhoan()
        {
            string query = "SELECT TenDN,TenND,MatKhau,LoaiTK FROM dbo.NguoiDung,dbo.LoaiTK WHERE NguoiDung.MaLoaiTK=LoaiTK.MaLoaiTK";
            dgvTaiKhoan.DataSource = DataProvider.Instance.ExcuteQuery(query);
        }
        void RefreshText()
        {
            txtTenDN.Text = "";
            txtTenND.Text = "";
            txtMatKhau.Text = "";
            cbLoaiTK.Text = "";
            txtTimKiemTK.Text = "";
            cbTimKiemTK.Text = "";
        }
        private void btnThemTK_Click(object sender, EventArgs e)
        {

        }

        private void btnSuaTK_Click(object sender, EventArgs e)
        {

        }

        private void btnXoaTK_Click(object sender, EventArgs e)
        {

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {

        }

        private void btnVeMenu_Click(object sender, EventArgs e)
        {
            fr_Main f = new fr_Main(TkDangNhap);
            this.Hide();
            f.Show();
        }

        private void btnThoatND_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát", "Thông Báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnTimKiemTK_Click(object sender, EventArgs e)
        {

        }

        private void dgvTaiKhoan_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvTaiKhoan.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                txtTenDN.Text = Convert.ToString(dgvTaiKhoan.CurrentRow.Cells["tenDN"].Value);
                txtTenND.Text = Convert.ToString(dgvTaiKhoan.CurrentRow.Cells["TenND"].Value);
                txtMatKhau.Text = Convert.ToString(dgvTaiKhoan.CurrentRow.Cells["matKhau"].Value);
                cbLoaiTK.Text = Convert.ToString(dgvTaiKhoan.CurrentRow.Cells["loaiTK"].Value);
            }
        }
    }
}
