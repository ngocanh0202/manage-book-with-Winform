
using System.Windows.Forms;

namespace quanly_sach.GUI
{
    partial class Form_quanlyngansach
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_tongsotien = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(484, 297);
            this.dataGridView1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "SÁCH BÁN",
            "SÁCH CHƯA BÁN",
            "TẤT CẢ CÁC SÁCH"});
            this.comboBox1.Location = new System.Drawing.Point(282, 58);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(152, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "SÁCH CHƯA BÁN/ SÁCH ĐÃ BÁN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(620, 375);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "TỔNG SỐ TIỀN";
            // 
            // txt_tongsotien
            // 
            this.txt_tongsotien.Location = new System.Drawing.Point(541, 395);
            this.txt_tongsotien.Name = "txt_tongsotien";
            this.txt_tongsotien.Size = new System.Drawing.Size(247, 22);
            this.txt_tongsotien.TabIndex = 4;
            // 
            // Form_quanlyngansach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_tongsotien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form_quanlyngansach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form_quanlyngansach";
            this.Load += new System.EventHandler(this.Form_quanlyngansach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_tongsotien;

        public TextBox Txt_tongsotien { get => txt_tongsotien; set => txt_tongsotien = value; }
        public DataGridView DataGridView1 { get => dataGridView1; set => dataGridView1 = value; }
        public ComboBox ComboBox1 { get => comboBox1; set => comboBox1 = value; }
    }
}