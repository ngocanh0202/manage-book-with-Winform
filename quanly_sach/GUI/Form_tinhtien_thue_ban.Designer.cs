
using System.Windows.Forms;

namespace quanly_sach.GUI
{
    partial class Form_tinhtien_thue_ban
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView_formtinhtien = new System.Windows.Forms.DataGridView();
            this.lb_lmasach = new System.Windows.Forms.Label();
            this.lb_ltensach = new System.Windows.Forms.Label();
            this.lb_masach = new System.Windows.Forms.Label();
            this.lb_tensach = new System.Windows.Forms.Label();
            this.lb_lmota = new System.Windows.Forms.Label();
            this.txt_mota = new System.Windows.Forms.TextBox();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.lb_loaisach = new System.Windows.Forms.Label();
            this.cb_loaisach = new System.Windows.Forms.ComboBox();
            this.btn_bansach = new System.Windows.Forms.Button();
            this.btn_thuesach = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_tenkhachhang = new System.Windows.Forms.TextBox();
            this.lb_lsotien = new System.Windows.Forms.Label();
            this.lb_sotien = new System.Windows.Forms.Label();
            this.btn_reset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_formtinhtien)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_formtinhtien
            // 
            this.dataGridView_formtinhtien.AllowUserToAddRows = false;
            this.dataGridView_formtinhtien.AllowUserToDeleteRows = false;
            this.dataGridView_formtinhtien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_formtinhtien.Location = new System.Drawing.Point(12, 297);
            this.dataGridView_formtinhtien.Name = "dataGridView_formtinhtien";
            this.dataGridView_formtinhtien.ReadOnly = true;
            this.dataGridView_formtinhtien.RowHeadersWidth = 51;
            this.dataGridView_formtinhtien.RowTemplate.Height = 24;
            this.dataGridView_formtinhtien.Size = new System.Drawing.Size(776, 141);
            this.dataGridView_formtinhtien.TabIndex = 0;
            this.dataGridView_formtinhtien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_formtinhtien_CellClick);
            // 
            // lb_lmasach
            // 
            this.lb_lmasach.AutoSize = true;
            this.lb_lmasach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_lmasach.Location = new System.Drawing.Point(39, 56);
            this.lb_lmasach.Name = "lb_lmasach";
            this.lb_lmasach.Size = new System.Drawing.Size(103, 25);
            this.lb_lmasach.TabIndex = 1;
            this.lb_lmasach.Text = "Mã sách : ";
            // 
            // lb_ltensach
            // 
            this.lb_ltensach.AutoSize = true;
            this.lb_ltensach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ltensach.Location = new System.Drawing.Point(39, 114);
            this.lb_ltensach.Name = "lb_ltensach";
            this.lb_ltensach.Size = new System.Drawing.Size(110, 25);
            this.lb_ltensach.TabIndex = 2;
            this.lb_ltensach.Text = "Tên sách : ";
            // 
            // lb_masach
            // 
            this.lb_masach.AutoSize = true;
            this.lb_masach.BackColor = System.Drawing.SystemColors.Control;
            this.lb_masach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_masach.Location = new System.Drawing.Point(148, 56);
            this.lb_masach.Name = "lb_masach";
            this.lb_masach.Size = new System.Drawing.Size(120, 25);
            this.lb_masach.TabIndex = 3;
            this.lb_masach.Text = "< mã sách >";
            // 
            // lb_tensach
            // 
            this.lb_tensach.AutoSize = true;
            this.lb_tensach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tensach.Location = new System.Drawing.Point(148, 114);
            this.lb_tensach.Name = "lb_tensach";
            this.lb_tensach.Size = new System.Drawing.Size(120, 25);
            this.lb_tensach.TabIndex = 4;
            this.lb_tensach.Text = "< tên sách >";
            // 
            // lb_lmota
            // 
            this.lb_lmota.AutoSize = true;
            this.lb_lmota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_lmota.Location = new System.Drawing.Point(39, 166);
            this.lb_lmota.Name = "lb_lmota";
            this.lb_lmota.Size = new System.Drawing.Size(77, 25);
            this.lb_lmota.TabIndex = 5;
            this.lb_lmota.Text = "Mô tả : ";
            // 
            // txt_mota
            // 
            this.txt_mota.Location = new System.Drawing.Point(122, 170);
            this.txt_mota.Multiline = true;
            this.txt_mota.Name = "txt_mota";
            this.txt_mota.Size = new System.Drawing.Size(414, 85);
            this.txt_mota.TabIndex = 6;
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Location = new System.Drawing.Point(566, 260);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(75, 31);
            this.btn_timkiem.TabIndex = 7;
            this.btn_timkiem.Text = "Tìm kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = true;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Location = new System.Drawing.Point(647, 264);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(141, 22);
            this.txt_timkiem.TabIndex = 8;
            // 
            // lb_loaisach
            // 
            this.lb_loaisach.AutoSize = true;
            this.lb_loaisach.Location = new System.Drawing.Point(563, 231);
            this.lb_loaisach.Name = "lb_loaisach";
            this.lb_loaisach.Size = new System.Drawing.Size(81, 17);
            this.lb_loaisach.TabIndex = 9;
            this.lb_loaisach.Text = "Loại sách : ";
            // 
            // cb_loaisach
            // 
            this.cb_loaisach.FormattingEnabled = true;
            this.cb_loaisach.Location = new System.Drawing.Point(650, 231);
            this.cb_loaisach.Name = "cb_loaisach";
            this.cb_loaisach.Size = new System.Drawing.Size(138, 24);
            this.cb_loaisach.TabIndex = 10;
            this.cb_loaisach.SelectedIndexChanged += new System.EventHandler(this.cb_loaisach_SelectedIndexChanged);
            // 
            // btn_bansach
            // 
            this.btn_bansach.Location = new System.Drawing.Point(692, 52);
            this.btn_bansach.Name = "btn_bansach";
            this.btn_bansach.Size = new System.Drawing.Size(96, 23);
            this.btn_bansach.TabIndex = 11;
            this.btn_bansach.Text = "Bán sách";
            this.btn_bansach.UseVisualStyleBackColor = true;
            this.btn_bansach.Click += new System.EventHandler(this.btn_bansach_Click);
            // 
            // btn_thuesach
            // 
            this.btn_thuesach.Location = new System.Drawing.Point(692, 114);
            this.btn_thuesach.Name = "btn_thuesach";
            this.btn_thuesach.Size = new System.Drawing.Size(96, 23);
            this.btn_thuesach.TabIndex = 12;
            this.btn_thuesach.Text = "Thuê sách";
            this.btn_thuesach.UseVisualStyleBackColor = true;
            this.btn_thuesach.Click += new System.EventHandler(this.btn_thuesach_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(309, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tên Khách Hàng :";
            // 
            // txt_tenkhachhang
            // 
            this.txt_tenkhachhang.Location = new System.Drawing.Point(480, 56);
            this.txt_tenkhachhang.Name = "txt_tenkhachhang";
            this.txt_tenkhachhang.Size = new System.Drawing.Size(129, 22);
            this.txt_tenkhachhang.TabIndex = 14;
            // 
            // lb_lsotien
            // 
            this.lb_lsotien.AutoSize = true;
            this.lb_lsotien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_lsotien.Location = new System.Drawing.Point(32, 264);
            this.lb_lsotien.Name = "lb_lsotien";
            this.lb_lsotien.Size = new System.Drawing.Size(84, 25);
            this.lb_lsotien.TabIndex = 15;
            this.lb_lsotien.Text = "Số tiền :";
            // 
            // lb_sotien
            // 
            this.lb_sotien.AutoSize = true;
            this.lb_sotien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sotien.Location = new System.Drawing.Point(117, 264);
            this.lb_sotien.Name = "lb_sotien";
            this.lb_sotien.Size = new System.Drawing.Size(112, 25);
            this.lb_sotien.TabIndex = 16;
            this.lb_sotien.Text = " < Số tiền >";
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(713, 202);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 17;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // Form_tinhtien_thue_ban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.lb_sotien);
            this.Controls.Add(this.lb_lsotien);
            this.Controls.Add(this.txt_tenkhachhang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_thuesach);
            this.Controls.Add(this.btn_bansach);
            this.Controls.Add(this.cb_loaisach);
            this.Controls.Add(this.lb_loaisach);
            this.Controls.Add(this.txt_timkiem);
            this.Controls.Add(this.btn_timkiem);
            this.Controls.Add(this.txt_mota);
            this.Controls.Add(this.lb_lmota);
            this.Controls.Add(this.lb_tensach);
            this.Controls.Add(this.lb_masach);
            this.Controls.Add(this.lb_ltensach);
            this.Controls.Add(this.lb_lmasach);
            this.Controls.Add(this.dataGridView_formtinhtien);
            this.Name = "Form_tinhtien_thue_ban";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form_tinhtien";
            this.Load += new System.EventHandler(this.Form_tinhtien_thue_ban_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_formtinhtien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_formtinhtien;
        private System.Windows.Forms.Label lb_lmasach;
        private System.Windows.Forms.Label lb_ltensach;
        private System.Windows.Forms.Label lb_masach;
        private System.Windows.Forms.Label lb_tensach;
        private System.Windows.Forms.Label lb_lmota;
        private System.Windows.Forms.TextBox txt_mota;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.Label lb_loaisach;
        private System.Windows.Forms.ComboBox cb_loaisach;
        private System.Windows.Forms.Button btn_bansach;
        private System.Windows.Forms.Button btn_thuesach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_tenkhachhang;
        private System.Windows.Forms.Label lb_lsotien;
        private System.Windows.Forms.Label lb_sotien;
        private Button btn_reset;

        public Label Lb_sotien { get => lb_sotien; set => lb_sotien = value; }
        public Label Lb_tensach { get => lb_tensach; set => lb_tensach = value; }
        public TextBox Txt_makhachhang { get => txt_tenkhachhang; set => txt_tenkhachhang = value; }
        public Label Lb_masach { get => lb_masach; set => lb_masach = value; }
        public DataGridView DataGridView_formtinhtien { get => dataGridView_formtinhtien; set => dataGridView_formtinhtien = value; }
        public TextBox Txt_mota { get => txt_mota; set => txt_mota = value; }
        public ComboBox Cb_loaisach { get => cb_loaisach; set => cb_loaisach = value; }
        public TextBox Txt_tenkhachhang { get => txt_tenkhachhang; set => txt_tenkhachhang = value; }
        public TextBox Txt_timkiem { get => txt_timkiem; set => txt_timkiem = value; }
    }
}