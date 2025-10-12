using app.Banco.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorDeBiblioteca
{
    public partial class FrmConexion : Form
    {
        public FrmConexion()
        {
            InitializeComponent();
        }

        #region Botones de Comando
        private void iconCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void iconAceptar_Click(object sender, EventArgs e)
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

            //Crear objeto de configuracion
            var parametros = new ParametrosDeConexion
            {
                servidor = txtServidor.Text.Trim(),
                baseDatos = txtbaseDatos.Text.Trim()
            };

            if (!AdminstrarConexion.ProbarConexion(parametros, out string error))
            {
                MessageBox.Show($"No se puede establecer la conexion con la base de datos.\n\nDetalles:{error}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                return;
            }

            try
            {
                AdminstrarConexion.Guardar(parametros);
                MessageBox.Show("Datos de conexcion registrados con exito", "Informacion",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error; " + ex.Message);
            }
        }

        #endregion


    }
}
