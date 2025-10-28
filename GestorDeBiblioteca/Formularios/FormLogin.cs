using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorDeBiblioteca.Formularios
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            string User = "Admin";
            string Contraseña = "miclave";

            if (txtUser.Text.Trim() == User && txtContraseña.Text.Trim() == Contraseña)
            {
                //MessageBox.Show($"Acceso concedido,Bienvenido:{txtUser}!");
                ////MDIMenu menu = new MDIMenu();
                ////this.Hide();
                ////menu.Show();
                // Devuelve OK al Program.cs
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

            else
            {
                MessageBox.Show($"Aceeso denegado, credenciales incorrectas!", "ERROR");
                txtUser.Focus();
                txtUser.Clear();
                txtContraseña.Clear();
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = new DialogResult();
            resultado = MessageBox.Show("¿Estas seguro que deseas salir?", "Aviso",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
