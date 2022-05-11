
namespace QuanLyNhanSu
{
    partial class Reportnhanvien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.NHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QLNSDataSet = new QuanLyNhanSu.QLNSDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.NHANVIENTableAdapter = new QuanLyNhanSu.QLNSDataSetTableAdapters.NHANVIENTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.NHANVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLNSDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // NHANVIENBindingSource
            // 
            this.NHANVIENBindingSource.DataMember = "NHANVIEN";
            this.NHANVIENBindingSource.DataSource = this.QLNSDataSet;
            // 
            // QLNSDataSet
            // 
            this.QLNSDataSet.DataSetName = "QLNSDataSet";
            this.QLNSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "nhanviennhansu";
            reportDataSource1.Value = this.NHANVIENBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyNhanSu.nhanvien.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1924, 1055);
            this.reportViewer1.TabIndex = 0;
            // 
            // NHANVIENTableAdapter
            // 
            this.NHANVIENTableAdapter.ClearBeforeFill = true;
            // 
            // Reportnhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Reportnhanvien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportnhanvien";
            this.Load += new System.EventHandler(this.Reportnhanvien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NHANVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLNSDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource NHANVIENBindingSource;
        private QLNSDataSet QLNSDataSet;
        private QLNSDataSetTableAdapters.NHANVIENTableAdapter NHANVIENTableAdapter;
    }
}