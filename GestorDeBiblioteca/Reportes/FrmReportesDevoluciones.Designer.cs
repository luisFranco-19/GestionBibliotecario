namespace GestorDeBiblioteca.Reportes
{
    partial class FrmReportesDevoluciones
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
            this.listadoDevolucionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dtsConexion = new GestorDeBiblioteca.OrigenDatos.DtsConexion();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.listadoDevolucionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.listadoDevolucionBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsConexion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadoDevolucionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listadoDevolucionBindingSource1
            // 
            this.listadoDevolucionBindingSource1.DataMember = "ListadoDevolucion";
            this.listadoDevolucionBindingSource1.DataSource = this.dtsConexion;
            // 
            // dtsConexion
            // 
            this.dtsConexion.DataSetName = "DtsConexion";
            this.dtsConexion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            reportDataSource2.Name = "DtsListadoDevolucion";
            reportDataSource2.Value = this.listadoDevolucionBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GestorDeBiblioteca.Reportes.RptListadoDevoluciones.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(664, 544);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.ZoomPercent = 75;
            // 
            // listadoDevolucionBindingSource
            // 
            this.listadoDevolucionBindingSource.DataMember = "ListadoDevolucion";
            this.listadoDevolucionBindingSource.DataSource = this.dtsConexion;
            // 
            // FrmReportesDevoluciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 544);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmReportesDevoluciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmReportesDevoluciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listadoDevolucionBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsConexion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadoDevolucionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource listadoDevolucionBindingSource;
        private OrigenDatos.DtsConexion dtsConexion;
        private System.Windows.Forms.BindingSource listadoDevolucionBindingSource1;
    }
}