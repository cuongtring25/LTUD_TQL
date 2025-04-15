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
    public partial class FrmKhieuNai : Form
    {
        public FrmKhieuNai()
        {
            InitializeComponent();
        }
        Ketnoi kn = new Ketnoi();

        private void FrmKhieuNai_Load(object sender, EventArgs e)
        {
            LoadKhieuNai();
            BindingDuLieu();
        }

        private void LoadKhieuNai()
        {
            DataTable dtKhieuNai = kn.Lay_DulieuBang("SELECT * FROM KhieuNai");
            dgvKhieuNai.DataSource = dtKhieuNai;

            cboMaKN.DataSource = dtKhieuNai;
            cboMaKN.DisplayMember = "ma_khieu_nai";
            cboMaKN.ValueMember = "ma_khieu_nai";
        }

        private void BindingDuLieu()
        {
            cboMaKhieuNai.DataBindings.Clear();
            cboMaKhieuNai.DataBindings.Add("Text", dgvKhieuNai.DataSource, "ma_khieu_nai");

            txtMaSinhVien.DataBindings.Clear();
            txtMaSinhVien.DataBindings.Add("Text", dgvKhieuNai.DataSource, "ma_sinh_vien");

            txtNoiDung.DataBindings.Clear();
            txtNoiDung.DataBindings.Add("Text", dgvKhieuNai.DataSource, "noi_dung_khieu_nai");

            cboTrangThaiXuLy.DataBindings.Clear();
            cboTrangThaiXuLy.DataBindings.Add("Text", dgvKhieuNai.DataSource, "trang_thai");

            dtNgayTao.DataBindings.Clear();
            dtNgayTao.DataBindings.Add("Value", dgvKhieuNai.DataSource, "ngay_tao");
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string sql;
            DataTable dt;

            if (rdoMaKN.Checked)
            {
                sql = $"SELECT * FROM KhieuNai WHERE ma_khieu_nai = '{cboMaKN.Text}'";
            }
            else if (rdoMaSV.Checked)
            {
                sql = $"SELECT * FROM KhieuNai WHERE ma_sinh_vien = '{txtMaSV.Text}'";
            }
            else
            {
                MessageBox.Show("Vui lòng chọn điều kiện tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dt = kn.Lay_DulieuBang(sql);

            if (dt.Rows.Count > 0)
            {
                dgvKhieuNai.DataSource = dt;
                BindingDuLieu();
            }
            else
            {
                MessageBox.Show("Không tìm thấy dữ liệu phù hợp.", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            string sql = string.Format(
                "INSERT INTO KhieuNai (ma_sinh_vien, noi_dung_khieu_nai, trang_thai, ngay_tao) " +
                "VALUES ('{0}', N'{1}', N'{2}', '{3}')",
                txtMaSinhVien.Text,
                txtNoiDung.Text,
                cboTrangThaiXuLy.Text,
                dtNgayTao.Value.ToString("yyyy-MM-dd")
            );

            kn.Thucthi(sql);
            MessageBox.Show("Thêm khiếu nại thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadKhieuNai();
            BindingDuLieu();
        }

        private void btnChinh_Click(object sender, EventArgs e)
        {
            string sql = string.Format(
                "UPDATE KhieuNai SET ma_sinh_vien = '{0}', noi_dung_khieu_nai = N'{1}', trang_thai = N'{2}', ngay_tao = '{3}' " +
                "WHERE ma_khieu_nai = '{4}'",
                txtMaSinhVien.Text,
                txtNoiDung.Text,
                cboTrangThaiXuLy.Text,
                dtNgayTao.Value.ToString("yyyy-MM-dd"),
                cboMaKhieuNai.Text
            );

            kn.Thucthi(sql);
            MessageBox.Show("Cập nhật khiếu nại thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadKhieuNai();
            BindingDuLieu();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xoá khiếu nại này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string sql = $"DELETE FROM KhieuNai WHERE ma_khieu_nai = '{cboMaKhieuNai.Text}'";
                kn.Thucthi(sql);
                MessageBox.Show("Xoá khiếu nại thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadKhieuNai();
                BindingDuLieu();
            }
        }

        private void btnTroLai_Click(object sender, EventArgs e)
        {
            LoadKhieuNai();
            BindingDuLieu();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
