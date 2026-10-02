using app.Banco.Utilidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace GestorDeBiblioteca.OrigenDatos
{
    public static class Servicios1
    {
        public static DtsConexion1 ListadoLibros()
        {

            try
            {
                string connetionString = ConexionDB.ObtenerConexion();

                using (SqlConnection conexion = new SqlConnection(connetionString))
                using (SqlCommand comando = new SqlCommand("sp_ReporteStockLibros", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    var adaptador = new SqlDataAdapter(comando);
                    var ds = new DtsConexion1();
                    adaptador.Fill(ds.ListadoLibros);
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
