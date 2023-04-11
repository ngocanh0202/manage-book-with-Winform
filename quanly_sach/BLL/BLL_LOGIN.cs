using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanly_sach.BLL
{
    class BLL_LOGIN
    {
        DAL.DAL_LOGIN dal_login;
        GUI.login lg;
        public BLL_LOGIN(GUI.login lgg)
        {
            dal_login = new DAL.DAL_LOGIN();
            lg = lgg;
        }
        public void dangnhap()
        {
            if(dal_login.dal_dangnhap(lg.Txt_tendangnhap.Text, lg.Txt_matkhau.Text) >= 1)
            {
                GUI.Form_chinh frm = new GUI.Form_chinh();
                frm.Show();
                lg.Opacity = 0;
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
