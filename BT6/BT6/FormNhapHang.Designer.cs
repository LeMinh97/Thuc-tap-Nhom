namespace BT6
{
    partial class FormNhapHang
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.txtTien = new System.Windows.Forms.TextBox();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.txtNgay = new System.Windows.Forms.TextBox();
            this.txtPhieu = new System.Windows.Forms.TextBox();
            this.BtnNhap = new System.Windows.Forms.Button();
            this.dgvNhap = new System.Windows.Forms.DataGridView();
            this.maSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maPhieuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayNhapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongTienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTNhapHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.banHangDBDataSetNhap = new BT6.BanHangDBDataSetNhap();
            this.cTNhapHangTableAdapter = new BT6.BanHangDBDataSetNhapTableAdapters.CTNhapHangTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTNhapHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banHangDBDataSetNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã SP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tổng Tiền";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã Phiếu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số Lượng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày Nhập";
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(109, 12);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(136, 20);
            this.txtMaSP.TabIndex = 5;
            // 
            // txtTien
            // 
            this.txtTien.Location = new System.Drawing.Point(109, 175);
            this.txtTien.Name = "txtTien";
            this.txtTien.Size = new System.Drawing.Size(136, 20);
            this.txtTien.TabIndex = 6;
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(109, 139);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(136, 20);
            this.txtSL.TabIndex = 7;
            // 
            // txtNgay
            // 
            this.txtNgay.Location = new System.Drawing.Point(109, 101);
            this.txtNgay.Name = "txtNgay";
            this.txtNgay.Size = new System.Drawing.Size(136, 20);
            this.txtNgay.TabIndex = 8;
            // 
            // txtPhieu
            // 
            this.txtPhieu.Location = new System.Drawing.Point(109, 57);
            this.txtPhieu.Name = "txtPhieu";
            this.txtPhieu.Size = new System.Drawing.Size(136, 20);
            this.txtPhieu.TabIndex = 9;
            // 
            // BtnNhap
            // 
            this.BtnNhap.Location = new System.Drawing.Point(364, 68);
            this.BtnNhap.Name = "BtnNhap";
            this.BtnNhap.Size = new System.Drawing.Size(95, 45);
            this.BtnNhap.TabIndex = 10;
            this.BtnNhap.Text = "Nhập Hàng";
            this.BtnNhap.UseVisualStyleBackColor = true;
            this.BtnNhap.Click += new System.EventHandler(this.BtnNhap_Click);
            // 
            // dgvNhap
            // 
            this.dgvNhap.AutoGenerateColumns = false;
            this.dgvNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSPDataGridViewTextBoxColumn,
            this.maPhieuDataGridViewTextBoxColumn,
            this.soLuongDataGridViewTextBoxColumn,
            this.ngayNhapDataGridViewTextBoxColumn,
            this.tongTienDataGridViewTextBoxColumn});
            this.dgvNhap.DataSource = this.cTNhapHangBindingSource;
            this.dgvNhap.Location = new System.Drawing.Point(5, 249);
            this.dgvNhap.Name = "dgvNhap";
            this.dgvNhap.Size = new System.Drawing.Size(795, 200);
            this.dgvNhap.TabIndex = 11;
            // 
            // maSPDataGridViewTextBoxColumn
            // 
            this.maSPDataGridViewTextBoxColumn.DataPropertyName = "MaSP";
            this.maSPDataGridViewTextBoxColumn.HeaderText = "Mã SP";
            this.maSPDataGridViewTextBoxColumn.Name = "maSPDataGridViewTextBoxColumn";
            // 
            // maPhieuDataGridViewTextBoxColumn
            // 
            this.maPhieuDataGridViewTextBoxColumn.DataPropertyName = "MaPhieu";
            this.maPhieuDataGridViewTextBoxColumn.HeaderText = "Mã Nhập";
            this.maPhieuDataGridViewTextBoxColumn.Name = "maPhieuDataGridViewTextBoxColumn";
            // 
            // soLuongDataGridViewTextBoxColumn
            // 
            this.soLuongDataGridViewTextBoxColumn.DataPropertyName = "SoLuong";
            this.soLuongDataGridViewTextBoxColumn.HeaderText = "Số Lượng";
            this.soLuongDataGridViewTextBoxColumn.Name = "soLuongDataGridViewTextBoxColumn";
            // 
            // ngayNhapDataGridViewTextBoxColumn
            // 
            this.ngayNhapDataGridViewTextBoxColumn.DataPropertyName = "NgayNhap";
            this.ngayNhapDataGridViewTextBoxColumn.HeaderText = "Ngày Nhập";
            this.ngayNhapDataGridViewTextBoxColumn.Name = "ngayNhapDataGridViewTextBoxColumn";
            // 
            // tongTienDataGridViewTextBoxColumn
            // 
            this.tongTienDataGridViewTextBoxColumn.DataPropertyName = "TongTien";
            this.tongTienDataGridViewTextBoxColumn.HeaderText = "Thành Tiền";
            this.tongTienDataGridViewTextBoxColumn.Name = "tongTienDataGridViewTextBoxColumn";
            // 
            // cTNhapHangBindingSource
            // 
            this.cTNhapHangBindingSource.DataMember = "CTNhapHang";
            this.cTNhapHangBindingSource.DataSource = this.banHangDBDataSetNhap;
            // 
            // banHangDBDataSetNhap
            // 
            this.banHangDBDataSetNhap.DataSetName = "BanHangDBDataSetNhap";
            this.banHangDBDataSetNhap.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cTNhapHangTableAdapter
            // 
            this.cTNhapHangTableAdapter.ClearBeforeFill = true;
            // 
            // FormNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvNhap);
            this.Controls.Add(this.BtnNhap);
            this.Controls.Add(this.txtPhieu);
            this.Controls.Add(this.txtNgay);
            this.Controls.Add(this.txtSL);
            this.Controls.Add(this.txtTien);
            this.Controls.Add(this.txtMaSP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormNhapHang";
            this.Text = "FormNhapHang";
            this.Load += new System.EventHandler(this.FormNhapHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTNhapHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banHangDBDataSetNhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.TextBox txtTien;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.TextBox txtNgay;
        private System.Windows.Forms.TextBox txtPhieu;
        private System.Windows.Forms.Button BtnNhap;
        private System.Windows.Forms.DataGridView dgvNhap;
        private BanHangDBDataSetNhap banHangDBDataSetNhap;
        private System.Windows.Forms.BindingSource cTNhapHangBindingSource;
        private BanHangDBDataSetNhapTableAdapters.CTNhapHangTableAdapter cTNhapHangTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPhieuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayNhapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongTienDataGridViewTextBoxColumn;
    }
}