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
    public partial class FrmLogin : Form
    {
       

        public FrmLogin()
        {

            InitializeComponent();

            this.KeyPreview = true;

            this.KeyDown += ValidacionEntrada.ControlEsc;
            txtUsuario.KeyPress += ValidacionEntrada.PasarFocus;
            txtPassword.KeyPress += ValidacionEntrada.PasarFocus;
            this.Shown += FrmLogin_Shown;

        }
        private void FrmLogin_Shown(object sender, EventArgs e)
        {
            txtUsuario.Focus();
        }

        #region Metodos
        private void LimpiarCampos()
        {
            txtUsuario.Clear();
            txtPassword.Clear();
            txtUsuario.Focus();
        }

        private int ValidarLogin(string usuario, string password)
        {
            int idUsuarioLogin = 0;

            try
            {
                string conexionStr = ConexionDB.ObtenerConexion();
                using (SqlConnection conexion = new SqlConnection(conexionStr))
                {
                    conexion.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_ValidarLogin", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@NombreUsuario", usuario);
                        cmd.Parameters.AddWithValue("@Password", password); // En texto plano

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            idUsuarioLogin = Convert.ToInt32(reader["IdUsuarioLogin"]);
                            RegistrarInicioSesion(idUsuarioLogin, idUsuarioLogin > 0);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al iniciar sesión: " + ex.Message);
            }

            return idUsuarioLogin;
        }
        private void RegistrarInicioSesion(int idUsuarioLogin, bool exito)
        {
            try
            {
                string conexionStr = ConexionDB.ObtenerConexion();
                using (SqlConnection conexion = new SqlConnection(conexionStr))
                {
                    string sql = "INSERT INTO InicioSesion (idUsuarioLogin, exito) VALUES (@idUsuarioLogin, @Exito)";
                    SqlCommand cmd = new SqlCommand(sql, conexion);
                    cmd.Parameters.AddWithValue("@idUsuarioLogin", idUsuarioLogin);
                    cmd.Parameters.AddWithValue("@Exito", exito ? 1 : 0);

                    conexion.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error; " + ex.Message);
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

        #region Botones de comando
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            string usuario = txtUsuario.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Ingrese usuario y contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idUsuarioLogin = ValidarLogin(usuario, password);

            if (idUsuarioLogin > 0)
            {
                MessageBox.Show("Login exitoso!", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                MDImenu principal = new MDImenu();
                principal.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.Focus();
            }
        }

        private void btnRegistrase_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
               
                FrmRegistroLogin registroLoginForm = new FrmRegistroLogin();
                registroLoginForm.ShowDialog();

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
