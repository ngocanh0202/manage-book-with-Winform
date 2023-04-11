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
    public partial class Form_hienthongtinnguoithue : Form
    {
        BLL.BLL_NGUOITHUE bll;
        public Form_hienthongtinnguoithue()
        {
            InitializeComponent();
            bll = new BLL.BLL_NGUOITHUE(this);
        }

        private void Form_hienthongtinnguoithue_Load(object sender, EventArgs e)
        {
            bll.BLL_data();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bll.BLL_xoa();
            bll.BLL_data();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bll.BLL_cellclick();
        }
    }
}
