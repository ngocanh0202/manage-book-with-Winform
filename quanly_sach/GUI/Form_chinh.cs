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
                if(Application.OpenForms["Form_nhapthongtinsach"] != null)
                    Application.OpenForms["Form_nhapthongtinsach"].Close();
                if(Application.OpenForms["Form_hienthongtinnguoiban"] != null)
                    Application.OpenForms["Form_hienthongtinnguoiban"].Close();
                if(Application.OpenForms["Form_hienthongtinnguoithue"] != null)
                    Application.OpenForms["Form_hienthongtinnguoithue"].Close();
                if(Application.OpenForms["Form_nhaploaisach"] !=null)
                    Application.OpenForms["Form_nhaploaisach"].Close();
                if(Application.OpenForms["Form_quanlyngansach"] != null)
                    Application.OpenForms["Form_quanlyngansach"].Close();
                GUI.Form_tinhtien_thue_ban a = new GUI.Form_tinhtien_thue_ban();
                a.MdiParent = this;
                a.Location = new Point(286,12);
                a.Show();
            }
        }

        private void btn_nhapthongtinsach_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Form_nhapthongtinsach"] == null)
            {
                if(Application.OpenForms["Form_tinhtien_thue_ban"] != null)
                    Application.OpenForms["Form_tinhtien_thue_ban"].Close();
                if (Application.OpenForms["Form_hienthongtinnguoiban"] != null)
                    Application.OpenForms["Form_hienthongtinnguoiban"].Close();
                if(Application.OpenForms["Form_hienthongtinnguoithue"] != null)
                    Application.OpenForms["Form_hienthongtinnguoithue"].Close();
                if (Application.OpenForms["Form_nhaploaisach"] != null)
                    Application.OpenForms["Form_nhaploaisach"].Close();
                if (Application.OpenForms["Form_quanlyngansach"] != null)
                    Application.OpenForms["Form_quanlyngansach"].Close();
                GUI.Form_nhapthongtinsach a = new GUI.Form_nhapthongtinsach();
                a.MdiParent = this;
                a.Location = new Point(286, 12);
                a.Show();
            }
        }

        private void btn_hienthongtin_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Form_hienthongtinnguoiban"] == null)
            {
                if(Application.OpenForms["Form_tinhtien_thue_ban"] !=null)
                Application.OpenForms["Form_tinhtien_thue_ban"].Close();
                if(Application.OpenForms["Form_nhapthongtinsach"]!= null)
                Application.OpenForms["Form_nhapthongtinsach"].Close();
                if(Application.OpenForms["Form_hienthongtinnguoithue"] != null)
                Application.OpenForms["Form_hienthongtinnguoithue"].Close();
                if(Application.OpenForms["Form_nhaploaisach"] !=null)
                Application.OpenForms["Form_nhaploaisach"].Close();
                if(Application.OpenForms["Form_nhaploaisach"] !=null)
                Application.OpenForms["Form_nhaploaisach"].Close();
                GUI.Form_hienthongtinnguoiban a = new GUI.Form_hienthongtinnguoiban();
                a.MdiParent = this;
                a.Location = new Point(286, 12);
                a.Show();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Form_hienthongtinnguoithue"] == null)
            {
                if(Application.OpenForms["Form_tinhtien_thue_ban"]!= null)
                Application.OpenForms["Form_tinhtien_thue_ban"].Close();
                if(Application.OpenForms["Form_nhapthongtinsach"]!= null)
                Application.OpenForms["Form_nhapthongtinsach"].Close();
                if(Application.OpenForms["Form_hienthongtinnguoiban"] != null)
                Application.OpenForms["Form_hienthongtinnguoiban"].Close();
                if (Application.OpenForms["Form_nhaploaisach"] != null)
                Application.OpenForms["Form_nhaploaisach"].Close();
                if (Application.OpenForms["Form_quanlyngansach"] !=null)
                Application.OpenForms["Form_quanlyngansach"].Close();
                GUI.Form_hienthongtinnguoithue a = new GUI.Form_hienthongtinnguoithue();
                a.MdiParent = this;
                a.Location = new Point(286, 12);
                a.Show();

            }
        }

        private void btn_nhaploaisach_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Form_nhaploaisach"] == null)
            {
                if(Application.OpenForms["Form_tinhtien_thue_ban"]!=null)
                Application.OpenForms["Form_tinhtien_thue_ban"].Close();
                if (Application.OpenForms["Form_nhapthongtinsach"]!=null)
                Application.OpenForms["Form_nhapthongtinsach"].Close();
                if(Application.OpenForms["Form_hienthongtinnguoiban"]!=null)
                Application.OpenForms["Form_hienthongtinnguoiban"].Close();
                if(Application.OpenForms["Form_hienthongtinnguoithue"]!=null)
                Application.OpenForms["Form_hienthongtinnguoithue"].Close();
                if(Application.OpenForms["Form_quanlyngansach"]!=null)
                Application.OpenForms["Form_quanlyngansach"].Close();
                GUI.Form_nhaploaisach a = new GUI.Form_nhaploaisach();
                a.MdiParent = this;
                a.Location = new Point(286, 12);
                a.Show();

            }
        }

        private void btn_quanlysach_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Form_quanlyngansach"] == null)
            {
                if(Application.OpenForms["Form_tinhtien_thue_ban"]!=null)
                Application.OpenForms["Form_tinhtien_thue_ban"].Close();
                if(Application.OpenForms["Form_nhapthongtinsach"]!=null)
                Application.OpenForms["Form_nhapthongtinsach"].Close();
                if(Application.OpenForms["Form_hienthongtinnguoiban"]!=null)
                Application.OpenForms["Form_hienthongtinnguoiban"].Close();
                if(Application.OpenForms["Form_hienthongtinnguoithue"]!=null)
                Application.OpenForms["Form_hienthongtinnguoithue"].Close();
                if(Application.OpenForms["Form_nhaploaisach"]!=null)
                Application.OpenForms["Form_nhaploaisach"].Close();
                GUI.Form_quanlyngansach a = new GUI.Form_quanlyngansach();
                a.MdiParent = this;
                a.Location = new Point(286, 12);
                a.Show();

            }
        }
    }
}
