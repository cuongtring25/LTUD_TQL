using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanLyktx
{
    class Ketnoi
    {
        public SqlConnection cnn;
        public SqlCommand cmd;
        public DataTable dta;
        public SqlDataAdapter ada;

        public void Ketnoi_dulieu()
        {
            string strKetNoi = @"Data Source=QUYNHLY;Initial Catalog=QUANLYKTX;Integrated Security=True";
            cnn = new SqlConnection(strKetNoi);
            cnn.Open();
        }

        public void Huyketnoi()
        {
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
        }

        public DataTable Lay_DulieuBang(string Sql)
        {
            Ketnoi_dulieu();
            ada = new SqlDataAdapter(Sql, cnn);
            dta = new DataTable();
            ada.Fill(dta);
            Huyketnoi(); // thêm đóng kết nối sau khi lấy xong
            return dta;
        }

        public void Thucthi(string Sql)
        {
            Ketnoi_dulieu();
            cmd = new SqlCommand(Sql, cnn);
            cmd.ExecuteNonQuery();
            Huyketnoi();
        }
    }
}
