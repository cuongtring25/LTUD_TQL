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
    public partial class FrmSinhVien : Form
    {
        Ketnoi kn = new Ketnoi();
        public FrmSinhVien()
        {
            InitializeComponent();
        }

        private void FrmSinhVien_Load(object sender, EventArgs e)
        {
            LoadData();

            cboGioiTinh.Items.Clear();
            cboGioiTinh.Items.Add("Nam");
            cboGioiTinh.Items.Add("Nữ");
            cboGioiTinh.SelectedIndex = 0;
        }
        void LoadData()
        {
            string sql = "SELECT * FROM SinhVien";
            dgvDichvu.DataSource = kn.Lay_DulieuBang(sql);
        }

        private void dgvDichvu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i >= 0)
            {
                txtMaSV.Text = dgvDichvu.Rows[i].Cells["ma_sinh_vien"].Value.ToString();
                txtTenSV.Text = dgvDichvu.Rows[i].Cells["ho_ten"].Value.ToString();
                cboGioiTinh.Text = dgvDichvu.Rows[i].Cells["gioi_tinh"].Value.ToString();
                dateTimeNS.Value = Convert.ToDateTime(dgvDichvu.Rows[i].Cells["ngay_sinh"].Value);
                txtSoDT.Text = dgvDichvu.Rows[i].Cells["dien_thoai"].Value.ToString();
                txtEmail.Text = dgvDichvu.Rows[i].Cells["email"].Value.ToString();
            }
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            if (txtTenSV.Text == "" || cboGioiTinh.SelectedIndex == -1 || txtSoDT.Text == "" || txtEmail.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thiếu dữ liệu");
                return;
            }

            string checkSql = $"SELECT COUNT(*) FROM SinhVien WHERE ma_sinh_vien = '{txtMaSV.Text}'";
            DataTable dtCheck = kn.Lay_DulieuBang(checkSql);
            if (Convert.ToInt32(dtCheck.Rows[0][0]) > 0)
            {
                MessageBox.Show("Mã sinh viên đã tồn tại!", "Trùng mã");
                return;
            }

            string sql = $"INSERT INTO SinhVien (ho_ten, gioi_tinh, ngay_sinh, dien_thoai, email) " +
             $"VALUES (N'{txtTenSV.Text}', N'{cboGioiTinh.Text}', " +
             $"'{dateTimeNS.Value:yyyy-MM-dd}', '{txtSoDT.Text}', '{txtEmail.Text}')";

            kn.Thucthi(sql);
            LoadData();
            MessageBox.Show("Thêm thành công!");
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            string sql = $"UPDATE SinhVien SET " +
              $"ho_ten = N'{txtTenSV.Text}', " +
              $"gioi_tinh = N'{cboGioiTinh.Text}', " +
              $"ngay_sinh = '{dateTimeNS.Value:yyyy-MM-dd}', " +
              $"dien_thoai = '{txtSoDT.Text}', " +
              $"email = '{txtEmail.Text}' " +
              $"WHERE ma_sinh_vien = '{txtMaSV.Text}'";

            kn.Thucthi(sql);
            LoadData();
            MessageBox.Show("Cập nhật thành công!");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                string sql = $"DELETE FROM SinhVien WHERE ma_sinh_vien = '{txtMaSV.Text}'";
                kn.Thucthi(sql);
                LoadData();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string sql = "";
            if (rdoMaSV.Checked)
            {
                sql = $"SELECT * FROM SinhVien WHERE ma_sinh_vien = '{txtTimKiemMa.Text}'";
            }

            else if (rdoTenSV.Checked)
            {
                sql = $"SELECT * FROM SinhVien WHERE ho_ten LIKE N'%{txtTimKiemTen.Text}%'";
            }

            dgvDichvu.DataSource = kn.Lay_DulieuBang(sql);
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
