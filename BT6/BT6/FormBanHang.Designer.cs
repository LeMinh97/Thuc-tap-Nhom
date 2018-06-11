namespace BT6
{
    partial class FormBanHang
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
            this.components = new System.ComponentModel.Container();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.dgvBanHang = new System.Windows.Forms.DataGridView();
            this.maDonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhTienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTHoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.banHangDBDataHoaDon = new BT6.BanHangDBDataHoaDon();
            this.cTHoaDonTableAdapter = new BT6.BanHangDBDataHoaDonTableAdapters.CTHoaDonTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDon = new System.Windows.Forms.TextBox();
            this.TxtTien = new System.Windows.Forms.TextBox();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.btnMoi = new System.Windows.Forms.Button();
            this.txtTong = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTHoaDonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banHangDBDataHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(489, 31);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.Location = new System.Drawing.Point(489, 98);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(75, 23);
            this.btnTinhTien.TabIndex = 1;
            this.btnTinhTien.Text = "Tính Tiền";
            this.btnTinhTien.UseVisualStyleBackColor = true;
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
            // 
            // dgvBanHang
            // 
            this.dgvBanHang.AutoGenerateColumns = false;
            this.dgvBanHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBanHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maDonDataGridViewTextBoxColumn,
            this.tenSPDataGridViewTextBoxColumn,
            this.giaDataGridViewTextBoxColumn,
            this.soLuongDataGridViewTextBoxColumn,
            this.thanhTienDataGridViewTextBoxColumn});
            this.dgvBanHang.DataSource = this.cTHoaDonBindingSource;
            this.dgvBanHang.Location = new System.Drawing.Point(13, 230);
            this.dgvBanHang.Name = "dgvBanHang";
            this.dgvBanHang.Size = new System.Drawing.Size(786, 220);
            this.dgvBanHang.TabIndex = 2;
            // 
            // maDonDataGridViewTextBoxColumn
            // 
            this.maDonDataGridViewTextBoxColumn.DataPropertyName = "MaDon";
            this.maDonDataGridViewTextBoxColumn.HeaderText = "MaDon";
            this.maDonDataGridViewTextBoxColumn.Name = "maDonDataGridViewTextBoxColumn";
            // 
            // tenSPDataGridViewTextBoxColumn
            // 
            this.tenSPDataGridViewTextBoxColumn.DataPropertyName = "TenSP";
            this.tenSPDataGridViewTextBoxColumn.HeaderText = "TenSP";
            this.tenSPDataGridViewTextBoxColumn.Name = "tenSPDataGridViewTextBoxColumn";
            // 
            // giaDataGridViewTextBoxColumn
            // 
            this.giaDataGridViewTextBoxColumn.DataPropertyName = "Gia";
            this.giaDataGridViewTextBoxColumn.HeaderText = "Gia";
            this.giaDataGridViewTextBoxColumn.Name = "giaDataGridViewTextBoxColumn";
            // 
            // soLuongDataGridViewTextBoxColumn
            // 
            this.soLuongDataGridViewTextBoxColumn.DataPropertyName = "SoLuong";
            this.soLuongDataGridViewTextBoxColumn.HeaderText = "SoLuong";
            this.soLuongDataGridViewTextBoxColumn.Name = "soLuongDataGridViewTextBoxColumn";
            // 
            // thanhTienDataGridViewTextBoxColumn
            // 
            this.thanhTienDataGridViewTextBoxColumn.DataPropertyName = "ThanhTien";
            this.thanhTienDataGridViewTextBoxColumn.HeaderText = "ThanhTien";
            this.thanhTienDataGridViewTextBoxColumn.Name = "thanhTienDataGridViewTextBoxColumn";
            // 
            // cTHoaDonBindingSource
            // 
            this.cTHoaDonBindingSource.DataMember = "CTHoaDon";
            this.cTHoaDonBindingSource.DataSource = this.banHangDBDataHoaDon;
            // 
            // banHangDBDataHoaDon
            // 
            this.banHangDBDataHoaDon.DataSetName = "BanHangDBDataHoaDon";
            this.banHangDBDataHoaDon.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cTHoaDonTableAdapter
            // 
            this.cTHoaDonTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã Đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Giá";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tiền";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Số Lượng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tên SP";
            // 
            // txtDon
            // 
            this.txtDon.Location = new System.Drawing.Point(69, 17);
            this.txtDon.Name = "txtDon";
            this.txtDon.Size = new System.Drawing.Size(219, 20);
            this.txtDon.TabIndex = 8;
            // 
            // TxtTien
            // 
            this.TxtTien.Location = new System.Drawing.Point(69, 179);
            this.TxtTien.Name = "TxtTien";
            this.TxtTien.Size = new System.Drawing.Size(219, 20);
            this.TxtTien.TabIndex = 9;
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(69, 135);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(219, 20);
            this.txtSL.TabIndex = 10;
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(69, 96);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(219, 20);
            this.txtGia.TabIndex = 11;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(69, 55);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(219, 20);
            this.txtTenSP.TabIndex = 12;
            // 
            // btnMoi
            // 
            this.btnMoi.Location = new System.Drawing.Point(489, 182);
            this.btnMoi.Name = "btnMoi";
            this.btnMoi.Size = new System.Drawing.Size(75, 23);
            this.btnMoi.TabIndex = 13;
            this.btnMoi.Text = "Xóa";
            this.btnMoi.UseVisualStyleBackColor = true;
            this.btnMoi.Click += new System.EventHandler(this.btnMoi_Click);
            // 
            // txtTong
            // 
            this.txtTong.Location = new System.Drawing.Point(603, 100);
            this.txtTong.Name = "txtTong";
            this.txtTong.Size = new System.Drawing.Size(175, 20);
            this.txtTong.TabIndex = 14;
            // 
            // FormBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTong);
            this.Controls.Add(this.btnMoi);
            this.Controls.Add(this.txtTenSP);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.txtSL);
            this.Controls.Add(this.TxtTien);
            this.Controls.Add(this.txtDon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvBanHang);
            this.Controls.Add(this.btnTinhTien);
            this.Controls.Add(this.btnThem);
            this.Name = "FormBanHang";
            this.Text = "FormBanHang";
            this.Load += new System.EventHandler(this.FormBanHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTHoaDonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banHangDBDataHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.DataGridView dgvBanHang;
        private BanHangDBDataHoaDon banHangDBDataHoaDon;
        private System.Windows.Forms.BindingSource cTHoaDonBindingSource;
        private BanHangDBDataHoaDonTableAdapters.CTHoaDonTableAdapter cTHoaDonTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhTienDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDon;
        private System.Windows.Forms.TextBox TxtTien;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.Button btnMoi;
        private System.Windows.Forms.TextBox txtTong;
    }
}