namespace FormQLSachh
{
    partial class QuanLySach
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
            this.txtDangNhap = new System.Windows.Forms.LinkLabel();
            this.txtQuenmatkhau = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtTaikhoan = new System.Windows.Forms.TextBox();
            this.txtMatkhau = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDangNhap
            // 
            this.txtDangNhap.AutoSize = true;
            this.txtDangNhap.Location = new System.Drawing.Point(148, 451);
            this.txtDangNhap.Name = "txtDangNhap";
            this.txtDangNhap.Size = new System.Drawing.Size(72, 16);
            this.txtDangNhap.TabIndex = 0;
            this.txtDangNhap.TabStop = true;
            this.txtDangNhap.Text = "Đăng nhập";
            // 
            // txtQuenmatkhau
            // 
            this.txtQuenmatkhau.AutoSize = true;
            this.txtQuenmatkhau.Location = new System.Drawing.Point(412, 451);
            this.txtQuenmatkhau.Name = "txtQuenmatkhau";
            this.txtQuenmatkhau.Size = new System.Drawing.Size(96, 16);
            this.txtQuenmatkhau.TabIndex = 1;
            this.txtQuenmatkhau.TabStop = true;
            this.txtQuenmatkhau.Text = "Quên mật khẩu";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FormQLSachh.Properties.Resources.illustration_of_human_icon_user_symbol_icon_modern_design_on_blank_background_free_vector;
            this.pictureBox1.Location = new System.Drawing.Point(167, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(352, 205);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtTaikhoan
            // 
            this.txtTaikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaikhoan.Location = new System.Drawing.Point(151, 261);
            this.txtTaikhoan.Multiline = true;
            this.txtTaikhoan.Name = "txtTaikhoan";
            this.txtTaikhoan.Size = new System.Drawing.Size(117, 40);
            this.txtTaikhoan.TabIndex = 3;
            this.txtTaikhoan.Text = "Tài  khoản";
            this.txtTaikhoan.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtMatkhau
            // 
            this.txtMatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatkhau.Location = new System.Drawing.Point(151, 352);
            this.txtMatkhau.Multiline = true;
            this.txtMatkhau.Name = "txtMatkhau";
            this.txtMatkhau.Size = new System.Drawing.Size(117, 40);
            this.txtMatkhau.TabIndex = 4;
            this.txtMatkhau.Text = "Mật khẩu";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(316, 261);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(164, 40);
            this.textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(316, 352);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(164, 40);
            this.textBox4.TabIndex = 6;
            // 
            // QuanLySach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 539);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txtMatkhau);
            this.Controls.Add(this.txtTaikhoan);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtQuenmatkhau);
            this.Controls.Add(this.txtDangNhap);
            this.Name = "QuanLySach";
            this.Text = "Đăng Nhập";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel txtDangNhap;
        private System.Windows.Forms.LinkLabel txtQuenmatkhau;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtTaikhoan;
        private System.Windows.Forms.TextBox txtMatkhau;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
    }
}

