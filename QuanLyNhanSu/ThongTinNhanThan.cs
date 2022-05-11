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
    public partial class ThongTinNhanThan : Form
    {
        private DataTable tblNhanThan;
        public ThongTinNhanThan()
        {
            InitializeComponent();
        }
        public void LoadDataGridView()
        {
            string sql;
            sql = "SELECT * FROM NHANTHAN ";
            tblNhanThan = functions.GetDataToTable(sql); //lấy dữ liệu
            dgvNhanThan.DataSource = tblNhanThan;
            dgvNhanThan.Columns[0].HeaderText = "Mã Nhân Thân";
            dgvNhanThan.Columns[1].HeaderText = "Mã Nhân Viên";
            dgvNhanThan.Columns[2].HeaderText = "Họ Tên Nhân Thân";
            dgvNhanThan.Columns[3].HeaderText = "Ngày Sinh";
            dgvNhanThan.Columns[4].HeaderText = "Giới Tính";
            dgvNhanThan.Columns[5].HeaderText = "Mối Quan Hệ";
            dgvNhanThan.Columns[6].HeaderText = "Số điện thoại";
            dgvNhanThan.Columns[7].HeaderText = "Nghề nghiệp";
            dgvNhanThan.Columns[8].HeaderText = "CMND/CCCD";
            dgvNhanThan.Columns[0].Width = 100;
            dgvNhanThan.Columns[1].Width = 100;
            dgvNhanThan.Columns[2].Width = 300;
            dgvNhanThan.Columns[3].Width = 100;
            dgvNhanThan.Columns[4].Width = 100;
            dgvNhanThan.Columns[5].Width = 100;
            dgvNhanThan.Columns[6].Width = 100;
            dgvNhanThan.Columns[7].Width = 100;
            dgvNhanThan.Columns[8].Width = 100;

            dgvNhanThan.AllowUserToAddRows = false;
            dgvNhanThan.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void ThongTinNhanThan_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
            btnSua.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = true;
            btnThem.Enabled = true;
        }
        private void ResetValues()
        {
            txtMaNhanThan.Text = "";
            txtMaNhanVien.Text = "";
            txtHoTenNT.Text = "";
            txtNgaySinh.Text = "";
            cboGioiTinh.Text = "";
            txtQuanHeNhanThan.Text = "";
            txtSDT.Text = "";
            txtNgheNghiep.Text = "";
            txtSoCMND.Text = "";

        }

        private void dgvNhanThan_DoubleClick(object sender, EventArgs e)
        {
            if (tblNhanThan.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaNhanThan.Text = dgvNhanThan.CurrentRow.Cells["MANT"].Value.ToString();
            txtMaNhanVien.Text = dgvNhanThan.CurrentRow.Cells["MANV"].Value.ToString();
            txtHoTenNT.Text = dgvNhanThan.CurrentRow.Cells["HOTENNV"].Value.ToString();
            txtNgaySinh.Text = dgvNhanThan.CurrentRow.Cells["NGAYSINH"].Value.ToString();
            cboGioiTinh.Text = dgvNhanThan.CurrentRow.Cells["GIOITINH"].Value.ToString();
            txtQuanHeNhanThan.Text = dgvNhanThan.CurrentRow.Cells["MOIQUANHE"].Value.ToString();
            txtSDT.Text = dgvNhanThan.CurrentRow.Cells["SDT"].Value.ToString();
            txtNgheNghiep.Text = dgvNhanThan.CurrentRow.Cells["NGHENGHIEP"].Value.ToString();
            txtSoCMND.Text = dgvNhanThan.CurrentRow.Cells["CMND"].Value.ToString();
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = true;
            btnThem.Enabled = false;
        }   

        private void btnThem_Click_1(object sender, EventArgs e)
        {

            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnThem.Enabled = false;
            ResetValues();
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {

            string sql, gt;
            sql = "UPDATE  NHANTHAN SET MANV=N'" + txtMaNhanVien.Text.Trim().ToString() + "',HOTENNT=N'" + txtHoTenNT.Text.Trim().ToString() + "',NGAYSINH=N'" + functions.ConvertDateTime(txtNgaySinh.Text.Trim()) + "',GIOITINH=N'" + cboGioiTinh.Text.Trim().ToString() + "',MOIQUANHE=N'" + txtQuanHeNhanThan.Text.Trim().ToString() + "',SDT=N'" + txtSDT.Text.Trim().ToString() + "',NGHENGHIEP=N'" + txtNgheNghiep.Text.Trim().ToString() + "',CMND=N'" + txtSoCMND.Text.Trim().ToString() + "'WHERE  MANT= N'" + txtMaNhanThan.Text.Trim() + "'";
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
            if (txtMaNhanThan.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nhân thân", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNhanThan.Focus();
                return;
            }
            if (txtMaNhanVien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Mã Nhân Viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNhanVien.Focus();
                return;
            }
            if (txtHoTenNT.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Họ Và Tên Của Nhân Thân", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTenNT.Focus();
                return;
            }
            if (txtNgaySinh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Ngày Sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNgaySinh.Focus();
                return;
            }
            if (cboGioiTinh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Giới Tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboGioiTinh.Focus();
                return;
            }
            if (txtQuanHeNhanThan.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Mối Quan Hệ với Nhân Thân", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQuanHeNhanThan.Focus();
                return;
            }
            if (txtSDT.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Số Điện Thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSDT.Focus();
                return;
            }
            if (txtNgheNghiep.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Nghề Nghiệp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNgheNghiep.Focus();
                return;
            }
            if (txtSoCMND.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Số CMND", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoCMND.Focus();
                return;
            }


            sql = "SELECT MANT FROM NHANTHAN WHERE MANV=N'" + txtMaNhanThan.Text.Trim() + "'";
            if (functions.CheckKey(sql))
            {
                MessageBox.Show("Mã nhân thân này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNhanThan.Focus();
                txtMaNhanThan.Text = "";
                return;
            }
            sql = "INSERT INTO NHANTHAN VALUES (N'" + txtMaNhanThan.Text.Trim() + "',N'" + txtMaNhanVien.Text.Trim() + "',N'" + txtHoTenNT.Text.Trim() + "',N'" + functions.ConvertDateTime(txtNgaySinh.Text.Trim()) + "',N'" + cboGioiTinh.Text.Trim() + "',N'" + txtQuanHeNhanThan.Text.Trim() + "',N'" + txtSDT.Text.Trim() + "',N'" + txtNgheNghiep.Text.Trim() + "',N'" + txtSoCMND.Text.Trim() + "')";
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

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

