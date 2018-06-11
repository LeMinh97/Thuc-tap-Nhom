using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Truong
{
    public partial class FormTTDG : Form
    {
        public FormTTDG()
        {
            InitializeComponent();
        }
        string strConn = @"Server=STCHIEN\SQLEXPRESS; Database=Truong; Integrated Security=True";
        SqlConnection conn;
        private void LoadData()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from ThongTinGiangDay", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvGD.DataSource = dt;
        }
        private void FormTTDG_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'truongDataSet.ThongTinGiangDay' table. You can move, or remove it, as needed.
            this.thongTinGiangDayTableAdapter.Fill(this.truongDataSet.ThongTinGiangDay);
            conn = new SqlConnection(strConn);
            conn.Open();
            LoadData();
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            string tenGV = txtTen.Text;
            string Lop = txtLop.Text;
            string SiSo = txtSiSo.Text;
            string Tiet = txtTiet.Text;
            string Ngay = txtNgay.Text;
            SqlDataAdapter da = new SqlDataAdapter("select * from ThongTinGiangDay where TenGV like N'%'+N'" + tenGV + "'+N'%' and Lop like N'%'+N'" + Lop + "'+N'%' and SiSo like N'%'+N'" + SiSo + "'+N'%' and Ngay like N'%'+N'" + Ngay + "'+N'%' and Tiet like N'%'+N'" + Tiet + "'+N'%'", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvGD.DataSource = dt;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Update1", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter p = new SqlParameter("@Ten", txtTen.Text);
            cmd.Parameters.Add(p);
            p = new SqlParameter("@Siso", txtSiSo.Text);
            cmd.Parameters.Add(p);
            p = new SqlParameter("@Lop", Convert.ToString(txtLop.Text));
            cmd.Parameters.Add(p);
            p = new SqlParameter("@Ngay", Convert.ToDateTime(txtNgay.Text));
            cmd.Parameters.Add(p);
            p = new SqlParameter("@Tiet", txtTiet.Text);
            cmd.Parameters.Add(p);
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
                MessageBox.Show("Thêm mới thành công");
            }
            else MessageBox.Show("Không thể thêm mới");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Add1", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter p = new SqlParameter("@Ten", txtTen.Text);
            cmd.Parameters.Add(p);
            p = new SqlParameter("@Siso", txtSiSo.Text);
            cmd.Parameters.Add(p);
            p = new SqlParameter("@Lop", Convert.ToString(txtLop.Text));
            cmd.Parameters.Add(p);
            p = new SqlParameter("@Ngay", Convert.ToDateTime(txtNgay.Text));
            cmd.Parameters.Add(p);
            p = new SqlParameter("@Tiet", txtTiet.Text);
            cmd.Parameters.Add(p);
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
                MessageBox.Show("Sửa Thành Công");
                LoadData();
            }
            else MessageBox.Show("Không sửa được!");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo",
   MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("Del1", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p = new SqlParameter("@Ten", txtTen.Text);
                cmd.Parameters.Add(p);
                int count = cmd.ExecuteNonQuery();
                if (count > 0)
                {
                    MessageBox.Show("Xóa thành công!");
                    LoadData();
                    txtTen.Text = "";
                    txtLop.Text = "";
                    txtSiSo.Text = "";
                    txtNgay.Text = "";
                    txtTiet.Text = "";
                }
                else MessageBox.Show("Không thể xóa bản ghi hiện thời!");
            }
        }

        private void btnLM_Click(object sender, EventArgs e)
        {
            txtTen.Text = "";
            txtLop.Text = "";
            txtSiSo.Text = "";
            txtNgay.Text = "";
            txtTiet.Text = "";
            LoadData();
        }
    }
}
