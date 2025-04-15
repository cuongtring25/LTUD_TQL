using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanLyktx
{
    public partial class FrmHoaDon : Form
    {
        Ketnoi kn = new Ketnoi();
        public FrmHoaDon()
        {
            InitializeComponent();
        }

        private void FrmHoaDon_Load(object sender, EventArgs e)
        {
            hienthihoadon();
            hienthi_dulieu();
        }
        private void hienthihoadon()
        {
            try
            {
                DataTable dataTable = kn.Lay_DulieuBang("SELECT * FROM HoaDon");
                dgvHoaDon.DataSource = dataTable;

                cboMaHoaDon.DataSource = dataTable;
                cboMaHoaDon.DisplayMember = "ma_hoa_don";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }
        private void hienthi_dulieu()
        {
            txtMaHoaDon.DataBindings.Clear();
            txtMaHoaDon.DataBindings.Add("Text", dgvHoaDon.DataSource, "ma_hoa_don");

            txtMaSV.DataBindings.Clear();
            txtMaSV.DataBindings.Add("Text", dgvHoaDon.DataSource, "ma_sinh_vien");

            txtTongSoTien.DataBindings.Clear();
            txtTongSoTien.DataBindings.Add("Text", dgvHoaDon.DataSource, "tong_so_tien");

            cboTrangThaiThanhToan.DataBindings.Clear();
            cboTrangThaiThanhToan.DataBindings.Add("Text", dgvHoaDon.DataSource, "trang_thai_thanh_toan");

            dtNgayTao.DataBindings.Clear();
            dtNgayTao.DataBindings.Add("Value", dgvHoaDon.DataSource, "ngay_tao");
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string timkiem;
            string sqlcmd;
            if (rdoMaHoaDon.Checked == true)
            {
                timkiem = cboMaHoaDon.Text;
                sqlcmd = string.Format("select * from HoaDon where ma_hoa_don = {0}", timkiem);
                dt = kn.Lay_DulieuBang(sqlcmd);
                if (dt != null && dt.Rows.Count > 0)
                {
                    dgvHoaDon.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("không có mã hóa đơn này");
                    cboMaHoaDon.Focus();
                }
            }
            if (rdoMaSinhVien.Checked == true)
            {
                timkiem = txtMaSinhVien.Text;
                sqlcmd = string.Format("select * from HoaDon where ma_sinh_vien = {0}", timkiem);
                dt = kn.Lay_DulieuBang(sqlcmd);
                if (dt != null && dt.Rows.Count > 0)
                {
                    dgvHoaDon.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("không có hóa đơn có mã sinh viên này");
                    txtMaSinhVien.Focus();
                }
            }
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            string sqlluu = string.Format("insert into HoaDon values({0},{1},'{2}','{3}')", txtMaSV.Text, txtTongSoTien.Text, cboTrangThaiThanhToan.Text, dtNgayTao.Value);
            kn.Thucthi(sqlluu);
            MessageBox.Show("Tạo mới thành công");
            hienthihoadon();
            hienthi_dulieu();
        }

        private void btnChinh_Click(object sender, EventArgs e)
        {
            string sqlupdate = $"update HoaDon set ma_sinh_vien = {txtMaSV.Text},tong_so_tien={txtTongSoTien.Text},ngay_tao='{dtNgayTao.Value}',trang_thai_thanh_toan='{cboTrangThaiThanhToan.Text}' where ma_hoa_don = {txtMaHoaDon.Text} ";
            kn.Thucthi(sqlupdate);
            MessageBox.Show("Update thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            hienthihoadon();
            hienthi_dulieu();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sqlktra = $"select * from ChiTietHoaDon where ma_hoa_don = {txtMaHoaDon.Text}";
            kn.Ketnoi_dulieu();
            SqlCommand cmd1 = new SqlCommand(sqlktra, kn.cnn);
            SqlDataReader rdr1 = cmd1.ExecuteReader();
            if (rdr1.Read())
            {
                MessageBox.Show("Mã hóa đơn đang được sử dụng ở nơi khác. Hãy xử lý dữ liệu ở bảng ChiTietHoaDon trước.",
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                kn.Huyketnoi();
            }
            else
            {
                rdr1.Close();
                string sqlthucthi = $"DELETE FROM HoaDon WHERE ma_hoa_don = {txtMaHoaDon.Text}";
                kn.Thucthi(sqlthucthi);
                MessageBox.Show("Xóa thành công",
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                hienthihoadon();
                hienthi_dulieu();
            }
        }

        private void btnTroLai_Click(object sender, EventArgs e)
        {
            hienthihoadon();
            hienthi_dulieu();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
