namespace quanLyktx
{
    partial class FrmKhieuNai
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
            this.cboTrangThaiXuLy = new System.Windows.Forms.ComboBox();
            this.cboMaKhieuNai = new System.Windows.Forms.ComboBox();
            this.txtTrangthaiXuLi = new System.Windows.Forms.Label();
            this.ngayTao = new System.Windows.Forms.Label();
            this.noidung = new System.Windows.Forms.Label();
            this.maSV = new System.Windows.Forms.Label();
            this.txtdanhsachKhieuNai = new System.Windows.Forms.Label();
            this.maKN = new System.Windows.Forms.Label();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.txtMaSinhVien = new System.Windows.Forms.TextBox();
            this.btnChinh = new System.Windows.Forms.Button();
            this.btnTaoMoi = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTroLai = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.cboMaKN = new System.Windows.Forms.ComboBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.dgvKhieuNai = new System.Windows.Forms.DataGridView();
            this.dtNgayTao = new System.Windows.Forms.DateTimePicker();
            this.rdoMaKN = new System.Windows.Forms.RadioButton();
            this.rdoMaSV = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhieuNai)).BeginInit();
            this.SuspendLayout();
            // 
            // cboTrangThaiXuLy
            // 
            this.cboTrangThaiXuLy.FormattingEnabled = true;
            this.cboTrangThaiXuLy.Items.AddRange(new object[] {
            "Chưa giải quyết",
            "Đang xử lý",
            "Đã giải quyết"});
            this.cboTrangThaiXuLy.Location = new System.Drawing.Point(885, 487);
            this.cboTrangThaiXuLy.Name = "cboTrangThaiXuLy";
            this.cboTrangThaiXuLy.Size = new System.Drawing.Size(183, 24);
            this.cboTrangThaiXuLy.TabIndex = 62;
            // 
            // cboMaKhieuNai
            // 
            this.cboMaKhieuNai.FormattingEnabled = true;
            this.cboMaKhieuNai.Location = new System.Drawing.Point(885, 257);
            this.cboMaKhieuNai.Name = "cboMaKhieuNai";
            this.cboMaKhieuNai.Size = new System.Drawing.Size(175, 24);
            this.cboMaKhieuNai.TabIndex = 61;
            // 
            // txtTrangthaiXuLi
            // 
            this.txtTrangthaiXuLi.AutoSize = true;
            this.txtTrangthaiXuLi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTrangthaiXuLi.Location = new System.Drawing.Point(734, 483);
            this.txtTrangthaiXuLi.Name = "txtTrangthaiXuLi";
            this.txtTrangthaiXuLi.Size = new System.Drawing.Size(105, 25);
            this.txtTrangthaiXuLi.TabIndex = 60;
            this.txtTrangthaiXuLi.Text = "Trạng thái ";
            // 
            // ngayTao
            // 
            this.ngayTao.AutoSize = true;
            this.ngayTao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ngayTao.Location = new System.Drawing.Point(741, 556);
            this.ngayTao.Name = "ngayTao";
            this.ngayTao.Size = new System.Drawing.Size(98, 25);
            this.ngayTao.TabIndex = 59;
            this.ngayTao.Text = "Ngày Tạo";
            // 
            // noidung
            // 
            this.noidung.AutoSize = true;
            this.noidung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.noidung.Location = new System.Drawing.Point(741, 402);
            this.noidung.Name = "noidung";
            this.noidung.Size = new System.Drawing.Size(90, 25);
            this.noidung.TabIndex = 58;
            this.noidung.Text = "Nội dung";
            // 
            // maSV
            // 
            this.maSV.AutoSize = true;
            this.maSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.maSV.Location = new System.Drawing.Point(741, 332);
            this.maSV.Name = "maSV";
            this.maSV.Size = new System.Drawing.Size(130, 25);
            this.maSV.TabIndex = 57;
            this.maSV.Text = "Mã Sinh Viên";
            // 
            // txtdanhsachKhieuNai
            // 
            this.txtdanhsachKhieuNai.AutoSize = true;
            this.txtdanhsachKhieuNai.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtdanhsachKhieuNai.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtdanhsachKhieuNai.Location = new System.Drawing.Point(402, 29);
            this.txtdanhsachKhieuNai.Name = "txtdanhsachKhieuNai";
            this.txtdanhsachKhieuNai.Size = new System.Drawing.Size(326, 39);
            this.txtdanhsachKhieuNai.TabIndex = 56;
            this.txtdanhsachKhieuNai.Text = "Danh sách khiếu nại";
            // 
            // maKN
            // 
            this.maKN.AutoSize = true;
            this.maKN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.maKN.Location = new System.Drawing.Point(741, 257);
            this.maKN.Name = "maKN";
            this.maKN.Size = new System.Drawing.Size(123, 25);
            this.maKN.TabIndex = 55;
            this.maKN.Text = "Mã khiếu nại";
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNoiDung.Location = new System.Drawing.Point(885, 397);
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(183, 30);
            this.txtNoiDung.TabIndex = 54;
            // 
            // txtMaSinhVien
            // 
            this.txtMaSinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMaSinhVien.Location = new System.Drawing.Point(885, 328);
            this.txtMaSinhVien.Name = "txtMaSinhVien";
            this.txtMaSinhVien.Size = new System.Drawing.Size(179, 30);
            this.txtMaSinhVien.TabIndex = 52;
            // 
            // btnChinh
            // 
            this.btnChinh.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnChinh.Location = new System.Drawing.Point(788, 607);
            this.btnChinh.Name = "btnChinh";
            this.btnChinh.Size = new System.Drawing.Size(75, 23);
            this.btnChinh.TabIndex = 47;
            this.btnChinh.Text = "Chỉnh sửa";
            this.btnChinh.UseVisualStyleBackColor = false;
            this.btnChinh.Click += new System.EventHandler(this.btnChinh_Click);
            // 
            // btnTaoMoi
            // 
            this.btnTaoMoi.Location = new System.Drawing.Point(695, 607);
            this.btnTaoMoi.Name = "btnTaoMoi";
            this.btnTaoMoi.Size = new System.Drawing.Size(75, 23);
            this.btnTaoMoi.TabIndex = 48;
            this.btnTaoMoi.Text = "Tạo mới";
            this.btnTaoMoi.UseVisualStyleBackColor = true;
            this.btnTaoMoi.Click += new System.EventHandler(this.btnTaoMoi_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(1056, 607);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 49;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTroLai
            // 
            this.btnTroLai.Location = new System.Drawing.Point(975, 607);
            this.btnTroLai.Name = "btnTroLai";
            this.btnTroLai.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnTroLai.Size = new System.Drawing.Size(75, 23);
            this.btnTroLai.TabIndex = 50;
            this.btnTroLai.Text = "Trở lại";
            this.btnTroLai.UseVisualStyleBackColor = true;
            this.btnTroLai.Click += new System.EventHandler(this.btnTroLai_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnXoa.Location = new System.Drawing.Point(885, 607);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 51;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(155, 170);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(140, 22);
            this.txtMaSV.TabIndex = 44;
            // 
            // cboMaKN
            // 
            this.cboMaKN.FormattingEnabled = true;
            this.cboMaKN.Location = new System.Drawing.Point(155, 104);
            this.cboMaKN.Name = "cboMaKN";
            this.cboMaKN.Size = new System.Drawing.Size(140, 24);
            this.cboMaKN.TabIndex = 43;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(343, 134);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(93, 23);
            this.btnTimKiem.TabIndex = 42;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.UseWaitCursor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // dgvKhieuNai
            // 
            this.dgvKhieuNai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhieuNai.Location = new System.Drawing.Point(9, 246);
            this.dgvKhieuNai.Name = "dgvKhieuNai";
            this.dgvKhieuNai.RowHeadersWidth = 51;
            this.dgvKhieuNai.RowTemplate.Height = 24;
            this.dgvKhieuNai.Size = new System.Drawing.Size(657, 398);
            this.dgvKhieuNai.TabIndex = 41;
            // 
            // dtNgayTao
            // 
            this.dtNgayTao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayTao.Location = new System.Drawing.Point(885, 556);
            this.dtNgayTao.Name = "dtNgayTao";
            this.dtNgayTao.Size = new System.Drawing.Size(183, 22);
            this.dtNgayTao.TabIndex = 63;
            // 
            // rdoMaKN
            // 
            this.rdoMaKN.AutoSize = true;
            this.rdoMaKN.Checked = true;
            this.rdoMaKN.Location = new System.Drawing.Point(41, 105);
            this.rdoMaKN.Name = "rdoMaKN";
            this.rdoMaKN.Size = new System.Drawing.Size(103, 20);
            this.rdoMaKN.TabIndex = 64;
            this.rdoMaKN.TabStop = true;
            this.rdoMaKN.Text = "Mã khiếu nại";
            this.rdoMaKN.UseVisualStyleBackColor = true;
            // 
            // rdoMaSV
            // 
            this.rdoMaSV.AutoSize = true;
            this.rdoMaSV.Location = new System.Drawing.Point(39, 170);
            this.rdoMaSV.Name = "rdoMaSV";
            this.rdoMaSV.Size = new System.Drawing.Size(102, 20);
            this.rdoMaSV.TabIndex = 64;
            this.rdoMaSV.Text = "Mã sinh viên";
            this.rdoMaSV.UseVisualStyleBackColor = true;
            // 
            // FrmKhieuNai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 727);
            this.Controls.Add(this.rdoMaSV);
            this.Controls.Add(this.rdoMaKN);
            this.Controls.Add(this.dtNgayTao);
            this.Controls.Add(this.cboTrangThaiXuLy);
            this.Controls.Add(this.cboMaKhieuNai);
            this.Controls.Add(this.txtTrangthaiXuLi);
            this.Controls.Add(this.ngayTao);
            this.Controls.Add(this.noidung);
            this.Controls.Add(this.maSV);
            this.Controls.Add(this.txtdanhsachKhieuNai);
            this.Controls.Add(this.maKN);
            this.Controls.Add(this.txtNoiDung);
            this.Controls.Add(this.txtMaSinhVien);
            this.Controls.Add(this.btnChinh);
            this.Controls.Add(this.btnTaoMoi);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTroLai);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.txtMaSV);
            this.Controls.Add(this.cboMaKN);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.dgvKhieuNai);
            this.Name = "FrmKhieuNai";
            this.Text = "FrmKhieuNai";
            this.Load += new System.EventHandler(this.FrmKhieuNai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhieuNai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboTrangThaiXuLy;
        private System.Windows.Forms.ComboBox cboMaKhieuNai;
        public System.Windows.Forms.Label txtTrangthaiXuLi;
        private System.Windows.Forms.Label ngayTao;
        private System.Windows.Forms.Label noidung;
        private System.Windows.Forms.Label maSV;
        private System.Windows.Forms.Label txtdanhsachKhieuNai;
        private System.Windows.Forms.Label maKN;
        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.TextBox txtMaSinhVien;
        private System.Windows.Forms.Button btnChinh;
        private System.Windows.Forms.Button btnTaoMoi;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTroLai;
        public System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.ComboBox cboMaKN;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView dgvKhieuNai;
        private System.Windows.Forms.DateTimePicker dtNgayTao;
        private System.Windows.Forms.RadioButton rdoMaKN;
        private System.Windows.Forms.RadioButton rdoMaSV;
    }
}