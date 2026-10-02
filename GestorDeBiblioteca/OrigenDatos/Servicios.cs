using app.Banco.Utilidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace GestorDeBiblioteca.OrigenDatos
{
    public static class Servicios
    {
        public static DtsConexion ListadoDevoliciones()
        {
            try
            {
                string connetionString = ConexionDB.ObtenerConexion();

                using (SqlConnection conexion = new SqlConnection(connetionString))
                using (SqlCommand comando = new SqlCommand("sp_ReportePrestamo", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    var adaptador = new SqlDataAdapter(comando);
                    var ds = new DtsConexion();
                    adaptador.Fill(ds.ListadoDevolucion);
                    return ds;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                return null;
            }
        }
    
    }
}
