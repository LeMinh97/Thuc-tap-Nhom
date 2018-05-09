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
            LoadDSPhieuXuat();
            LoadDSChiTietPhieuXuat();
            LoadCbTenKhachHang();
            LoadCbMaPhieuXuat();
            LoadCbTenHang();
            RefreshTextPhieuXuat();
            RefreshTextChiTietPhieuXuat();
        }
        private void LoadDSPhieuXuat()
        {
            string query = "SELECT MaPhieuXuat,NgayXuat,TenKH FROM dbo.PhieuXuat,dbo.KhachHang WHERE KhachHang.MaKH=PhieuXuat.MaKH";
            dgvPhieuXuat.DataSource = DataProvider.Instance.ExcuteQuery(query);
        }

        private void LoadDSChiTietPhieuXuat()
        {
            string query = "SELECT MaPhieuXuat,TenHang,ChiTietPhieuXuat.SoLuong,DonGiaXuat FROM dbo.ChiTietPhieuXuat,dbo.HangHoa WHERE ChiTietPhieuXuat.MaHang=HangHoa.MaHang";
            dgvChiTietPX.DataSource = DataProvider.Instance.ExcuteQuery(query);
        }

        private void LoadCbTenKhachHang()
        {
            List<CbTenKhachHang> listTenKH = CbTenKhachHangDAO.Instance.LayDSTenKhachHang();
            cbTenKH.DataSource = listTenKH;
            cbTenKH.DisplayMember = "TenKhachHang";
        }

        private void LoadCbMaPhieuXuat()
        {
            List<CbMaPhieuXuat> listMaPX = CbMaPhieuXuatDAO.Instance.LayDSMaPhieuXuat();
            cbMaPX.DataSource = listMaPX;
            cbMaPX.DisplayMember = "MaPhieuXuat";
        }
        private void LoadCbTenHang()
        {
            List<CbTenHang> listTenHang = CbTenHangDAO.Instance.LayDSTenHang();
            cbTenHang.DataSource = listTenHang;
            cbTenHang.DisplayMember = "TenHang";
        }

        private void RefreshTextPhieuXuat()
        {
            txtMaPX.Text = "";
            dtpNgayXuat.Value = DateTime.Now;
            cbTenKH.Text = "";
            txtTimKiemPX.Text = "";
            cbTimKiemPX.Text = "";
        }

        private void RefreshTextChiTietPhieuXuat()
        {
            cbMaPX.Text = "";
            cbTenHang.Text = "";
            txtSoLg.Text = "";
            txtDonGiaXuat.Text = "";
            txtTimKiemCTPX.Text = "";
            cbTimKiemCTPX.Text = "";
        }

        private void dgvPhieuXuat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                txtMaPX.Text = Convert.ToString(dgvPhieuXuat.CurrentRow.Cells["maPX"].Value);
                dtpNgayXuat.Text = Convert.ToString(dgvPhieuXuat.CurrentRow.Cells["ngayXuat"].Value);
                cbTenKH.Text = Convert.ToString(dgvPhieuXuat.CurrentRow.Cells["tenKH"].Value);
            }
        }

        private void dgvPhieuXuat_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvPhieuXuat.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        private void dgvChiTietPX_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                cbMaPX.Text = Convert.ToString(dgvChiTietPX.CurrentRow.Cells["maPX1"].Value);
                cbTenHang.Text = Convert.ToString(dgvChiTietPX.CurrentRow.Cells["tenHang"].Value);
                txtSoLg.Text = Convert.ToString(dgvChiTietPX.CurrentRow.Cells["soLuong"].Value);
                txtDonGiaXuat.Text = Convert.ToString(dgvChiTietPX.CurrentRow.Cells["donGiaXuat"].Value);
            }
        }

        private void dgvChiTietPX_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvChiTietPX.Rows[e.RowIndex].Cells["STT1"].Value = e.RowIndex + 1;
        }

        private void btnThemPX_Click(object sender, EventArgs e)
        {
            string maPX = txtMaPX.Text;
            DateTime ngayXuat = dtpNgayXuat.Value;
            string maKH = (cbTenKH.SelectedItem as CbTenKhachHang).MaKH;
            if(maPX=="")
            {
                MessageBox.Show("Bạn chưa nhập Mã phiếu xuất!", "Thông báo");
            }else if(cbTenKH.SelectedItem==null)
            {
                MessageBox.Show("Bạn chưa chọn khách hàng!", "Thông báo");
            }else
            {
                if (ThemXuatHang.Instance.ThemPhieuXuat(maPX,ngayXuat,maKH) == true)
                {
                    MessageBox.Show("Thêm thành công", "Thông Báo");
                    RefreshTextPhieuXuat();
                    LoadCbMaPhieuXuat();
                    LoadDSPhieuXuat();
                }
                else MessageBox.Show("Có lỗi khi thêm phiếu xuất!", "Thông Báo");
            }
        }

        private void btnSuaPX_Click(object sender, EventArgs e)
        {
            string maPX = txtMaPX.Text;
            DateTime ngayXuat = dtpNgayXuat.Value;
            string maKH = (cbTenKH.SelectedItem as CbTenKhachHang).MaKH;
            if (SuaXuatHang.Instance.SuaPhieuXuat(maPX, ngayXuat, maKH) == true)
            {
                MessageBox.Show("Sửa thành công", "Thông Báo");
                RefreshTextPhieuXuat();
                LoadDSPhieuXuat();
            }
            else MessageBox.Show("Có lỗi khi sửa phiếu xuất!", "Thông Báo");
        }

        private void btnXoaPX_Click(object sender, EventArgs e)
        {
            string maPX = txtMaPX.Text;
            if (XoaXuatHang.Instance.XoaPhieuXuat(maPX) == true)
            {
                MessageBox.Show("Xóa thành công", "Thông Báo");
                RefreshTextPhieuXuat();
                LoadCbMaPhieuXuat();
                LoadDSPhieuXuat();
            }
            else MessageBox.Show("Có lỗi khi xóa phiếu xuất!", "Thông Báo");
        }

        private void btnLamMoiPX_Click(object sender, EventArgs e)
        {
            RefreshTextPhieuXuat();
            LoadDSPhieuXuat();
        }

        private void btnTimKiemPX_Click(object sender, EventArgs e)
        {
            string maTK = txtTimKiemPX.Text;
            string cbTim = cbTimKiemPX.SelectedItem.ToString();

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
                    dgvPhieuXuat.DataSource = TimKiemXuatHang.Instance.TkPhieuXuatTheoTatCa(maTK);
                    if (TimKiemXuatHang.Instance.CheckTkPhieuXuatTheoTatCa(maTK) == false)
                        MessageBox.Show("Không tìm thấy kết quả nào!", "Thông báo");
                }

                if (cbTim == "Mã phiếu xuất")
                {
                    dgvPhieuXuat.DataSource = TimKiemXuatHang.Instance.TkPhieuXuatTheoMaPhieuXuat(maTK);
                    if (TimKiemXuatHang.Instance.CheckTkPhieuXuatTheoMaPhieuXuat(maTK) == false)
                        MessageBox.Show("Không tìm thấy kết quả nào!", "Thông báo");
                }

                if (cbTim == "Ngày xuất")
                {
                    dgvPhieuXuat.DataSource = TimKiemXuatHang.Instance.TkPhieuXuatTheoNgayXuat(maTK);
                    if (TimKiemXuatHang.Instance.CheckTkPhieuXuatTheoNgayXuat(maTK) == false)
                        MessageBox.Show("Không tìm thấy kết quả nào!", "Thông báo");
                }

                if (cbTim == "Tên khách hàng")
                {
                    dgvPhieuXuat.DataSource = TimKiemXuatHang.Instance.TkPhieuXuatTheoTenKhachHang(maTK);
                    if (TimKiemXuatHang.Instance.CheckTkPhieuXuatTheoTenKhachHang(maTK) == false)
                        MessageBox.Show("Không tìm thấy kết quả nào!", "Thông báo");
                }
            }
        }

        private void btnThemCTPX_Click(object sender, EventArgs e)
        {
            string maPX = (cbMaPX.SelectedItem as CbMaPhieuXuat).MaPhieuXuat;
            string maHang = (cbTenHang.SelectedItem as CbTenHang).MaHang;
            int soLuong =Convert.ToInt32(txtSoLg.Text);
            int donGiaXuat = Convert.ToInt32(txtDonGiaXuat.Text);
            if (maPX == "")
            {
                MessageBox.Show("Bạn chưa chọn Mã phiếu xuất!", "Thông báo");
            }
            else if (maHang == "")
            {
                MessageBox.Show("Bạn chưa chọn hàng!", "Thông báo");
            }
            else if (txtSoLg.Text== "")
            {
                MessageBox.Show("Bạn chưa nhập số lượng!", "Thông báo");
            }
            else if (txtDonGiaXuat.Text== "")
            {
                MessageBox.Show("Bạn nhập đơn giá xuất!", "Thông báo");
            }
            else
            {
                if (ThemXuatHang.Instance.ThemChiTietPhieuXuat(maPX,maHang,soLuong,donGiaXuat)==true)
                {
                    MessageBox.Show("Thêm thành công", "Thông Báo");
                    RefreshTextChiTietPhieuXuat();
                    LoadDSChiTietPhieuXuat();
                }
                else MessageBox.Show("Có lỗi khi thêm chi tiết phiếu xuất!", "Thông Báo");
            }
        }

        private void btnSuaCTPX_Click(object sender, EventArgs e)
        {
            string maPX = (cbMaPX.SelectedItem as CbMaPhieuXuat).MaPhieuXuat;
            string maHang = (cbTenHang.SelectedItem as CbTenHang).MaHang;
            int soLuong = Convert.ToInt32(txtSoLg.Text);
            int donGiaXuat = Convert.ToInt32(txtDonGiaXuat.Text);
            if (SuaXuatHang.Instance.SuaChiTietPhieuXuat(maPX, maHang, soLuong, donGiaXuat) == true)
            {
                MessageBox.Show("Sửa thành công", "Thông Báo");
                RefreshTextChiTietPhieuXuat();
                LoadDSChiTietPhieuXuat();
            }
            else MessageBox.Show("Có lỗi khi sửa chi tiết phiếu xuất!", "Thông Báo");
        }

        private void btnXoaCTPX_Click(object sender, EventArgs e)
        {
            string maPX = (cbMaPX.SelectedItem as CbMaPhieuXuat).MaPhieuXuat;
            string maHang = (cbTenHang.SelectedItem as CbTenHang).MaHang;
            if (XoaXuatHang.Instance.XoaChiTietPhieuXuat(maPX,maHang) == true)
            {
                MessageBox.Show("Xóa thành công", "Thông Báo");
                RefreshTextChiTietPhieuXuat();
                LoadDSChiTietPhieuXuat();
            }
            else MessageBox.Show("Có lỗi khi xóa chi tiết phiếu xuất!", "Thông Báo");
        }

        private void btnLamMoiCTPX_Click(object sender, EventArgs e)
        {
            RefreshTextChiTietPhieuXuat();
            LoadDSChiTietPhieuXuat();
        }

        private void btnTimKiemCTPX_Click(object sender, EventArgs e)
        {
            string maTK = txtTimKiemCTPX.Text;
            string cbTim = cbTimKiemCTPX.SelectedItem.ToString();

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
                    dgvChiTietPX.DataSource = TimKiemXuatHang.Instance.TkCTPXTheoTatCa(maTK);
                    if (TimKiemXuatHang.Instance.CheckTkCTPXTheoTatCa(maTK) == false)
                        MessageBox.Show("Không tìm thấy kết quả nào!", "Thông báo");
                }

                if (cbTim == "Mã phiếu xuất")
                {
                    dgvChiTietPX.DataSource = TimKiemXuatHang.Instance.TkCTPXTheoMaPhieuXuat(maTK);
                    if (TimKiemXuatHang.Instance.CheckTkCTPXTheoMaPhieuXuat(maTK) == false)
                        MessageBox.Show("Không tìm thấy kết quả nào!", "Thông báo");
                }

                if (cbTim == "Tên hàng hóa")
                {
                    dgvChiTietPX.DataSource = TimKiemXuatHang.Instance.TkCTPXTheoTenHang(maTK);
                    if (TimKiemXuatHang.Instance.CheckTkCTPXTheoTenHang(maTK) == false)
                        MessageBox.Show("Không tìm thấy kết quả nào!", "Thông báo");
                }

                if (cbTim == "Số lượng")
                {
                    dgvChiTietPX.DataSource = TimKiemXuatHang.Instance.TkCTPXTheoSoLuong(maTK);
                    if (TimKiemXuatHang.Instance.CheckTkCTPXTheoSoLuong(maTK) == false)
                        MessageBox.Show("Không tìm thấy kết quả nào!", "Thông báo");
                }
                if (cbTim == "Đơn giá xuất")
                {
                    dgvChiTietPX.DataSource = TimKiemXuatHang.Instance.TkCTPXTheoDonGiaXuat(maTK);
                    if (TimKiemXuatHang.Instance.CheckTkCTPXTheoDonGiaXuat(maTK) == false)
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
    }
}
