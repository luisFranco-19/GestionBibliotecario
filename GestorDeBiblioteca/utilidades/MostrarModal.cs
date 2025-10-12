using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app.Banco.Utilidades
{
    public static class MostrarModal
    {
        public static void MostraConCap(Form formularioPrincipal, Form formularioModal)
        {
            //Crear capa oscura semi transparente

            Form capa = new Form
            {
                FormBorderStyle = FormBorderStyle.None,
                BackColor = Color.Black,
                Opacity = 0.3,
                ShowInTaskbar = false,
                StartPosition = FormStartPosition.Manual,
                Location = formularioPrincipal.PointToScreen(Point.Empty),
                Size = formularioPrincipal.ClientSize,
                TopMost = false,
                Owner = formularioPrincipal,

            };
            capa.Show();

            formularioModal.ShowInTaskbar = false;
            formularioModal.ShowDialog();

            capa.Close();
    }   }
}
