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
    public partial class FrmDangKyDichVu : Form
    {
        Ketnoi kn = new Ketnoi();
        public FrmDangKyDichVu()
        {
            InitializeComponent();
        }

        private void FrmDangKyDichVu_Load(object sender, EventArgs e)
        {
            LoadDuLieuDangKyDichVu();
            LoadBindingControls();
        }
        private void LoadDuLieuDangKyDichVu()
        {
            DataTable dtDangKy = kn.Lay_DulieuBang("SELECT * FROM DangKyDichVu");
            dgvDangKyDichvu.DataSource = dtDangKy;

            cboMaDK.DataSource = dtDangKy;
            cboMaDK.DisplayMember = "ma_dang_ky";

            cboMaDK.SelectedIndex = -1;

            cboMaDangKy.DataSource = kn.Lay_DulieuBang("SELECT * FROM SinhVien");
            cboMaDangKy.DisplayMember = "ma_dang_ky";

            cboMaDV.DataSource = kn.Lay_DulieuBang("SELECT * FROM DichVu");
            cboMaDV.DisplayMember = "ma_dich_vu";
        }

        private void LoadBindingControls()
        {
            cboMaDangKy.DataBindings.Clear();
            cboMaDangKy.DataBindings.Add("Text", dgvDangKyDichvu.DataSource, "ma_dang_ky");

            cboMaDangKy.DataBindings.Clear();
            cboMaDangKy.DataBindings.Add("Text", dgvDangKyDichvu.DataSource, "ma_sinh_vien");

            cboMaDV.DataBindings.Clear();
            cboMaDV.DataBindings.Add("Text", dgvDangKyDichvu.DataSource, "ma_dich_vu");

            dtNgayDK.DataBindings.Clear();
            dtNgayDK.DataBindings.Add("Value", dgvDangKyDichvu.DataSource, "ngay_dang_ky");

            cboTrthaiTtoan.DataBindings.Clear();
            cboTrthaiTtoan.DataBindings.Add("Text", dgvDangKyDichvu.DataSource, "trang_thai");
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string sqlcmd = string.Empty;
            string timkiem = string.Empty;

            if (rdoMaDK.Checked)
            {
                timkiem = cboMaDK.Text;
                sqlcmd = $"SELECT * FROM DangKyDichVu WHERE ma_dang_ky = {timkiem}";
            }
            else if (rdoMaSV.Checked)
            {
                timkiem = txtMaSV.Text;
                sqlcmd = $"SELECT * FROM DangKyDichVu WHERE ma_sinh_vien = {timkiem}";
            }

            DataTable dt = kn.Lay_DulieuBang(sqlcmd);

            if (dt.Rows.Count > 0)
            {
                dgvDangKyDichvu.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Không tìm thấy dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            string sqlInsert = $"INSERT INTO DangKyDichVu VALUES({txtMaSinhVien.Text}, {cboMaDV.Text}, '{dtNgayDK.Value}', '{cboTrthaiTtoan.Text}')";
            kn.Thucthi(sqlInsert);
            MessageBox.Show("Tạo mới thành công!");
            LoadDuLieuDangKyDichVu();
            LoadBindingControls();
        }

        private void btnChinh_Click(object sender, EventArgs e)
        {
            string sqlUpdate = $"UPDATE DangKyDichVu SET ma_sinh_vien = {txtMaSinhVien.Text}, ma_dich_vu = {cboMaDV.Text}, ngay_dang_ky = '{dtNgayDK.Value}', trang_thai = '{cboTrthaiTtoan.Text}' WHERE ma_dang_ky = {cboMaDangKy.Text}";
            kn.Thucthi(sqlUpdate);
            MessageBox.Show("Cập nhật thành công!");
            LoadDuLieuDangKyDichVu();
            LoadBindingControls();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sqlDelete = $"DELETE FROM DangKyDichVu WHERE ma_dang_ky = {cboMaDangKy.Text}";
            kn.Thucthi(sqlDelete);
            MessageBox.Show("Xóa thành công!");
            LoadDuLieuDangKyDichVu();
            LoadBindingControls();
        }

        private void btnTroLai_Click(object sender, EventArgs e)
        {
            LoadDuLieuDangKyDichVu();
            LoadBindingControls();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
