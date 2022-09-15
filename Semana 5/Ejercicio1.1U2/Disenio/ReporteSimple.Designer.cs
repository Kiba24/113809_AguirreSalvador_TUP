namespace Ejercicio1._1U2.Disenio
{
    partial class ReporteSimple
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
            this.dsListadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsListado = new Ejercicio1._1U2.Reportes.DsListado();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dTListadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dTListadoTableAdapter = new Ejercicio1._1U2.Reportes.DsListadoTableAdapters.DTListadoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsListadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTListadoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dsListadoBindingSource
            // 
            this.dsListadoBindingSource.DataSource = this.dsListado;
            this.dsListadoBindingSource.Position = 0;
            // 
            // dsListado
            // 
            this.dsListado.DataSetName = "DsListado";
            this.dsListado.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "TablaListado";
            reportDataSource1.Value = this.dTListadoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Ejercicio1._1U2.Reportes.ListadoCarreras.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(42, 28);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(992, 434);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // dTListadoBindingSource
            // 
            this.dTListadoBindingSource.DataMember = "DTListado";
            this.dTListadoBindingSource.DataSource = this.dsListado;
            // 
            // dTListadoTableAdapter
            // 
            this.dTListadoTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 496);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteSimple";
            this.Text = "ReporteSimple";
            this.Load += new System.EventHandler(this.ReporteSimple_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsListadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTListadoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dsListadoBindingSource;
        private Reportes.DsListado dsListado;
        private System.Windows.Forms.BindingSource dTListadoBindingSource;
        private Reportes.DsListadoTableAdapters.DTListadoTableAdapter dTListadoTableAdapter;
    }
}