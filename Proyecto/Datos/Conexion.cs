using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Datos
{
    public class Conexion
    {

        public static MySqlConnection conexion;

        /// <summary>
        /// Efectua la conexión a la base de datos
        /// </summary>
        /// <returns>
        /// true:la conexión fue exitosa 
        /// false:la conexión no fue exitosa
        /// </returns>
        public static bool Conectar()
        {


            try
            {
                if (conexion != null && conexion.State == System.Data.ConnectionState.Open) return true;

                conexion = new MySqlConnection();
                conexion.ConnectionString = "server=localhost;uid=root;pwd=root;database=LICUATE";
                conexion.Open();

                return true;
            }
            catch (MySqlException ex)
            {

                return false;
            }
            catch (Exception ex)
            {

                return false;
            }

        }
        /// <summary>
        /// Desconecta la conexión
        /// </summary>
        public static void Desconectar()
        {
            if (conexion != null && conexion.State == System.Data.ConnectionState.Open)
                conexion.Close();

        }
    }
}
