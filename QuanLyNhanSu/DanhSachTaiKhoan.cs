using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu
{
    public class DanhSachTaiKhoan
    {
        private static DanhSachTaiKhoan instance;

        public static DanhSachTaiKhoan Instance 
        {
            get
            {
                if (instance == null)
                    instance = new DanhSachTaiKhoan();
                return instance; 
            }
            set => instance = value; 
        }

        List<TaiKhoan> listTaiKhoan;

        public List<TaiKhoan> ListTaiKhoan 
        { 
            get => listTaiKhoan; 
            set => listTaiKhoan = value; 
        }
        public object Listtaikhoan { get; internal set; }

        DanhSachTaiKhoan()
        {
            listTaiKhoan = new List<TaiKhoan>();
            listTaiKhoan.Add(new TaiKhoan("admin", "123456", TaiKhoan.LoaiTK.admin));
            listTaiKhoan.Add(new TaiKhoan("giamdoc", "123456", TaiKhoan.LoaiTK.giamdoc));
            listTaiKhoan.Add(new TaiKhoan("nhansu", "123456", TaiKhoan.LoaiTK.nhansu));
            listTaiKhoan.Add(new TaiKhoan("luong", "123456", TaiKhoan.LoaiTK.luong));
            listTaiKhoan.Add(new TaiKhoan("chamcong", "123456", TaiKhoan.LoaiTK.chamcong));
        }
    }
}
