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
    public partial class FrmPhong : Form
    {
        Ketnoi kn = new Ketnoi();

        public FrmPhong()
        {
            InitializeComponent();
        }

        private void FrmPhong_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            string sql = "SELECT * FROM Phong";
            dgvPhong.DataSource = kn.Lay_DulieuBang(sql);
        }

        private void dgvPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPhong.Rows[e.RowIndex];
                txtMaPhong.Text = row.Cells["ma_phong"].Value.ToString();
                txtSoPhong.Text = row.Cells["so_phong"].Value.ToString();
                txtSucChua.Text = row.Cells["suc_chua"].Value.ToString();
                txtSoNguoiHT.Text = row.Cells["so_nguoi_hien_tai"].Value.ToString();
                txtGia.Text = row.Cells["gia"].Value.ToString();
            }
        }

        private void btnTimKiemDichVu_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Phong WHERE ma_phong = '" + txtMaPhong.Text + "'";
            dgvPhong.DataSource = kn.Lay_DulieuBang(sql);
        }

        private void btnChinh_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaPhong.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã phòng để chỉnh sửa!", "Thông báo");
                return;
            }

            string maPhong = txtMaPhong.Text;
            string sqlCheck = $"SELECT COUNT(*) FROM Phong WHERE ma_phong = '{maPhong}'";
            DataTable dtCheck = kn.Lay_DulieuBang(sqlCheck);

            if (dtCheck.Rows.Count > 0 && Convert.ToInt32(dtCheck.Rows[0][0]) > 0)
            {
                string sqlUpdate = $"UPDATE Phong SET " +
                                   $"so_phong = '{txtSoPhong.Text}', " +
                                   $"suc_chua = '{txtSucChua.Text}', " +
                                   $"so_nguoi_hien_tai = '{txtSoNguoiHT.Text}', " +
                                   $"gia = '{txtGia.Text}' " +
                                   $"WHERE ma_phong = '{maPhong}'";
                kn.Thucthi(sqlUpdate);
                LoadData(); 
                MessageBox.Show("Cập nhật thông tin phòng thành công!");
            }
            else
            {
                MessageBox.Show("Không tìm thấy phòng với mã này!", "Lỗi");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa phòng này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string sqlXoa = $"DELETE FROM Phong WHERE ma_phong = '{txtMaPhong.Text}'";
                kn.Thucthi(sqlXoa);
                LoadData();
            }
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txtSoPhong.Text) ||
                string.IsNullOrWhiteSpace(txtSucChua.Text) ||
                string.IsNullOrWhiteSpace(txtSoNguoiHT.Text) ||
                string.IsNullOrWhiteSpace(txtGia.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo");
                return;
            }

            string sqlThem = $"INSERT INTO Phong (so_phong, suc_chua, so_nguoi_hien_tai, gia) " +
                             $"VALUES ('{txtSoPhong.Text}', '{txtSucChua.Text}', '{txtSoNguoiHT.Text}', '{txtGia.Text}')";
            kn.Thucthi(sqlThem);
            LoadData(); 
            MessageBox.Show("Đã thêm mới phòng thành công!");

           
            txtMaPhong.Clear();
            txtSoPhong.Clear();
            txtSucChua.Clear();
            txtSoNguoiHT.Clear();
            txtGia.Clear();
        
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
