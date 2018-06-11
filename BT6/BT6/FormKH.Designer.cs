namespace BT6
{
    partial class FormKH
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
            this.txtMa = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtDC = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLm = new System.Windows.Forms.Button();
            this.BtnTK = new System.Windows.Forms.Button();
            this.BtnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.webBanDienThoaiDataSet = new BT6.WebBanDienThoaiDataSet();
            this.webBanDienThoaiDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.webBanDienThoaiDataSetKH = new BT6.WebBanDienThoaiDataSetKH();
            this.kHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kHTableAdapter = new BT6.WebBanDienThoaiDataSetKHTableAdapters.KHTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kHBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.banHangDBDataSet = new BT6.BanHangDBDataSet();
            this.kHTableAdapter1 = new BT6.BanHangDBDataSetTableAdapters.KHTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.webBanDienThoaiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.webBanDienThoaiDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.webBanDienThoaiDataSetKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banHangDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã KH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Địa Chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên KH";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "SĐT";
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(127, 16);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(131, 20);
            this.txtMa.TabIndex = 4;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(127, 141);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(131, 20);
            this.txtSDT.TabIndex = 5;
            // 
            // txtDC
            // 
            this.txtDC.Location = new System.Drawing.Point(127, 104);
            this.txtDC.Name = "txtDC";
            this.txtDC.Size = new System.Drawing.Size(131, 20);
            this.txtDC.TabIndex = 6;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(127, 61);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(131, 20);
            this.txtTen.TabIndex = 7;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(422, 18);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLm
            // 
            this.btnLm.Location = new System.Drawing.Point(559, 68);
            this.btnLm.Name = "btnLm";
            this.btnLm.Size = new System.Drawing.Size(75, 23);
            this.btnLm.TabIndex = 9;
            this.btnLm.Text = "Refresh";
            this.btnLm.UseVisualStyleBackColor = true;
            this.btnLm.Click += new System.EventHandler(this.btnLm_Click);
            // 
            // BtnTK
            // 
            this.BtnTK.Location = new System.Drawing.Point(681, 111);
            this.BtnTK.Name = "BtnTK";
            this.BtnTK.Size = new System.Drawing.Size(75, 23);
            this.BtnTK.TabIndex = 10;
            this.BtnTK.Text = "Tìm Kiếm";
            this.BtnTK.UseVisualStyleBackColor = true;
            this.BtnTK.Click += new System.EventHandler(this.BtnTK_Click);
            // 
            // BtnXoa
            // 
            this.BtnXoa.Location = new System.Drawing.Point(422, 111);
            this.BtnXoa.Name = "BtnXoa";
            this.BtnXoa.Size = new System.Drawing.Size(75, 23);
            this.BtnXoa.TabIndex = 11;
            this.BtnXoa.Text = "Xóa";
            this.BtnXoa.UseVisualStyleBackColor = true;
            this.BtnXoa.Click += new System.EventHandler(this.BtnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(681, 18);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 12;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // webBanDienThoaiDataSet
            // 
            this.webBanDienThoaiDataSet.DataSetName = "WebBanDienThoaiDataSet";
            this.webBanDienThoaiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // webBanDienThoaiDataSetBindingSource
            // 
            this.webBanDienThoaiDataSetBindingSource.DataSource = this.webBanDienThoaiDataSet;
            this.webBanDienThoaiDataSetBindingSource.Position = 0;
            // 
            // webBanDienThoaiDataSetKH
            // 
            this.webBanDienThoaiDataSetKH.DataSetName = "WebBanDienThoaiDataSetKH";
            this.webBanDienThoaiDataSetKH.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kHBindingSource
            // 
            this.kHBindingSource.DataMember = "KH";
            this.kHBindingSource.DataSource = this.webBanDienThoaiDataSetKH;
            // 
            // kHTableAdapter
            // 
            this.kHTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maDataGridViewTextBoxColumn,
            this.tenDataGridViewTextBoxColumn,
            this.dcDataGridViewTextBoxColumn,
            this.sDTDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kHBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(1, 196);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(795, 234);
            this.dataGridView1.TabIndex = 13;
            // 
            // maDataGridViewTextBoxColumn
            // 
            this.maDataGridViewTextBoxColumn.DataPropertyName = "Ma";
            this.maDataGridViewTextBoxColumn.HeaderText = "Mã KH";
            this.maDataGridViewTextBoxColumn.Name = "maDataGridViewTextBoxColumn";
            // 
            // tenDataGridViewTextBoxColumn
            // 
            this.tenDataGridViewTextBoxColumn.DataPropertyName = "Ten";
            this.tenDataGridViewTextBoxColumn.HeaderText = "Tên KH";
            this.tenDataGridViewTextBoxColumn.Name = "tenDataGridViewTextBoxColumn";
            // 
            // dcDataGridViewTextBoxColumn
            // 
            this.dcDataGridViewTextBoxColumn.DataPropertyName = "Dc";
            this.dcDataGridViewTextBoxColumn.HeaderText = "Địa Chỉ";
            this.dcDataGridViewTextBoxColumn.Name = "dcDataGridViewTextBoxColumn";
            // 
            // sDTDataGridViewTextBoxColumn
            // 
            this.sDTDataGridViewTextBoxColumn.DataPropertyName = "SDT";
            this.sDTDataGridViewTextBoxColumn.HeaderText = "SDT";
            this.sDTDataGridViewTextBoxColumn.Name = "sDTDataGridViewTextBoxColumn";
            // 
            // kHBindingSource1
            // 
            this.kHBindingSource1.DataMember = "KH";
            this.kHBindingSource1.DataSource = this.banHangDBDataSet;
            // 
            // banHangDBDataSet
            // 
            this.banHangDBDataSet.DataSetName = "BanHangDBDataSet";
            this.banHangDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kHTableAdapter1
            // 
            this.kHTableAdapter1.ClearBeforeFill = true;
            // 
            // FormKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.BtnXoa);
            this.Controls.Add(this.BtnTK);
            this.Controls.Add(this.btnLm);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtDC);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormKH";
            this.Text = "FormKH";
            this.Load += new System.EventHandler(this.FormKH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.webBanDienThoaiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.webBanDienThoaiDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.webBanDienThoaiDataSetKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banHangDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtDC;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLm;
        private System.Windows.Forms.Button BtnTK;
        private System.Windows.Forms.Button BtnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.BindingSource webBanDienThoaiDataSetBindingSource;
        private WebBanDienThoaiDataSet webBanDienThoaiDataSet;
        private WebBanDienThoaiDataSetKH webBanDienThoaiDataSetKH;
        private System.Windows.Forms.BindingSource kHBindingSource;
        private WebBanDienThoaiDataSetKHTableAdapters.KHTableAdapter kHTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BanHangDBDataSet banHangDBDataSet;
        private System.Windows.Forms.BindingSource kHBindingSource1;
        private BanHangDBDataSetTableAdapters.KHTableAdapter kHTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDTDataGridViewTextBoxColumn;
    }
}