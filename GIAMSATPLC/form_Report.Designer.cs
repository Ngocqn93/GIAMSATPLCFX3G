namespace GIAMSATPLCFX3G
{
    partial class form_Report
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dssqlreport = new GIAMSATPLCFX3G.dssqlreport();
            this.FX3GA_DataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FX3GA_DataTableAdapter = new GIAMSATPLCFX3G.dssqlreportTableAdapters.FX3GA_DataTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dssqlreport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FX3GA_DataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "PLCFX3GSQL";
            reportDataSource1.Value = this.FX3GA_DataBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GIAMSATPLCFX3G.PLCFX3G_Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 552);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // dssqlreport
            // 
            this.dssqlreport.DataSetName = "dssqlreport";
            this.dssqlreport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FX3GA_DataBindingSource
            // 
            this.FX3GA_DataBindingSource.DataMember = "FX3GA_Data";
            this.FX3GA_DataBindingSource.DataSource = this.dssqlreport;
            // 
            // FX3GA_DataTableAdapter
            // 
            this.FX3GA_DataTableAdapter.ClearBeforeFill = true;
            // 
            // form_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 552);
            this.Controls.Add(this.reportViewer1);
            this.Name = "form_Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_Report";
            this.Load += new System.EventHandler(this.form_Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dssqlreport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FX3GA_DataBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource FX3GA_DataBindingSource;
        private dssqlreport dssqlreport;
        private dssqlreportTableAdapters.FX3GA_DataTableAdapter FX3GA_DataTableAdapter;
    }
}