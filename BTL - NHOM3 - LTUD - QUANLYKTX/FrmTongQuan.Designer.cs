namespace quanLyktx
{
    partial class FrmTongQuan
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.quảnLýPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPhong1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPhong2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPhong3 = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýTàiKhoảnQuảnTrịViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSinhvien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQlyHoadon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQlyKhieunai = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThongke = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.mnuDkyDichvu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýPhòngToolStripMenuItem,
            this.quảnLýTàiKhoảnQuảnTrịViênToolStripMenuItem,
            this.mnuQlyHoadon,
            this.mnuQlyKhieunai,
            this.mnuThongke});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 4, 0, 4);
            this.menuStrip.Size = new System.Drawing.Size(1772, 46);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // quảnLýPhòngToolStripMenuItem
            // 
            this.quảnLýPhòngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPhong1,
            this.mnuPhong2,
            this.mnuPhong3});
            this.quảnLýPhòngToolStripMenuItem.Name = "quảnLýPhòngToolStripMenuItem";
            this.quảnLýPhòngToolStripMenuItem.Size = new System.Drawing.Size(194, 38);
            this.quảnLýPhòngToolStripMenuItem.Text = "Quản lý phòng";
            // 
            // mnuPhong1
            // 
            this.mnuPhong1.Name = "mnuPhong1";
            this.mnuPhong1.Size = new System.Drawing.Size(398, 44);
            this.mnuPhong1.Text = "Thông Tin Phòng";
            this.mnuPhong1.Click += new System.EventHandler(this.mnuPhong1_Click);
            // 
            // mnuPhong2
            // 
            this.mnuPhong2.Name = "mnuPhong2";
            this.mnuPhong2.Size = new System.Drawing.Size(398, 44);
            this.mnuPhong2.Text = "Quản lý dịch vụ";
            this.mnuPhong2.Click += new System.EventHandler(this.mnuPhong2_Click);
            // 
            // mnuPhong3
            // 
            this.mnuPhong3.Name = "mnuPhong3";
            this.mnuPhong3.Size = new System.Drawing.Size(398, 44);
            this.mnuPhong3.Text = "Quản lý thuê trả phòng";
            this.mnuPhong3.Click += new System.EventHandler(this.mnuPhong3_Click);
            // 
            // quảnLýTàiKhoảnQuảnTrịViênToolStripMenuItem
            // 
            this.quảnLýTàiKhoảnQuảnTrịViênToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSinhvien,
            this.mnuDkyDichvu});
            this.quảnLýTàiKhoảnQuảnTrịViênToolStripMenuItem.Name = "quảnLýTàiKhoảnQuảnTrịViênToolStripMenuItem";
            this.quảnLýTàiKhoảnQuảnTrịViênToolStripMenuItem.Size = new System.Drawing.Size(230, 38);
            this.quảnLýTàiKhoảnQuảnTrịViênToolStripMenuItem.Text = "Quản lý tài khoản ";
            // 
            // mnuSinhvien
            // 
            this.mnuSinhvien.Name = "mnuSinhvien";
            this.mnuSinhvien.Size = new System.Drawing.Size(359, 44);
            this.mnuSinhvien.Text = "Quản lý sinh viên";
            this.mnuSinhvien.Click += new System.EventHandler(this.mnuSinhvien_Click);
            // 
            // mnuQlyHoadon
            // 
            this.mnuQlyHoadon.Name = "mnuQlyHoadon";
            this.mnuQlyHoadon.Size = new System.Drawing.Size(219, 38);
            this.mnuQlyHoadon.Text = "Quản lý Hóa Đơn";
            this.mnuQlyHoadon.Click += new System.EventHandler(this.mnuQlyHoadon_Click);
            // 
            // mnuQlyKhieunai
            // 
            this.mnuQlyKhieunai.Name = "mnuQlyKhieunai";
            this.mnuQlyKhieunai.Size = new System.Drawing.Size(228, 38);
            this.mnuQlyKhieunai.Text = "Quản lý Khiếu Nại";
            this.mnuQlyKhieunai.Click += new System.EventHandler(this.mnuQlyKhieunai_Click);
            // 
            // mnuThongke
            // 
            this.mnuThongke.Name = "mnuThongke";
            this.mnuThongke.Size = new System.Drawing.Size(135, 38);
            this.mnuThongke.Text = "Thống kê";
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Location = new System.Drawing.Point(0, 46);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.toolStrip.Size = new System.Drawing.Size(1772, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 829);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(2, 0, 28, 0);
            this.statusStrip.Size = new System.Drawing.Size(1772, 42);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(78, 32);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // mnuDkyDichvu
            // 
            this.mnuDkyDichvu.Name = "mnuDkyDichvu";
            this.mnuDkyDichvu.Size = new System.Drawing.Size(359, 44);
            this.mnuDkyDichvu.Text = "Đăng ký dịch vụ";
            this.mnuDkyDichvu.Click += new System.EventHandler(this.mnuDkyDichvu_Click);
            // 
            // FrmTongQuan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1772, 871);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmTongQuan";
            this.Load += new System.EventHandler(this.FrmTongQuan_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem mnuThongke;
        private System.Windows.Forms.ToolStripMenuItem quảnLýPhòngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuPhong2;
        private System.Windows.Forms.ToolStripMenuItem mnuPhong3;
        private System.Windows.Forms.ToolStripMenuItem mnuPhong1;
        private System.Windows.Forms.ToolStripMenuItem mnuQlyHoadon;
        private System.Windows.Forms.ToolStripMenuItem mnuQlyKhieunai;
        private System.Windows.Forms.ToolStripMenuItem quảnLýTàiKhoảnQuảnTrịViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuSinhvien;
        private System.Windows.Forms.ToolStripMenuItem mnuDkyDichvu;
    }
}



