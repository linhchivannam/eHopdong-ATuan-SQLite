namespace eHopdong.BAOCAO
{
    partial class uBaoDoanhthu
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
            this.pValue = new System.Windows.Forms.Panel();
            this.pButton = new System.Windows.Forms.Panel();
            this.btnBaocaobang = new Krypton.Toolkit.KryptonButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btnXem = new Krypton.Toolkit.KryptonButton();
            this.label2 = new System.Windows.Forms.Label();
            this.dtDen = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.dtTu = new System.Windows.Forms.DateTimePicker();
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.tinhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chamsocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tinhBindingSource)).BeginInit();
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
            this.pButton.Controls.Add(this.btnBaocaobang);
            this.pButton.Controls.Add(this.label3);
            this.pButton.Controls.Add(this.btnXem);
            this.pButton.Controls.Add(this.label2);
            this.pButton.Controls.Add(this.dtDen);
            this.pButton.Controls.Add(this.label10);
            this.pButton.Controls.Add(this.dtTu);
            this.pButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.pButton.Location = new System.Drawing.Point(0, 10);
            this.pButton.Name = "pButton";
            this.pButton.Size = new System.Drawing.Size(898, 38);
            this.pButton.TabIndex = 1;
            // 
            // btnBaocaobang
            // 
            this.btnBaocaobang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBaocaobang.Location = new System.Drawing.Point(777, 6);
            this.btnBaocaobang.Name = "btnBaocaobang";
            this.btnBaocaobang.Size = new System.Drawing.Size(106, 25);
            this.btnBaocaobang.TabIndex = 271;
            this.btnBaocaobang.Tag = "";
            this.btnBaocaobang.ToolTipValues.Description = "Chỉnh sửa hợp đồng";
            this.btnBaocaobang.ToolTipValues.EnableToolTips = true;
            this.btnBaocaobang.ToolTipValues.Heading = "Sửa";
            this.btnBaocaobang.Values.Image = global::eHopdong.Properties.Resources.list;
            this.btnBaocaobang.Values.Text = "hiển thị bảng";
            this.btnBaocaobang.Click += new System.EventHandler(this.btnBaocaobang_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(12, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 18);
            this.label3.TabIndex = 270;
            this.label3.Text = "BÁO CÁO DOANH THU";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnXem
            // 
            this.btnXem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXem.Location = new System.Drawing.Point(737, 6);
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
            this.label2.Location = new System.Drawing.Point(617, 14);
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
            this.dtDen.Location = new System.Drawing.Point(649, 10);
            this.dtDen.Name = "dtDen";
            this.dtDen.Size = new System.Drawing.Size(81, 20);
            this.dtDen.TabIndex = 260;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(474, 14);
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
            this.dtTu.Location = new System.Drawing.Point(529, 9);
            this.dtTu.Name = "dtTu";
            this.dtTu.Size = new System.Drawing.Size(81, 20);
            this.dtTu.TabIndex = 258;
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.cartesianChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cartesianChart1.Location = new System.Drawing.Point(0, 48);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(898, 444);
            this.cartesianChart1.TabIndex = 4;
            this.cartesianChart1.Text = "cartesianChart1";
            this.cartesianChart1.Visible = false;
            // 
            // tinhBindingSource
            // 
            this.tinhBindingSource.DataSource = typeof(eHopdong.LINQ.tinh);
            // 
            // chamsocBindingSource
            // 
            this.chamsocBindingSource.DataSource = typeof(eHopdong.MODEL.Chamsoc);
            // 
            // uBaoDoanhthu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cartesianChart1);
            this.Controls.Add(this.pButton);
            this.Controls.Add(this.pValue);
            this.Name = "uBaoDoanhthu";
            this.Size = new System.Drawing.Size(898, 492);
            this.Load += new System.EventHandler(this.uKhachhang_Load);
            this.pButton.ResumeLayout(false);
            this.pButton.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tinhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chamsocBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pValue;
        private System.Windows.Forms.Panel pButton;
        private System.Windows.Forms.BindingSource tinhBindingSource;
        private System.Windows.Forms.BindingSource chamsocBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtDen;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtTu;
        private Krypton.Toolkit.KryptonButton btnXem;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private System.Windows.Forms.Label label3;
        private Krypton.Toolkit.KryptonButton btnBaocaobang;
    }
}
