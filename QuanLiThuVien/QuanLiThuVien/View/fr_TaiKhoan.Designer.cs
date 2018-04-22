namespace QuanLiThuVien.View
{
    partial class fr_TaiKhoan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fr_TaiKhoan));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvTaiKhoan = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiTK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbLoaiTK = new System.Windows.Forms.ComboBox();
            this.txtSDT = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTenND = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTenDN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnVeMenu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoaTK = new System.Windows.Forms.Button();
            this.btnSuaTK = new System.Windows.Forms.Button();
            this.btnThemTK = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTimKiemTK = new System.Windows.Forms.TextBox();
            this.cbTimKiemTK = new System.Windows.Forms.ComboBox();
            this.btnTimKiemTK = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvTaiKhoan);
            this.groupBox4.Location = new System.Drawing.Point(4, 292);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(807, 223);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Bảnh thông tin";
            // 
            // dgvTaiKhoan
            // 
            this.dgvTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaiKhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.tenDN,
            this.TenND,
            this.matKhau,
            this.loaiTK});
            this.dgvTaiKhoan.Location = new System.Drawing.Point(7, 20);
            this.dgvTaiKhoan.Name = "dgvTaiKhoan";
            this.dgvTaiKhoan.Size = new System.Drawing.Size(794, 197);
            this.dgvTaiKhoan.TabIndex = 0;
            this.dgvTaiKhoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTaiKhoan_CellClick);
            this.dgvTaiKhoan.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvTaiKhoan_RowPrePaint);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            // 
            // tenDN
            // 
            this.tenDN.DataPropertyName = "TenDN";
            this.tenDN.HeaderText = "Tên đăng nhập";
            this.tenDN.Name = "tenDN";
            this.tenDN.Width = 200;
            // 
            // TenND
            // 
            this.TenND.DataPropertyName = "TenND";
            this.TenND.HeaderText = "Tên người dùng";
            this.TenND.Name = "TenND";
            this.TenND.Width = 200;
            // 
            // matKhau
            // 
            this.matKhau.DataPropertyName = "MatKhau";
            this.matKhau.HeaderText = "Mật khẩu";
            this.matKhau.Name = "matKhau";
            this.matKhau.Width = 150;
            // 
            // loaiTK
            // 
            this.loaiTK.DataPropertyName = "LoaiTK";
            this.loaiTK.HeaderText = "Loại tài khoản";
            this.loaiTK.Name = "loaiTK";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(4, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 270);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin Tài khoản";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cbLoaiTK);
            this.panel4.Controls.Add(this.txtSDT);
            this.panel4.Location = new System.Drawing.Point(21, 197);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(341, 49);
            this.panel4.TabIndex = 3;
            // 
            // cbLoaiTK
            // 
            this.cbLoaiTK.FormattingEnabled = true;
            this.cbLoaiTK.Location = new System.Drawing.Point(118, 17);
            this.cbLoaiTK.Name = "cbLoaiTK";
            this.cbLoaiTK.Size = new System.Drawing.Size(189, 21);
            this.cbLoaiTK.TabIndex = 1;
            // 
            // txtSDT
            // 
            this.txtSDT.AutoSize = true;
            this.txtSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(21, 18);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(84, 15);
            this.txtSDT.TabIndex = 0;
            this.txtSDT.Text = "Loại tài khoản";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtMatKhau);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(21, 142);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(341, 49);
            this.panel3.TabIndex = 2;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(118, 15);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(189, 20);
            this.txtMatKhau.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mật khẩu";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtTenND);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(21, 87);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(341, 49);
            this.panel2.TabIndex = 1;
            // 
            // txtTenND
            // 
            this.txtTenND.Location = new System.Drawing.Point(118, 15);
            this.txtTenND.Name = "txtTenND";
            this.txtTenND.Size = new System.Drawing.Size(189, 20);
            this.txtTenND.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên người dùng";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTenDN);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(21, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 49);
            this.panel1.TabIndex = 0;
            // 
            // txtTenDN
            // 
            this.txtTenDN.Location = new System.Drawing.Point(118, 15);
            this.txtTenDN.Name = "txtTenDN";
            this.txtTenDN.Size = new System.Drawing.Size(189, 20);
            this.txtTenDN.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLamMoi);
            this.groupBox2.Controls.Add(this.btnVeMenu);
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.btnXoaTK);
            this.groupBox2.Controls.Add(this.btnSuaTK);
            this.groupBox2.Controls.Add(this.btnThemTK);
            this.groupBox2.Location = new System.Drawing.Point(391, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(420, 175);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.Image = ((System.Drawing.Image)(resources.GetObject("btnLamMoi.Image")));
            this.btnLamMoi.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLamMoi.Location = new System.Drawing.Point(113, 102);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(80, 55);
            this.btnLamMoi.TabIndex = 7;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnVeMenu
            // 
            this.btnVeMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVeMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnVeMenu.Image")));
            this.btnVeMenu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVeMenu.Location = new System.Drawing.Point(321, 26);
            this.btnVeMenu.Name = "btnVeMenu";
            this.btnVeMenu.Size = new System.Drawing.Size(80, 55);
            this.btnVeMenu.TabIndex = 6;
            this.btnVeMenu.Text = "Về Menu";
            this.btnVeMenu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVeMenu.UseVisualStyleBackColor = true;
            this.btnVeMenu.Click += new System.EventHandler(this.btnVeMenu_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThoat.Location = new System.Drawing.Point(321, 102);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(80, 55);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoatND_Click);
            // 
            // btnXoaTK
            // 
            this.btnXoaTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaTK.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaTK.Image")));
            this.btnXoaTK.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnXoaTK.Location = new System.Drawing.Point(16, 102);
            this.btnXoaTK.Name = "btnXoaTK";
            this.btnXoaTK.Size = new System.Drawing.Size(80, 55);
            this.btnXoaTK.TabIndex = 2;
            this.btnXoaTK.Text = "Xóa";
            this.btnXoaTK.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnXoaTK.UseVisualStyleBackColor = true;
            this.btnXoaTK.Click += new System.EventHandler(this.btnXoaTK_Click);
            // 
            // btnSuaTK
            // 
            this.btnSuaTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaTK.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaTK.Image")));
            this.btnSuaTK.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSuaTK.Location = new System.Drawing.Point(113, 26);
            this.btnSuaTK.Name = "btnSuaTK";
            this.btnSuaTK.Size = new System.Drawing.Size(80, 55);
            this.btnSuaTK.TabIndex = 1;
            this.btnSuaTK.Text = "Sửa";
            this.btnSuaTK.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSuaTK.UseVisualStyleBackColor = true;
            this.btnSuaTK.Click += new System.EventHandler(this.btnSuaTK_Click);
            // 
            // btnThemTK
            // 
            this.btnThemTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemTK.Image = ((System.Drawing.Image)(resources.GetObject("btnThemTK.Image")));
            this.btnThemTK.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThemTK.Location = new System.Drawing.Point(16, 26);
            this.btnThemTK.Name = "btnThemTK";
            this.btnThemTK.Size = new System.Drawing.Size(80, 55);
            this.btnThemTK.TabIndex = 0;
            this.btnThemTK.Text = "Thêm";
            this.btnThemTK.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThemTK.UseVisualStyleBackColor = true;
            this.btnThemTK.Click += new System.EventHandler(this.btnThemTK_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtTimKiemTK);
            this.groupBox3.Controls.Add(this.cbTimKiemTK);
            this.groupBox3.Controls.Add(this.btnTimKiemTK);
            this.groupBox3.Location = new System.Drawing.Point(391, 197);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(420, 89);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm";
            // 
            // txtTimKiemTK
            // 
            this.txtTimKiemTK.Location = new System.Drawing.Point(16, 43);
            this.txtTimKiemTK.Name = "txtTimKiemTK";
            this.txtTimKiemTK.Size = new System.Drawing.Size(165, 20);
            this.txtTimKiemTK.TabIndex = 2;
            // 
            // cbTimKiemTK
            // 
            this.cbTimKiemTK.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbTimKiemTK.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbTimKiemTK.FormattingEnabled = true;
            this.cbTimKiemTK.Items.AddRange(new object[] {
            "Tất cả",
            "Tên đăng nhập",
            "Tên người dùng",
            "Loại tài khoản"});
            this.cbTimKiemTK.Location = new System.Drawing.Point(187, 43);
            this.cbTimKiemTK.Name = "cbTimKiemTK";
            this.cbTimKiemTK.Size = new System.Drawing.Size(121, 21);
            this.cbTimKiemTK.TabIndex = 1;
            // 
            // btnTimKiemTK
            // 
            this.btnTimKiemTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemTK.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiemTK.Image")));
            this.btnTimKiemTK.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTimKiemTK.Location = new System.Drawing.Point(321, 19);
            this.btnTimKiemTK.Name = "btnTimKiemTK";
            this.btnTimKiemTK.Size = new System.Drawing.Size(80, 55);
            this.btnTimKiemTK.TabIndex = 0;
            this.btnTimKiemTK.Text = "Tìm kiếm";
            this.btnTimKiemTK.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTimKiemTK.UseVisualStyleBackColor = true;
            this.btnTimKiemTK.Click += new System.EventHandler(this.btnTimKiemTK_Click);
            // 
            // fr_TaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 518);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Name = "fr_TaiKhoan";
            this.Text = "Quản lí Tài Khoản";
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDN;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenND;
        private System.Windows.Forms.DataGridViewTextBoxColumn matKhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiTK;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label txtSDT;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtTenND;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTenDN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnVeMenu;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoaTK;
        private System.Windows.Forms.Button btnSuaTK;
        private System.Windows.Forms.Button btnThemTK;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtTimKiemTK;
        private System.Windows.Forms.ComboBox cbTimKiemTK;
        private System.Windows.Forms.Button btnTimKiemTK;
        private System.Windows.Forms.ComboBox cbLoaiTK;

    }
}