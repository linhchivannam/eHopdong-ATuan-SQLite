namespace eHopdong.DANHMUC
{
    partial class frm_Nhanvien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pValue = new Krypton.Toolkit.KryptonPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxNhomquyen = new System.Windows.Forms.ComboBox();
            this.nhomquyenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtPass = new System.Windows.Forms.TextBox();
            this.chkDoiPass = new Krypton.Toolkit.KryptonCheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxBophan = new System.Windows.Forms.ComboBox();
            this.phongbanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chkOK = new Krypton.Toolkit.KryptonCheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.btnThem = new Krypton.Toolkit.KryptonButton();
            this.btnSua = new Krypton.Toolkit.KryptonButton();
            this.btnXoa = new Krypton.Toolkit.KryptonButton();
            this.btnLuu = new Krypton.Toolkit.KryptonButton();
            this.btnThoat = new Krypton.Toolkit.KryptonButton();
            this.btnHuy = new Krypton.Toolkit.KryptonButton();
            this.dgv = new Krypton.Toolkit.KryptonDataGridView();
            this.ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bophan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhomquyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ok = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dSNHANVIENADMINResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pValue)).BeginInit();
            this.pValue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhomquyenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongbanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSNHANVIENADMINResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pValue
            // 
            this.pValue.Controls.Add(this.label4);
            this.pValue.Controls.Add(this.cbxNhomquyen);
            this.pValue.Controls.Add(this.txtPass);
            this.pValue.Controls.Add(this.chkDoiPass);
            this.pValue.Controls.Add(this.label3);
            this.pValue.Controls.Add(this.cbxBophan);
            this.pValue.Controls.Add(this.chkOK);
            this.pValue.Controls.Add(this.label2);
            this.pValue.Controls.Add(this.label1);
            this.pValue.Controls.Add(this.txtTen);
            this.pValue.Controls.Add(this.txtMa);
            this.pValue.Dock = System.Windows.Forms.DockStyle.Top;
            this.pValue.Location = new System.Drawing.Point(0, 0);
            this.pValue.Name = "pValue";
            this.pValue.Size = new System.Drawing.Size(554, 121);
            this.pValue.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(310, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 245;
            this.label4.Text = "Nhóm quyền:";
            // 
            // cbxNhomquyen
            // 
            this.cbxNhomquyen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxNhomquyen.DataSource = this.nhomquyenBindingSource;
            this.cbxNhomquyen.DisplayMember = "ten";
            this.cbxNhomquyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNhomquyen.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxNhomquyen.FormattingEnabled = true;
            this.cbxNhomquyen.Location = new System.Drawing.Point(386, 77);
            this.cbxNhomquyen.Name = "cbxNhomquyen";
            this.cbxNhomquyen.Size = new System.Drawing.Size(156, 24);
            this.cbxNhomquyen.TabIndex = 244;
            this.cbxNhomquyen.ValueMember = "ma";
            // 
            // nhomquyenBindingSource
            // 
            this.nhomquyenBindingSource.DataSource = typeof(eHopdong.LINQ.nhomquyen);
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(386, 43);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '-';
            this.txtPass.Size = new System.Drawing.Size(156, 23);
            this.txtPass.TabIndex = 243;
            // 
            // chkDoiPass
            // 
            this.chkDoiPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkDoiPass.Location = new System.Drawing.Point(286, 46);
            this.chkDoiPass.Name = "chkDoiPass";
            this.chkDoiPass.Size = new System.Drawing.Size(95, 20);
            this.chkDoiPass.TabIndex = 242;
            this.chkDoiPass.Values.Text = "đổi mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(3, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 241;
            this.label3.Text = "Phòng, bộ phận:";
            // 
            // cbxBophan
            // 
            this.cbxBophan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxBophan.DataSource = this.phongbanBindingSource;
            this.cbxBophan.DisplayMember = "ten";
            this.cbxBophan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBophan.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxBophan.FormattingEnabled = true;
            this.cbxBophan.Location = new System.Drawing.Point(95, 72);
            this.cbxBophan.Name = "cbxBophan";
            this.cbxBophan.Size = new System.Drawing.Size(185, 24);
            this.cbxBophan.TabIndex = 240;
            this.cbxBophan.ValueMember = "ma";
            // 
            // phongbanBindingSource
            // 
            this.phongbanBindingSource.DataSource = typeof(eHopdong.LINQ.phongban);
            // 
            // chkOK
            // 
            this.chkOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkOK.Checked = true;
            this.chkOK.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkOK.Location = new System.Drawing.Point(286, 14);
            this.chkOK.Name = "chkOK";
            this.chkOK.Size = new System.Drawing.Size(80, 20);
            this.chkOK.TabIndex = 239;
            this.chkOK.Values.Text = "hoạt động";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(34, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 153;
            this.label2.Text = "Tên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(34, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 152;
            this.label1.Text = "Mã:";
            // 
            // txtTen
            // 
            this.txtTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Location = new System.Drawing.Point(65, 43);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(215, 23);
            this.txtTen.TabIndex = 150;
            this.txtTen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTen_KeyDown);
            // 
            // txtMa
            // 
            this.txtMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMa.Location = new System.Drawing.Point(65, 14);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(215, 23);
            this.txtMa.TabIndex = 151;
            this.txtMa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMa_KeyDown);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(12, 127);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(90, 25);
            this.btnThem.TabIndex = 181;
            this.btnThem.Values.Image = global::eHopdong.Properties.Resources.add;
            this.btnThem.Values.Text = "Thêm mới";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(108, 127);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(63, 25);
            this.btnSua.TabIndex = 182;
            this.btnSua.Values.Image = global::eHopdong.Properties.Resources.edit;
            this.btnSua.Values.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(177, 127);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(70, 25);
            this.btnXoa.TabIndex = 183;
            this.btnXoa.Values.Image = global::eHopdong.Properties.Resources.del;
            this.btnXoa.Values.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(330, 127);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(116, 25);
            this.btnLuu.TabIndex = 184;
            this.btnLuu.Values.Image = global::eHopdong.Properties.Resources.save;
            this.btnLuu.Values.Text = "Lưu dữ liệu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(452, 127);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(90, 25);
            this.btnThoat.TabIndex = 185;
            this.btnThoat.Values.Image = global::eHopdong.Properties.Resources.close;
            this.btnThoat.Values.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(253, 127);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(71, 25);
            this.btnHuy.TabIndex = 186;
            this.btnHuy.Values.Image = global::eHopdong.Properties.Resources.undo;
            this.btnHuy.Values.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.AutoGenerateColumns = false;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.ColumnHeadersHeight = 25;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ma,
            this.ten,
            this.bophan,
            this.nhomquyen,
            this.tenphong,
            this.ok});
            this.dgv.DataSource = this.dSNHANVIENADMINResultBindingSource;
            this.dgv.Location = new System.Drawing.Point(12, 158);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 20;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(530, 226);
            this.dgv.TabIndex = 187;
            this.dgv.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_RowEnter);
            // 
            // ma
            // 
            this.ma.DataPropertyName = "ma";
            this.ma.HeaderText = "Mã";
            this.ma.Name = "ma";
            this.ma.ReadOnly = true;
            // 
            // ten
            // 
            this.ten.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ten.DataPropertyName = "ten";
            this.ten.HeaderText = "Họ tên";
            this.ten.Name = "ten";
            this.ten.ReadOnly = true;
            // 
            // bophan
            // 
            this.bophan.DataPropertyName = "bophan";
            this.bophan.HeaderText = "bophan";
            this.bophan.Name = "bophan";
            this.bophan.ReadOnly = true;
            this.bophan.Visible = false;
            // 
            // nhomquyen
            // 
            this.nhomquyen.DataPropertyName = "nhomquyen";
            this.nhomquyen.HeaderText = "nhomquyen";
            this.nhomquyen.Name = "nhomquyen";
            this.nhomquyen.ReadOnly = true;
            this.nhomquyen.Visible = false;
            // 
            // tenphong
            // 
            this.tenphong.DataPropertyName = "tenphong";
            this.tenphong.HeaderText = "Phòng ban/Bộ phận";
            this.tenphong.Name = "tenphong";
            this.tenphong.ReadOnly = true;
            this.tenphong.Width = 150;
            // 
            // ok
            // 
            this.ok.DataPropertyName = "ok";
            this.ok.HeaderText = "OK";
            this.ok.Name = "ok";
            this.ok.ReadOnly = true;
            this.ok.Width = 35;
            // 
            // dSNHANVIENADMINResultBindingSource
            // 
            this.dSNHANVIENADMINResultBindingSource.DataSource = typeof(eHopdong.LINQ.DS_NHANVIEN_ADMINResult);
            // 
            // frm_Nhanvien
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(554, 396);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.pValue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Nhanvien";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nhân viên";
            this.Load += new System.EventHandler(this.frm_NhomSP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pValue)).EndInit();
            this.pValue.ResumeLayout(false);
            this.pValue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhomquyenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongbanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSNHANVIENADMINResultBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtMa;
        private Krypton.Toolkit.KryptonButton btnThem;
        private Krypton.Toolkit.KryptonButton btnSua;
        private Krypton.Toolkit.KryptonButton btnXoa;
        private Krypton.Toolkit.KryptonButton btnLuu;
        private Krypton.Toolkit.KryptonButton btnThoat;
        private Krypton.Toolkit.KryptonButton btnHuy;
        private Krypton.Toolkit.KryptonDataGridView dgv;
        private Krypton.Toolkit.KryptonPanel pValue;
        private System.Windows.Forms.TextBox txtPass;
        private Krypton.Toolkit.KryptonCheckBox chkDoiPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxBophan;
        private Krypton.Toolkit.KryptonCheckBox chkOK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxNhomquyen;
        private System.Windows.Forms.BindingSource dSNHANVIENADMINResultBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn bophan;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhomquyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenphong;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ok;
        private System.Windows.Forms.BindingSource phongbanBindingSource;
        private System.Windows.Forms.BindingSource nhomquyenBindingSource;
    }
}
