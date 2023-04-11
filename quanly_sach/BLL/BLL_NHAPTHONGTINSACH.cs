using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanly_sach.BLL
{
    class BLL_NHAPTHONGTINSACH
    {
        DAL.DAL_SACH dal_sach;
        DAL.DAL_LOAISACH dal_loaisach;
        GUI.Form_nhapthongtinsach frm;
        public BLL_NHAPTHONGTINSACH(GUI.Form_nhapthongtinsach f)
        {
            dal_sach = new DAL.DAL_SACH();
            dal_loaisach = new DAL.DAL_LOAISACH();
            frm = f;
        }
        public void bll_loaddatasach()
        {
            frm.DataGridView1.DataSource = dal_sach.dal_loaddatasach();
        }
        public void bll_loadcbloaisach()
        {
            frm.Cb_loaisach.DataSource = dal_loaisach.dal_loaddataloaisach();
            frm.Cb_loaisach.DisplayMember = "tenloaisach";
            frm.Cb_loaisach.ValueMember = "maloaisach";
        }
        public void bll_them()
        {
            dal_sach.dal_them_sach(frm.Txt_masach.Text,frm.Txt_tensach.Text,frm.Txt_mota.Text,frm.Cb_loaisach.SelectedValue.ToString(), frm.Txt_sotien.Text);
        }
        public void bll_xoa()
        {
            dal_sach.dal_xoa_sach(frm.Txt_masach.Text);
        }
        public void bll_sua()
        {
            dal_sach.dal_sua_sach(frm.Txt_masach.Text, frm.Txt_tensach.Text, frm.Txt_mota.Text, frm.Cb_loaisach.SelectedValue.ToString(), frm.Txt_sotien.Text);
        }
        public void bll_timkiem()
        {
            frm.DataGridView1.DataSource = dal_sach.dal_timkiem(frm.Txt_tensach.Text);
        }
        public void bll_cell_click()
        {
            frm.Txt_masach.Text = frm.DataGridView1.CurrentRow.Cells["masach"].Value.ToString();
            frm.Txt_tensach.Text = frm.DataGridView1.CurrentRow.Cells["tensach"].Value.ToString();
            frm.Txt_mota.Text = frm.DataGridView1.CurrentRow.Cells["mota"].Value.ToString();
            frm.Txt_sotien.Text = frm.DataGridView1.CurrentRow.Cells["sotien"].Value.ToString();
            frm.Cb_loaisach.SelectedValue = frm.DataGridView1.CurrentRow.Cells["maloaisach"].Value.ToString();
        }
    }
}
