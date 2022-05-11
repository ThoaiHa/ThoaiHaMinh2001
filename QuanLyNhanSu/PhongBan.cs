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
    public partial class PhongBan : Form
    {
        private DataTable tblPhongBan;
        public PhongBan()
        {
            InitializeComponent();
        }
        public void LoadDataGridView()
        {
            string sql;
            sql = "SELECT * FROM PHONGBAN ";
            tblPhongBan = functions.GetDataToTable(sql); //lấy dữ liệu
            dgvpb.DataSource = tblPhongBan;
            dgvpb.Columns[0].HeaderText = "Mã Phòng Ban";
            dgvpb.Columns[1].HeaderText = "Tên Phòng Ban";
            dgvpb.Columns[2].HeaderText = "Số Điện Thoại";
            dgvpb.Columns[0].Width = 200;
            dgvpb.Columns[1].Width = 200;
            dgvpb.Columns[2].Width = 300;

            dgvpb.AllowUserToAddRows = false;
            dgvpb.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void PhongBan_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
            btnSua.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = true;
            btnThem.Enabled = true;
        }

        private void dgvpb_DoubleClick(object sender, EventArgs e)
        {
            if (tblPhongBan.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaPhongBan.Text = dgvpb.CurrentRow.Cells["MAPHONGBAN"].Value.ToString();
            txtSDT.Text = dgvpb.CurrentRow.Cells["TENPHONGBAN"].Value.ToString();
            txtTenPhongBan.Text = dgvpb.CurrentRow.Cells["SDT"].Value.ToString();
           
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = true;
            btnThem.Enabled = false;
        }

        private void ResetValues()
        {
            txtMaPhongBan.Text = "";
            txtSDT.Text = "";
            txtTenPhongBan.Text = "";
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
            sql = "UPDATE  PHONGBAN SET TENPHONGBAN=N'" + txtTenPhongBan.Text.Trim().ToString() + "',SDT=N'" + txtSDT.Text.Trim().ToString() + "'WHERE  MAPHONGBAN= N'" + txtMaPhongBan.Text.Trim().ToString() + "'";
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
            if (txtMaPhongBan.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Mã Phòng Ban", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaPhongBan.Focus();
                return;
            }
            if (txtTenPhongBan.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Tên Phòng Ban", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenPhongBan.Focus();
                return;
            }
            if (txtSDT.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Số Điện Thoại Phòng Ban", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSDT.Focus();
                return;
            }


            sql = "SELECT MAPHONGBAN FROM PHONGBAN WHERE MAPHONGBAN=N'" + txtMaPhongBan.Text.Trim() + "'";
            if (functions.CheckKey(sql))
            {
                MessageBox.Show("Mã phòng ban này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaPhongBan.Focus();
                txtMaPhongBan.Text = "";
                return;
            }
            sql = "INSERT INTO PHONGBAN VALUES (N'" + txtMaPhongBan.Text.Trim() + "',N'" + txtTenPhongBan.Text.Trim() + "',N'" + txtSDT.Text.Trim() + "')";
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
