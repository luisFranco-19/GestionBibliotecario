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
            lblTituloLibro.Visible = false;
            lblAutorLibro.Visible = false;
            lblEstadoLibro.Visible = false;

            BotonesLayout.Visible = false;
            Carnet.Visible = true;
            Nombre.Visible = true;
            panelregistroLibros.Visible = true;

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
            panelregistroUsuarios.Visible = true;

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
            Titulo.Visible = true;
            Autor.Visible = true;
            Estado.Visible = true;
            BotonesLayout.Visible = true;
        }
        #endregion


        #region Inicializar tabla de préstamos
        private void InicializarPrestamoTable()
        {
            dtPrestamo = new DataTable();
            dtPrestamo.Columns.Add("idLibro", typeof(int));
            dtPrestamo.Columns.Add("Cantidad", typeof(int));
            dtPrestamo.Columns.Add("Autor", typeof(string));
            dtPrestamo.Columns.Add("Titulo", typeof(string));
            dtPrestamo.Columns.Add("NuevoPrestamo", typeof(bool));

            dtPrestamo.Columns["Cantidad"].DefaultValue = 1;
            dtPrestamo.Columns["NuevoPrestamo"].DefaultValue = true;

            dgvPrestamos.DataSource = dtPrestamo;

            if (dgvPrestamos.Columns["idLibro"] != null)
                dgvPrestamos.Columns["idLibro"].Visible = false;
            if (dgvPrestamos.Columns["NuevoPrestamo"] != null)
                dgvPrestamos.Columns["NuevoPrestamo"].Visible = false;

            dgvPrestamos.Columns["Cantidad"].Width = 80;
            dgvPrestamos.Columns["Autor"].Width = 150;
            dgvPrestamos.Columns["Titulo"].Width = 241;

            //  Estilo del data
            dgvPrestamos.BorderStyle = BorderStyle.None;
            dgvPrestamos.BackgroundColor = Color.White;
            dgvPrestamos.GridColor = Color.LightGray;
            dgvPrestamos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvPrestamos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvPrestamos.RowHeadersVisible = false;

            //  Encabezado 
            dgvPrestamos.EnableHeadersVisualStyles = false;
            dgvPrestamos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(33, 150, 243);
            dgvPrestamos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvPrestamos.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvPrestamos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPrestamos.ColumnHeadersHeight = 35;

            // Filas 
            dgvPrestamos.DefaultCellStyle.BackColor = Color.White;
            dgvPrestamos.DefaultCellStyle.ForeColor = Color.FromArgb(50, 50, 50);
            dgvPrestamos.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvPrestamos.DefaultCellStyle.SelectionBackColor = Color.FromArgb(187, 222, 251); // Color al seleccionar una columna
            dgvPrestamos.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvPrestamos.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Centrar texto en las celdas


            // Filas alternas 
            dgvPrestamos.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 248, 255);


            dgvPrestamos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPrestamos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPrestamos.MultiSelect = false;
            dgvPrestamos.RowTemplate.Height = 30;
        }


        
        #endregion



        #region Buscar Usuario
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
                        WHERE carnet LIKE @texto OR nombre LIKE @texto OR apellido LIKE @texto";

                    using (SqlCommand cmd = new SqlCommand(consulta, conexion))
                    {
                        cmd.Parameters.Add("@texto", SqlDbType.NVarChar, 200).Value = "%" + txtBuscarUsuario.Text.Trim() + "%";
                        conexion.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int idUsuario = reader.GetInt32(0);

                                string carnet = reader.IsDBNull(1) ? string.Empty : reader.GetString(1);
                                string nombre = reader.IsDBNull(2) ? string.Empty : reader.GetString(2);
                                string apellido = reader.IsDBNull(3) ? string.Empty : reader.GetString(3);

                                selectedUserId = idUsuario;
                                lblCarnetUsuario.Text = carnet;
                                lblNombreUsuario.Text = nombre + " " + apellido;

                                MostrarDatosUsuario();
                                CargarPrestamosUsuario(selectedUserId.Value);
                                MostrarBuscadorLibros();
                            }
                            else
                            {
                                MessageBox.Show("Usuario no encontrado.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar usuario: " + ex.Message + "\n" + ex.StackTrace);
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

        #region Buscar Libro
        //private void BuscarLibro()
        //{
        //    try
        //    {
        //        string connetionString = ConexionDB.ObtenerConexion();
        //        using (SqlConnection conexion = new SqlConnection(connetionString))
        //        {
        //            string consulta = @"
        //                SELECT TOP 1 l.idLibro, l.titulo, a.nombre AS autor, ISNULL(l.estado, '') AS estado, ISNULL(l.cantidad, 0) AS cantidad
        //                FROM Libros l
        //                INNER JOIN Autores a ON l.idAutor = a.idAutor
        //                WHERE l.titulo LIKE @texto OR a.nombre LIKE @texto";

        //            using (SqlCommand cmd = new SqlCommand(consulta, conexion))
        //            {
        //                cmd.Parameters.Add("@texto", SqlDbType.NVarChar, 200).Value = "%" + txtBuscarLibro.Text.Trim() + "%";
        //                conexion.Open();
        //                using (SqlDataReader reader = cmd.ExecuteReader())
        //                {
        //                    if (reader.Read())
        //                    {
        //                        int idLibro = reader.GetInt32(0);
        //                        string titulo = reader.IsDBNull(1) ? string.Empty : reader.GetString(1);
        //                        string autor = reader.IsDBNull(2) ? string.Empty : reader.GetString(2);
        //                        string estado = reader.IsDBNull(3) ? string.Empty : reader.GetString(3);
        //                        int cantidadDisponible = reader.IsDBNull(4) ? 0 : reader.GetInt32(4);

        //                        lblTituloLibro.Text = titulo;
        //                        lblAutorLibro.Text = autor;
        //                        lblEstadoLibro.Text = estado;

        //                        if (estado.Equals("Activo", StringComparison.OrdinalIgnoreCase) && cantidadDisponible > 0)
        //                        {
        //                            // No permitir agregar si ya existe en dtPrestamo (sea préstamo anterior o nuevo)
        //                            bool yaPrestado = dtPrestamo.AsEnumerable()
        //                                .Any(r => r.Field<int>("idLibro") == idLibro);

        //                            if (yaPrestado)
        //                            {
        //                                MessageBox.Show("El usuario ya tiene (o ya ha agregado) este libro.", "Aviso",
        //                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                                return;
        //                            }

        //                            AgregarLibroAPrestamo(idLibro, titulo, autor);
        //                            MostrarDatosLibro();
        //                            btnAgregar.Focus();
        //                        }
        //                        else
        //                        {
        //                            MessageBox.Show("El libro no está disponible.");
        //                        }
        //                    }
        //                    else
        //                    {
        //                        MessageBox.Show("Libro no encontrado.");
        //                    }
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error al buscar libro: " + ex.Message + "\n" + ex.StackTrace);
        //    }

        //}




        private void BuscarLibro()
        {
            try
            {
                string connetionString = ConexionDB.ObtenerConexion();
                using (SqlConnection conexion = new SqlConnection(connetionString))
                {
                    string consulta = @"
                    SELECT TOP 1 l.idLibro, l.titulo, a.nombre AS autor, ISNULL(l.estado, '') AS estado, ISNULL(l.cantidad, 0) AS cantidad
                    FROM Libros l
                    INNER JOIN Autores a ON l.idAutor = a.idAutor
                    WHERE l.titulo LIKE @texto OR a.nombre LIKE @texto";

                    using (SqlCommand cmd = new SqlCommand(consulta, conexion))
                    {
                        cmd.Parameters.Add("@texto", SqlDbType.NVarChar, 200).Value = "%" + txtBuscarLibro.Text.Trim() + "%";
                        conexion.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int idLibro = reader.GetInt32(0);
                                string titulo = reader.IsDBNull(1) ? string.Empty : reader.GetString(1);
                                string autor = reader.IsDBNull(2) ? string.Empty : reader.GetString(2);
                                string estado = reader.IsDBNull(3) ? string.Empty : reader.GetString(3);
                                int cantidadDisponible = reader.IsDBNull(4) ? 0 : reader.GetInt32(4);

                                lblTituloLibro.Text = titulo;
                                lblAutorLibro.Text = autor;
                                lblEstadoLibro.Text = estado;

                                // 🔸 VALIDAR FECHA DE DEVOLUCIÓN ANTES DE AGREGAR EL LIBRO
                                if (dtpFechaDevolucion.Value.Date <= DateTime.Today.Date)
                                {
                                    MessageBox.Show(
                                        "Debe establecer una fecha de devolución válida (posterior a hoy) antes de agregar el libro.",
                                        "Fecha inválida",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning
                                    );

                                    dtpFechaDevolucion.Focus();
                                    return;
                                }


                                if (estado.Equals("Activo", StringComparison.OrdinalIgnoreCase) && cantidadDisponible > 0)
                                {
                                    // No permitir agregar si ya existe en dtPrestamo (sea préstamo anterior o nuevo)
                                    bool yaPrestado = dtPrestamo.AsEnumerable()
                                        .Any(r => r.Field<int>("idLibro") == idLibro);

                                    if (yaPrestado)
                                    {
                                        MessageBox.Show("El usuario ya tiene (o ya ha agregado) este libro.", "Aviso",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        return;
                                    }

                                    AgregarLibroAPrestamo(idLibro, titulo, autor);
                                    MostrarDatosLibro();

                                    // ✅ Después de encontrar el libro, pasar el foco al botón Agregar
                                    btnAgregar.Focus();
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar libro: " + ex.Message + "\n" + ex.StackTrace);
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
                MessageBox.Show("Este libro ya fue agregado a los préstamos actuales.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataRow fila = dtPrestamo.NewRow();
            fila["idLibro"] = idLibro;
            fila["Cantidad"] = 1;
            fila["Titulo"] = titulo;
            fila["Autor"] = autor;
            fila["NuevoPrestamo"] = true;
            dtPrestamo.Rows.Add(fila);
        }

        private void QuitarLibroSeleccionado()
        {
            if (dgvPrestamos.CurrentRow != null)
                dgvPrestamos.Rows.RemoveAt(dgvPrestamos.CurrentRow.Index);
        }

        private bool ValidarAntesGuardar()
        {
            if (!selectedUserId.HasValue)
            {
                MessageBox.Show("Debe seleccionar un usuario.", "Falta usuario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (dtPrestamo.Rows.Count == 0)
            {
                MessageBox.Show("Debe agregar al menos un libro.", "Falta libro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validar fecha de devolución si está marcada
            if (dtpFechaDevolucion.Checked)
            {
                DateTime fechaDevolucion = dtpFechaDevolucion.Value.Date;
                if (fechaDevolucion <= DateTime.Now.Date)
                {
                    MessageBox.Show("La fecha de devolución debe ser mayor a la fecha actual.", "Fecha inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            return true;
        }

        private void GuardarPrestamo()
        {
            if (!ValidarAntesGuardar()) return;

            DateTime fechaPrestamo = DateTime.Now;
            DateTime? fechaDevolucion = dtpFechaDevolucion.Value.Date;

            // Validar que la fecha de devolución sea mayor a la fecha actual
            if (fechaDevolucion.HasValue && fechaDevolucion <= DateTime.Now.Date)
            {
                MessageBox.Show("La fecha de devolución debe ser mayor a la fecha actual.", "Fecha inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
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
                                            INSERT INTO Prestamos (idUsuario, fechaDevolucion)
                                            VALUES (@idUsuario, @fechaDevolucion);
                                            SELECT CAST(SCOPE_IDENTITY() AS INT);";

                            int idPrestamo;
                            using (SqlCommand cmdPrestamo = new SqlCommand(insertPrestamo, conexion, tr))
                            {
                                cmdPrestamo.Parameters.Add("@idUsuario", SqlDbType.Int).Value = selectedUserId.Value;
                                cmdPrestamo.Parameters.Add("@fechaDevolucion", SqlDbType.DateTime).Value = (object)fechaDevolucion ?? DBNull.Value;
                                idPrestamo = (int)cmdPrestamo.ExecuteScalar();
                            }
                            foreach (DataRow row in dtPrestamo.Rows)
                            {
                                bool esNuevo = Convert.ToBoolean(row["NuevoPrestamo"]);
                                if (!esNuevo) continue;

                                int idLibro = (int)row["idLibro"];
                                int cantidad = Convert.ToInt32(row["Cantidad"]);

                                    string insertDetalle = @"
                                                        INSERT INTO DetallePrestamos 
                                                        (idPrestamo, idLibro, cantidad, fechaDevolucion, estado)
                                                        VALUES 
                                                        (@idPrestamo, @idLibro, @cantidad, @fechaDevolucion, @estado)";


                                using (SqlCommand cmdDetalle = new SqlCommand(insertDetalle, conexion, tr))
                                {
                                    cmdDetalle.Parameters.Add("@idPrestamo", SqlDbType.Int).Value = idPrestamo;
                                    cmdDetalle.Parameters.Add("@idLibro", SqlDbType.Int).Value = idLibro;
                                    cmdDetalle.Parameters.Add("@cantidad", SqlDbType.Int).Value = cantidad;
                                    cmdDetalle.Parameters.Add("@fechaDevolucion", SqlDbType.DateTime).Value = (object)fechaDevolucion ?? DBNull.Value;
                                    cmdDetalle.Parameters.Add("@estado", SqlDbType.VarChar, 15).Value = "Prestado";
                                    cmdDetalle.ExecuteNonQuery();
                                }

                                string updateLibro = @"
                                    UPDATE Libros
                                    SET cantidad = cantidad - @cantidad,
                                        estado = CASE WHEN cantidad - @cantidad <= 0 THEN 'Inactivo' ELSE 'Activo' END
                                    WHERE idLibro = @idLibro";

                                using (SqlCommand cmdUpdate = new SqlCommand(updateLibro, conexion, tr))
                                {
                                    cmdUpdate.Parameters.Add("@idLibro", SqlDbType.Int).Value = idLibro;
                                    cmdUpdate.Parameters.Add("@cantidad", SqlDbType.Int).Value = cantidad;
                                    cmdUpdate.ExecuteNonQuery();
                                }
                            }

                            tr.Commit();
                            MessageBox.Show("Préstamo registrado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            dtPrestamo.Clear();
                            CargarPrestamosUsuario(selectedUserId.Value);
                            txtBuscarLibro.Text = "";
                            MostrarBuscadorLibros();
                        }
                        catch (Exception exTr)
                        {
                            tr.Rollback();
                            MessageBox.Show("Error guardando préstamo: " + exTr.Message + "\n" + exTr.StackTrace);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión: " + ex.Message + "\n" + ex.StackTrace);
            }
        }

        private void CargarPrestamosUsuario(int idUsuario)
        {
            try
            {
                dtPrestamo.Clear();

                string connectionString = ConexionDB.ObtenerConexion();
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    string consulta = @"
                            SELECT 
                                idUsuario,
                                idDetallePrestamo,
                                idLibro,
                                titulo,
                                autor,
                                cantidad,
                                fechaDevolucion,
                                estado,
                                fechaPrestamo
                              FROM vw_LibrosPrestados
                             WHERE idUsuario = @idUsuario
                             AND estado = 'Prestado'  
                            ORDER BY fechaPrestamo DESC;";

                    using (SqlCommand cmd = new SqlCommand(consulta, conexion))
                    {
                        cmd.Parameters.Add("@idUsuario", SqlDbType.Int).Value = idUsuario;
                        conexion.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                DataRow fila = dtPrestamo.NewRow();

                                fila["idLibro"] = reader.GetInt32(reader.GetOrdinal("idLibro"));
                                fila["Cantidad"] = reader.GetInt32(reader.GetOrdinal("cantidad"));
                                fila["Titulo"] = reader.IsDBNull(reader.GetOrdinal("titulo")) ? "" : reader.GetString(reader.GetOrdinal("titulo"));
                                fila["Autor"] = reader.IsDBNull(reader.GetOrdinal("autor")) ? "" : reader.GetString(reader.GetOrdinal("autor"));
                                fila["NuevoPrestamo"] = false;

                                dtPrestamo.Rows.Add(fila);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar préstamos del usuario: " + ex.Message);
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


        #region None
        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Titulo_Click(object sender, EventArgs e)
        {

        }

        private void lblNombreUsuario_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscarUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void FechaPrestamo_Click(object sender, EventArgs e)
        {

        }

        private void dgvPrestamos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        #endregion

    }
}

