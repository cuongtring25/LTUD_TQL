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
    public partial class FrmDichVu : Form
    {
        Ketnoi kn = new Ketnoi();
        public FrmDichVu()
        {
            InitializeComponent();
        }

        private void FrmDichVu_Load(object sender, EventArgs e)
        {
            hienthidichvu();
            hienthi_dulieu();
        }
        private void hienthidichvu()
        {
            DataTable dataTable = kn.Lay_DulieuBang("SELECT * FROM DichVu");
            dgvDichVu.DataSource = dataTable;

            cboMaDV.DataSource = dataTable;
            cboMaDV.DisplayMember = "ma_dich_vu";
        }
        private void hienthi_dulieu()
        {
            txtMaDV.DataBindings.Clear();
            txtMaDV.DataBindings.Add("Text", dgvDichVu.DataSource, "ma_dich_vu");

            txtTenDV.DataBindings.Clear();
            txtTenDV.DataBindings.Add("Text", dgvDichVu.DataSource, "ten_dich_vu");

            txtMoTaDV.DataBindings.Clear();
            txtMoTaDV.DataBindings.Add("Text", dgvDichVu.DataSource, "mo_ta");

            txtGiaDV.DataBindings.Clear();
            txtGiaDV.DataBindings.Add("Text", dgvDichVu.DataSource, "gia");
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string timkiem;

            try
            {
                if (rdoMaDV.Checked)
                {
                    timkiem = cboMaDV.Text;
                    string sqlcmd = "SELECT * FROM DichVu WHERE ma_dich_vu = @maDV";

                    kn.Ketnoi_dulieu();
                    SqlCommand cmd = new SqlCommand(sqlcmd, kn.cnn);
                    cmd.Parameters.AddWithValue("@maDV", timkiem);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    kn.Huyketnoi();

                    if (dt.Rows.Count > 0)
                        dgvDichVu.DataSource = dt;
                    else
                        MessageBox.Show("Không có dịch vụ này");
                }
                else if (rdoTenDV.Checked)
                {
                    timkiem = txtDichvu.Text;
                    string sqlcmd = "SELECT * FROM DichVu WHERE ten_dich_vu LIKE @tenDV";

                    kn.Ketnoi_dulieu();
                    SqlCommand cmd = new SqlCommand(sqlcmd, kn.cnn);
                    cmd.Parameters.AddWithValue("@tenDV", "%" + timkiem + "%");
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    kn.Huyketnoi();

                    if (dt.Rows.Count > 0)
                        dgvDichVu.DataSource = dt;
                    else
                        MessageBox.Show("Không có dịch vụ có tên này");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm: " + ex.Message);
            }
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "INSERT INTO DichVu (ten_dich_vu, mo_ta, gia) VALUES (@ten, @mota, @gia)";
                kn.Ketnoi_dulieu();
                SqlCommand cmd = new SqlCommand(sql, kn.cnn);
                cmd.Parameters.AddWithValue("@ten", txtTenDV.Text);
                cmd.Parameters.AddWithValue("@mota", txtMoTaDV.Text);
                cmd.Parameters.AddWithValue("@gia", Convert.ToDecimal(txtGiaDV.Text));
                cmd.ExecuteNonQuery();
                kn.Huyketnoi();
                MessageBox.Show("Tạo mới thành công");
                hienthidichvu();
                hienthi_dulieu();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tạo mới: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                kn.Ketnoi_dulieu();

                string sqlktra1 = "SELECT COUNT(*) FROM ChiTietHoaDon WHERE ma_dich_vu = @maDV";
                string sqlktra2 = "SELECT COUNT(*) FROM DangKyDichVu WHERE ma_dich_vu = @maDV";

                SqlCommand cmd1 = new SqlCommand(sqlktra1, kn.cnn);
                cmd1.Parameters.AddWithValue("@maDV", txtMaDV.Text);
                int count1 = (int)cmd1.ExecuteScalar();

                SqlCommand cmd2 = new SqlCommand(sqlktra2, kn.cnn);
                cmd2.Parameters.AddWithValue("@maDV", txtMaDV.Text);
                int count2 = (int)cmd2.ExecuteScalar();

                if (count1 > 0 || count2 > 0)
                {
                    MessageBox.Show("Mã dịch vụ đang được sử dụng ở nơi khác. Hãy xử lý dữ liệu ở bảng ChiTietHoaDon và DangKyDichVu trước.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string sql = "DELETE FROM DichVu WHERE ma_dich_vu = @maDV";
                    SqlCommand cmd = new SqlCommand(sql, kn.cnn);
                    cmd.Parameters.AddWithValue("@maDV", txtMaDV.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    hienthidichvu();
                    hienthi_dulieu();
                }
                kn.Huyketnoi();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa: " + ex.Message);
            }
        }

        private void btnChinh_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "UPDATE DichVu SET ten_dich_vu = @ten, mo_ta = @mota, gia = @gia WHERE ma_dich_vu = @maDV";
                kn.Ketnoi_dulieu();
                SqlCommand cmd = new SqlCommand(sql, kn.cnn);
                cmd.Parameters.AddWithValue("@ten", txtTenDV.Text);
                cmd.Parameters.AddWithValue("@mota", txtMoTaDV.Text);
                cmd.Parameters.AddWithValue("@gia", Convert.ToDecimal(txtGiaDV.Text));
                cmd.Parameters.AddWithValue("@maDV", txtMaDV.Text);
                cmd.ExecuteNonQuery();
                kn.Huyketnoi();
                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                hienthidichvu();
                hienthi_dulieu();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật: " + ex.Message);
            }
        }

        private void btnTroLai_Click(object sender, EventArgs e)
        {
            hienthidichvu();
            hienthi_dulieu();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
