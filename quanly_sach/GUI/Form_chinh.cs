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
    public partial class Form_chinh : Form
    {
        public Form_chinh()
        {
            InitializeComponent();
        }

        private void btn_chobanthuesach_Click(object sender, EventArgs e)
        {
            if(Application.OpenForms["Form_tinhtien_thue_ban"] == null)
            {
                if(Application.OpenForms["Form_nhaploaisach"] != null)
                    Application.OpenForms["Form_nhaploaisach"].Close();
                if(Application.OpenForms["Form_nhapthongtinsach"] != null)
                    Application.OpenForms["Form_nhapthongtinsach"].Close();
                if(Application.OpenForms["Form_quanlyngansach"] != null)
                    Application.OpenForms["Form_quanlyngansach"].Close();

                GUI.Form_tinhtien_thue_ban a = new GUI.Form_tinhtien_thue_ban();
                a.MdiParent = this;
                a.Location = new Point(286,12);
                a.Show();

            }
        }
    }
}
