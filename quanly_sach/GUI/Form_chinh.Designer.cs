
namespace quanly_sach.GUI
{
    partial class Form_chinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_chinh));
            this.btn_nhapthongtinsach = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_nhaploaisach = new System.Windows.Forms.Button();
            this.btn_chobanthuesach = new System.Windows.Forms.Button();
            this.btn_quanlysach = new System.Windows.Forms.Button();
            this.btn_hienthongtin = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_nhapthongtinsach
            // 
            this.btn_nhapthongtinsach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nhapthongtinsach.Location = new System.Drawing.Point(24, 211);
            this.btn_nhapthongtinsach.Name = "btn_nhapthongtinsach";
            this.btn_nhapthongtinsach.Size = new System.Drawing.Size(248, 40);
            this.btn_nhapthongtinsach.TabIndex = 0;
            this.btn_nhapthongtinsach.Text = "Nhập thông tin sách";
            this.btn_nhapthongtinsach.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(345, 193);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btn_nhaploaisach
            // 
            this.btn_nhaploaisach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nhaploaisach.Location = new System.Drawing.Point(24, 257);
            this.btn_nhaploaisach.Name = "btn_nhaploaisach";
            this.btn_nhaploaisach.Size = new System.Drawing.Size(248, 40);
            this.btn_nhaploaisach.TabIndex = 3;
            this.btn_nhaploaisach.Text = "Nhập loại sách";
            this.btn_nhaploaisach.UseVisualStyleBackColor = true;
            // 
            // btn_chobanthuesach
            // 
            this.btn_chobanthuesach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chobanthuesach.Location = new System.Drawing.Point(24, 303);
            this.btn_chobanthuesach.Name = "btn_chobanthuesach";
            this.btn_chobanthuesach.Size = new System.Drawing.Size(248, 40);
            this.btn_chobanthuesach.TabIndex = 5;
            this.btn_chobanthuesach.Text = "Cho Bán hoặc Thuê sách";
            this.btn_chobanthuesach.UseVisualStyleBackColor = true;
            this.btn_chobanthuesach.Click += new System.EventHandler(this.btn_chobanthuesach_Click);
            // 
            // btn_quanlysach
            // 
            this.btn_quanlysach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quanlysach.Location = new System.Drawing.Point(24, 349);
            this.btn_quanlysach.Name = "btn_quanlysach";
            this.btn_quanlysach.Size = new System.Drawing.Size(248, 40);
            this.btn_quanlysach.TabIndex = 6;
            this.btn_quanlysach.Text = "Quản lý ngân sách";
            this.btn_quanlysach.UseVisualStyleBackColor = true;
            // 
            // btn_hienthongtin
            // 
            this.btn_hienthongtin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hienthongtin.Location = new System.Drawing.Point(24, 395);
            this.btn_hienthongtin.Name = "btn_hienthongtin";
            this.btn_hienthongtin.Size = new System.Drawing.Size(345, 40);
            this.btn_hienthongtin.TabIndex = 8;
            this.btn_hienthongtin.Text = "Hiện thông tin người bán";
            this.btn_hienthongtin.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(24, 441);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(345, 40);
            this.button1.TabIndex = 9;
            this.button1.Text = "Hiện thông tin người thuê";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form_chinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 555);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_hienthongtin);
            this.Controls.Add(this.btn_quanlysach);
            this.Controls.Add(this.btn_chobanthuesach);
            this.Controls.Add(this.btn_nhaploaisach);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_nhapthongtinsach);
            this.IsMdiContainer = true;
            this.Name = "Form_chinh";
            this.Text = "Form_chinh";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_nhapthongtinsach;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_nhaploaisach;
        private System.Windows.Forms.Button btn_chobanthuesach;
        private System.Windows.Forms.Button btn_quanlysach;
        private System.Windows.Forms.Button btn_hienthongtin;
        private System.Windows.Forms.Button button1;
    }
}