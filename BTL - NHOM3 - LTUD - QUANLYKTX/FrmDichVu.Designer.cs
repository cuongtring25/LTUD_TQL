namespace quanLyktx
{
    partial class FrmDichVu
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
            this.btnChinh = new System.Windows.Forms.Button();
            this.btnTaoMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.cboMaDV = new System.Windows.Forms.ComboBox();
            this.dgvDichVu = new System.Windows.Forms.DataGridView();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtDichvu = new System.Windows.Forms.TextBox();
            this.txtTenDichVu = new System.Windows.Forms.Label();
            this.btnTroLai = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtMaDV = new System.Windows.Forms.TextBox();
            this.txtTenDV = new System.Windows.Forms.TextBox();
            this.txtMoTaDV = new System.Windows.Forms.TextBox();
            this.txtGiaDV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdanhsachDichVu = new System.Windows.Forms.Label();
            this.rdoMaDV = new System.Windows.Forms.RadioButton();
            this.rdoTenDV = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChinh
            // 
            this.btnChinh.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnChinh.Location = new System.Drawing.Point(1258, 1016);
            this.btnChinh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnChinh.Name = "btnChinh";
            this.btnChinh.Size = new System.Drawing.Size(112, 36);
            this.btnChinh.TabIndex = 14;
            this.btnChinh.Text = "Chỉnh sửa";
            this.btnChinh.UseVisualStyleBackColor = false;
            this.btnChinh.Click += new System.EventHandler(this.btnChinh_Click);
            // 
            // btnTaoMoi
            // 
            this.btnTaoMoi.Location = new System.Drawing.Point(1119, 1016);
            this.btnTaoMoi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTaoMoi.Name = "btnTaoMoi";
            this.btnTaoMoi.Size = new System.Drawing.Size(112, 36);
            this.btnTaoMoi.TabIndex = 15;
            this.btnTaoMoi.Text = "Tạo mới";
            this.btnTaoMoi.UseVisualStyleBackColor = true;
            this.btnTaoMoi.Click += new System.EventHandler(this.btnTaoMoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnXoa.Location = new System.Drawing.Point(1404, 1016);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnXoa.Size = new System.Drawing.Size(112, 36);
            this.btnXoa.TabIndex = 16;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // cboMaDV
            // 
            this.cboMaDV.FormattingEnabled = true;
            this.cboMaDV.Location = new System.Drawing.Point(266, 173);
            this.cboMaDV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboMaDV.Name = "cboMaDV";
            this.cboMaDV.Size = new System.Drawing.Size(208, 33);
            this.cboMaDV.TabIndex = 10;
            // 
            // dgvDichVu
            // 
            this.dgvDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDichVu.Location = new System.Drawing.Point(51, 391);
            this.dgvDichVu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvDichVu.Name = "dgvDichVu";
            this.dgvDichVu.RowHeadersWidth = 51;
            this.dgvDichVu.RowTemplate.Height = 24;
            this.dgvDichVu.Size = new System.Drawing.Size(1044, 661);
            this.dgvDichVu.TabIndex = 7;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(595, 173);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(145, 36);
            this.btnTimKiem.TabIndex = 9;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.UseWaitCursor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtDichvu
            // 
            this.txtDichvu.Location = new System.Drawing.Point(266, 277);
            this.txtDichvu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDichvu.Name = "txtDichvu";
            this.txtDichvu.Size = new System.Drawing.Size(474, 31);
            this.txtDichvu.TabIndex = 11;
            // 
            // txtTenDichVu
            // 
            this.txtTenDichVu.AutoSize = true;
            this.txtTenDichVu.Location = new System.Drawing.Point(124, 286);
            this.txtTenDichVu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtTenDichVu.Name = "txtTenDichVu";
            this.txtTenDichVu.Size = new System.Drawing.Size(0, 25);
            this.txtTenDichVu.TabIndex = 13;
            // 
            // btnTroLai
            // 
            this.btnTroLai.Location = new System.Drawing.Point(1539, 1016);
            this.btnTroLai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTroLai.Name = "btnTroLai";
            this.btnTroLai.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnTroLai.Size = new System.Drawing.Size(112, 36);
            this.btnTroLai.TabIndex = 16;
            this.btnTroLai.Text = "Trở lại";
            this.btnTroLai.UseVisualStyleBackColor = true;
            this.btnTroLai.Click += new System.EventHandler(this.btnTroLai_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(1660, 1016);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnThoat.Size = new System.Drawing.Size(112, 36);
            this.btnThoat.TabIndex = 16;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtMaDV
            // 
            this.txtMaDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMaDV.Location = new System.Drawing.Point(1467, 427);
            this.txtMaDV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaDV.Name = "txtMaDV";
            this.txtMaDV.Size = new System.Drawing.Size(266, 44);
            this.txtMaDV.TabIndex = 17;
            // 
            // txtTenDV
            // 
            this.txtTenDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTenDV.Location = new System.Drawing.Point(1467, 536);
            this.txtTenDV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenDV.Name = "txtTenDV";
            this.txtTenDV.Size = new System.Drawing.Size(266, 44);
            this.txtTenDV.TabIndex = 17;
            // 
            // txtMoTaDV
            // 
            this.txtMoTaDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMoTaDV.Location = new System.Drawing.Point(1467, 645);
            this.txtMoTaDV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMoTaDV.Name = "txtMoTaDV";
            this.txtMoTaDV.Size = new System.Drawing.Size(266, 44);
            this.txtMoTaDV.TabIndex = 17;
            // 
            // txtGiaDV
            // 
            this.txtGiaDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtGiaDV.Location = new System.Drawing.Point(1467, 758);
            this.txtGiaDV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGiaDV.Name = "txtGiaDV";
            this.txtGiaDV.Size = new System.Drawing.Size(266, 44);
            this.txtGiaDV.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(1251, 427);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 37);
            this.label1.TabIndex = 18;
            this.label1.Text = "Mã dịch vụ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(1251, 545);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 37);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tên dịch vụ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(1251, 655);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 37);
            this.label3.TabIndex = 18;
            this.label3.Text = "Mô tả";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(1251, 767);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 37);
            this.label4.TabIndex = 18;
            this.label4.Text = "Giá";
            // 
            // txtdanhsachDichVu
            // 
            this.txtdanhsachDichVu.AutoSize = true;
            this.txtdanhsachDichVu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtdanhsachDichVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtdanhsachDichVu.Location = new System.Drawing.Point(680, 52);
            this.txtdanhsachDichVu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtdanhsachDichVu.Name = "txtdanhsachDichVu";
            this.txtdanhsachDichVu.Size = new System.Drawing.Size(469, 63);
            this.txtdanhsachDichVu.TabIndex = 18;
            this.txtdanhsachDichVu.Text = "Danh sách dịch vụ";
            // 
            // rdoMaDV
            // 
            this.rdoMaDV.AutoSize = true;
            this.rdoMaDV.Location = new System.Drawing.Point(78, 175);
            this.rdoMaDV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdoMaDV.Name = "rdoMaDV";
            this.rdoMaDV.Size = new System.Drawing.Size(148, 29);
            this.rdoMaDV.TabIndex = 19;
            this.rdoMaDV.TabStop = true;
            this.rdoMaDV.Text = "Mã dịch vụ";
            this.rdoMaDV.UseVisualStyleBackColor = true;
            // 
            // rdoTenDV
            // 
            this.rdoTenDV.AutoSize = true;
            this.rdoTenDV.Location = new System.Drawing.Point(78, 277);
            this.rdoTenDV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdoTenDV.Name = "rdoTenDV";
            this.rdoTenDV.Size = new System.Drawing.Size(155, 29);
            this.rdoTenDV.TabIndex = 19;
            this.rdoTenDV.TabStop = true;
            this.rdoTenDV.Text = "Tên dịch vụ";
            this.rdoTenDV.UseVisualStyleBackColor = true;
            // 
            // FrmDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1810, 1123);
            this.Controls.Add(this.rdoTenDV);
            this.Controls.Add(this.rdoMaDV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtdanhsachDichVu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGiaDV);
            this.Controls.Add(this.txtMoTaDV);
            this.Controls.Add(this.txtTenDV);
            this.Controls.Add(this.txtMaDV);
            this.Controls.Add(this.btnChinh);
            this.Controls.Add(this.btnTaoMoi);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTroLai);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.txtTenDichVu);
            this.Controls.Add(this.txtDichvu);
            this.Controls.Add(this.cboMaDV);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.dgvDichVu);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmDichVu";
            this.Text = "FrmDichVu";
            this.Load += new System.EventHandler(this.FrmDichVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChinh;
        private System.Windows.Forms.Button btnTaoMoi;
        private System.Windows.Forms.ComboBox cboMaDV;
        private System.Windows.Forms.DataGridView dgvDichVu;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtDichvu;
        private System.Windows.Forms.Label txtTenDichVu;
        private System.Windows.Forms.Button btnTroLai;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtMaDV;
        private System.Windows.Forms.TextBox txtTenDV;
        private System.Windows.Forms.TextBox txtMoTaDV;
        private System.Windows.Forms.TextBox txtGiaDV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtdanhsachDichVu;
        public System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.RadioButton rdoMaDV;
        private System.Windows.Forms.RadioButton rdoTenDV;
    }
}