using QuanLiKho.DAO;
using QuanLiKho.Data;
using QuanLiKho.Module;
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
    public partial class fr_NhapHang : Form
    {
        private TaiKhoan tkDangNhap;

        public TaiKhoan TkDangNhap
        {
            get { return tkDangNhap; }
            set { tkDangNhap = value; }
        }
        public fr_NhapHang(TaiKhoan TKDN)
        {
            InitializeComponent();
            this.TkDangNhap = TKDN;
            LoadCbTenNCC();
            LoadCbMaPhieuNhap();
            LoadCbTenHang();
            LoadDSPhieuNhap();
            LoadDSChiTietPhieuNhap();
            RefreshTextPhieuNhap();
            RefreshTextChiTietPhieuNhap();
        }

        private void LoadDSPhieuNhap()
        {
            string query = "SELECT MaPhieuNhap,NgayNhap,TenNCC FROM dbo.PhieuNhap,dbo.NhaCungCap WHERE NhaCungCap.MaNCC=PhieuNhap.MaNCC";
            dgvPhieuNhap.DataSource = DataProvider.Instance.ExcuteQuery(query);
            RefreshTextPhieuNhap();
        }

        private void LoadDSChiTietPhieuNhap()
        {
            string query = "SELECT MaPhieuNhap,TenHang,ChiTietPhieuNhap.SoLuong,DonGiaNhap FROM dbo.ChiTietPhieuNhap,dbo.HangHoa WHERE ChiTietPhieuNhap.MaHang=HangHoa.MaHang";
            dgvChiTietPN.DataSource = DataProvider.Instance.ExcuteQuery(query);
            RefreshTextChiTietPhieuNhap();
        }
        private void RefreshTextPhieuNhap()
        {
            txtMaPN.Text = "";
            dtpNgayNhap.Value = DateTime.Now;
            cbTenNCC.Text = "";
            txtTimKiemPN.Text = "";
            cbTimKiemPN.Text = "";
        }
        private void RefreshTextChiTietPhieuNhap()
        {
            cbMaPN.Text = "";
            cbTenHang.Text = "";
            txtSoLg.Text = "";
            txtDonGiaNhap.Text = "";
            txtTimKiemCTPN.Text = "";
            cbTimKiemCTPN.Text = "";
        }
        private void LoadCbTenNCC()
        {
            List<CbTenNCC> listTenNCC = CbTenNCCDAO.Instance.LayDSTenNCC();
            cbTenNCC.DataSource = listTenNCC;
            cbTenNCC.DisplayMember = "TenNCC";
        }
        private void LoadCbMaPhieuNhap()
        {
            List<CbMaPhieuNhap> listMaPN = CbMaPhieuNhapDAO.Instance.LayDSMaPhieuNhap();
            cbMaPN.DataSource = listMaPN;
            cbMaPN.DisplayMember = "MaPhieuNhap";
        }
        private void LoadCbTenHang()
        {
            List<CbTenHang> listTenHang = CbTenHangDAO.Instance.LayDSTenHang();
            cbTenHang.DataSource = listTenHang;
            cbTenHang.DisplayMember = "TenHang";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnThemPN_Click(object sender, EventArgs e)
        {
            string maPN = txtMaPN.Text;
            DateTime ngayNhap = dtpNgayNhap.Value;
            string maKH = (cbTenNCC.SelectedItem as CbTenNCC).MaNCC;
            if (maPN == "")
            {
                MessageBox.Show("Bạn chưa nhập Mã phiếu xuất!", "Thông báo");
            }
            else if (cbTenNCC.SelectedItem == null)
            {
                MessageBox.Show("Bạn chưa chọn khách hàng!", "Thông báo");
            }
            else
            {
                if (ThemNhapHang.Instance.ThemPhieuNhap(maPN,ngayNhap,maKH)==true)
                {
                    MessageBox.Show("Thêm thành công", "Thông Báo");
                    RefreshTextPhieuNhap();
                    LoadCbMaPhieuNhap();
                    LoadDSPhieuNhap();
                }
                else MessageBox.Show("Có lỗi khi thêm phiếu nhập!", "Thông Báo");
            }
        }

        private void btnSuaPN_Click(object sender, EventArgs e)
        {
            string maPN = txtMaPN.Text;
            DateTime ngayNhap = dtpNgayNhap.Value;
            string maNCC = (cbTenNCC.SelectedItem as CbTenNCC).MaNCC;
            if (SuaNhapHang.Instance.SuaPhieuNhap(maPN, ngayNhap, maNCC) == true)
            {
                MessageBox.Show("Sửa thành công", "Thông Báo");
                RefreshTextPhieuNhap();
                LoadDSPhieuNhap();
            }
            else MessageBox.Show("Có lỗi khi sửa phiếu nhập!", "Thông Báo");
        }

        private void btnXoaPN_Click(object sender, EventArgs e)
        {
            string maPN = txtMaPN.Text;
            if (XoaNhapHang.Instance.XoaPhieuNhap(maPN) == true)
            {
                MessageBox.Show("Xóa thành công", "Thông Báo");
                RefreshTextPhieuNhap();
                LoadCbMaPhieuNhap();
                LoadDSPhieuNhap();
            }
            else MessageBox.Show("Có lỗi khi xóa phiếu nhập!", "Thông Báo");
        }

        private void btnLamMoiPN_Click(object sender, EventArgs e)
        {
            RefreshTextPhieuNhap();
            LoadDSPhieuNhap();
        }

        private void btnTimKiemPN_Click(object sender, EventArgs e)
        {
            string maTK = txtTimKiemPN.Text;
            string cbTim = cbTimKiemPN.SelectedItem.ToString();

            if (maTK == "")
            {
                MessageBox.Show("Bạn chưa nhập gì cả!", "Thông báo");
            }
            else if (cbTim == "")
            {
                MessageBox.Show("Bạn chưa chọn gì từ ComboBox!", "Thông báo");
            }
            else
            {
                if (cbTim == "Tất cả")
                {
                    dgvPhieuNhap.DataSource = TimKiemNhapHang.Instance.TkPhieuNhapTheoTatCa(maTK);
                    if (TimKiemNhapHang.Instance.CheckTkPhieuNhapTheoTatCa(maTK) == false)
                        MessageBox.Show("Không tìm thấy kết quả nào!", "Thông báo");
                }

                if (cbTim == "Mã phiếu nhập")
                {
                    dgvPhieuNhap.DataSource = TimKiemNhapHang.Instance.TkPhieuNhapTheoMaPhieuNhap(maTK);
                    if (TimKiemNhapHang.Instance.CheckTkPhieuNhapTheoMaPhieuNhap(maTK) == false)
                        MessageBox.Show("Không tìm thấy kết quả nào!", "Thông báo");
                }

                if (cbTim == "Ngày nhập")
                {
                    dgvPhieuNhap.DataSource = TimKiemNhapHang.Instance.TkPhieuNhapTheoNgayNhap(maTK);
                    if (TimKiemNhapHang.Instance.CheckTkPhieuNhapTheoNgayNhap(maTK) == false)
                        MessageBox.Show("Không tìm thấy kết quả nào!", "Thông báo");
                }

                if (cbTim == "Tên nhà cung cấp")
                {
                    dgvPhieuNhap.DataSource = TimKiemNhapHang.Instance.TkPhieuNhapTheoTenNCC(maTK);
                    if (TimKiemNhapHang.Instance.CheckTkPhieuNhapTheoTenNCC(maTK) == false)
                        MessageBox.Show("Không tìm thấy kết quả nào!", "Thông báo");
                }
            }
        }

        private void btnThemCTPN_Click(object sender, EventArgs e)
        {
            string maPN = (cbMaPN.SelectedItem as CbMaPhieuNhap).MaPhieuNhap;
            string maHang = (cbTenHang.SelectedItem as CbTenHang).MaHang;
            int soLuong = Convert.ToInt32(txtSoLg.Text);
            int donGiaNhap = Convert.ToInt32(txtDonGiaNhap.Text);
            if (maPN == "")
            {
                MessageBox.Show("Bạn chưa chọn Mã phiếu nhập!", "Thông báo");
            }
            else if (maHang == "")
            {
                MessageBox.Show("Bạn chưa chọn hàng!", "Thông báo");
            }
            else if (txtSoLg.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số lượng!", "Thông báo");
            }
            else if (txtDonGiaNhap.Text == "")
            {
                MessageBox.Show("Bạn nhập đơn giá nhập!", "Thông báo");
            }
            else
            {
                if (ThemNhapHang.Instance.ThemChiTietPhieuNhap(maPN, maHang, soLuong, donGiaNhap) == true)
                {
                    MessageBox.Show("Thêm thành công", "Thông Báo");
                    RefreshTextChiTietPhieuNhap();
                    LoadDSChiTietPhieuNhap();
                }
                else MessageBox.Show("Có lỗi khi thêm chi tiết phiếu nhập!", "Thông Báo");
            }
        }

        private void btnSuaCTPN_Click(object sender, EventArgs e)
        {
            string maPN = (cbMaPN.SelectedItem as CbMaPhieuNhap).MaPhieuNhap;
            string maHang = (cbTenHang.SelectedItem as CbTenHang).MaHang;
            int soLuong = Convert.ToInt32(txtSoLg.Text);
            int donGiaNhap = Convert.ToInt32(txtDonGiaNhap.Text);
            if (SuaNhapHang.Instance.SuaChiTietPhieuNhap(maPN, maHang, soLuong, donGiaNhap) == true)
            {
                MessageBox.Show("Sửa thành công", "Thông Báo");
                RefreshTextChiTietPhieuNhap();
                LoadDSChiTietPhieuNhap();
            }
            else MessageBox.Show("Có lỗi khi sửa chi tiết phiếu nhập!", "Thông Báo");
        }

        private void btnXoaCTPN_Click(object sender, EventArgs e)
        {
            string maPN = (cbMaPN.SelectedItem as CbMaPhieuNhap).MaPhieuNhap;
            string maHang = (cbTenHang.SelectedItem as CbTenHang).MaHang;
            if (XoaNhapHang.Instance.XoaChiTietPhieuNhap(maPN, maHang) == true)
            {
                MessageBox.Show("Xóa thành công", "Thông Báo");
                RefreshTextChiTietPhieuNhap();
                LoadDSChiTietPhieuNhap();
            }
            else MessageBox.Show("Có lỗi khi xóa chi tiết phiếu nhập!", "Thông Báo");
        }

        private void btnLamMoiCTPN_Click(object sender, EventArgs e)
        {
            RefreshTextChiTietPhieuNhap();
            LoadDSChiTietPhieuNhap();
        }

        private void btnTimKiemCTPN_Click(object sender, EventArgs e)
        {
            string maTK = txtTimKiemCTPN.Text;
            string cbTim = cbTimKiemCTPN.SelectedItem.ToString();

            if (cbTim == "")
            {
                MessageBox.Show("Bạn chưa chọn gì từ ComboBox!", "Thông báo");
            }
            else if (maTK == "")
            {
                MessageBox.Show("Bạn chưa nhập gì cả!", "Thông báo");
            }
            else
            {
                if (cbTim == "Tất cả")
                {
                    dgvChiTietPN.DataSource = TimKiemNhapHang.Instance.TkCTPNTheoTatCa(maTK);
                    if (TimKiemNhapHang.Instance.CheckTkCTPNTheoTatCa(maTK) == false)
                        MessageBox.Show("Không tìm thấy kết quả nào!", "Thông báo");
                }

                if (cbTim == "Mã phiếu nhập")
                {
                    dgvChiTietPN.DataSource = TimKiemNhapHang.Instance.TkCTPNTheoMaPhieuNhap(maTK);
                    if (TimKiemNhapHang.Instance.CheckTkCTPNTheoMaPhieuNhap(maTK) == false)
                        MessageBox.Show("Không tìm thấy kết quả nào!", "Thông báo");
                }

                if (cbTim == "Tên hàng hóa")
                {
                    dgvChiTietPN.DataSource = TimKiemNhapHang.Instance.TkCTPNTheoTenHang(maTK);
                    if (TimKiemNhapHang.Instance.CheckTkCTPNTheoTenHang(maTK) == false)
                        MessageBox.Show("Không tìm thấy kết quả nào!", "Thông báo");
                }

                if (cbTim == "Số lượng")
                {
                    dgvChiTietPN.DataSource = TimKiemNhapHang.Instance.TkCTPNTheoSoLuong(maTK);
                    if (TimKiemNhapHang.Instance.CheckTkCTPNTheoSoLuong(maTK) == false)
                        MessageBox.Show("Không tìm thấy kết quả nào!", "Thông báo");
                }
                if (cbTim == "Đơn giá nhập")
                {
                    dgvChiTietPN.DataSource = TimKiemNhapHang.Instance.TkCTPNTheoDonGiaNhap(maTK);
                    if (TimKiemNhapHang.Instance.CheckTkCTPNTheoDonGiaNhap(maTK) == false)
                        MessageBox.Show("Không tìm thấy kết quả nào!", "Thông báo");
                }
            }
        }

        private void btnVeMenu_Click_1(object sender, EventArgs e)
        {
            fr_Main f = new fr_Main(TkDangNhap);
            this.Hide();
            f.Show();
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát", "Thông Báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void dgvPhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                txtMaPN.Text = Convert.ToString(dgvPhieuNhap.CurrentRow.Cells["maPN"].Value);
                dtpNgayNhap.Text = Convert.ToString(dgvPhieuNhap.CurrentRow.Cells["ngayNhap"].Value);
                cbTenNCC.Text = Convert.ToString(dgvPhieuNhap.CurrentRow.Cells["tenNCC"].Value);
            }
        }

        private void dgvPhieuNhap_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvPhieuNhap.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        private void dgvChiTietPX_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                cbMaPN.Text = Convert.ToString(dgvChiTietPN.CurrentRow.Cells["maPN1"].Value);
                cbTenHang.Text = Convert.ToString(dgvChiTietPN.CurrentRow.Cells["tenHang"].Value);
                txtSoLg.Text = Convert.ToString(dgvChiTietPN.CurrentRow.Cells["soLuong"].Value);
                txtDonGiaNhap.Text = Convert.ToString(dgvChiTietPN.CurrentRow.Cells["donGiaNhap"].Value);
            }
        }

        private void dgvChiTietPX_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvChiTietPN.Rows[e.RowIndex].Cells["STT1"].Value = e.RowIndex + 1;
        }
    }
}
