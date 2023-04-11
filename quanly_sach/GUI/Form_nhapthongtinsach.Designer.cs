
using System.Windows.Forms;

namespace quanly_sach.GUI
{
    partial class Form_nhapthongtinsach
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_loaisach = new System.Windows.Forms.ComboBox();
            this.txt_masach = new System.Windows.Forms.TextBox();
            this.txt_tensach = new System.Windows.Forms.TextBox();
            this.txt_sotien = new System.Windows.Forms.TextBox();
            this.txt_mota = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "MÃ SÁCH:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "TÊN SÁCH:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "MÔ TẢ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(319, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "SỐ TIỀN:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(319, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "LOẠI SÁCH:";
            // 
            // cb_loaisach
            // 
            this.cb_loaisach.FormattingEnabled = true;
            this.cb_loaisach.Location = new System.Drawing.Point(446, 49);
            this.cb_loaisach.Name = "cb_loaisach";
            this.cb_loaisach.Size = new System.Drawing.Size(121, 24);
            this.cb_loaisach.TabIndex = 5;
            // 
            // txt_masach
            // 
            this.txt_masach.Location = new System.Drawing.Point(167, 51);
            this.txt_masach.Name = "txt_masach";
            this.txt_masach.Size = new System.Drawing.Size(123, 22);
            this.txt_masach.TabIndex = 6;
            // 
            // txt_tensach
            // 
            this.txt_tensach.Location = new System.Drawing.Point(167, 90);
            this.txt_tensach.Name = "txt_tensach";
            this.txt_tensach.Size = new System.Drawing.Size(123, 22);
            this.txt_tensach.TabIndex = 7;
            // 
            // txt_sotien
            // 
            this.txt_sotien.Location = new System.Drawing.Point(446, 87);
            this.txt_sotien.Name = "txt_sotien";
            this.txt_sotien.Size = new System.Drawing.Size(121, 22);
            this.txt_sotien.TabIndex = 8;
            // 
            // txt_mota
            // 
            this.txt_mota.Location = new System.Drawing.Point(167, 132);
            this.txt_mota.Multiline = true;
            this.txt_mota.Name = "txt_mota";
            this.txt_mota.Size = new System.Drawing.Size(236, 79);
            this.txt_mota.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 230);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(646, 208);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(476, 174);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 23);
            this.btn_them.TabIndex = 11;
            this.btn_them.Text = "THÊM ";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(583, 174);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 23);
            this.btn_sua.TabIndex = 12;
            this.btn_sua.Text = "SỬA";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(700, 174);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_xoa.TabIndex = 13;
            this.btn_xoa.Text = "XÓA";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // Form_nhapthongtinsach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_mota);
            this.Controls.Add(this.txt_sotien);
            this.Controls.Add(this.txt_tensach);
            this.Controls.Add(this.txt_masach);
            this.Controls.Add(this.cb_loaisach);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_nhapthongtinsach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form_nhapthongtinsach";
            this.Load += new System.EventHandler(this.Form_nhapthongtinsach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_loaisach;
        private System.Windows.Forms.TextBox txt_masach;
        private System.Windows.Forms.TextBox txt_tensach;
        private System.Windows.Forms.TextBox txt_sotien;
        private System.Windows.Forms.TextBox txt_mota;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;

        public ComboBox Cb_loaisach { get => cb_loaisach; set => cb_loaisach = value; }
        public TextBox Txt_masach { get => txt_masach; set => txt_masach = value; }
        public TextBox Txt_tensach { get => txt_tensach; set => txt_tensach = value; }
        public TextBox Txt_sotien { get => txt_sotien; set => txt_sotien = value; }
        public TextBox Txt_mota { get => txt_mota; set => txt_mota = value; }
        public DataGridView DataGridView1 { get => dataGridView1; set => dataGridView1 = value; }
    }
}