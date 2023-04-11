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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            bll_login = new BLL.BLL_LOGIN(this);
        }
        BLL.BLL_LOGIN bll_login;

        private void button1_Click(object sender, EventArgs e)
        {
            bll_login.dangnhap();
        }
    }
}
