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
            chartEstadisticas.Legends[0].Enabled = true;
            chartEstadisticas.Legends[0].Font = new Font("Segoe UI", 10, FontStyle.Regular);
            chartEstadisticas.Legends[0].Docking = Docking.Right;

            if (dt == null || dt.Rows.Count == 0)
            {
                chartEstadisticas.Titles.Add("Sin datos disponibles");
                return;
            }

            // Estilos de fondo del gráfico
            chartEstadisticas.BackColor = Color.FromArgb(255, 255, 255); // Blanco
            chartEstadisticas.ChartAreas[0].BackColor = Color.White;
            chartEstadisticas.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Segoe UI", 9);
            chartEstadisticas.ChartAreas[0].AxisY.LabelStyle.Font = new Font("Segoe UI", 9);
            chartEstadisticas.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.FromArgb(210, 210, 210);
            chartEstadisticas.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.FromArgb(210, 210, 210);

            Series serie = new Series
            {
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                IsValueShownAsLabel = true,
                LabelForeColor = Color.Black,
                BorderColor = Color.White,
                BorderWidth = 2
            };

            // Paleta personalizada (colores combinados con el dashboard)
            Color[] coloresDashboard =
            {
                    Color.FromArgb(54, 69, 79),   // gris azulado oscuro
                    Color.FromArgb(93, 109, 126), // gris acero
                    Color.FromArgb(72, 133, 184), // azul petróleo
                    Color.FromArgb(100, 149, 237),// celeste suave
                    Color.FromArgb(147, 197, 207),// azul gris claro
                    Color.FromArgb(171, 183, 183),// gris cálido
                    Color.FromArgb(88, 111, 124), // gris azulado medio
                    Color.FromArgb(42, 87, 118),  // azul marino
                    Color.FromArgb(64, 128, 128), // azul verdoso
                    Color.FromArgb(192, 200, 207) // gris plateado
    };

            // Configuración visual según vista
            switch (vistaActual)
            {
                case "vw_Top10UsuariosPrestamos":
                    chartEstadisticas.Titles.Add("Usuarios con más préstamos");
                    serie.ChartType = SeriesChartType.Pie;
                    foreach (DataRow r in dt.Rows)
                        serie.Points.AddXY(r["Usuario"].ToString(), Convert.ToInt32(r["TotalPrestamos"]));
                    break;

                case "vw_Top10LibrosPopulares":
                    chartEstadisticas.Titles.Add("Libros más populares");
                    serie.ChartType = SeriesChartType.Pie;
                    foreach (DataRow r in dt.Rows)
                        serie.Points.AddXY(r["Libro"].ToString(), Convert.ToInt32(r["TotalPrestamos"]));
                    break;

                case "vw_DistribucionUsuarios":
                    chartEstadisticas.Titles.Add("Distribución de Usuarios");
                    serie.ChartType = SeriesChartType.Bar;
                    foreach (DataRow r in dt.Rows)
                        serie.Points.AddXY(r["TipoUsuario"].ToString(), Convert.ToInt32(r["Total"]));
                    break;
            }

            chartEstadisticas.Series.Add(serie);

            // Aplicar los colores personalizados a cada punto del gráfico
            for (int i = 0; i < serie.Points.Count; i++)
            {
                serie.Points[i].Color = coloresDashboard[i % coloresDashboard.Length];
            }

            // Ajuste visual general
            chartEstadisticas.ChartAreas[0].AxisX.LabelStyle.Angle = -30;
            chartEstadisticas.Titles[0].Font = new Font("Segoe UI Semibold", 12, FontStyle.Bold);
            chartEstadisticas.Titles[0].ForeColor = Color.FromArgb(54, 69, 79);
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
            if (dt == null || dt.Rows.Count == 0)
            {
                total1.Text = total2.Text = total3.Text = total4.Text = "—";
                return;
            }

            switch (vistaActual)
            {
                case "vw_Top10UsuariosPrestamos":
                    int totalUsuarios = dt.Rows.Count;
                    int totalPrestamosUsuarios = dt.AsEnumerable().Sum(r => Convert.ToInt32(r["TotalPrestamos"]));

                    total1.Text = $"👥 Usuarios Top: {totalUsuarios}";
                    total2.Text = $"📘 Total de préstamos: {totalPrestamosUsuarios}";
                    total3.Text = $"🏆 Promedio por usuario: {totalPrestamosUsuarios / totalUsuarios}";
                    total4.Text = $"🗓️ Actualizado: {DateTime.Now:dd/MM/yyyy}";
                    break;

                case "vw_Top10LibrosPopulares":
                    int totalLibros = dt.Rows.Count;
                    int totalPrestamosLibros = dt.AsEnumerable().Sum(r => Convert.ToInt32(r["TotalPrestamos"]));

                    total1.Text = $"📚 Libros Top: {totalLibros}";
                    total2.Text = $"📦 Total préstamos: {totalPrestamosLibros}";
                    total3.Text = $"⭐ Promedio por libro: {totalPrestamosLibros / totalLibros}";
                    total4.Text = $"🗓️ Actualizado: {DateTime.Now:dd/MM/yyyy}";
                    break;

                case "vw_DistribucionUsuarios":
                    int total = dt.AsEnumerable().Sum(r => Convert.ToInt32(r["Total"]));
                    string detalle = string.Join(" | ", dt.AsEnumerable().Select(r => $"{r["TipoUsuario"]}: {r["Total"]}"));

                    total1.Text = $"👥 Total usuarios: {total}";
                    total2.Text = $"📊 {detalle}";
                    total3.Text = $"🔍 {dt.Rows.Count} categorías";
                    total4.Text = $"🗓️ Actualizado: {DateTime.Now:dd/MM/yyyy}";
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

            //  Estilo del data
            dvgListado.BorderStyle = BorderStyle.None;
            dvgListado.BackgroundColor = Color.White;
            dvgListado.GridColor = Color.LightGray;
            dvgListado.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dvgListado.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dvgListado.RowHeadersVisible = false;
             
            //Encabezado 
            dvgListado.EnableHeadersVisualStyles = false;
            dvgListado.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(54, 69, 79);
            dvgListado.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dvgListado.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dvgListado.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dvgListado.ColumnHeadersHeight = 35;

            // Filas 
            dvgListado.DefaultCellStyle.BackColor = Color.White;
            dvgListado.DefaultCellStyle.ForeColor = Color.FromArgb(50, 50, 50);
            dvgListado.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dvgListado.DefaultCellStyle.SelectionBackColor = Color.FromArgb(136, 155, 168); // Color al seleccionar una columna
            dvgListado.DefaultCellStyle.SelectionForeColor = Color.Black;

            // Filas alternas 
            dvgListado.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(219, 219, 219);

            // CONFIGURACIÓN MEJORADA PARA EL PROBLEMA DEL COLOR AZUL
            dvgListado.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvgListado.MultiSelect = false;
            dvgListado.RowTemplate.Height = 30;

            // Deshabilitar la selección de celdas individuales
            dvgListado.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            // Asegurar que solo se seleccionen filas completas
            dvgListado.ColumnHeadersDefaultCellStyle.SelectionBackColor = dvgListado.ColumnHeadersDefaultCellStyle.BackColor;
            dvgListado.ColumnHeadersDefaultCellStyle.SelectionForeColor = dvgListado.ColumnHeadersDefaultCellStyle.ForeColor;

            // Deshabilitar el enfoque visual en celdas individuales
            dvgListado.ShowCellToolTips = false;
            dvgListado.StandardTab = true;
             
            dvgListado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        #endregion

        #region Botones de comando
        private void btnRegistrosLibros_Click(object sender, EventArgs e)
        {
            CargarVista("vw_Top10UsuariosPrestamos");
            TotalesvistasNoOcultas();
        }
        private void btnRegistroUsuarios_Click(object sender, EventArgs e)
        {
            CargarVista("vw_Top10LibrosPopulares");
            TotalesvistasNoOcultas();

        }
        private void btnStockLibros_Click(object sender, EventArgs e)
        {
            CargarVista("vw_DistribucionUsuarios");
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
