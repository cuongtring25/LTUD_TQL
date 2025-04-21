namespace quanLyktx
{
    partial class FrmSinhVien
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtdanhsachDichVu = new System.Windows.Forms.Label();
            this.txtTenSV = new System.Windows.Forms.TextBox();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.btnChinhSua = new System.Windows.Forms.Button();
            this.btnTaoMoi = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTroLai = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.dgvDichvu = new System.Windows.Forms.DataGridView();
            this.txtSoDT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimeNS = new System.Windows.Forms.DateTimePicker();
            this.txtTimKiemTen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rdoMaSV = new System.Windows.Forms.RadioButton();
            this.txtTimKiemMa = new System.Windows.Forms.TextBox();
            this.rdoTenSV = new System.Windows.Forms.RadioButton();
            this.cboGioiTinh = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichvu)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(803, 532);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 25);
            this.label4.TabIndex = 38;
            this.label4.Text = "Ngày sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(803, 460);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 25);
            this.label3.TabIndex = 37;
            this.label3.Text = "Giới tính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(803, 390);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 25);
            this.label2.TabIndex = 36;
            this.label2.Text = "Tên sinh viên";
            // 
            // txtdanhsachDichVu
            // 
            this.txtdanhsachDichVu.AutoSize = true;
            this.txtdanhsachDichVu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtdanhsachDichVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtdanhsachDichVu.Location = new System.Drawing.Point(422, 74);
            this.txtdanhsachDichVu.Name = "txtdanhsachDichVu";
            this.txtdanhsachDichVu.Size = new System.Drawing.Size(324, 39);
            this.txtdanhsachDichVu.TabIndex = 35;
            this.txtdanhsachDichVu.Text = "Danh sách sinh viên";
            // 
            // txtTenSV
            // 
            this.txtTenSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTenSV.Location = new System.Drawing.Point(947, 384);
            this.txtTenSV.Name = "txtTenSV";
            this.txtTenSV.Size = new System.Drawing.Size(179, 30);
            this.txtTenSV.TabIndex = 30;
            // 
            // txtMaSV
            // 
            this.txtMaSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMaSV.Location = new System.Drawing.Point(947, 314);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(179, 30);
            this.txtMaSV.TabIndex = 31;
            // 
            // btnChinhSua
            // 
            this.btnChinhSua.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnChinhSua.Location = new System.Drawing.Point(814, 863);
            this.btnChinhSua.Name = "btnChinhSua";
            this.btnChinhSua.Size = new System.Drawing.Size(75, 23);
            this.btnChinhSua.TabIndex = 25;
            this.btnChinhSua.Text = "Chỉnh sửa";
            this.btnChinhSua.UseVisualStyleBackColor = false;
            this.btnChinhSua.Click += new System.EventHandler(this.btnChinhSua_Click);
            // 
            // btnTaoMoi
            // 
            this.btnTaoMoi.Location = new System.Drawing.Point(721, 863);
            this.btnTaoMoi.Name = "btnTaoMoi";
            this.btnTaoMoi.Size = new System.Drawing.Size(75, 23);
            this.btnTaoMoi.TabIndex = 26;
            this.btnTaoMoi.Text = "Tạo mới";
            this.btnTaoMoi.UseVisualStyleBackColor = true;
            this.btnTaoMoi.Click += new System.EventHandler(this.btnTaoMoi_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(1082, 863);
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
            this.btnTroLai.Location = new System.Drawing.Point(1001, 863);
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
            this.btnXoa.Location = new System.Drawing.Point(911, 863);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 29;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(388, 156);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(106, 23);
            this.btnTimKiem.TabIndex = 20;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.UseWaitCursor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // dgvDichvu
            // 
            this.dgvDichvu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDichvu.Location = new System.Drawing.Point(42, 291);
            this.dgvDichvu.Name = "dgvDichvu";
            this.dgvDichvu.RowHeadersWidth = 51;
            this.dgvDichvu.RowTemplate.Height = 24;
            this.dgvDichvu.Size = new System.Drawing.Size(657, 595);
            this.dgvDichvu.TabIndex = 19;
            this.dgvDichvu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDichvu_CellContentClick);
            // 
            // txtSoDT
            // 
            this.txtSoDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSoDT.Location = new System.Drawing.Point(947, 600);
            this.txtSoDT.Name = "txtSoDT";
            this.txtSoDT.Size = new System.Drawing.Size(189, 30);
            this.txtSoDT.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(803, 605);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 25);
            this.label5.TabIndex = 38;
            this.label5.Text = "Điện thoại";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtEmail.Location = new System.Drawing.Point(947, 677);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(189, 30);
            this.txtEmail.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(813, 683);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 25);
            this.label6.TabIndex = 38;
            this.label6.Text = "Email";
            // 
            // dateTimeNS
            // 
            this.dateTimeNS.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeNS.Location = new System.Drawing.Point(947, 534);
            this.dateTimeNS.Name = "dateTimeNS";
            this.dateTimeNS.Size = new System.Drawing.Size(179, 22);
            this.dateTimeNS.TabIndex = 39;
            // 
            // txtTimKiemTen
            // 
            this.txtTimKiemTen.Location = new System.Drawing.Point(192, 218);
            this.txtTimKiemTen.Name = "txtTimKiemTen";
            this.txtTimKiemTen.Size = new System.Drawing.Size(317, 22);
            this.txtTimKiemTen.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(803, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 34;
            this.label1.Text = "Mã sinh viên";
            // 
            // rdoMaSV
            // 
            this.rdoMaSV.AutoSize = true;
            this.rdoMaSV.Location = new System.Drawing.Point(55, 159);
            this.rdoMaSV.Name = "rdoMaSV";
            this.rdoMaSV.Size = new System.Drawing.Size(102, 20);
            this.rdoMaSV.TabIndex = 41;
            this.rdoMaSV.TabStop = true;
            this.rdoMaSV.Text = "Mã sinh viên";
            this.rdoMaSV.UseVisualStyleBackColor = true;
            // 
            // txtTimKiemMa
            // 
            this.txtTimKiemMa.Location = new System.Drawing.Point(192, 159);
            this.txtTimKiemMa.Name = "txtTimKiemMa";
            this.txtTimKiemMa.Size = new System.Drawing.Size(165, 22);
            this.txtTimKiemMa.TabIndex = 22;
            // 
            // rdoTenSV
            // 
            this.rdoTenSV.AutoSize = true;
            this.rdoTenSV.Location = new System.Drawing.Point(55, 218);
            this.rdoTenSV.Name = "rdoTenSV";
            this.rdoTenSV.Size = new System.Drawing.Size(109, 20);
            this.rdoTenSV.TabIndex = 42;
            this.rdoTenSV.TabStop = true;
            this.rdoTenSV.Text = "Tên Sinh viên";
            this.rdoTenSV.UseVisualStyleBackColor = true;
            // 
            // cboGioiTinh
            // 
            this.cboGioiTinh.FormattingEnabled = true;
            this.cboGioiTinh.Location = new System.Drawing.Point(950, 458);
            this.cboGioiTinh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboGioiTinh.Name = "cboGioiTinh";
            this.cboGioiTinh.Size = new System.Drawing.Size(175, 24);
            this.cboGioiTinh.TabIndex = 43;
            // 
            // FrmSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 675);
            this.Controls.Add(this.cboGioiTinh);
            this.Controls.Add(this.rdoTenSV);
            this.Controls.Add(this.rdoMaSV);
            this.Controls.Add(this.dateTimeNS);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtdanhsachDichVu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSoDT);
            this.Controls.Add(this.txtTenSV);
            this.Controls.Add(this.txtMaSV);
            this.Controls.Add(this.btnChinhSua);
            this.Controls.Add(this.btnTaoMoi);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTroLai);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.txtTimKiemMa);
            this.Controls.Add(this.txtTimKiemTen);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.dgvDichvu);
            this.Name = "FrmSinhVien";
            this.Text = "FrmSinhVien";
            this.Load += new System.EventHandler(this.FrmSinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichvu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtdanhsachDichVu;
        private System.Windows.Forms.TextBox txtTenSV;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Button btnChinhSua;
        private System.Windows.Forms.Button btnTaoMoi;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTroLai;
        public System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView dgvDichvu;
        private System.Windows.Forms.TextBox txtSoDT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimeNS;
        private System.Windows.Forms.TextBox txtTimKiemTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdoMaSV;
        private System.Windows.Forms.TextBox txtTimKiemMa;
        private System.Windows.Forms.RadioButton rdoTenSV;
        private System.Windows.Forms.ComboBox cboGioiTinh;
    }
}