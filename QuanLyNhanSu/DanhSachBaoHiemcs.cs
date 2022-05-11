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
    public partial class DanhSachBaoHiemcs : Form
    {
        private DataTable tblBaoHiem;
        public DanhSachBaoHiemcs()
        {
            InitializeComponent();
        }
        public void LoadDataGridView()
        {
            string sql;
            sql = "SELECT * FROM BAOHIEM ";
            tblBaoHiem = functions.GetDataToTable(sql); //lấy dữ liệu
            dgvBaoHiem.DataSource = tblBaoHiem;
            dgvBaoHiem.Columns[0].HeaderText = "Mã Bảo Hiểm";
            dgvBaoHiem.Columns[1].HeaderText = "Mã Nhân Viên";
            dgvBaoHiem.Columns[2].HeaderText = "Mã BHXH";
            dgvBaoHiem.Columns[3].HeaderText = "Mã BHYT";
            dgvBaoHiem.Columns[4].HeaderText = "Mã BHTN";
            dgvBaoHiem.Columns[5].HeaderText = "Ngày Cấp";
            dgvBaoHiem.Columns[6].HeaderText = "Nơi Cấp";
            dgvBaoHiem.Columns[7].HeaderText = "Hạn Sử Dụng";
            dgvBaoHiem.Columns[0].Width = 200;
            dgvBaoHiem.Columns[1].Width = 200;
            dgvBaoHiem.Columns[2].Width = 300;
            dgvBaoHiem.Columns[3].Width = 200;
            dgvBaoHiem.Columns[4].Width = 200;
            dgvBaoHiem.Columns[5].Width = 300;
            dgvBaoHiem.Columns[6].Width = 200;
            dgvBaoHiem.Columns[7].Width = 300;

            dgvBaoHiem.AllowUserToAddRows = false;
            dgvBaoHiem.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgvKtKl_DoubleClick(object sender, EventArgs e)
        {
            if (tblBaoHiem.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaBH.Text = dgvBaoHiem.CurrentRow.Cells["MABH"].Value.ToString();
            txtMaNV.Text = dgvBaoHiem.CurrentRow.Cells["MANV"].Value.ToString();
            txtMaBHXH.Text = dgvBaoHiem.CurrentRow.Cells["MABHXH"].Value.ToString();
            txtMaBHYT.Text = dgvBaoHiem.CurrentRow.Cells["MABHYT"].Value.ToString();
            txtMaBHTN.Text = dgvBaoHiem.CurrentRow.Cells["MABHTN"].Value.ToString();
            txtNgayCap.Text = dgvBaoHiem.CurrentRow.Cells["NGAYCAP"].Value.ToString();
            txtNoiCap.Text = dgvBaoHiem.CurrentRow.Cells["NOICAP"].Value.ToString();
            txtHanSuDung.Text = dgvBaoHiem.CurrentRow.Cells["HANSUDUNG"].Value.ToString();
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = true;
            btnThem.Enabled = false;
        }

        private void DanhSachBaoHiemcs_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
            btnSua.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = true;
            btnThem.Enabled = true;
        }
        private void ResetValues()
        {
            txtMaBH.Text = "";
            txtMaNV.Text = "";
            txtMaBHXH.Text = "";
            txtMaBHYT.Text = "";
            txtMaBHTN.Text = "";
            txtNgayCap.Text = "";
            txtNoiCap.Text = "";
            txtHanSuDung.Text = "";
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
            sql = "UPDATE  BAOHIEM SET MANV=N'" + txtMaNV.Text.Trim() + "',MABHXH=N'" + txtMaBHXH.Text.Trim() + "',MABHYT=N'" + txtMaBHYT.Text.Trim() + "',MABHTN=N'" + txtMaBHTN.Text.Trim() + "',NGAYCAP=N'" + txtNgayCap.Text.Trim() + "',NOICAP=N'" + txtNoiCap.Text.Trim() + "',HANSUDUNG=N'" + txtHanSuDung.Text.Trim() + "'WHERE MABH=N'" + txtMaBH.Text.Trim() + "'";
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
            if (txtMaBH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Mã Bảo Hiểm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaBH.Focus();
                return;
            }
            if (txtMaNV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Mã Nhân Viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNV.Focus();
                return;
            }
            if (txtMaBHXH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Mã Bảo Hiểm Xã Hội", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaBHXH.Focus();
                return;
            }
            if (txtMaBHYT.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Mã Bảo Hiểm Y Tế", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaBHYT.Focus();
                return;
            }
            if (txtMaBHTN.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Mã Bảo Hiểm Thân Nhân", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaBHTN.Focus();
                return;
            }
            if (txtNgayCap.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Ngày Cấp Chứ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNgayCap.Focus();
                return;
            }
            if (txtNoiCap.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Nơi Cấp Bảo Hiểm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNoiCap.Focus();
                return;
            }
            if (txtHanSuDung.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Hạn Sử Dụng Bảo Hiểm Trong Bao Lâu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHanSuDung.Focus();
                return;
            }


            sql = "SELECT MABH FROM BAOHIEM WHERE MABH=N'" + txtMaBH.Text.Trim() + "'";
            if (functions.CheckKey(sql))
            {
                MessageBox.Show("Mã bảo hiểm này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaBH.Focus();
                txtMaBH.Text = "";
                return;
            }
            sql = "INSERT INTO BAOHIEM VALUES (N'" + txtMaBH.Text.Trim() + "',N'" + txtMaNV.Text.Trim() + "',N'" + txtMaBHXH.Text.Trim() + "',N'" + txtMaBHYT.Text.Trim() + "',N'" + txtMaBHTN.Text.Trim() + "',N'" + txtNgayCap.Text.Trim() + "',N'" + txtNoiCap.Text.Trim() + "',N'" + txtHanSuDung.Text.Trim() + "')";
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
