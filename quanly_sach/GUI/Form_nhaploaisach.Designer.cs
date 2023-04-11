
using System.Windows.Forms;

namespace quanly_sach.GUI
{
    partial class Form_nhaploaisach
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
            this.txt_maloaisach = new System.Windows.Forms.TextBox();
            this.txt_tenloaisach = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_xoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã loại sách:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên loại sách:";
            // 
            // txt_maloaisach
            // 
            this.txt_maloaisach.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_maloaisach.Location = new System.Drawing.Point(207, 33);
            this.txt_maloaisach.Name = "txt_maloaisach";
            this.txt_maloaisach.Size = new System.Drawing.Size(203, 34);
            this.txt_maloaisach.TabIndex = 2;
            // 
            // txt_tenloaisach
            // 
            this.txt_tenloaisach.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenloaisach.Location = new System.Drawing.Point(207, 109);
            this.txt_tenloaisach.Name = "txt_tenloaisach";
            this.txt_tenloaisach.Size = new System.Drawing.Size(203, 34);
            this.txt_tenloaisach.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(136, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 48);
            this.button1.TabIndex = 4;
            this.button1.Text = "THÊM";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(453, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(335, 426);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Location = new System.Drawing.Point(335, 192);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(96, 41);
            this.btn_xoa.TabIndex = 6;
            this.btn_xoa.Text = "XÓA";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // Form_nhaploaisach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_tenloaisach);
            this.Controls.Add(this.txt_maloaisach);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_nhaploaisach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form_nhaploaisach";
            this.Load += new System.EventHandler(this.Form_nhaploaisach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_maloaisach;
        private System.Windows.Forms.TextBox txt_tenloaisach;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Button btn_xoa;

        public TextBox Txt_maloaisach { get => txt_maloaisach; set => txt_maloaisach = value; }
        public TextBox Txt_tenloaisach { get => txt_tenloaisach; set => txt_tenloaisach = value; }
        public DataGridView DataGridView1 { get => dataGridView1; set => dataGridView1 = value; }
    }
}