using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanly_sach.DAL
{
    class DAL_LOAISACH
    {
        lopdungchung ldc;
        public DAL_LOAISACH()
        {
            ldc = new lopdungchung();
        }
        // lấy dữ liệu từ bảng loaisach
        public DataTable dal_loaddataloaisach()
        {
            string sql = "select * from loaisach";
            return ldc.loaddata(sql);
        }
    }
}
