
namespace QuanLyNhanSu
{
    partial class quanlytaikhoan
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
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.btn_sua = new FontAwesome.Sharp.IconButton();
            this.btn_xoa = new FontAwesome.Sharp.IconButton();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvUser = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.cbLoaiTK = new System.Windows.Forms.ComboBox();
            this.txtTenHienThi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUser)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.btnAdd.IconColor = System.Drawing.Color.Lime;
            this.btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdd.IconSize = 30;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(576, 316);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(140, 43);
            this.btnAdd.TabIndex = 185;
            this.btnAdd.Text = "     Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.IconChar = FontAwesome.Sharp.IconChar.Hammer;
            this.btn_sua.IconColor = System.Drawing.Color.Black;
            this.btn_sua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_sua.IconSize = 30;
            this.btn_sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sua.Location = new System.Drawing.Point(722, 316);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(140, 43);
            this.btn_sua.TabIndex = 184;
            this.btn_sua.Text = "      Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btn_xoa.IconColor = System.Drawing.Color.Red;
            this.btn_xoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_xoa.IconSize = 30;
            this.btn_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xoa.Location = new System.Drawing.Point(868, 316);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(140, 43);
            this.btn_xoa.TabIndex = 183;
            this.btn_xoa.Text = "      Xoá";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // txtPassWord
            // 
            this.txtPassWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassWord.Location = new System.Drawing.Point(773, 137);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.Size = new System.Drawing.Size(160, 24);
            this.txtPassWord.TabIndex = 189;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(635, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 18);
            this.label9.TabIndex = 188;
            this.label9.Text = "Mật khẩu:";
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(773, 94);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(160, 24);
            this.txtUserName.TabIndex = 187;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(635, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 18);
            this.label2.TabIndex = 186;
            this.label2.Text = "Tên tài khoản:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(635, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 18);
            this.label1.TabIndex = 190;
            this.label1.Text = "Loại tài khoản:";
            // 
            // dtgvUser
            // 
            this.dtgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvUser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgvUser.Location = new System.Drawing.Point(0, 365);
            this.dtgvUser.Name = "dtgvUser";
            this.dtgvUser.RowHeadersWidth = 51;
            this.dtgvUser.RowTemplate.Height = 24;
            this.dtgvUser.Size = new System.Drawing.Size(1555, 458);
            this.dtgvUser.TabIndex = 192;
            this.dtgvUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvUser_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(635, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(265, 37);
            this.label3.TabIndex = 193;
            this.label3.Text = "Quản lý tài khoản";
            // 
            // cbLoaiTK
            // 
            this.cbLoaiTK.FormattingEnabled = true;
            this.cbLoaiTK.Items.AddRange(new object[] {
            "admin",
            "nhansu",
            "luong",
            "chamcong"});
            this.cbLoaiTK.Location = new System.Drawing.Point(773, 196);
            this.cbLoaiTK.Name = "cbLoaiTK";
            this.cbLoaiTK.Size = new System.Drawing.Size(160, 24);
            this.cbLoaiTK.TabIndex = 194;
            // 
            // txtTenHienThi
            // 
            this.txtTenHienThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenHienThi.Location = new System.Drawing.Point(773, 254);
            this.txtTenHienThi.Name = "txtTenHienThi";
            this.txtTenHienThi.Size = new System.Drawing.Size(160, 24);
            this.txtTenHienThi.TabIndex = 196;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(635, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 18);
            this.label4.TabIndex = 195;
            this.label4.Text = "Tên hiển thị:";
            // 
            // quanlytaikhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1555, 823);
            this.Controls.Add(this.txtTenHienThi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbLoaiTK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtgvUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassWord);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_xoa);
            this.Name = "quanlytaikhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "quanlytaikhoan";
            this.Load += new System.EventHandler(this.quanlytaikhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnAdd;
        private FontAwesome.Sharp.IconButton btn_sua;
        private FontAwesome.Sharp.IconButton btn_xoa;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbLoaiTK;
        private System.Windows.Forms.TextBox txtTenHienThi;
        private System.Windows.Forms.Label label4;
    }
}