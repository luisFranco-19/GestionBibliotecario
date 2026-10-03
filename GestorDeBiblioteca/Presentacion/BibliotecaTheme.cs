using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Guna.UI2.WinForms;

namespace GestorDeBiblioteca.Presentacion
{
    // Formato de datos y eventos; los controles y su distribución pertenecen al Designer.
    internal static class BibliotecaTheme
    {
        internal static readonly Color Ink = Color.FromArgb(24, 53, 61);
        internal static readonly Color Petrol = Color.FromArgb(25, 78, 89);
        internal static readonly Color PetrolHover = Color.FromArgb(35, 96, 107);
        internal static readonly Color Canvas = Color.FromArgb(246, 245, 241);
        internal static readonly Color Surface = Color.White;
        internal static readonly Color Muted = Color.FromArgb(102, 117, 120);
        internal static readonly Color Line = Color.FromArgb(224, 229, 225);
        internal static readonly Color Soft = Color.FromArgb(233, 243, 239);
        internal static readonly Color Amber = Color.FromArgb(183, 113, 55);
        internal static readonly Color AmberSoft = Color.FromArgb(255, 244, 222);
        internal static readonly Color Danger = Color.FromArgb(159, 55, 55);
        internal static readonly Font BodyFont = new Font("Segoe UI", 10F);
        internal static readonly Font LabelFont = new Font("Segoe UI Semibold", 9F);
        internal static readonly Font TitleFont = new Font("Georgia", 25F);
        internal static readonly Font SmallFont = new Font("Segoe UI", 9F);

