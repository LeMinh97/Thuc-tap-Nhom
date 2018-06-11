using QuanLiKhachSan.DAO;
using QuanLiKhachSan.Data;
using QuanLiKhachSan.Module;
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
    public partial class fr_SDDichVu : Form
    {
        private TaiKhoan tkDangNhap;

        public TaiKhoan TkDangNhap
        {
            get { return tkDangNhap; }
            set { tkDangNhap = value; }
        }
        public fr_SDDichVu(TaiKhoan TKDN)
        {
            InitializeComponent();
            this.TkDangNhap = TKDN;
            LoadDSSdDichVu();
            RefreshText();
        }

        private void LoadDSSdDichVu()
        {
            string query = "SELECT MaPhong,TenDichVu,NgayDung,SoLuong,ThanhToan FROM dbo.SuDungDichVu,dbo.DichVu WHERE DichVu.MaDichVu=SuDungDichVu.MaDichVu";
            dgvSDDichVu.DataSource = DataProvider.Instance.ExcuteQuery(query);
            RefreshText();
            LoadCBMaPhong();
            LoadCBTenDichVu();
        }
        private void RefreshText()
        {
            cbMaPhong.Text = "";
            cbTenDichVu.Text = "";
            cbTimKiem.Text = "";
            dtpNgayDung.Value = DateTime.Now;
            txtSoLuong.Text = "";
            cbThanhToan.Text = "";
            txtTimKiem.Text = "";
        }

        private void LoadCBMaPhong()
        {
            List<cbPhong> listPhong = cbPhongDAO.Instance.LayDSPhongDat();
            cbMaPhong.DataSource = listPhong;
            cbMaPhong.DisplayMember = "MaPhong";
        }

        private void LoadCBTenDichVu()
        {
            List<cbDichVu> listDichVu = cbDichVuDAO.Instance.LayDSTenDichVu();
            cbTenDichVu.DataSource = listDichVu;
            cbTenDichVu.DisplayMember = "TenDichVu";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maPhong = (cbMaPhong.SelectedItem as cbPhong).MaPhong;
            string maDichVu = (cbTenDichVu.SelectedItem as cbDichVu).MaDichVu;
            DateTime ngayDung = dtpNgayDung.Value;
            int soLuong = Convert.ToInt32(txtSoLuong.Text);
            string thanhToan = cbThanhToan.SelectedItem.ToString();
            if (maPhong == "")
            {
                MessageBox.Show("Bạn chưa chọn Mã phòng!", "Thông báo");
            }
            else if (maDichVu == "")
            {
                MessageBox.Show("Bạn chưa chọn Tên dịch vụ!", "Thông báo");
            }
            else if (txtSoLuong.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập Số lượng!", "Thông báo");
            }
            
            else if (thanhToan =="")
            {
                MessageBox.Show("Bạn chưa chọn Thanh toán", "Thông báo");
            }
            else
            {
                if (SuDungDichVu.Instance.ThemSDDV(maPhong,maDichVu,ngayDung,soLuong,thanhToan) == true)
                {
                    MessageBox.Show("Thêm thành công", "Thông Báo");
                    LoadDSSdDichVu();
                    RefreshText();
                }
                else MessageBox.Show("Có lỗi khi thêm Dịch vụ!", "Thông Báo");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maPhong = (cbMaPhong.SelectedItem as cbPhong).MaPhong;
            string maDichVu = (cbTenDichVu.SelectedItem as cbDichVu).MaDichVu;
            DateTime ngayDung = dtpNgayDung.Value;
            int soLuong = Convert.ToInt32(txtSoLuong.Text);
            string thanhToan = cbThanhToan.SelectedItem.ToString();
            if (SuDungDichVu.Instance.SuaSDDV(maPhong, maDichVu, ngayDung, soLuong, thanhToan) == true)
            {
                MessageBox.Show("Sửa thành công", "Thông Báo");
                LoadDSSdDichVu();
                RefreshText();
            }
            else MessageBox.Show("Có lỗi khi sửa dịch vụ!", "Thông Báo");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maPhong = (cbMaPhong.SelectedItem as cbPhong).MaPhong;
            string maDichVu = (cbTenDichVu.SelectedItem as cbDichVu).MaDichVu;
            DateTime ngayDung = dtpNgayDung.Value;
            if (SuDungDichVu.Instance.XoaSDDV(maPhong, maDichVu, ngayDung) == true)
            {
                MessageBox.Show("Xóa thành công", "Thông Báo");
                LoadDSSdDichVu();
                RefreshText();
            }
            else MessageBox.Show("Có lỗi khi xóa dịch vụ!", "Thông Báo");
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string maTK = txtTimKiem.Text;
            string cbTim = cbTimKiem.SelectedItem.ToString();
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
                    dgvSDDichVu.DataSource = SuDungDichVu.Instance.TkTheoTatCa(maTK);
                    if (SuDungDichVu.Instance.CheckTkTheoTatCa(maTK) == false)
                        MessageBox.Show("Không tìm thấy kết quả nào!", "Thông báo");
                }

                if (cbTim == "Mã phòng")
                {
                    dgvSDDichVu.DataSource = SuDungDichVu.Instance.TkTheoMaPhong(maTK);
                    if (SuDungDichVu.Instance.CheckTkTheoMaPhong(maTK) == false)
                        MessageBox.Show("Không tìm thấy kết quả nào!", "Thông báo");
                }

                if (cbTim == "Tên dịch vụ")
                {
                    dgvSDDichVu.DataSource = SuDungDichVu.Instance.TkTheoTenDichVu(maTK);
                    if (SuDungDichVu.Instance.CheckTkTheoTenDichVu(maTK) == false)
                        MessageBox.Show("Không tìm thấy kết quả nào!", "Thông báo");
                }

                if (cbTim == "Ngày sử dụng")
                {
                    dgvSDDichVu.DataSource = SuDungDichVu.Instance.TkTheoNgayDung(maTK);
                    if (SuDungDichVu.Instance.CheckTkTheoNgayDung(maTK) == false)
                        MessageBox.Show("Không tìm thấy kết quả nào!", "Thông báo");
                }

                if (cbTim == "Số lượng")
                {
                    dgvSDDichVu.DataSource = SuDungDichVu.Instance.TkTheoSoLuong(maTK);
                    if (SuDungDichVu.Instance.CheckTkTheoSoLuong(maTK) == false)
                        MessageBox.Show("Không tìm thấy kết quả nào!", "Thông báo");
                }

                if (cbTim == "Tình trạng thanh toán")
                {
                    dgvSDDichVu.DataSource = SuDungDichVu.Instance.TkTheoThanhToan(maTK);
                    if (SuDungDichVu.Instance.CheckTkTheoThanhToan(maTK) == false)
                        MessageBox.Show("Không tìm thấy kết quả nào!", "Thông báo");
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadDSSdDichVu();
            RefreshText();
        }

        private void btnVeMenu_Click(object sender, EventArgs e)
        {
            fr_Main f = new fr_Main(TkDangNhap);
            this.Hide();
            f.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát", "Thông Báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void dgvSDDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                cbTenDichVu.Text = Convert.ToString(dgvSDDichVu.CurrentRow.Cells["tenDichVu"].Value);
                cbMaPhong.Text = Convert.ToString(dgvSDDichVu.CurrentRow.Cells["maPhong"].Value);
                dtpNgayDung.Text = Convert.ToString(dgvSDDichVu.CurrentRow.Cells["ngayDung"].Value);
                cbThanhToan.Text = Convert.ToString(dgvSDDichVu.CurrentRow.Cells["thanhToan"].Value);
                txtSoLuong.Text = Convert.ToString(dgvSDDichVu.CurrentRow.Cells["soLuong"].Value);
            }
        }

        private void dgvSDDichVu_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvSDDichVu.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }
    }
}
