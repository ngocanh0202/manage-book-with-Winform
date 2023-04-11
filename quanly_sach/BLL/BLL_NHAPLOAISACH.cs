using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanly_sach.BLL
{
    class BLL_NHAPLOAISACH
    {
        DAL.DAL_LOAISACH dal_loaisach;
        GUI.Form_nhaploaisach frm;
        public BLL_NHAPLOAISACH(GUI.Form_nhaploaisach f)
        {
            dal_loaisach = new DAL.DAL_LOAISACH();
            frm = f;
        }
        public void bll_them()
        {
            dal_loaisach.dal_themloaisach(frm.Txt_maloaisach.Text, frm.Txt_tenloaisach.Text);
        }
        public void bll_loadloaisach()
        {
            frm.DataGridView1.DataSource = dal_loaisach.dal_loaddataloaisach();
        }
        public void bll_cellclick()
        {
            frm.Txt_maloaisach.Text =  frm.DataGridView1.CurrentRow.Cells["maloaisach"].Value.ToString();
            frm.Txt_tenloaisach.Text = frm.DataGridView1.CurrentRow.Cells["tenloaisach"].Value.ToString();
        }
        public void bll_xoa()
        {
            dal_loaisach.dal_xoaloaisach(frm.Txt_maloaisach.Text);
        }
    }
}
