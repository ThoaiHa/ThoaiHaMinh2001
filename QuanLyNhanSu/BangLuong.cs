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
    public partial class BangLuong : Form
    {
        private DataTable tblBL;
        public BangLuong()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void LoadDataGridView()
        {
            string sql;
            sql = "Select a.MALUONG,a.THANG,a.NAM,a.MANV,b.HOTENNV,a.MABH,c.LUONGCB,g.NOIDUNG,e.PHUCAPCHUCVU,a.TONGLUONG from BANGLUONG as a, NHANVIEN as b,BIENDONGTIENLUONG as c,QUATRINHLAMVIEC as d,CHUCVU as e ,KHENTHUONGKYLUAT as g where a.MANV =b.MANV and a.MAQTBDL=c.MALUONG and d.MACHUCVU=e.MACHUCVU and d.MANV=b.MANV and a.MAKTKL=g.MAKTKL";
            tblBL = functions.GetDataToTable(sql);
            dgvbangtinhluong.DataSource = tblBL;
            dgvbangtinhluong.Columns[0].HeaderText = "Mã Lương";
            dgvbangtinhluong.Columns[1].HeaderText = "Tháng";
            dgvbangtinhluong.Columns[2].HeaderText = "Năm";
            dgvbangtinhluong.Columns[3].HeaderText = "Mã Nhân Viên";
            dgvbangtinhluong.Columns[4].HeaderText = "Tên Nhân Viên";
            dgvbangtinhluong.Columns[5].HeaderText = "Mã Bảo Hiểm";
            dgvbangtinhluong.Columns[6].HeaderText = "Lương Cơ Bản";
            dgvbangtinhluong.Columns[7].HeaderText = "Số Tiền Thưởng";
            dgvbangtinhluong.Columns[8].HeaderText = "Phụ Cấp Chức Vụ";
            dgvbangtinhluong.Columns[9].HeaderText = "Tổng Lương";
            dgvbangtinhluong.Columns[0].Width = 150;
            dgvbangtinhluong.Columns[1].Width = 100;
            dgvbangtinhluong.Columns[2].Width = 100;
            dgvbangtinhluong.Columns[3].Width = 150;
            dgvbangtinhluong.Columns[4].Width = 180;
            dgvbangtinhluong.Columns[5].Width = 150;
            dgvbangtinhluong.Columns[6].Width = 150;
            dgvbangtinhluong.Columns[7].Width = 170;
            dgvbangtinhluong.Columns[8].Width = 200;
            dgvbangtinhluong.Columns[9].Width = 227;
            dgvbangtinhluong.AllowUserToAddRows = false;
            dgvbangtinhluong.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        public void LoadDataGridViewThangMoi()
        {
            string sql;
            sql = "Select a.MALUONG,a.THANG,a.NAM,a.MANV,b.HOTENNV,a.MABH,c.LUONGCB,g.NOIDUNG,e.PHUCAPCHUCVU,a.TONGLUONG from BANGLUONG as a, NHANVIEN as b,BIENDONGTIENLUONG as c,QUATRINHLAMVIEC as d,CHUCVU as e ,KHENTHUONGKYLUAT as g where a.MANV =b.MANV and a.MAQTBDL=c.MALUONG and d.MACHUCVU=e.MACHUCVU and d.MANV=b.MANV and a.MAKTKL=g.MAKTKL and a.THANG='"+cboThang.Text+"' and a.NAM='"+cboNam.Text+"'";
            tblBL = functions.GetDataToTable(sql);
            dgvbangtinhluong.DataSource = tblBL;
            dgvbangtinhluong.Columns[0].HeaderText = "Mã Lương";
            dgvbangtinhluong.Columns[1].HeaderText = "Tháng";
            dgvbangtinhluong.Columns[2].HeaderText = "Năm";
            dgvbangtinhluong.Columns[3].HeaderText = "Mã Nhân Viên";
            dgvbangtinhluong.Columns[4].HeaderText = "Tên Nhân Viên";
            dgvbangtinhluong.Columns[5].HeaderText = "Mã Bảo Hiểm";
            dgvbangtinhluong.Columns[6].HeaderText = "Lương Cơ Bản";
            dgvbangtinhluong.Columns[7].HeaderText = "Số Tiền Thưởng";
            dgvbangtinhluong.Columns[8].HeaderText = "Phụ Cấp Chức Vụ";
            dgvbangtinhluong.Columns[9].HeaderText = "Tổng Lương";
            dgvbangtinhluong.Columns[0].Width = 150;
            dgvbangtinhluong.Columns[1].Width = 100;
            dgvbangtinhluong.Columns[2].Width = 100;
            dgvbangtinhluong.Columns[3].Width = 150;
            dgvbangtinhluong.Columns[4].Width = 180;
            dgvbangtinhluong.Columns[5].Width = 150;
            dgvbangtinhluong.Columns[6].Width = 150;
            dgvbangtinhluong.Columns[7].Width = 170;
            dgvbangtinhluong.Columns[8].Width = 200;
            dgvbangtinhluong.Columns[9].Width = 227;
            dgvbangtinhluong.AllowUserToAddRows = false;
            dgvbangtinhluong.EditMode = DataGridViewEditMode.EditProgrammatically;
        }


        private void BangLuong_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
            btnLuu.Enabled = false;
            btnTinhLuong.Enabled = false;
            btnHuy.Enabled = false;
            btnThem.Enabled = true;
            txtMaNV.Enabled = false;
        }

        
        private void Resetvalue()
        {
            txtMaNV.Text = "";
            txtMaLuong.Text = "";
        }
        

        private void dgvbangtinhluong_DoubleClick(object sender, EventArgs e)
        {
            
            btnLuu.Enabled = false;
            btnHuy.Enabled = true;
            btnThem.Enabled = false;
            btnTinhLuong.Enabled = true;
            txtMaLuong.Text = dgvbangtinhluong.CurrentRow.Cells["MALUONG"].Value.ToString();
            txtMaNV.Text =dgvbangtinhluong.CurrentRow.Cells["MANV"].Value.ToString();
            cboThang.Text = dgvbangtinhluong.CurrentRow.Cells["THANG"].Value.ToString();
            cboNam.Text = dgvbangtinhluong.CurrentRow.Cells["NAM"].Value.ToString();
            LoadDataGridViewThangMoi();
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            Resetvalue();
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnThem.Enabled = false;
            btnTinhLuong.Enabled = false;
        }

        private void btnTinhLuong_Click_1(object sender, EventArgs e)
        {
            string sql;
            float a, b, d, g, tong;
            int c, em;
            sql = "select a.LUONGNGAY from BIENDONGTIENLUONG as a,BANGLUONG as b where a.MANV=b.MANV and b.MANV=N'" + txtMaNV.Text + "'";
            a = float.Parse(functions.GetFieldValues(sql));
            sql = "SELECT a.SONGAYCONG FROM CHAMCONG as a,BANGLUONG as b WHERE a.MANV=b.MANV and a.MANV=N'" + txtMaNV.Text + "' AND a.THANG=b.THANG and a.NAM=b.NAM and b.THANG='" + cboThang.Text.Trim().ToString() + "' AND b.NAM ='" + cboNam.Text.Trim().ToString() + "'";
            b = float.Parse(functions.GetFieldValues(sql));
            c = 11;//% thuế bảo hiểm
            sql = "select a.NOIDUNG from KHENTHUONGKYLUAT as a,BANGLUONG as b where a.MANV=b.MANV and b.MANV=N'" + txtMaNV.Text + "'";
            if (functions.GetFieldValues(sql) == "")
            {
                d = 0;
            }
            else
            {
                d = float.Parse(functions.GetFieldValues(sql));
            }
            sql = "select c.PHUCAPCHUCVU from QUATRINHLAMVIEC as a,BANGLUONG as b,CHUCVU as c where a.MANV=b.MANV and a.MACHUCVU=c.MACHUCVU and b.MANV=N'" + txtMaNV.Text + "'";
            g = float.Parse(functions.GetFieldValues(sql));
            tong = (a * b) - (a * b * c / 100) + d + g;
            sql = "Update BANGLUONG Set TONGLUONG=N'" + tong + "' WHERE MALUONG=N'" + txtMaLuong.Text + "' and MANV=N'" + txtMaNV.Text + "'";
            functions.RunSQL(sql);
            LoadDataGridViewThangMoi();
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
            if (cboThang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Tháng Tính Lương", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboThang.Focus();
                return;
            }
            if (cboNam.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Năm tính lương", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboNam.Focus();
                return;
            }
            sql = "INSERT INTO BANGLUONG(MANV,MABH,MAQTBDL,MAKTKL) select distinct b.MANV,b.MABHXH,c.MALUONG,d.MAKTKL from NHANVIEN as b, BIENDONGTIENLUONG as c,KHENTHUONGKYLUAT as d  where c.MANV = b.MANV and b.TTLV = N'Đang Làm Việc' and b.MANV=d.MANV";
            functions.RunSQL(sql);
            sql = "UPDATE BANGLUONG SET MALUONG=N'" + txtMaLuong.Text.Trim() + "' WHERE MALUONG is Null";
            functions.RunSQL(sql);
            sql = "Update BANGLUONG Set THANG=N'" + cboThang.Text + "', NAM=N'" + cboNam.Text + "' Where MALUONG=N'" + txtMaLuong.Text + "'";
            functions.RunSQL(sql);
            MessageBox.Show("Tính lương nhân viên cho thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnThem.Enabled = true;
            btnTinhLuong.Enabled = false;
            LoadDataGridViewThangMoi();
        }

        private void btnHuy_Click_1(object sender, EventArgs e)
        {
            Resetvalue();
            LoadDataGridView();
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnThem.Enabled = true;
            btnTinhLuong.Enabled = false;
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
