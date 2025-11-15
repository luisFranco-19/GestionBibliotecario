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
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Ajustar el reproductor al tamaño del formulario
            //axWindowsMediaPlayer1.Dock = DockStyle.Fill;

            // Cargar el video (usa una ruta válida en tu PC)
            axWindowsMediaPlayer1.URL = @"C:\Users\LuisFranco\Documents\ExamenFinal\Biblioteca app Actualizaciones\GestionBibliotecario\Recursos\Video\videoplayback.mp4";
            axWindowsMediaPlayer1.settings.setMode("loop", true);

            // Quitar los controles de Windows Media Player si quieres que se vea limpio
            //axWindowsMediaPlayer1.uiMode = "none";

            // Reproducir automáticamente
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }
      
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            
            
        }
    }
}
