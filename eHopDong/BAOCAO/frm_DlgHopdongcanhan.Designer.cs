namespace eHopdong.BAOCAO
{
    partial class frm_DlgHopdongcanhan
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
            this.pValue = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbxDV = new System.Windows.Forms.ComboBox();
            this.tinhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chkAll = new Krypton.Toolkit.KryptonCheckBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSumloinhuan = new System.Windows.Forms.TextBox();
            this.txtSotien = new System.Windows.Forms.TextBox();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.dgv = new Krypton.Toolkit.KryptonDataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kethucngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noidung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhomdichvu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.covat = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.sotien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sotienvon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loinhuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ketthuc = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cungcapdichvuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tinhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cungcapdichvuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pValue
            // 
            this.pValue.BackColor = System.Drawing.Color.White;
            this.pValue.Dock = System.Windows.Forms.DockStyle.Top;
            this.pValue.Location = new System.Drawing.Point(0, 0);
            this.pValue.Margin = new System.Windows.Forms.Padding(0);
            this.pValue.Name = "pValue";
            this.pValue.Size = new System.Drawing.Size(817, 10);
            this.pValue.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.cbxDV);
            this.panel1.Controls.Add(this.chkAll);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtSumloinhuan);
            this.panel1.Controls.Add(this.txtSotien);
            this.panel1.Controls.Add(this.txtSum);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(817, 36);
            this.panel1.TabIndex = 2;
            // 
            // cbxDV
            // 
            this.cbxDV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxDV.DataSource = this.tinhBindingSource;
            this.cbxDV.DisplayMember = "ten";
            this.cbxDV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDV.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxDV.FormattingEnabled = true;
            this.cbxDV.Location = new System.Drawing.Point(180, 7);
            this.cbxDV.Name = "cbxDV";
            this.cbxDV.Size = new System.Drawing.Size(116, 24);
            this.cbxDV.TabIndex = 246;
            this.cbxDV.ValueMember = "ma";
            this.cbxDV.SelectedIndexChanged += new System.EventHandler(this.cbxDV_SelectedIndexChanged);
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
            this.chkAll.Location = new System.Drawing.Point(120, 9);
            this.chkAll.Name = "chkAll";
            this.chkAll.Size = new System.Drawing.Size(54, 20);
            this.chkAll.TabIndex = 245;
            this.chkAll.Values.Text = "tất cả";
            this.chkAll.CheckedChanged += new System.EventHandler(this.chkAll_CheckedChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(369, 9);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(104, 21);
            this.txtSearch.TabIndex = 244;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(302, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 243;
            this.label1.Text = "Tìm kiếm:";
            // 
            // txtSumloinhuan
            // 
            this.txtSumloinhuan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSumloinhuan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtSumloinhuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSumloinhuan.ForeColor = System.Drawing.Color.Red;
            this.txtSumloinhuan.Location = new System.Drawing.Point(622, 7);
            this.txtSumloinhuan.Name = "txtSumloinhuan";
            this.txtSumloinhuan.ReadOnly = true;
            this.txtSumloinhuan.Size = new System.Drawing.Size(137, 23);
            this.txtSumloinhuan.TabIndex = 242;
            this.txtSumloinhuan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSotien
            // 
            this.txtSotien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSotien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtSotien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSotien.ForeColor = System.Drawing.Color.Red;
            this.txtSotien.Location = new System.Drawing.Point(479, 7);
            this.txtSotien.Name = "txtSotien";
            this.txtSotien.ReadOnly = true;
            this.txtSotien.Size = new System.Drawing.Size(137, 23);
            this.txtSotien.TabIndex = 241;
            this.txtSotien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSum
            // 
            this.txtSum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSum.Location = new System.Drawing.Point(765, 7);
            this.txtSum.Name = "txtSum";
            this.txtSum.Size = new System.Drawing.Size(40, 21);
            this.txtSum.TabIndex = 240;
            this.txtSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.kethucngay,
            this.noidung,
            this.nhomdichvu,
            this.covat,
            this.sotien,
            this.sotienvon,
            this.loinhuan,
            this.ketthuc});
            this.dgv.DataSource = this.cungcapdichvuBindingSource;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 46);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 10;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(817, 380);
            this.dgv.TabIndex = 189;
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
            this.id.Width = 50;
            // 
            // ngay
            // 
            this.ngay.DataPropertyName = "ngay";
            this.ngay.HeaderText = "Ngày";
            this.ngay.Name = "ngay";
            this.ngay.ReadOnly = true;
            this.ngay.Width = 80;
            // 
            // kethucngay
            // 
            this.kethucngay.DataPropertyName = "kethucngay";
            this.kethucngay.HeaderText = "Kết thúc";
            this.kethucngay.Name = "kethucngay";
            this.kethucngay.ReadOnly = true;
            this.kethucngay.Width = 80;
            // 
            // noidung
            // 
            this.noidung.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.noidung.DataPropertyName = "noidung";
            this.noidung.HeaderText = "Nội dung";
            this.noidung.Name = "noidung";
            this.noidung.ReadOnly = true;
            // 
            // nhomdichvu
            // 
            this.nhomdichvu.DataPropertyName = "nhomdichvu";
            this.nhomdichvu.HeaderText = "nhomdichvu";
            this.nhomdichvu.Name = "nhomdichvu";
            this.nhomdichvu.ReadOnly = true;
            this.nhomdichvu.Visible = false;
            // 
            // covat
            // 
            this.covat.DataPropertyName = "covat";
            this.covat.HeaderText = "VAT";
            this.covat.Name = "covat";
            this.covat.ReadOnly = true;
            this.covat.Width = 30;
            // 
            // sotien
            // 
            this.sotien.DataPropertyName = "sotien";
            this.sotien.HeaderText = "Số tiền";
            this.sotien.Name = "sotien";
            this.sotien.ReadOnly = true;
            // 
            // sotienvon
            // 
            this.sotienvon.DataPropertyName = "sotienvon";
            this.sotienvon.HeaderText = "Tiền vốn";
            this.sotienvon.Name = "sotienvon";
            this.sotienvon.ReadOnly = true;
            // 
            // loinhuan
            // 
            this.loinhuan.DataPropertyName = "loinhuan";
            this.loinhuan.HeaderText = "Lợi nhuận";
            this.loinhuan.Name = "loinhuan";
            this.loinhuan.ReadOnly = true;
            // 
            // ketthuc
            // 
            this.ketthuc.DataPropertyName = "ketthuc";
            this.ketthuc.HeaderText = "ketthuc";
            this.ketthuc.Name = "ketthuc";
            this.ketthuc.ReadOnly = true;
            this.ketthuc.Visible = false;
            // 
            // cungcapdichvuBindingSource
            // 
            this.cungcapdichvuBindingSource.DataSource = typeof(eHopdong.LINQ.cungcapdichvu);
            // 
            // frm_DlgHopdongcanhan
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(817, 426);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pValue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_DlgHopdongcanhan";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quá trình hợp tác";
            this.Load += new System.EventHandler(this.frm_DlgHopdongcanhan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tinhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cungcapdichvuBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pValue;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSotien;
        private System.Windows.Forms.TextBox txtSum;
        private System.Windows.Forms.TextBox txtSumloinhuan;
        private System.Windows.Forms.ComboBox cbxDV;
        private Krypton.Toolkit.KryptonCheckBox chkAll;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource cungcapdichvuBindingSource;
        private Krypton.Toolkit.KryptonDataGridView dgv;
        private System.Windows.Forms.BindingSource tinhBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngay;
        private System.Windows.Forms.DataGridViewTextBoxColumn kethucngay;
        private System.Windows.Forms.DataGridViewTextBoxColumn noidung;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhomdichvu;
        private System.Windows.Forms.DataGridViewCheckBoxColumn covat;
        private System.Windows.Forms.DataGridViewTextBoxColumn sotien;
        private System.Windows.Forms.DataGridViewTextBoxColumn sotienvon;
        private System.Windows.Forms.DataGridViewTextBoxColumn loinhuan;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ketthuc;
    }
}
