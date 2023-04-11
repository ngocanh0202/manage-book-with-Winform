using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanly_sach.BLL
{
    class BLL_QUANLYNGANSACH
    {
        DAL.DAL_SACH dal_sach;
        GUI.Form_quanlyngansach frm;
        public BLL_QUANLYNGANSACH(GUI.Form_quanlyngansach f)
        {
            dal_sach = new DAL.DAL_SACH();
            frm = f;
        }
        public void BLL_sachchuaban()
        {
            frm.DataGridView1.DataSource = dal_sach.dal_sach_chuaban();
            frm.Txt_tongsotien.Text = dal_sach.dall_tongsotiensachchuaban().ToString();
        }
        public void bll_sachban()
        {
            frm.DataGridView1.DataSource = dal_sach.dall_sach_ban();
            frm.Txt_tongsotien.Text = dal_sach.dall_tongsotiensachban().ToString();
        }
        public void bll_sach()
        {
            frm.DataGridView1.DataSource = dal_sach.dal_loaddatasach_masach_tensach_sotien();
            frm.Txt_tongsotien.Text = dal_sach.dall_tongsotientatcasach().ToString();
        }
    }
}
