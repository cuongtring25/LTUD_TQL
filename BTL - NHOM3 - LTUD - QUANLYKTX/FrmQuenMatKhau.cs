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
    public partial class FrmQuenMatKhau: Form
    {
        Ketnoi kn = new Ketnoi();
        public FrmQuenMatKhau()
        {
            InitializeComponent();
        }

        private void btnGuiMa_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();

            if (string.IsNullOrEmpty(email))
            {
                lblThongBao.Text = "Vui lòng nhập email!";
                lblThongBao.ForeColor = Color.Red;
                return;
            }

            
            string sql = $"SELECT * FROM SinhVien WHERE email = '{email}'";
            DataTable dt = kn.Lay_DulieuBang(sql);

            if (dt.Rows.Count > 0)
            {
                
                string matKhau = dt.Rows[0]["dien_thoai"].ToString();

                MessageBox.Show($"Mật khẩu của bạn là: {matKhau}", "Khôi phục mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); 
            }
            else
            {
                lblThongBao.Text = "Email không tồn tại trong hệ thống!";
                lblThongBao.ForeColor = Color.Red;
            }
        }

        private void FrmQuenMatKhau_Load(object sender, EventArgs e)
        {

        }
    }
}
