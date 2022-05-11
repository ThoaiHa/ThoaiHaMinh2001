using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu
{
    public partial class Reportnhanvien : Form
    {
        public Reportnhanvien()
        {
            InitializeComponent();
        }

        private void Reportnhanvien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLNSDataSet.NHANVIEN' table. You can move, or remove it, as needed.
            this.NHANVIENTableAdapter.Fill(this.QLNSDataSet.NHANVIEN);

            this.reportViewer1.RefreshReport();
        }

        //private void iconButton1_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        string str = null;
        //        SqlConnection conn = new SqlConnection(str);
        //        SqlCommand cmd = new SqlCommand("SELECT MANV, HOTENNV, NGAYSINH, GIOITINH, SDT, EMAIL, NOISINH, CMND, NGAYCAP, NOICAP, DCTAMTRU, DCTHUONGTRU,TRINHDOHOCVAN, TRINHDOCHUYENMON, TINHTRANGHONNHAN, MSTHUETNCN, MABHXH, GHICHU, TTLV FROM NHANVIEN where MANV Like '%" + txtSearch.Text + "%' or HOTENNV Like N'%" + txtSearch.Text + "%'", conn);
        //        cmd.CommandType = CommandType.Text;
        //        conn.Open();

        //        DataTable dt = new DataTable();
        //        dt.Load(cmd.ExecuteReader());

        //        ReportDataSource reportDSDetail = new ReportDataSource("NHANVIEN", dt);
        //        this.reportViewer1.LocalReport.DataSources.Clear();
        //        this.reportViewer1.LocalReport.DataSources.Add(reportDSDetail);
        //        this.reportViewer1.LocalReport.Refresh();
        //        this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
        //        this.reportViewer1.ZoomMode = ZoomMode.PageWidth;
        //        this.reportViewer1.RefreshReport();
        //        conn.Close();
        //    }
        //    catch
        //    {
        //    }
        //}
    }
}
