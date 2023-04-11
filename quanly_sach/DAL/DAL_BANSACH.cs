using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanly_sach.DAL
{
    class DAL_BANSACH
    {
        lopdungchung ldc;
        public DAL_BANSACH()
        {
            ldc = new lopdungchung();
        }
        // Lấy dữ liệu từ bảng bansach
        public DataTable dal_loaddatabansach()
        {
            string sql = "select * from bansach";
            return ldc.loaddata(sql);
        }
        // cập nhập bảng bansach
        public void dal_updatadbbs(string tenkhachhang, string masach, string sotien)
        {
            string sql = "insert into bansach values(N'" + tenkhachhang + "', '" + masach + "', '" + sotien + "')";
            ldc.nonquery(sql);
        }
        // Xoa bansach theo ma sach
        public void DAL_xoabansach_masach(string masach)
        {
            string sqlXoa = "delete from bansach where masach = '" + masach + "'";
            ldc.nonquery(sqlXoa);
        }
    }
}
