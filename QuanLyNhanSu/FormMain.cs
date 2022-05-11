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
    public partial class FormMain : Form
    {
        public bool isThoat = true;
        public FormMain()
        {
            InitializeComponent();
            CustomizeDesig();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            PhanQuyen();
            functions.Connect();
        }
        private void PanelHienThi_Paint(object sender, PaintEventArgs e)
        {

        }
        private void AddFrom(Form f)
        {
            this.PanelHienThi.Controls.Clear();
            f.TopLevel = false;
            f.AutoScroll = true;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            this.PanelHienThi.Controls.Add(f);
            f.Show();
        }
        private void CustomizeDesig()
        {

            panelqlnsSubmenu.Visible = false;
            panelqlccSubmenu.Visible = false;
            panelqllSubmenu.Visible = false;
            panelqlhtSubmenu.Visible = false;
        }
        private void HideSubMenu()
        {

            if (panelqlnsSubmenu.Visible == true)
                panelqlnsSubmenu.Visible = false;
            if (panelqlccSubmenu.Visible == true)
                panelqlccSubmenu.Visible = false;
            if (panelqllSubmenu.Visible == true)
                panelqllSubmenu.Visible = false;
            if (panelqlhtSubmenu.Visible == true)
                panelqlhtSubmenu.Visible = false;
        }
        private void ShowSubMenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                HideSubMenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }

        private void btnqlns_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelqlnsSubmenu);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ThongTinNhanVien f = new ThongTinNhanVien();
            AddFrom(f);
            HideSubMenu();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            PhongBan f = new PhongBan();
            AddFrom(f);
            HideSubMenu();
        }

        private void iconButton25_Click(object sender, EventArgs e)
        {
            ThongTinNhanThan f = new ThongTinNhanThan();
            AddFrom(f);
            HideSubMenu();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            QuaTrinhLamViec f = new QuaTrinhLamViec();
            AddFrom(f);
            HideSubMenu();
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelqlccSubmenu);
        }

        private void iconButton9_Click(object sender, EventArgs e)
        {
            ChamCong f = new ChamCong();
            AddFrom(f);
            HideSubMenu();
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            ChiTietChamCong f = new ChiTietChamCong();
            AddFrom(f);
            HideSubMenu();
        }

        private void iconButton10_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelqllSubmenu);
        }

        private void iconButton14_Click(object sender, EventArgs e)
        {

           BangLuong f = new BangLuong();
            AddFrom(f);
            HideSubMenu();
        }

        private void iconButton13_Click(object sender, EventArgs e)
        {

            BienDongTIenLuong f = new BienDongTIenLuong();
            AddFrom(f);
            HideSubMenu();
        }
        void PhanQuyen()
        {
            switch (Const.TaiKhoan.LoaiTaiKhoan)
            {
                case TaiKhoan.LoaiTK.nhansu:
                    quanlytaikhoan.Enabled = iconButton10.Enabled = iconButton5.Enabled = iconButton19.Enabled = iconButton20.Enabled = false;
                    break;
                case TaiKhoan.LoaiTK.chamcong:
                    quanlytaikhoan.Enabled = iconButton10.Enabled = btnqlns.Enabled = iconButton19.Enabled = iconButton20.Enabled = iconButton21.Enabled = false;
                    break;
                case TaiKhoan.LoaiTK.luong:
                    quanlytaikhoan.Enabled = btnqlns.Enabled = iconButton5.Enabled = false;
                    break;
                
            }
            txt_LoaiTK.Text = Const.TaiKhoan.TenHienThi;
        }

        private void quanlytaikhoan_Click(object sender, EventArgs e)
        {
            quanlytaikhoan f = new quanlytaikhoan();
            AddFrom(f);
            HideSubMenu();
        }
        public event EventHandler DangXuat;
        private void iconButton17_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có muốn đăng xuất hay không?", "Hộp thoại", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                DangXuat(this, new EventArgs());
            }
            HideSubMenu();
        }

        private void iconButton16_Click(object sender, EventArgs e)
        {
            if (isThoat)
                Application.Exit();
            HideSubMenu();
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isThoat)
                Application.Exit();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isThoat)
           {
                if (MessageBox.Show("Bạn có thực sự muốn thoát hay không?", "Hộp thoại", MessageBoxButtons.YesNo) != DialogResult.Yes)

                            e.Cancel = true;
            }
        }

        private void iconButton15_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelqlhtSubmenu);
        }

        private void iconButton18_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void iconButton19_Click(object sender, EventArgs e)
        {
            DanhSachBaoHiemcs f = new DanhSachBaoHiemcs();
            AddFrom(f);
            HideSubMenu();
        }

        private void iconButton20_Click_1(object sender, EventArgs e)
        {
            KhenThuongKyLuat f = new KhenThuongKyLuat();
            AddFrom(f);
            HideSubMenu();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            ChucVu f = new ChucVu();
            AddFrom(f);
            HideSubMenu();
        }

        private void iconButton21_Click(object sender, EventArgs e)
        {

        }
    }
}
