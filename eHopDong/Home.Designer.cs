namespace eHopdong
{
    partial class Home
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
            this.pTop = new System.Windows.Forms.Panel();
            this.btnMin = new Krypton.Toolkit.KryptonButton();
            this.btnMax = new Krypton.Toolkit.KryptonButton();
            this.btnClose = new Krypton.Toolkit.KryptonButton();
            this.label18 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pLeft = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbDangxuat = new System.Windows.Forms.Label();
            this.lbBophan = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.pHome = new System.Windows.Forms.Panel();
            this.lbVersion = new System.Windows.Forms.Label();
            this.pqBaocao = new eHopdong.PHUQUI.PQButton();
            this.pqQuantri = new eHopdong.PHUQUI.PQButton();
            this.pqHopdong = new eHopdong.PHUQUI.PQButton();
            this.pqLienhe = new eHopdong.PHUQUI.PQButton();
            this.pqKhachhang = new eHopdong.PHUQUI.PQButton();
            this.pqHome = new eHopdong.PHUQUI.PQButton();
            this.pMy = new eHopdong.PHUQUI.OvalPictureBox();
            this.pTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pMy)).BeginInit();
            this.SuspendLayout();
            // 
            // pTop
            // 
            this.pTop.BackColor = System.Drawing.Color.White;
            this.pTop.Controls.Add(this.btnMin);
            this.pTop.Controls.Add(this.btnMax);
            this.pTop.Controls.Add(this.btnClose);
            this.pTop.Controls.Add(this.label18);
            this.pTop.Controls.Add(this.pictureBox1);
            this.pTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTop.Location = new System.Drawing.Point(0, 0);
            this.pTop.Name = "pTop";
            this.pTop.Size = new System.Drawing.Size(1277, 52);
            this.pTop.TabIndex = 1;
            this.pTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pTop_MouseDown);
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.ButtonStyle = Krypton.Toolkit.ButtonStyle.LowProfile;
            this.btnMin.Location = new System.Drawing.Point(1145, 8);
            this.btnMin.Name = "btnMin";
            this.btnMin.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnMin.OverrideDefault.Border.Rounding = 20F;
            this.btnMin.OverrideFocus.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnMin.OverrideFocus.Border.Rounding = 20F;
            this.btnMin.Size = new System.Drawing.Size(36, 36);
            this.btnMin.TabIndex = 10;
            this.btnMin.Values.Image = global::eHopdong.Properties.Resources.minimize;
            this.btnMin.Values.Text = "";
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.ButtonStyle = Krypton.Toolkit.ButtonStyle.LowProfile;
            this.btnMax.Location = new System.Drawing.Point(1187, 8);
            this.btnMax.Name = "btnMax";
            this.btnMax.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnMax.OverrideDefault.Border.Rounding = 15F;
            this.btnMax.OverrideFocus.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnMax.OverrideFocus.Border.Rounding = 20F;
            this.btnMax.Size = new System.Drawing.Size(36, 36);
            this.btnMax.TabIndex = 183;
            this.btnMax.Values.Image = global::eHopdong.Properties.Resources.maximinze;
            this.btnMax.Values.Text = "";
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.ButtonStyle = Krypton.Toolkit.ButtonStyle.LowProfile;
            this.btnClose.Location = new System.Drawing.Point(1229, 8);
            this.btnClose.Name = "btnClose";
            this.btnClose.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnClose.OverrideDefault.Border.Rounding = 20F;
            this.btnClose.OverrideFocus.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnClose.OverrideFocus.Border.Rounding = 20F;
            this.btnClose.Size = new System.Drawing.Size(36, 36);
            this.btnClose.TabIndex = 182;
            this.btnClose.Values.Image = global::eHopdong.Properties.Resources.close_1;
            this.btnClose.Values.Text = "";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(160)))), ((int)(((byte)(104)))));
            this.label18.Location = new System.Drawing.Point(561, 18);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(271, 16);
            this.label18.TabIndex = 2;
            this.label18.Text = "TÔI LÀ CHIẾN BINH SALES CỦA MEKONG!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::eHopdong.Properties.Resources.Logo_Mekong;
            this.pictureBox1.Location = new System.Drawing.Point(28, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pLeft
            // 
            this.pLeft.BackColor = System.Drawing.Color.White;
            this.pLeft.Controls.Add(this.lbVersion);
            this.pLeft.Controls.Add(this.pqBaocao);
            this.pLeft.Controls.Add(this.pqQuantri);
            this.pLeft.Controls.Add(this.pqHopdong);
            this.pLeft.Controls.Add(this.pqLienhe);
            this.pLeft.Controls.Add(this.pqKhachhang);
            this.pLeft.Controls.Add(this.pqHome);
            this.pLeft.Controls.Add(this.pictureBox2);
            this.pLeft.Controls.Add(this.label2);
            this.pLeft.Controls.Add(this.panel4);
            this.pLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pLeft.Location = new System.Drawing.Point(0, 52);
            this.pLeft.Name = "pLeft";
            this.pLeft.Size = new System.Drawing.Size(180, 637);
            this.pLeft.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox2.Image = global::eHopdong.Properties.Resources.zalo;
            this.pictureBox2.Location = new System.Drawing.Point(17, 577);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(43, 583);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 14);
            this.label2.TabIndex = 6;
            this.label2.Text = "hỗ trợ: 0974.36.76.76";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.lbDangxuat);
            this.panel4.Controls.Add(this.pMy);
            this.panel4.Controls.Add(this.lbBophan);
            this.panel4.Controls.Add(this.lbName);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(180, 138);
            this.panel4.TabIndex = 6;
            // 
            // lbDangxuat
            // 
            this.lbDangxuat.AutoSize = true;
            this.lbDangxuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDangxuat.ForeColor = System.Drawing.Color.Red;
            this.lbDangxuat.Location = new System.Drawing.Point(118, 119);
            this.lbDangxuat.Name = "lbDangxuat";
            this.lbDangxuat.Size = new System.Drawing.Size(56, 13);
            this.lbDangxuat.TabIndex = 4;
            this.lbDangxuat.Text = "Đăng xuất";
            this.lbDangxuat.Visible = false;
            this.lbDangxuat.Click += new System.EventHandler(this.lbDangxuat_Click);
            // 
            // lbBophan
            // 
            this.lbBophan.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBophan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(160)))), ((int)(((byte)(104)))));
            this.lbBophan.Location = new System.Drawing.Point(0, 98);
            this.lbBophan.Name = "lbBophan";
            this.lbBophan.Size = new System.Drawing.Size(180, 19);
            this.lbBophan.TabIndex = 2;
            this.lbBophan.Text = "chưa đăng nhập";
            this.lbBophan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbName
            // 
            this.lbName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(160)))), ((int)(((byte)(104)))));
            this.lbName.Location = new System.Drawing.Point(0, 82);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(180, 16);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "Mekong";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pHome
            // 
            this.pHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(248)))), ((int)(((byte)(233)))));
            this.pHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pHome.Location = new System.Drawing.Point(180, 52);
            this.pHome.Name = "pHome";
            this.pHome.Size = new System.Drawing.Size(1097, 637);
            this.pHome.TabIndex = 3;
            // 
            // lbVersion
            // 
            this.lbVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbVersion.AutoSize = true;
            this.lbVersion.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVersion.ForeColor = System.Drawing.Color.Green;
            this.lbVersion.Location = new System.Drawing.Point(40, 614);
            this.lbVersion.Name = "lbVersion";
            this.lbVersion.Size = new System.Drawing.Size(47, 14);
            this.lbVersion.TabIndex = 17;
            this.lbVersion.Text = "Version:";
            // 
            // pqBaocao
            // 
            this.pqBaocao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(188)))), ((int)(((byte)(148)))));
            this.pqBaocao.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(188)))), ((int)(((byte)(148)))));
            this.pqBaocao.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.pqBaocao.BorderRadius = 20;
            this.pqBaocao.BorderSize = 0;
            this.pqBaocao.FlatAppearance.BorderSize = 0;
            this.pqBaocao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pqBaocao.ForeColor = System.Drawing.Color.White;
            this.pqBaocao.Image = global::eHopdong.Properties.Resources.Icon_04;
            this.pqBaocao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pqBaocao.Location = new System.Drawing.Point(17, 385);
            this.pqBaocao.Name = "pqBaocao";
            this.pqBaocao.Size = new System.Drawing.Size(163, 52);
            this.pqBaocao.TabIndex = 16;
            this.pqBaocao.Tag = "5";
            this.pqBaocao.Text = "     Báo cáo";
            this.pqBaocao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.pqBaocao.TextColor = System.Drawing.Color.White;
            this.pqBaocao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.pqBaocao.UseVisualStyleBackColor = false;
            this.pqBaocao.Click += new System.EventHandler(this.pqBaocao_Click);
            this.pqBaocao.MouseLeave += new System.EventHandler(this.pqHome_MouseLeave);
            this.pqBaocao.MouseHover += new System.EventHandler(this.pqHome_MouseHover);
            // 
            // pqQuantri
            // 
            this.pqQuantri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(208)))), ((int)(((byte)(179)))));
            this.pqQuantri.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(208)))), ((int)(((byte)(179)))));
            this.pqQuantri.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.pqQuantri.BorderRadius = 20;
            this.pqQuantri.BorderSize = 0;
            this.pqQuantri.FlatAppearance.BorderSize = 0;
            this.pqQuantri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pqQuantri.ForeColor = System.Drawing.Color.White;
            this.pqQuantri.Image = global::eHopdong.Properties.Resources.Icon_02;
            this.pqQuantri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pqQuantri.Location = new System.Drawing.Point(17, 443);
            this.pqQuantri.Name = "pqQuantri";
            this.pqQuantri.Size = new System.Drawing.Size(163, 52);
            this.pqQuantri.TabIndex = 15;
            this.pqQuantri.Tag = "0";
            this.pqQuantri.Text = "     Quản trị";
            this.pqQuantri.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.pqQuantri.TextColor = System.Drawing.Color.White;
            this.pqQuantri.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.pqQuantri.UseVisualStyleBackColor = false;
            this.pqQuantri.Click += new System.EventHandler(this.pqQuantri_Click);
            this.pqQuantri.MouseLeave += new System.EventHandler(this.pqHome_MouseLeave);
            this.pqQuantri.MouseHover += new System.EventHandler(this.pqHome_MouseHover);
            // 
            // pqHopdong
            // 
            this.pqHopdong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(160)))), ((int)(((byte)(104)))));
            this.pqHopdong.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(160)))), ((int)(((byte)(104)))));
            this.pqHopdong.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.pqHopdong.BorderRadius = 20;
            this.pqHopdong.BorderSize = 0;
            this.pqHopdong.FlatAppearance.BorderSize = 0;
            this.pqHopdong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pqHopdong.ForeColor = System.Drawing.Color.White;
            this.pqHopdong.Image = global::eHopdong.Properties.Resources.Icon_03;
            this.pqHopdong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pqHopdong.Location = new System.Drawing.Point(17, 327);
            this.pqHopdong.Name = "pqHopdong";
            this.pqHopdong.Size = new System.Drawing.Size(163, 52);
            this.pqHopdong.TabIndex = 14;
            this.pqHopdong.Tag = "4";
            this.pqHopdong.Text = "     Hợp đồng";
            this.pqHopdong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.pqHopdong.TextColor = System.Drawing.Color.White;
            this.pqHopdong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.pqHopdong.UseVisualStyleBackColor = false;
            this.pqHopdong.Click += new System.EventHandler(this.pqHopdong_Click);
            this.pqHopdong.MouseLeave += new System.EventHandler(this.pqHome_MouseLeave);
            this.pqHopdong.MouseHover += new System.EventHandler(this.pqHome_MouseHover);
            // 
            // pqLienhe
            // 
            this.pqLienhe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(118)))), ((int)(((byte)(75)))));
            this.pqLienhe.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(118)))), ((int)(((byte)(75)))));
            this.pqLienhe.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.pqLienhe.BorderRadius = 20;
            this.pqLienhe.BorderSize = 0;
            this.pqLienhe.FlatAppearance.BorderSize = 0;
            this.pqLienhe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pqLienhe.ForeColor = System.Drawing.Color.White;
            this.pqLienhe.Image = global::eHopdong.Properties.Resources.Icon_05;
            this.pqLienhe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pqLienhe.Location = new System.Drawing.Point(17, 269);
            this.pqLienhe.Name = "pqLienhe";
            this.pqLienhe.Size = new System.Drawing.Size(163, 52);
            this.pqLienhe.TabIndex = 13;
            this.pqLienhe.Tag = "3";
            this.pqLienhe.Text = "     Chăm sóc khách hàng";
            this.pqLienhe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.pqLienhe.TextColor = System.Drawing.Color.White;
            this.pqLienhe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.pqLienhe.UseVisualStyleBackColor = false;
            this.pqLienhe.Click += new System.EventHandler(this.pqLienhe_Click);
            this.pqLienhe.MouseLeave += new System.EventHandler(this.pqHome_MouseLeave);
            this.pqLienhe.MouseHover += new System.EventHandler(this.pqHome_MouseHover);
            // 
            // pqKhachhang
            // 
            this.pqKhachhang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(83)))), ((int)(((byte)(51)))));
            this.pqKhachhang.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(83)))), ((int)(((byte)(51)))));
            this.pqKhachhang.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.pqKhachhang.BorderRadius = 20;
            this.pqKhachhang.BorderSize = 0;
            this.pqKhachhang.FlatAppearance.BorderSize = 0;
            this.pqKhachhang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pqKhachhang.ForeColor = System.Drawing.Color.White;
            this.pqKhachhang.Image = global::eHopdong.Properties.Resources.Icon_01;
            this.pqKhachhang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pqKhachhang.Location = new System.Drawing.Point(17, 211);
            this.pqKhachhang.Name = "pqKhachhang";
            this.pqKhachhang.Size = new System.Drawing.Size(163, 52);
            this.pqKhachhang.TabIndex = 12;
            this.pqKhachhang.Tag = "2";
            this.pqKhachhang.Text = "     Khách hàng";
            this.pqKhachhang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.pqKhachhang.TextColor = System.Drawing.Color.White;
            this.pqKhachhang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.pqKhachhang.UseVisualStyleBackColor = false;
            this.pqKhachhang.Click += new System.EventHandler(this.pqButton2_Click);
            this.pqKhachhang.MouseLeave += new System.EventHandler(this.pqHome_MouseLeave);
            this.pqKhachhang.MouseHover += new System.EventHandler(this.pqHome_MouseHover);
            // 
            // pqHome
            // 
            this.pqHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(30)))));
            this.pqHome.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(30)))));
            this.pqHome.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.pqHome.BorderRadius = 20;
            this.pqHome.BorderSize = 0;
            this.pqHome.FlatAppearance.BorderSize = 0;
            this.pqHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pqHome.ForeColor = System.Drawing.Color.White;
            this.pqHome.Image = global::eHopdong.Properties.Resources.Icon_06;
            this.pqHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pqHome.Location = new System.Drawing.Point(17, 153);
            this.pqHome.Name = "pqHome";
            this.pqHome.Size = new System.Drawing.Size(163, 52);
            this.pqHome.TabIndex = 11;
            this.pqHome.Tag = "1";
            this.pqHome.Text = "     Tổng quan";
            this.pqHome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.pqHome.TextColor = System.Drawing.Color.White;
            this.pqHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.pqHome.UseVisualStyleBackColor = false;
            this.pqHome.Click += new System.EventHandler(this.pqHome_Click);
            this.pqHome.MouseLeave += new System.EventHandler(this.pqHome_MouseLeave);
            this.pqHome.MouseHover += new System.EventHandler(this.pqHome_MouseHover);
            // 
            // pMy
            // 
            this.pMy.BackColor = System.Drawing.Color.White;
            this.pMy.Image = global::eHopdong.Properties.Resources.mekong_icon;
            this.pMy.Location = new System.Drawing.Point(61, 21);
            this.pMy.Name = "pMy";
            this.pMy.Size = new System.Drawing.Size(58, 58);
            this.pMy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pMy.TabIndex = 3;
            this.pMy.TabStop = false;
            this.pMy.Click += new System.EventHandler(this.pMy_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 689);
            this.Controls.Add(this.pHome);
            this.Controls.Add(this.pLeft);
            this.Controls.Add(this.pTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Home_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Home_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Home_MouseUp);
            this.pTop.ResumeLayout(false);
            this.pTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pLeft.ResumeLayout(false);
            this.pLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pMy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pTop;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pLeft;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel pHome;
        private PHUQUI.OvalPictureBox pMy;
        private System.Windows.Forms.Label label2;
        private Krypton.Toolkit.KryptonButton btnClose;
        private Krypton.Toolkit.KryptonButton btnMin;
        private Krypton.Toolkit.KryptonButton btnMax;
        private System.Windows.Forms.PictureBox pictureBox2;
        private PHUQUI.PQButton pqHome;
        private PHUQUI.PQButton pqLienhe;
        private PHUQUI.PQButton pqKhachhang;
        private PHUQUI.PQButton pqHopdong;
        private PHUQUI.PQButton pqQuantri;
        private PHUQUI.PQButton pqBaocao;
        public System.Windows.Forms.Label lbBophan;
        public System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbDangxuat;
        private System.Windows.Forms.Label lbVersion;
    }
}