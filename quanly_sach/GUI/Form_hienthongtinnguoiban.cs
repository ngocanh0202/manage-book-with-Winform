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
    public partial class Form_hienthongtinnguoiban : Form
    {
        BLL.BLL_NGUOIMUA bll_nguoimua;
        public Form_hienthongtinnguoiban()
        {
            InitializeComponent();
            bll_nguoimua = new BLL.BLL_NGUOIMUA(this);
        }

        private void Form_hienthongtinnguoiban_Load(object sender, EventArgs e)
        {
            bll_nguoimua.BLL_data();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bll_nguoimua.BLL_xoa();
            bll_nguoimua.BLL_data();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bll_nguoimua.BLL_cellclick();
        }
    }
}
