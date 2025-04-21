namespace quanLyktx
{
    partial class FrmThueTraPhong
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
            this.rdoSoPhong = new System.Windows.Forms.RadioButton();
            this.rdoMaPhong = new System.Windows.Forms.RadioButton();
            this.txtdanhsachDichVu = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtThoigianthue = new System.Windows.Forms.TextBox();
            this.btnChinh = new System.Windows.Forms.Button();
            this.btnTaoMoi = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTroLai = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.txtSoPhong = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.gdvPhongchothue = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.maphong = new System.Windows.Forms.Label();
            this.datetimeChoThue = new System.Windows.Forms.DateTimePicker();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboMaPhong = new System.Windows.Forms.ComboBox();
            this.cboSoPhong = new System.Windows.Forms.ComboBox();
            this.cboGioiTinh = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gdvPhongchothue)).BeginInit();
            this.SuspendLayout();
            // 
            // rdoSoPhong
            // 
            this.rdoSoPhong.AutoSize = true;
            this.rdoSoPhong.Location = new System.Drawing.Point(63, 210);
            this.rdoSoPhong.Name = "rdoSoPhong";
            this.rdoSoPhong.Size = new System.Drawing.Size(86, 20);
            this.rdoSoPhong.TabIndex = 66;
            this.rdoSoPhong.TabStop = true;
            this.rdoSoPhong.Text = "Số phòng";
            this.rdoSoPhong.UseVisualStyleBackColor = true;
            // 
            // rdoMaPhong
            // 
            this.rdoMaPhong.AutoSize = true;
            this.rdoMaPhong.Location = new System.Drawing.Point(63, 151);
            this.rdoMaPhong.Name = "rdoMaPhong";
            this.rdoMaPhong.Size = new System.Drawing.Size(88, 20);
            this.rdoMaPhong.TabIndex = 65;
            this.rdoMaPhong.TabStop = true;
            this.rdoMaPhong.Text = "Mã phòng";
            this.rdoMaPhong.UseVisualStyleBackColor = true;
            // 
            // txtdanhsachDichVu
            // 
            this.txtdanhsachDichVu.AutoSize = true;
            this.txtdanhsachDichVu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtdanhsachDichVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtdanhsachDichVu.Location = new System.Drawing.Point(381, 63);
            this.txtdanhsachDichVu.Name = "txtdanhsachDichVu";
            this.txtdanhsachDichVu.Size = new System.Drawing.Size(423, 39);
            this.txtdanhsachDichVu.TabIndex = 57;
            this.txtdanhsachDichVu.Text = "Danh sách phòng cho thuê";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(772, 539);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 56;
            this.label1.Text = "Mã sinh viên";
            // 
            // txtThoigianthue
            // 
            this.txtThoigianthue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtThoigianthue.Location = new System.Drawing.Point(956, 426);
            this.txtThoigianthue.Name = "txtThoigianthue";
            this.txtThoigianthue.Size = new System.Drawing.Size(179, 30);
            this.txtThoigianthue.TabIndex = 53;
            // 
            // btnChinh
            // 
            this.btnChinh.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnChinh.Location = new System.Drawing.Point(822, 855);
            this.btnChinh.Name = "btnChinh";
            this.btnChinh.Size = new System.Drawing.Size(75, 23);
            this.btnChinh.TabIndex = 47;
            this.btnChinh.Text = "Chỉnh sửa";
            this.btnChinh.UseVisualStyleBackColor = false;
            this.btnChinh.Click += new System.EventHandler(this.btnChinh_Click);
            // 
            // btnTaoMoi
            // 
            this.btnTaoMoi.Location = new System.Drawing.Point(729, 855);
            this.btnTaoMoi.Name = "btnTaoMoi";
            this.btnTaoMoi.Size = new System.Drawing.Size(75, 23);
            this.btnTaoMoi.TabIndex = 48;
            this.btnTaoMoi.Text = "Tạo mới";
            this.btnTaoMoi.UseVisualStyleBackColor = true;
            this.btnTaoMoi.Click += new System.EventHandler(this.btnTaoMoi_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(1090, 855);
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
            this.btnTroLai.Location = new System.Drawing.Point(1009, 855);
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
            this.btnXoa.Location = new System.Drawing.Point(919, 855);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 51;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Location = new System.Drawing.Point(200, 151);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(165, 22);
            this.txtMaPhong.TabIndex = 46;
            // 
            // txtSoPhong
            // 
            this.txtSoPhong.Location = new System.Drawing.Point(200, 210);
            this.txtSoPhong.Name = "txtSoPhong";
            this.txtSoPhong.Size = new System.Drawing.Size(317, 22);
            this.txtSoPhong.TabIndex = 45;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(396, 148);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(120, 23);
            this.btnTimKiem.TabIndex = 44;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.UseWaitCursor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // gdvPhongchothue
            // 
            this.gdvPhongchothue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvPhongchothue.Location = new System.Drawing.Point(50, 283);
            this.gdvPhongchothue.Name = "gdvPhongchothue";
            this.gdvPhongchothue.RowHeadersWidth = 51;
            this.gdvPhongchothue.RowTemplate.Height = 24;
            this.gdvPhongchothue.Size = new System.Drawing.Size(657, 595);
            this.gdvPhongchothue.TabIndex = 43;
            this.gdvPhongchothue.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdvPhongchothue_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(772, 599);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 25);
            this.label7.TabIndex = 59;
            this.label7.Text = "Giới tính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(772, 372);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 59;
            this.label2.Text = "Số phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(772, 426);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 25);
            this.label3.TabIndex = 56;
            this.label3.Text = "Khoảng thời gian";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(772, 480);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 25);
            this.label4.TabIndex = 56;
            this.label4.Text = "Tính từ ngày";
            // 
            // maphong
            // 
            this.maphong.AutoSize = true;
            this.maphong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.maphong.Location = new System.Drawing.Point(772, 316);
            this.maphong.Name = "maphong";
            this.maphong.Size = new System.Drawing.Size(100, 25);
            this.maphong.TabIndex = 59;
            this.maphong.Text = "Mã phòng";
            // 
            // datetimeChoThue
            // 
            this.datetimeChoThue.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datetimeChoThue.Location = new System.Drawing.Point(956, 483);
            this.datetimeChoThue.Name = "datetimeChoThue";
            this.datetimeChoThue.Size = new System.Drawing.Size(179, 22);
            this.datetimeChoThue.TabIndex = 68;
            // 
            // txtMaSV
            // 
            this.txtMaSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMaSV.Location = new System.Drawing.Point(956, 539);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(179, 30);
            this.txtMaSV.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(772, 426);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 25);
            this.label5.TabIndex = 59;
            // 
            // cboMaPhong
            // 
            this.cboMaPhong.FormattingEnabled = true;
            this.cboMaPhong.Location = new System.Drawing.Point(956, 320);
            this.cboMaPhong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboMaPhong.Name = "cboMaPhong";
            this.cboMaPhong.Size = new System.Drawing.Size(178, 24);
            this.cboMaPhong.TabIndex = 69;
            // 
            // cboSoPhong
            // 
            this.cboSoPhong.FormattingEnabled = true;
            this.cboSoPhong.Location = new System.Drawing.Point(956, 374);
            this.cboSoPhong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboSoPhong.Name = "cboSoPhong";
            this.cboSoPhong.Size = new System.Drawing.Size(177, 24);
            this.cboSoPhong.TabIndex = 70;
            // 
            // cboGioiTinh
            // 
            this.cboGioiTinh.FormattingEnabled = true;
            this.cboGioiTinh.Location = new System.Drawing.Point(955, 599);
            this.cboGioiTinh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboGioiTinh.Name = "cboGioiTinh";
            this.cboGioiTinh.Size = new System.Drawing.Size(178, 24);
            this.cboGioiTinh.TabIndex = 71;
            // 
            // FrmThueTraPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 675);
            this.Controls.Add(this.cboGioiTinh);
            this.Controls.Add(this.cboSoPhong);
            this.Controls.Add(this.cboMaPhong);
            this.Controls.Add(this.datetimeChoThue);
            this.Controls.Add(this.rdoSoPhong);
            this.Controls.Add(this.rdoMaPhong);
            this.Controls.Add(this.maphong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtdanhsachDichVu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaSV);
            this.Controls.Add(this.txtThoigianthue);
            this.Controls.Add(this.btnChinh);
            this.Controls.Add(this.btnTaoMoi);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTroLai);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.txtMaPhong);
            this.Controls.Add(this.txtSoPhong);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.gdvPhongchothue);
            this.Name = "FrmThueTraPhong";
            this.Text = "FrmThueTraPhong";
            this.Load += new System.EventHandler(this.FrmThueTraPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdvPhongchothue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdoSoPhong;
        private System.Windows.Forms.RadioButton rdoMaPhong;
        private System.Windows.Forms.Label txtdanhsachDichVu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtThoigianthue;
        private System.Windows.Forms.Button btnChinh;
        private System.Windows.Forms.Button btnTaoMoi;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTroLai;
        public System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.TextBox txtSoPhong;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView gdvPhongchothue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label maphong;
        private System.Windows.Forms.DateTimePicker datetimeChoThue;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboMaPhong;
        private System.Windows.Forms.ComboBox cboSoPhong;
        private System.Windows.Forms.ComboBox cboGioiTinh;
    }
}