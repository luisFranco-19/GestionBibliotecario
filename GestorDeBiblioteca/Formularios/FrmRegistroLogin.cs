using app.Banco.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorDeBiblioteca.Formularios
{
    public partial class FrmRegistroLogin : Form
    {
        public FrmRegistroLogin()
        {
            InitializeComponent();

            this.KeyPreview = true;

            this.KeyDown += ValidacionEntrada.ControlEsc;

            txtNombreUsuario.KeyPress += ValidacionEntrada.PasarFocus;
            txtEmail.KeyPress += ValidacionEntrada.PasarFocus;
            txtPassword.KeyPress += ValidacionEntrada.PasarFocus;

            this.Shown += FrmRegistroLogin_Shown;
        }
        private void FrmRegistroLogin_Shown(object sender, EventArgs e)
        {
            txtNombreUsuario.Focus();
        }


        #region Metodos
        private bool UsuarioExiste(string nombreUsuario, string email)
        {
            bool existe = false;
            try
            {
                string conexionStr = ConexionDB.ObtenerConexion();
                using (SqlConnection conexion = new SqlConnection(conexionStr))
                {
                    string sql = "SELECT COUNT(*) FROM UsuarioLogin WHERE nombreUsuario=@Usuario OR email=@Email";
                    SqlCommand cmd = new SqlCommand(sql, conexion);
                    cmd.Parameters.AddWithValue("@Usuario", nombreUsuario);
                    cmd.Parameters.AddWithValue("@Email", email);
                    conexion.Open();
                    int count = (int)cmd.ExecuteScalar();
                    existe = count > 0;
                }
            }
            catch { }
            return existe;
        }


        private void GuardarUsuario(string nombreUsuario, string email, string password)
        {
            try
            {
                if (UsuarioExiste(nombreUsuario, email))
                {
                    MessageBox.Show("El nombre de usuario o email ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string conexionStr = ConexionDB.ObtenerConexion();
                using (SqlConnection conexion = new SqlConnection(conexionStr))
                {
                    string sql = "INSERT INTO UsuarioLogin (nombreUsuario, email, password, estado) " +
                                 "VALUES (@NombreUsuario, @Email, @Password, 1)";
                    SqlCommand cmd = new SqlCommand(sql, conexion);
                    cmd.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", ObtenerSHA256(password));

                    conexion.Open();
                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Usuario registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Close();
                        MDImenu menuForm = new MDImenu();
                        menuForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo registrar el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar usuario: " + ex.Message);
            }
        }


        private string ObtenerSHA256(string texto)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(texto));
                StringBuilder builder = new StringBuilder();
                foreach (var b in bytes)
                    builder.Append(b.ToString("x2"));
                return builder.ToString();
            }
        }

        #endregion

        #region Botones de Comando
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtNombreUsuario.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(nombreUsuario) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            GuardarUsuario(nombreUsuario, email, password);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNombreUsuario.Clear();
            txtEmail.Clear();
            txtPassword.Clear();

            txtNombreUsuario.Focus();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide(); 
                FrmLogin loginForm = new FrmLogin();
                loginForm.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el formulario de registro: " + ex.Message);
                this.Show();
            }
        }

        #endregion

        
    }
}
