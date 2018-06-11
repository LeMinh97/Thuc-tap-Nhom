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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvXuat = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maPhieuXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenHang1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuong1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGiaXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnVeMenu = new System.Windows.Forms.Button();
            this.lbLai = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvNhap = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maPhieuNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.tpTonKho = new System.Windows.Forms.TabPage();
            this.cbSapXep = new System.Windows.Forms.ComboBox();
            this.btnSapXep = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThoat1 = new System.Windows.Forms.Button();
            this.btnVeMenu1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvTonKho = new System.Windows.Forms.DataGridView();
            this.STT2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenHang2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nganhHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuong2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtLai = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tpNhapXuat.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXuat)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhap)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tpTonKho.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTonKho)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpNhapXuat);
            this.tabControl1.Controls.Add(this.tpTonKho);
            this.tabControl1.Location = new System.Drawing.Point(2, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(746, 560);
            this.tabControl1.TabIndex = 0;
            // 
            // tpNhapXuat
            // 
            this.tpNhapXuat.Controls.Add(this.label3);
            this.tpNhapXuat.Controls.Add(this.txtLai);
            this.tpNhapXuat.Controls.Add(this.groupBox4);
            this.tpNhapXuat.Controls.Add(this.btnThoat);
            this.tpNhapXuat.Controls.Add(this.btnVeMenu);
            this.tpNhapXuat.Controls.Add(this.lbLai);
            this.tpNhapXuat.Controls.Add(this.groupBox2);
            this.tpNhapXuat.Controls.Add(this.groupBox1);
            this.tpNhapXuat.Location = new System.Drawing.Point(4, 22);
            this.tpNhapXuat.Name = "tpNhapXuat";
            this.tpNhapXuat.Padding = new System.Windows.Forms.Padding(3);
            this.tpNhapXuat.Size = new System.Drawing.Size(738, 534);
            this.tpNhapXuat.TabIndex = 0;
            this.tpNhapXuat.Text = "Nhập- Xuất";
            this.tpNhapXuat.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvXuat);
            this.groupBox4.Location = new System.Drawing.Point(4, 262);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(728, 184);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông tin Xuất";
            // 
            // dgvXuat
            // 
            this.dgvXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvXuat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.maPhieuXuat,
            this.ngayXuat,
            this.tenHang1,
            this.tenKH,
            this.soLuong1,
            this.donGiaXuat});
            this.dgvXuat.Location = new System.Drawing.Point(7, 20);
            this.dgvXuat.Name = "dgvXuat";
            this.dgvXuat.Size = new System.Drawing.Size(715, 154);
            this.dgvXuat.TabIndex = 0;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.Width = 50;
            // 
            // maPhieuXuat
            // 
            this.maPhieuXuat.DataPropertyName = "MaPhieuXuat";
            this.maPhieuXuat.HeaderText = "Mã phiếu xuất";
            this.maPhieuXuat.Name = "maPhieuXuat";
            this.maPhieuXuat.Width = 92;
            // 
            // ngayXuat
            // 
            this.ngayXuat.DataPropertyName = "NgayXuat";
            this.ngayXuat.HeaderText = "Ngày xuất";
            this.ngayXuat.Name = "ngayXuat";
            this.ngayXuat.Width = 120;
            // 
            // tenHang1
            // 
            this.tenHang1.DataPropertyName = "TenHang";
            this.tenHang1.HeaderText = "Tên hàng";
            this.tenHang1.Name = "tenHang1";
            this.tenHang1.Width = 120;
            // 
            // tenKH
            // 
            this.tenKH.DataPropertyName = "TenKH";
            this.tenKH.HeaderText = "Tên khách hàng";
            this.tenKH.Name = "tenKH";
            this.tenKH.Width = 120;
            // 
            // soLuong1
            // 
            this.soLuong1.DataPropertyName = "SoLuong";
            this.soLuong1.HeaderText = "Số lượng";
            this.soLuong1.Name = "soLuong1";
            this.soLuong1.Width = 70;
            // 
            // donGiaXuat
            // 
            this.donGiaXuat.DataPropertyName = "DonGiaXuat";
            this.donGiaXuat.HeaderText = "Đơn giá xuất";
            this.donGiaXuat.Name = "donGiaXuat";
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThoat.Location = new System.Drawing.Point(629, 452);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(80, 55);
            this.btnThoat.TabIndex = 12;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnVeMenu
            // 
            this.btnVeMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVeMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnVeMenu.Image")));
            this.btnVeMenu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVeMenu.Location = new System.Drawing.Point(534, 452);
            this.btnVeMenu.Name = "btnVeMenu";
            this.btnVeMenu.Size = new System.Drawing.Size(80, 55);
            this.btnVeMenu.TabIndex = 11;
            this.btnVeMenu.Text = "Về Menu";
            this.btnVeMenu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVeMenu.UseVisualStyleBackColor = true;
            this.btnVeMenu.Click += new System.EventHandler(this.btnVeMenu_Click);
            // 
            // lbLai
            // 
            this.lbLai.AutoSize = true;
            this.lbLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLai.Location = new System.Drawing.Point(21, 468);
            this.lbLai.Name = "lbLai";
            this.lbLai.Size = new System.Drawing.Size(37, 16);
            this.lbLai.TabIndex = 2;
            this.lbLai.Text = "Lãi: ";
            this.lbLai.Click += new System.EventHandler(this.lbLai_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvNhap);
            this.groupBox2.Location = new System.Drawing.Point(4, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(728, 183);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin Nhập";
            // 
            // dgvNhap
            // 
            this.dgvNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.maPhieuNhap,
            this.ngayNhap,
            this.tenNCC,
            this.tenHang,
            this.soLuong,
            this.donGiaNhap});
            this.dgvNhap.Location = new System.Drawing.Point(7, 20);
            this.dgvNhap.Name = "dgvNhap";
            this.dgvNhap.Size = new System.Drawing.Size(715, 154);
            this.dgvNhap.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "STT";
            this.Column1.HeaderText = "STT";
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // maPhieuNhap
            // 
            this.maPhieuNhap.DataPropertyName = "MaPhieuNhap";
            this.maPhieuNhap.HeaderText = "Mã phiếu nhập";
            this.maPhieuNhap.Name = "maPhieuNhap";
            this.maPhieuNhap.Width = 92;
            // 
            // ngayNhap
            // 
            this.ngayNhap.DataPropertyName = "NgayNhap";
            this.ngayNhap.HeaderText = "Ngày nhập";
            this.ngayNhap.Name = "ngayNhap";
            this.ngayNhap.Width = 120;
            // 
            // tenNCC
            // 
            this.tenNCC.DataPropertyName = "TenNCC";
            this.tenNCC.HeaderText = "Tên nhà cung cấp";
            this.tenNCC.Name = "tenNCC";
            this.tenNCC.Width = 120;
            // 
            // tenHang
            // 
            this.tenHang.DataPropertyName = "TenHang";
            this.tenHang.HeaderText = "Tên hàng";
            this.tenHang.Name = "tenHang";
            this.tenHang.Width = 120;
            // 
            // soLuong
            // 
            this.soLuong.DataPropertyName = "SoLuong";
            this.soLuong.HeaderText = "Số lượng";
            this.soLuong.Name = "soLuong";
            this.soLuong.Width = 70;
            // 
            // donGiaNhap
            // 
            this.donGiaNhap.DataPropertyName = "DonGiaNhap";
            this.donGiaNhap.HeaderText = "Đơn giá nhập";
            this.donGiaNhap.Name = "donGiaNhap";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThongKe);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpNgayKetThuc);
            this.groupBox1.Controls.Add(this.dtpNgayBatDau);
            this.groupBox1.Location = new System.Drawing.Point(4, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(728, 77);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Khoảng thời gian";
            // 
            // btnThongKe
            // 
            this.btnThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.Image = ((System.Drawing.Image)(resources.GetObject("btnThongKe.Image")));
            this.btnThongKe.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThongKe.Location = new System.Drawing.Point(625, 15);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(80, 55);
            this.btnThongKe.TabIndex = 12;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(255, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Đến ngày";
            // 
            // dtpNgayKetThuc
            // 
            this.dtpNgayKetThuc.Location = new System.Drawing.Point(359, 36);
            this.dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            this.dtpNgayKetThuc.Size = new System.Drawing.Size(200, 20);
            this.dtpNgayKetThuc.TabIndex = 1;
            // 
            // dtpNgayBatDau
            // 
            this.dtpNgayBatDau.Location = new System.Drawing.Point(20, 36);
            this.dtpNgayBatDau.Name = "dtpNgayBatDau";
            this.dtpNgayBatDau.Size = new System.Drawing.Size(200, 20);
            this.dtpNgayBatDau.TabIndex = 0;
            // 
            // tpTonKho
            // 
            this.tpTonKho.Controls.Add(this.cbSapXep);
            this.tpTonKho.Controls.Add(this.btnSapXep);
            this.tpTonKho.Controls.Add(this.label2);
            this.tpTonKho.Controls.Add(this.btnThoat1);
            this.tpTonKho.Controls.Add(this.btnVeMenu1);
            this.tpTonKho.Controls.Add(this.groupBox3);
            this.tpTonKho.Location = new System.Drawing.Point(4, 22);
            this.tpTonKho.Name = "tpTonKho";
            this.tpTonKho.Padding = new System.Windows.Forms.Padding(3);
            this.tpTonKho.Size = new System.Drawing.Size(738, 534);
            this.tpTonKho.TabIndex = 1;
            this.tpTonKho.Text = "Tồn kho";
            this.tpTonKho.UseVisualStyleBackColor = true;
            // 
            // cbSapXep
            // 
            this.cbSapXep.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbSapXep.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbSapXep.FormattingEnabled = true;
            this.cbSapXep.Items.AddRange(new object[] {
            "Số lượng từ cao đến thấp",
            "Số lượng từ thấp đến cao",
            "Ngành hàng"});
            this.cbSapXep.Location = new System.Drawing.Point(376, 41);
            this.cbSapXep.Name = "cbSapXep";
            this.cbSapXep.Size = new System.Drawing.Size(184, 21);
            this.cbSapXep.TabIndex = 17;
            // 
            // btnSapXep
            // 
            this.btnSapXep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSapXep.Image = ((System.Drawing.Image)(resources.GetObject("btnSapXep.Image")));
            this.btnSapXep.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSapXep.Location = new System.Drawing.Point(592, 18);
            this.btnSapXep.Name = "btnSapXep";
            this.btnSapXep.Size = new System.Drawing.Size(80, 55);
            this.btnSapXep.TabIndex = 16;
            this.btnSapXep.Text = "Sắp xếp";
            this.btnSapXep.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSapXep.UseVisualStyleBackColor = true;
            this.btnSapXep.Click += new System.EventHandler(this.btnSapXep_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(159, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Sắp xếp hàng hóa tồn kho theo: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnThoat1
            // 
            this.btnThoat1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat1.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat1.Image")));
            this.btnThoat1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThoat1.Location = new System.Drawing.Point(592, 439);
            this.btnThoat1.Name = "btnThoat1";
            this.btnThoat1.Size = new System.Drawing.Size(80, 55);
            this.btnThoat1.TabIndex = 13;
            this.btnThoat1.Text = "Thoát";
            this.btnThoat1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThoat1.UseVisualStyleBackColor = true;
            this.btnThoat1.Click += new System.EventHandler(this.btnThoat1_Click);
            // 
            // btnVeMenu1
            // 
            this.btnVeMenu1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVeMenu1.Image = ((System.Drawing.Image)(resources.GetObject("btnVeMenu1.Image")));
            this.btnVeMenu1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVeMenu1.Location = new System.Drawing.Point(480, 439);
            this.btnVeMenu1.Name = "btnVeMenu1";
            this.btnVeMenu1.Size = new System.Drawing.Size(80, 55);
            this.btnVeMenu1.TabIndex = 12;
            this.btnVeMenu1.Text = "Về Menu";
            this.btnVeMenu1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVeMenu1.UseVisualStyleBackColor = true;
            this.btnVeMenu1.Click += new System.EventHandler(this.btnVeMenu1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvTonKho);
            this.groupBox3.Location = new System.Drawing.Point(3, 89);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(731, 335);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin";
            // 
            // dgvTonKho
            // 
            this.dgvTonKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTonKho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT2,
            this.maHang,
            this.tenHang2,
            this.nganhHang,
            this.dvt,
            this.soLuong2});
            this.dgvTonKho.Location = new System.Drawing.Point(7, 20);
            this.dgvTonKho.Name = "dgvTonKho";
            this.dgvTonKho.Size = new System.Drawing.Size(718, 300);
            this.dgvTonKho.TabIndex = 0;
            // 
            // STT2
            // 
            this.STT2.HeaderText = "STT";
            this.STT2.Name = "STT2";
            this.STT2.Width = 75;
            // 
            // maHang
            // 
            this.maHang.DataPropertyName = "MaHang";
            this.maHang.HeaderText = "Mã hàng";
            this.maHang.Name = "maHang";
            // 
            // tenHang2
            // 
            this.tenHang2.DataPropertyName = "TenHang";
            this.tenHang2.HeaderText = "Tên hàng";
            this.tenHang2.Name = "tenHang2";
            this.tenHang2.Width = 150;
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
            // soLuong2
            // 
            this.soLuong2.DataPropertyName = "SoLuong";
            this.soLuong2.HeaderText = "Số lượng tồn kho";
            this.soLuong2.Name = "soLuong2";
            // 
            // txtLai
            // 
            this.txtLai.Location = new System.Drawing.Point(55, 467);
            this.txtLai.Name = "txtLai";
            this.txtLai.Size = new System.Drawing.Size(100, 20);
            this.txtLai.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 470);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "VND";
            // 
            // fr_ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 550);
            this.Controls.Add(this.tabControl1);
            this.Name = "fr_ThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê";
            this.tabControl1.ResumeLayout(false);
            this.tpNhapXuat.ResumeLayout(false);
            this.tpNhapXuat.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvXuat)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhap)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tpTonKho.ResumeLayout(false);
            this.tpTonKho.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTonKho)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpNhapXuat;
        private System.Windows.Forms.Label lbLai;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvNhap;
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
        private System.Windows.Forms.DataGridView dgvTonKho;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnSapXep;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT2;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenHang2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nganhHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvt;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuong2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPhieuNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGiaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPhieuXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenHang1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuong1;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGiaXuat;
        private System.Windows.Forms.ComboBox cbSapXep;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLai;
    }
}