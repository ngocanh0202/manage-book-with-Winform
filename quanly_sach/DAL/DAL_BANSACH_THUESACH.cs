﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanly_sach.DAL
{
    class DAL_BANSACH_THUESACH
    {
        lopdungchung ldc;
        public DAL_BANSACH_THUESACH()
        {
            ldc = new lopdungchung();
        }
        
        // Lấy dữ liệu từ bảng bansach
        public DataTable dal_loaddatabansach()
        {
            string sql = "select * from bansach";
            return ldc.loaddata(sql);
        }
        // Lấy dữ liệu từ bảng thuesach
        public DataTable dal_loaddatathuesach()
        {
            string sql = "select * from thuesach";
            return ldc.loaddata(sql);
        }
        // cập nhập bảng bansach
        public void dal_updatadbbs(string tenkhachhang, string masach, string sotien)
        {
            string sql = "insert into bansach values(N'"+tenkhachhang+"', '"+masach+"', '"+sotien+"')";
            ldc.nonquery(sql);
        }
        // cập nhập bảng thuesach
        public void dal_thuesach(string tenkhachhang, string masach, DateTime ngaymuon, DateTime ngaytra, string tinhtrang)
        {
            string sql = "insert into thuesach values(N'"+tenkhachhang+"', '"+masach+"', '"+ngaymuon+"', '"+ngaytra+"',N'"+tinhtrang+"')";
            ldc.nonquery(sql);
        }
        
        
    }
}