        internal static void Grid(DataGridView grid)
        {
            grid.BorderStyle = BorderStyle.None;
            grid.BackgroundColor = Surface;
            grid.GridColor = Line;
            grid.EnableHeadersVisualStyles = false;
            grid.RowHeadersVisible = false;
            grid.AllowUserToAddRows = false;
            grid.AllowUserToResizeRows = false;
            grid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            grid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            grid.ColumnHeadersHeight = 42;
            grid.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle {
                BackColor = Soft, ForeColor = Petrol, Font = LabelFont,
                Alignment = DataGridViewContentAlignment.MiddleLeft,
                SelectionBackColor = Soft, SelectionForeColor = Petrol, Padding = new Padding(10, 0, 10, 0)
            };
            grid.DefaultCellStyle = new DataGridViewCellStyle {
                BackColor = Surface, ForeColor = Ink, Font = BodyFont,
                SelectionBackColor = Color.FromArgb(219, 237, 231), SelectionForeColor = Ink,
                Alignment = DataGridViewContentAlignment.MiddleLeft, Padding = new Padding(10, 5, 10, 5)
            };
            grid.AlternatingRowsDefaultCellStyle = new DataGridViewCellStyle {
                BackColor = Color.FromArgb(249, 250, 247), ForeColor = Ink,
                SelectionBackColor = Color.FromArgb(219, 237, 231), SelectionForeColor = Ink
            };
            grid.RowTemplate.Height = 38;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.MultiSelect = false;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.ShowCellToolTips = true;
            foreach (DataGridViewColumn column in grid.Columns)
            {
                if (column.Visible) column.MinimumWidth = 85;
                string name = column.DataPropertyName.Length > 0 ? column.DataPropertyName : column.Name;
                switch (name.Replace("_", "").ToLowerInvariant())
                {
                    case "titulo": case "titulolibro": case "título": column.HeaderText = "Título"; column.FillWeight = 240; break;
                    case "autor": case "nombreautor": column.HeaderText = "Autor"; column.FillWeight = 190; break;
                    case "nombreusuario": column.HeaderText = "Usuario"; column.FillWeight = 175; break;
                    case "nombre": case "nombres": column.HeaderText = "Nombres"; column.FillWeight = 120; break;
                    case "apellido": case "apellidos": column.HeaderText = "Apellidos"; column.FillWeight = 135; break;
                    case "email": column.HeaderText = "Correo electrónico"; column.FillWeight = 230; break;
                    case "telefono": column.HeaderText = "Teléfono"; column.FillWeight = 125; break;
                    case "nacionalidad": column.HeaderText = "Nacionalidad"; column.FillWeight = 125; break;
                    case "carnet": column.HeaderText = "Carnet"; column.FillWeight = 100; break;
                    case "aniopublicacion": case "añopublicacion": column.HeaderText = "Año"; column.FillWeight = 90; break;
                    case "cantidad": column.HeaderText = "Cantidad"; column.FillWeight = 90; break;
                    case "estado": column.HeaderText = "Estado"; column.FillWeight = 100; break;
                    case "cargo": column.HeaderText = "Cargo"; column.FillWeight = 95; break;
                    case "fecharegistro": column.HeaderText = "Registro"; column.FillWeight = 110; break;
                    case "fechaprestamo": column.HeaderText = "Préstamo"; column.FillWeight = 115; break;
                    case "fechadevolucion": column.HeaderText = "Devolución"; column.FillWeight = 120; break;
                    case "totalprestamos": column.HeaderText = "Préstamos"; column.FillWeight = 110; break;
                    case "idprestamo": column.HeaderText = "N.º"; column.FillWeight = 60; break;
                }
                if (column.ValueType == typeof(DateTime)) column.DefaultCellStyle.Format = "dd/MM/yyyy";
            }
            var guna = grid as Guna2DataGridView;
            if (guna != null)
            {
                guna.ThemeStyle.HeaderStyle.BackColor = Soft;
                guna.ThemeStyle.HeaderStyle.ForeColor = Petrol;
                guna.ThemeStyle.HeaderStyle.Height = 42;
                guna.ThemeStyle.HeaderStyle.Font = LabelFont;
                guna.ThemeStyle.RowsStyle.BackColor = Surface;
                guna.ThemeStyle.RowsStyle.ForeColor = Ink;
                guna.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(219, 237, 231);
                guna.ThemeStyle.RowsStyle.SelectionForeColor = Ink;
                guna.ThemeStyle.RowsStyle.Height = 38;
                guna.ThemeStyle.RowsStyle.Font = BodyFont;
                guna.ThemeStyle.AlternatingRowsStyle.BackColor = Color.FromArgb(249, 250, 247);
                guna.ThemeStyle.GridColor = Line;
            }
        }

        internal static void Chart(Chart chart)
        {
            chart.BackColor = Surface;
            chart.BorderlineWidth = 0;
            foreach (ChartArea area in chart.ChartAreas)
            {
                area.BackColor = Surface;
                area.Area3DStyle.Enable3D = false;
                area.AxisX.LabelStyle.Font = SmallFont;
                area.AxisY.LabelStyle.Font = SmallFont;
                area.AxisX.LabelStyle.ForeColor = Muted;
                area.AxisY.LabelStyle.ForeColor = Muted;
                area.AxisX.MajorGrid.LineColor = Line;
                area.AxisY.MajorGrid.LineColor = Line;
            }
            foreach (Legend legend in chart.Legends) { legend.BackColor = Surface; legend.ForeColor = Muted; legend.Font = SmallFont; }
            foreach (Title title in chart.Titles) { title.Font = new Font("Segoe UI Semibold", 12F); title.ForeColor = Ink; }
        }

        private static string RecordCount(int count)
        {
            return count + (count == 1 ? " registro" : " registros");
        }

        internal static void BindGrid(DataGridView grid, Label count)
        {
            grid.DataBindingComplete += (s, e) => count.Text = RecordCount(grid.Rows.Count);
            grid.RowsAdded += (s, e) => count.Text = RecordCount(grid.Rows.Count);
            grid.RowsRemoved += (s, e) => count.Text = RecordCount(grid.Rows.Count);
        }
    }
}
