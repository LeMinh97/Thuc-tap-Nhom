namespace QuanLiKho.Views
{
    partial class fr_ThongKe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fr_ThongKe));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpNhapXuat = new System.Windows.Forms.TabPage();
            this.tpTonKho = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvNhapXuat = new System.Windows.Forms.DataGridView();
            this.lbLai = new System.Windows.Forms.Label();
            this.btnVeMenu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnVeMenu1 = new System.Windows.Forms.Button();
            this.btnThoat1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnSapXep = new System.Windows.Forms.Button();
            this.STT1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nganhHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tpNhapXuat.SuspendLayout();
            this.tpTonKho.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapXuat)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpNhapXuat);
            this.tabControl1.Controls.Add(this.tpTonKho);
            this.tabControl1.Location = new System.Drawing.Point(2, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(724, 457);
            this.tabControl1.TabIndex = 0;
            // 
            // tpNhapXuat
            // 
            this.tpNhapXuat.Controls.Add(this.btnThoat);
            this.tpNhapXuat.Controls.Add(this.btnVeMenu);
            this.tpNhapXuat.Controls.Add(this.lbLai);
            this.tpNhapXuat.Controls.Add(this.groupBox2);
            this.tpNhapXuat.Controls.Add(this.groupBox1);
            this.tpNhapXuat.Location = new System.Drawing.Point(4, 22);
            this.tpNhapXuat.Name = "tpNhapXuat";
            this.tpNhapXuat.Padding = new System.Windows.Forms.Padding(3);
            this.tpNhapXuat.Size = new System.Drawing.Size(716, 431);
            this.tpNhapXuat.TabIndex = 0;
            this.tpNhapXuat.Text = "Nhập- Xuất";
            this.tpNhapXuat.UseVisualStyleBackColor = true;
            // 
            // tpTonKho
            // 
            this.tpTonKho.Controls.Add(this.btnSapXep);
            this.tpTonKho.Controls.Add(this.comboBox1);
            this.tpTonKho.Controls.Add(this.label2);
            this.tpTonKho.Controls.Add(this.btnThoat1);
            this.tpTonKho.Controls.Add(this.btnVeMenu1);
            this.tpTonKho.Controls.Add(this.groupBox3);
            this.tpTonKho.Location = new System.Drawing.Point(4, 22);
            this.tpTonKho.Name = "tpTonKho";
            this.tpTonKho.Padding = new System.Windows.Forms.Padding(3);
            this.tpTonKho.Size = new System.Drawing.Size(716, 431);
            this.tpTonKho.TabIndex = 1;
            this.tpTonKho.Text = "Tồn kho";
            this.tpTonKho.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThongKe);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpNgayKetThuc);
            this.groupBox1.Controls.Add(this.dtpNgayBatDau);
            this.groupBox1.Location = new System.Drawing.Point(4, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(706, 71);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Khoảng thời gian";
            // 
            // dtpNgayBatDau
            // 
            this.dtpNgayBatDau.Location = new System.Drawing.Point(20, 36);
            this.dtpNgayBatDau.Name = "dtpNgayBatDau";
            this.dtpNgayBatDau.Size = new System.Drawing.Size(200, 20);
            this.dtpNgayBatDau.TabIndex = 0;
            // 
            // dtpNgayKetThuc
            // 
            this.dtpNgayKetThuc.Location = new System.Drawing.Point(359, 36);
            this.dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            this.dtpNgayKetThuc.Size = new System.Drawing.Size(200, 20);
            this.dtpNgayKetThuc.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(258, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Đến ngày";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvNhapXuat);
            this.groupBox2.Location = new System.Drawing.Point(3, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(706, 282);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin";
            // 
            // dgvNhapXuat
            // 
            this.dgvNhapXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhapXuat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgvNhapXuat.Location = new System.Drawing.Point(7, 20);
            this.dgvNhapXuat.Name = "dgvNhapXuat";
            this.dgvNhapXuat.Size = new System.Drawing.Size(693, 185);
            this.dgvNhapXuat.TabIndex = 0;
            // 
            // lbLai
            // 
            this.lbLai.AutoSize = true;
            this.lbLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLai.Location = new System.Drawing.Point(21, 383);
            this.lbLai.Name = "lbLai";
            this.lbLai.Size = new System.Drawing.Size(37, 16);
            this.lbLai.TabIndex = 2;
            this.lbLai.Text = "Lãi: ";
            // 
            // btnVeMenu
            // 
            this.btnVeMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVeMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnVeMenu.Image")));
            this.btnVeMenu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVeMenu.Location = new System.Drawing.Point(483, 370);
            this.btnVeMenu.Name = "btnVeMenu";
            this.btnVeMenu.Size = new System.Drawing.Size(80, 55);
            this.btnVeMenu.TabIndex = 11;
            this.btnVeMenu.Text = "Về Menu";
            this.btnVeMenu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVeMenu.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThoat.Location = new System.Drawing.Point(590, 370);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(80, 55);
            this.btnThoat.TabIndex = 12;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(4, 66);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(706, 263);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT1,
            this.maHang,
            this.tenHang,
            this.nganhHang,
            this.dvt,
            this.soLuong});
            this.dataGridView1.Location = new System.Drawing.Point(7, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(693, 237);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnVeMenu1
            // 
            this.btnVeMenu1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVeMenu1.Image = ((System.Drawing.Image)(resources.GetObject("btnVeMenu1.Image")));
            this.btnVeMenu1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVeMenu1.Location = new System.Drawing.Point(470, 360);
            this.btnVeMenu1.Name = "btnVeMenu1";
            this.btnVeMenu1.Size = new System.Drawing.Size(80, 55);
            this.btnVeMenu1.TabIndex = 12;
            this.btnVeMenu1.Text = "Về Menu";
            this.btnVeMenu1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVeMenu1.UseVisualStyleBackColor = true;
            // 
            // btnThoat1
            // 
            this.btnThoat1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat1.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat1.Image")));
            this.btnThoat1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThoat1.Location = new System.Drawing.Point(578, 360);
            this.btnThoat1.Name = "btnThoat1";
            this.btnThoat1.Size = new System.Drawing.Size(80, 55);
            this.btnThoat1.TabIndex = 13;
            this.btnThoat1.Text = "Thoát";
            this.btnThoat1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThoat1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(148, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Sắp xếp hàng hóa tồn kho theo: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Số lượng từ cao đến thấp",
            "Số lượng từ thấp đến cao",
            "Ngành hàng"});
            this.comboBox1.Location = new System.Drawing.Point(352, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(198, 24);
            this.comboBox1.TabIndex = 15;
            // 
            // btnThongKe
            // 
            this.btnThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.Image = ((System.Drawing.Image)(resources.GetObject("btnThongKe.Image")));
            this.btnThongKe.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThongKe.Location = new System.Drawing.Point(586, 15);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(80, 55);
            this.btnThongKe.TabIndex = 12;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThongKe.UseVisualStyleBackColor = true;
            // 
            // btnSapXep
            // 
            this.btnSapXep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSapXep.Image = ((System.Drawing.Image)(resources.GetObject("btnSapXep.Image")));
            this.btnSapXep.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSapXep.Location = new System.Drawing.Point(578, 6);
            this.btnSapXep.Name = "btnSapXep";
            this.btnSapXep.Size = new System.Drawing.Size(80, 55);
            this.btnSapXep.TabIndex = 16;
            this.btnSapXep.Text = "Sắp xếp";
            this.btnSapXep.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSapXep.UseVisualStyleBackColor = true;
            // 
            // STT1
            // 
            this.STT1.HeaderText = "STT";
            this.STT1.Name = "STT1";
            this.STT1.Width = 50;
            // 
            // maHang
            // 
            this.maHang.DataPropertyName = "MaHang";
            this.maHang.HeaderText = "Mã hàng";
            this.maHang.Name = "maHang";
            // 
            // tenHang
            // 
            this.tenHang.DataPropertyName = "TenHang";
            this.tenHang.HeaderText = "Tên hàng";
            this.tenHang.Name = "tenHang";
            this.tenHang.Width = 150;
            // 
            // nganhHang
            // 
            this.nganhHang.DataPropertyName = "NganhHang";
            this.nganhHang.HeaderText = "Ngành hàng";
            this.nganhHang.Name = "nganhHang";
            this.nganhHang.Width = 150;
            // 
            // dvt
            // 
            this.dvt.DataPropertyName = "DVT";
            this.dvt.HeaderText = "Đơn vị tính";
            this.dvt.Name = "dvt";
            // 
            // soLuong
            // 
            this.soLuong.DataPropertyName = "SoLuong";
            this.soLuong.HeaderText = "Số lượng tồn kho";
            this.soLuong.Name = "soLuong";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Column6";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Column7";
            this.Column7.Name = "Column7";
            // 
            // fr_ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 472);
            this.Controls.Add(this.tabControl1);
            this.Name = "fr_ThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê";
            this.tabControl1.ResumeLayout(false);
            this.tpNhapXuat.ResumeLayout(false);
            this.tpNhapXuat.PerformLayout();
            this.tpTonKho.ResumeLayout(false);
            this.tpTonKho.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapXuat)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpNhapXuat;
        private System.Windows.Forms.Label lbLai;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvNhapXuat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpNgayKetThuc;
        private System.Windows.Forms.DateTimePicker dtpNgayBatDau;
        private System.Windows.Forms.TabPage tpTonKho;
        private System.Windows.Forms.Button btnVeMenu;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnThoat1;
        private System.Windows.Forms.Button btnVeMenu1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnSapXep;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn nganhHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvt;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}