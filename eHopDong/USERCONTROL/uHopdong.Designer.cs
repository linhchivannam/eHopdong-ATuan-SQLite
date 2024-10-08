namespace eHopdong.USERCONTROL
{
    partial class uHopdong
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pValue = new System.Windows.Forms.Panel();
            this.pButton = new System.Windows.Forms.Panel();
            this.btnXem = new Krypton.Toolkit.KryptonButton();
            this.label2 = new System.Windows.Forms.Label();
            this.dtDen = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.dtTu = new System.Windows.Forms.DateTimePicker();
            this.txtSotien = new System.Windows.Forms.TextBox();
            this.btnSua = new Krypton.Toolkit.KryptonButton();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.btnThem = new Krypton.Toolkit.KryptonButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv = new Krypton.Toolkit.KryptonDataGridView();
            this.hopdongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sohopdong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Noidung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Batdau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ketthuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sotien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ghichu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dienthoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Masothue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Taikhoannganhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sotaikhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hopdongBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pValue
            // 
            this.pValue.BackColor = System.Drawing.Color.White;
            this.pValue.Dock = System.Windows.Forms.DockStyle.Top;
            this.pValue.Location = new System.Drawing.Point(0, 0);
            this.pValue.Name = "pValue";
            this.pValue.Size = new System.Drawing.Size(1074, 10);
            this.pValue.TabIndex = 0;
            // 
            // pButton
            // 
            this.pButton.BackColor = System.Drawing.Color.White;
            this.pButton.Controls.Add(this.btnXem);
            this.pButton.Controls.Add(this.label2);
            this.pButton.Controls.Add(this.dtDen);
            this.pButton.Controls.Add(this.label10);
            this.pButton.Controls.Add(this.dtTu);
            this.pButton.Controls.Add(this.txtSotien);
            this.pButton.Controls.Add(this.btnSua);
            this.pButton.Controls.Add(this.txtSum);
            this.pButton.Controls.Add(this.btnThem);
            this.pButton.Controls.Add(this.txtSearch);
            this.pButton.Controls.Add(this.label1);
            this.pButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.pButton.Location = new System.Drawing.Point(0, 10);
            this.pButton.Name = "pButton";
            this.pButton.Size = new System.Drawing.Size(1074, 38);
            this.pButton.TabIndex = 1;
            // 
            // btnXem
            // 
            this.btnXem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXem.Location = new System.Drawing.Point(485, 7);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(34, 25);
            this.btnXem.TabIndex = 267;
            this.btnXem.Tag = "";
            this.btnXem.ToolTipValues.Description = "Chỉnh sửa hợp đồng";
            this.btnXem.ToolTipValues.EnableToolTips = true;
            this.btnXem.ToolTipValues.Heading = "Sửa";
            this.btnXem.Values.Image = global::eHopdong.Properties.Resources.report;
            this.btnXem.Values.Text = "";
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(365, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 266;
            this.label2.Text = "đến";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtDen
            // 
            this.dtDen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtDen.CustomFormat = "dd/MM/yyyy";
            this.dtDen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDen.Location = new System.Drawing.Point(397, 11);
            this.dtDen.Name = "dtDen";
            this.dtDen.Size = new System.Drawing.Size(81, 20);
            this.dtDen.TabIndex = 265;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(222, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 264;
            this.label10.Text = "Từ ngày:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtTu
            // 
            this.dtTu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtTu.CustomFormat = "dd/MM/yyyy";
            this.dtTu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTu.Location = new System.Drawing.Point(277, 10);
            this.dtTu.Name = "dtTu";
            this.dtTu.Size = new System.Drawing.Size(81, 20);
            this.dtTu.TabIndex = 263;
            // 
            // txtSotien
            // 
            this.txtSotien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSotien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtSotien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSotien.ForeColor = System.Drawing.Color.Red;
            this.txtSotien.Location = new System.Drawing.Point(886, 7);
            this.txtSotien.Name = "txtSotien";
            this.txtSotien.ReadOnly = true;
            this.txtSotien.Size = new System.Drawing.Size(137, 23);
            this.txtSotien.TabIndex = 239;
            this.txtSotien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSotien.TextChanged += new System.EventHandler(this.txtSotien_TextChanged);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(58, 7);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(34, 25);
            this.btnSua.TabIndex = 184;
            this.btnSua.Tag = "";
            this.btnSua.ToolTipValues.Description = "Chỉnh sửa hợp đồng";
            this.btnSua.ToolTipValues.EnableToolTips = true;
            this.btnSua.ToolTipValues.Heading = "Sửa";
            this.btnSua.Values.Image = global::eHopdong.Properties.Resources.edit;
            this.btnSua.Values.Text = "";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // txtSum
            // 
            this.txtSum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSum.Location = new System.Drawing.Point(1029, 9);
            this.txtSum.Name = "txtSum";
            this.txtSum.Size = new System.Drawing.Size(40, 21);
            this.txtSum.TabIndex = 183;
            this.txtSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(12, 6);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(39, 25);
            this.btnThem.TabIndex = 182;
            this.btnThem.ToolTipValues.Description = "Thêm hợp đồng với khách hàng";
            this.btnThem.ToolTipValues.EnableToolTips = true;
            this.btnThem.ToolTipValues.Heading = "Thêm mới";
            this.btnThem.Values.Image = global::eHopdong.Properties.Resources.add;
            this.btnThem.Values.Text = "";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(776, 9);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(104, 21);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(709, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm kiếm:";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.AutoGenerateColumns = false;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.ColumnHeadersHeight = 25;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Ngay,
            this.Sohopdong,
            this.Noidung,
            this.Batdau,
            this.Ketthuc,
            this.Sotien,
            this.Ghichu,
            this.Ma,
            this.Ten,
            this.Diachi,
            this.Dienthoai,
            this.Masothue,
            this.Taikhoannganhang,
            this.Sotaikhoan});
            this.dgv.DataSource = this.hopdongBindingSource;
            this.dgv.Location = new System.Drawing.Point(0, 48);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 10;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(1074, 441);
            this.dgv.TabIndex = 188;
            this.dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellDoubleClick);
            this.dgv.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_CellFormatting);
            // 
            // hopdongBindingSource
            // 
            this.hopdongBindingSource.DataSource = typeof(PQDb.MODEL.Hopdong);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Id.DefaultCellStyle = dataGridViewCellStyle2;
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 50;
            // 
            // Ngay
            // 
            this.Ngay.DataPropertyName = "Ngay";
            this.Ngay.HeaderText = "Ngày";
            this.Ngay.Name = "Ngay";
            this.Ngay.ReadOnly = true;
            this.Ngay.Width = 90;
            // 
            // Sohopdong
            // 
            this.Sohopdong.DataPropertyName = "Sohopdong";
            this.Sohopdong.HeaderText = "HĐ Số";
            this.Sohopdong.Name = "Sohopdong";
            this.Sohopdong.ReadOnly = true;
            // 
            // Noidung
            // 
            this.Noidung.DataPropertyName = "Noidung";
            this.Noidung.HeaderText = "Nội dung";
            this.Noidung.Name = "Noidung";
            this.Noidung.ReadOnly = true;
            this.Noidung.Width = 200;
            // 
            // Batdau
            // 
            this.Batdau.DataPropertyName = "Batdau";
            this.Batdau.HeaderText = "Bắt đầu";
            this.Batdau.Name = "Batdau";
            this.Batdau.ReadOnly = true;
            this.Batdau.Width = 90;
            // 
            // Ketthuc
            // 
            this.Ketthuc.DataPropertyName = "Ketthuc";
            this.Ketthuc.HeaderText = "Kết thúc";
            this.Ketthuc.Name = "Ketthuc";
            this.Ketthuc.ReadOnly = true;
            this.Ketthuc.Width = 90;
            // 
            // Sotien
            // 
            this.Sotien.DataPropertyName = "Sotien";
            this.Sotien.HeaderText = "Số tiền";
            this.Sotien.Name = "Sotien";
            this.Sotien.ReadOnly = true;
            // 
            // Ghichu
            // 
            this.Ghichu.DataPropertyName = "Ghichu";
            this.Ghichu.HeaderText = "Ghi chú";
            this.Ghichu.Name = "Ghichu";
            this.Ghichu.ReadOnly = true;
            this.Ghichu.Width = 200;
            // 
            // Ma
            // 
            this.Ma.DataPropertyName = "Ma";
            this.Ma.HeaderText = "Ma";
            this.Ma.Name = "Ma";
            this.Ma.ReadOnly = true;
            this.Ma.Visible = false;
            // 
            // Ten
            // 
            this.Ten.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ten.DataPropertyName = "Ten";
            this.Ten.HeaderText = "Khách hàng";
            this.Ten.Name = "Ten";
            this.Ten.ReadOnly = true;
            // 
            // Diachi
            // 
            this.Diachi.DataPropertyName = "Diachi";
            this.Diachi.HeaderText = "Diachi";
            this.Diachi.Name = "Diachi";
            this.Diachi.ReadOnly = true;
            this.Diachi.Visible = false;
            // 
            // Dienthoai
            // 
            this.Dienthoai.DataPropertyName = "Dienthoai";
            this.Dienthoai.HeaderText = "Dienthoai";
            this.Dienthoai.Name = "Dienthoai";
            this.Dienthoai.ReadOnly = true;
            this.Dienthoai.Visible = false;
            // 
            // Masothue
            // 
            this.Masothue.DataPropertyName = "Masothue";
            this.Masothue.HeaderText = "Masothue";
            this.Masothue.Name = "Masothue";
            this.Masothue.ReadOnly = true;
            this.Masothue.Visible = false;
            // 
            // Taikhoannganhang
            // 
            this.Taikhoannganhang.DataPropertyName = "Taikhoannganhang";
            this.Taikhoannganhang.HeaderText = "Taikhoannganhang";
            this.Taikhoannganhang.Name = "Taikhoannganhang";
            this.Taikhoannganhang.ReadOnly = true;
            this.Taikhoannganhang.Visible = false;
            // 
            // Sotaikhoan
            // 
            this.Sotaikhoan.DataPropertyName = "Sotaikhoan";
            this.Sotaikhoan.HeaderText = "Sotaikhoan";
            this.Sotaikhoan.Name = "Sotaikhoan";
            this.Sotaikhoan.ReadOnly = true;
            this.Sotaikhoan.Visible = false;
            // 
            // uHopdong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.pButton);
            this.Controls.Add(this.pValue);
            this.Name = "uHopdong";
            this.Size = new System.Drawing.Size(1074, 492);
            this.Load += new System.EventHandler(this.uKhachhang_Load);
            this.pButton.ResumeLayout(false);
            this.pButton.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hopdongBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pValue;
        private System.Windows.Forms.Panel pButton;
        private Krypton.Toolkit.KryptonDataGridView dgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private Krypton.Toolkit.KryptonButton btnThem;
        private System.Windows.Forms.TextBox txtSum;
        private Krypton.Toolkit.KryptonButton btnSua;
        private System.Windows.Forms.TextBox txtSotien;
        private Krypton.Toolkit.KryptonButton btnXem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtDen;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtTu;
        private System.Windows.Forms.BindingSource hopdongBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sohopdong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Noidung;
        private System.Windows.Forms.DataGridViewTextBoxColumn Batdau;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ketthuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sotien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ghichu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dienthoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Masothue;
        private System.Windows.Forms.DataGridViewTextBoxColumn Taikhoannganhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sotaikhoan;
    }
}
