using app.Banco.Utilidades;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace GestorDeBiblioteca
{
    public partial class FrmLibros : Form
    {
        public FrmLibros()
        {
            InitializeComponent();

           
            this.KeyPreview = true;
            this.KeyPress += ValidacionEntrada.PasarFocus;
            this.KeyDown += ValidacionEntrada.ControlEsc;

            txtTitulos.TabIndex = 0;
            txtAutor.TabIndex = 1;
            txtNacionalidad.TabIndex = 2;
            cmbEstado.TabIndex = 3;
            txtAñoPublicacion.TabIndex = 4;
            txtCantidad.TabIndex = 5;
            btnAceptar.TabIndex = 6;


        }

        private void FrmLibros_Load(object sender, EventArgs e)
        {
            cmbEstado.Items.Add("Activo");
            cmbEstado.Items.Add("Inactivo");
            cmbEstado.SelectedIndex = 0;
            listarRegistro();

            this.ActiveControl = txtTitulos;
            txtTitulos.Focus();
        }

        #region Metodos
        private bool validarControl()
        {
            errorIcono.Clear();

            var controles = new List<Control> { txtTitulos, txtAutor, txtAñoPublicacion , txtCantidad, txtNacionalidad};
            bool esValido = true;
            foreach (Control control in controles)
            {
                if (control.Text.Trim() == string.Empty)
                {
                    errorIcono.SetError(control, "Este campo es requerido");
                    esValido = false;

                }
                txtTitulos.Focus();
            }
            if (!esValido)
                return false;

            return true;

        }

        private void Aceptar(string titulo, string nombreAutor, string nacionalidad, string fechaPublicacion, string estado, string cantidad)
        {

            if (!int.TryParse(fechaPublicacion, out int anoPub))
            {
                MessageBox.Show("El año de publicación debe ser un número válido", "Año inválido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(cantidad, out int cantidadCopias) || cantidadCopias <= 0)
            {
                MessageBox.Show("La cantidad de copias es invalida debe exister una o mas copias por libro", "Cantidad inválida",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTitulos.Focus();
                return;
            }
            try
            {
                string connetionString = ConexionDB.ObtenerConexion();
                using (SqlConnection conexion = new SqlConnection(connetionString))
                {
                    conexion.Open();
                    SqlTransaction transaction = conexion.BeginTransaction();

                    try
                    {
                       
                        string sqlBuscarAutor = @"SELECT idAutor 
                                                FROM Autores
                                                WHERE nombre = @Nombre
                                                AND nacionalidad = @Nacionalidad";

                        SqlCommand cmdBuscar = new SqlCommand(sqlBuscarAutor, conexion, transaction);
                        cmdBuscar.Parameters.AddWithValue("@Nombre", nombreAutor);
                        cmdBuscar.Parameters.AddWithValue("@Nacionalidad", nacionalidad);

                        object resultado = cmdBuscar.ExecuteScalar();
                        int idAutor;

                        if (resultado != null)
                        {
                            idAutor = Convert.ToInt32(resultado); 
                        }
                        else
                        {
                           
                            string sqlInsertarAutor = @"INSERT INTO Autores (nombre, nacionalidad)
                                                        VALUES (@Nombre, 
                                                        @Nacionalidad);
                                                        SELECT SCOPE_IDENTITY();";

                            SqlCommand cmdInsertAutor = new SqlCommand(sqlInsertarAutor, conexion, transaction);
                            cmdInsertAutor.Parameters.AddWithValue("@Nombre", nombreAutor);
                            cmdInsertAutor.Parameters.AddWithValue("@Nacionalidad", nacionalidad);
                            idAutor = Convert.ToInt32(cmdInsertAutor.ExecuteScalar());
                        }

                        
                        string sqlInsertarLibro = @"INSERT INTO Libros (titulo, idAutor, estado, 
                                                    anioPublicacion, cantidad)
                                                    VALUES (@Titulo,
                                                    @IdAutor,
                                                    @Estado,
                                                    @AnoPublicacion,
                                                    @Cantidad)";

                        SqlCommand cmdInsertLibro = new SqlCommand(sqlInsertarLibro, conexion, transaction);
                        cmdInsertLibro.Parameters.AddWithValue("@Titulo", titulo);
                        cmdInsertLibro.Parameters.AddWithValue("@IdAutor", idAutor);
                        cmdInsertLibro.Parameters.AddWithValue("@Estado", estado);
                        cmdInsertLibro.Parameters.AddWithValue("@AnoPublicacion", anoPub);
                        cmdInsertLibro.Parameters.AddWithValue("@Cantidad", cantidadCopias);


                        int result = cmdInsertLibro.ExecuteNonQuery();

                        transaction.Commit();

                        if (result > 0)
                        {
                            MessageBox.Show("Libro y autor guardados con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            listarRegistro();
                            limpiarControles();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo guardar el registro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch
                    {
                        transaction.Rollback();
                        MessageBox.Show("Error al guardar libro y autor. Se ha revertido la operación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex);
            }
        }
        private void listarRegistro()
        {
            try
            {
                string connetionString = ConexionDB.ObtenerConexion();
                using (SqlConnection conexion = new SqlConnection(connetionString))
                {
                    string consultaSql = @"SELECT 
                                    l.idLibro, 
                                    l.titulo, 
                                    a.nombre AS autor,
                                    a.nacionalidad, 
                                    l.estado,
                                    l.anioPublicacion, 
                                    l.cantidad
                      FROM Libros l INNER JOIN Autores a ON l.idAutor = a.idAutor";

                    SqlDataAdapter adapter = new SqlDataAdapter(consultaSql, conexion);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvListado.DataSource = dt;
                    formatoGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar registros: " + ex.Message);
            }

        }
        private void formatoGrid()
        {
            dgvListado.Columns[0].Visible = false;
            dgvListado.Columns[1].HeaderText = "TITULO";
            dgvListado.Columns[1].Width = 170;

            dgvListado.Columns[2].HeaderText = "AUTOR";
            dgvListado.Columns[2].Width = 150;

            dgvListado.Columns[3].HeaderText = "NACIONALIDAD";
            dgvListado.Columns[3].Width = 150;

            dgvListado.Columns[4].HeaderText = "ESTADO";
            dgvListado.Columns[4].Width = 100;

            dgvListado.Columns[5].HeaderText = "AÑO PUBLICACIÓN";
            dgvListado.Columns[5].Width = 150;

            dgvListado.Columns[6].HeaderText = "COPIAS";
            dgvListado.Columns[6].Width = 150;


            //  Estilo del data
            dgvListado.BorderStyle = BorderStyle.None;
            dgvListado.BackgroundColor = Color.White;
            dgvListado.GridColor = Color.LightGray;
            dgvListado.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvListado.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvListado.RowHeadersVisible = false;

            //  Encabezado 
            dgvListado.EnableHeadersVisualStyles = false;
            dgvListado.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(54, 69, 79);
            dgvListado.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvListado.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvListado.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvListado.ColumnHeadersHeight = 35;

            // Filas 
            dgvListado.DefaultCellStyle.BackColor = Color.White;
            dgvListado.DefaultCellStyle.ForeColor = Color.FromArgb(50, 50, 50);
            dgvListado.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvListado.DefaultCellStyle.SelectionBackColor = Color.FromArgb(136, 155, 168); // Color al seleccionar una columna
            dgvListado.DefaultCellStyle.SelectionForeColor = Color.Black;

            // Filas alternas 
            dgvListado.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(219, 219, 219);

            // CONFIGURACIÓN MEJORADA PARA EL PROBLEMA DEL COLOR AZUL
            dgvListado.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListado.MultiSelect = false;
            dgvListado.RowTemplate.Height = 30;

            // Deshabilitar la selección de celdas individuales
            dgvListado.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            // Asegurar que solo se seleccionen filas completas
            dgvListado.ColumnHeadersDefaultCellStyle.SelectionBackColor = dgvListado.ColumnHeadersDefaultCellStyle.BackColor;
            dgvListado.ColumnHeadersDefaultCellStyle.SelectionForeColor = dgvListado.ColumnHeadersDefaultCellStyle.ForeColor;

            // Deshabilitar el enfoque visual en celdas individuales
            dgvListado.ShowCellToolTips = false;
            dgvListado.StandardTab = true;

            dgvListado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void Actualizar(int idLibro, string titulo, string nombreAutor, string nacionalidad, string estado, string fechaPublicacion, string cantidad)
        {
          
            try
            {
                string connetionString = ConexionDB.ObtenerConexion();
                using (SqlConnection conexion = new SqlConnection(connetionString))
                {
                    conexion.Open();

                    
                    string consultaAutor = @"SELECT idAutor FROM Libros WHERE idLibro = @idLibro";
                    int idAutor = 0;

                    using (SqlCommand cmdAutor = new SqlCommand(consultaAutor, conexion))
                    {
                        cmdAutor.Parameters.AddWithValue("@idLibro", idLibro);
                        object result = cmdAutor.ExecuteScalar();
                        if (result != null)
                        {
                            idAutor = Convert.ToInt32(result);
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el libro especificado.");
                            return;
                        }
                    }

                   
                    string consultaUpdateAutor = @"UPDATE Autores 
                                                    SET nombre = @NombreAutor, 
                                                    nacionalidad = @Nacionalidad 
                                                    WHERE idAutor = @idAutor";
                    using (SqlCommand cmdUpdateAutor = new SqlCommand(consultaUpdateAutor, conexion))
                    {
                        cmdUpdateAutor.Parameters.AddWithValue("@NombreAutor", nombreAutor);
                        cmdUpdateAutor.Parameters.AddWithValue("@Nacionalidad", nacionalidad);
                        cmdUpdateAutor.Parameters.AddWithValue("@idAutor", idAutor);
                        cmdUpdateAutor.ExecuteNonQuery();
                    }

               
                    string consultaUpdateLibro = @"UPDATE Libros 
                                                 SET titulo = @Titulo, 
                                                estado = @Estado,
                                                anioPublicacion = @AnioPublicacion,
                                                cantidad = @Cantidad 
                                                WHERE idLibro = @idLibro";

                    using (SqlCommand cmdUpdateLibro = new SqlCommand(consultaUpdateLibro, conexion))
                    {
                        cmdUpdateLibro.Parameters.AddWithValue("@Titulo", titulo);
                        cmdUpdateLibro.Parameters.AddWithValue("@Estado", estado);
                        cmdUpdateLibro.Parameters.AddWithValue("@AnioPublicacion", fechaPublicacion);
                        cmdUpdateLibro.Parameters.AddWithValue("@Cantidad", cantidad);
                        cmdUpdateLibro.Parameters.AddWithValue("@idLibro", idLibro);

                        int result = cmdUpdateLibro.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Registro actualizado con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se pudo actualizar el registro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    listarRegistro();
                    limpiarControles();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado al actualizar: " + ex.Message);
            }
        }
        private void Eliminar(int idLibro)
        {
            try
            {
                string connectionString = ConexionDB.ObtenerConexion();

                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();

                    //  Verificar si el libro tiene préstamos ACTIVOS (sin devolver)
                    string sqlCheck = @"
                    SELECT COUNT(*) 
                    FROM DetallePrestamos 
                    WHERE idLibro = @idLibro AND fechaDevolucion IS NULL";

                    SqlCommand checkCmd = new SqlCommand(sqlCheck, conexion);
                    checkCmd.Parameters.AddWithValue("@idLibro", idLibro);
                    int countPrestamosActivos = (int)checkCmd.ExecuteScalar();

                    if (countPrestamosActivos > 0)
                    {
                        MessageBox.Show(
                            "No se puede eliminar este libro porque tiene préstamos activos.",
                            "Advertencia",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );
                        return;
                    }

                    // 2️ Si tiene préstamos pero ya están devueltos, eliminar historial antes
                    string deleteDetalle = @"DELETE FROM DetallePrestamos WHERE idLibro = @idLibro";
                    SqlCommand cmdDetalle = new SqlCommand(deleteDetalle, conexion);
                    cmdDetalle.Parameters.AddWithValue("@idLibro", idLibro);
                    cmdDetalle.ExecuteNonQuery();

                    string deletePrestamos = @"
                                    DELETE FROM Prestamos 
                                    WHERE idPrestamo NOT IN (SELECT idPrestamo FROM DetallePrestamos)
                                                                    ";
                    SqlCommand cmdPrestamos = new SqlCommand(deletePrestamos, conexion);
                    cmdPrestamos.ExecuteNonQuery();

                    // 3️⃣ Eliminar el libro
                    string deleteLibro = @"DELETE FROM Libros WHERE idLibro = @idLibro";
                    SqlCommand cmdLibro = new SqlCommand(deleteLibro, conexion);
                    cmdLibro.Parameters.AddWithValue("@idLibro", idLibro);
                    int result = cmdLibro.ExecuteNonQuery();

                    if (result > 0)
                        MessageBox.Show("Libro eliminado con éxito.", "Información",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("No se pudo eliminar el libro.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);

                    listarRegistro(); // Recargar DataGridView
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado al eliminar libro: " + ex.Message);
            }
        }

        private void limpiarControles()
        {
            txtTitulos.Clear();
            txtAutor.Clear();
            txtAñoPublicacion.Clear();
            txtNacionalidad.Clear();
            txtCantidad.Clear();


        }


        #endregion


        #region Botones de Comando
       

        private void btnAcepatr_Click(object sender, EventArgs e)
        {
            try
            {
                if (validarControl())
                {
                    string titulo = txtTitulos.Text.Trim();
                    string nombreAutor = txtAutor.Text.Trim();
                    string nacionalidad = txtNacionalidad.Text.Trim();
                    string fechaPublicacion = txtAñoPublicacion.Text.Trim();
                    string estado = cmbEstado.Text.Trim();
                    string cantidad = txtCantidad.Text.Trim();


                    Aceptar(titulo, nombreAutor, nacionalidad, fechaPublicacion, estado, cantidad);
                    limpiarControles();
                }
                else
                {
                    MessageBox.Show("Seran remarcados los datos faltantes", "Informacion incompleta",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha generado un error inesperado" + ex);
            }
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (validarControl())
                {
                    string titulo = txtTitulos.Text.Trim();
                    string nombreAutor = txtAutor.Text.Trim();
                    string nacionalidad = txtNacionalidad.Text.Trim();
                    string fechaPublicacion = txtAñoPublicacion.Text.Trim();
                    string estado = cmbEstado.Text.Trim();
                    string cantidad = txtCantidad.Text.Trim();

                    if (string.IsNullOrWhiteSpace(txtId.Text))
                    {
                        Aceptar(titulo, nombreAutor, nacionalidad, fechaPublicacion, estado, cantidad);
                    }
                    else
                    {
                        int.TryParse(txtId.Text, out int idLibro);
                        Actualizar(idLibro, titulo, nombreAutor, nacionalidad, estado, fechaPublicacion, cantidad);

                    }

                    btnAceptar.Visible = true;

                }
                else
                {
                    MessageBox.Show("Informacion incompleta, Seram remarcados los datos faltantes");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha generado un error inesperado" + ex);
            }
        }
        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (dgvListado.SelectedRows.Count > 0)
            {
                try
                {
                    if (MessageBox.Show("Seguro que desea eliminar este registro?", "Confirmacion", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int.TryParse(dgvListado.CurrentRow.Cells[0].Value.ToString(), out int idUsuario);

                        
                        Eliminar(idUsuario);
                        limpiarControles();
                        btnAceptar.Visible = true;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Se ha generado un error " + ex);
                }
               
            }
            else
            {
                MessageBox.Show("Seleccione un registro para eliminar", "Errro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            limpiarControles();
        }

        #endregion


        #region Data Griwd
        private void dgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvListado.Rows.Count > 0 && dgvListado.CurrentRow != null)
                {
                    if (!int.TryParse(dgvListado.CurrentRow.Cells[0].Value?.ToString(), out int idLibro))
                    {
                        MessageBox.Show("El ID no es válido", "Información", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
                        return;
                    }

                    txtId.Text = idLibro.ToString();
                    txtTitulos.Text = dgvListado.CurrentRow.Cells[1].Value?.ToString() ?? "";
                    txtAutor.Text = dgvListado.CurrentRow.Cells[2].Value?.ToString() ?? "";
                    txtNacionalidad.Text = dgvListado.CurrentRow.Cells[3].Value?.ToString() ?? "";
                    cmbEstado.Text = dgvListado.CurrentRow.Cells[4].Value?.ToString() ?? "";
                    txtAñoPublicacion.Text = dgvListado.CurrentRow.Cells[5].Value?.ToString() ?? "";
                    txtCantidad.Text = dgvListado.CurrentRow.Cells[6].Value?.ToString() ?? "";

                    btnAceptar.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el registro para editar: " + ex.Message);
            }

        }
        #endregion


        #region None

        private void FrmLibros_Shown(object sender, EventArgs e)
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

     
    }
}
