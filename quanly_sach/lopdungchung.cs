using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanly_sach
{
    class lopdungchung
    {
        string chuoiketnoi = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CODE\lập trình ứng dụng .net\project\quanly_sach\quanly_sach\QL_sach.mdf;Integrated Security=True";
        SqlConnection cn;
        public lopdungchung()
        {
            cn = new SqlConnection(chuoiketnoi);
        }
        public DataTable loaddata(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public void nonquery(string sql)
        {
            SqlCommand cm = new SqlCommand(sql, cn);
            cn.Open();
            try
            {
                int dem = cm.ExecuteNonQuery();
                if (dem >= 1) MessageBox.Show("Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show("Thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi SQL, lỗi cacth", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                cn.Close();
            }
            cn.Close();
        }
        public int scalar(string sql)
        {
            SqlCommand cm = new SqlCommand(sql, cn);
            cn.Open();
            int dem = (int)cm.ExecuteScalar();
            cn.Close();
            return dem;
        }
        public object tinhtien(string sql)
        {
            SqlCommand cm = new SqlCommand(sql, cn);
            cn.Open();
            object dem = cm.ExecuteScalar();
            cn.Close();
            return dem;
        }
        
    }
}
