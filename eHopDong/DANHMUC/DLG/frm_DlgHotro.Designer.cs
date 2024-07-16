namespace eHopdong.DANHMUC.DLG
{
    partial class frm_DlgHotro
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
            this.pValue = new Krypton.Toolkit.KryptonPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.dtNgay = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxNV = new System.Windows.Forms.ComboBox();
            this.nhanvienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tinhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.txtDT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDichvu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.btnHuy = new Krypton.Toolkit.KryptonButton();
            this.btnThoat = new Krypton.Toolkit.KryptonButton();
            this.btnLuu = new Krypton.Toolkit.KryptonButton();
            this.btnXoa = new Krypton.Toolkit.KryptonButton();
            this.btnSua = new Krypton.Toolkit.KryptonButton();
            this.btnThem = new Krypton.Toolkit.KryptonButton();
            this.lbSCT = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pValue)).BeginInit();
            this.pValue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhanvienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tinhBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pValue
            // 
            this.pValue.Controls.Add(this.lbSCT);
            this.pValue.Controls.Add(this.label10);
            this.pValue.Controls.Add(this.dtNgay);
            this.pValue.Controls.Add(this.label8);
            this.pValue.Controls.Add(this.cbxNV);
            this.pValue.Controls.Add(this.label5);
            this.pValue.Controls.Add(this.txtDT);
            this.pValue.Controls.Add(this.label4);
            this.pValue.Controls.Add(this.txtDichvu);
            this.pValue.Controls.Add(this.label3);
            this.pValue.Controls.Add(this.txtDiachi);
            this.pValue.Controls.Add(this.label1);
            this.pValue.Controls.Add(this.txtTenKH);
            this.pValue.Controls.Add(this.txtMaKH);
            this.pValue.Dock = System.Windows.Forms.DockStyle.Top;
            this.pValue.Location = new System.Drawing.Point(0, 0);
            this.pValue.Name = "pValue";
            this.pValue.PanelBackStyle = Krypton.Toolkit.PaletteBackStyle.GridHeaderRowList;
            this.pValue.Size = new System.Drawing.Size(758, 140);
            this.pValue.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(324, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 257;
            this.label10.Text = "Ngày:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtNgay
            // 
            this.dtNgay.CustomFormat = "dd/MM/yyyy";
            this.dtNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgay.Location = new System.Drawing.Point(365, 46);
            this.dtNgay.Name = "dtNgay";
            this.dtNgay.Size = new System.Drawing.Size(81, 20);
            this.dtNgay.TabIndex = 256;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(456, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 245;
            this.label8.Text = "Nhân viên:";
            // 
            // cbxNV
            // 
            this.cbxNV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxNV.DataSource = this.nhanvienBindingSource;
            this.cbxNV.DisplayMember = "ten";
            this.cbxNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNV.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxNV.FormattingEnabled = true;
            this.cbxNV.Location = new System.Drawing.Point(521, 73);
            this.cbxNV.Name = "cbxNV";
            this.cbxNV.Size = new System.Drawing.Size(225, 24);
            this.cbxNV.TabIndex = 244;
            this.cbxNV.ValueMember = "ma";
            // 
            // nhanvienBindingSource
            // 
            this.nhanvienBindingSource.DataSource = typeof(eHopdong.LINQ.nhanvien);
            // 
            // tinhBindingSource
            // 
            this.tinhBindingSource.DataSource = typeof(eHopdong.LINQ.tinh);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(457, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 159;
            this.label5.Text = "Điện thoại:";
            // 
            // txtDT
            // 
            this.txtDT.Enabled = false;
            this.txtDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDT.Location = new System.Drawing.Point(521, 43);
            this.txtDT.Name = "txtDT";
            this.txtDT.Size = new System.Drawing.Size(225, 23);
            this.txtDT.TabIndex = 158;
            this.txtDT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(23, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 157;
            this.label4.Text = "Nội dung:";
            // 
            // txtDichvu
            // 
            this.txtDichvu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDichvu.Location = new System.Drawing.Point(82, 73);
            this.txtDichvu.Multiline = true;
            this.txtDichvu.Name = "txtDichvu";
            this.txtDichvu.Size = new System.Drawing.Size(364, 54);
            this.txtDichvu.TabIndex = 156;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(472, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 155;
            this.label3.Text = "Địa chỉ:";
            // 
            // txtDiachi
            // 
            this.txtDiachi.Enabled = false;
            this.txtDiachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiachi.Location = new System.Drawing.Point(521, 14);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(225, 23);
            this.txtDiachi.TabIndex = 154;
            this.txtDiachi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(8, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 152;
            this.label1.Text = "Khách hàng:";
            // 
            // txtTenKH
            // 
            this.txtTenKH.Enabled = false;
            this.txtTenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKH.Location = new System.Drawing.Point(161, 14);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(285, 23);
            this.txtTenKH.TabIndex = 150;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKH.Location = new System.Drawing.Point(82, 14);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.ReadOnly = true;
            this.txtMaKH.Size = new System.Drawing.Size(73, 23);
            this.txtMaKH.TabIndex = 151;
            this.txtMaKH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMaKH.TextChanged += new System.EventHandler(this.txtMaKH_TextChanged);
            this.txtMaKH.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMaKH_KeyDown);
            this.txtMaKH.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtMaKH_PreviewKeyDown);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(355, 149);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(71, 25);
            this.btnHuy.TabIndex = 192;
            this.btnHuy.Values.Image = global::eHopdong.Properties.Resources.undo;
            this.btnHuy.Values.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(554, 149);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(90, 25);
            this.btnThoat.TabIndex = 191;
            this.btnThoat.Values.Image = global::eHopdong.Properties.Resources.close;
            this.btnThoat.Values.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(432, 149);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(116, 25);
            this.btnLuu.TabIndex = 190;
            this.btnLuu.Values.Image = global::eHopdong.Properties.Resources.save;
            this.btnLuu.Values.Text = "Lưu dữ liệu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(279, 149);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(70, 25);
            this.btnXoa.TabIndex = 189;
            this.btnXoa.Values.Image = global::eHopdong.Properties.Resources.del;
            this.btnXoa.Values.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(210, 149);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(63, 25);
            this.btnSua.TabIndex = 188;
            this.btnSua.Values.Image = global::eHopdong.Properties.Resources.edit;
            this.btnSua.Values.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(114, 149);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(90, 25);
            this.btnThem.TabIndex = 187;
            this.btnThem.Values.Image = global::eHopdong.Properties.Resources.add;
            this.btnThem.Values.Text = "Thêm mới";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lbSCT
            // 
            this.lbSCT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSCT.BackColor = System.Drawing.Color.Transparent;
            this.lbSCT.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSCT.ForeColor = System.Drawing.Color.Red;
            this.lbSCT.Location = new System.Drawing.Point(221, 40);
            this.lbSCT.Name = "lbSCT";
            this.lbSCT.Size = new System.Drawing.Size(85, 32);
            this.lbSCT.TabIndex = 261;
            this.lbSCT.Text = "00000";
            this.lbSCT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_DlgHotro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 182);
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
            this.Name = "frm_DlgHotro";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Liên hệ khách hàng";
            this.Load += new System.EventHandler(this.frm_DlgKhachhang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pValue)).EndInit();
            this.pValue.ResumeLayout(false);
            this.pValue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhanvienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tinhBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel pValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDichvu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxNV;
        private Krypton.Toolkit.KryptonButton btnHuy;
        private Krypton.Toolkit.KryptonButton btnThoat;
        private Krypton.Toolkit.KryptonButton btnLuu;
        private Krypton.Toolkit.KryptonButton btnXoa;
        private Krypton.Toolkit.KryptonButton btnSua;
        private Krypton.Toolkit.KryptonButton btnThem;
        private System.Windows.Forms.BindingSource nhanvienBindingSource;
        private System.Windows.Forms.BindingSource tinhBindingSource;
        public System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtNgay;
        public System.Windows.Forms.TextBox txtDiachi;
        public System.Windows.Forms.TextBox txtTenKH;
        public System.Windows.Forms.TextBox txtDT;
        public System.Windows.Forms.Label lbSCT;
    }
}
