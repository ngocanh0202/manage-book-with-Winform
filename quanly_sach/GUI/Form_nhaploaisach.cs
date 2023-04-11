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
    public partial class Form_nhaploaisach : Form
    {
        public Form_nhaploaisach()
        {
            InitializeComponent();
            bll_nhapsach = new BLL.BLL_NHAPLOAISACH(this);
        }
        BLL.BLL_NHAPLOAISACH bll_nhapsach;
        private void button1_Click(object sender, EventArgs e)
        {
            bll_nhapsach.bll_them();
            bll_nhapsach.bll_loadloaisach();
        }

        private void Form_nhaploaisach_Load(object sender, EventArgs e)
        {
            bll_nhapsach.bll_loadloaisach();
            bll_nhapsach.bll_loadloaisach();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bll_nhapsach.bll_cellclick();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            bll_nhapsach.bll_xoa();
            bll_nhapsach.bll_loadloaisach();
        }
    }
}
