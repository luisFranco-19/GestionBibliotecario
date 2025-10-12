using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace app.Banco.Utilidades
{
    public class ValidacionEntrada
    {
        //Manejar la tecla Enter Como Tab

        public static void PasarFocus(object sender, KeyPressEventArgs e)
        {
            try
            {
                if(e.KeyChar == (char)Keys.Enter)
                {
                    e.Handled = true;
                    SendKeys.Send("{TAB}");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al pasar el focus: " + ex.Message);
            }
        }

        //Manejar la tecla ESC 
        public static void ControlEsc(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape)
                {
                   if(sender is Form formulario)
                    {
                        formulario.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en  esc: " + ex.Message);
            }
        }

    }
}
