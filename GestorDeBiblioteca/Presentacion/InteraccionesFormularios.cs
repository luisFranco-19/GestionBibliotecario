using System.Drawing;
using System.Windows.Forms;
using GestorDeBiblioteca.Presentacion;

// Solo comportamiento dinámico. La distribución y los estilos están en cada Designer.cs.
namespace GestorDeBiblioteca
{
    public partial class FrmUsuarios
    {
        private void ConfigurarInteracciones()
        {
            BibliotecaTheme.BindGrid(dgvListado, lblDisenoContador);
        }
    }

    public partial class FrmLibros
    {
        private void ConfigurarInteracciones()
        {
            BibliotecaTheme.BindGrid(dgvListado, lblDisenoContador);
        }
    }

    public partial class FrmPrestamos
    {
        private void ConfigurarInteracciones()
        {
            BibliotecaTheme.BindGrid(dgvPrestamos, lblDisenoContador);
        }
    }

    public partial class MDImenu
    {
        private void ConfigurarInteracciones()
        {
            var botones = new[] { btnDashboard, btnUsuario, btnLibro, btnPrestamo, btnDevolucion };
            foreach (var seleccionado in botones)
            {
                var activo = seleccionado;
                activo.Click += (s, e) => {
                    foreach (var boton in botones)
                    {
                        boton.FillColor = boton == activo ? BibliotecaTheme.AmberSoft : Color.Transparent;
                        boton.ForeColor = boton == activo ? BibliotecaTheme.Ink : Color.White;
                    }
                };
            }
            panelSiderbar.VisibleChanged += (s, e) => ActualizarAnchoNavegacion();
            DpiChanged += (s, e) => ActualizarAnchoNavegacion();
        }

        private void ActualizarAnchoNavegacion()
        {
            tlpDisenoRaiz.ColumnStyles[0].Width = panelSiderbar.Visible ?
                236F * CurrentAutoScaleDimensions.Width / 96F : 0F;
        }
    }
}

namespace GestorDeBiblioteca.Formularios
{
    public partial class FrmLogin
    {
        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing) Application.Exit();
        }
    }

    public partial class FrmRegistroLogin
    {
        private void FrmRegistroLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing) Application.Exit();
        }
    }

    public partial class FrmDevoluciones
    {
        private void ConfigurarInteracciones()
        {
            BibliotecaTheme.BindGrid(dgvListado, lblDisenoContador);
        }
    }

    public partial class FrmDashboard
    {
        private Label[] titulosMetricas;

        private void ConfigurarInteracciones()
        {
            titulosMetricas = new[] { lblDisenoMetrica1, lblDisenoMetrica2, lblDisenoMetrica3, lblDisenoMetrica4 };
            BibliotecaTheme.BindGrid(dvgListado, lblDisenoContador);
            var botones = new[] { btnRegistrosLibros, btnRegistroUsuarios, btnStockLibros };
            foreach (var seleccionado in botones)
            {
                var activo = seleccionado;
                activo.Click += (s, e) => {
                    foreach (var boton in botones)
                    {
                        boton.FillColor = boton == activo ? BibliotecaTheme.Petrol : Color.White;
                        boton.ForeColor = boton == activo ? Color.White : BibliotecaTheme.Ink;
                        boton.HoverState.ForeColor = boton.ForeColor;
                    }
                };
            }
        }
    }
}
