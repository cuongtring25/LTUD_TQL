namespace quanLyktx
{
    partial class FrmHoaDon
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
            this.moTa = new System.Windows.Forms.Label();
            this.maSV = new System.Windows.Forms.Label();
            this.txtdanhsachDichVu = new System.Windows.Forms.Label();
            this.maHD = new System.Windows.Forms.Label();
            this.txtTongSoTien = new System.Windows.Forms.TextBox();
            this.txtMaHoaDon = new System.Windows.Forms.TextBox();
            this.btnChinh = new System.Windows.Forms.Button();
            this.btnTaoMoi = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTroLai = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtxMaHoaDon = new System.Windows.Forms.Label();
            this.masvhd = new System.Windows.Forms.Label();
            this.txtMaSinhVien = new System.Windows.Forms.TextBox();
            this.cboMaHoaDon = new System.Windows.Forms.ComboBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.txtTrangthaiThanhToan = new System.Windows.Forms.Label();
            this.cboTrangThaiThanhToan = new System.Windows.Forms.ComboBox();
            this.rdoMaHoaDon = new System.Windows.Forms.RadioButton();
            this.rdoMaSinhVien = new System.Windows.Forms.RadioButton();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.dtNgayTao = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // moTa
            // 
            this.moTa.AutoSize = true;
            this.moTa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.moTa.Location = new System.Drawing.Point(731, 429);
            this.moTa.Name = "moTa";
            this.moTa.Size = new System.Drawing.Size(120, 25);
            this.moTa.TabIndex = 37;
            this.moTa.Text = "Tổng số tiền";
            // 
            // maSV
            // 
            this.maSV.AutoSize = true;
            this.maSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.maSV.Location = new System.Drawing.Point(731, 359);
            this.maSV.Name = "maSV";
            this.maSV.Size = new System.Drawing.Size(130, 25);
            this.maSV.TabIndex = 36;
            this.maSV.Text = "Mã Sinh Viên";
            // 
            // txtdanhsachDichVu
            // 
            this.txtdanhsachDichVu.AutoSize = true;
            this.txtdanhsachDichVu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtdanhsachDichVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtdanhsachDichVu.Location = new System.Drawing.Point(392, 55);
            this.txtdanhsachDichVu.Name = "txtdanhsachDichVu";
            this.txtdanhsachDichVu.Size = new System.Drawing.Size(312, 39);
            this.txtdanhsachDichVu.TabIndex = 35;
            this.txtdanhsachDichVu.Text = "Danh sách hóa đơn";
            // 
            // maHD
            // 
            this.maHD.AutoSize = true;
            this.maHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.maHD.Location = new System.Drawing.Point(731, 283);
            this.maHD.Name = "maHD";
            this.maHD.Size = new System.Drawing.Size(116, 25);
            this.maHD.TabIndex = 34;
            this.maHD.Text = "Mã hóa đơn";
            // 
            // txtTongSoTien
            // 
            this.txtTongSoTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTongSoTien.Location = new System.Drawing.Point(875, 423);
            this.txtTongSoTien.Name = "txtTongSoTien";
            this.txtTongSoTien.Size = new System.Drawing.Size(179, 30);
            this.txtTongSoTien.TabIndex = 33;
            // 
            // txtMaHoaDon
            // 
            this.txtMaHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMaHoaDon.Location = new System.Drawing.Point(875, 283);
            this.txtMaHoaDon.Name = "txtMaHoaDon";
            this.txtMaHoaDon.Size = new System.Drawing.Size(179, 30);
            this.txtMaHoaDon.TabIndex = 31;
            // 
            // btnChinh
            // 
            this.btnChinh.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnChinh.Location = new System.Drawing.Point(790, 634);
            this.btnChinh.Name = "btnChinh";
            this.btnChinh.Size = new System.Drawing.Size(75, 23);
            this.btnChinh.TabIndex = 25;
            this.btnChinh.Text = "Chỉnh sửa";
            this.btnChinh.UseVisualStyleBackColor = false;
            this.btnChinh.Click += new System.EventHandler(this.btnChinh_Click);
            // 
            // btnTaoMoi
            // 
            this.btnTaoMoi.Location = new System.Drawing.Point(697, 634);
            this.btnTaoMoi.Name = "btnTaoMoi";
            this.btnTaoMoi.Size = new System.Drawing.Size(75, 23);
            this.btnTaoMoi.TabIndex = 26;
            this.btnTaoMoi.Text = "Tạo mới";
            this.btnTaoMoi.UseVisualStyleBackColor = true;
            this.btnTaoMoi.Click += new System.EventHandler(this.btnTaoMoi_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(1058, 634);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 27;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTroLai
            // 
            this.btnTroLai.Location = new System.Drawing.Point(977, 634);
            this.btnTroLai.Name = "btnTroLai";
            this.btnTroLai.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnTroLai.Size = new System.Drawing.Size(75, 23);
            this.btnTroLai.TabIndex = 28;
            this.btnTroLai.Text = "Trở lại";
            this.btnTroLai.UseVisualStyleBackColor = true;
            this.btnTroLai.Click += new System.EventHandler(this.btnTroLai_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnXoa.Location = new System.Drawing.Point(887, 634);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 29;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtxMaHoaDon
            // 
            this.txtxMaHoaDon.AutoSize = true;
            this.txtxMaHoaDon.Location = new System.Drawing.Point(22, 137);
            this.txtxMaHoaDon.Name = "txtxMaHoaDon";
            this.txtxMaHoaDon.Size = new System.Drawing.Size(0, 16);
            this.txtxMaHoaDon.TabIndex = 23;
            // 
            // masvhd
            // 
            this.masvhd.AutoSize = true;
            this.masvhd.Location = new System.Drawing.Point(22, 205);
            this.masvhd.Name = "masvhd";
            this.masvhd.Size = new System.Drawing.Size(0, 16);
            this.masvhd.TabIndex = 24;
            // 
            // txtMaSinhVien
            // 
            this.txtMaSinhVien.Location = new System.Drawing.Point(160, 200);
            this.txtMaSinhVien.Name = "txtMaSinhVien";
            this.txtMaSinhVien.Size = new System.Drawing.Size(140, 22);
            this.txtMaSinhVien.TabIndex = 22;
            // 
            // cboMaHoaDon
            // 
            this.cboMaHoaDon.FormattingEnabled = true;
            this.cboMaHoaDon.Location = new System.Drawing.Point(160, 134);
            this.cboMaHoaDon.Name = "cboMaHoaDon";
            this.cboMaHoaDon.Size = new System.Drawing.Size(140, 24);
            this.cboMaHoaDon.TabIndex = 21;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(351, 159);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(113, 23);
            this.btnTimKiem.TabIndex = 20;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.UseWaitCursor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Location = new System.Drawing.Point(25, 272);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.RowHeadersWidth = 51;
            this.dgvHoaDon.RowTemplate.Height = 24;
            this.dgvHoaDon.Size = new System.Drawing.Size(657, 349);
            this.dgvHoaDon.TabIndex = 19;
            // 
            // txtTrangthaiThanhToan
            // 
            this.txtTrangthaiThanhToan.AutoSize = true;
            this.txtTrangthaiThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTrangthaiThanhToan.Location = new System.Drawing.Point(731, 575);
            this.txtTrangthaiThanhToan.Name = "txtTrangthaiThanhToan";
            this.txtTrangthaiThanhToan.Size = new System.Drawing.Size(105, 25);
            this.txtTrangthaiThanhToan.TabIndex = 38;
            this.txtTrangthaiThanhToan.Text = "Trạng thái ";
            // 
            // cboTrangThaiThanhToan
            // 
            this.cboTrangThaiThanhToan.FormattingEnabled = true;
            this.cboTrangThaiThanhToan.Items.AddRange(new object[] {
            "Chưa thanh toán",
            "Đã thanh toán"});
            this.cboTrangThaiThanhToan.Location = new System.Drawing.Point(875, 575);
            this.cboTrangThaiThanhToan.Name = "cboTrangThaiThanhToan";
            this.cboTrangThaiThanhToan.Size = new System.Drawing.Size(179, 24);
            this.cboTrangThaiThanhToan.TabIndex = 40;
            // 
            // rdoMaHoaDon
            // 
            this.rdoMaHoaDon.AutoSize = true;
            this.rdoMaHoaDon.Checked = true;
            this.rdoMaHoaDon.Location = new System.Drawing.Point(45, 134);
            this.rdoMaHoaDon.Name = "rdoMaHoaDon";
            this.rdoMaHoaDon.Size = new System.Drawing.Size(99, 20);
            this.rdoMaHoaDon.TabIndex = 41;
            this.rdoMaHoaDon.TabStop = true;
            this.rdoMaHoaDon.Text = "Mã hóa đơn";
            this.rdoMaHoaDon.UseVisualStyleBackColor = true;
            // 
            // rdoMaSinhVien
            // 
            this.rdoMaSinhVien.AutoSize = true;
            this.rdoMaSinhVien.Location = new System.Drawing.Point(45, 200);
            this.rdoMaSinhVien.Name = "rdoMaSinhVien";
            this.rdoMaSinhVien.Size = new System.Drawing.Size(102, 20);
            this.rdoMaSinhVien.TabIndex = 65;
            this.rdoMaSinhVien.Text = "Mã sinh viên";
            this.rdoMaSinhVien.UseVisualStyleBackColor = true;
            // 
            // txtMaSV
            // 
            this.txtMaSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMaSV.Location = new System.Drawing.Point(876, 357);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(179, 30);
            this.txtMaSV.TabIndex = 66;
            // 
            // dtNgayTao
            // 
            this.dtNgayTao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayTao.Location = new System.Drawing.Point(875, 504);
            this.dtNgayTao.Name = "dtNgayTao";
            this.dtNgayTao.Size = new System.Drawing.Size(179, 22);
            this.dtNgayTao.TabIndex = 68;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(731, 502);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 25);
            this.label4.TabIndex = 67;
            this.label4.Text = "Ngày tạo";
            // 
            // FrmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 672);
            this.Controls.Add(this.dtNgayTao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMaSV);
            this.Controls.Add(this.rdoMaSinhVien);
            this.Controls.Add(this.rdoMaHoaDon);
            this.Controls.Add(this.cboTrangThaiThanhToan);
            this.Controls.Add(this.txtTrangthaiThanhToan);
            this.Controls.Add(this.moTa);
            this.Controls.Add(this.maSV);
            this.Controls.Add(this.txtdanhsachDichVu);
            this.Controls.Add(this.maHD);
            this.Controls.Add(this.txtTongSoTien);
            this.Controls.Add(this.txtMaHoaDon);
            this.Controls.Add(this.btnChinh);
            this.Controls.Add(this.btnTaoMoi);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTroLai);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.txtxMaHoaDon);
            this.Controls.Add(this.masvhd);
            this.Controls.Add(this.txtMaSinhVien);
            this.Controls.Add(this.cboMaHoaDon);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.dgvHoaDon);
            this.Name = "FrmHoaDon";
            this.Text = "FrmHoaDon";
            this.Load += new System.EventHandler(this.FrmHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label moTa;
        private System.Windows.Forms.Label maSV;
        private System.Windows.Forms.Label txtdanhsachDichVu;
        private System.Windows.Forms.Label maHD;
        private System.Windows.Forms.TextBox txtTongSoTien;
        private System.Windows.Forms.TextBox txtMaHoaDon;
        private System.Windows.Forms.Button btnChinh;
        private System.Windows.Forms.Button btnTaoMoi;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTroLai;
        public System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label txtxMaHoaDon;
        private System.Windows.Forms.Label masvhd;
        private System.Windows.Forms.TextBox txtMaSinhVien;
        private System.Windows.Forms.ComboBox cboMaHoaDon;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.ComboBox cboTrangThaiThanhToan;
        public System.Windows.Forms.Label txtTrangthaiThanhToan;
        private System.Windows.Forms.RadioButton rdoMaHoaDon;
        private System.Windows.Forms.RadioButton rdoMaSinhVien;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.DateTimePicker dtNgayTao;
        private System.Windows.Forms.Label label4;
    }
}