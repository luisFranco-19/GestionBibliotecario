using app.Banco.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GestorDeBiblioteca.Formularios
{
    public partial class FrmDevoluciones : Form
    {
        public FrmDevoluciones()
        {
            InitializeComponent();
            this.KeyPress += ValidacionEntrada.PasarFocus;
            this.KeyDown += ValidacionEntrada.ControlEsc;

            txtBuscar.Focus();
        }

        public FrmDevoluciones(int idPrestamo, string carnet, string nombre, string telefono, string cargo, int fechaRegistro)
        {
            InitializeComponent();

            txtBuscar.Focus();
        }


        private void ListarRegistros()
        {
            try
            {
                string connetionString = ConexionDB.ObtenerConexion();

                using (SqlConnection conexion = new SqlConnection(connetionString))
                {
                    string consulta = @"
                                    SELECT 
                                         idDetallePrestamo AS Id,
                                         u.carnet AS Carnet,
                                         u.nombre AS Nombre,
                                         u.cargo AS Cargo,
                                         l.titulo AS Libro,
                                         dp.cantidad AS Cantidad,
                                         p.fechaPrestamo AS FechaPrestamo,
                                         dp.fechaDevolucion AS FechaDevolucion,
                                         dp.estado AS Estado
                                     FROM DetallePrestamos dp
                                     INNER JOIN Prestamos p ON dp.idPrestamo = p.idPrestamo
                                     INNER JOIN Usuarios u ON p.idUsuario = u.idUsuario
                                     INNER JOIN Libros l ON dp.idLibro = l.idLibro
                                     WHERE dp.estado = 'Prestado'
                                     ORDER BY p.fechaPrestamo DESC";

                    SqlDataAdapter adapter = new SqlDataAdapter(consulta, conexion);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvListado.DataSource = dt;
                    dgvListado.Columns["Id"].Visible = false;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            //  Estilo del data
            dgvListado.BorderStyle = BorderStyle.None;
            dgvListado.BackgroundColor = Color.White;
            dgvListado.GridColor = Color.LightGray;
            dgvListado.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvListado.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvListado.RowHeadersVisible = false;

            //  Encabezado 
            dgvListado.EnableHeadersVisualStyles = false;
            dgvListado.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(33, 150, 243);
            dgvListado.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvListado.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvListado.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvListado.ColumnHeadersHeight = 35;

            // Filas 
            dgvListado.DefaultCellStyle.BackColor = Color.White;
            dgvListado.DefaultCellStyle.ForeColor = Color.FromArgb(50, 50, 50);
            dgvListado.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvListado.DefaultCellStyle.SelectionBackColor = Color.FromArgb(187, 222, 251); // Color al seleccionar una columna
            dgvListado.DefaultCellStyle.SelectionForeColor = Color.Black;

            // Filas alternas 
            dgvListado.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 248, 255); 

           
            dgvListado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListado.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListado.MultiSelect = false;
            dgvListado.RowTemplate.Height = 30;

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string valor = txtBuscar.Text.Trim();

            try
            {
                string connetionString = ConexionDB.ObtenerConexion();

                using (SqlConnection conexion = new SqlConnection(connetionString))
                {

                    string consulta = $@"
                         SELECT
                                         u.carnet AS Carnet,
                                         u.nombre AS Nombre,
                                         u.cargo AS Cargo,
                                         l.titulo AS Libro,
                                         dp.cantidad AS Cantidad,
                                         p.fechaPrestamo AS FechaPrestamo,
                                         dp.fechaDevolucion AS FechaDevolucion,
                                         dp.estado AS Estado
                                     FROM DetallePrestamos dp
                                     INNER JOIN Prestamos p ON dp.idPrestamo = p.idPrestamo
                                     INNER JOIN Usuarios u ON p.idUsuario = u.idUsuario
                                     INNER JOIN Libros l ON dp.idLibro = l.idLibro
                                    WHERE u.nombre LIKE '%{valor}%'
                                    OR l.titulo LIKE '%{valor}%'
                                    OR u.carnet LIKE '%{valor}%'";



                    SqlDataAdapter adapter = new SqlDataAdapter(consulta, conexion);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvListado.DataSource = dt;
                    //dgvListado.Columns[0].Visible = false;

  
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        #region eventos del Datagrid
        private void dgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    int id = Convert.ToInt32(dgvListado.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                    string carnet = dgvListado.Rows[e.RowIndex].Cells["Carnet"].Value.ToString();
                    string nombre = dgvListado.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                    string telefono = dgvListado.Rows[e.RowIndex].Cells["Teléfono"].Value.ToString();
                    string cargo = dgvListado.Rows[e.RowIndex].Cells["Cargo"].Value.ToString();
                    string fechaRegistro = dgvListado.Rows[e.RowIndex].Cells["FechaRegistro"].Value.ToString();

                   
                    FrmDevoluciones frm = new FrmDevoluciones();

                    //frm.registroAgregado -= ListarRegistros;
                    //MostrarModal.MostrarConCapa(this, frm);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        #endregion


        #region botones 
       
        private void iconEliminar_Click_1(object sender, EventArgs e)
        {
            if (dgvListado.CurrentRow != null)
            {
                try
                {                  

                    if (MessageBox.Show("¿Seguro que desea eliminar el registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int id = Convert.ToInt32(dgvListado.CurrentRow.Cells["Id"].Value);

                        string connetionString = ConexionDB.ObtenerConexion();
                        using (SqlConnection conexion = new SqlConnection(connetionString))
                        {
                            string consulta = "DELETE FROM DetallePrestamos WHERE idDetallePrestamo = @Id";
                            SqlCommand command = new SqlCommand(consulta, conexion);
                            command.Parameters.AddWithValue("@Id", id);

                            conexion.Open();
                            int resultado = command.ExecuteNonQuery();

                            if (resultado > 0)
                                MessageBox.Show("Registro eliminado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            else
                                MessageBox.Show("No se pudo eliminar el registro.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            ListarRegistros();
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void iconCerrar_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        #endregion


      

        private void FrmDev_Load(object sender, EventArgs e)
        {
            ListarRegistros();
        }

        
    }
}
