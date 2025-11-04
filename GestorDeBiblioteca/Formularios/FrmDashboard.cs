using app.Banco.Utilidades;
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
using System.Windows.Forms.DataVisualization.Charting;

namespace GestorDeBiblioteca.Formularios
{
    public partial class FrmDashboard : Form
    {
        private DataTable datosOriginales;
        private string vistaActual = "";
        public FrmDashboard()
        {
            InitializeComponent();
            TotalesvistasOcultas();
        }

        #region Estilos y metodos del dataGrid
      
        private void CargarVista(string nombreVista)
        {
            try
            {
                string connectionString = ConexionDB.ObtenerConexion();

                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    string consulta = $"SELECT * FROM {nombreVista}";
                    SqlDataAdapter adapter = new SqlDataAdapter(consulta, conexion);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    datosOriginales = dt; // Guardamos los datos para que el buscador funcione
                    vistaActual = nombreVista;
                    ConfigurarDataGridView(dt);
                    ActualizarGrafico(dt);
                    ActualizarTotales(dt);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ActualizarGrafico(DataTable dt)
        {
            chartEstadisticas.Series.Clear();
            chartEstadisticas.Titles.Clear();

            if (dt == null || dt.Rows.Count == 0)
            {
                chartEstadisticas.Titles.Add("Sin datos disponibles");
                return;
            }

            Series serie = new Series("Datos");
            serie.ChartType = SeriesChartType.Doughnut;
            serie.Font = new Font("Segoe UI", 11, FontStyle.Bold);

            // valores del gráfico
            serie.IsValueShownAsLabel = true;
            serie.LabelForeColor = Color.Black;   
            serie.Label = "#VALX #VALY";       
                                               

            // Estilo del Doughnut
            serie["PieLabelStyle"] = "Outside";   
            serie["DoughnutRadius"] = "60";
            serie.SmartLabelStyle.Enabled = true; 

            switch (vistaActual)
            {
                case "vw_LibrosEnMora":
                    var grupoLibros = dt.AsEnumerable()
                        .Select(r => new
                        {
                            Libro = r["Titulo"].ToString(),
                            Copias = Convert.ToInt32(r["CopiasPrestadas"])
                        });

                    foreach (var item in grupoLibros)
                        serie.Points.AddXY(item.Libro, item.Copias);

                    chartEstadisticas.Titles.Add("Libros Prestados ");
                    break;

                case "vw_UsuariosEnMora":
                    var grupoUsuarios = dt.AsEnumerable()
                        .Select(r => new
                        {
                            Usuario = r["Usuarios"].ToString(),
                            Cantidad = Convert.ToInt32(r["CantidadLibrosPrestados"])
                        });

                    foreach (var item in grupoUsuarios)
                        serie.Points.AddXY(item.Usuario, item.Cantidad);

                    chartEstadisticas.Titles.Add("Usuarios con Préstamos en Mora");
                    break;

                case "vw_StockLibros":
                    var grupoStock = dt.AsEnumerable()
                        .Select(r => new
                        {
                            Libro = r["Titulo"].ToString(),
                            Stock = Convert.ToInt32(r["CopiasDisponibles"])
                        });

                    foreach (var item in grupoStock)
                        serie.Points.AddXY(item.Libro, item.Stock);

                    chartEstadisticas.Titles.Add("Stock Actual de Libros");
                    break;
            }

            chartEstadisticas.Series.Add(serie);
            chartEstadisticas.Legends[0].Enabled = true;
            chartEstadisticas.Legends[0].Font = new Font("Segoe UI", 10, FontStyle.Regular);
            chartEstadisticas.Legends[0].Docking = Docking.Right;
        }


        private void TotalesvistasOcultas()
        {
            picBox1.Visible = false;
            picBox2.Visible = false;
            picBox3.Visible = false;
            picBox4.Visible = false;


            total1.Visible = false;
            total2.Visible = false;
            total3.Visible = false;
            total4.Visible = false;
        }
        private void TotalesvistasNoOcultas()
        {
            picBox1.Visible = true;
            picBox2.Visible = true;
            picBox3.Visible = true;
            picBox4.Visible = true;

            total1.Visible = true;
            total2.Visible = true;
            total3.Visible = true;
            total4.Visible = true;
        }
        private void ActualizarTotales(DataTable dt)
        {
            

            // Si no hay datos limpiar los labels
            if (dt == null || dt.Rows.Count == 0)
            {
                total1.Text = "—";
                total2.Text = "—";
                total3.Text = "—";
                total4.Text = "—";
                return;
            }

            switch (vistaActual)
            {
                // LIBROS EN MORA
                case "vw_LibrosEnMora":
                    int totalLibros = dt.Rows.Count;
                    int totalPrestamos = dt.AsEnumerable().Sum(r => Convert.ToInt32(r["CopiasPrestadas"]));
                    int totalDisponibles = dt.AsEnumerable().Sum(r => Convert.ToInt32(r["CopiasDisponibles"]));
                    int totalAutores = dt.AsEnumerable().Select(r => r["Autor"].ToString()).Distinct().Count();

                    total1.Text = $"📚 Total Libros: {totalLibros}";
                    total2.Text = $"📦 Copias Prestadas: {totalPrestamos}";
                    total3.Text = $"✅ Copias Disponibles: {totalDisponibles}";
                    total4.Text = $"✍️ Autores: {totalAutores}";
                    break;

                //  USUARIOS EN MORA
                case "vw_UsuariosEnMora":
                    int totalUsuarios = dt.Rows.Count;
                    int totalLibrosPrestados = dt.AsEnumerable().Sum(r => Convert.ToInt32(r["CantidadLibrosPrestados"]));
                    DateTime fechaMasAntigua = dt.AsEnumerable().Min(r => Convert.ToDateTime(r["FechaPrestamo"]));
                    DateTime fechaMasReciente = dt.AsEnumerable().Max(r => Convert.ToDateTime(r["FechaDevolucionEsperada"]));

                    total1.Text = $"👥 Usuarios en Mora: {totalUsuarios}";
                    total2.Text = $"📘 Libros Prestados: {totalLibrosPrestados}";
                    total3.Text = $"📅 Desde: {fechaMasAntigua:dd/MM/yyyy}";
                    total4.Text = $"📅 Hasta: {fechaMasReciente:dd/MM/yyyy}";
                    break;

                //  STOCK DE LIBROS
                case "vw_StockLibros":
                    int totalTitulos = dt.Rows.Count;
                    int totalStock = dt.AsEnumerable().Sum(r => Convert.ToInt32(r["StockCopias"]));
                    int totalPrestadosStock = dt.AsEnumerable().Sum(r => Convert.ToInt32(r["CopiasPrestadas"]));
                    int totalDisponiblesStock = dt.AsEnumerable().Sum(r => Convert.ToInt32(r["CopiasDisponibles"]));

                    total1.Text = $"📚 Total Títulos: {totalTitulos}";
                    total2.Text = $"📦 Stock Total: {totalStock}";
                    total3.Text = $"📕 Prestados: {totalPrestadosStock}";
                    total4.Text = $"✅ Disponibles: {totalDisponiblesStock}";
                    break;
            }
        }

        
        private void ConfigurarDataGridView(DataTable dt)
        {
            dvgListado.AutoGenerateColumns = true;
            dvgListado.Columns.Clear();
            dvgListado.DataSource = null;

            dvgListado.DataSource = dt;

           
            foreach (DataGridViewColumn col in dvgListado.Columns)
            {
                if (col.Name.ToLower().Contains("id"))
                    col.Visible = false;
            }

            // Apariencia del DataGridView
            dvgListado.BorderStyle = BorderStyle.None;
            dvgListado.BackgroundColor = Color.White;
            dvgListado.GridColor = Color.LightGray;
            dvgListado.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dvgListado.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dvgListado.RowHeadersVisible = false;
            dvgListado.EnableHeadersVisualStyles = false;

            dvgListado.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(33, 150, 243);
            dvgListado.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dvgListado.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dvgListado.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dvgListado.ColumnHeadersHeight = 35;

            dvgListado.DefaultCellStyle.BackColor = Color.White;
            dvgListado.DefaultCellStyle.ForeColor = Color.FromArgb(50, 50, 50);
            dvgListado.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dvgListado.DefaultCellStyle.SelectionBackColor = Color.FromArgb(187, 222, 251);
            dvgListado.DefaultCellStyle.SelectionForeColor = Color.Black;
            dvgListado.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 248, 255);
            dvgListado.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dvgListado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgListado.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvgListado.MultiSelect = false;
            dvgListado.RowTemplate.Height = 30;
        }
        #endregion

        #region Botones de comando
        private void btnRegistrosLibros_Click(object sender, EventArgs e)
        {
            CargarVista("vw_LibrosEnMora");
            TotalesvistasNoOcultas();
        }
        private void btnRegistroUsuarios_Click(object sender, EventArgs e)
        {
            CargarVista("vw_UsuariosEnMora");
            TotalesvistasNoOcultas();

        }
        private void btnStockLibros_Click(object sender, EventArgs e)
        {
            CargarVista("vw_StockLibros");
            TotalesvistasNoOcultas();

        }
        #endregion

        #region Buscador
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (datosOriginales == null) return;

            string filtro = txtBuscar.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(filtro))
            {
                dvgListado.DataSource = datosOriginales;
                ActualizarGrafico(datosOriginales);
                return;
            }

            var resultados = datosOriginales.AsEnumerable()
                .Where(row => row.ItemArray.Any(
                    campo => campo.ToString().ToLower().Contains(filtro)
                ));

            if (resultados.Any())
            {
                DataTable filtrada = resultados.CopyToDataTable();
                dvgListado.DataSource = filtrada;
                ActualizarGrafico(filtrada);
            }
            else
            {
                dvgListado.DataSource = datosOriginales.Clone();
                chartEstadisticas.Series.Clear();
                chartEstadisticas.Titles.Clear();
                chartEstadisticas.Titles.Add("Sin resultados");
            }
        }
    }

        #endregion
    
}
