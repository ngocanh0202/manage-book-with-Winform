using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanly_sach.DAL
{
    class DAL_LOGIN
    {
        lopdungchung ldc;
        public DAL_LOGIN()
        {
            ldc = new lopdungchung();
        }
        public int dal_dangnhap(string tendangnhap, string matkhau)
        {
            string sql = "select count(*) from login where tendangnhap = '"+tendangnhap+"' and matkhau = '"+matkhau+"'";
            return (int)ldc.scalar(sql);
        }
    }
}
