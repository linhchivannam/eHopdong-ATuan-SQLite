namespace eHopdong.BAOCAO
{
    partial class uBaoKHNCC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pValue = new System.Windows.Forms.Panel();
            this.pButton = new System.Windows.Forms.Panel();
            this.cbxNhanvien = new System.Windows.Forms.ComboBox();
            this.nhanvienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chkNV = new Krypton.Toolkit.KryptonCheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxTinh = new System.Windows.Forms.ComboBox();
            this.tinhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chkAll = new Krypton.Toolkit.KryptonCheckBox();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv = new Krypton.Toolkit.KryptonDataGridView();
            this.myMn = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnThongtin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnHoptacdv = new System.Windows.Forms.ToolStripMenuItem();
            this.mnHoptac = new System.Windows.Forms.ToolStripMenuItem();
            this.mnChamsoc = new System.Windows.Forms.ToolStripMenuItem();
            this.khachhangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chucvu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dienthoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tendonvi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facebook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiemnang = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.congtacvien = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhacungcap = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ngaycuoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tuongtacuoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sinhnhat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sinhnhatco = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.kyniem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kyniemco = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.donvi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhanvienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tinhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.myMn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.khachhangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pValue
            // 
            this.pValue.BackColor = System.Drawing.Color.White;
            this.pValue.Dock = System.Windows.Forms.DockStyle.Top;
            this.pValue.Location = new System.Drawing.Point(0, 0);
            this.pValue.Name = "pValue";
            this.pValue.Size = new System.Drawing.Size(898, 10);
            this.pValue.TabIndex = 0;
            // 
            // pButton
            // 
            this.pButton.BackColor = System.Drawing.Color.White;
            this.pButton.Controls.Add(this.cbxNhanvien);
            this.pButton.Controls.Add(this.chkNV);
            this.pButton.Controls.Add(this.label3);
            this.pButton.Controls.Add(this.cbxTinh);
            this.pButton.Controls.Add(this.chkAll);
            this.pButton.Controls.Add(this.txtSum);
            this.pButton.Controls.Add(this.txtSearch);
            this.pButton.Controls.Add(this.label1);
            this.pButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.pButton.Location = new System.Drawing.Point(0, 10);
            this.pButton.Name = "pButton";
            this.pButton.Size = new System.Drawing.Size(898, 38);
            this.pButton.TabIndex = 1;
            // 
            // cbxNhanvien
            // 
            this.cbxNhanvien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxNhanvien.DataSource = this.nhanvienBindingSource;
            this.cbxNhanvien.DisplayMember = "ten";
            this.cbxNhanvien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNhanvien.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxNhanvien.FormattingEnabled = true;
            this.cbxNhanvien.Location = new System.Drawing.Point(273, 7);
            this.cbxNhanvien.Name = "cbxNhanvien";
            this.cbxNhanvien.Size = new System.Drawing.Size(159, 24);
            this.cbxNhanvien.TabIndex = 271;
            this.cbxNhanvien.ValueMember = "ma";
            this.cbxNhanvien.SelectedIndexChanged += new System.EventHandler(this.cbxNhanvien_SelectedIndexChanged);
            // 
            // nhanvienBindingSource
            // 
            this.nhanvienBindingSource.DataSource = typeof(eHopdong.LINQ.nhanvien);
            // 
            // chkNV
            // 
            this.chkNV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkNV.Checked = true;
            this.chkNV.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNV.Location = new System.Drawing.Point(193, 11);
            this.chkNV.Name = "chkNV";
            this.chkNV.Size = new System.Drawing.Size(74, 20);
            this.chkNV.TabIndex = 270;
            this.chkNV.Values.Text = "tất cả NV";
            this.chkNV.CheckedChanged += new System.EventHandler(this.chkNV_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(3, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 18);
            this.label3.TabIndex = 269;
            this.label3.Text = "BÁO CÁO NHÀ CUNG CẤP";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxTinh
            // 
            this.cbxTinh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxTinh.DataSource = this.tinhBindingSource;
            this.cbxTinh.DisplayMember = "ten";
            this.cbxTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTinh.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTinh.FormattingEnabled = true;
            this.cbxTinh.Location = new System.Drawing.Point(523, 7);
            this.cbxTinh.Name = "cbxTinh";
            this.cbxTinh.Size = new System.Drawing.Size(116, 24);
            this.cbxTinh.TabIndex = 238;
            this.cbxTinh.ValueMember = "ma";
            this.cbxTinh.SelectedIndexChanged += new System.EventHandler(this.cbxTinh_SelectedIndexChanged);
            // 
            // tinhBindingSource
            // 
            this.tinhBindingSource.DataSource = typeof(eHopdong.LINQ.tinh);
            // 
            // chkAll
            // 
            this.chkAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkAll.Checked = true;
            this.chkAll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAll.Location = new System.Drawing.Point(439, 9);
            this.chkAll.Name = "chkAll";
            this.chkAll.Size = new System.Drawing.Size(78, 20);
            this.chkAll.TabIndex = 187;
            this.chkAll.Values.Text = "tất cả tỉnh";
            this.chkAll.CheckedChanged += new System.EventHandler(this.chkAll_CheckedChanged);
            // 
            // txtSum
            // 
            this.txtSum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSum.Location = new System.Drawing.Point(824, 9);
            this.txtSum.Name = "txtSum";
            this.txtSum.Size = new System.Drawing.Size(61, 21);
            this.txtSum.TabIndex = 183;
            this.txtSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(712, 9);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(106, 21);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(645, 12);
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
            this.dgv.AutoGenerateColumns = false;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.ColumnHeadersHeight = 25;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.ten,
            this.chucvu,
            this.dienthoai,
            this.diachi,
            this.tendonvi,
            this.email,
            this.facebook,
            this.tiemnang,
            this.congtacvien,
            this.ma,
            this.nhacungcap,
            this.ngaycuoi,
            this.tuongtacuoi,
            this.username,
            this.tinh,
            this.sinhnhat,
            this.sinhnhatco,
            this.kyniem,
            this.kyniemco,
            this.donvi});
            this.dgv.ContextMenuStrip = this.myMn;
            this.dgv.DataSource = this.khachhangBindingSource;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 48);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 20;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(898, 444);
            this.dgv.TabIndex = 188;
            this.dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellDoubleClick);
            this.dgv.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_CellFormatting);
            // 
            // myMn
            // 
            this.myMn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.myMn.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnThongtin,
            this.mnHoptacdv,
            this.mnHoptac,
            this.mnChamsoc});
            this.myMn.Name = "myMn";
            this.myMn.Size = new System.Drawing.Size(223, 92);
            // 
            // mnThongtin
            // 
            this.mnThongtin.Image = global::eHopdong.Properties.Resources.edit;
            this.mnThongtin.Name = "mnThongtin";
            this.mnThongtin.Size = new System.Drawing.Size(222, 22);
            this.mnThongtin.Text = "Thông tin khách hàng";
            this.mnThongtin.Click += new System.EventHandler(this.mnThongtin_Click);
            // 
            // mnHoptacdv
            // 
            this.mnHoptacdv.Image = global::eHopdong.Properties.Resources.pass;
            this.mnHoptacdv.Name = "mnHoptacdv";
            this.mnHoptacdv.Size = new System.Drawing.Size(222, 22);
            this.mnHoptacdv.Text = "Quá trình hợp tác với đơn vị";
            this.mnHoptacdv.Visible = false;
            this.mnHoptacdv.Click += new System.EventHandler(this.mnHoptacdv_Click);
            // 
            // mnHoptac
            // 
            this.mnHoptac.Image = global::eHopdong.Properties.Resources.customer;
            this.mnHoptac.Name = "mnHoptac";
            this.mnHoptac.Size = new System.Drawing.Size(222, 22);
            this.mnHoptac.Text = "Quá trình hợp tác";
            this.mnHoptac.Click += new System.EventHandler(this.mnHoptac_Click);
            // 
            // mnChamsoc
            // 
            this.mnChamsoc.Image = global::eHopdong.Properties.Resources.list;
            this.mnChamsoc.Name = "mnChamsoc";
            this.mnChamsoc.Size = new System.Drawing.Size(222, 22);
            this.mnChamsoc.Text = "Quá trình chăm sóc";
            this.mnChamsoc.Click += new System.EventHandler(this.mnChamsoc_Click);
            // 
            // khachhangBindingSource
            // 
            this.khachhangBindingSource.DataSource = typeof(eHopdong.LINQ.khachhang);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.id.DefaultCellStyle = dataGridViewCellStyle2;
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 40;
            // 
            // ten
            // 
            this.ten.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ten.DataPropertyName = "ten";
            this.ten.HeaderText = "Tên Khách hàng";
            this.ten.MinimumWidth = 200;
            this.ten.Name = "ten";
            this.ten.ReadOnly = true;
            // 
            // chucvu
            // 
            this.chucvu.DataPropertyName = "chucvu";
            this.chucvu.HeaderText = "Chức vụ";
            this.chucvu.Name = "chucvu";
            this.chucvu.ReadOnly = true;
            // 
            // dienthoai
            // 
            this.dienthoai.DataPropertyName = "dienthoai";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dienthoai.DefaultCellStyle = dataGridViewCellStyle3;
            this.dienthoai.HeaderText = "Điện thoại";
            this.dienthoai.Name = "dienthoai";
            this.dienthoai.ReadOnly = true;
            this.dienthoai.Width = 120;
            // 
            // diachi
            // 
            this.diachi.DataPropertyName = "diachi";
            this.diachi.HeaderText = "Địa chỉ";
            this.diachi.MinimumWidth = 220;
            this.diachi.Name = "diachi";
            this.diachi.ReadOnly = true;
            this.diachi.Visible = false;
            this.diachi.Width = 220;
            // 
            // tendonvi
            // 
            this.tendonvi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tendonvi.DataPropertyName = "tendonvi";
            this.tendonvi.HeaderText = "Đơn vị";
            this.tendonvi.Name = "tendonvi";
            this.tendonvi.ReadOnly = true;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Visible = false;
            // 
            // facebook
            // 
            this.facebook.DataPropertyName = "facebook";
            this.facebook.HeaderText = "facebook";
            this.facebook.Name = "facebook";
            this.facebook.ReadOnly = true;
            this.facebook.Visible = false;
            // 
            // tiemnang
            // 
            this.tiemnang.DataPropertyName = "tiemnang";
            this.tiemnang.HeaderText = "TN";
            this.tiemnang.Name = "tiemnang";
            this.tiemnang.ReadOnly = true;
            this.tiemnang.Visible = false;
            this.tiemnang.Width = 40;
            // 
            // congtacvien
            // 
            this.congtacvien.DataPropertyName = "congtacvien";
            this.congtacvien.HeaderText = "CTV";
            this.congtacvien.Name = "congtacvien";
            this.congtacvien.ReadOnly = true;
            this.congtacvien.Visible = false;
            this.congtacvien.Width = 40;
            // 
            // ma
            // 
            this.ma.DataPropertyName = "ma";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ma.DefaultCellStyle = dataGridViewCellStyle4;
            this.ma.HeaderText = "Mã CTV";
            this.ma.Name = "ma";
            this.ma.ReadOnly = true;
            this.ma.Visible = false;
            this.ma.Width = 60;
            // 
            // nhacungcap
            // 
            this.nhacungcap.DataPropertyName = "nhacungcap";
            this.nhacungcap.HeaderText = "NCC";
            this.nhacungcap.Name = "nhacungcap";
            this.nhacungcap.ReadOnly = true;
            this.nhacungcap.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.nhacungcap.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.nhacungcap.Width = 40;
            // 
            // ngaycuoi
            // 
            this.ngaycuoi.DataPropertyName = "ngaycuoi";
            this.ngaycuoi.HeaderText = "GD Cuối";
            this.ngaycuoi.Name = "ngaycuoi";
            this.ngaycuoi.ReadOnly = true;
            this.ngaycuoi.Width = 80;
            // 
            // tuongtacuoi
            // 
            this.tuongtacuoi.DataPropertyName = "tuongtacuoi";
            this.tuongtacuoi.HeaderText = "TT cuối";
            this.tuongtacuoi.Name = "tuongtacuoi";
            this.tuongtacuoi.ReadOnly = true;
            this.tuongtacuoi.Width = 80;
            // 
            // username
            // 
            this.username.DataPropertyName = "username";
            this.username.HeaderText = "username";
            this.username.Name = "username";
            this.username.ReadOnly = true;
            this.username.Visible = false;
            // 
            // tinh
            // 
            this.tinh.DataPropertyName = "tinh";
            this.tinh.HeaderText = "tinh";
            this.tinh.Name = "tinh";
            this.tinh.ReadOnly = true;
            this.tinh.Visible = false;
            // 
            // sinhnhat
            // 
            this.sinhnhat.DataPropertyName = "sinhnhat";
            this.sinhnhat.HeaderText = "Ngày KN";
            this.sinhnhat.Name = "sinhnhat";
            this.sinhnhat.ReadOnly = true;
            this.sinhnhat.Visible = false;
            this.sinhnhat.Width = 80;
            // 
            // sinhnhatco
            // 
            this.sinhnhatco.DataPropertyName = "sinhnhatco";
            this.sinhnhatco.HeaderText = "sinhnhatco";
            this.sinhnhatco.Name = "sinhnhatco";
            this.sinhnhatco.ReadOnly = true;
            this.sinhnhatco.Visible = false;
            // 
            // kyniem
            // 
            this.kyniem.DataPropertyName = "kyniem";
            this.kyniem.HeaderText = "kyniem";
            this.kyniem.Name = "kyniem";
            this.kyniem.ReadOnly = true;
            this.kyniem.Visible = false;
            // 
            // kyniemco
            // 
            this.kyniemco.DataPropertyName = "kyniemco";
            this.kyniemco.HeaderText = "kyniemco";
            this.kyniemco.Name = "kyniemco";
            this.kyniemco.ReadOnly = true;
            this.kyniemco.Visible = false;
            // 
            // donvi
            // 
            this.donvi.DataPropertyName = "donvi";
            this.donvi.HeaderText = "donvi";
            this.donvi.Name = "donvi";
            this.donvi.ReadOnly = true;
            this.donvi.Visible = false;
            // 
            // uBaoKHNCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.pButton);
            this.Controls.Add(this.pValue);
            this.Name = "uBaoKHNCC";
            this.Size = new System.Drawing.Size(898, 492);
            this.Load += new System.EventHandler(this.uKhachhang_Load);
            this.pButton.ResumeLayout(false);
            this.pButton.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhanvienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tinhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.myMn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.khachhangBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pValue;
        private System.Windows.Forms.Panel pButton;
        private Krypton.Toolkit.KryptonDataGridView dgv;
        private System.Windows.Forms.BindingSource khachhangBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtSum;
        private Krypton.Toolkit.KryptonCheckBox chkAll;
        private System.Windows.Forms.BindingSource tinhBindingSource;
        private System.Windows.Forms.ContextMenuStrip myMn;
        private System.Windows.Forms.ToolStripMenuItem mnThongtin;
        private System.Windows.Forms.ToolStripMenuItem mnHoptac;
        private System.Windows.Forms.ToolStripMenuItem mnChamsoc;
        private System.Windows.Forms.ToolStripMenuItem mnHoptacdv;
        private System.Windows.Forms.ComboBox cbxTinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxNhanvien;
        private Krypton.Toolkit.KryptonCheckBox chkNV;
        private System.Windows.Forms.BindingSource nhanvienBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn chucvu;
        private System.Windows.Forms.DataGridViewTextBoxColumn dienthoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn tendonvi;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn facebook;
        private System.Windows.Forms.DataGridViewCheckBoxColumn tiemnang;
        private System.Windows.Forms.DataGridViewCheckBoxColumn congtacvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma;
        private System.Windows.Forms.DataGridViewCheckBoxColumn nhacungcap;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaycuoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn tuongtacuoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn tinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn sinhnhat;
        private System.Windows.Forms.DataGridViewCheckBoxColumn sinhnhatco;
        private System.Windows.Forms.DataGridViewTextBoxColumn kyniem;
        private System.Windows.Forms.DataGridViewCheckBoxColumn kyniemco;
        private System.Windows.Forms.DataGridViewTextBoxColumn donvi;
    }
}
