namespace Truong
{
    partial class FormTTDG
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
            this.dgvGD = new System.Windows.Forms.DataGridView();
            this.truongDataSet = new Truong.TruongDataSet();
            this.thongTinGiangDayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.thongTinGiangDayTableAdapter = new Truong.TruongDataSetTableAdapters.ThongTinGiangDayTableAdapter();
            this.tenGVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siSoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tietDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLM = new System.Windows.Forms.Button();
            this.btnTK = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtTiet = new System.Windows.Forms.TextBox();
            this.txtNgay = new System.Windows.Forms.TextBox();
            this.txtLop = new System.Windows.Forms.TextBox();
            this.txtSiSo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.truongDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongTinGiangDayBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên GV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sĩ Số";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tiết";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Lớp";
            // 
            // dgvGD
            // 
            this.dgvGD.AutoGenerateColumns = false;
            this.dgvGD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenGVDataGridViewTextBoxColumn,
            this.lopDataGridViewTextBoxColumn,
            this.siSoDataGridViewTextBoxColumn,
            this.tietDataGridViewTextBoxColumn,
            this.ngayDataGridViewTextBoxColumn});
            this.dgvGD.DataSource = this.thongTinGiangDayBindingSource;
            this.dgvGD.Location = new System.Drawing.Point(1, 233);
            this.dgvGD.Name = "dgvGD";
            this.dgvGD.Size = new System.Drawing.Size(800, 215);
            this.dgvGD.TabIndex = 5;
            // 
            // truongDataSet
            // 
            this.truongDataSet.DataSetName = "TruongDataSet";
            this.truongDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // thongTinGiangDayBindingSource
            // 
            this.thongTinGiangDayBindingSource.DataMember = "ThongTinGiangDay";
            this.thongTinGiangDayBindingSource.DataSource = this.truongDataSet;
            // 
            // thongTinGiangDayTableAdapter
            // 
            this.thongTinGiangDayTableAdapter.ClearBeforeFill = true;
            // 
            // tenGVDataGridViewTextBoxColumn
            // 
            this.tenGVDataGridViewTextBoxColumn.DataPropertyName = "TenGV";
            this.tenGVDataGridViewTextBoxColumn.HeaderText = "Tên GV";
            this.tenGVDataGridViewTextBoxColumn.Name = "tenGVDataGridViewTextBoxColumn";
            // 
            // lopDataGridViewTextBoxColumn
            // 
            this.lopDataGridViewTextBoxColumn.DataPropertyName = "Lop";
            this.lopDataGridViewTextBoxColumn.HeaderText = "Lớp";
            this.lopDataGridViewTextBoxColumn.Name = "lopDataGridViewTextBoxColumn";
            // 
            // siSoDataGridViewTextBoxColumn
            // 
            this.siSoDataGridViewTextBoxColumn.DataPropertyName = "SiSo";
            this.siSoDataGridViewTextBoxColumn.HeaderText = "Sĩ Số";
            this.siSoDataGridViewTextBoxColumn.Name = "siSoDataGridViewTextBoxColumn";
            // 
            // tietDataGridViewTextBoxColumn
            // 
            this.tietDataGridViewTextBoxColumn.DataPropertyName = "Tiet";
            this.tietDataGridViewTextBoxColumn.HeaderText = "Tiết";
            this.tietDataGridViewTextBoxColumn.Name = "tietDataGridViewTextBoxColumn";
            // 
            // ngayDataGridViewTextBoxColumn
            // 
            this.ngayDataGridViewTextBoxColumn.DataPropertyName = "Ngay";
            this.ngayDataGridViewTextBoxColumn.HeaderText = "Ngày";
            this.ngayDataGridViewTextBoxColumn.Name = "ngayDataGridViewTextBoxColumn";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(420, 44);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLM
            // 
            this.btnLM.Location = new System.Drawing.Point(565, 104);
            this.btnLM.Name = "btnLM";
            this.btnLM.Size = new System.Drawing.Size(75, 23);
            this.btnLM.TabIndex = 7;
            this.btnLM.Text = "Refersh";
            this.btnLM.UseVisualStyleBackColor = true;
            this.btnLM.Click += new System.EventHandler(this.btnLM_Click);
            // 
            // btnTK
            // 
            this.btnTK.Location = new System.Drawing.Point(689, 159);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(75, 23);
            this.btnTK.TabIndex = 8;
            this.btnTK.Text = "Tìm Kiếm";
            this.btnTK.UseVisualStyleBackColor = true;
            this.btnTK.Click += new System.EventHandler(this.btnTK_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(689, 44);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 9;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(420, 159);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(99, 17);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(216, 20);
            this.txtTen.TabIndex = 11;
            // 
            // txtTiet
            // 
            this.txtTiet.Location = new System.Drawing.Point(99, 179);
            this.txtTiet.Name = "txtTiet";
            this.txtTiet.Size = new System.Drawing.Size(216, 20);
            this.txtTiet.TabIndex = 12;
            // 
            // txtNgay
            // 
            this.txtNgay.Location = new System.Drawing.Point(99, 145);
            this.txtNgay.Name = "txtNgay";
            this.txtNgay.Size = new System.Drawing.Size(216, 20);
            this.txtNgay.TabIndex = 13;
            // 
            // txtLop
            // 
            this.txtLop.Location = new System.Drawing.Point(99, 104);
            this.txtLop.Name = "txtLop";
            this.txtLop.Size = new System.Drawing.Size(216, 20);
            this.txtLop.TabIndex = 14;
            // 
            // txtSiSo
            // 
            this.txtSiSo.Location = new System.Drawing.Point(99, 61);
            this.txtSiSo.Name = "txtSiSo";
            this.txtSiSo.Size = new System.Drawing.Size(216, 20);
            this.txtSiSo.TabIndex = 15;
            // 
            // FormTTDG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSiSo);
            this.Controls.Add(this.txtLop);
            this.Controls.Add(this.txtNgay);
            this.Controls.Add(this.txtTiet);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnTK);
            this.Controls.Add(this.btnLM);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvGD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormTTDG";
            this.Text = "FormTTDG";
            this.Load += new System.EventHandler(this.FormTTDG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.truongDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongTinGiangDayBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvGD;
        private TruongDataSet truongDataSet;
        private System.Windows.Forms.BindingSource thongTinGiangDayBindingSource;
        private TruongDataSetTableAdapters.ThongTinGiangDayTableAdapter thongTinGiangDayTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenGVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siSoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tietDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLM;
        private System.Windows.Forms.Button btnTK;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtTiet;
        private System.Windows.Forms.TextBox txtNgay;
        private System.Windows.Forms.TextBox txtLop;
        private System.Windows.Forms.TextBox txtSiSo;
    }
}