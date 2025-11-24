using app.Banco.Utilidades;
using FontAwesome.Sharp;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace GestorDeBiblioteca
{
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();

            // eventos de teclado
            this.KeyPreview = true; // interseccion antes de resivir los controladores hijos

            //controles hijos 
            this.KeyPress += ValidacionEntrada.PasarFocus; // pasar el focus
            this.KeyDown += ValidacionEntrada.ControlEsc; // cerrar con ESC

            //Orden logico de la tabulacion de los campos
            txtCarnet.TabIndex = 0;
            txtNombres.TabIndex = 1;
            txtApellidos.TabIndex = 2;
            txtTelefonos.TabIndex = 3;
            txtEmail.TabIndex = 4;
            cbmCargos.TabIndex = 5;
            btnAceptar.TabIndex = 6;

        }

        
        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            //Mostramos la fecha actual
            lbFecha.Text = DateTime.Now.ToShortDateString();

            //Inicialisar los valores del ComboBox de cargos
            //cbmCargos.Items.Add("Docente");
            //cbmCargos.Items.Add("Alumno");
            cbmCargos.SelectedIndex = 0;

            listarRegistro();
            btnEliminar.Enabled = false;
            //Focus inicial en carnet
            this.ActiveControl = txtCarnet;
            txtCarnet.Focus();
        }

        #region Metodos
        private bool validarControl()
        {
            errorIcono.Clear(); // Limpiamos errores previos

            // creamos una lista en donde estaran los controladores del formulario
            var controles = new List<Control> { txtNombres, txtApellidos, txtTelefonos, txtEmail, cbmCargos };

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
        private void Aceptar(string carnet, string nombre, string apellidos, string telefono, string email, string cargo)
        {
            try
            {
                string connectionString = ConexionDB.ObtenerConexion();////se Obtiene la cadena de conexión configurada en la clase y
                                                                       //guardala en una variable para poder usarla en una conexión con SQL Server

                using (SqlConnection conexion = new SqlConnection(connectionString))//garantiza que la conexión se
                                                                                    //cierre automáticamente al terminar, aunque haya errores.

                //Crea un comando SQL temporal que ejecutara el procedimiento almacenado
                //usando la conexión abierta (conexion)
                using (SqlCommand command = new SqlCommand("sp_InsertarUsuario", conexion))
                {
                    command.CommandType = CommandType.StoredProcedure;//Se le indica que el comando que se ejecutara sera un
                                                                      //procedimiento almacenado y no una consulta

                    //Creacion de variables que enviaran los valores de esas variables al procedimiento almacenado en SQL
                    command.Parameters.AddWithValue("@Carnet", carnet);
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@Apellido", apellidos);
                    command.Parameters.AddWithValue("@Telefono", telefono);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Cargo", cargo);

                    command.Parameters.AddWithValue("@FechaRegistro", DateTime.Now);
                    conexion.Open(); //Abrimos la conexion para ejecutar el comando

                    int result = command.ExecuteNonQuery();// nos devuelve el número de filas afectadas

                    //Si se inserto al menos un registro,
                    //mostramos el mensaje de exito, actualiza la lista el data gripd y limpia los campos
                    if (result > 0)
                    {
                        MessageBox.Show("Registro almacenado con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        listarRegistro();
                        limpiarControles();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo guardar el registro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (SqlException ex) //problemas con la base de datos
            {
                MessageBox.Show("Error de SQL: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex) //Cualquier otro error inesperado
            {
                MessageBox.Show("Error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Actualizar(int idUsuario, string carnet, string nombre, string apellido, string telefono, string email, string cargo)
        {
            try
            {
                string connectionString = ConexionDB.ObtenerConexion();

                using (SqlConnection conexion = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand("sp_ActualizarUsuario", conexion))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@IdUsuario", idUsuario);
                    command.Parameters.AddWithValue("@Carnet", carnet);
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@Apellido", apellido);
                    command.Parameters.AddWithValue("@Telefono", telefono);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Cargo", cargo);

                    conexion.Open();
                    int result = command.ExecuteNonQuery();// nos devuelve el número de filas afectadas

                    if (result > 0)
                    {
                        MessageBox.Show("Registro actualizado con éxito.", "Información",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        listarRegistro();
                        limpiarControles();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar el registro.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error de SQL: " + ex.Message, "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado al actualizar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Eliminar(int idUsuario)// como parametro el metodo resive el ID del Usuario
        {
            try
            {
                string connectionString = ConexionDB.ObtenerConexion();// Optenemos la cadena de conexion con la base de datos

                using (SqlConnection conexion = new SqlConnection(connectionString)) // creamos una conexion con el procedimeinto almacenado
                using (SqlCommand command = new SqlCommand("sp_EliminarUsuario", conexion))// aqui ejecutamos el procedimiento almacenado 
                {
                    //Indica que se usaremos el procedimiento almacenado y
                    //se enviara el parametro @IdUsuario con el valor del usuario a eliminar.
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@IdUsuario", idUsuario);


                    conexion.Open();//Abre la conexion y ejecuta el procedimiento.
                    command.ExecuteNonQuery();//ejecuta la instrucción sin devolver filas y lugo mostramos el mensaje

                    MessageBox.Show("Usuario eliminado con éxito.", "Información",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Limpiamos las cajas de texto y limpiamos el Datagripw
                    listarRegistro();
                    limpiarControles();
                }
            }
            catch (SqlException ex)//problemas de conexión o restricciones de la base de datos.
            {
                
                MessageBox.Show("No se pudo eliminar el usuario: " + ex.Message,
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)//cualquier otro error inesperado que no sea SQL.
            {
                MessageBox.Show("Error inesperado al eliminar: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void listarRegistro()
        {
            try
            {
                string connetionString = ConexionDB.ObtenerConexion();

                using (SqlConnection conexion = new SqlConnection(connetionString))//Crea una conexion SQL que se
                                                                                   //cierra automaticamente al terminar
                {
                    string consultaSql = "SELECT * FROM Usuarios ORDER BY IdUsuario DESC";
                    SqlDataAdapter adapter = new SqlDataAdapter(consultaSql, conexion); //ejecuta la consulta y se
                                                                                        //llena el DataTable con los resultados.
                    DataTable dt = new DataTable();//contiene todos los
                                                   //registros de la tabla
                    adapter.Fill(dt);

                    dgvListado.DataSource = dt;//Mostramos los datos en el DataGridView
                    formatoGrid();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar registros: " + ex);
            }


           
        }
        private void formatoGrid()
        {
            //Cambio de los nombres de los encabezado y el ancho de cada columna.
            dgvListado.Columns[0].Visible = false; // idUsuario
            dgvListado.Columns[1].HeaderText = "CARNET"; dgvListado.Columns[1].Width = 100;
            dgvListado.Columns[2].HeaderText = "NOMBRE"; dgvListado.Columns[2].Width = 180;
            dgvListado.Columns[3].HeaderText = "APELLIDO"; dgvListado.Columns[3].Width = 180;
            dgvListado.Columns[4].HeaderText = "TELEFONO"; dgvListado.Columns[4].Width = 110;
            dgvListado.Columns[5].HeaderText = "EMAIL"; dgvListado.Columns[5].Width = 170;
            dgvListado.Columns[6].HeaderText = "CARGO"; dgvListado.Columns[6].Width = 90;
            dgvListado.Columns[7].HeaderText = "FECHA REGISTRO"; dgvListado.Columns[7].Width = 200;


            //  Estilo del data
            //Quita los bordes innecesarios y define colores de fondo y de líneas.
            dgvListado.BorderStyle = BorderStyle.None;
            dgvListado.BackgroundColor = System.Drawing.Color.White;
            dgvListado.GridColor = System.Drawing.Color.Gray;
            dgvListado.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvListado.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvListado.RowHeadersVisible = false;

            //  Encabezado 
            //Cambia color, fuente y alineación del encabezado.
            //Desactiva estilos visuales predeterminados  la personalizacion.
            dgvListado.EnableHeadersVisualStyles = false;
            dgvListado.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(54, 69, 79);
            dgvListado.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            dgvListado.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvListado.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvListado.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Centrar texto en las celdas
            dgvListado.ColumnHeadersHeight = 35;

            // Filas 
            dgvListado.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            dgvListado.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);//Define colores de texto y fondo.
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
            txtNombres.Clear();
            txtApellidos.Clear();
            txtTelefonos.Clear();
            txtEmail.Clear();
            txtCarnet.Clear();


        }



        #endregion

        #region Botones de Comando
        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
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
                    string carnet = txtCarnet.Text.Trim();//Cada valor se toma del campo correspondiente y
                                                          //se usa .Trim() para quitar espacios al inicio o final.
                    string nombre = txtNombres.Text.Trim();
                    string apellidos = txtApellidos.Text.Trim();
                    string telefono = txtTelefonos.Text.Trim();
                    string email = txtEmail.Text.Trim();
                    string cargo = cbmCargos.Text.Trim();


                    Aceptar(carnet, nombre, apellidos, telefono, email, cargo);// Llamamos al metodo aceptar
                    limpiarControles();//Limpiamos las cajas de texto
                    txtCarnet.Focus();
                    btnEliminar.Enabled = false;

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
                    //Obtener los datos de las Variables y se preparan para enviarse al metodo
                    //que se actualizara en la base de datos.
                    string carnet = txtCarnet.Text.Trim();
                    string nombre = txtNombres.Text.Trim();
                    string apellidos = txtApellidos.Text.Trim();
                    string telefono = txtTelefonos.Text.Trim();
                    string email = txtEmail.Text.Trim();
                    string cargo = cbmCargos.Text.Trim();

                    // Si el Id esta vasio No hay ningún ID cargado,  entonces significa que es un nuevo usuario.
                    if (string.IsNullOrWhiteSpace(txtId.Text))
                    {
                        //Llamamos al metodo Aceptar para Insertar un Usuario
                        Aceptar(carnet, nombre, apellidos, telefono, email, cargo);
                    }
                    else
                    {   // De lo contrario si el ID tiene un valor y significa que se ha seleccionado un usuario existente desde la tabla
                        int.TryParse(txtId.Text, out int idUsuario);//convierte el texto del ID a nnmero entero.

                        //Luego llama al metodo Actualizar pasando el idUsuario junto con los demas datos
                        Actualizar(idUsuario, carnet, nombre, apellidos, telefono, email, cargo);

                    }
                    //Escondemos el Boton Acepatar Ala ahora de Actualizar un registro
                    btnAceptar.Visible = true;
                    txtCarnet.Focus();
                    btnEliminar.Enabled = false;



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
        {   //Verificamos si hay una fila Selecionada en el DataGrid
            if (dgvListado.SelectedRows.Count > 0)
            {
                try
                {
                    if (MessageBox.Show("Seguro que desea eliminar este registro?", "Confirmacion", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int.TryParse(dgvListado.CurrentRow.Cells[0].Value.ToString(), out int idUsuario);//Obtenemos el ID del Usuario Selecionado
                        //Toma el valor de la primera columna (Cells[0]) de la fila seleccionada
                        //convertir el texto a numerico entero sin causar error si el valor no es Ententero y lo hacemos con un TryParse 

                        Eliminar(idUsuario);
                        limpiarControles();
                        btnAceptar.Visible = true;
                        txtCarnet.Focus();
                        btnEliminar.Enabled = false;

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

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            limpiarControles();
            btnAceptar.Visible = true;
            txtCarnet.Focus();
            btnEliminar.Enabled = false;
            btnAceptar.Enabled = true;

        }

        #endregion

        #region Data Griwd
        private void dgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Comprueba que el DataGridView tenga al menos una fila con registros.
                if (dgvListado.Rows.Count > 0)
                {

                    if (!int.TryParse(dgvListado.CurrentRow.Cells[0].Value?.ToString(), out int idUsuario))//Obtenemos el ID del Usuario Selecionado
                    {   //Toma el valor de la primera columna (Cells[0]) de la fila seleccionada
                        //convertir el texto a numerico entero sin causar error si el valor no es Ententero y lo hacemos con un TryParse 

                        MessageBox.Show("El ID no es Valido", "Informacion", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);//Si el valor no es un número valido, muestra un mensaje y sale del metodo
                        return;
                    }


                    //se copian los valores de la fila seleccionada en las cajas de texto correspondientes
                    txtId.Text = idUsuario.ToString();
                    txtCarnet.Text = dgvListado.CurrentRow.Cells[1].Value?.ToString() ?? "";//dgvListado.CurrentRow.Cells[] obtiene el valor de
                                                                                            //cada celda

                    txtNombres.Text = dgvListado.CurrentRow.Cells[2].Value?.ToString() ?? "";
                    txtApellidos.Text = dgvListado.CurrentRow.Cells[3].Value?.ToString() ?? "";
                    txtTelefonos.Text = dgvListado.CurrentRow.Cells[4].Value?.ToString() ?? "";
                    txtEmail.Text = dgvListado.CurrentRow.Cells[5].Value?.ToString() ?? "";
                    cbmCargos.Text = dgvListado.CurrentRow.Cells[6].Value?.ToString() ?? "";

                    //Asi, las cajas de texto del formulario se rellenan automaticamente con los datos de la fila seleccionada.
                    btnEliminar.Enabled = true;
                    btnAceptar.Enabled = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar; " + ex);
            }

         

        }
        #endregion

        #region None
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbFecha_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        #endregion

    }
}