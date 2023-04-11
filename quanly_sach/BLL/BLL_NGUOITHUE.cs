using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanly_sach.BLL
{
    class BLL_NGUOITHUE
    {
        DAL.DAL_THUESACH dal_thuesach;
        GUI.Form_hienthongtinnguoithue form_nguoithue;
        public BLL_NGUOITHUE(GUI.Form_hienthongtinnguoithue frm)
        {
            dal_thuesach = new DAL.DAL_THUESACH();
            form_nguoithue = frm;
        }
        public void BLL_data()
        {
            form_nguoithue.DataGridView1.DataSource = dal_thuesach.dal_loaddatathuesach();
        }
        public void BLL_xoa()
        {
            dal_thuesach.DAL_thuesach_masach(form_nguoithue.Txt_masach.Text);
        }
        public void BLL_cellclick()
        {
            form_nguoithue.Txt_masach.Text = form_nguoithue.DataGridView1.CurrentRow.Cells["masach"].Value.ToString();
            form_nguoithue.Txt_tenkhachhang.Text = form_nguoithue.DataGridView1.CurrentRow.Cells["tenkhachhang"].Value.ToString();
        }
    }
}
