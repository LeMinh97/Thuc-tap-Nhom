using QuanLiThuVien.DAO;
using QuanLiThuVien.Data;
using QuanLiThuVien.Module;
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
    public partial class fr_MuonTra : Form
    {
        private TaiKhoan tkDangNhap;

        public TaiKhoan TkDangNhap
        {
            get { return tkDangNhap; }
            set { tkDangNhap = value; }
        }
        public fr_MuonTra(TaiKhoan TKDN)
        {
            InitializeComponent();
            this.TkDangNhap = TKDN;
            LoadDSMuonTra();
            LoadCBBoxTenNM();
            LoadCBBoxMaCS();
            RefreshText();
        }
        void LoadDSMuonTra()
        {
            string query = "SELECT TenNguoiDoc, CuonSach.MaCuonSach, NgayMuon, NgayTra FROM dbo.PhieuMuon, dbo.NguoiDoc, dbo.CuonSach WHERE dbo.PhieuMuon.MaNguoiDoc=dbo.NguoiDoc.MaNguoiDoc AND dbo.PhieuMuon.MaCuonSach=dbo.CuonSach.MaCuonSach";
            dgvMuonTra.DataSource = DataProvider.Instance.ExcuteQuery(query);
        }

        void RefreshText()
        {
            cbMaCuonSach.Text="";
            cbTenNM.Text="";
            cbTimKiemMT.Text="";
            txtTimKiemMT.Text = "";
            dtpNgayMuon.Value = DateTime.Now;
            dtpNgayTra.Value = DateTime.Now;
        }
        void LoadCBBoxTenNM()
        {
            List<MTNguoiMuon> listNM = MTNguoiMuonDAO.Instance.LayDSNguonMuon();
            cbTenNM.DataSource = listNM;
            cbTenNM.DisplayMember = "TenNguoiMuon";
        }
        void LoadCBBoxMaCS()
        {
            List<MTCuonSach> listCS = MTCuonSachDAO.Instance.LayDSCuonSach();
            cbMaCuonSach.DataSource = listCS;
            cbMaCuonSach.DisplayMember = "MaCuonSach";
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

        private void dgvMuonTra_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvMuonTra.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        private void dgvMuonTra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                cbTenNM.Text = Convert.ToString(dgvMuonTra.CurrentRow.Cells["TenNM"].Value);
                cbMaCuonSach.Text = Convert.ToString(dgvMuonTra.CurrentRow.Cells["MaCS"].Value);
                dtpNgayMuon.Text = Convert.ToString(dgvMuonTra.CurrentRow.Cells["NgayMuon"].Value);
                dtpNgayTra.Text = Convert.ToString(dgvMuonTra.CurrentRow.Cells["NgayTra"].Value);
            }
        }

        private void btnThemMT_Click(object sender, EventArgs e)
        {
            string maNM = (cbTenNM.SelectedItem as MTNguoiMuon).MaNguoiMuon;
            string maCS = (cbMaCuonSach.SelectedItem as MTCuonSach).MaCuonSach;
            DateTime NgayMuon = dtpNgayMuon.Value;
            DateTime NgayTra = dtpNgayTra.Value;
            if (cbTenNM.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn Người mượn!", "Thông báo");
            }
            else if (cbMaCuonSach.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn Mã sách!", "Thông báo");
            }
            else if (dtpNgayTra.Value<dtpNgayMuon.Value)
            {
                MessageBox.Show("Ngày trả không được trước ngày mượn!", "Thông báo");
            }
            else
            {
                if (ThemMuonTra.Instance.ThemMT(maNM,maCS,NgayMuon,NgayTra) == true)
                {
                    MessageBox.Show("Thêm thành công", "Thông Báo");
                    LoadDSMuonTra();
                }
                else MessageBox.Show("Có lỗi khi thêm mượn trả!", "Thông Báo");
            }
        }

        private void btnSuaMT_Click(object sender, EventArgs e)
        {
            string maNM = (cbTenNM.SelectedItem as MTNguoiMuon).MaNguoiMuon;
            string maCS = (cbMaCuonSach.SelectedItem as MTCuonSach).MaCuonSach;
            DateTime NgayMuon = dtpNgayMuon.Value;
            DateTime NgayTra = dtpNgayTra.Value;
            if(SuaMuonTra.Instance.SuaMT(maNM,maCS,NgayMuon,NgayTra)==true)
            {
                MessageBox.Show("Sửa thành công", "Thông Báo");
                LoadDSMuonTra();
            }
            else MessageBox.Show("Có lỗi khi sửa mượn trả!", "Thông Báo");
        }

        private void btnXoaMT_Click(object sender, EventArgs e)
        {
            string maNM = (cbTenNM.SelectedItem as MTNguoiMuon).MaNguoiMuon;
            string maCS = (cbMaCuonSach.SelectedItem as MTCuonSach).MaCuonSach;
            if (MessageBox.Show("Bạn có thực sự muốn xóa?", "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                if (XoaMuonTra.Instance.XoaMT(maNM, maCS) == true)
                {
                    MessageBox.Show("Xóa thành công", "Thông Báo");
                    RefreshText();
                    LoadDSMuonTra();
                }
                else MessageBox.Show("Có lỗi khi Xóa mượn trả!", "Thông Báo");
            }
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            RefreshText();
            LoadDSMuonTra();
        }

        private void btnTimKiemMT_Click(object sender, EventArgs e)
        {
            string maTK = txtTimKiemMT.Text;
            string cbTim = cbTimKiemMT.SelectedItem.ToString();

            if (cbTimKiemMT.Text == "")
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
                    dgvMuonTra.DataSource = TimKiemMuonTra.Instance.TkMTTheoTatCa(maTK);
                    if (TimKiemMuonTra.Instance.CheckTkMTTheoTatCa(maTK) == false)
                        MessageBox.Show("Không tìm thấy kết quả nào!", "Thông báo");
                }

                if (cbTim == "Tên người mượn")
                {
                    dgvMuonTra.DataSource = TimKiemMuonTra.Instance.TkMTTheoTenNM(maTK);
                    if (TimKiemMuonTra.Instance.CheckTkMTTheoTenNM(maTK) == false)
                        MessageBox.Show("Không tìm thấy kết quả nào!", "Thông báo");
                }

                if (cbTim == "Mã cuốn sách")
                {
                    dgvMuonTra.DataSource = TimKiemMuonTra.Instance.TkMTTheoMaCS(maTK);
                    if (TimKiemMuonTra.Instance.CheckTkMTTheoMaCS(maTK) == false)
                        MessageBox.Show("Không tìm thấy kết quả nào!", "Thông báo");
                }

                if (cbTim == "Ngày mượn")
                {
                    dgvMuonTra.DataSource = TimKiemMuonTra.Instance.TkMTTheoNgayMuon(maTK);
                    if (TimKiemMuonTra.Instance.CheckTkMTTheoNgayMuon(maTK) == false)
                        MessageBox.Show("Không tìm thấy kết quả nào!", "Thông báo");
                }

                if (cbTim == "Ngày trả")
                {
                    dgvMuonTra.DataSource = TimKiemMuonTra.Instance.TkMTTheoNgayTra(maTK);
                    if (TimKiemMuonTra.Instance.CheckTkMTTheoNgayTra(maTK) == false)
                        MessageBox.Show("Không tìm thấy kết quả nào!", "Thông báo");
                }
            }
        }
    }
}
