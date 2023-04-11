using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanly_sach.BLL
{
    class BLL_NGUOIMUA
    {
        GUI.Form_hienthongtinnguoiban form_nguoimua;
        DAL.DAL_BANSACH dal_ban;
        public BLL_NGUOIMUA(GUI.Form_hienthongtinnguoiban f)
        {
            dal_ban = new DAL.DAL_BANSACH();
            form_nguoimua = f;
        }
        public void BLL_data()
        {
            form_nguoimua.DataGridView1.DataSource = dal_ban.dal_loaddatabansach();
        }
        public void BLL_xoa()
        {
            dal_ban.DAL_xoabansach_masach(form_nguoimua.Txt_masach.Text);
        }
        public void BLL_cellclick()
        {
            form_nguoimua.Txt_masach.Text = form_nguoimua.DataGridView1.CurrentRow.Cells["masach"].Value.ToString();
            form_nguoimua.Txt_tenkhachhang.Text = form_nguoimua.DataGridView1.CurrentRow.Cells["tenkhachhang"].Value.ToString(); 
        }
    }
}
