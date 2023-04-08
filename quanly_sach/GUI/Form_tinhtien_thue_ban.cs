using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanly_sach.GUI
{
    public partial class Form_tinhtien_thue_ban : Form
    {
        BLL.BLL_BANSACH_THUESACH bll_bansach;
        public Form_tinhtien_thue_ban()
        {
            InitializeComponent();
            bll_bansach = new BLL.BLL_BANSACH_THUESACH(this);
        }
        // nút bán sách
        private void btn_bansach_Click(object sender, EventArgs e)
        {
            bll_bansach.bll_updatebs();
        }
        // nút thuê sách
        private void btn_thuesach_Click(object sender, EventArgs e)
        {
            bll_bansach.bll_thuesach();
        }
        // show dữ liệu
        private void Form_tinhtien_thue_ban_Load(object sender, EventArgs e)
        {    
            bll_bansach.bll_comobox();
            bll_bansach.bll_datagridview();
        }
        // click dữ liệu 
        private void dataGridView_formtinhtien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bll_bansach.bll_cellclick();
        }
        // nút tìm kiếm
        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            bll_bansach.bll_loadatatimkiem();
        }
        // reset lại bảng datagridview
        private void btn_reset_Click(object sender, EventArgs e)
        {
            bll_bansach.bll_datagridview();
        }
        // chọn loại sách cho datagridview
        private void cb_loaisach_SelectedIndexChanged(object sender, EventArgs e)
        {
            bll_bansach.bll_loadataloaisach();
        }
    }
}
