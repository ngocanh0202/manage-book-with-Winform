
using System.Windows.Forms;

namespace quanly_sach.GUI
{
    partial class Form_hienthongtinnguoiban
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_masach = new System.Windows.Forms.TextBox();
            this.txt_tenkhachhang = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(43, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(725, 312);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 359);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 402);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên khách hàng";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(375, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 27);
            this.button1.TabIndex = 3;
            this.button1.Text = "XÓA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_masach
            // 
            this.txt_masach.Location = new System.Drawing.Point(180, 356);
            this.txt_masach.Name = "txt_masach";
            this.txt_masach.Size = new System.Drawing.Size(162, 22);
            this.txt_masach.TabIndex = 4;
            // 
            // txt_tenkhachhang
            // 
            this.txt_tenkhachhang.Location = new System.Drawing.Point(180, 402);
            this.txt_tenkhachhang.Name = "txt_tenkhachhang";
            this.txt_tenkhachhang.Size = new System.Drawing.Size(162, 22);
            this.txt_tenkhachhang.TabIndex = 5;
            // 
            // Form_hienthongtinnguoiban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_tenkhachhang);
            this.Controls.Add(this.txt_masach);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form_hienthongtinnguoiban";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form_hienthongtinnguoiban";
            this.Load += new System.EventHandler(this.Form_hienthongtinnguoiban_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Button button1;
        private TextBox txt_masach;
        private TextBox txt_tenkhachhang;

        public DataGridView DataGridView1 { get => dataGridView1; set => dataGridView1 = value; }
        public TextBox Txt_masach { get => txt_masach; set => txt_masach = value; }
        public TextBox Txt_tenkhachhang { get => txt_tenkhachhang; set => txt_tenkhachhang = value; }
    }
}