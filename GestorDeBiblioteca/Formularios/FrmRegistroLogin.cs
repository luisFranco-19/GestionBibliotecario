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

        private void GuardarUsuario(string nombreUsuario, string email, string password)
        {
            try
            {
                string conexionStr = ConexionDB.ObtenerConexion();
                using (SqlConnection conexion = new SqlConnection(conexionStr))
                {
                    conexion.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_InsertarUsuarioLogin", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                        cmd.Parameters.AddWithValue("@Email", email);
                        // Guardamos la contraseña tal cual
                        cmd.Parameters.AddWithValue("@Password", password);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Usuario registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    
                    MDImenu menuForm = new MDImenu();
                    menuForm.FormClosed += (s, args) => this.Close();  
                    menuForm.Show();
                    

                }
            }
            catch (SqlException sqlEx)
            {
                // Manejar error de duplicidad (RAISERROR)
                MessageBox.Show("Error al registrar usuario: " + sqlEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion


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

        private void txtPassword_IconRightClick(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '\0')
            {
                txtPassword.PasswordChar = '●';
            }
            else
            {
                txtPassword.PasswordChar = '\0';
            }
        }

        private void iconCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
