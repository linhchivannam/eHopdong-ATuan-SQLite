namespace eHopdong.DANHMUC
{
    partial class uQuantri
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
            this.btnThem = new Krypton.Toolkit.KryptonButton();
            this.kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            this.kryptonButton2 = new Krypton.Toolkit.KryptonButton();
            this.kryptonButton3 = new Krypton.Toolkit.KryptonButton();
            this.kryptonButton4 = new Krypton.Toolkit.KryptonButton();
            this.btnPhuQui = new Krypton.Toolkit.KryptonButton();
            this.btnPhanquyen = new Krypton.Toolkit.KryptonButton();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThem.Location = new System.Drawing.Point(123, 90);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(152, 63);
            this.btnThem.TabIndex = 182;
            this.btnThem.Values.Image = global::eHopdong.Properties.Resources.add;
            this.btnThem.Values.Text = "Nhân viên";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kryptonButton1.Location = new System.Drawing.Point(281, 90);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(152, 63);
            this.kryptonButton1.TabIndex = 183;
            this.kryptonButton1.Values.Image = global::eHopdong.Properties.Resources.add;
            this.kryptonButton1.Values.Text = "Phòng ban";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // kryptonButton2
            // 
            this.kryptonButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kryptonButton2.Location = new System.Drawing.Point(172, 159);
            this.kryptonButton2.Name = "kryptonButton2";
            this.kryptonButton2.Size = new System.Drawing.Size(152, 63);
            this.kryptonButton2.TabIndex = 184;
            this.kryptonButton2.Values.Image = global::eHopdong.Properties.Resources.add;
            this.kryptonButton2.Values.Text = "Tỉnh";
            this.kryptonButton2.Click += new System.EventHandler(this.kryptonButton2_Click);
            // 
            // kryptonButton3
            // 
            this.kryptonButton3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kryptonButton3.Location = new System.Drawing.Point(330, 159);
            this.kryptonButton3.Name = "kryptonButton3";
            this.kryptonButton3.Size = new System.Drawing.Size(152, 63);
            this.kryptonButton3.TabIndex = 185;
            this.kryptonButton3.Values.Image = global::eHopdong.Properties.Resources.add;
            this.kryptonButton3.Values.Text = "Đơn vị";
            this.kryptonButton3.Click += new System.EventHandler(this.kryptonButton3_Click);
            // 
            // kryptonButton4
            // 
            this.kryptonButton4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kryptonButton4.Location = new System.Drawing.Point(252, 228);
            this.kryptonButton4.Name = "kryptonButton4";
            this.kryptonButton4.Size = new System.Drawing.Size(230, 63);
            this.kryptonButton4.TabIndex = 186;
            this.kryptonButton4.Values.Image = global::eHopdong.Properties.Resources.add;
            this.kryptonButton4.Values.Text = "Luân chuyển khách hàng";
            this.kryptonButton4.Click += new System.EventHandler(this.kryptonButton4_Click);
            // 
            // btnPhuQui
            // 
            this.btnPhuQui.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPhuQui.Location = new System.Drawing.Point(439, 90);
            this.btnPhuQui.Name = "btnPhuQui";
            this.btnPhuQui.Size = new System.Drawing.Size(43, 63);
            this.btnPhuQui.TabIndex = 187;
            this.btnPhuQui.Values.Image = global::eHopdong.Properties.Resources.add;
            this.btnPhuQui.Values.Text = "";
            this.btnPhuQui.Click += new System.EventHandler(this.btnPhuQui_Click);
            // 
            // btnPhanquyen
            // 
            this.btnPhanquyen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPhanquyen.Location = new System.Drawing.Point(123, 228);
            this.btnPhanquyen.Name = "btnPhanquyen";
            this.btnPhanquyen.Size = new System.Drawing.Size(123, 63);
            this.btnPhanquyen.TabIndex = 188;
            this.btnPhanquyen.Values.Image = global::eHopdong.Properties.Resources.add;
            this.btnPhanquyen.Values.Text = "Phân quyền";
            this.btnPhanquyen.Click += new System.EventHandler(this.btnPhanquyen_Click);
            // 
            // uQuantri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnPhanquyen);
            this.Controls.Add(this.btnPhuQui);
            this.Controls.Add(this.kryptonButton4);
            this.Controls.Add(this.kryptonButton3);
            this.Controls.Add(this.kryptonButton2);
            this.Controls.Add(this.kryptonButton1);
            this.Controls.Add(this.btnThem);
            this.Name = "uQuantri";
            this.Size = new System.Drawing.Size(604, 381);
            this.Load += new System.EventHandler(this.uQuantri_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonButton btnThem;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private Krypton.Toolkit.KryptonButton kryptonButton2;
        private Krypton.Toolkit.KryptonButton kryptonButton3;
        private Krypton.Toolkit.KryptonButton kryptonButton4;
        private Krypton.Toolkit.KryptonButton btnPhuQui;
        private Krypton.Toolkit.KryptonButton btnPhanquyen;
    }
}
