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
    public partial class Form_nhapthongtinsach : Form
    {
        public Form_nhapthongtinsach()
        {
            InitializeComponent();
            bll_sach = new BLL.BLL_NHAPTHONGTINSACH(this);
        }
        BLL.BLL_NHAPTHONGTINSACH bll_sach;

        private void Form_nhapthongtinsach_Load(object sender, EventArgs e)
        {
            bll_sach.bll_loadcbloaisach();
            bll_sach.bll_loaddatasach();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            bll_sach.bll_them();
            bll_sach.bll_loaddatasach();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            bll_sach.bll_sua();
            bll_sach.bll_loaddatasach();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            bll_sach.bll_xoa();
            bll_sach.bll_loaddatasach();
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bll_sach.bll_cell_click();
        }

    }
}
