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
    public partial class Form_ngaythuetra : Form
    {
        BLL.BLL_BANSACH_THUESACH bll;
        public Form_ngaythuetra(object b)
        {
            InitializeComponent();
            bll = (BLL.BLL_BANSACH_THUESACH)b;
        }
        int check = 0;
        private void dtp_ngaytra_ValueChanged(object sender, EventArgs e)
        {
            if (dtp_ngaytra.Value.Year == dtp_ngaythue.Value.Year && dtp_ngaytra.Value.Month == dtp_ngaythue.Value.Month && dtp_ngaytra.Value.Day < dtp_ngaythue.Value.Day)
            {
                MessageBox.Show("Lấy ngày trả sai", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                check = 1;
                return;
            }
            else if (dtp_ngaytra.Value.Year < dtp_ngaythue.Value.Year)
            {
                MessageBox.Show("Lấy năm trả sai", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                check = 1;
                return;
            }
            else if(dtp_ngaytra.Value.Year == dtp_ngaythue.Value.Year && dtp_ngaytra.Value.Month < dtp_ngaythue.Value.Month)
            {
                MessageBox.Show("Lấy tháng trả sai", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                check = 1;
                return;
            }
            check = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.OpenForms["Form_ngaythuetra"].Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(check == 0)
            {
                bll.dal_bansach_thuesach.dal_thuesach(bll.ftinhtien.Txt_tenkhachhang.Text, bll.ftinhtien.Lb_masach.Text, dtp_ngaythue.Value, dtp_ngaytra.Value, "còn hạn");
                Application.OpenForms["Form_ngaythuetra"].Close();
            }
            else  if(check == 1)
            {
                MessageBox.Show("Chọn lại năm tháng ngày trả đúng", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
