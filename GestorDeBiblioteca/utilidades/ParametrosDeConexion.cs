using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace app.Banco.Utilidades
{
    [DataContract]

    public class ParametrosDeConexion
    {
        [DataMember(Order = 0)]
        public string servidor { get; set; }

        [DataMember(Order = 1)]
        public string baseDatos { get; set; }

        public string cadenaConexion =>
            $"Data Source={servidor}; Initial Catalog={baseDatos}; Integrated Security=True;Encrypt=False";
    }

    public static class AdminstrarConexion
    {
        private static readonly string carpeta =
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "app.Biblioteca");

        private static readonly string archivo = Path.Combine(carpeta, "conexion.json");

        private static string rutaArchivo => archivo;

        public static void Guardar(ParametrosDeConexion parametros)
        {
            if (!Directory.Exists(carpeta))
                Directory.CreateDirectory(carpeta);

            var serializar = new DataContractJsonSerializer(typeof(ParametrosDeConexion));
            using(var ms = new MemoryStream())
            {
                serializar.WriteObject(ms, parametros);
                File.WriteAllText(archivo, Encoding.UTF8.GetString(ms.ToArray()), Encoding.UTF8);
            }
        }

        public static ParametrosDeConexion Cargar()
        {
            if (!File.Exists(archivo))
                return new ParametrosDeConexion();

            var json = File.ReadAllText(archivo, Encoding.UTF8);
            var bytes = Encoding.UTF8.GetBytes(json);
            using(var ms = new MemoryStream(bytes))
            {
                var serializar = new DataContractJsonSerializer(typeof(ParametrosDeConexion));
                return(ParametrosDeConexion)serializar.ReadObject(ms);
            }
        }

        public static bool ProbarConexion(ParametrosDeConexion parametros, out string error)
        {
            try
            {
                using(var cn = new SqlConnection(parametros.cadenaConexion))
                {
                    cn.Open();
                    error = null;
                    return true;
                }
            }
            catch(Exception ex)
            {
                error = ex.Message;
                return false;
            }
        }
    }
}
