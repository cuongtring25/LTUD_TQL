using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanLyktx
{
    public partial class FrmThueTraPhong : Form
    {
        Ketnoi kn = new Ketnoi();
        public FrmThueTraPhong()
        {
            InitializeComponent();

        }

        private void FrmThueTraPhong_Load(object sender, EventArgs e)
        {
            cboMaPhong.DataSource = kn.Lay_DulieuBang("SELECT ma_phong FROM PHONG");
            cboMaPhong.DisplayMember = "ma_phong";
            cboMaPhong.ValueMember = "ma_phong";

            
            cboSoPhong.DataSource = kn.Lay_DulieuBang("SELECT DISTINCT so_phong FROM PHONG");
            cboSoPhong.DisplayMember = "so_phong";
            cboSoPhong.ValueMember = "so_phong";

            
            cboGioiTinh.Items.Add("Nam");
            cboGioiTinh.Items.Add("Nữ");

           
            Load_ThueTraPhong();
        }
        private void Load_ThueTraPhong()
        {
            string sql = "SELECT * FROM THUETRAPHONG";
            gdvPhongchothue.DataSource = kn.Lay_DulieuBang(sql);
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            try
            {
                string maPhong = cboMaPhong.SelectedValue?.ToString();
                string soPhong = cboSoPhong.SelectedItem?.ToString();
                string khoangThoiGian = txtThoigianthue.Text.Trim();
                string tinhTuNgay = datetimeChoThue.Value.ToString("yyyy-MM-dd");
                string maSV = txtMaSV.Text.Trim();
                string gioiTinh = cboGioiTinh.SelectedItem?.ToString();

                if (string.IsNullOrEmpty(maPhong) || string.IsNullOrEmpty(maSV))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo");
                    return;
                }

                string sql = $@"INSERT INTO THUETRAPHONG (ma_phong, so_phong, khoang_thoi_gian, tinh_tu_ngay, ma_sinh_vien, gioi_tinh)
                        VALUES ('{maPhong}', '{soPhong}', N'{khoangThoiGian}', '{tinhTuNgay}', '{maSV}', N'{gioiTinh}')";
                kn.Thucthi(sql);
                Load_ThueTraPhong();
                MessageBox.Show("Thêm mới thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (gdvPhongchothue.CurrentRow != null)
            {
                string maPhong = gdvPhongchothue.CurrentRow.Cells["ma_phong"].Value.ToString();
                string maSV = gdvPhongchothue.CurrentRow.Cells["ma_sinh_vien"].Value.ToString();

                DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo);
                if (r == DialogResult.Yes)
                {
                    string sql = $@"DELETE FROM THUETRAPHONG 
                            WHERE ma_phong = '{maPhong}' AND ma_sinh_vien = '{maSV}'";
                    kn.Thucthi(sql);
                    Load_ThueTraPhong();
                }
            }
        }

        private void btnChinh_Click(object sender, EventArgs e)
        {
            try
            {
                string maPhong = cboMaPhong.SelectedValue?.ToString();
                string soPhong = cboSoPhong.SelectedItem?.ToString();
                string khoangThoiGian = txtThoigianthue.Text.Trim();
                string tinhTuNgay = datetimeChoThue.Value.ToString("yyyy-MM-dd");
                string maSV = txtMaSV.Text.Trim();
                string gioiTinh = cboGioiTinh.SelectedItem?.ToString();

                string sql = $@"UPDATE THUETRAPHONG 
                        SET so_phong = '{soPhong}', khoang_thoi_gian = N'{khoangThoiGian}', 
                            tinh_tu_ngay = '{tinhTuNgay}', gioi_tinh = N'{gioiTinh}'
                        WHERE ma_phong = '{maPhong}' AND ma_sinh_vien = '{maSV}'";
                kn.Thucthi(sql);
                Load_ThueTraPhong();
                MessageBox.Show("Cập nhật thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật: " + ex.Message);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM THUETRAPHONG WHERE 1=1";

            if (rdoMaPhong.Checked && !string.IsNullOrEmpty(txtMaPhong.Text))
            {
                sql += $" AND ma_phong = '{txtMaPhong.Text.Trim()}'";
            }
            else if (rdoSoPhong.Checked && !string.IsNullOrEmpty(txtSoPhong.Text))
            {
                sql += $" AND so_phong = '{txtSoPhong.Text.Trim()}'";
            }

            gdvPhongchothue.DataSource = kn.Lay_DulieuBang(sql);
        }

        private void gdvPhongchothue_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = gdvPhongchothue.Rows[e.RowIndex];
                cboMaPhong.SelectedValue = row.Cells["ma_phong"].Value.ToString();
                cboSoPhong.Text = row.Cells["so_phong"].Value.ToString();
                txtThoigianthue.Text = row.Cells["khoang_thoi_gian"].Value.ToString();
                datetimeChoThue.Value = Convert.ToDateTime(row.Cells["tinh_tu_ngay"].Value);
                txtMaSV.Text = row.Cells["ma_sinh_vien"].Value.ToString();
                cboGioiTinh.Text = row.Cells["gioi_tinh"].Value.ToString();
            }
        }

        private void btnTroLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
