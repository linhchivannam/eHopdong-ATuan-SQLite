namespace eHopdong.DANHMUC
{
    partial class uChamsoc
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
            this.cbxDV = new System.Windows.Forms.ComboBox();
            this.tinhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chkAll = new Krypton.Toolkit.KryptonCheckBox();
            this.btnSua = new Krypton.Toolkit.KryptonButton();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.btnThem = new Krypton.Toolkit.KryptonButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv = new Krypton.Toolkit.KryptonDataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenkh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noidung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chamsocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tinhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chamsocBindingSource)).BeginInit();
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
            this.pButton.Controls.Add(this.btnXem);
            this.pButton.Controls.Add(this.label2);
            this.pButton.Controls.Add(this.dtDen);
            this.pButton.Controls.Add(this.label10);
            this.pButton.Controls.Add(this.dtTu);
            this.pButton.Controls.Add(this.cbxDV);
            this.pButton.Controls.Add(this.chkAll);
            this.pButton.Controls.Add(this.btnSua);
            this.pButton.Controls.Add(this.txtSum);
            this.pButton.Controls.Add(this.btnThem);
            this.pButton.Controls.Add(this.txtSearch);
            this.pButton.Controls.Add(this.label1);
            this.pButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.pButton.Location = new System.Drawing.Point(0, 10);
            this.pButton.Name = "pButton";
            this.pButton.Size = new System.Drawing.Size(898, 38);
            this.pButton.TabIndex = 1;
            // 
            // btnXem
            // 
            this.btnXem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXem.Location = new System.Drawing.Point(383, 7);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(34, 25);
            this.btnXem.TabIndex = 262;
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
            this.label2.Location = new System.Drawing.Point(263, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 261;
            this.label2.Text = "đến";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtDen
            // 
            this.dtDen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtDen.CustomFormat = "dd/MM/yyyy";
            this.dtDen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDen.Location = new System.Drawing.Point(295, 11);
            this.dtDen.Name = "dtDen";
            this.dtDen.Size = new System.Drawing.Size(81, 20);
            this.dtDen.TabIndex = 260;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(120, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 259;
            this.label10.Text = "Từ ngày:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtTu
            // 
            this.dtTu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtTu.CustomFormat = "dd/MM/yyyy";
            this.dtTu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTu.Location = new System.Drawing.Point(175, 10);
            this.dtTu.Name = "dtTu";
            this.dtTu.Size = new System.Drawing.Size(81, 20);
            this.dtTu.TabIndex = 258;
            // 
            // cbxDV
            // 
            this.cbxDV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxDV.DataSource = this.tinhBindingSource;
            this.cbxDV.DisplayMember = "ten";
            this.cbxDV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDV.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxDV.FormattingEnabled = true;
            this.cbxDV.Location = new System.Drawing.Point(483, 7);
            this.cbxDV.Name = "cbxDV";
            this.cbxDV.Size = new System.Drawing.Size(147, 24);
            this.cbxDV.TabIndex = 238;
            this.cbxDV.ValueMember = "ma";
            this.cbxDV.SelectedIndexChanged += new System.EventHandler(this.cbxTinh_SelectedIndexChanged);
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
            this.chkAll.Location = new System.Drawing.Point(423, 10);
            this.chkAll.Name = "chkAll";
            this.chkAll.Size = new System.Drawing.Size(54, 20);
            this.chkAll.TabIndex = 187;
            this.chkAll.Values.Text = "tất cả";
            this.chkAll.CheckedChanged += new System.EventHandler(this.chkAll_CheckedChanged);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(84, 7);
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
            this.txtSum.Location = new System.Drawing.Point(853, 9);
            this.txtSum.Name = "txtSum";
            this.txtSum.Size = new System.Drawing.Size(40, 21);
            this.txtSum.TabIndex = 183;
            this.txtSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(12, 6);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(66, 25);
            this.btnThem.TabIndex = 182;
            this.btnThem.Values.Image = global::eHopdong.Properties.Resources.add;
            this.btnThem.Values.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(720, 10);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(127, 21);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(653, 13);
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
            this.ngay,
            this.makh,
            this.tenkh,
            this.diachi,
            this.noidung,
            this.username});
            this.dgv.DataSource = this.chamsocBindingSource;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 48);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 10;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(898, 444);
            this.dgv.TabIndex = 188;
            this.dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellDoubleClick);
            this.dgv.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_CellFormatting);
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
            // ngay
            // 
            this.ngay.DataPropertyName = "ngay";
            this.ngay.HeaderText = "Ngày";
            this.ngay.Name = "ngay";
            this.ngay.ReadOnly = true;
            this.ngay.Width = 70;
            // 
            // makh
            // 
            this.makh.DataPropertyName = "makh";
            this.makh.HeaderText = "makh";
            this.makh.Name = "makh";
            this.makh.ReadOnly = true;
            this.makh.Visible = false;
            // 
            // tenkh
            // 
            this.tenkh.DataPropertyName = "tenkh";
            this.tenkh.HeaderText = "Khách hàng";
            this.tenkh.Name = "tenkh";
            this.tenkh.ReadOnly = true;
            this.tenkh.Width = 200;
            // 
            // diachi
            // 
            this.diachi.DataPropertyName = "diachi";
            this.diachi.HeaderText = "Địa chỉ";
            this.diachi.Name = "diachi";
            this.diachi.ReadOnly = true;
            this.diachi.Width = 200;
            // 
            // noidung
            // 
            this.noidung.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.noidung.DataPropertyName = "noidung";
            this.noidung.HeaderText = "Nội dung";
            this.noidung.Name = "noidung";
            this.noidung.ReadOnly = true;
            // 
            // username
            // 
            this.username.DataPropertyName = "username";
            this.username.HeaderText = "Phụ trách";
            this.username.Name = "username";
            this.username.ReadOnly = true;
            this.username.Visible = false;
            // 
            // chamsocBindingSource
            // 
            this.chamsocBindingSource.DataSource = typeof(eHopdong.MODEL.Chamsoc);
            // 
            // uChamsoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.pButton);
            this.Controls.Add(this.pValue);
            this.Name = "uChamsoc";
            this.Size = new System.Drawing.Size(898, 492);
            this.Load += new System.EventHandler(this.uKhachhang_Load);
            this.pButton.ResumeLayout(false);
            this.pButton.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tinhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chamsocBindingSource)).EndInit();
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
        private Krypton.Toolkit.KryptonCheckBox chkAll;
        private System.Windows.Forms.ComboBox cbxDV;
        private System.Windows.Forms.BindingSource tinhBindingSource;
        private System.Windows.Forms.BindingSource chamsocBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtDen;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtTu;
        private Krypton.Toolkit.KryptonButton btnXem;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngay;
        private System.Windows.Forms.DataGridViewTextBoxColumn makh;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenkh;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn noidung;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
    }
}
