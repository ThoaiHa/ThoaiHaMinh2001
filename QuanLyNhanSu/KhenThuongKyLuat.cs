using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhanSu.Class;

namespace QuanLyNhanSu
{
    public partial class KhenThuongKyLuat : Form
    {
        private DataTable tblKhenThuong;
        public KhenThuongKyLuat()
        {
            InitializeComponent();
        }
        public void LoadDataGridView()
        {
            string sql;
            sql = "SELECT * FROM KHENTHUONGKYLUAT ";
            tblKhenThuong = functions.GetDataToTable(sql); //lấy dữ liệu
            dgvKTKL.DataSource = tblKhenThuong;
            dgvKTKL.Columns[0].HeaderText = "Mã Khen Thưởng Kỷ Luật";
            dgvKTKL.Columns[1].HeaderText = "Mã Nhân Viên";
            dgvKTKL.Columns[2].HeaderText = "Nội Dung Khen Thưởng Kỷ Luật";
            dgvKTKL.Columns[3].HeaderText = "Hình Thức Khen Thưởng Kỷ Luật";
            dgvKTKL.Columns[0].Width = 200;
            dgvKTKL.Columns[1].Width = 200;
            dgvKTKL.Columns[2].Width = 500;
            dgvKTKL.Columns[3].Width = 500;

            dgvKTKL.AllowUserToAddRows = false;
            dgvKTKL.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void KhenThuongKyLuat_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
            btnSua.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = true;
            btnThem.Enabled = true;
        }
        private void ResetValues()
        {
            txtMaKTKL.Text = "";
            txtMaNV.Text = "";
            txtNoiDung.Text = "";
            txtHinhThuc.Text = "";
        }

        
        
        
        

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            string sql, gt;
            sql = "UPDATE  KHENTHUONGKYLUAT SET MANV=N'" + txtMaNV.Text.Trim().ToString() + "',NOIDUNG=N'" + txtNoiDung.Text.Trim().ToString() + "',HINHTHUC=N'" + txtHinhThuc.Text.Trim().ToString() + "'WHERE  MAKTKL= N'" + txtMaKTKL.Text.Trim().ToString() + "'";
            functions.RunSQL(sql);
            LoadDataGridView();
            ResetValues();
            btnSua.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnThem.Enabled = true;
        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            string sql, gt;
            if (txtMaKTKL.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Mã Khen Thưởng Kỷ Luật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaKTKL.Focus();
                return;
            }
            if (txtMaNV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Mã Nhân Viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNV.Focus();
                return;
            }
            if (txtNoiDung.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Nội Dung Khen Thưởng Kỷ Luật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNoiDung.Focus();
                return;
            }
            if (txtHinhThuc.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Hình thức Khen Thưởng Kỷ Luật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHinhThuc.Focus();
                return;
            }


            sql = "SELECT MAKTKL FROM KHENTHUONGKYLUAT WHERE MAKTKL=N'" + txtMaKTKL.Text.Trim() + "'";
            if (functions.CheckKey(sql))
            {
                MessageBox.Show("Mã phòng ban này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaKTKL.Focus();
                txtMaKTKL.Text = "";
                return;
            }
            sql = "INSERT INTO KHENTHUONGKYLUAT VALUES (N'" + txtMaKTKL.Text.Trim() + "',N'" + txtMaNV.Text.Trim() + "',N'" + txtNoiDung.Text.Trim() + "',N'" + txtHinhThuc.Text.Trim() + "')";
            functions.RunSQL(sql);
            LoadDataGridView();
            ResetValues();
            btnSua.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnThem.Enabled = true;
        }

        private void btnHuy_Click_1(object sender, EventArgs e)
        {

            ResetValues();
            btnSua.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnThem.Enabled = true;
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnThem.Enabled = false;
            ResetValues();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvKTKL_DoubleClick(object sender, EventArgs e)
        {
            if (tblKhenThuong.Rows.Count == 0)
          {
               MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaKTKL.Text = dgvKTKL.CurrentRow.Cells["MAKTKL"].Value.ToString();
            txtMaNV.Text = dgvKTKL.CurrentRow.Cells["MANV"].Value.ToString();
            txtNoiDung.Text = dgvKTKL.CurrentRow.Cells["NOIDUNG"].Value.ToString();
            txtHinhThuc.Text = dgvKTKL.CurrentRow.Cells["HINHTHUC"].Value.ToString();
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = true;
            btnThem.Enabled = false;
        }
    }
}
