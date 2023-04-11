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
    public partial class Form_quanlyngansach : Form
    {
        public Form_quanlyngansach()
        {
            InitializeComponent();
            bll_qlngansach = new BLL.BLL_QUANLYNGANSACH(this);
        }
        BLL.BLL_QUANLYNGANSACH bll_qlngansach;
        private void Form_quanlyngansach_Load(object sender, EventArgs e)
        {
            bll_qlngansach.bll_sach();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem.ToString() == "SÁCH BÁN")
            {
                bll_qlngansach.bll_sachban();
            }
            else if(comboBox1.SelectedItem.ToString() == "SÁCH CHƯA BÁN"){
                bll_qlngansach.BLL_sachchuaban();
            }
            else if(comboBox1.SelectedItem.ToString() == "TẤT CẢ CÁC SÁCH")
            {
                bll_qlngansach.bll_sach();
            }
        }
    }
}
