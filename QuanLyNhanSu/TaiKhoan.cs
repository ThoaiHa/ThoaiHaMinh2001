using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu
{
    public class TaiKhoan
    {
        private string tenTaiKhoan;

        public string TenTaiKhoan 
        { 
            get => tenTaiKhoan; 
            set => tenTaiKhoan = value; 
        }

        private string matKhau;

        public string MatKhau
        {
            get => matKhau;
            set => matKhau = value;
        }

        public enum LoaiTK

        {
            admin,
            giamdoc,
            nhansu,
            luong,
            chamcong,
        }


        private LoaiTK loaiTaiKhoan;

            public LoaiTK LoaiTaiKhoan 
        {
            get { return loaiTaiKhoan; }
            set => loaiTaiKhoan = value; 
        }
        

        private string tenHienThi;
        public string TenHienThi 
        {
            get
            {
                switch (LoaiTaiKhoan)
                {
                    case LoaiTK.admin:
                        TenHienThi = "Admin";
                        break;
                    case LoaiTK.giamdoc:
                        TenHienThi = "Giám Đốc";
                        break;
                    case LoaiTK.nhansu:
                        TenHienThi = "Nhân Sự";
                        break;
                    case LoaiTK.luong:
                        TenHienThi = "Lương";
                        break;
                    case LoaiTK.chamcong:
                        TenHienThi = "Chấm Công";
                        break;
                }
                return tenHienThi;
            }
            set => tenHienThi = value; 
        }

        public TaiKhoan(string tentaikhoan, string matkhau, LoaiTK loaitaikhoan)
        {
            this.TenTaiKhoan = tentaikhoan;
            this.MatKhau = matkhau;
            this.LoaiTaiKhoan = loaitaikhoan;
            
        }

        public TaiKhoan(string tenTaiKhoan, string matKhau)
        {
            this.tenTaiKhoan = tenTaiKhoan;
            this.matKhau = matKhau;
        }
    }
}
