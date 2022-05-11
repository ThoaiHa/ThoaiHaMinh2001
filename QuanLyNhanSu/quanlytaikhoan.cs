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
    public partial class quanlytaikhoan : Form
    {
        int index = -1;
        public quanlytaikhoan()
        {
            InitializeComponent();
        }

        void LoadDanhSachTaiKhoan()
        {
            dtgvUser.DataSource = null;
            dtgvUser.DataSource = DanhSachTaiKhoan.Instance.ListTaiKhoan;
            dtgvUser.Refresh();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            

            if (index < 0)
            {
                MessageBox.Show("Vui lòng chọn 1 bản ghi");
                return;
            }
            string tenTaiKhoan = txtUserName.Text;
            string matKhau = txtPassWord.Text;
            DanhSachTaiKhoan.Instance.ListTaiKhoan.Add(new TaiKhoan(tenTaiKhoan,matKhau));
            LoadDanhSachTaiKhoan();
        }

        

        private void quanlytaikhoan_Load(object sender, EventArgs e)
        {
            LoadDanhSachTaiKhoan();
        }

        private void dtgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index<0) return;

            txtUserName.Text = dtgvUser.Rows[index].Cells[0].Value.ToString();
            txtPassWord.Text = dtgvUser.Rows[index].Cells[1].Value.ToString();
            cbLoaiTK.Text = dtgvUser.Rows[index].Cells[2].Value.ToString();
            txtTenHienThi.Text = dtgvUser.Rows[index].Cells[3].Value.ToString();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (index < 0) 
            {
                MessageBox.Show("Vui lòng chọn 1 bản ghi");
                return;
             }
            string tenTaiKhoan = txtUserName.Text;
            string matKhau = txtPassWord.Text;
            DanhSachTaiKhoan.Instance.ListTaiKhoan[index].TenTaiKhoan = tenTaiKhoan;
            DanhSachTaiKhoan.Instance.ListTaiKhoan[index].MatKhau = matKhau;
            LoadDanhSachTaiKhoan();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (index < 0)
            {
                MessageBox.Show("Vui lòng chọn 1 bản ghi");
                return;
            }
            DanhSachTaiKhoan.Instance.ListTaiKhoan.RemoveAt(index);
            LoadDanhSachTaiKhoan();
        }
    }
}
