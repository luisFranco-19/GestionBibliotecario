using LiveCharts;
using LiveCharts.WinForms;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GestorDeBiblioteca.Formularios
{
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
        }

        public string ConnectionString = ConfigurationManager.ConnectionStrings
          ["GestorDeBiblioteca.Properties.Settings.conexion"].ConnectionString;

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
           
        }


        private int ObtenerValorEscalar(string query)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        con.Open();
                        object resultado = cmd.ExecuteScalar();
                        con.Close();

                        if (resultado != null && resultado != DBNull.Value)
                        {
                            return Convert.ToInt32(resultado);
                        }
                        else
                        {
                            return 0; // Si no hay resultado, devuelve 0
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar consulta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0; // Devuelve 0 en caso de error
            }
        }



        private void CargarGraficoDisponibilidad()
        {
            // Nota: Se asume que los libros con préstamo activo (FechaDevolucion IS NULL) son los 'Prestados'
            string qDisponibles = @"
                SELECT 
                    SUM(CASE WHEN P.FechaDevolucion IS NULL THEN 1 ELSE 0 END) AS Prestados, 
                    SUM(CASE WHEN P.FechaDevolucion IS NOT NULL OR P.IdPrestamo IS NULL THEN 1 ELSE 0 END) AS Disponibles
                FROM dbo.Libros L
                LEFT JOIN dbo.Prestamos P ON L.IdLibro = P.IdLibro AND P.FechaDevolucion IS NULL
                WHERE L.IdLibro IS NOT NULL";

            int prestados = 0;
            int disponibles = 0;

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(qDisponibles, con))
                {
                    try
                    {
                        con.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Obtener los valores de las columnas
                                // La consulta es una simplificación; se recomienda una vista o SP
                                // para obtener el stock total y el prestado de forma más precisa.
                                // Ejemplo simplificado:
                                prestados = ObtenerValorEscalar(
                                    "SELECT COUNT(DISTINCT IdLibro) FROM dbo.Prestamos WHERE FechaDevolucion IS NULL");

                                int totalLibros = ObtenerValorEscalar("SELECT COUNT(*) FROM dbo.Libros");
                                disponibles = totalLibros - prestados;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al cargar Disponibilidad: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }

            // Configuración de LiveCharts (Tarta)
            pieChart1.Series = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "Prestados",
                    Values = new ChartValues<double> { prestados },
                    DataLabels = true,
                    LabelPoint = labelPoint => string.Format("{0} ({1:P})", labelPoint.Y, labelPoint.Participation)
                },
                new PieSeries
                {
                    Title = "Disponibles",
                    Values = new ChartValues<double> { disponibles },
                    DataLabels = true,
                    LabelPoint = labelPoint => string.Format("{0} ({1:P})", labelPoint.Y, labelPoint.Participation)
                }
            };
            pieChart1.LegendLocation = LegendLocation.Bottom;
            pieChart1.InnerRadius = 50; // Para hacerlo tipo dona (Doughnut)
        }
    }
}  

   