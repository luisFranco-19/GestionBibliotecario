using GestorDeBiblioteca.Formularios;
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
    public partial class MDImenu : Form
    {
        private Form formularioActivo = null;

        public MDImenu()
        {
            InitializeComponent();
        }

        #region Metodos

        private void AbrirFormulario(Form formularioHijo, bool esHijoDelPanelContenedor = true)
        {
            try
            {
                if (esHijoDelPanelContenedor)
                {
                    if (formularioActivo != null)
                    {
                        formularioActivo.Close();
                        formularioActivo.Dispose();
                    }

                    formularioActivo = formularioHijo;

                    formularioHijo.TopLevel = false;
                    formularioHijo.FormBorderStyle = FormBorderStyle.None;
                    formularioHijo.Dock = DockStyle.Fill;

                    panelContenedor.Controls.Clear();
                    panelContenedor.Controls.Add(formularioHijo);
                    panelContenedor.Tag = formularioHijo;
                    formularioHijo.Show();
                }
                else
                {
                    formularioHijo.TopLevel = true;
                    formularioHijo.FormBorderStyle = FormBorderStyle.Sizable;

                    formularioHijo.ShowDialog();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Se ha generado un error inesperado al cargar el formulario", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Botones de Comando
        private void btnUsuario_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmUsuarios(), true);
        }

        private void btnLibro_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmLibros(), true);
        }

        private void btnPrestamo_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmGestionDePrestamos(), true);
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnDevolucion_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmDev(), true);
        }
        #endregion


    }
}
