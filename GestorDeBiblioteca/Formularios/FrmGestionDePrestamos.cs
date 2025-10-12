using app.Banco.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorDeBiblioteca
{
    public partial class FrmGestionDePrestamos : Form
    {
        public FrmGestionDePrestamos()
        {
            InitializeComponent();
        }
        public string ConnectionString = ConfigurationManager.ConnectionStrings
        ["GestorDeBiblioteca.Properties.Settings.conexion"].ConnectionString;

        #region Variables
        private DataTable dtPrestamo;       // Libros seleccionados
        private int? selectedUserId = null; // Usuario actual
        #endregion

        #region Load
        private void FrmGestionDePrestamos_Load(object sender, EventArgs e)
        {
            FechaPrestamo.Text = DateTime.Now.ToShortDateString();
            InicializarPrestamoTable();

            MostrarSoloBuscadorUsuario();

        }
        #endregion

        #region Métodos de visibilidad
        private void MostrarSoloBuscadorUsuario()
        {
            
            txtBuscarUsuario.Visible = true;

            lblCarnetUsuario.Visible = false;
            lblNombreUsuario.Visible = false;
            BotonesLayout.Visible = false;

            Carnet.Visible = true;
            Nombre.Visible = true;

            panelregistroLibros.Visible = false;
            txtBuscarUsuario.Focus();
        }
        private void MostrarDatosUsuario()
        {
            lblCarnetUsuario.Visible = true;
            lblNombreUsuario.Visible = true;
            Carnet.Visible = true;
            Nombre.Visible = true;

        }

        private void MostrarBuscadorLibros()
        {
            panelregistroUsuarios.Visible = true ;
           


            lblTituloLibro.Visible = false;
            lblAutorLibro.Visible = false;
            lblEstadoLibro.Visible = false;

            Titulo.Visible = true;
            Autor.Visible = true;
            Estado.Visible = true;

            panelregistroLibros.Visible = true;
            txtBuscarLibro.Focus();
        }

        private void MostrarDatosLibro()
        {
            lblTituloLibro.Visible = true;
            lblAutorLibro.Visible = true;
            lblEstadoLibro.Visible = true;

            Titulo.Visible =true;
            Autor.Visible = true;
            Estado.Visible =true;

            BotonesLayout.Visible = true;
        }

        #endregion

        #region Inicializar DataGrid de préstamos
        private void InicializarPrestamoTable()
        {
            dtPrestamo = new DataTable();
            dtPrestamo.Columns.Add("idLibro", typeof(int)); // Ocultar el id del libro
            dtPrestamo.Columns.Add("Cantidad", typeof(int));
            dtPrestamo.Columns.Add("Autor", typeof(string));
            dtPrestamo.Columns.Add("Titulo", typeof(string));

            dtPrestamo.Columns["Cantidad"].DefaultValue = 1;
            dgvPrestamos.DataSource = dtPrestamo;

            if (dgvPrestamos.Columns["idLibro"] != null)
                dgvPrestamos.Columns["idLibro"].Visible = false;

            dgvPrestamos.Columns["Cantidad"].Width = 80;
            dgvPrestamos.Columns["Autor"].Width = 150;
            dgvPrestamos.Columns["Titulo"].Width = 241;


            dgvPrestamos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPrestamos.AllowUserToAddRows = false;
        }
        #endregion

        #region Buscar Usuarios


        private void BuscarUsuario()
        {
            try
            {
                string connetionString = ConexionDB.ObtenerConexion();
                using (SqlConnection conexion = new SqlConnection(connetionString))
                {
                    string consulta = @"
                        SELECT TOP 1 idUsuario, carnet, nombre, apellido
                        FROM Usuarios
                        WHERE carnet = @texto OR nombre LIKE @texto";

                    SqlCommand cmd = new SqlCommand(consulta, conexion);
                    cmd.Parameters.AddWithValue("@texto", "%" + txtBuscarUsuario.Text.Trim() + "%");
                    conexion.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        int idUsuario = reader.GetInt32(0);
                        string carnet = reader.GetString(1);
                        string nombre = reader.GetString(2);
                        string apellido = reader.GetString(3);

                        selectedUserId = idUsuario;
                        lblCarnetUsuario.Text = carnet;
                        lblNombreUsuario.Text = nombre + " " + apellido;

                        //  buscar de libros 
                        MostrarDatosUsuario();
                        MostrarBuscadorLibros();
                    }
                    else
                    {
                        MessageBox.Show("Usuario no encontrado.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar usuario: " + ex.Message);
            }
        }

        private void txtBuscarUsuario_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BuscarUsuario();
                e.SuppressKeyPress = true;
            }
        }

        #endregion

        #region Buscar Libros

        private void BuscarLibro()
        {
            try
            {
                string connetionString = ConexionDB.ObtenerConexion();
                using (SqlConnection conexion = new SqlConnection(connetionString))
                {
                    string consulta = @"
                        SELECT TOP 1 l.idLibro, l.titulo, a.nombre AS autor, l.estado
                        FROM Libros l
                        INNER JOIN Autores a ON l.idAutor = a.idAutor
                        WHERE l.titulo LIKE @texto OR a.nombre LIKE @texto";

                    SqlCommand cmd = new SqlCommand(consulta, conexion);
                    cmd.Parameters.AddWithValue("@texto", "%" + txtBuscarLibro.Text.Trim() + "%");
                    conexion.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        int idLibro = reader.GetInt32(0);
                        string titulo = reader.GetString(1);
                        string autor = reader.GetString(2);
                        string estado = reader.GetString(3);

                        lblTituloLibro.Text =  titulo;
                        lblAutorLibro.Text =  autor;
                        lblEstadoLibro.Text =  estado;

                        if (estado == "Activo")
                        {
                            AgregarLibroAPrestamo(idLibro, titulo, autor);
                            MostrarDatosLibro();
                        }
                        else
                        {
                            MessageBox.Show("El libro no está disponible.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Libro no encontrado.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar libro: " + ex.Message);
            }
        }

        private void txtBuscarLibro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BuscarLibro();
                e.SuppressKeyPress = true;
            }
        }

        #endregion


        #region Manejo de Préstamos
        private void AgregarLibroAPrestamo(int idLibro, string titulo, string autor)
        {
            DataRow existente = dtPrestamo.AsEnumerable()
                .FirstOrDefault(r => r.Field<int>("idLibro") == idLibro);

            if (existente != null)
            {
                existente["Cantidad"] = Convert.ToInt32(existente["Cantidad"]) + 1;
            }
            else
            {
                DataRow fila = dtPrestamo.NewRow();
                fila["idLibro"] = idLibro;
                fila["Cantidad"] = 1;
                fila["Autor"] = autor;
                fila["Titulo"] = titulo;
                dtPrestamo.Rows.Add(fila);
            }
        }

        private void QuitarLibroSeleccionado()
        {
            if (dgvPrestamos.CurrentRow != null)
            {
                dgvPrestamos.Rows.RemoveAt(dgvPrestamos.CurrentRow.Index);
            }
        }

        private bool ValidarAntesGuardar()
        {
            if (!selectedUserId.HasValue)
            {
                MessageBox.Show("Debe seleccionar un usuario.", "Falta usuario",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (dtPrestamo.Rows.Count == 0)
            {
                MessageBox.Show("Debe agregar al menos un libro.", "Falta libro",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (dtpFechaDevolucion.Checked && dtpFechaDevolucion.Value.Date < DateTime.Now.Date)
            {
                MessageBox.Show("La fecha de devolución debe ser mayor o igual a hoy.",
                    "Fecha inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void GuardarPrestamo()
        {
            if (!ValidarAntesGuardar()) return;

            DateTime fechaPrestamo = DateTime.Now;
            DateTime? fechaDevolucion = dtpFechaDevolucion.Checked
                ? (DateTime?)dtpFechaDevolucion.Value.Date : null;

            try
            {
                string connetionString = ConexionDB.ObtenerConexion();
                using (SqlConnection conexion = new SqlConnection(connetionString))
                {
                    conexion.Open();
                    using (SqlTransaction tr = conexion.BeginTransaction())
                    {
                        try
                        {
                            string insertPrestamo = @"
                                INSERT INTO Prestamos (idUsuario, fechaPrestamo, fechaDevolucion)
                                VALUES (@idUsuario, @fechaPrestamo, @fechaDevolucion);
                                SELECT CAST(SCOPE_IDENTITY() AS INT);";

                            int idPrestamo;
                            using (SqlCommand cmdPrestamo = new SqlCommand(insertPrestamo, conexion, tr))
                            {
                                cmdPrestamo.Parameters.AddWithValue("@idUsuario", selectedUserId.Value);
                                cmdPrestamo.Parameters.AddWithValue("@fechaPrestamo", fechaPrestamo);
                                cmdPrestamo.Parameters.AddWithValue("@fechaDevolucion",
                                    (object)fechaDevolucion ?? DBNull.Value);
                                idPrestamo = (int)cmdPrestamo.ExecuteScalar();
                            }

                            foreach (DataRow row in dtPrestamo.Rows)
                            {
                                string insertDetalle = @"
                                    INSERT INTO DetallePrestamos (idPrestamo, idLibro, cantidad)
                                    VALUES (@idPrestamo, @idLibro, @cantidad);";

                                string updateLibro = "UPDATE Libros SET estado = 'Inactivo' WHERE idLibro = @idLibro";

                                using (SqlCommand cmdDetalle = new SqlCommand(insertDetalle, conexion, tr))
                                {
                                    cmdDetalle.Parameters.AddWithValue("@idPrestamo", idPrestamo);
                                    cmdDetalle.Parameters.AddWithValue("@idLibro", (int)row["idLibro"]);
                                    cmdDetalle.Parameters.AddWithValue("@cantidad", Convert.ToInt32(row["Cantidad"]));
                                    cmdDetalle.ExecuteNonQuery();
                                }

                                using (SqlCommand cmdUpdate = new SqlCommand(updateLibro, conexion, tr))
                                {
                                    cmdUpdate.Parameters.AddWithValue("@idLibro", (int)row["idLibro"]);
                                    cmdUpdate.ExecuteNonQuery();
                                }
                            }

                            tr.Commit();
                            MessageBox.Show("Préstamo registrado con éxito.", "Éxito",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                            dtPrestamo.Clear();
                            selectedUserId = null;
                            txtBuscarUsuario.Text = "";
                            txtBuscarLibro.Text = "";
                            MostrarSoloBuscadorUsuario();
                        }
                        catch (Exception exTr)
                        {
                            tr.Rollback();
                            MessageBox.Show("Error guardando préstamo: " + exTr.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión: " + ex.Message);
            }
        }
        #endregion


        #region Botones de comando

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            GuardarPrestamo();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            QuitarLibroSeleccionado();
        }


        #endregion

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

