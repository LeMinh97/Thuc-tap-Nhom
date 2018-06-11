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

namespace BT6
{
    public partial class FormKH : Form
    {
        public FormKH()
        {
            InitializeComponent();
        }
        string strConn = @"Server=STCHIEN\SQLEXPRESS; Database=BanHangDB; Integrated Security=True";
        SqlConnection conn;
        private void LoadData()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from KH", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void FormKH_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'banHangDBDataSet.KH' table. You can move, or remove it, as needed.
            this.kHTableAdapter1.Fill(this.banHangDBDataSet.KH);
            conn = new SqlConnection(strConn);
            conn.Open();
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("AddKH", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter p = new SqlParameter("@Ma", txtMa.Text);
            cmd.Parameters.Add(p);
            p = new SqlParameter("@Ten", txtTen.Text);
            cmd.Parameters.Add(p);
            p = new SqlParameter("@DC", txtDC.Text);
            cmd.Parameters.Add(p);
            p = new SqlParameter("@SDT", txtSDT.Text);
            cmd.Parameters.Add(p);
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
                MessageBox.Show("Thêm mới thành công");
                LoadData();
            }
            else MessageBox.Show("Không thể thêm mới");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("UpdateKH", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter p = new SqlParameter("@Ma", txtMa.Text);
            cmd.Parameters.Add(p);
            p = new SqlParameter("@Ten", txtTen.Text);
            cmd.Parameters.Add(p);
            p = new SqlParameter("@DC", txtDC.Text);
            cmd.Parameters.Add(p);
            p = new SqlParameter("@SDT", txtSDT.Text);
            cmd.Parameters.Add(p);
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
                MessageBox.Show("Sửa thành công");
                LoadData();
            }
            else MessageBox.Show("Không thể Sửa");
        }

        private void btnLm_Click(object sender, EventArgs e)
        {
            txtSDT.Text = "";
            txtTen.Text = "";
            txtMa.Text = "";
            txtDC.Text = "";
            LoadData();
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo",
MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("XoaKH", conn);
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

        private void BtnTK_Click(object sender, EventArgs e)
        {
            string ma = txtMa.Text;
            string ten = txtTen.Text;
            string DC = txtDC.Text;
            string sdt = txtSDT.Text;
            SqlDataAdapter da = new SqlDataAdapter("select * from KH where Ma like N'%'+N'" + ma + "'+N'%' and Ten like N'%'+N'" + ten + "'+N'%' and SDT like N'%'+N'" + sdt + "'+N'%' and Dc like N'%'+N'" + DC + "'+N'%'", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
