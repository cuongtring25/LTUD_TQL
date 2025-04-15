namespace quanLyktx
{
    partial class FrmQuenMatKhau
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
            this.btnGuiMa = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNhapTaiKhoan = new System.Windows.Forms.Label();
            this.txtDangNhap = new System.Windows.Forms.Label();
            this.lblThongBao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGuiMa
            // 
            this.btnGuiMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuiMa.Location = new System.Drawing.Point(656, 638);
            this.btnGuiMa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuiMa.Name = "btnGuiMa";
            this.btnGuiMa.Size = new System.Drawing.Size(222, 55);
            this.btnGuiMa.TabIndex = 18;
            this.btnGuiMa.Text = "Gửi mã!";
            this.btnGuiMa.UseVisualStyleBackColor = true;
            this.btnGuiMa.Click += new System.EventHandler(this.btnGuiMa_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(675, 469);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(481, 31);
            this.txtEmail.TabIndex = 17;
            // 
            // txtNhapTaiKhoan
            // 
            this.txtNhapTaiKhoan.AutoSize = true;
            this.txtNhapTaiKhoan.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtNhapTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhapTaiKhoan.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtNhapTaiKhoan.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.txtNhapTaiKhoan.Location = new System.Drawing.Point(446, 469);
            this.txtNhapTaiKhoan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtNhapTaiKhoan.Name = "txtNhapTaiKhoan";
            this.txtNhapTaiKhoan.Size = new System.Drawing.Size(158, 31);
            this.txtNhapTaiKhoan.TabIndex = 14;
            this.txtNhapTaiKhoan.Text = "Nhập email:";
            // 
            // txtDangNhap
            // 
            this.txtDangNhap.AutoSize = true;
            this.txtDangNhap.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDangNhap.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtDangNhap.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.txtDangNhap.Location = new System.Drawing.Point(483, 352);
            this.txtDangNhap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtDangNhap.Name = "txtDangNhap";
            this.txtDangNhap.Size = new System.Drawing.Size(621, 51);
            this.txtDangNhap.TabIndex = 16;
            this.txtDangNhap.Text = "Nhập email để lấy lại mật khẩu!";
            // 
            // lblThongBao
            // 
            this.lblThongBao.AutoSize = true;
            this.lblThongBao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongBao.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblThongBao.Location = new System.Drawing.Point(669, 560);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(161, 33);
            this.lblThongBao.TabIndex = 19;
            this.lblThongBao.Text = "Thông báo:";
            // 
            // FrmQuenMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1665, 1164);
            this.Controls.Add(this.lblThongBao);
            this.Controls.Add(this.btnGuiMa);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNhapTaiKhoan);
            this.Controls.Add(this.txtDangNhap);
            this.Name = "FrmQuenMatKhau";
            this.Text = "FrmQuenMatKhau";
            this.Load += new System.EventHandler(this.FrmQuenMatKhau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuiMa;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label txtNhapTaiKhoan;
        private System.Windows.Forms.Label txtDangNhap;
        private System.Windows.Forms.Label lblThongBao;
    }
}