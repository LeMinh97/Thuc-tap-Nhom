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
    public partial class fr_NguoiDoc : Form
    {
        private TaiKhoan tkDangNhap;

        public TaiKhoan TkDangNhap
        {
            get { return tkDangNhap; }
            set { tkDangNhap = value; }
        }
        public fr_NguoiDoc(TaiKhoan TKDN)
        {
            InitializeComponent();
            this.TkDangNhap = TKDN;
            LoadDSNguoiDoc();
        }

        void LoadDSNguoiDoc()
        {
            string query = "SELECT * FROM dbo.NguoiDoc";
            dgvNguoiDoc.DataSource = DataProvider.Instance.ExcuteQuery(query);
        }

        void RefreshText()
        {
            txtMaND.Text = "";
            txtTenND.Text = "";
            txtDiaChiND.Text = "";
            txtSdtND.Text = "";
            txtTimKiemND.Text = "";
            cbTimKiemND.ResetText();
        }
        
        private void dgvNguoiDoc_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvNguoiDoc.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        private void btnThemND_Click(object sender, EventArgs e)
        {
            string maND = txtMaND.Text;
            string tenND = txtTenND.Text;
            string diaChi = txtDiaChiND.Text;
            string sdt = txtSdtND.Text;
            if(maND=="")
            {
                MessageBox.Show("Bạn chưa nhập Mã người đọc!", "Thông báo");
            }else if(tenND=="")
            {
                MessageBox.Show("Bạn chưa nhập Tên người đọc!", "Thông báo");
            }else if(diaChi=="")
            {
                MessageBox.Show("Bạn chưa nhập Địa chỉ!", "Thông báo");
            }
            else if (sdt == "")
            {
                MessageBox.Show("Bạn chưa nhập SDT!", "Thông báo");
            }
            else
            {
                if (ThemDocGia.Instance.ThemND(maND, tenND, diaChi, sdt) == true)
                {
                    MessageBox.Show("Thêm thành công", "Thông Báo");
                    LoadDSNguoiDoc();
                }
                else MessageBox.Show("Có lỗi khi thêm người đọc!", "Thông Báo");
            }
        }

        private void btnSuaND_Click(object sender, EventArgs e)
        {
            string maND = txtMaND.Text;
            string tenND = txtTenND.Text;
            string diaChi = txtDiaChiND.Text;
            string sdt = txtSdtND.Text;
            if (SuaDocGia.Instance.SuaND(maND,tenND,diaChi,sdt) == true)
            {
                MessageBox.Show("Sửa thành công", "Thông Báo");
                LoadDSNguoiDoc();
            }
            else MessageBox.Show("Có lỗi khi sửa người đọc!", "Thông Báo");
        }

        private void btnXoaND_Click(object sender, EventArgs e)
        {
            string maND = txtMaND.Text;
            if (MessageBox.Show("Bạn có thực sự muốn xóa?", "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                if (XoaDocGia.Instance.XoaND(maND) == true)
                {
                    MessageBox.Show("Xóa thành công", "Thông Báo");
                    RefreshText();
                    LoadDSNguoiDoc();
                }
                else MessageBox.Show("Có lỗi khi xóa người đọc!", "Thông Báo");
            }
        }

        private void btnThoatND_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát", "Thông Báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnTimKiemND_Click(object sender, EventArgs e)
        {
            string maTK = txtTimKiemND.Text;
            string cbTim = cbTimKiemND.SelectedItem.ToString();
            if (cbTimKiemND.Text==null)
            {
                MessageBox.Show("Bạn chưa chọn gì từ ComboBox!", "Thông báo");
            }
            else if (maTK=="")
            {
                MessageBox.Show("Bạn chưa nhập gì cả!", "Thông báo");
            }
            else
            {
                if (cbTim == "Tất cả")
                {
                    dgvNguoiDoc.DataSource = TimKiemDocGia.Instance.TkTatCa(maTK);
                    if(TimKiemDocGia.Instance.CheckTkTatCa(maTK)==false)
                        MessageBox.Show("Không tìm thấy kết quả nào!", "Thông báo");
                }

                if (cbTim == "Mã người đọc")
                {
                    dgvNguoiDoc.DataSource = TimKiemDocGia.Instance.TkMaND(maTK);
                    if (TimKiemDocGia.Instance.CheckTkMaND(maTK) == false)
                        MessageBox.Show("Không tìm thấy kết quả nào!", "Thông báo");
                }

                if (cbTim == "Tên người đọc")
                {
                    dgvNguoiDoc.DataSource = TimKiemDocGia.Instance.TkTenND(maTK);
                    if(TimKiemDocGia.Instance.CheckTkTenND(maTK)==false)
                        MessageBox.Show("Không tìm thấy kết quả nào!", "Thông báo");
                }

                if (cbTim == "Địa chỉ")
                {
                    dgvNguoiDoc.DataSource = TimKiemDocGia.Instance.TkDiaChi(maTK);
                    if(TimKiemDocGia.Instance.CheckTkDiaChi(maTK)==false)
                        MessageBox.Show("Không tìm thấy kết quả nào!", "Thông báo");
                }

                if (cbTim == "SDT")
                {
                    dgvNguoiDoc.DataSource = TimKiemDocGia.Instance.TkSDT(maTK);
                    if(TimKiemDocGia.Instance.CheckTkSDT(maTK)==false)
                        MessageBox.Show("Không tìm thấy kết quả nào!", "Thông báo");
                }
            }   
        }

        private void dgvNguoiDoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0&&e.ColumnIndex>=0)
            {
                txtMaND.Text = Convert.ToString(dgvNguoiDoc.CurrentRow.Cells["MaND"].Value);
                txtTenND.Text = Convert.ToString(dgvNguoiDoc.CurrentRow.Cells["TenND"].Value);
                txtDiaChiND.Text = Convert.ToString(dgvNguoiDoc.CurrentRow.Cells["DC"].Value);
                txtSdtND.Text = Convert.ToString(dgvNguoiDoc.CurrentRow.Cells["SDT"].Value);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadDSNguoiDoc();
            RefreshText();
        }

        private void btnVeMenu_Click(object sender, EventArgs e)
        {
            fr_Main f = new fr_Main(TkDangNhap);
            this.Hide();
            f.Show();
        }

        private void cbTimKiemND_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
