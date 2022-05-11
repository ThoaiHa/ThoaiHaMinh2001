using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu
{
    public partial class DangNhap : Form
    {
        List<TaiKhoan> listTaiKhoan = DanhSachTaiKhoan.Instance.ListTaiKhoan;
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btdangnhap_Click(object sender, EventArgs e)
        {
            if(KiemTraDangNhap(txbTaiKhoan.Text, txbMatKhau.Text))
            {     
                FormMain f = new FormMain();
                f.Show();
                this.Hide();
                f.DangXuat += F_DangXuat;
            }
            else 
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu", "Lỗi");
                txbTaiKhoan.Focus();
            }
        }

        private void F_DangXuat(object sender, EventArgs e)
        {
            (sender as FormMain).isThoat = false;
            (sender as FormMain).Close();
            this.Show();
        }

        private void btthoát_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có thực sự muốn thoát hay không?", "Hộp thoại", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        bool KiemTraDangNhap(string tentaikhoan, string matkhau)
        { 
            for(int i = 0; i < listTaiKhoan.Count; i++)
            {
                if (tentaikhoan == listTaiKhoan[i].TenTaiKhoan && matkhau == listTaiKhoan[i].MatKhau)
                {
                    Const.TaiKhoan = listTaiKhoan[i];
                    return true;
                }
            }    
                return false;
        }
    }
}
