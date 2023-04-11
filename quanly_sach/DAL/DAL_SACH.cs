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
        public void dal_them_sach(string masach, string tensach, string mota,string maloaisach,string sotien)
        {
            string sql = "insert into sach values('" + masach + "',N'"+tensach+"',N'"+mota+"', '"+maloaisach+"','"+sotien+"')";
            ldc.nonquery(sql);
        }
        public void dal_xoa_sach(string masach)
        {
            string sql = "delete from sach where masach = '"+masach+"' ";
            ldc.nonquery(sql);
        }
        public void dal_sua_sach(string masach, string tensach, string mota, string maloaisach, string sotien)
        {
            string sql = "update sach set tensach = N'"+tensach+"', mota =N'"+mota+"', maloaisach = '"+maloaisach+"', sotien = '"+sotien+"' where masach = '"+masach+"'";
            ldc.nonquery(sql);
        }
        public DataTable dal_loaddatasach_masach_tensach_sotien()
        {
            string sql = "select sach.masach, sach.tensach, sach.sotien from sach";
            return ldc.loaddata(sql);
        }
        public DataTable dal_sach_chuaban()
        {
            string sql = "SELECT sach.masach, sach.tensach, sach.sotien FROM sach WHERE sach.masach NOT IN(SELECT bansach.masach FROM bansach)";
            return ldc.loaddata(sql);
        }
        public DataTable dall_sach_ban()
        {
            string sql = "select sach.masach, sach.tensach, sach.sotien from sach join bansach on sach.masach = bansach.masach";
            return ldc.loaddata(sql);
        }
        public object dall_tongsotientatcasach()
        {
            string sql = "select SUM(sotien) from sach";
            return ldc.tinhtien(sql);
        }
        public object dall_tongsotiensachchuaban()
        {
            string sql = "SELECT SUM(sach.sotien) FROM sach where sach.masach not in (select bansach.masach from bansach)";
            return ldc.tinhtien(sql);
        }
        public object dall_tongsotiensachban()
        {
            string sql = "SELECT SUM(sach.sotien) FROM sach where sach.masach in (select bansach.masach from bansach)";
            return ldc.tinhtien(sql);
        }
    }
}
