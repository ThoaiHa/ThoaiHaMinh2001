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
    
    public partial class BienDongTIenLuong : Form
    {
        private DataTable tblBiendongluong;
        public BienDongTIenLuong()
        {
            InitializeComponent();
        }
        public void LoadDataGridView()
        {
            string sql;
            sql = "SELECT * FROM BIENDONGTIENLUONG ";
            tblBiendongluong = functions.GetDataToTable(sql); //lấy dữ liệu
            dgvBDTL.DataSource = tblBiendongluong;
            dgvBDTL.Columns[0].HeaderText = "Mã Lương";
            dgvBDTL.Columns[1].HeaderText = "Mã Nhân Viên";
            dgvBDTL.Columns[2].HeaderText = "Lý Do";
            dgvBDTL.Columns[3].HeaderText = "Ngày Có Hiệu Lực";
            dgvBDTL.Columns[4].HeaderText = "Lương Cơ Bản";
            dgvBDTL.Columns[5].HeaderText = "Trạng Thái";
            dgvBDTL.Columns[6].HeaderText = "Nội Dung";
            dgvBDTL.Columns[0].Width = 200;
            dgvBDTL.Columns[1].Width = 200;
            dgvBDTL.Columns[2].Width = 300;
            dgvBDTL.Columns[3].Width = 200;
            dgvBDTL.Columns[4].Width = 200;
            dgvBDTL.Columns[5].Width = 300;
            dgvBDTL.Columns[6].Width = 200;
          

            dgvBDTL.AllowUserToAddRows = false;
            dgvBDTL.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void BienDongTIenLuong_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
            btnSua.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = true;
            btnThem.Enabled = true;
        }
        private void ResetValues()
        {
            txtMaLuong.Text = "";
            txtTenPhongBan.Text = "";
            txtLyDo.Text = "";
            dateNgayHieuLuc.Text = "";
            txtLuongcb.Text = "";
            txtTrangThai.Text = "";
            txtNoiDung.Text = "";
           

        }

        private void txtMaLuong_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvBDTL_DoubleClick(object sender, EventArgs e)
        {
            if (tblBiendongluong.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaLuong.Text = dgvBDTL.CurrentRow.Cells["MALUONG"].Value.ToString();
            txtTenPhongBan.Text = dgvBDTL.CurrentRow.Cells["MANV"].Value.ToString();
            txtLyDo.Text = dgvBDTL.CurrentRow.Cells["LYDO"].Value.ToString();
            dateNgayHieuLuc.Text = dgvBDTL.CurrentRow.Cells["NGAYCOHIEULUC"].Value.ToString();
            txtLuongcb.Text = dgvBDTL.CurrentRow.Cells["LUONGCB"].Value.ToString();
            txtTrangThai.Text = dgvBDTL.CurrentRow.Cells["TRANGTHAI"].Value.ToString();
            txtNoiDung.Text = dgvBDTL.CurrentRow.Cells["NOIDUNG"].Value.ToString();
           
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
            sql = "UPDATE  BIENDONGTIENLUONG SET MANV=N'" + txtTenPhongBan.Text.Trim().ToString() + "',LYDO=N'" + txtLyDo.Text.Trim().ToString() + "',NGAYCOHIEULUC=N'" + functions.ConvertDateTime(dateNgayHieuLuc.Text.Trim()) + "',LUONGCB=N'" + txtLuongcb.Text.Trim().ToString() + "',TRANGTHAI=N'" + txtTrangThai.Text.Trim().ToString() + "',NOIDUNG=N'" + txtNoiDung.Text.Trim().ToString() + "',LUONGNGAY=" + txtLuongcb.Text + "/26 WHERE  MALUONG= N'" + txtMaLuong.Text.Trim() + "'";
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
            if (txtMaLuong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã Lương", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaLuong.Focus();
                return;
            }
            if (txtTenPhongBan.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Mã Nhân Viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenPhongBan.Focus();
                return;
            }
            if (txtLyDo.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Lý Do", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLyDo.Focus();
                return;
            }
            if (dateNgayHieuLuc.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Ngày Có Hiệu Lực", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateNgayHieuLuc.Focus();
                return;
            }
            if (txtLuongcb.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Lương Cơ Bản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLuongcb.Focus();
                return;
            }
            if (txtTrangThai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Trạng Thái", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTrangThai.Focus();
                return;
            }
            if (txtNoiDung.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Nội Dung", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNoiDung.Focus();
                return;
            }



            sql = "SELECT MALUONG FROM BIENDONGTIENLUONG WHERE MALUONG=N'" + txtMaLuong.Text.Trim() + "'";
            if (functions.CheckKey(sql))
            {
                MessageBox.Show("Mã Lương này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaLuong.Focus();
                txtMaLuong.Text = "";
                return;
            }
            sql = "INSERT INTO BIENDONGTIENLUONG VALUES (N'" + txtMaLuong.Text.Trim() + "',N'" + txtTenPhongBan.Text.Trim() + "',N'" + txtLyDo.Text.Trim() + "',N'" + functions.ConvertDateTime(dateNgayHieuLuc.Text.Trim()) + "',N'" + txtLuongcb.Text.Trim() + "',N'" + txtTrangThai.Text.Trim() + "',N'" + txtNoiDung.Text.Trim() +
                "'," + txtLuongcb.Text.Trim() + "/26)";
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
