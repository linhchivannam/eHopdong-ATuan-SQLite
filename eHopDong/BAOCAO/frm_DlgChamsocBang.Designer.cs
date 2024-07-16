namespace eHopdong.BAOCAO
{
    partial class frm_DlgChamsocBang
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
            this.sokh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.solan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bCChamsocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bCChamsocBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbngay
            // 
            this.lbngay.AutoSize = true;
            this.lbngay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbngay.ForeColor = System.Drawing.Color.Green;
            this.lbngay.Location = new System.Drawing.Point(133, 6);
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
            this.sokh,
            this.solan});
            this.dgv.DataSource = this.bCChamsocBindingSource;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv.Location = new System.Drawing.Point(0, 27);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 10;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(502, 267);
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
            this.sott.Width = 50;
            // 
            // ten
            // 
            this.ten.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ten.DataPropertyName = "ten";
            this.ten.HeaderText = "Nhân viên";
            this.ten.Name = "ten";
            this.ten.ReadOnly = true;
            // 
            // sokh
            // 
            this.sokh.DataPropertyName = "sokh";
            this.sokh.HeaderText = "Số KH";
            this.sokh.Name = "sokh";
            this.sokh.ReadOnly = true;
            this.sokh.Width = 80;
            // 
            // solan
            // 
            this.solan.DataPropertyName = "solan";
            this.solan.HeaderText = "Số lần";
            this.solan.Name = "solan";
            this.solan.ReadOnly = true;
            this.solan.Width = 80;
            // 
            // bCChamsocBindingSource
            // 
            this.bCChamsocBindingSource.DataSource = typeof(eHopdong.MODEL.BCChamsoc);
            // 
            // frm_DlgChamsocBang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(502, 294);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.lbngay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_DlgChamsocBang";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kết quả chăm sóc khách hàng";
            this.Load += new System.EventHandler(this.frm_DlgChamsocBang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bCChamsocBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lbngay;
        private Krypton.Toolkit.KryptonDataGridView dgv;
        private System.Windows.Forms.BindingSource bCChamsocBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn sott;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn sokh;
        private System.Windows.Forms.DataGridViewTextBoxColumn solan;
    }
}
