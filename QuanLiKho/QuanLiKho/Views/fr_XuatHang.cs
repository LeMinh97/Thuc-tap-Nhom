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
    public partial class fr_XuatHang : Form
    {
        private TaiKhoan tkDangNhap;

        public TaiKhoan TkDangNhap
        {
            get { return tkDangNhap; }
            set { tkDangNhap = value; }
        }
        public fr_XuatHang(TaiKhoan TKDN)
        {
            InitializeComponent();
            this.TkDangNhap = TKDN;
            LoadDSXuatHang();
            RefreshText();
        }
        private void LoadDSXuatHang()
        {
            string query = "SELECT ChiTietPhieuXuat.MaPhieuXuat,NgayXuat,TenKH,TenHang,ChiTietPhieuXuat.SoLuong,DonGiaXuat FROM dbo.PhieuXuat,dbo.KhachHang,dbo.ChiTietPhieuXuat,dbo.HangHoa WHERE KhachHang.MaKH=PhieuXuat.MaKH AND ChiTietPhieuXuat.MaPhieuXuat=PhieuXuat.MaPhieuXuat AND ChiTietPhieuXuat.MaHang=HangHoa.MaHang";
            dgvXuatHang.DataSource = DataProvider.Instance.ExcuteQuery(query);
        }

        private void LoadCbTenKhachHang()
        {

        }
        private void LoadCbTenHang()
        {

        }

        private void RefreshText()
        {
            txtMaPX.Text = "";
            cbTenKH.Text = "";
            cbTenHang.Text = "";
            cbTimKiem.Text = "";
            txtSoLuong.Text = "";
            txtDonGia.Text = "";
            txtTimKiem.Text = "";
            dtpNgayXuat.Value = DateTime.Now;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {

        }

        private void btnVeMenu_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

        }

        private void dgvXuatHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                txtMaPX.Text = Convert.ToString(dgvXuatHang.CurrentRow.Cells["maPX"].Value);
                dtpNgayXuat.Text = Convert.ToString(dgvXuatHang.CurrentRow.Cells["ngayXuat"].Value);
                cbTenKH.Text = Convert.ToString(dgvXuatHang.CurrentRow.Cells["tenKH"].Value);
                cbTenHang.Text = Convert.ToString(dgvXuatHang.CurrentRow.Cells["tenHang"].Value);
                txtSoLuong.Text = Convert.ToString(dgvXuatHang.CurrentRow.Cells["soLuong"].Value);
                txtDonGia.Text = Convert.ToString(dgvXuatHang.CurrentRow.Cells["donGiaXuat"].Value);
            }
        }

        private void dgvXuatHang_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvXuatHang.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }
    }
}
