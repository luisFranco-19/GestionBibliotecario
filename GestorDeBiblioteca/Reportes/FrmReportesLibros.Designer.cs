namespace GestorDeBiblioteca.Reportes
{
    partial class FrmReportesLibros
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.listadoLibrosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dtsConexion1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtsConexion1 = new GestorDeBiblioteca.OrigenDatos.DtsConexion1();
            this.listadoLibrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.listadoLibrosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsConexion1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsConexion1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadoLibrosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listadoLibrosBindingSource1
            // 
            this.listadoLibrosBindingSource1.DataMember = "ListadoLibros";
            this.listadoLibrosBindingSource1.DataSource = this.dtsConexion1BindingSource;
            // 
            // dtsConexion1BindingSource
            // 
            this.dtsConexion1BindingSource.DataSource = this.dtsConexion1;
            this.dtsConexion1BindingSource.Position = 0;
            // 
            // dtsConexion1
            // 
            this.dtsConexion1.DataSetName = "DtsConexion1";
            this.dtsConexion1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listadoLibrosBindingSource
            // 
            this.listadoLibrosBindingSource.DataMember = "ListadoLibros";
            this.listadoLibrosBindingSource.DataSource = this.dtsConexion1;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DtsStockLibros";
            reportDataSource2.Value = this.listadoLibrosBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GestorDeBiblioteca.Reportes.RptListadoLibros.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(664, 544);
            this.reportViewer1.TabIndex = 0;
            // 
            // FrmReportesLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 544);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmReportesLibros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmReportesLibros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listadoLibrosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsConexion1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsConexion1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadoLibrosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource listadoLibrosBindingSource;
        private OrigenDatos.DtsConexion1 dtsConexion1;
        private System.Windows.Forms.BindingSource dtsConexion1BindingSource;
        private System.Windows.Forms.BindingSource listadoLibrosBindingSource1;
    }
}