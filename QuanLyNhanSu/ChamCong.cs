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
    public partial class ChamCong : Form
    {
        private DataTable tblCC;
        public ChamCong()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }
        public void LoadDataGridView()
        {
            string sql;
            sql = "SELECT distinct a.*,b.NGAY1,b.NGAY2,b.NGAY3,b.NGAY4,b.NGAY5,b.NGAY6,b.NGAY7,b.NGAY8,b.NGAY9,b.NGAY10,b.NGAY11,b.NGAY12,b.NGAY13,b.NGAY14,b.NGAY15,b.NGAY16,b.NGAY17,b.NGAY18,b.NGAY19,b.NGAY20,b.NGAY21,b.NGAY22,b.NGAY23,b.NGAY24,b.NGAY25,b.NGAY26,b.NGAY27,b.NGAY28,b.NGAY29,b.NGAY30,b.NGAY31 FROM CHAMCONG AS a, CHITIETCHAMCONG AS b Where a.MACHAMCONG=b.MACHAMCONG and a.MANV=b.MANV";
            tblCC = functions.GetDataToTable(sql); //lấy dữ liệu
            dgvCC.DataSource = tblCC;

            dgvCC.Columns[0].HeaderText = "Mã Chấm Công";
            dgvCC.Columns[1].HeaderText = "Mã Nhân Viên";
            dgvCC.Columns[2].HeaderText = "Tháng";
            dgvCC.Columns[3].HeaderText = "Năm";
            dgvCC.Columns[4].HeaderText = "Số Ngày Công";
            dgvCC.Columns[5].HeaderText = "Số Ngày Nghỉ ";
            dgvCC.Columns[6].HeaderText = "Số Giờ Tăng ca";
            dgvCC.Columns[7].HeaderText = "Nội Dung Nghỉ";
            dgvCC.Columns[8].HeaderText = "Xếp Loại";
       

            dgvCC.Columns[0].Width = 100;
            dgvCC.Columns[1].Width = 100;
            dgvCC.Columns[2].Width = 100;
            dgvCC.Columns[3].Width = 100;
            dgvCC.Columns[4].Width = 100;
            dgvCC.Columns[5].Width = 100;
            dgvCC.Columns[6].Width = 100;
            dgvCC.Columns[7].Width = 100;
            dgvCC.Columns[8].Width = 100;

            dgvCC.AllowUserToAddRows = false;
            dgvCC.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        public void LoadDataGridViewThang()
        {
            string sql;
            sql = "SELECT distinct a.*,b.NGAY1,b.NGAY2,b.NGAY3,b.NGAY4,b.NGAY5,b.NGAY6,b.NGAY7,b.NGAY8,b.NGAY9,b.NGAY10,b.NGAY11,b.NGAY12,b.NGAY13,b.NGAY14,b.NGAY15,b.NGAY16,b.NGAY17,b.NGAY18,b.NGAY19,b.NGAY20,b.NGAY21,b.NGAY22,b.NGAY23,b.NGAY24,b.NGAY25,b.NGAY26,b.NGAY27,b.NGAY28,b.NGAY29,b.NGAY30,b.NGAY31 FROM CHAMCONG AS a, CHITIETCHAMCONG AS b Where a.MACHAMCONG=b.MACHAMCONG and a.MANV=b.MANV and a.MACHAMCONG='"+txtMaChamCong.Text+"'";
            tblCC = functions.GetDataToTable(sql); //lấy dữ liệu
            dgvCC.DataSource = tblCC;

            dgvCC.Columns[0].HeaderText = "Mã Chấm Công";
            dgvCC.Columns[1].HeaderText = "Mã Nhân Viên";
            dgvCC.Columns[2].HeaderText = "Tháng";
            dgvCC.Columns[3].HeaderText = "Năm";
            dgvCC.Columns[4].HeaderText = "Số Ngày Công";
            dgvCC.Columns[5].HeaderText = "Số Ngày Nghỉ ";
            dgvCC.Columns[6].HeaderText = "Số Giờ Tăng ca";
            dgvCC.Columns[7].HeaderText = "Nội Dung Nghỉ";
            dgvCC.Columns[8].HeaderText = "Xếp Loại";


            dgvCC.Columns[0].Width = 100;
            dgvCC.Columns[1].Width = 100;
            dgvCC.Columns[2].Width = 100;
            dgvCC.Columns[3].Width = 100;
            dgvCC.Columns[4].Width = 100;
            dgvCC.Columns[5].Width = 100;
            dgvCC.Columns[6].Width = 100;
            dgvCC.Columns[7].Width = 100;
            dgvCC.Columns[8].Width = 100;

            dgvCC.AllowUserToAddRows = false;
            dgvCC.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void ChamCong_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
          
        }

        private void dgvCC_DoubleClick(object sender, EventArgs e)
        {
            if (tblCC.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            txtMaChamCong.Text = dgvCC.CurrentRow.Cells["MACHAMCONG"].Value.ToString();
            cboMaNV.Text = dgvCC.CurrentRow.Cells["MANV"].Value.ToString();
            string sql = "SELECT HOTENNV From NHANVIEN where MANV='" + cboMaNV.Text+"'";
            txtTenNhanVien.Text = functions.GetFieldValues(sql);
            //cboSoGioTangCa.Text = dgvCC.CurrentRow.Cells["SOGIOTANGCA"].Value.ToString();
            txtNoiDungNghi.Text = dgvCC.CurrentRow.Cells["NOIDUNGNGHI"].Value.ToString();
            LoadDataGridViewThang();
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = true;
            btnThem.Enabled = false;
        }
        private void ResetValues()
        {
            txtMaChamCong.Text = "";
            cboMaNV.Text = "";
            
            cboNam.Text = "";
            cboThang.Text = "";
            txtNoiDungNghi.Text = "";
            cboSoGioTangCa.Text = "";
            cboTinhTrang.Text = "";
           
           
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str;
            if (cboMaNV.Text == "")
            {
                txtTenNV.Text = "";
            }
            //Khi chọn Mã Nhân viên thì các thông tin của khách hàng sẽ hiện ra
            str = "Select HOTENNV from NHANVIEN where MANV=N'" + cboMaNV.Text + "'";
            cboMaNV.Text = functions.GetFieldValues(str);

        }
        private void DemNgayCong()
        {
            string sql;
            int tong;
            int a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16, a17, a18, a19, a20, a21, a22, a23, a24, a25, a26, a27, a28, a29, a30, a31;
            sql = "SELECT NGAY1 From CHITIETCHAMCONG WHERE MANV='" + cboMaNV.Text+"'and MACHAMCONG='"+txtMaChamCong.Text+"'";
            if (functions.GetFieldValues(sql) == "Có Đi Làm")
            {
                a1 = 1;
            }
            else a1 = 0;
            sql = "SELECT NGAY2 From CHITIETCHAMCONG WHERE MANV='" + cboMaNV.Text + "'and MACHAMCONG='" + txtMaChamCong.Text + "'";
            if (functions.GetFieldValues(sql) == "Có Đi Làm")
            {
                a2 = 1;
            }
            else a2 = 0;
            sql = "SELECT NGAY3 From CHITIETCHAMCONG WHERE MANV='" + cboMaNV.Text + "'and MACHAMCONG='" + txtMaChamCong.Text + "'";
            if (functions.GetFieldValues(sql) == "Có Đi Làm")
            {
                a3 = 1;
            }
            else a3 = 0;
            sql = "SELECT NGAY4 From CHITIETCHAMCONG WHERE MANV='" + cboMaNV.Text + "'and MACHAMCONG='" + txtMaChamCong.Text + "'";
            if (functions.GetFieldValues(sql) == "Có Đi Làm")
            {
                a4 = 1;
            }
            else a4 = 0;
            sql = "SELECT NGAY5 From CHITIETCHAMCONG WHERE MANV='" + cboMaNV.Text + "'and MACHAMCONG='" + txtMaChamCong.Text + "'";
            if (functions.GetFieldValues(sql) == "Có Đi Làm")
            {
                a5 = 1;
            }
            else a5 = 0;
            sql = "SELECT NGAY6 From CHITIETCHAMCONG WHERE MANV='" + cboMaNV.Text + "'and MACHAMCONG='" + txtMaChamCong.Text + "'";
            if (functions.GetFieldValues(sql) == "Có Đi Làm")
            {
                a6 = 1;
            }
            else a6 = 0;
            sql = "SELECT NGAY7 From CHITIETCHAMCONG WHERE MANV='" + cboMaNV.Text + "'and MACHAMCONG='" + txtMaChamCong.Text + "'";
            if (functions.GetFieldValues(sql) == "Có Đi Làm")
            {
                a7 = 1;
            }
            else a7 = 0;
            sql = "SELECT NGAY8 From CHITIETCHAMCONG WHERE MANV='" + cboMaNV.Text + "'and MACHAMCONG='" + txtMaChamCong.Text + "'";
            if (functions.GetFieldValues(sql) == "Có Đi Làm")
            {
                a8 = 1;
            }
            else a8 = 0;
            sql = "SELECT NGAY9 From CHITIETCHAMCONG WHERE MANV='" + cboMaNV.Text + "'and MACHAMCONG='" + txtMaChamCong.Text + "'";
            if (functions.GetFieldValues(sql) == "Có Đi Làm")
            {
                a9 = 1;
            }
            else a9 = 0;
            sql = "SELECT NGAY10 From CHITIETCHAMCONG WHERE MANV='" + cboMaNV.Text + "'and MACHAMCONG='" + txtMaChamCong.Text + "'";
            if (functions.GetFieldValues(sql) == "Có Đi Làm")
            {
                a10 = 1;
            }
            else a10 = 0;
            sql = "SELECT NGAY11 From CHITIETCHAMCONG WHERE MANV='" + cboMaNV.Text + "'and MACHAMCONG='" + txtMaChamCong.Text + "'";
            if (functions.GetFieldValues(sql) == "Có Đi Làm")
            {
                a11 = 1;
            }
            else a11 = 0;
            sql = "SELECT NGAY12 From CHITIETCHAMCONG WHERE MANV='" + cboMaNV.Text + "'and MACHAMCONG='" + txtMaChamCong.Text + "'";
            if (functions.GetFieldValues(sql) == "Có Đi Làm")
            {
                a12 = 1;
            }
            else a12 = 0;
            sql = "SELECT NGAY13 From CHITIETCHAMCONG WHERE MANV='" + cboMaNV.Text + "'and MACHAMCONG='" + txtMaChamCong.Text + "'";
            if (functions.GetFieldValues(sql) == "Có Đi Làm")
            {
                a13 = 1;
            }
            else a13 = 0;
            sql = "SELECT NGAY14 From CHITIETCHAMCONG WHERE MANV='" + cboMaNV.Text + "'and MACHAMCONG='" + txtMaChamCong.Text + "'";
            if (functions.GetFieldValues(sql) == "Có Đi Làm")
            {
                a14 = 1;
            }
            else a14= 0;
            sql = "SELECT NGAY15 From CHITIETCHAMCONG WHERE MANV='" + cboMaNV.Text + "'and MACHAMCONG='" + txtMaChamCong.Text + "'";
            if (functions.GetFieldValues(sql) == "Có Đi Làm")
            {
                a15 = 1;
            }
            else a15 = 0;
            sql = "SELECT NGAY16 From CHITIETCHAMCONG WHERE MANV='" + cboMaNV.Text + "'and MACHAMCONG='" + txtMaChamCong.Text + "'";
            if (functions.GetFieldValues(sql) == "Có Đi Làm")
            {
                a16 = 1;
            }
            else a16 = 0;
            sql = "SELECT NGAY17 From CHITIETCHAMCONG WHERE MANV='" + cboMaNV.Text + "'and MACHAMCONG='" + txtMaChamCong.Text + "'";
            if (functions.GetFieldValues(sql) == "Có Đi Làm")
            {
                a17 = 1;
            }
            else a17 = 0;
            sql = "SELECT NGAY18 From CHITIETCHAMCONG WHERE MANV='" + cboMaNV.Text + "'and MACHAMCONG='" + txtMaChamCong.Text + "'";
            if (functions.GetFieldValues(sql) == "Có Đi Làm")
            {
                a18 = 1;
            }
            else a18 = 0;
            sql = "SELECT NGAY19 From CHITIETCHAMCONG WHERE MANV='" + cboMaNV.Text + "'and MACHAMCONG='" + txtMaChamCong.Text + "'";
            if (functions.GetFieldValues(sql) == "Có Đi Làm")
            {
                a19 = 1;
            }
            else a19 = 0;
            sql = "SELECT NGAY20 From CHITIETCHAMCONG WHERE MANV='" + cboMaNV.Text + "'and MACHAMCONG='" + txtMaChamCong.Text + "'";
            if (functions.GetFieldValues(sql) == "Có Đi Làm")
            {
                a20 = 1;
            }
            else a20 = 0;
            sql = "SELECT NGAY21 From CHITIETCHAMCONG WHERE MANV='" + cboMaNV.Text + "'and MACHAMCONG='" + txtMaChamCong.Text + "'";
            if (functions.GetFieldValues(sql) == "Có Đi Làm")
            {
                a21 = 1;
            }
            else a21 = 0;
            sql = "SELECT NGAY22 From CHITIETCHAMCONG WHERE MANV='" + cboMaNV.Text + "'and MACHAMCONG='" + txtMaChamCong.Text + "'";
            if (functions.GetFieldValues(sql) == "Có Đi Làm")
            {
                a22 = 1;
            }
            else a22 = 0;
            sql = "SELECT NGAY23 From CHITIETCHAMCONG WHERE MANV='" + cboMaNV.Text + "'and MACHAMCONG='" + txtMaChamCong.Text + "'";
            if (functions.GetFieldValues(sql) == "Có Đi Làm")
            {
                a23 = 1;
            }
            else a23 = 0;
            sql = "SELECT NGAY24 From CHITIETCHAMCONG WHERE MANV='" + cboMaNV.Text + "'and MACHAMCONG='" + txtMaChamCong.Text + "'";
            if (functions.GetFieldValues(sql) == "Có Đi Làm")
            {
                a24 = 1;
            }
            else a24 = 0;
            sql = "SELECT NGAY25 From CHITIETCHAMCONG WHERE MANV='" + cboMaNV.Text + "'and MACHAMCONG='" + txtMaChamCong.Text + "'";
            if (functions.GetFieldValues(sql) == "Có Đi Làm")
            {
                a25 = 1;
            }
            else a25 = 0;
            sql = "SELECT NGAY26 From CHITIETCHAMCONG WHERE MANV='" + cboMaNV.Text + "'and MACHAMCONG='" + txtMaChamCong.Text + "'";
            if (functions.GetFieldValues(sql) == "Có Đi Làm")
            {
                a26 = 1;
            }
            else a26 = 0;
            sql = "SELECT NGAY27 From CHITIETCHAMCONG WHERE MANV='" + cboMaNV.Text + "'and MACHAMCONG='" + txtMaChamCong.Text + "'";
            if (functions.GetFieldValues(sql) == "Có Đi Làm")
            {
                a27 = 1;
            }
            else a27 = 0;
            sql = "SELECT NGAY28 From CHITIETCHAMCONG WHERE MANV='" + cboMaNV.Text + "'and MACHAMCONG='" + txtMaChamCong.Text + "'";
            if (functions.GetFieldValues(sql) == "Có Đi Làm")
            {
                a28 = 1;
            }
            else a28= 0;
            sql = "SELECT NGAY29 From CHITIETCHAMCONG WHERE MANV='" + cboMaNV.Text + "'and MACHAMCONG='" + txtMaChamCong.Text + "'";
            if (functions.GetFieldValues(sql) == "Có Đi Làm")
            {
                a29 = 1;
            }
            else a29 = 0;
            sql = "SELECT NGAY30 From CHITIETCHAMCONG WHERE MANV='" + cboMaNV.Text + "'and MACHAMCONG='" + txtMaChamCong.Text + "'";
            if (functions.GetFieldValues(sql) == "Có Đi Làm")
            {
                a30 = 1;
            }
            else a30 = 0;
            sql = "SELECT NGAY31 From CHITIETCHAMCONG WHERE MANV='" + cboMaNV.Text + "'and MACHAMCONG='" + txtMaChamCong.Text + "'";
            if (functions.GetFieldValues(sql) == "Có Đi Làm")
            {
                a31 = 1;
            }
            else a31 = 0;
            tong = a1 + a2+ a3+a4+a5+a6+a7+a8+a9+a10+a11+a12+a13+a14+a15+a16+a17+a18+a19+a20+a21+a22+a23+a24+a25+a26+a27+a28+a29+a30+a31;
            
            sql = "Update CHAMCONG SET SONGAYCONG='" + tong.ToString() + "'Where MACHAMCONG='" + txtMaChamCong.Text+ "'and MANV='" + cboMaNV.Text+"'";
            functions.RunSQL(sql);
           
        }
        private void DemNgayNghi()
        {
            string sql;
            int tong;
            int a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16, a17, a18, a19, a20, a21, a22, a23, a24, a25, a26, a27, a28, a29, a30, a31;
            sql = "SELECT NGAY1 From CHITIETCHAMCONG WHERE MANV='" + cboMaNV.Text + "'and MACHAMCONG='" + txtMaChamCong.Text + "'";
            if (functions.GetFieldValues(sql) == "Không Đi Làm")
            {
                a1 = 1;
            }
            else a1 = 0;
            sql = "SELECT NGAY2 From CHITIETCHAMCONG WHERE MANV='" + cboMaNV.Text + "'and MACHAMCONG='" + txtMaChamCong.Text + "'";
            if (functions.GetFieldValues(sql) == "Không Đi Làm")
            {
                a2 = 1;
            }
            else a2 = 0;
            sql = "SELECT NGAY3 From CHITIETCHAMCONG WHERE MANV='" + cboMaNV.Text + "'and MACHAMCONG='" + txtMaChamCong.Text + "'";
            if (functions.GetFieldValues(sql) == "Không Đi Làm")
            {
                a3 = 1;
            }
            else a3 = 0;
            sql = "SELECT NGAY4 From CHITIETCHAMCONG WHERE MANV='" + cboMaNV.Text + "'and MACHAMCONG='" + txtMaChamCong.Text + "'";
            if (functions.GetFieldValues(sql) == "Không Đi Làm")
            {
                a4 = 1;
            }
            else a4 = 0;
            sql = "SELECT NGAY5 From CHITIETCHAMCONG WHERE MANV='" + cboMaNV.Text + "'and MACHAMCONG='" + txtMaChamCong.Text + "'";
            if (functions.GetFieldValues(sql) == "Không Đi Làm")
            {
                a5 = 1;
            }
            else a5 = 0;
            sql = "SELECT NGAY6 From CHITIETCHAMCONG WHERE MANV='" + cboMaNV.Text + "'and MACHAMCONG='" + txtMaChamCong.Text + "'";
            if (functions.GetFieldValues(sql) == "Không Đi Làm")
            {
                a6 = 1;
            }
            else a6 = 0;
            sql = "SELECT NGAY7 From CHITIETCHAMCONG WHERE MANV='" + cboMaNV.Text + "'and MACHAMCONG='" + txtMaChamCong.Text + "'";
            if (functions.GetFieldValues(sql) == "Không Đi Làm")
            {
                a7 = 1;
            }
            else a7 = 0;
            sql = "SELECT NGAY8 From CHITIETCHAMCONG WHERE MANV='" + cboMaNV.Text + "'and MACHAMCONG='" + txtMaChamCong.Text + "'";
            if (functions.GetFieldValues(sql) == "Không Đi Làm")
            {
                a8 = 1;
            }
            else a8 = 0;
            sql = "SELECT NGAY9 From CHITIETCHAMCONG WHERE MANV='" + cboMaNV.Text + "'and MACHAMCONG='" + txtMaChamCong.Text + "'";
            if (functions.GetFieldValues(sql) == "Không Đi Làm")
            {
                a9 = 1;
            }
            else a9 = 0;
            sql = "SELECT NGAY10 From CHITIETCHAMCONG WHERE MANV='" + cboMaNV.Text + "'and MACHAMCONG='" + txtMaChamCong.Text + "'";
            if (functions.GetFieldValues(sql) == "Không Đi Làm")
            {
                a10 = 1;
            }
            else a10 = 0;
            sql = "SELECT NGAY11 From CHITIETCHAMCONG WHERE MANV='" + cboMaNV.Text + "'and MACHAMCONG='" + txtMaChamCong.Text + "'";
            if (functions.GetFieldValues(sql) == "Không Đi Làm")
            {
                a11 = 1;
            }
            else a11 = 0;
            sql = "SELECT NGAY12 From CHITIETCHAMCONG WHERE MANV='" + cboMaNV.Text + "'and MACHAMCONG='" + txtMaChamCong.Text + "'";
            if (functions.GetFieldValues(sql) == "Không Đi Làm")
            {
                a12 = 1;
            }
            else a12 = 0;
            sql = "SELECT NGAY13 From CHITIETCHAMCONG WHERE MANV='" + cboMaNV.Text + "'and MACHAMCONG='" + txtMaChamCong.Text + "'";
            if (functions.GetFieldValues(sql) == "Không Đi Làm")
            {
                a13 = 1;
            }
            else a13 = 0;
            sql = "SELECT NGAY14 From CHITIETCHAMCONG WHERE MANV='" + cboMaNV.Text + "'and MACHAMCONG='" + txtMaChamCong.Text + "'";
            if (functions.GetFieldValues(sql) == "Không Đi Làm")
            {
                a14 = 1;
            }
            else a14 = 0;
            sql = "SELECT NGAY15 From CHITIETCHAMCONG WHERE MANV='" + cboMaNV.Text + "'and MACHAMCONG='" + txtMaChamCong.Text + "'";
            if (functions.GetFieldValues(sql) == "Không Đi Làm")
            {
                a15 = 1;
            }
            else a15 = 0;
            sql = "SELECT NGAY16 From CHITIETCHAMCONG WHERE MANV='" + cboMaNV.Text + "'and MACHAMCONG='" + txtMaChamCong.Text + "'";
            if (functions.GetFieldValues(sql) == "Không Đi Làm")
            {
                a16 = 1;
            }
            else a16 = 0;
            sql = "SELECT NGAY17 From CHITIETCHAMCONG WHERE MANV='" + cboMaNV.Text + "'and MACHAMCONG='" + txtMaChamCong.Text + "'";
            if (functions.GetFieldValues(sql) == "Không Đi Làm")
            {
                a17 = 1;
            }
            else a17 = 0;
            sql = "SELECT NGAY18 From CHITIETCHAMCONG WHERE MANV='" + cboMaNV.Text + "'and MACHAMCONG='" + txtMaChamCong.Text + "'";
            if (functions.GetFieldValues(sql) == "Không Đi Làm")
            {
                a18 = 1;
            }
            else a18 = 0;
            sql = "SELECT NGAY19 From CHITIETCHAMCONG WHERE MANV='" + cboMaNV.Text + "'and MACHAMCONG='" + txtMaChamCong.Text + "'";
            if (functions.GetFieldValues(sql) == "Không Đi Làm")
            {
                a19 = 1;
            }
            else a19 = 0;
            sql = "SELECT NGAY20 From CHITIETCHAMCONG WHERE MANV='" + cboMaNV.Text + "'and MACHAMCONG='" + txtMaChamCong.Text + "'";
            if (functions.GetFieldValues(sql) == "Không Đi Làm")
            {
                a20 = 1;
            }
            else a20 = 0;
            sql = "SELECT NGAY21 From CHITIETCHAMCONG WHERE MANV='" + cboMaNV.Text + "'and MACHAMCONG='" + txtMaChamCong.Text + "'";
            if (functions.GetFieldValues(sql) == "Không Đi Làm")
            {
                a21 = 1;
            }
            else a21 = 0;
            sql = "SELECT NGAY22 From CHITIETCHAMCONG WHERE MANV='" + cboMaNV.Text + "'and MACHAMCONG='" + txtMaChamCong.Text + "'";
            if (functions.GetFieldValues(sql) == "Không Đi Làm")
            {
                a22 = 1;
            }
            else a22 = 0;
            sql = "SELECT NGAY23 From CHITIETCHAMCONG WHERE MANV='" + cboMaNV.Text + "'and MACHAMCONG='" + txtMaChamCong.Text + "'";
            if (functions.GetFieldValues(sql) == "Không Đi Làm")
            {
                a23 = 1;
            }
            else a23 = 0;
            sql = "SELECT NGAY24 From CHITIETCHAMCONG WHERE MANV='" + cboMaNV.Text + "'and MACHAMCONG='" + txtMaChamCong.Text + "'";
            if (functions.GetFieldValues(sql) == "Không Đi Làm")
            {
                a24 = 1;
            }
            else a24 = 0;
            sql = "SELECT NGAY25 From CHITIETCHAMCONG WHERE MANV='" + cboMaNV.Text + "'and MACHAMCONG='" + txtMaChamCong.Text + "'";
            if (functions.GetFieldValues(sql) == "Không Đi Làm")
            {
                a25 = 1;
            }
            else a25 = 0;
            sql = "SELECT NGAY26 From CHITIETCHAMCONG WHERE MANV='" + cboMaNV.Text + "'and MACHAMCONG='" + txtMaChamCong.Text + "'";
            if (functions.GetFieldValues(sql) == "Không Đi Làm")
            {
                a26 = 1;
            }
            else a26 = 0;
            sql = "SELECT NGAY27 From CHITIETCHAMCONG WHERE MANV='" + cboMaNV.Text + "'and MACHAMCONG='" + txtMaChamCong.Text + "'";
            if (functions.GetFieldValues(sql) == "Không Đi Làm")
            {
                a27 = 1;
            }
            else a27 = 0;
            sql = "SELECT NGAY28 From CHITIETCHAMCONG WHERE MANV='" + cboMaNV.Text + "'and MACHAMCONG='" + txtMaChamCong.Text + "'";
            if (functions.GetFieldValues(sql) == "Không Đi Làm")
            {
                a28 = 1;
            }
            else a28 = 0;
            sql = "SELECT NGAY29 From CHITIETCHAMCONG WHERE MANV='" + cboMaNV.Text + "'and MACHAMCONG='" + txtMaChamCong.Text + "'";
            if (functions.GetFieldValues(sql) == "Không Đi Làm")
            {
                a29 = 1;
            }
            else a29 = 0;
            sql = "SELECT NGAY30 From CHITIETCHAMCONG WHERE MANV='" + cboMaNV.Text + "'and MACHAMCONG='" + txtMaChamCong.Text + "'";
            if (functions.GetFieldValues(sql) == "Không Đi Làm")
            {
                a30 = 1;
            }
            else a30 = 0;
            sql = "SELECT NGAY31 From CHITIETCHAMCONG WHERE MANV='" + cboMaNV.Text + "'and MACHAMCONG='" + txtMaChamCong.Text + "'";
            if (functions.GetFieldValues(sql) == "Không Đi Làm")
            {
                a31 = 1;
            }
            else a31 = 0;
            tong = a1 + a2 + a3 + a4 + a5 + a6 + a7 + a8 + a9 + a10 + a11 + a12 + a13 + a14 + a15 + a16 + a17 + a18 + a19 + a20 + a21 + a22 + a23 + a24 + a25 + a26 + a27 + a28 + a29 + a30 + a31;

            sql = "Update CHAMCONG SET SONGAYNGHI='" + tong.ToString() + "'Where MACHAMCONG='" + txtMaChamCong.Text + "'and MANV='" + cboMaNV.Text + "'";
            functions.RunSQL(sql);

        }
        private void Xeploai()
        {
            string sql;
            float a;
            sql = "SELECT SONGAYCONG From CHAMCONG Where MACHAMCONG='"+txtMaChamCong.Text+"' and MANV='"+cboMaNV.Text+"' ";
            functions.GetFieldValues(sql);
            a = float.Parse(functions.GetFieldValues(sql));
            if (a <= 10 )
            {
                sql = "UPDATE CHAMCONG SET XEPLOAI=N'Kém' where MACHAMCONG='"+txtMaChamCong.Text+"' and MANV='"+cboMaNV.Text+"'";
                functions.RunSQL(sql);
            }
            else if (a >10 && a<=15 )
            {
                sql = "UPDATE CHAMCONG SET XEPLOAI=N'Trung bình' where MACHAMCONG='" + txtMaChamCong.Text + "' and MANV='" + cboMaNV.Text + "'";
                functions.RunSQL(sql);
            }
            else if (a > 15 && a <= 20)
            {
                sql = "UPDATE CHAMCONG SET XEPLOAI=N'Khá' where MACHAMCONG='" + txtMaChamCong.Text + "' and MANV='" + cboMaNV.Text + "'";
                functions.RunSQL(sql);
            }
            else if (a > 20 )
            {
                sql = "UPDATE CHAMCONG SET XEPLOAI=N'Tốt' where MACHAMCONG='" + txtMaChamCong.Text + "' and MANV='" + cboMaNV.Text + "'";
                functions.RunSQL(sql);
            }
            else if (a >= 26 )
            {
                sql = "UPDATE CHAMCONG SET XEPLOAI=N'Xuất Sắc' where MACHAMCONG='" + txtMaChamCong.Text + "' and MANV='" + cboMaNV.Text + "'";
                functions.RunSQL(sql);
            }
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
            string sql;
            if (cboNgay.Text == "Ngày 1")
            {
                sql = "UPDATE CHITIETCHAMCONG SET NGAY1=N'" + cboTinhTrang.Text + "' where MANV=N'" + cboMaNV.Text + "' AND MACHAMCONG=N'" + txtMaChamCong.Text + "'";
                functions.RunSQL(sql);
            }
            else if (cboNgay.Text == "Ngày 2")
            {
                sql = "UPDATE CHITIETCHAMCONG SET NGAY2=N'" + cboTinhTrang.Text + "'where MANV=N'" + cboMaNV.Text + "'AND MACHAMCONG=N'" + txtMaChamCong.Text + "'";
                functions.RunSQL(sql);
            }
            else if (cboNgay.Text == "Ngày 3")
            {
                sql = "UPDATE CHITIETCHAMCONG SET NGAY3=N'" + cboTinhTrang.Text + "'where MANV=N'" + cboMaNV.Text + "'AND MACHAMCONG=N'" + txtMaChamCong.Text + "'";
                functions.RunSQL(sql);
            }
            else if (cboNgay.Text == "Ngày 4")
            {
                sql = "UPDATE CHITIETCHAMCONG SET NGAY4=N'" + cboTinhTrang.Text + "'where MANV=N'" + cboMaNV.Text + "'AND MACHAMCONG=N'" + txtMaChamCong.Text + "'";
                functions.RunSQL(sql);
            }
            else if (cboNgay.Text == "Ngày 5")
            {
                sql = "UPDATE CHITIETCHAMCONG SET NGAY5=N'" + cboTinhTrang.Text + "'where MANV=N'" + cboMaNV.Text + "'AND MACHAMCONG=N'" + txtMaChamCong.Text + "'";
                functions.RunSQL(sql);
            }
            else if (cboNgay.Text == "Ngày 6")
            {
                sql = "UPDATE CHITIETCHAMCONG SET NGAY6=N'" + cboTinhTrang.Text + "'where MANV=N'" + cboMaNV.Text + "'AND MACHAMCONG=N'" + txtMaChamCong.Text + "'";
                functions.RunSQL(sql);
            }
            else if (cboNgay.Text == "Ngày 7")
            {
                sql = "UPDATE CHITIETCHAMCONG SET NGAY7=N'" + cboTinhTrang.Text + "'where MANV=N'" + cboMaNV.Text + "'AND MACHAMCONG=N'" + txtMaChamCong.Text + "'";
                functions.RunSQL(sql);
            }
            else if (cboNgay.Text == "Ngày 8")
            {
                sql = "UPDATE CHITIETCHAMCONG SET NGAY8=N'" + cboTinhTrang.Text + "'where MANV=N'" + cboMaNV.Text + "'AND MACHAMCONG=N'" + txtMaChamCong.Text + "'";
                functions.RunSQL(sql);
            }
            else if (cboNgay.Text == "Ngày 9")
            {
                sql = "UPDATE CHITIETCHAMCONG SET NGAY9=N'" + cboTinhTrang.Text + "'where MANV=N'" + cboMaNV.Text + "'AND MACHAMCONG=N'" + txtMaChamCong.Text + "'";
                functions.RunSQL(sql);
            }
            else if (cboNgay.Text == "Ngày 10")
            {
                sql = "UPDATE CHITIETCHAMCONG SET NGAY10=N'" + cboTinhTrang.Text + "'where MANV=N'" + cboMaNV.Text + "'AND MACHAMCONG=N'" + txtMaChamCong.Text + "'";
                functions.RunSQL(sql);
            }
            else if (cboNgay.Text == "Ngày 11")
            {
                sql = "UPDATE CHITIETCHAMCONG SET NGAY11=N'" + cboTinhTrang.Text + "'where MANV=N'" + cboMaNV.Text + "'AND MACHAMCONG=N'" + txtMaChamCong.Text + "'";
                functions.RunSQL(sql);
            }
            else if (cboNgay.Text == "Ngày 12")
            {
                sql = "UPDATE CHITIETCHAMCONG SET NGAY12=N'" + cboTinhTrang.Text + "'where MANV=N'" + cboMaNV.Text + "'AND MACHAMCONG=N'" + txtMaChamCong.Text + "'";
                functions.RunSQL(sql);
            }
            else if (cboNgay.Text == "Ngày 13")
            {
                sql = "UPDATE CHITIETCHAMCONG SET NGAY13=N'" + cboTinhTrang.Text + "'where MANV=N'" + cboMaNV.Text + "'AND MACHAMCONG=N'" + txtMaChamCong.Text + "'";
                functions.RunSQL(sql);
            }
            else if (cboNgay.Text == "Ngày 14")
            {
                sql = "UPDATE CHITIETCHAMCONG SET NGAY14=N'" + cboTinhTrang.Text + "'where MANV=N'" + cboMaNV.Text + "'AND MACHAMCONG=N'" + txtMaChamCong.Text + "'";
                functions.RunSQL(sql);
            }
            else if (cboNgay.Text == "Ngày 15")
            {
                sql = "UPDATE CHITIETCHAMCONG SET NGAY15=N'" + cboTinhTrang.Text + "'where MANV=N'" + cboMaNV.Text + "'AND MACHAMCONG=N'" + txtMaChamCong.Text + "'";
                functions.RunSQL(sql);
            }
            else if (cboNgay.Text == "Ngày 16")
            {
                sql = "UPDATE CHITIETCHAMCONG SET NGAY16=N'" + cboTinhTrang.Text + "'where MANV=N'" + cboMaNV.Text + "'AND MACHAMCONG=N'" + txtMaChamCong.Text + "'";
                functions.RunSQL(sql);
            }
            else if (cboNgay.Text == "Ngày 17")
            {
                sql = "UPDATE CHITIETCHAMCONG SET NGAY17=N'" + cboTinhTrang.Text + "'where MANV=N'" + cboMaNV.Text + "'AND MACHAMCONG=N'" + txtMaChamCong.Text + "'";
                functions.RunSQL(sql);
            }
            else if (cboNgay.Text == "Ngày 18")
            {
                sql = "UPDATE CHITIETCHAMCONG SET NGAY18=N'" + cboTinhTrang.Text + "'where MANV=N'" + cboMaNV.Text + "'AND MACHAMCONG=N'" + txtMaChamCong.Text + "'";
                functions.RunSQL(sql);
            }
            else if (cboNgay.Text == "Ngày 19")
            {
                sql = "UPDATE CHITIETCHAMCONG SET NGAY19=N'" + cboTinhTrang.Text + "'where MANV=N'" + cboMaNV.Text + "'AND MACHAMCONG=N'" + txtMaChamCong.Text + "'";
                functions.RunSQL(sql);
            }
            else if (cboNgay.Text == "Ngày 20")
            {
                sql = "UPDATE CHITIETCHAMCONG SET NGAY20=N'" + cboTinhTrang.Text + "'where MANV=N'" + cboMaNV.Text + "'AND MACHAMCONG=N'" + txtMaChamCong.Text + "'";
                functions.RunSQL(sql);
            }
            else if (cboNgay.Text == "Ngày 21")
            {
                sql = "UPDATE CHITIETCHAMCONG SET NGAY21=N'" + cboTinhTrang.Text + "'where MANV=N'" + cboMaNV.Text + "'AND MACHAMCONG=N'" + txtMaChamCong.Text + "'";
                functions.RunSQL(sql);
            }
            else if (cboNgay.Text == "Ngày 22")
            {
                sql = "UPDATE CHITIETCHAMCONG SET NGAY22=N'" + cboTinhTrang.Text + "'where MANV=N'" + cboMaNV.Text + "'AND MACHAMCONG=N'" + txtMaChamCong.Text + "'";
                functions.RunSQL(sql);
            }
            else if (cboNgay.Text == "Ngày 23")
            {
                sql = "UPDATE CHITIETCHAMCONG SET NGAY23=N'" + cboTinhTrang.Text + "'where MANV=N'" + cboMaNV.Text + "'AND MACHAMCONG=N'" + txtMaChamCong.Text + "'";
                functions.RunSQL(sql);
            }
            else if (cboNgay.Text == "Ngày 24")
            {
                sql = "UPDATE CHITIETCHAMCONG SET NGAY24=N'" + cboTinhTrang.Text + "'where MANV=N'" + cboMaNV.Text + "'AND MACHAMCONG=N'" + txtMaChamCong.Text + "'";
                functions.RunSQL(sql);
            }
            else if (cboNgay.Text == "Ngày 25")
            {
                sql = "UPDATE CHITIETCHAMCONG SET NGAY25=N'" + cboTinhTrang.Text + "'where MANV=N'" + cboMaNV.Text + "'AND MACHAMCONG=N'" + txtMaChamCong.Text + "'";
                functions.RunSQL(sql);
            }

            else if (cboNgay.Text == "Ngày 26")
            {
                sql = "UPDATE CHITIETCHAMCONG SET NGAY26=N'" + cboTinhTrang.Text + "'where MANV=N'" + cboMaNV.Text + "'AND MACHAMCONG=N'" + txtMaChamCong.Text + "'";
                functions.RunSQL(sql);
            }
            else if (cboNgay.Text == "Ngày 27")
            {
                sql = "UPDATE CHITIETCHAMCONG SET NGAY27=N'" + cboTinhTrang.Text + "'where MANV=N'" + cboMaNV.Text + "'AND MACHAMCONG=N'" + txtMaChamCong.Text + "'";
                functions.RunSQL(sql);
            }
            else if (cboNgay.Text == "Ngày 28")
            {
                sql = "UPDATE CHITIETCHAMCONG SET NGAY28=N'" + cboTinhTrang.Text + "'where MANV=N'" + cboMaNV.Text + "'AND MACHAMCONG=N'" + txtMaChamCong.Text + "'";

                functions.RunSQL(sql);
            }
            else if (cboNgay.Text == "Ngày 29")
            {
                sql = "UPDATE CHITIETCHAMCONG SET NGAY29=N'" + cboTinhTrang.Text + "'where MANV=N'" + cboMaNV.Text + "'AND MACHAMCONG=N'" + txtMaChamCong.Text + "'";
                functions.RunSQL(sql);
            }
            else if (cboNgay.Text == "Ngày 30")
            {
                sql = "UPDATE CHITIETCHAMCONG SET NGAY30=N'" + cboTinhTrang.Text + "'where MANV=N'" + cboMaNV.Text + "'AND MACHAMCONG=N'" + txtMaChamCong.Text + "'";
                functions.RunSQL(sql);
            }

            else if (cboNgay.Text == "Ngày 31")
            {
                sql = "UPDATE CHITIETCHAMCONG SET NGAY31=N'" + cboTinhTrang.Text + "'where MANV=N'" + cboMaNV.Text + "'AND MACHAMCONG=N'" + txtMaChamCong.Text + "'";
                functions.RunSQL(sql);
            }

            DemNgayCong();
            DemNgayNghi();
            Xeploai();
            LoadDataGridViewThang();
        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            string sql, gt;
            if (txtMaChamCong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Mã Chấm Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaChamCong.Focus();
                return;
            }
            if (cboThang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Tháng chấm công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboThang.Focus();
                return;
            }
            if (cboNam.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Năm Chấm Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboNam.Focus();
                return;
            }
            sql = " INSERT INTO CHAMCONG(MANV) SELECT MANV From NHANVIEN WHERE TTLV=N'Đang Làm Việc'";
            functions.RunSQL(sql);
            sql = " UPDATE CHAMCONG SET MACHAMCONG='" + txtMaChamCong.Text + "' Where MACHAMCONG is Null";
            functions.RunSQL(sql);
            sql = " UPDATE CHAMCONG SET THANG='" + cboThang.Text + "',NAM='" + cboNam.Text + "' Where MACHAMCONG='" + txtMaChamCong.Text + "'";
            functions.RunSQL(sql);

            sql = " INSERT INTO CHITIETCHAMCONG(MANV) SELECT MANV From CHAMCONG";
            functions.RunSQL(sql);
            sql = " UPDATE CHITIETCHAMCONG SET MACHAMCONG='" + txtMaChamCong.Text + "' Where MACHAMCONG is Null";
            functions.RunSQL(sql);
            LoadDataGridView();
            ResetValues();
        }

        private void btnHuy_Click_1(object sender, EventArgs e)
        {
            LoadDataGridView();
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
