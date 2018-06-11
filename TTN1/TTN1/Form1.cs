using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTN1
{
    public partial class Form1 : Form
    {
        string strConn = @"Server=STCHIEN\SQLEXPRESS; Database=CongTy; Integrated Security=True";
        SqlConnection conn;

        public Form1()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from NhanVien", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvNhanVien.DataSource = dt;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(strConn);
            conn.Open();
            LoadData();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvNhanVien_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvNhanVien.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                txtMa.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["manv"].Value);
                txtTen.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["hoten"].Value);
                txtNgaySinh.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["ns"].Value);
                txtGT.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["gt"].Value);
                txtPhong.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["phong"].Value);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SP_ThemNhanVien", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter p = new SqlParameter("@Ma", txtMa.Text);
            cmd.Parameters.Add(p);
            p = new SqlParameter("@Ten", txtTen.Text);
            cmd.Parameters.Add(p);
            p = new SqlParameter("@NS", txtNgaySinh.Text);
            cmd.Parameters.Add(p);
            p = new SqlParameter("@GT", txtGT.Text);
            cmd.Parameters.Add(p);
            p = new SqlParameter("@Phong", txtPhong.Text);
            cmd.Parameters.Add(p);
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
                MessageBox.Show("Đã Thêm");
            }
            else
            {
                MessageBox.Show("Không Thể Thêm Mới");
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SP_SuaNhanVien", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter p = new SqlParameter("@Ma", txtMa.Text);
            cmd.Parameters.Add(p);
            p = new SqlParameter("@Ten", txtTen.Text);
            cmd.Parameters.Add(p);
            p = new SqlParameter("@NS", txtNgaySinh.Text);
            cmd.Parameters.Add(p);
            p = new SqlParameter("@GT", txtGT.Text);
            cmd.Parameters.Add(p);
            p = new SqlParameter("@Phong", txtPhong.Text);
            cmd.Parameters.Add(p);
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
                MessageBox.Show("Da sua thanh cong");
            }
            else
            {
                MessageBox.Show("Khong sua duoc");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo",
MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("SP_XoaNhanVien", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p = new SqlParameter("@Ma", txtMa.Text);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@Ten", txtTen.Text);
                cmd.Parameters.Add(p);
                int count = cmd.ExecuteNonQuery();
                if (count > 0)
                {
                    MessageBox.Show("Da Xoa thanh cong");
                    LoadData();
                    txtMa.Text = "";
                    txtTen.Text = "";
                }
                else
                {
                    MessageBox.Show("Khong xoa duoc");
                }
            }
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SP_TimNhanVien", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter p = new SqlParameter("@Ma", txtMa.Text);
            cmd.Parameters.Add(p);
            p = new SqlParameter("@Ten", txtTen.Text);
            cmd.Parameters.Add(p);
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
                MessageBox.Show("Da tim thanh cong");
            }
            else
            {
                MessageBox.Show("Khong tim duoc");
            }
        }
    }
}
