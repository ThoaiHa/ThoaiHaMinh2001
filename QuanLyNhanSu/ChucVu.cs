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
    public partial class ChucVu : Form
    {
        private DataTable tblChucVu;
        public ChucVu()
        {
            InitializeComponent();
        }
        public void LoadDataGridView()
        {
            string sql;
            sql = "SELECT * FROM CHUCVU ";
            tblChucVu = functions.GetDataToTable(sql); //lấy dữ liệu
            dgvCV.DataSource = tblChucVu;
            dgvCV.Columns[0].HeaderText = "Mã Chức Vụ";
            dgvCV.Columns[1].HeaderText = "Tên Chức Vụ";
            dgvCV.Columns[2].HeaderText = "Ghi Chú";
            dgvCV.Columns[3].HeaderText = "Phụ Cấp Chức Vụ";
            dgvCV.Columns[0].Width = 200;
            dgvCV.Columns[1].Width = 200;
            dgvCV.Columns[2].Width = 200;
            dgvCV.Columns[3].Width = 200;

            dgvCV.AllowUserToAddRows = false;
            dgvCV.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void ChucVu_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
            btnSua.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = true;
            btnThem.Enabled = true;
        }

        private void dgvCV_DoubleClick(object sender, EventArgs e)
        {
            if (tblChucVu.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaChucVu.Text = dgvCV.CurrentRow.Cells["MACHUCVU"].Value.ToString();
            txtTenChucVu.Text = dgvCV.CurrentRow.Cells["TENCHUCVU"].Value.ToString();
            txtGhiChu.Text = dgvCV.CurrentRow.Cells["GHICHU"].Value.ToString();
            txtPhuCapChucVu.Text = dgvCV.CurrentRow.Cells["PHUCAPCHUCVU"].Value.ToString();

            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = true;
            btnThem.Enabled = false;
        }
        private void ResetValues()
        {
            txtMaChucVu.Text = "";
            txtTenChucVu.Text = "";
            txtGhiChu.Text = "";
            txtPhuCapChucVu.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnThem.Enabled = false;
            ResetValues();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql, gt;
            sql = "UPDATE  CHUCVU SET TENCHUCVU=N'" + txtTenChucVu.Text.Trim().ToString() + "',GHICHU=N'" + txtGhiChu.Text.Trim().ToString() + "',PHUCAPCHUCVU=N'" + txtPhuCapChucVu.Text.Trim().ToString() + "'WHERE  MACHUCVU= N'" + txtMaChucVu.Text.Trim().ToString() + "'";
            functions.RunSQL(sql);
            LoadDataGridView();
            ResetValues();
            btnSua.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnThem.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql, gt;
            if (txtMaChucVu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Mã Phòng Ban", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaChucVu.Focus();
                return;
            }
            if (txtTenChucVu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Tên Phòng Ban", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenChucVu.Focus();
                return;
            }
            if (txtGhiChu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Số Điện Thoại Phòng Ban", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGhiChu.Focus();
                return;
            }
            if (txtPhuCapChucVu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Số Điện Thoại Phòng Ban", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhuCapChucVu.Focus();
                return;
            }


            sql = "SELECT MACHUCVU FROM CHUCVU WHERE MACHUCVU=N'" + txtMaChucVu.Text.Trim() + "'";
            if (functions.CheckKey(sql))
            {
                MessageBox.Show("Mã chức vụ này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaChucVu.Focus();
                txtMaChucVu.Text = "";
                return;
            }
            sql = "INSERT INTO CHUCVU VALUES (N'" + txtMaChucVu.Text.Trim() + "',N'" + txtTenChucVu.Text.Trim() + "',N'" + txtGhiChu.Text.Trim() + "',N'" + txtPhuCapChucVu.Text.Trim() + "')";
            functions.RunSQL(sql);
            LoadDataGridView();
            ResetValues();
            btnSua.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnThem.Enabled = true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnSua.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnThem.Enabled = true;
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
