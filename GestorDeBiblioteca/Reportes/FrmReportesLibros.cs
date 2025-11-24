using GestorDeBiblioteca.OrigenDatos;
using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using app.Banco.Utilidades;

namespace GestorDeBiblioteca.Reportes
{
    public partial class FrmReportesLibros : Form
    {
        public FrmReportesLibros()
        {
            InitializeComponent();
        }

        private void FrmReportesLibros_Load(object sender, EventArgs e)
        {
            try
            {

                var ds = Servicios1.ListadoLibros();
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DtsStockLibros",
                    ds.ListadoLibros as DataTable));
                reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);

                // reportViewer1.ZoomMode = ZoomMode.PageWidth;

                //reportViewer1.ZoomMode = ZoomMode.FullPage;

                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 75;


                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
