using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanly_sach.BLL
{
    class BLL_BANSACH_THUESACH
    {
        public DAL.DAL_BANSACH_THUESACH dal_bansach_thuesach;
        public GUI.Form_tinhtien_thue_ban ftinhtien;
        // Hàm khởi tạo
        public BLL_BANSACH_THUESACH(GUI.Form_tinhtien_thue_ban ftt)
        {
            dal_bansach_thuesach = new DAL.DAL_BANSACH_THUESACH();
            ftinhtien = ftt;
        }
        // Hàm bán sách
        public void bll_updatebs()
        {
            DataTable dtbs = dal_bansach_thuesach.dal_loaddatabansach();
            DataTable dtts = dal_bansach_thuesach.dal_loaddatathuesach();
            int dem = 0;
            for(int i = 0;i < dtbs.Rows.Count; i++)
            {
                if(dtbs.Rows[i]["masach"].ToString() == ftinhtien.Lb_masach.Text)
                {
                    MessageBox.Show("Sách đã được bán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dem = 1;
                    break;
                }
            }
            for (int i = 0; i < dtts.Rows.Count; i++)
            {
                if (dtts.Rows[i]["masach"].ToString() == ftinhtien.Lb_masach.Text)
                {
                    MessageBox.Show("Sách đã được thuê", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dem = 1;
                    break;
                }
            }
            if (dem == 0)
            {
                dal_bansach_thuesach.dal_updatadbbs(ftinhtien.Txt_tenkhachhang.Text, ftinhtien.Lb_masach.Text, ftinhtien.Lb_sotien.Text);
            }else if(dem == 1)
            {
                return;
            }
        }
        // Hàm thuê sách
        public void bll_thuesach()
        {
            DataTable dtbs = dal_bansach_thuesach.dal_loaddatabansach();
            DataTable dtts = dal_bansach_thuesach.dal_loaddatathuesach();
            int dem = 0;
            for (int i = 0; i < dtbs.Rows.Count; i++)
            {
                if (dtbs.Rows[i]["masach"].ToString() == ftinhtien.Lb_masach.Text)
                {
                    MessageBox.Show("Sách đã được bán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dem = 1;
                    break;
                }
            }
            for (int i = 0; i < dtts.Rows.Count; i++)
            {
                if (dtts.Rows[i]["masach"].ToString() == ftinhtien.Lb_masach.Text)
                {
                    MessageBox.Show("Sách đã được thuê", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dem = 1;
                    break;
                }
            }
            if(dem == 0)
            {
                GUI.Form_ngaythuetra fntt = new GUI.Form_ngaythuetra(this);
                fntt.Show();
            }
            else if(dem == 1)
            {
                return;
            }
        }
        // Show dữ liệu từ bảng sach vao datagridview
        public void bll_datagridview()
        {
            ftinhtien.DataGridView_formtinhtien.DataSource = dal_bansach_thuesach.dal_loaddatasach();
        }
        // show dữ liệu từ bảng loaisach vào combobox
        public void bll_comobox()
        {
            ftinhtien.Cb_loaisach.DataSource = dal_bansach_thuesach.dal_loadcbboxloaisach();
            ftinhtien.Cb_loaisach.DisplayMember = "tenloaisach";
            ftinhtien.Cb_loaisach.ValueMember = "maloaisach";
        }
        // làm chức năng nhấp chuột vào datagirdview
        int chon = 0;
        public void bll_cellclick()
        {
            ftinhtien.Lb_masach.Text = ftinhtien.DataGridView_formtinhtien.CurrentRow.Cells["masach"].Value.ToString();
            ftinhtien.Lb_tensach.Text = ftinhtien.DataGridView_formtinhtien.CurrentRow.Cells["tensach"].Value.ToString();
            ftinhtien.Lb_sotien.Text = ftinhtien.DataGridView_formtinhtien.CurrentRow.Cells["sotien"].Value.ToString();
            ftinhtien.Txt_mota.Text = ftinhtien.DataGridView_formtinhtien.CurrentRow.Cells["mota"].Value.ToString();
            chon = 1;
            ftinhtien.Cb_loaisach.SelectedValue = ftinhtien.DataGridView_formtinhtien.CurrentRow.Cells["maloaisach"].Value.ToString();
            chon = 0;
        }
        // làm chức năng tìm kiếm
        public void bll_loadatatimkiem()
        {
            ftinhtien.DataGridView_formtinhtien.DataSource = dal_bansach_thuesach.dal_timkiem(ftinhtien.Txt_timkiem.Text);
        }
        // show datagridview từ loại sách được chọn
        public void bll_loadataloaisach()
        {
            if(chon == 0)
                ftinhtien.DataGridView_formtinhtien.DataSource = dal_bansach_thuesach.dal_updatecbbox(ftinhtien.Cb_loaisach.SelectedValue.ToString());
        }
    }
}
