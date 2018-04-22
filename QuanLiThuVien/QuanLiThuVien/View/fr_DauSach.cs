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
    public partial class fr_DauSach : Form
    {
        private TaiKhoan tkDangNhap;

        public TaiKhoan TkDangNhap
        {
            get { return tkDangNhap; }
            set { tkDangNhap = value; }
        }
        public fr_DauSach(TaiKhoan TKDN)
        {
            InitializeComponent();
            this.TkDangNhap = TKDN;
            LoadCbBoxNhaXB();
            LoadCbBoxNhanh();
            RefreshText();
            LoadDSDauSach();
        }

        void LoadDSDauSach()
        {
            string query = "SELECT MaDauSach,TenDauSach,TheLoai,TenNXB,TenNhanh FROM dbo.DauSach,dbo.Nhanh,dbo.NhaXB WHERE dbo.DauSach.MaNhanh=dbo.Nhanh.MaNhanh AND dbo.DauSach.MaNhaXB=dbo.NhaXB.MaNXB";
            dgvDauSach.DataSource=DataProvider.Instance.ExcuteQuery(query);
        }

        void LoadCbBoxNhaXB()
        {
            List<DSNhaXB> listNXB = DSNhaXBDAO.Instance.LayDSNhaXB();
            cbNXB.DataSource = listNXB;
            cbNXB.DisplayMember = "TenNXB";
        }
        void LoadCbBoxNhanh()
        {
            List<DSNhanh> listNhanh = DSNhanhDAO.Instance.LayDSNhanh();
            cbNhanh.DataSource = listNhanh;
            cbNhanh.DisplayMember = "TenNhanh";
        }
        void RefreshText()
        {
            txtMaDS.Text = "";
            txtTenDS.Text = "";
            txtTheLoaiDS.Text = "";
            txtTimKiemDS.Text = "";
            cbNhanh.ResetText();
            cbNXB.ResetText();
            cbTimKiemDS.ResetText();
        }

        private void btnThoatDS_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát", "Thông Báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnVeMenu_Click(object sender, EventArgs e)
        {
            fr_Main f = new fr_Main(TkDangNhap);
            this.Hide();
            f.Show();
        }

        private void btnLamMoiDS_Click(object sender, EventArgs e)
        {
            RefreshText();
            LoadDSDauSach();
        }

        private void dgvDauSach_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvDauSach.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        private void dgvDauSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0&&e.ColumnIndex>=0)
            {
                txtMaDS.Text = Convert.ToString(dgvDauSach.CurrentRow.Cells["MaDS"].Value);
                txtTenDS.Text = Convert.ToString(dgvDauSach.CurrentRow.Cells["TenDS"].Value);
                txtTheLoaiDS.Text = Convert.ToString(dgvDauSach.CurrentRow.Cells["TheLoai"].Value);
                cbNXB.Text = Convert.ToString(dgvDauSach.CurrentRow.Cells["NXB"].Value);
                cbNhanh.Text = Convert.ToString(dgvDauSach.CurrentRow.Cells["Nhanh"].Value);
            }
        }

        private void btnThemDS_Click(object sender, EventArgs e)
        {
            string maDS = txtMaDS.Text;
            string tenDS = txtTenDS.Text;
            string theLoai = txtTheLoaiDS.Text;
            string maNXB = (cbNXB.SelectedItem as DSNhaXB).MaNXB;
            string maNhanh = (cbNhanh.SelectedItem as DSNhanh).MaNhanh;
            if (maDS == "")
            {
                MessageBox.Show("Bạn chưa nhập Mã đầu sách!", "Thông báo");
            }
            else if (tenDS == "")
            {
                MessageBox.Show("Bạn chưa nhập Tên đầu sách!", "Thông báo");
            }
            else if (theLoai == "")
            {
                MessageBox.Show("Bạn chưa nhập Thể loại!", "Thông báo");
            }
            else if (cbNXB.Text== null)
            {
                MessageBox.Show("Bạn chưa chọn NXB!", "Thông báo");
            }
            else if (cbNhanh.Text == null)
            {
                MessageBox.Show("Bạn chưa chọn Nhánh!", "Thông báo");
            }
            else
            {
                if (ThemDauSach.Instance.ThemDS(maDS,tenDS,theLoai, maNXB, maNhanh)== true)
                {
                    MessageBox.Show("Thêm thành công", "Thông Báo");
                    LoadDSDauSach();
                }
                else MessageBox.Show("Có lỗi khi thêm đầu sách!", "Thông Báo");
            }
        }

        private void btnSuaDS_Click(object sender, EventArgs e)
        {
            string maDS = txtMaDS.Text;
            string tenDS = txtTenDS.Text;
            string theLoai = txtTheLoaiDS.Text;
            string maNXB = (cbNXB.SelectedItem as DSNhaXB).MaNXB;
            string maNhanh = (cbNhanh.SelectedItem as DSNhanh).MaNhanh;
            if(SuaDauSach.Instance.SuaDS(maDS,tenDS,theLoai, maNXB, maNhanh)==true)
            {
                MessageBox.Show("Sửa thành công", "Thông Báo");
                LoadDSDauSach();
            }
            else MessageBox.Show("Có lỗi khi sửa đầu sách!", "Thông Báo");
        }

        private void btnXoaDS_Click(object sender, EventArgs e)
        {
            string maDS = txtMaDS.Text;
            if (MessageBox.Show("Bạn có thực sự muốn xóa?", "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                if (XoaDauSach.Instance.XoaDS(maDS) == true)
                {
                    MessageBox.Show("Xóa thành công", "Thông Báo");
                    RefreshText();
                    LoadDSDauSach();
                }
                else MessageBox.Show("Có lỗi khi xóa đầu sách!", "Thông Báo");
            }
        }

        private void btnTimKiemDS_Click(object sender, EventArgs e)
        {
            string maTK = txtTimKiemDS.Text;
            string cbTim = cbTimKiemDS.SelectedItem.ToString();

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
                    dgvDauSach.DataSource = TimKiemDauSach.Instance.TkDSTheoTatCa(maTK);
                    if (TimKiemDauSach.Instance.CheckTkDSTheoTatCa(maTK) == false)
                        MessageBox.Show("Không tìm thấy kết quả nào!", "Thông báo");
                }

                if (cbTim == "Mã đầu sách")
                {
                    dgvDauSach.DataSource = TimKiemDauSach.Instance.TkDSTheoMaDS(maTK);
                    if (TimKiemDauSach.Instance.CheckTkDSTheoMaDS(maTK) == false)
                        MessageBox.Show("Không tìm thấy kết quả nào!", "Thông báo");
                }

                if (cbTim == "Tên đầu sách")
                {
                    dgvDauSach.DataSource = TimKiemDauSach.Instance.TkDSTheoTenDS(maTK);
                    if (TimKiemDauSach.Instance.CheckTkDSTheoTenDS(maTK) == false)
                        MessageBox.Show("Không tìm thấy kết quả nào!", "Thông báo");
                }

                if (cbTim == "Thể loại")
                {
                    dgvDauSach.DataSource = TimKiemDauSach.Instance.TkDSTheoTheLoai(maTK);
                    if (TimKiemDauSach.Instance.CheckTkDSTheoTheLoai(maTK) == false)
                        MessageBox.Show("Không tìm thấy kết quả nào!", "Thông báo");
                }

                if (cbTim == "Nhà xuất bản")
                {
                    dgvDauSach.DataSource = TimKiemDauSach.Instance.TkDSTheoNhaXB(maTK);
                    if (TimKiemDauSach.Instance.CheckTkDSTheoNhaXB(maTK) == false)
                        MessageBox.Show("Không tìm thấy kết quả nào!", "Thông báo");
                }

                if (cbTim == "Nhánh lưu trữ")
                {
                    dgvDauSach.DataSource = TimKiemDauSach.Instance.TkDSTheoNhanh(maTK);
                    if (TimKiemDauSach.Instance.CheckTkDSTheoNhanh(maTK) == false)
                        MessageBox.Show("Không tìm thấy kết quả nào!", "Thông báo");
                }
            }
        }
    }
}
