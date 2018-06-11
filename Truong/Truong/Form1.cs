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
    public partial class FormHS : Form
    {
        public FormHS()
        {
            InitializeComponent();
        }
        string strConn = @"Server=STCHIEN\SQLEXPRESS; Database=Truong; Integrated Security=True";
        SqlConnection conn;
        private void LoadData()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from HocSinh", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvHocSinh.DataSource = dt;
        }
        private void FormHS_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(strConn);
            conn.Open();
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("ThemHS", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter p = new SqlParameter("@Ma", txtMa.Text);
            cmd.Parameters.Add(p);
            p = new SqlParameter("@Ten", Convert.ToString(txtTen.Text));
            cmd.Parameters.Add(p);
            p = new SqlParameter("@Lop", Convert.ToString(txtLop.Text));
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
            SqlCommand cmd = new SqlCommand("SuaHS", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter p = new SqlParameter("@Ma", txtMa.Text);
            cmd.Parameters.Add(p);
            p = new SqlParameter("@Ten", txtTen.Text);
            cmd.Parameters.Add(p);
            p = new SqlParameter("@Lop", txtLop.Text);
            cmd.Parameters.Add(p);
            int count = cmd.ExecuteNonQuery();
            if (count >= 0)
            {
                MessageBox.Show("Sửa thành công!");
                LoadData();
            }
            else MessageBox.Show("Không sửa được!");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo",
MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("XoaHS", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p = new SqlParameter("@Ma", txtMa.Text);
                cmd.Parameters.Add(p);
                int count = cmd.ExecuteNonQuery();
                if (count > 0)
                {
                    MessageBox.Show("Xóa thành công!");
                    LoadData();
                    txtMa.Text = "";
                    txtTen.Text = "";
                }
                else MessageBox.Show("Không thể xóa bản ghi hiện thời!");
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string Ma = txtMa.Text;
            string Ten = txtTen.Text;
            string Lop = txtLop.Text;
            SqlDataAdapter da = new SqlDataAdapter("select * from HocSinh where Maso like N'%'+N'" + Ma + "'+N'%' and Hoten like N'%'+N'" + Ten + "'+N'%' and Lop like N'%'+N'" + Lop + "'+N'%'", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvHocSinh.DataSource = dt;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtLop.Text = "";
            txtMa.Text = "";
            txtTen.Text = "";
            LoadData();
        }
    }
}
