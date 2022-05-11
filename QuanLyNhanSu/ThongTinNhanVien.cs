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
    public partial class ThongTinNhanVien : Form
    {
        private DataTable tblNhanVien;
        public ThongTinNhanVien()
        {
            InitializeComponent();
        }

     
        public void LoadDataGridView()
        {
            string sql;
            sql = "SELECT * FROM NHANVIEN ";
            tblNhanVien = functions.GetDataToTable(sql); //lấy dữ liệu
            dgvNhanVien.DataSource = tblNhanVien;
          
            dgvNhanVien.Columns[0].HeaderText = "Mã Nhân Viên";
            dgvNhanVien.Columns[1].HeaderText = "Họ và Tên";
            dgvNhanVien.Columns[2].HeaderText = "Ngày Sinh";
            dgvNhanVien.Columns[3].HeaderText = "Giới Tính ";
            dgvNhanVien.Columns[4].HeaderText = "Số điện Thoại";
            dgvNhanVien.Columns[5].HeaderText = "Email";
            dgvNhanVien.Columns[6].HeaderText = "Nơi Sinh";
            dgvNhanVien.Columns[7].HeaderText = "CMND/CCCD";
            dgvNhanVien.Columns[8].HeaderText = "Ngày Cấp";
            dgvNhanVien.Columns[9].HeaderText = "Nơi Cấp";
            dgvNhanVien.Columns[10].HeaderText = "Địa Chỉ Tạm Trú";
            dgvNhanVien.Columns[11].HeaderText = "Địa Chỉ Thường Trú";
            dgvNhanVien.Columns[12].HeaderText = "Trình Độ Học Vấn";
            dgvNhanVien.Columns[13].HeaderText = "Trình Độ Chuyên Môn";
            dgvNhanVien.Columns[14].HeaderText = "Tình Trạng Hôn Nhân";
            dgvNhanVien.Columns[15].HeaderText = "Mã Thuế TNCN";
            dgvNhanVien.Columns[16].HeaderText = "Mã BHXH";
            dgvNhanVien.Columns[17].HeaderText = "Ghi Chú";
   
            dgvNhanVien.Columns[0].Width = 150;
            dgvNhanVien.Columns[1].Width = 200;
            dgvNhanVien.Columns[2].Width = 150;
            dgvNhanVien.Columns[3].Width = 150;
            dgvNhanVien.Columns[4].Width = 150;
            dgvNhanVien.Columns[5].Width = 200;
            dgvNhanVien.Columns[6].Width = 150;
            dgvNhanVien.Columns[7].Width = 150;
            dgvNhanVien.Columns[8].Width = 150;
            dgvNhanVien.Columns[9].Width = 150;
            dgvNhanVien.Columns[10].Width = 150;
            dgvNhanVien.Columns[11].Width = 150;
            dgvNhanVien.Columns[12].Width = 150;
            dgvNhanVien.Columns[13].Width = 150;
            dgvNhanVien.Columns[14].Width = 150;
            dgvNhanVien.Columns[15].Width = 150;
            dgvNhanVien.Columns[16].Width = 150;
            dgvNhanVien.Columns[17].Width = 150;
            dgvNhanVien.AllowUserToAddRows = false;
            dgvNhanVien.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void ThongTinNhanVien_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
        }

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvNhanVien_DoubleClick(object sender, EventArgs e)
        {
            if (tblNhanVien.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtmanv.Text = dgvNhanVien.CurrentRow.Cells["MANV"].Value.ToString();
            txtHoTenNV.Text = dgvNhanVien.CurrentRow.Cells["HOTENNV"].Value.ToString();
            dateNgaySinh.Text = dgvNhanVien.CurrentRow.Cells["NGAYSINH"].Value.ToString();
            cboGioiTinh.Text = dgvNhanVien.CurrentRow.Cells["GIOITINH"].Value.ToString();
            txtSĐT.Text = dgvNhanVien.CurrentRow.Cells["SDT"].Value.ToString();
            txtEmail.Text = dgvNhanVien.CurrentRow.Cells["EMAIL"].Value.ToString();
           txtNoiSinh.Text = dgvNhanVien.CurrentRow.Cells["NOISINH"].Value.ToString();
            txtCMND.Text = dgvNhanVien.CurrentRow.Cells["CMND"].Value.ToString();
            txtNgayCapCMND.Text = dgvNhanVien.CurrentRow.Cells["NGAYCAP"].Value.ToString();
            txtNoiCap.Text = dgvNhanVien.CurrentRow.Cells["NOICAP"].Value.ToString();
            txtDCTamTru.Text = dgvNhanVien.CurrentRow.Cells["DCTAMTRU"].Value.ToString();
            txtDCThuongTru.Text = dgvNhanVien.CurrentRow.Cells["DCTHUONGTRU"].Value.ToString();
            txtHocVan.Text = dgvNhanVien.CurrentRow.Cells["TRINHDOHOCVAN"].Value.ToString();
            txtTrinhDoChuyenMon.Text = dgvNhanVien.CurrentRow.Cells["TRINHDOCHUYENMON"].Value.ToString();
           txtHonNhan.Text = dgvNhanVien.CurrentRow.Cells["TINHTRANGHONNHAN"].Value.ToString();
           txtMSThua.Text = dgvNhanVien.CurrentRow.Cells["MSTHUETNCN"].Value.ToString();
            txtBHXH.Text = dgvNhanVien.CurrentRow.Cells["MABHXH"].Value.ToString();
            txtGhiChu.Text = dgvNhanVien.CurrentRow.Cells["GHICHU"].Value.ToString();
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = true;
            btnThem.Enabled = false;


            /*   string sql;
              sql = "SELECT HOTENNV FROM NHANVIEN Where MANV = N'"+txtmanv.Text+"'";
               txtHoTenNV.Text = functions.GetFieldValues(sql);
               txtBHXH.Text = dgvNhanVien.CurrentRow.Cells["MABHXH"].Value.ToString();
               sql = "SELECT b.NOICAP FROM NHANVIEN AS a , BAOHIEM AS b  Where a.MABHXH = N'" + txtBHXH.Text + "'and a.MABHXH= b.MABHXH";
               txt1.Text = functions.GetFieldValues(sql);*/
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

       /* private void cboPhongBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql;
            sql = "SELECT MAPHONGBAN FROM PHONGBAN Where TENPHONGBAN=N'" + cboPhongBan.Text + "' ";
            txtMaPhongBan.Text = functions.GetFieldValues(sql);
        }*/

        
        private void ResetValues()
        {
            txtmanv.Text = "";
            txtHoTenNV.Text = "";
            dateNgaySinh.Text = "";
            cboGioiTinh.Text = "";
            txtSĐT.Text = "";
            txtEmail.Text = "";
            txtNoiSinh.Text = "";
            txtCMND.Text = "";
            txtNgayCapCMND.Text = "";
            txtNoiCap.Text = "";
            txtDCTamTru.Text = "";
            txtDCThuongTru.Text = "";
            txtHocVan.Text = "";
            txtTrinhDoChuyenMon.Text = "";
            txtHonNhan.Text = "";
            txtMSThua.Text = "";
            txtBHXH.Text = "";
            txtGhiChu.Text = "";
            cboTTLV.Text = "";
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
            sql = "UPDATE  NHANVIEN SET HOTENNV=N'" + txtHoTenNV.Text.Trim().ToString() + "',NGAYSINH=N'" + functions.ConvertDateTime(dateNgaySinh.Text.Trim()) + "',GIOITINH=N'" + cboGioiTinh.Text.Trim().ToString() + "',SDT=N'" + txtSĐT.Text.Trim().ToString() + "',EMAIL=N'" + txtEmail.Text.Trim().ToString() + "',NOISINH=N'" + txtNoiSinh.Text.Trim().ToString() + "',CMND=N'" + txtCMND.Text.Trim().ToString() + "',NGAYCAP=N'" + txtNgayCapCMND.Text.Trim().ToString() + "',NOICAP=N'" + txtNoiCap.Text.Trim().ToString() + "',DCTAMTRU=N'" + txtDCTamTru.Text.Trim().ToString() + "',DCTHUONGTRU=N'" + txtDCThuongTru.Text.Trim().ToString() + "',TRINHDOHOCVAN=N'" + txtHocVan.Text.Trim().ToString() + "',TRINHDOCHUYENMON=N'" + txtTrinhDoChuyenMon.Text.Trim().ToString() + "',TINHTRANGHONNHAN=N'" + txtHonNhan.Text.Trim().ToString() + "',MSTHUETNCN=N'" + txtMSThua.Text.Trim().ToString() + "',MABHXH=N'" + txtBHXH.Text.Trim().ToString() +
                "',GHICHU=N'" + txtGhiChu.Text.Trim().ToString() +
                "',TTLV=N'" + cboTTLV.Text.Trim().ToString() + "'WHERE MANV=N'" + txtmanv.Text.Trim() + "'";
            functions.RunSQL(sql);
            LoadDataGridView();
            ResetValues();
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = true;
            btnThem.Enabled = false;
        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            string sql, gt;
            if (txtmanv.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmanv.Focus();
                return;
            }
            if (txtHoTenNV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Họ và Tên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTenNV.Focus();
                return;
            }
            if (dateNgaySinh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Ngày Sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateNgaySinh.Focus();
                return;
            }
            if (cboGioiTinh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Giới Tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboGioiTinh.Focus();
                return;
            }

            if (txtEmail.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }
            if (txtNoiSinh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Nơi Sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNoiSinh.Focus();
                return;
            }
            if (txtSĐT.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Số Điện Thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSĐT.Focus();
                return;
            }
            if (txtCMND.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập CMND hoặc CCCD", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCMND.Focus();
                return;
            }
            if (txtNgayCapCMND.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Ngày Cấp CMND/CCCD", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNgayCapCMND.Focus();
                return;
            }
            if (txtNoiCap.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Nơi Cấp CMND/CCCD", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNoiCap.Focus();
                return;
            }
            if (txtDCTamTru.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Địa Chỉ Tạm Trú", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDCTamTru.Focus();
                return;
            }
            if (txtDCThuongTru.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Địa chỉ thường trú", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDCThuongTru.Focus();
                return;
            }

            if (txtHocVan.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập trình độ học vấn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHocVan.Focus();
                return;
            }
            if (txtTrinhDoChuyenMon.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập trình độ chuyên môn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTrinhDoChuyenMon.Focus();
                return;
            }
            if (txtHonNhan.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tình trạng hôn nhân", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHonNhan.Focus();
                return;
            }

            sql = "SELECT MANV FROM NHANVIEN WHERE MANV=N'" + txtmanv.Text.Trim() + "'";
            if (functions.CheckKey(sql))
            {
                MessageBox.Show("Mã nhân viên này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmanv.Focus();
                txtmanv.Text = "";
                return;
            }
            sql = "INSERT INTO NHANVIEN VALUES (N'" + txtmanv.Text.Trim() + "',N'" + txtHoTenNV.Text.Trim() + "',N'" + functions.ConvertDateTime(dateNgaySinh.Text.Trim()) + "',N'" + cboGioiTinh.Text.Trim() + "',N'" + txtSĐT.Text.Trim() + "',N'" + txtEmail.Text.Trim() + "',N'" + txtNoiSinh.Text.Trim() + "',N'" + txtCMND.Text.Trim() + "',N'" + txtNgayCapCMND.Text.Trim() + "',N'" + txtNoiCap.Text.Trim() + "',N'" + txtDCTamTru.Text.Trim() + "',N'" + txtDCThuongTru.Text.Trim() + "',N'" + txtHocVan.Text.Trim() + "',N'" + txtTrinhDoChuyenMon.Text.Trim() + "',N'" + txtHonNhan.Text.Trim() + "',N'" + txtMSThua.Text.Trim() + "',N'" + txtBHXH.Text.Trim() + "',N'" + txtGhiChu.Text.Trim() + "',N'" + cboTTLV.Text.Trim().ToString() + "')";
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

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Reportnhanvien a = new Reportnhanvien();
            a.ShowDialog();
        }
    }
}
