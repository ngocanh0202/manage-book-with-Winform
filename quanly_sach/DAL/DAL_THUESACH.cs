using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanly_sach.DAL
{
    class DAL_THUESACH
    {
        lopdungchung ldc;
        public DAL_THUESACH()
        {
            ldc = new lopdungchung();
        }
        
        // Lấy dữ liệu từ bảng thuesach
        public DataTable dal_loaddatathuesach()
        {
            string sql = "select * from thuesach";
            return ldc.loaddata(sql);
        }

        // cập nhập bảng thuesach
        public void dal_thuesach(string tenkhachhang, string masach, DateTime ngaymuon, DateTime ngaytra, string tinhtrang)
        {
            string sql = "insert into thuesach values(N'"+tenkhachhang+"', '"+masach+"', '"+ngaymuon+"', '"+ngaytra+"',N'"+tinhtrang+"')";
            ldc.nonquery(sql);
        }
        // Xoa thuesach theo masach
        public void DAL_thuesach_masach(string masach)
        {
            string sqlXoa = "delete from thuesach where masach = '" + masach + "'";
            ldc.nonquery(sqlXoa);
        }

    }
}
