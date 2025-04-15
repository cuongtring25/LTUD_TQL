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
    public partial class FrmDangnhap: Form
    {
        Ketnoi kn = new Ketnoi();
        public FrmDangnhap()
        {
            InitializeComponent();
        }

        private void FrmDangnhap_Load(object sender, EventArgs e)
        {

        }

        private void btnQuenMatKhau_Click(object sender, EventArgs e)
        {
            FrmQuenMatKhau frm = new FrmQuenMatKhau();
            frm.ShowDialog();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string email = txtTaiKhoan.Text.Trim().ToLower();
            string sdt = txtNhapMatKhau.Text.Trim();

            MessageBox.Show($"DEBUG:\nEmail nhập: {email}\nSDT nhập: {sdt}");

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(sdt))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            if (email == "quynhly1109@gmail.com" && sdt == "11092004")
            {
                MessageBox.Show("Đăng nhập thành công (tài khoản test)!");
                FrmTongQuan frmTongQuan = new FrmTongQuan();
                frmTongQuan.Show();
                this.Hide();
                return;
            }

            string sqlstr = $@"
                            SELECT * FROM SinhVien
                            WHERE LTRIM(RTRIM(LOWER(email))) = LTRIM(RTRIM(LOWER('{email}')))
                            AND LTRIM(RTRIM(dien_thoai)) = LTRIM(RTRIM('{sdt}'))";

            MessageBox.Show("SQL Query: " + sqlstr);  

            DataTable dt = kn.Lay_DulieuBang(sqlstr);

            MessageBox.Show("Số dòng kết quả từ DB: " + dt.Rows.Count);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Đăng nhập thành công!");
                FrmTongQuan frmTongQuan = new FrmTongQuan();
                frmTongQuan.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
