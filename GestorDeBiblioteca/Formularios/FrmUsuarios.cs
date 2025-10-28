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

namespace GestorDeBiblioteca
{
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();

            this.KeyPreview = true;
            this.KeyPress += ValidacionEntrada.PasarFocus;
            this.KeyDown += ValidacionEntrada.ControlEsc;

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

            lbFecha.Text = DateTime.Now.ToShortDateString();

            cbmCargos.Items.Add("Docente");
            cbmCargos.Items.Add("Alumno");
            cbmCargos.SelectedIndex = 0;
            listarRegistro();

            this.ActiveControl = txtCarnet;
            txtCarnet.Focus();
        }

        #region Metodos
        private bool validarControl()
        {
            errorIcono.Clear();

            var controles = new List<Control> { txtNombres, txtApellidos, txtTelefonos, txtEmail, cbmCargos };
            bool esValido = true;
            foreach (Control control in controles)
            {
                if (control.Text.Trim() == string.Empty)
                {
                    errorIcono.SetError(control, "Este campo es requerido");
                    esValido = false;

                }
                txtCarnet.Focus();
            }
            if (!esValido)
                return false;

            return true;

        }

        private void Aceptar(string carnet, string nombre,string apellidos, string telefono, string email, string cargo)
        {
           

            try
            {
                string connetionString = ConexionDB.ObtenerConexion();
                using (SqlConnection conexion = new SqlConnection(connetionString))
                {
                    string consultaSQL = "INSERT INTO Usuarios (carnet, nombre, apellido, telefono, email, cargo, fechaRegistro) " +
                                        "VALUES (@Carnet, @Nombre, @Apellido, @Telefono, @Email, @Cargo, @FechaRegistro)";

                    SqlCommand command = new SqlCommand(consultaSQL, conexion);
                    command.Parameters.AddWithValue("@Carnet", carnet);
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@Apellido", apellidos);
                    command.Parameters.AddWithValue("@Telefono", telefono);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Cargo", cargo);
                    command.Parameters.AddWithValue("@FechaRegistro", DateTime.Now);

                    conexion.Open();
                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Registro almacenado con exito.", "Informacion", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        listarRegistro();
                        limpiarControles();
                    }
                    else
                    {
                        MessageBox.Show("No se puede guardar el registro.", "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
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
                    string consultaSql = "SELECT * FROM Usuarios";
                    SqlDataAdapter adapter = new SqlDataAdapter(consultaSql, conexion);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvListado.DataSource = dt;
                    formatoGrid();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar registros: " + ex);
            }

            //  Estilo del data
            dgvListado.BorderStyle = BorderStyle.None;
            dgvListado.BackgroundColor = Color.White;
            dgvListado.GridColor = Color.LightGray;
            dgvListado.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvListado.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvListado.RowHeadersVisible = false;

            //  Encabezado 
            dgvListado.EnableHeadersVisualStyles = false;
            dgvListado.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(33, 150, 243);
            dgvListado.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvListado.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvListado.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvListado.ColumnHeadersHeight = 35;

            // Filas 
            dgvListado.DefaultCellStyle.BackColor = Color.White;
            dgvListado.DefaultCellStyle.ForeColor = Color.FromArgb(50, 50, 50);
            dgvListado.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvListado.DefaultCellStyle.SelectionBackColor = Color.FromArgb(187, 222, 251); // Color al seleccionar una columna
            dgvListado.DefaultCellStyle.SelectionForeColor = Color.Black;

            // Filas alternas 
            dgvListado.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 248, 255);


            dgvListado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListado.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListado.MultiSelect = false;
            dgvListado.RowTemplate.Height = 30;

        }
        private void formatoGrid()
        {
            dgvListado.Columns[0].Visible = false; // idUsuario
            dgvListado.Columns[1].HeaderText = "CARNET"; dgvListado.Columns[1].Width = 100;
            dgvListado.Columns[2].HeaderText = "NOMBRE"; dgvListado.Columns[2].Width = 180;
            dgvListado.Columns[3].HeaderText = "APELLIDO"; dgvListado.Columns[3].Width = 180;
            dgvListado.Columns[4].HeaderText = "TELEFONO"; dgvListado.Columns[4].Width = 110;
            dgvListado.Columns[5].HeaderText = "EMAIL"; dgvListado.Columns[5].Width = 170;
            dgvListado.Columns[6].HeaderText = "CARGO"; dgvListado.Columns[6].Width = 90;
            dgvListado.Columns[7].HeaderText = "FECHA REGISTRO"; dgvListado.Columns[7].Width = 200;

        }
        private void Actualizar(int idUsuario, string carnet, string nombre,string apellido, string telefono, string email, string cargo)
        {
            try
            {
                string connetionString = ConexionDB.ObtenerConexion();

                using (SqlConnection conexion = new SqlConnection(connetionString))
                {
                    string consultaSQL = "UPDATE Usuarios " +
                      "SET carnet = @Carnet, " +
                          "nombre = @Nombre," +
                          "apellido = @Apellido, " +
                          "telefono = @Telefono, " +
                          "cargo = @Cargo, " +
                          "email = @Email " +
                      "WHERE idUsuario = @idUsuario";


                    SqlCommand command = new SqlCommand(consultaSQL, conexion);
                    command.Parameters.AddWithValue("@idUsuario", idUsuario);
                    command.Parameters.AddWithValue("@Carnet", carnet);
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@Apellido", apellido);
                    command.Parameters.AddWithValue("@Telefono", telefono);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Cargo", cargo);
                    conexion.Open();

                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Registro alctualizado con exito.", "Informacion", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("No se puede actualizar el registro.", "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }

                    listarRegistro();
                    limpiarControles();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado al actualizar: " + ex);
            }
        }
        private void Eliminar(int idUsuario)
        {
            try
            {
                string connetionString = ConexionDB.ObtenerConexion();

                using (SqlConnection conexion = new SqlConnection(connetionString))
                {
                    conexion.Open();

                    string sqlCheck = "SELECT COUNT(*) FROM Prestamos WHERE idUsuario = @idUsuario";
                    SqlCommand checkCmd = new SqlCommand(sqlCheck, conexion);
                    checkCmd.Parameters.AddWithValue("@idUsuario", idUsuario);
                    int count = (int)checkCmd.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show(
                            "No se puede eliminar este usuario porque tiene libros en prestamo",
                            "Advertencia",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );
                        return;
                    }

                    string consultaSQL = "DELETE FROM Usuarios WHERE idUsuario = @idUsuario";
                    SqlCommand command = new SqlCommand(consultaSQL, conexion);
                    command.Parameters.AddWithValue("@idUsuario", idUsuario);

                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("✅ Usuario eliminado con éxito.", "Información",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el usuario.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    listarRegistro();
                    limpiarControles();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado al eliminar: " + ex.Message);
            }
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

            foreach (Control control in tableLayoutPanel1.Controls)
            {
                if (control is Guna.UI2.WinForms.Guna2TextBox gunaTextBox)
                {
                    if (string.IsNullOrWhiteSpace(gunaTextBox.Text))
                    {
                        errorIcono.SetError(gunaTextBox, "Esre campo es obligatorio. ");
                        datosValidos = false;
                    }
                }
            }

            if (!datosValidos)
            {
                MessageBox.Show("Informacion incompleta, seran remarcados los datos que faltan. ",
                    "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                if (validarControl())
                {
                    string carnet = txtCarnet.Text.Trim();
                    string nombre = txtNombres.Text.Trim();
                    string apellidos = txtApellidos.Text.Trim();
                    string telefono = txtTelefonos.Text.Trim();
                    string email = txtEmail.Text.Trim();
                    string cargo = cbmCargos.Text.Trim();


                    Aceptar(carnet, nombre, apellidos, telefono, email, cargo);
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
                    string carnet = txtCarnet.Text.Trim();
                    string nombre = txtNombres.Text.Trim();
                    string apellidos = txtApellidos.Text.Trim();
                    string telefono = txtTelefonos.Text.Trim();
                    string email = txtEmail.Text.Trim();
                    string cargo = cbmCargos.Text.Trim();

                    if (string.IsNullOrWhiteSpace(txtId.Text))
                    {
                        Aceptar(carnet, nombre, apellidos, telefono, email, cargo);
                    }
                    else
                    {
                        int.TryParse(txtId.Text, out int idUsuario);
                        Actualizar(idUsuario, carnet, nombre, apellidos, telefono, email, cargo);

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

                        //int id = Convert.ToInt32(dgvListado.CurrentRow.Cells[0].Value.ToString());
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

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            limpiarControles();
        }

        #endregion

        #region Data Griwd
        private void dgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvListado.Rows.Count > 0)
                {

                    if (!int.TryParse(dgvListado.CurrentRow.Cells[0].Value?.ToString(), out int idUsuario))
                    {
                        MessageBox.Show("El ID no es Valido", "Informacion", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
                        return;
                    }



                    txtId.Text = idUsuario.ToString();
                    txtCarnet.Text = dgvListado.CurrentRow.Cells[1].Value?.ToString() ?? "";
                    txtNombres.Text = dgvListado.CurrentRow.Cells[2].Value?.ToString() ?? "";
                    txtApellidos.Text = dgvListado.CurrentRow.Cells[3].Value?.ToString() ?? "";
                    txtTelefonos.Text = dgvListado.CurrentRow.Cells[4].Value?.ToString() ?? "";
                    txtEmail.Text = dgvListado.CurrentRow.Cells[5].Value?.ToString() ?? "";
                    cbmCargos.Text = dgvListado.CurrentRow.Cells[6].Value?.ToString() ?? "";

                    btnAceptar.Visible = false;
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