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
    public partial class QuaTrinhLamViec : Form
    {
        private DataTable tblQTLV;
        public QuaTrinhLamViec()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void QuaTrinhLamViec_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
            btnSua.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = true;
            btnThem.Enabled = true;

        }
        public void LoadDataGridView()
        {
            string sql;
            sql = "SELECT * FROM QUATRINHLAMVIEC ";
            tblQTLV = functions.GetDataToTable(sql); //lấy dữ liệu
            dvgqtlv.DataSource = tblQTLV;
            dvgqtlv.Columns[0].HeaderText = "Mã Nhân Viên";
            dvgqtlv.Columns[1].HeaderText = "Mã Phòng Ban";
            dvgqtlv.Columns[2].HeaderText = "Mã Chức Vụ";
            dvgqtlv.Columns[3].HeaderText = "Bộ Phận";
            dvgqtlv.Columns[4].HeaderText = "Thời Gian";
            dvgqtlv.Columns[5].HeaderText = "Tình Trạng Làm Việc";
            dvgqtlv.Columns[0].Width = 200;
            dvgqtlv.Columns[1].Width = 200;
            dvgqtlv.Columns[2].Width = 200;
            dvgqtlv.Columns[3].Width = 200;
            dvgqtlv.Columns[4].Width = 200;
            dvgqtlv.Columns[5].Width = 200;

            dvgqtlv.AllowUserToAddRows = false;
            dvgqtlv.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dvgqtlv_DoubleClick(object sender, EventArgs e)
        {
           
            if (tblQTLV.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaChucVu.Text = dvgqtlv.CurrentRow.Cells["MACHUCVU"].Value.ToString();
            txtMaNV.Text = dvgqtlv.CurrentRow.Cells["MANV"].Value.ToString();
            txtMaPhongBan.Text = dvgqtlv.CurrentRow.Cells["MAPHONGBAN"].Value.ToString();
            txtTGLamViec.Text = dvgqtlv.CurrentRow.Cells["THOIGIAN"].Value.ToString();
            txtTTTinhTrangLV.Text = dvgqtlv.CurrentRow.Cells["TINHTRANGLAMVIEC"].Value.ToString();
            cboBoPhan.Text = dvgqtlv.CurrentRow.Cells["BOPHAN"].Value.ToString();
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = true;
            btnThem.Enabled = false;

        }
        private void ResetValues()
        {
            txtMaChucVu.Text = "";
            txtMaNV.Text = "";
            txtMaPhongBan.Text = "";
            txtTGLamViec.Text = "";
            txtTTTinhTrangLV.Text = "";
            cboBoPhan.Text = "";

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
            sql = "UPDATE  QUATRINHLAMVIEC SET MAPHONGBAN=N'" + txtMaPhongBan.Text.Trim() + "',MACHUCVU=N'" + txtMaChucVu.Text.Trim() + "',BOPHAN=N'" + cboBoPhan.Text.Trim() + "',THOIGIAN=N'" + txtTGLamViec.Text.Trim() + "',TINHTRANGLAMVIEC=N'" + txtTTTinhTrangLV.Text.Trim() + "'WHERE  MANV= N'" + txtMaNV.Text.Trim() + "'";
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
            if (txtMaNV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNV.Focus();
                return;
            }
            if (cboBoPhan.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Tên Bộ Phận", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboBoPhan.Focus();
                return;
            }
            if (txtMaPhongBan.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Mã Phòng Ban", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaPhongBan.Focus();
                return;
            }
            if (txtMaChucVu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Mã Chức Vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaChucVu.Focus();
                return;
            }
            if (txtTGLamViec.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Thời Gian Làm Việc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTGLamViec.Focus();
                return;
            }
            if (txtTTTinhTrangLV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Tình Trạng Làm Việc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTTTinhTrangLV.Focus();
                return;
            }


            sql = "SELECT MANV FROM QUATRINHLAMVIEC WHERE MANV=N'" + txtMaNV.Text.Trim() + "'";
            if (functions.CheckKey(sql))
            {
                MessageBox.Show("Mã nhân viên này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNV.Focus();
                txtMaNV.Text = "";
                return;
            }
            sql = "INSERT INTO QUATRINHLAMVIEC VALUES (N'" + txtMaNV.Text.Trim() + "',N'" + txtMaPhongBan.Text.Trim() + "',N'" + txtMaChucVu.Text.Trim() + "',N'" + cboBoPhan.Text.Trim() + "',N'" + txtTGLamViec.Text.Trim() + "',N'" + txtTTTinhTrangLV.Text.Trim() + "')";
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
