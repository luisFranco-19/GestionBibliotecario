using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestorDeBiblioteca;
using app.Banco.Utilidades;

namespace GestorDeBiblioteca
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var conexion = AdminstrarConexion.Cargar();
            if (string.IsNullOrWhiteSpace(conexion.servidor) || string.IsNullOrWhiteSpace
              (conexion.baseDatos))
            {
                using (var frm = new FrmConexion())
                {
                    if (frm.ShowDialog() != DialogResult.OK)
                    {
                        MessageBox.Show("No se configuro la conexion. La aplicacion se cerrara.",
                            "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    return;
                }
            }
            Application.Run(new MDImenu());
        }
    }
}
