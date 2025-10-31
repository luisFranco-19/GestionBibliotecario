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
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GestorDeBiblioteca.Formularios
{
    public partial class FrmDevoluciones : Form
    {
        public FrmDevoluciones()
        {
            InitializeComponent();
            this.KeyPress += ValidacionEntrada.PasarFocus;
            this.KeyDown += ValidacionEntrada.ControlEsc;
            txtBuscar.Focus();
        }

        public FrmDevoluciones(int idPrestamo, string carnet, string nombre, string telefono, string cargo, int fechaRegistro)
        {
            InitializeComponent();
            txtBuscar.Focus();
        }

        private void FrmDev_Load(object sender, EventArgs e)
        {
            CargarPrestamos();
        }

        #region Métodos de carga y DataGridView
        private void CargarPrestamos()
        {
            try
            {
                string connectionString = ConexionDB.ObtenerConexion();
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    string consulta = @"
                    SELECT *
                    FROM vw_detallePrestamo
                    ORDER BY 
                        CASE Estado 
                            WHEN 'Prestado' THEN 1
                            WHEN 'Devuelto' THEN 2
                            ELSE 3
                        END,
                        FechaPrestamo DESC;";

                    SqlDataAdapter adapter = new SqlDataAdapter(consulta, conexion);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Limpiar el evento anterior para evitar duplicados
                    dgvListado.DataBindingComplete -= DgvListado_DataBindingComplete;

                    ConfigurarDataGridView(dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los registros: " + ex.Message);
            }
        }
        private void ConfigurarDataGridView(DataTable dt)
        {
            dgvListado.AutoGenerateColumns = false;
            dgvListado.Columns.Clear();

            dgvListado.Columns.Add(new DataGridViewTextBoxColumn { Name = "NombreUsuario", HeaderText = "Usuario", DataPropertyName = "NombreUsuario" });
            dgvListado.Columns.Add(new DataGridViewTextBoxColumn { Name = "Carnet", HeaderText = "Carnet", DataPropertyName = "Carnet" });
            dgvListado.Columns.Add(new DataGridViewTextBoxColumn { Name = "TituloLibro", HeaderText = "Libro", DataPropertyName = "TituloLibro" });
            dgvListado.Columns.Add(new DataGridViewTextBoxColumn { Name = "Cantidad", HeaderText = "Cantidad", DataPropertyName = "Cantidad" });
            dgvListado.Columns.Add(new DataGridViewTextBoxColumn { Name = "FechaPrestamo", HeaderText = "Fecha Préstamo", DataPropertyName = "FechaPrestamo" });
            dgvListado.Columns.Add(new DataGridViewTextBoxColumn { Name = "Estado", HeaderText = "Estado", DataPropertyName = "Estado" });
            dgvListado.Columns.Add(new DataGridViewTextBoxColumn { Name = "IdDetalle", DataPropertyName = "IdDetalle", Visible = false });
            dgvListado.Columns.Add(new DataGridViewTextBoxColumn { Name = "IdLibro", DataPropertyName = "IdLibro", Visible = false });

            // Estilo general
            dgvListado.BorderStyle = BorderStyle.None;
            dgvListado.BackgroundColor = Color.White;
            dgvListado.GridColor = Color.LightGray;
            dgvListado.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvListado.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvListado.RowHeadersVisible = false;
            dgvListado.EnableHeadersVisualStyles = false;
            dgvListado.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(33, 150, 243);
            dgvListado.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvListado.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvListado.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvListado.ColumnHeadersHeight = 35;

            dgvListado.DefaultCellStyle.BackColor = Color.White;
            dgvListado.DefaultCellStyle.ForeColor = Color.FromArgb(50, 50, 50);
            dgvListado.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvListado.DefaultCellStyle.SelectionBackColor = Color.FromArgb(187, 222, 251);
            dgvListado.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvListado.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 248, 255);

            dgvListado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListado.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListado.MultiSelect = false;
            dgvListado.RowTemplate.Height = 30;

            // Asignar el evento para colorear filas DESPUÉS del enlace de datos
            dgvListado.DataBindingComplete += DgvListado_DataBindingComplete;

            // Enlazar los datos
            dgvListado.DataSource = dt;

            // Habilitar/Deshabilitar botón de devolución
            iconEliminar.Enabled = dgvListado.SelectedRows.Count > 0;
            dgvListado.SelectionChanged += (s, e) =>
            {
                iconEliminar.Enabled = dgvListado.SelectedRows.Count > 0;
            };
        }

        // Evento que se ejecuta después de que los datos se han enlazado
        private void DgvListado_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            // Llamar el coloreado después de un pequeño delay para evitar conflictos
            this.BeginInvoke(new Action(ColorearFilasPorEstado));
        }

        // Método para colorear filas según el estado - SOLO PRESTADOS EN ROJO
        // Modifica el método ColorearFilasPorEstado
        private void ColorearFilasPorEstado()
        {
            // Temporariamente deshabilitar la selección automática para evitar conflictos
            dgvListado.ClearSelection();

            foreach (DataGridViewRow row in dgvListado.Rows)
            {
                if (row.IsNewRow) continue;

                string estado = row.Cells["Estado"]?.Value?.ToString() ?? "";

                if (estado == "Prestado")
                {
                    // Aplicar estilo personalizado para préstamos activos
                    row.DefaultCellStyle.BackColor = Color.FromArgb(255, 204, 203);
                    row.DefaultCellStyle.ForeColor = Color.DarkRed;
                    // Importante: asegurar que la selección no sobrescriba el color
                    row.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 150, 150); // Rojo más oscuro para selección
                    row.DefaultCellStyle.SelectionForeColor = Color.DarkRed;
                }
                else
                {
                    // Para "Devuelto" - estilo normal pero también definir selección
                    row.DefaultCellStyle.BackColor = row.Index % 2 == 0
                        ? dgvListado.DefaultCellStyle.BackColor
                        : dgvListado.AlternatingRowsDefaultCellStyle.BackColor;
                    row.DefaultCellStyle.ForeColor = dgvListado.DefaultCellStyle.ForeColor;
                    row.DefaultCellStyle.SelectionBackColor = Color.FromArgb(187, 222, 251); // Azul original para selección
                    row.DefaultCellStyle.SelectionForeColor = Color.Black;
                }
            }
        }

        #endregion

        #region Busqueda
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string valor = txtBuscar.Text.Trim();

            try
            {
                string connectionString = ConexionDB.ObtenerConexion();
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    string consulta = @"
                            SELECT *
                            FROM vw_detallePrestamo
                            WHERE NombreUsuario LIKE @valor
                               OR Carnet LIKE @valor
                               OR TituloLibro LIKE @valor
                            ORDER BY FechaPrestamo DESC;";

                    using (SqlCommand cmd = new SqlCommand(consulta, conexion))
                    {
                        cmd.Parameters.AddWithValue("@valor", $"%{valor}%");
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        ConfigurarDataGridView(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message);
            }
        }

        #endregion

        #region Devolución
        private int ObtenerIdLibroPorDetalle(int idDetalle)
        {
            string connectionString = ConexionDB.ObtenerConexion();
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                string consulta = "SELECT idLibro FROM DetallePrestamos WHERE idDetallePrestamo = @idDetalle";
                using (SqlCommand cmd = new SqlCommand(consulta, conexion))
                {
                    cmd.Parameters.AddWithValue("@idDetalle", idDetalle);
                    conexion.Open();
                    object result = cmd.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : 0;
                }
            }
        }

        private void DevolverLibroSeleccionado()
        {
            if (dgvListado.CurrentRow == null)
                return;

            try
            {
                int idDetalle = Convert.ToInt32(dgvListado.CurrentRow.Cells["IdDetalle"].Value);
                string estadoActual = dgvListado.CurrentRow.Cells["Estado"].Value.ToString();
                int cantidadPrestada = Convert.ToInt32(dgvListado.CurrentRow.Cells["Cantidad"].Value);
                int idLibro = ObtenerIdLibroPorDetalle(idDetalle);

                if (estadoActual == "Devuelto")
                {
                    MessageBox.Show("Este libro ya fue devuelto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (MessageBox.Show($"¿Confirmar devolución de {cantidadPrestada} copia(s)?", "Confirmación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string connectionString = ConexionDB.ObtenerConexion();
                    using (SqlConnection conexion = new SqlConnection(connectionString))
                    {
                        conexion.Open();

                        // Marcar como devuelto
                        string actualizarPrestamo = @"
                            UPDATE DetallePrestamos
                            SET estado = 'Devuelto',
                                fechaDevolucion = GETDATE()
                            WHERE idDetallePrestamo = @idDetalle";

                        using (SqlCommand cmd1 = new SqlCommand(actualizarPrestamo, conexion))
                        {
                            cmd1.Parameters.AddWithValue("@idDetalle", idDetalle);
                            cmd1.ExecuteNonQuery();
                        }

                        // Sumar cantidad al inventario
                        string actualizarCantidad = @"
                            UPDATE Libros
                            SET cantidad = cantidad + @cantidad
                            WHERE idLibro = @idLibro";

                        using (SqlCommand cmd2 = new SqlCommand(actualizarCantidad, conexion))
                        {
                            cmd2.Parameters.AddWithValue("@cantidad", cantidadPrestada);
                            cmd2.Parameters.AddWithValue("@idLibro", idLibro);
                            cmd2.ExecuteNonQuery();
                        }

                        // Activar libro si hay stock
                        string activarLibro = @"
                            UPDATE Libros
                            SET estado = 'Activo'
                            WHERE idLibro = @idLibro AND cantidad > 0";

                        using (SqlCommand cmd3 = new SqlCommand(activarLibro, conexion))
                        {
                            cmd3.Parameters.AddWithValue("@idLibro", idLibro);
                            cmd3.ExecuteNonQuery();
                        }

                        MessageBox.Show("✅ Devolución registrada correctamente.", "Éxito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        CargarPrestamos();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al devolver: " + ex.Message);
            }
        }
        #endregion

        #region eventos del Datagrid
        private void dgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                DevolverLibroSeleccionado();
        }
        #endregion

        #region botones 
       

        private void iconEliminar_Click_1(object sender, EventArgs e)
        {
            DevolverLibroSeleccionado();
        }

        private void iconCerrar_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        #endregion


        
    }
}
