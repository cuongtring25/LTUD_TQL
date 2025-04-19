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
            this.btnChinh.Location = new System.Drawing.Point(839, 650);
            this.btnChinh.Name = "btnChinh";
            this.btnChinh.Size = new System.Drawing.Size(75, 23);
            this.btnChinh.TabIndex = 14;
            this.btnChinh.Text = "Chỉnh sửa";
            this.btnChinh.UseVisualStyleBackColor = false;
            this.btnChinh.Click += new System.EventHandler(this.btnChinh_Click);
            // 
            // btnTaoMoi
            // 
            this.btnTaoMoi.Location = new System.Drawing.Point(746, 650);
            this.btnTaoMoi.Name = "btnTaoMoi";
            this.btnTaoMoi.Size = new System.Drawing.Size(75, 23);
            this.btnTaoMoi.TabIndex = 15;
            this.btnTaoMoi.Text = "Tạo mới";
            this.btnTaoMoi.UseVisualStyleBackColor = true;
            this.btnTaoMoi.Click += new System.EventHandler(this.btnTaoMoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnXoa.Location = new System.Drawing.Point(936, 650);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 16;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // cboMaDV
            // 
            this.cboMaDV.FormattingEnabled = true;
            this.cboMaDV.Location = new System.Drawing.Point(177, 111);
            this.cboMaDV.Name = "cboMaDV";
            this.cboMaDV.Size = new System.Drawing.Size(140, 24);
            this.cboMaDV.TabIndex = 10;
            // 
            // dgvDichVu
            // 
            this.dgvDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDichVu.Location = new System.Drawing.Point(34, 250);
            this.dgvDichVu.Name = "dgvDichVu";
            this.dgvDichVu.RowHeadersWidth = 51;
            this.dgvDichVu.RowTemplate.Height = 24;
            this.dgvDichVu.Size = new System.Drawing.Size(696, 423);
            this.dgvDichVu.TabIndex = 7;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(397, 111);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(97, 23);
            this.btnTimKiem.TabIndex = 9;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.UseWaitCursor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtDichvu
            // 
            this.txtDichvu.Location = new System.Drawing.Point(177, 177);
            this.txtDichvu.Name = "txtDichvu";
            this.txtDichvu.Size = new System.Drawing.Size(317, 22);
            this.txtDichvu.TabIndex = 11;
            // 
            // txtTenDichVu
            // 
            this.txtTenDichVu.AutoSize = true;
            this.txtTenDichVu.Location = new System.Drawing.Point(83, 183);
            this.txtTenDichVu.Name = "txtTenDichVu";
            this.txtTenDichVu.Size = new System.Drawing.Size(0, 16);
            this.txtTenDichVu.TabIndex = 13;
            // 
            // btnTroLai
            // 
            this.btnTroLai.Location = new System.Drawing.Point(1026, 650);
            this.btnTroLai.Name = "btnTroLai";
            this.btnTroLai.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnTroLai.Size = new System.Drawing.Size(75, 23);
            this.btnTroLai.TabIndex = 16;
            this.btnTroLai.Text = "Trở lại";
            this.btnTroLai.UseVisualStyleBackColor = true;
            this.btnTroLai.Click += new System.EventHandler(this.btnTroLai_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(1107, 650);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 16;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtMaDV
            // 
            this.txtMaDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMaDV.Location = new System.Drawing.Point(978, 273);
            this.txtMaDV.Name = "txtMaDV";
            this.txtMaDV.Size = new System.Drawing.Size(179, 30);
            this.txtMaDV.TabIndex = 17;
            // 
            // txtTenDV
            // 
            this.txtTenDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTenDV.Location = new System.Drawing.Point(978, 343);
            this.txtTenDV.Name = "txtTenDV";
            this.txtTenDV.Size = new System.Drawing.Size(179, 30);
            this.txtTenDV.TabIndex = 17;
            // 
            // txtMoTaDV
            // 
            this.txtMoTaDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMoTaDV.Location = new System.Drawing.Point(978, 413);
            this.txtMoTaDV.Name = "txtMoTaDV";
            this.txtMoTaDV.Size = new System.Drawing.Size(179, 30);
            this.txtMoTaDV.TabIndex = 17;
            // 
            // txtGiaDV
            // 
            this.txtGiaDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtGiaDV.Location = new System.Drawing.Point(978, 485);
            this.txtGiaDV.Name = "txtGiaDV";
            this.txtGiaDV.Size = new System.Drawing.Size(179, 30);
            this.txtGiaDV.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(834, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Mã dịch vụ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(834, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tên dịch vụ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(834, 419);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "Mô tả";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(834, 491);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "Giá";
            // 
            // txtdanhsachDichVu
            // 
            this.txtdanhsachDichVu.AutoSize = true;
            this.txtdanhsachDichVu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtdanhsachDichVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtdanhsachDichVu.Location = new System.Drawing.Point(453, 33);
            this.txtdanhsachDichVu.Name = "txtdanhsachDichVu";
            this.txtdanhsachDichVu.Size = new System.Drawing.Size(297, 39);
            this.txtdanhsachDichVu.TabIndex = 18;
            this.txtdanhsachDichVu.Text = "Danh sách dịch vụ";
            // 
            // rdoMaDV
            // 
            this.rdoMaDV.AutoSize = true;
            this.rdoMaDV.Checked = true;
            this.rdoMaDV.Location = new System.Drawing.Point(52, 112);
            this.rdoMaDV.Name = "rdoMaDV";
            this.rdoMaDV.Size = new System.Drawing.Size(92, 20);
            this.rdoMaDV.TabIndex = 19;
            this.rdoMaDV.TabStop = true;
            this.rdoMaDV.Text = "Mã dịch vụ";
            this.rdoMaDV.UseVisualStyleBackColor = true;
            // 
            // rdoTenDV
            // 
            this.rdoTenDV.AutoSize = true;
            this.rdoTenDV.Location = new System.Drawing.Point(52, 177);
            this.rdoTenDV.Name = "rdoTenDV";
            this.rdoTenDV.Size = new System.Drawing.Size(97, 20);
            this.rdoTenDV.TabIndex = 19;
            this.rdoTenDV.Text = "Tên dịch vụ";
            this.rdoTenDV.UseVisualStyleBackColor = true;
            // 
            // FrmDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 675);
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