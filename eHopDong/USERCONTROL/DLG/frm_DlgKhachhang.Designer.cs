
namespace eHopdong.USERCONTROL.DLG
{
    partial class frm_DlgKhachhang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pLeft = new Krypton.Toolkit.KryptonPanel();
            this.dgv = new Krypton.Toolkit.KryptonDataGridView();
            this.Ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Daidien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Chucvu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dienthoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Masothue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Taikhoannganhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sotaikhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pValue = new Krypton.Toolkit.KryptonPanel();
            this.btnChon = new Krypton.Toolkit.KryptonButton();
            this.label14 = new System.Windows.Forms.Label();
            this.txtKHChucvu = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtKHDaidien = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtKHMST = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtKHNH = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtKHSoTK = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtKHten = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtKHma = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKhDienthoai = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKHDiachi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnHuy = new Krypton.Toolkit.KryptonButton();
            this.btnThoat = new Krypton.Toolkit.KryptonButton();
            this.btnLuu = new Krypton.Toolkit.KryptonButton();
            this.btnXoa = new Krypton.Toolkit.KryptonButton();
            this.btnSua = new Krypton.Toolkit.KryptonButton();
            this.btnThem = new Krypton.Toolkit.KryptonButton();
            this.khachhangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pLeft)).BeginInit();
            this.pLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pValue)).BeginInit();
            this.pValue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.khachhangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pLeft
            // 
            this.pLeft.Controls.Add(this.dgv);
            this.pLeft.Controls.Add(this.kryptonPanel2);
            this.pLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pLeft.Location = new System.Drawing.Point(0, 0);
            this.pLeft.Name = "pLeft";
            this.pLeft.Size = new System.Drawing.Size(489, 418);
            this.pLeft.TabIndex = 0;
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
            this.Ma,
            this.Ten,
            this.Daidien,
            this.Chucvu,
            this.Diachi,
            this.Dienthoai,
            this.Masothue,
            this.Taikhoannganhang,
            this.Sotaikhoan});
            this.dgv.DataSource = this.khachhangBindingSource;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 44);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 10;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(489, 374);
            this.dgv.TabIndex = 189;
            this.dgv.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_RowEnter);
            // 
            // Ma
            // 
            this.Ma.DataPropertyName = "Ma";
            this.Ma.HeaderText = "Mã KH";
            this.Ma.Name = "Ma";
            this.Ma.ReadOnly = true;
            // 
            // Ten
            // 
            this.Ten.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ten.DataPropertyName = "Ten";
            this.Ten.HeaderText = "Khách hàng";
            this.Ten.Name = "Ten";
            this.Ten.ReadOnly = true;
            // 
            // Daidien
            // 
            this.Daidien.DataPropertyName = "Daidien";
            this.Daidien.HeaderText = "Daidien";
            this.Daidien.Name = "Daidien";
            this.Daidien.ReadOnly = true;
            this.Daidien.Visible = false;
            // 
            // Chucvu
            // 
            this.Chucvu.DataPropertyName = "Chucvu";
            this.Chucvu.HeaderText = "Chucvu";
            this.Chucvu.Name = "Chucvu";
            this.Chucvu.ReadOnly = true;
            this.Chucvu.Visible = false;
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
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.txtSum);
            this.kryptonPanel2.Controls.Add(this.txtSearch);
            this.kryptonPanel2.Controls.Add(this.label1);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(489, 44);
            this.kryptonPanel2.TabIndex = 0;
            // 
            // txtSum
            // 
            this.txtSum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSum.Location = new System.Drawing.Point(437, 12);
            this.txtSum.Name = "txtSum";
            this.txtSum.Size = new System.Drawing.Size(46, 23);
            this.txtSum.TabIndex = 184;
            this.txtSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(86, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(345, 23);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tìm kiếm:";
            // 
            // pValue
            // 
            this.pValue.Controls.Add(this.btnChon);
            this.pValue.Controls.Add(this.label14);
            this.pValue.Controls.Add(this.txtKHChucvu);
            this.pValue.Controls.Add(this.label15);
            this.pValue.Controls.Add(this.txtKHDaidien);
            this.pValue.Controls.Add(this.label11);
            this.pValue.Controls.Add(this.txtKHMST);
            this.pValue.Controls.Add(this.label12);
            this.pValue.Controls.Add(this.txtKHNH);
            this.pValue.Controls.Add(this.label13);
            this.pValue.Controls.Add(this.txtKHSoTK);
            this.pValue.Controls.Add(this.label10);
            this.pValue.Controls.Add(this.txtKHten);
            this.pValue.Controls.Add(this.label8);
            this.pValue.Controls.Add(this.txtKHma);
            this.pValue.Controls.Add(this.label5);
            this.pValue.Controls.Add(this.txtKhDienthoai);
            this.pValue.Controls.Add(this.label3);
            this.pValue.Controls.Add(this.txtKHDiachi);
            this.pValue.Controls.Add(this.label7);
            this.pValue.Controls.Add(this.btnHuy);
            this.pValue.Controls.Add(this.btnThoat);
            this.pValue.Controls.Add(this.btnLuu);
            this.pValue.Controls.Add(this.btnXoa);
            this.pValue.Controls.Add(this.btnSua);
            this.pValue.Controls.Add(this.btnThem);
            this.pValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pValue.Location = new System.Drawing.Point(489, 0);
            this.pValue.Name = "pValue";
            this.pValue.PanelBackStyle = Krypton.Toolkit.PaletteBackStyle.HeaderSecondary;
            this.pValue.Size = new System.Drawing.Size(433, 418);
            this.pValue.TabIndex = 1;
            // 
            // btnChon
            // 
            this.btnChon.Location = new System.Drawing.Point(6, 384);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(415, 25);
            this.btnChon.TabIndex = 305;
            this.btnChon.Values.Image = global::eHopdong.Properties.Resources.zalo;
            this.btnChon.Values.Text = "Chọn khách hàng";
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Location = new System.Drawing.Point(32, 151);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 17);
            this.label14.TabIndex = 304;
            this.label14.Text = "Chức vụ:";
            // 
            // txtKHChucvu
            // 
            this.txtKHChucvu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKHChucvu.Location = new System.Drawing.Point(97, 146);
            this.txtKHChucvu.Name = "txtKHChucvu";
            this.txtKHChucvu.Size = new System.Drawing.Size(324, 23);
            this.txtKHChucvu.TabIndex = 303;
            this.txtKHChucvu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Location = new System.Drawing.Point(31, 122);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 17);
            this.label15.TabIndex = 302;
            this.label15.Text = "Đại diện:";
            // 
            // txtKHDaidien
            // 
            this.txtKHDaidien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKHDaidien.Location = new System.Drawing.Point(97, 117);
            this.txtKHDaidien.Name = "txtKHDaidien";
            this.txtKHDaidien.Size = new System.Drawing.Size(324, 23);
            this.txtKHDaidien.TabIndex = 301;
            this.txtKHDaidien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(54, 238);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 17);
            this.label11.TabIndex = 300;
            this.label11.Text = "MST:";
            // 
            // txtKHMST
            // 
            this.txtKHMST.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKHMST.Location = new System.Drawing.Point(97, 233);
            this.txtKHMST.Name = "txtKHMST";
            this.txtKHMST.Size = new System.Drawing.Size(324, 23);
            this.txtKHMST.TabIndex = 299;
            this.txtKHMST.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(13, 296);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 17);
            this.label12.TabIndex = 298;
            this.label12.Text = "Ngân hàng:";
            // 
            // txtKHNH
            // 
            this.txtKHNH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKHNH.Location = new System.Drawing.Point(97, 291);
            this.txtKHNH.Name = "txtKHNH";
            this.txtKHNH.Size = new System.Drawing.Size(324, 23);
            this.txtKHNH.TabIndex = 297;
            this.txtKHNH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(44, 272);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 17);
            this.label13.TabIndex = 296;
            this.label13.Text = "Số TK:";
            // 
            // txtKHSoTK
            // 
            this.txtKHSoTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKHSoTK.Location = new System.Drawing.Point(97, 262);
            this.txtKHSoTK.Name = "txtKHSoTK";
            this.txtKHSoTK.Size = new System.Drawing.Size(324, 23);
            this.txtKHSoTK.TabIndex = 295;
            this.txtKHSoTK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(58, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 17);
            this.label10.TabIndex = 294;
            this.label10.Text = "Tên:";
            // 
            // txtKHten
            // 
            this.txtKHten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKHten.Location = new System.Drawing.Point(97, 88);
            this.txtKHten.Name = "txtKHten";
            this.txtKHten.Size = new System.Drawing.Size(324, 23);
            this.txtKHten.TabIndex = 293;
            this.txtKHten.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(41, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 17);
            this.label8.TabIndex = 292;
            this.label8.Text = "Mã KH:";
            // 
            // txtKHma
            // 
            this.txtKHma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKHma.Location = new System.Drawing.Point(97, 59);
            this.txtKHma.Name = "txtKHma";
            this.txtKHma.Size = new System.Drawing.Size(324, 23);
            this.txtKHma.TabIndex = 291;
            this.txtKHma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(19, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 290;
            this.label5.Text = "Điện thoại:";
            // 
            // txtKhDienthoai
            // 
            this.txtKhDienthoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKhDienthoai.Location = new System.Drawing.Point(97, 204);
            this.txtKhDienthoai.Name = "txtKhDienthoai";
            this.txtKhDienthoai.Size = new System.Drawing.Size(324, 23);
            this.txtKhDienthoai.TabIndex = 289;
            this.txtKhDienthoai.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(40, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 288;
            this.label3.Text = "Địa chỉ:";
            // 
            // txtKHDiachi
            // 
            this.txtKHDiachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKHDiachi.Location = new System.Drawing.Point(97, 175);
            this.txtKHDiachi.Name = "txtKHDiachi";
            this.txtKHDiachi.Size = new System.Drawing.Size(324, 23);
            this.txtKHDiachi.TabIndex = 287;
            this.txtKHDiachi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(19, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(292, 47);
            this.label7.TabIndex = 203;
            this.label7.Text = "KHÁCH HÀNG";
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(97, 351);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(106, 25);
            this.btnHuy.TabIndex = 201;
            this.btnHuy.Values.Image = global::eHopdong.Properties.Resources.undo;
            this.btnHuy.Values.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(331, 351);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(90, 25);
            this.btnThoat.TabIndex = 200;
            this.btnThoat.Values.Image = global::eHopdong.Properties.Resources.close;
            this.btnThoat.Values.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(209, 351);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(116, 25);
            this.btnLuu.TabIndex = 199;
            this.btnLuu.Values.Image = global::eHopdong.Properties.Resources.save;
            this.btnLuu.Values.Text = "Lưu dữ liệu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(262, 320);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(70, 25);
            this.btnXoa.TabIndex = 198;
            this.btnXoa.Values.Image = global::eHopdong.Properties.Resources.del;
            this.btnXoa.Values.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(193, 320);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(63, 25);
            this.btnSua.TabIndex = 197;
            this.btnSua.Values.Image = global::eHopdong.Properties.Resources.edit;
            this.btnSua.Values.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(97, 320);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(90, 25);
            this.btnThem.TabIndex = 196;
            this.btnThem.Values.Image = global::eHopdong.Properties.Resources.add;
            this.btnThem.Values.Text = "Thêm mới";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // khachhangBindingSource
            // 
            this.khachhangBindingSource.DataSource = typeof(PQDb.MODEL.Khachhang);
            // 
            // frm_DlgKhachhang
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(922, 418);
            this.Controls.Add(this.pValue);
            this.Controls.Add(this.pLeft);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_DlgKhachhang";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Người dùng";
            this.Load += new System.EventHandler(this.frm_DlgUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pLeft)).EndInit();
            this.pLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pValue)).EndInit();
            this.pValue.ResumeLayout(false);
            this.pValue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.khachhangBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel pLeft;
        private Krypton.Toolkit.KryptonPanel pValue;
        private Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private Krypton.Toolkit.KryptonDataGridView dgv;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSum;
        private Krypton.Toolkit.KryptonButton btnXoa;
        private Krypton.Toolkit.KryptonButton btnSua;
        private Krypton.Toolkit.KryptonButton btnThem;
        private Krypton.Toolkit.KryptonButton btnHuy;
        private Krypton.Toolkit.KryptonButton btnThoat;
        private Krypton.Toolkit.KryptonButton btnLuu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.TextBox txtKHChucvu;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.TextBox txtKHDaidien;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox txtKHMST;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox txtKHNH;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.TextBox txtKHSoTK;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txtKHten;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtKHma;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtKhDienthoai;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtKHDiachi;
        private Krypton.Toolkit.KryptonButton btnChon;
        private System.Windows.Forms.BindingSource khachhangBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn Daidien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Chucvu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dienthoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Masothue;
        private System.Windows.Forms.DataGridViewTextBoxColumn Taikhoannganhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sotaikhoan;
    }
}
