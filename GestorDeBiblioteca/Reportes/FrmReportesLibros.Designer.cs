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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.components = new System.ComponentModel.Container();
            this.listadoLibrosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dtsConexion1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtsConexion1 = new GestorDeBiblioteca.OrigenDatos.DtsConexion1();
            this.listadoLibrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Margin = new System.Windows.Forms.Padding(2);
            this.tlpDisenoRaiz = new System.Windows.Forms.TableLayoutPanel();
            this.tlpDisenoEncabezado = new System.Windows.Forms.TableLayoutPanel();
            this.lblDisenoSeccion = new System.Windows.Forms.Label();
            this.lblDisenoTitulo = new System.Windows.Forms.Label();
            this.lblDisenoSubtitulo = new System.Windows.Forms.Label();
            this.pnlDisenoTarjeta = new Guna.UI2.WinForms.Guna2Panel();
            this.lblDisenoAyuda = new System.Windows.Forms.Label();
            this.tlpDisenoRaiz.SuspendLayout();
            this.tlpDisenoEncabezado.SuspendLayout();
            this.pnlDisenoTarjeta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listadoLibrosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsConexion1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsConexion1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadoLibrosBindingSource)).BeginInit();
            this.SuspendLayout();
            this.listadoLibrosBindingSource1.DataMember = "ListadoLibros";
            this.listadoLibrosBindingSource1.DataSource = this.dtsConexion1BindingSource;
            this.dtsConexion1BindingSource.DataSource = this.dtsConexion1;
            this.dtsConexion1BindingSource.Position = 0;
            this.dtsConexion1.DataSetName = "DtsConexion1";
            this.dtsConexion1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            this.listadoLibrosBindingSource.DataMember = "ListadoLibros";
            this.listadoLibrosBindingSource.DataSource = this.dtsConexion1;
            reportDataSource2.Name = "DtsStockLibros";
            reportDataSource2.Value = this.listadoLibrosBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GestorDeBiblioteca.Reportes.RptListadoLibros.rdlc";
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(2);
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.TabIndex = 0;
            this.Name = "FrmReportesLibros";
            // tlpDisenoRaiz
            this.tlpDisenoRaiz.Name = "tlpDisenoRaiz";
            this.tlpDisenoRaiz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDisenoRaiz.BackColor = System.Drawing.Color.Transparent;
            this.tlpDisenoRaiz.ColumnCount = 1;
            this.tlpDisenoRaiz.RowCount = 3;
            this.tlpDisenoRaiz.Padding = new System.Windows.Forms.Padding(24, 16, 24, 14);
            this.tlpDisenoRaiz.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.tlpDisenoRaiz.Location = new System.Drawing.Point(0, 0);
            this.tlpDisenoRaiz.Size = new System.Drawing.Size(1140, 780);
            this.tlpDisenoRaiz.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDisenoRaiz.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tlpDisenoRaiz.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDisenoRaiz.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpDisenoRaiz.Controls.Add(this.tlpDisenoEncabezado, 0, 0);
            this.tlpDisenoRaiz.Controls.Add(this.pnlDisenoTarjeta, 0, 1);
            this.tlpDisenoRaiz.Controls.Add(this.lblDisenoAyuda, 0, 2);
            // tlpDisenoEncabezado
            this.tlpDisenoEncabezado.Name = "tlpDisenoEncabezado";
            this.tlpDisenoEncabezado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDisenoEncabezado.BackColor = System.Drawing.Color.Transparent;
            this.tlpDisenoEncabezado.ColumnCount = 1;
            this.tlpDisenoEncabezado.RowCount = 3;
            this.tlpDisenoEncabezado.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.tlpDisenoEncabezado.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.tlpDisenoEncabezado.Location = new System.Drawing.Point(24, 16);
            this.tlpDisenoEncabezado.Size = new System.Drawing.Size(1092, 86);
            this.tlpDisenoEncabezado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDisenoEncabezado.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpDisenoEncabezado.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tlpDisenoEncabezado.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlpDisenoEncabezado.Controls.Add(this.lblDisenoSeccion, 0, 0);
            this.tlpDisenoEncabezado.Controls.Add(this.lblDisenoTitulo, 0, 1);
            this.tlpDisenoEncabezado.Controls.Add(this.lblDisenoSubtitulo, 0, 2);
            // lblDisenoSeccion
            this.lblDisenoSeccion.Name = "lblDisenoSeccion";
            this.lblDisenoSeccion.Text = "REPORTES";
            this.lblDisenoSeccion.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDisenoSeccion.ForeColor = System.Drawing.Color.FromArgb(183, 113, 55);
            this.lblDisenoSeccion.BackColor = System.Drawing.Color.Transparent;
            this.lblDisenoSeccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDisenoSeccion.AutoSize = false;
            this.lblDisenoSeccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDisenoSeccion.AutoEllipsis = true;
            this.lblDisenoSeccion.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.lblDisenoSeccion.Location = new System.Drawing.Point(0, 0);
            this.lblDisenoSeccion.Size = new System.Drawing.Size(1092, 20);
            // lblDisenoTitulo
            this.lblDisenoTitulo.Name = "lblDisenoTitulo";
            this.lblDisenoTitulo.Text = "Reporte de inventario";
            this.lblDisenoTitulo.Font = new System.Drawing.Font("Georgia", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDisenoTitulo.ForeColor = System.Drawing.Color.FromArgb(24, 53, 61);
            this.lblDisenoTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblDisenoTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDisenoTitulo.AutoSize = false;
            this.lblDisenoTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDisenoTitulo.AutoEllipsis = true;
            this.lblDisenoTitulo.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.lblDisenoTitulo.Location = new System.Drawing.Point(0, 20);
            this.lblDisenoTitulo.Size = new System.Drawing.Size(1092, 42);
            // lblDisenoSubtitulo
            this.lblDisenoSubtitulo.Name = "lblDisenoSubtitulo";
            this.lblDisenoSubtitulo.Text = "Revisa los ejemplares, autores y disponibilidad de tu colección.";
            this.lblDisenoSubtitulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDisenoSubtitulo.ForeColor = System.Drawing.Color.FromArgb(102, 117, 120);
            this.lblDisenoSubtitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblDisenoSubtitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDisenoSubtitulo.AutoSize = false;
            this.lblDisenoSubtitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDisenoSubtitulo.AutoEllipsis = true;
            this.lblDisenoSubtitulo.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.lblDisenoSubtitulo.Location = new System.Drawing.Point(0, 62);
            this.lblDisenoSubtitulo.Size = new System.Drawing.Size(1092, 24);
            // pnlDisenoTarjeta
            this.pnlDisenoTarjeta.Name = "pnlDisenoTarjeta";
            this.pnlDisenoTarjeta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDisenoTarjeta.FillColor = System.Drawing.Color.White;
            this.pnlDisenoTarjeta.BackColor = System.Drawing.Color.Transparent;
            this.pnlDisenoTarjeta.BorderColor = System.Drawing.Color.FromArgb(224, 229, 225);
            this.pnlDisenoTarjeta.BorderThickness = 1;
            this.pnlDisenoTarjeta.BorderRadius = 12;
            this.pnlDisenoTarjeta.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.pnlDisenoTarjeta.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.pnlDisenoTarjeta.Location = new System.Drawing.Point(24, 112);
            this.pnlDisenoTarjeta.Size = new System.Drawing.Size(1092, 624);
            this.pnlDisenoTarjeta.Controls.Add(this.reportViewer1);
            // reportViewer1
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(10, 10);
            this.reportViewer1.Size = new System.Drawing.Size(1072, 604);
            // lblDisenoAyuda
            this.lblDisenoAyuda.Name = "lblDisenoAyuda";
            this.lblDisenoAyuda.Text = "Usa la barra del reporte para imprimir, buscar o exportar el documento.";
            this.lblDisenoAyuda.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDisenoAyuda.ForeColor = System.Drawing.Color.FromArgb(102, 117, 120);
            this.lblDisenoAyuda.BackColor = System.Drawing.Color.Transparent;
            this.lblDisenoAyuda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDisenoAyuda.AutoSize = false;
            this.lblDisenoAyuda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDisenoAyuda.AutoEllipsis = true;
            this.lblDisenoAyuda.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.lblDisenoAyuda.Location = new System.Drawing.Point(24, 736);
            this.lblDisenoAyuda.Size = new System.Drawing.Size(1092, 30);
            this.Text = "Reporte de inventario | Biblioteca";
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BackColor = System.Drawing.Color.FromArgb(246, 245, 241);
            this.ForeColor = System.Drawing.Color.FromArgb(24, 53, 61);
            this.ClientSize = new System.Drawing.Size(1140, 780);
            this.MinimumSize = new System.Drawing.Size(900, 650);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            this.Opacity = 1D;
            this.Controls.Add(this.tlpDisenoRaiz);
            this.Load += new System.EventHandler(this.FrmReportesLibros_Load);
            this.tlpDisenoRaiz.ResumeLayout(false);
            this.tlpDisenoEncabezado.ResumeLayout(false);
            this.pnlDisenoTarjeta.ResumeLayout(false);
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

        private System.Windows.Forms.TableLayoutPanel tlpDisenoRaiz;
        private System.Windows.Forms.TableLayoutPanel tlpDisenoEncabezado;
        private System.Windows.Forms.Label lblDisenoSeccion;
        private System.Windows.Forms.Label lblDisenoTitulo;
        private System.Windows.Forms.Label lblDisenoSubtitulo;
        private Guna.UI2.WinForms.Guna2Panel pnlDisenoTarjeta;
        private System.Windows.Forms.Label lblDisenoAyuda;
    }
}
