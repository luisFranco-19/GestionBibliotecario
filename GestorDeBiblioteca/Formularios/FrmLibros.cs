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
using System.Windows.Media;
using System.Windows.Shapes;
using static System.Resources.ResXFileRef;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace GestorDeBiblioteca
{
    public partial class FrmLibros : Form
    {
        public FrmLibros()
        {
            InitializeComponent();

            // eventos de teclado
            this.KeyPreview = true;
            //controles hijos 
            this.KeyPress += ValidacionEntrada.PasarFocus;
            this.KeyDown += ValidacionEntrada.ControlEsc;

            //txt.TabIndex = 0;
            //txt.TabIndex = 1;
            //txt.TabIndex = 2;
            //cmbEstado.TabIndex = 3;
            //txtAñoPublicacion.TabIndex = 4;
            //txtCantidad.TabIndex = 5;
            //btnAceptar.TabIndex = 6;


        }

        private void FrmLibros_Load(object sender, EventArgs e)
        {
            //cmbEstado.Items.Add("Activo");
            //cmbEstado.Items.Add("Inactivo");

            cmbEstado.SelectedIndex = 0;//Se muestra el primer Elemento de los Combo box
            cmbEstado.Enabled = false;//El combo box queda Desactivado cuando se inicializa el formulario
            listarRegistro();//Mandamos ah llamar al metodo para listar el data grid

            this.ActiveControl = txtTitulos;//Establece que el control del cursor del teclado estara  activo en txtTitulos
                                            //automaticamente al abrir el formulario.
            txtTitulos.Focus();
        }

        #region Metodos
        private bool validarControl()
        {
            errorIcono.Clear();// Limpiamos errores previos

            // creamos una lista en donde estaran los controladores del formulario
            var controles = new List<Control> { txtTitulos, txtAutor, txtAñoPublicacion , txtCantidad, txtNacionalidad};
            bool esValido = true;// Declaracion de una variable booleana que indica si los datos son validos

            // Recorre todos los controles y verifica si están vacios
            foreach (Control control in this.Controls)
            {
                if (control is Guna.UI2.WinForms.Guna2TextBox txt)
                {
                    if (string.IsNullOrWhiteSpace(txt.Text))
                    {
                        errorIcono.SetError(txt, "Este campo es requerido");
                        esValido = false;
                    }
                }
            }

            return esValido;
            //Si algún campo está vacio, devuelve false.
            //Si todos están llenos, devuelve true
        }

        private void Aceptar(string titulo, string nombreAutor, string nacionalidad, string fechaPublicacion, string estado, string cantidad)
        {   //se intenta convertir texto a numero entero.
            if (!int.TryParse(fechaPublicacion, out int anoPub))//Aqui se valida que el usuario no haya escrito letras o valores no numericos.
            {
                MessageBox.Show("El año de publicación debe ser un número válido", "Año inválido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(cantidad, out int cantidadCopias) || cantidadCopias <= 0) //convertir el valor de la cantidad
                                                                                        //que es unstring lo pasa a un numero entero
            {
                MessageBox.Show("La cantidad de copias es inválida. Debe existir una o más copias por libro.",
                    "Cantidad inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string connectionString = ConexionDB.ObtenerConexion();//se Obtiene la cadena de conexión configurada en la clase y
                                                                       //guardala en una variable para poder usarla en una conexión con SQL Server

                using (SqlConnection conexion = new SqlConnection(connectionString))//garantiza que la conexión secierre
                                                                                    //automaticamente al terminar, aunque haya errores.
                {
                    conexion.Open();
                    //Crea un comando SQL temporal que ejecutara el procedimiento almacenado
                    //usando la conexión abierta (conexion)
                    using (SqlCommand cmd = new SqlCommand("sp_InsertarLibro", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;//Se le indica que el comando que se ejecutara sera un
                                                                      //procedimiento almacenado y no una consulta

                        //Creacion de variables que enviaran los valores de esas variables al procedimiento almacenado en SQL
                        cmd.Parameters.AddWithValue("@Titulo", titulo);
                        cmd.Parameters.AddWithValue("@NombreAutor", nombreAutor);
                        cmd.Parameters.AddWithValue("@Nacionalidad", nacionalidad);
                        cmd.Parameters.AddWithValue("@Estado", estado);
                        cmd.Parameters.AddWithValue("@AnioPublicacion", anoPub);
                        cmd.Parameters.AddWithValue("@Cantidad", cantidadCopias);

                        cmd.ExecuteNonQuery(); //Abrimos la conexion para ejecutar el comando
                    }

                    MessageBox.Show("Libro y autor guardados con éxito.", "Información",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    listarRegistro();
                    limpiarControles();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el libro: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Actualizar(int idLibro, string titulo, string nombreAutor, string nacionalidad, string estado, int anioPublicacion, int cantidad)
        {
            try
            {
                string connectionString = ConexionDB.ObtenerConexion();
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_ActualizarLibro", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@IdLibro", idLibro);
                        cmd.Parameters.AddWithValue("@Titulo", titulo);
                        cmd.Parameters.AddWithValue("@NombreAutor", nombreAutor);
                        cmd.Parameters.AddWithValue("@Nacionalidad", nacionalidad);
                        cmd.Parameters.AddWithValue("@Estado", estado);
                        cmd.Parameters.AddWithValue("@AnioPublicacion", anioPublicacion);
                        cmd.Parameters.AddWithValue("@Cantidad", cantidad);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Registro actualizado con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listarRegistro();
                    limpiarControles();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el libro: " + ex.Message);
            }
        }

        private void Eliminar(int idLibro)//recibe el ID del libro que quieres eliminar
        {
            try
            {
                string connectionString = ConexionDB.ObtenerConexion();
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_EliminarLibro", conexion))// aqui ejecutamos el procedimiento almacenado 
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@IdLibro", idLibro);//pasa el ID del libro al procedimiento
                        cmd.ExecuteNonQuery();//ejecuta la eliminacion, ExecuteNonQuery solo se usa cuando no se espera ningun resultado
                    }

                    MessageBox.Show("Libro eliminado con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listarRegistro();
                    limpiarControles();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el libro: " + ex.Message);
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
            dgvListado.BackgroundColor = System.Drawing.Color.White;
            dgvListado.GridColor = System.Drawing.Color.LightGray;
            dgvListado.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvListado.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvListado.RowHeadersVisible = false;

            //  Encabezado 
            dgvListado.EnableHeadersVisualStyles = false;
            dgvListado.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(54, 69, 79);
            dgvListado.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            dgvListado.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvListado.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvListado.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Centrar texto en las celdas
            dgvListado.ColumnHeadersHeight = 35;

            // Filas 
            dgvListado.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            dgvListado.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            dgvListado.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvListado.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(136, 155, 168); // Color al seleccionar una columna
            dgvListado.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;

            // Filas alternas 
            dgvListado.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(219, 219, 219);

            // CONFIGURACIÓN MEJORADA 
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
            //borra todos los mensajes de error previos
            errorIcono.Clear();
            bool datosValidos = true;

            foreach (Control control in tableLayoutPanel1.Controls)//recorre todos los controles
            {
                if (control is Guna.UI2.WinForms.Guna2TextBox gunaTextBox)//Si este control es una caja de texto (de tipo Guna2TextBox),
                                                                          //entonces verifica si el campo está vacío o lleno solo de espacios.
                {
                    if (string.IsNullOrWhiteSpace(gunaTextBox.Text))
                    {
                        errorIcono.SetError(gunaTextBox, "Este campo es obligatorio. ");
                        datosValidos = false;//marca que falta información.
                    }
                }
            }
            //Si datosValidos es false, significa que al menos un campo estaba vacio.
            if (!datosValidos)
            {
                MessageBox.Show("Informacion incompleta, seran remarcados los datos que faltan. ",
                    "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;//salir del método (no se ejecuta nada mas hasta que se llenen los datos).
            }

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
            //borra todos los mensajes de error previos
            errorIcono.Clear();
            bool datosValidos = true;

            foreach (Control control in tableLayoutPanel1.Controls)//recorre todos los controles
            {
                if (control is Guna.UI2.WinForms.Guna2TextBox gunaTextBox)//Si este control es una caja de texto (de tipo Guna2TextBox),
                                                                          //entonces verifica si el campo está vacío o lleno solo de espacios.
                {
                    if (string.IsNullOrWhiteSpace(gunaTextBox.Text))
                    {
                        errorIcono.SetError(gunaTextBox, "Este campo es obligatorio. ");
                        datosValidos = false;//marca que falta información.
                    }
                }
            }
            //Si datosValidos es false, significa que al menos un campo estaba vacio.
            if (!datosValidos)
            {
                MessageBox.Show("Informacion incompleta, seran remarcados los datos que faltan. ",
                    "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;//salir del método (no se ejecuta nada mas hasta que se llenen los datos).
            }

            try
            {
                if (validarControl())
                {
                    string titulo = txtTitulos.Text.Trim();
                    string nombreAutor = txtAutor.Text.Trim();
                    string nacionalidad = txtNacionalidad.Text.Trim();
                    string estado = cmbEstado.Text.Trim();

                    // Convertir a int
                    if (!int.TryParse(txtAñoPublicacion.Text.Trim(), out int anioPublicacion))
                    {
                        MessageBox.Show("El año de publicación debe ser un número válido", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (!int.TryParse(txtCantidad.Text.Trim(), out int cantidad) || cantidad <= 0)
                    {
                        MessageBox.Show("La cantidad debe ser un número mayor que 0", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (string.IsNullOrWhiteSpace(txtId.Text))
                    {
                        Aceptar(titulo, nombreAutor, nacionalidad, anioPublicacion.ToString(), estado, cantidad.ToString());
                    }
                    else
                    {
                        int.TryParse(txtId.Text, out int idLibro);
                        Actualizar(idLibro, titulo, nombreAutor, nacionalidad, estado, anioPublicacion, cantidad);
                    }

                    btnAceptar.Visible = true;
                    cmbEstado.Enabled = false;

                }
                else
                {
                    MessageBox.Show("Información incompleta, serán remarcados los datos faltantes");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha generado un error inesperado: " + ex.Message);
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
                cmbEstado.Enabled = true;

                //Comprueba que el DataGridView tenga al menos una fila con registros.
                if (dgvListado.Rows.Count > 0 && dgvListado.CurrentRow != null)
                {
                    if (!int.TryParse(dgvListado.CurrentRow.Cells[0].Value?.ToString(), out int idLibro))//Obtenemos el ID del Usuario Selecionado
                    {   //Toma el valor de la primera columna (Cells[0]) de la fila seleccionada
                        //convertir el texto a numerico entero sin causar error si el valor no es Ententero y lo hacemos con un TryParse 
                        
                            MessageBox.Show("El ID no es válido", "Información", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
                        return;
                    }
                    //se copian los valores de la fila seleccionada en las cajas de texto correspondientes
                    txtId.Text = idLibro.ToString();
                    txtTitulos.Text = dgvListado.CurrentRow.Cells[1].Value?.ToString() ?? "";//dgvListado.CurrentRow.Cells[] obtiene el valor de
                                                                                             //cada celda
                    txtAutor.Text = dgvListado.CurrentRow.Cells[2].Value?.ToString() ?? "";
                    txtNacionalidad.Text = dgvListado.CurrentRow.Cells[3].Value?.ToString() ?? "";
                    cmbEstado.Text = dgvListado.CurrentRow.Cells[4].Value?.ToString() ?? "";
                    txtAñoPublicacion.Text = dgvListado.CurrentRow.Cells[5].Value?.ToString() ?? "";
                    txtCantidad.Text = dgvListado.CurrentRow.Cells[6].Value?.ToString() ?? "";

                    //Asi, las cajas de texto del formulario se rellenan automaticamente con los datos de la fila seleccionada.
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
