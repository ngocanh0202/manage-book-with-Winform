using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanly_sach.DAL
{
    class DAL_SACH
    {
        lopdungchung ldc;
        public DAL_SACH()
        {
            ldc = new lopdungchung();
        }

        // lấy dữ liệu từ bảng sach
        public DataTable dal_loaddatasach()
        {
            string sql = "select * from sach";
            return ldc.loaddata(sql);
        }
        // lay du lieu tu bang theo ten sach
        public DataTable dal_timkiem(string tensach)
        {
            string sql = "select * from sach where tensach like '%" + tensach + "%' ";
            return ldc.loaddata(sql);
        }
        // lấy dữ liệu bảng sach với maloaisach
        public DataTable dal_sach_theo_maloaisach(string loaisach)
        {
            string sql = "select * from sach where maloaisach = '" + loaisach + "' ";
            return ldc.loaddata(sql);
        }
    }
}
