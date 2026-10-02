using GestorDeBiblioteca.OrigenDatos;
using System;
using Microsoft.Reporting.WinForms;
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
    public partial class FrmReportesDevoluciones : Form
    {
        public FrmReportesDevoluciones()
        {
            InitializeComponent();
        }

        private void FrmReportesDevoluciones_Load(object sender, EventArgs e)
        {
            try
            {
                var ds = Servicios.ListadoDevoliciones();
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DtsListadoDevoluciones",
                    ds.ListadoDevolucion as DataTable));
                reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);

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
