using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            //string ruta = Path.Combine(Application.StartupPath, "Media", "videoplayback.mp4");
            //if (!File.Exists(ruta))
            //{
            //    ruta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Media", "videoplayback.mp4");
            //}
            //if (!File.Exists(ruta))
            //{
            //    ruta = Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\..\..\Recursos\Video\videoplayback.mp4"));
            //}

            //if (File.Exists(ruta))
            //{
            //    axWindowsMediaPlayer1.URL = ruta;
            //    axWindowsMediaPlayer1.Ctlcontrols.play();
            //}
        }
    }
}
