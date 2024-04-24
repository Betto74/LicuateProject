using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Modelos;
using MySql.Data.MySqlClient;


namespace Datos
{
    
    public class LoginDAO
    {
        /// <summary>
        /// Inserta un usuario con los parametros especificados
        /// </summary>
        /// <param name="user">Lista con todos los elementos del usuario</param>
        /// <returns>
        /// true:Si la operación fue exitosa
        /// false: Si la operación no fue existosa
        /// </returns>
        public Boolean register(Usuario user)
        {

            if (Conexion.Conectar())
            {
                try
                {

                    String select = @"INSERT INTO USUARIOS (NOMBRE, USERNAME, PASSWORD,CARGO)" +
                        "VALUES (@NOMBRE,@USERNAME,SHA2(@PASSWORD,256),1);";

                    //Crear el dataadapter
                    MySqlCommand sentencia = new MySqlCommand(select);
                    //Asignar los parámetros
                    sentencia.Parameters.AddWithValue("@NOMBRE", user.NOMBRE);
                    sentencia.Parameters.AddWithValue("@USERNAME", user.USERNAME);
                    sentencia.Parameters.AddWithValue("@PASSWORD", user.PASSWORD);


                    sentencia.Connection = Conexion.conexion;

                    sentencia.ExecuteNonQuery();
                    return true;
                }
                finally
                {
                    Conexion.Desconectar();
                }
            }
            else
            {
                return false;
            }

        }
        /// <summary>
        /// Obtiene un usuario de la BD con los parametros especificados
        /// </summary>
        /// <param name="USERNAME">Nombre de usuario proporcionado</param>
        /// <param name="PASSWORD">Contraseña proporcionada</param>
        /// <returns>
        /// Un objeto correspondiente al usuario con esas credenciales
        /// </returns>
        public Usuario getUser(String USERNAME, String PASSWORD)
        {
            Usuario user = null;
            if (Conexion.Conectar())
            {
                try
                {

                    String select = @"SELECT * FROM USUARIOS
                                    where USERNAME = @USERNAME and PASSWORD = SHA2(@PASSWORD,256);";

                    //Crear el dataadapter
                    MySqlCommand sentencia = new MySqlCommand(select);
                    //Asignar los parámetros
                    sentencia.Parameters.AddWithValue("@USERNAME", USERNAME);
                    sentencia.Parameters.AddWithValue("@PASSWORD", PASSWORD);

                    sentencia.Connection = Conexion.conexion;

                    MySqlDataAdapter da = new MySqlDataAdapter(sentencia);

                    DataTable dt = new DataTable();
                    //Llenar el datatable
                    da.Fill(dt);

                    //Revisar si hubo resultados
                    if (dt.Rows.Count > 0)
                    {
                        DataRow fila = dt.Rows[0];
                        user = new Usuario()
                        {
                            ID = Convert.ToInt32(fila["ID"]),
                            NOMBRE = fila["NOMBRE"].ToString(),
                            USERNAME = fila["USERNAME"].ToString(),
                            PASSWORD = fila["PASSWORD"].ToString(),
                            CARGO = fila["CARGO"].ToString(),
                        };

                    }

                    return user;
                }
                finally
                {
                    Conexion.Desconectar();
                }
            }
            else
            {
                return null;
            }

        }

     
    }
}
