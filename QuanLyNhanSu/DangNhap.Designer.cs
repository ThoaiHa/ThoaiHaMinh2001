namespace QuanLyNhanSu
{
    partial class DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbTaiKhoan = new System.Windows.Forms.TextBox();
            this.txbMatKhau = new System.Windows.Forms.TextBox();
            this.btdangnhap = new System.Windows.Forms.Button();
            this.btthoát = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài khoản:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu:";
            // 
            // txbTaiKhoan
            // 
            this.txbTaiKhoan.Location = new System.Drawing.Point(155, 53);
            this.txbTaiKhoan.Name = "txbTaiKhoan";
            this.txbTaiKhoan.Size = new System.Drawing.Size(186, 22);
            this.txbTaiKhoan.TabIndex = 2;
            // 
            // txbMatKhau
            // 
            this.txbMatKhau.Location = new System.Drawing.Point(155, 105);
            this.txbMatKhau.Name = "txbMatKhau";
            this.txbMatKhau.PasswordChar = '*';
            this.txbMatKhau.Size = new System.Drawing.Size(186, 22);
            this.txbMatKhau.TabIndex = 3;
            this.txbMatKhau.UseSystemPasswordChar = true;
            // 
            // btdangnhap
            // 
            this.btdangnhap.Location = new System.Drawing.Point(140, 178);
            this.btdangnhap.Name = "btdangnhap";
            this.btdangnhap.Size = new System.Drawing.Size(90, 31);
            this.btdangnhap.TabIndex = 4;
            this.btdangnhap.Text = "Đăng nhập";
            this.btdangnhap.UseVisualStyleBackColor = true;
            this.btdangnhap.Click += new System.EventHandler(this.btdangnhap_Click);
            // 
            // btthoát
            // 
            this.btthoát.Location = new System.Drawing.Point(251, 178);
            this.btthoát.Name = "btthoát";
            this.btthoát.Size = new System.Drawing.Size(90, 31);
            this.btthoát.TabIndex = 5;
            this.btthoát.Text = "Thoát";
            this.btthoát.UseVisualStyleBackColor = true;
            this.btthoát.Click += new System.EventHandler(this.btthoát_Click);
            // 
            // DangNhap
            // 
            this.AcceptButton = this.btdangnhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(605, 251);
            this.Controls.Add(this.btthoát);
            this.Controls.Add(this.btdangnhap);
            this.Controls.Add(this.txbMatKhau);
            this.Controls.Add(this.txbTaiKhoan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DangNhap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbTaiKhoan;
        private System.Windows.Forms.TextBox txbMatKhau;
        private System.Windows.Forms.Button btdangnhap;
        private System.Windows.Forms.Button btthoát;
    }
}