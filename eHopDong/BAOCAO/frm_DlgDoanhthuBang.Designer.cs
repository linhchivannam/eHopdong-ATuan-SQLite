namespace eHopdong.BAOCAO
{
    partial class frm_DlgDoanhthuBang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbngay = new System.Windows.Forms.Label();
            this.dgv = new Krypton.Toolkit.KryptonDataGridView();
            this.sott = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doanhthu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tienvon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loinhuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bCDoanhthuloinhuanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtSumloinhuan = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bCDoanhthuloinhuanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbngay
            // 
            this.lbngay.AutoSize = true;
            this.lbngay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbngay.ForeColor = System.Drawing.Color.Green;
            this.lbngay.Location = new System.Drawing.Point(184, 6);
            this.lbngay.Name = "lbngay";
            this.lbngay.Size = new System.Drawing.Size(216, 18);
            this.lbngay.TabIndex = 271;
            this.lbngay.Text = "BÁO CÁO CHĂM SÓC KHÁCH";
            this.lbngay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.sott,
            this.ten,
            this.doanhthu,
            this.tienvon,
            this.loinhuan});
            this.dgv.DataSource = this.bCDoanhthuloinhuanBindingSource;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv.Location = new System.Drawing.Point(0, 27);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 10;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(671, 267);
            this.dgv.TabIndex = 272;
            this.dgv.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_CellFormatting);
            // 
            // sott
            // 
            this.sott.DataPropertyName = "sott";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.sott.DefaultCellStyle = dataGridViewCellStyle2;
            this.sott.HeaderText = "TT";
            this.sott.Name = "sott";
            this.sott.ReadOnly = true;
            this.sott.Width = 30;
            // 
            // ten
            // 
            this.ten.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ten.DataPropertyName = "ten";
            this.ten.HeaderText = "Nhân viên";
            this.ten.Name = "ten";
            this.ten.ReadOnly = true;
            // 
            // doanhthu
            // 
            this.doanhthu.DataPropertyName = "doanhthu";
            this.doanhthu.HeaderText = "Doanh thu";
            this.doanhthu.Name = "doanhthu";
            this.doanhthu.ReadOnly = true;
            this.doanhthu.Width = 110;
            // 
            // tienvon
            // 
            this.tienvon.DataPropertyName = "tienvon";
            this.tienvon.HeaderText = "Tiền vốn";
            this.tienvon.Name = "tienvon";
            this.tienvon.ReadOnly = true;
            this.tienvon.Width = 110;
            // 
            // loinhuan
            // 
            this.loinhuan.DataPropertyName = "loinhuan";
            this.loinhuan.HeaderText = "Lợi nhuận";
            this.loinhuan.Name = "loinhuan";
            this.loinhuan.ReadOnly = true;
            this.loinhuan.Width = 110;
            // 
            // bCDoanhthuloinhuanBindingSource
            // 
            this.bCDoanhthuloinhuanBindingSource.DataSource = typeof(eHopdong.MODEL.BCDoanhthuloinhuan);
            // 
            // txtSumloinhuan
            // 
            this.txtSumloinhuan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSumloinhuan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtSumloinhuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSumloinhuan.ForeColor = System.Drawing.Color.Red;
            this.txtSumloinhuan.Location = new System.Drawing.Point(534, 1);
            this.txtSumloinhuan.Name = "txtSumloinhuan";
            this.txtSumloinhuan.ReadOnly = true;
            this.txtSumloinhuan.Size = new System.Drawing.Size(137, 23);
            this.txtSumloinhuan.TabIndex = 273;
            this.txtSumloinhuan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // frm_DlgDoanhthuBang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(671, 294);
            this.Controls.Add(this.txtSumloinhuan);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.lbngay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_DlgDoanhthuBang";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kết quả kinh doanh";
            this.Load += new System.EventHandler(this.frm_DlgChamsocBang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bCDoanhthuloinhuanBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lbngay;
        private Krypton.Toolkit.KryptonDataGridView dgv;
        private System.Windows.Forms.BindingSource bCDoanhthuloinhuanBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn sott;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn doanhthu;
        private System.Windows.Forms.DataGridViewTextBoxColumn tienvon;
        private System.Windows.Forms.DataGridViewTextBoxColumn loinhuan;
        private System.Windows.Forms.TextBox txtSumloinhuan;
    }
}
