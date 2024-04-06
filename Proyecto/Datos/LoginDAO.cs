using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
using MySql.Data.MySqlClient;


namespace Datos
{
    public class LoginDAO
    {
        public Boolean register(String NOMBRE, String USERNAME, String PASSWORD)
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
                    sentencia.Parameters.AddWithValue("@NOMBRE", NOMBRE);
                    sentencia.Parameters.AddWithValue("@USERNAME", USERNAME);
                    sentencia.Parameters.AddWithValue("@PASSWORD", PASSWORD);


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

        public int Login(String USERNAME, String PASSWORD)
        {

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

                    int rows = Convert.ToInt32(sentencia.ExecuteScalar());
                    return rows;
                }
                finally
                {
                    Conexion.Desconectar();
                }
            }
            else
            {
                return -1;
            }

        }


        public bool admin(String USERNAME, String PASSWORD)
        {

            if (Conexion.Conectar())
            {
                try
                {

                    String select = @"SELECT * FROM USUARIOS
                                    where USERNAME = @USERNAME and PASSWORD = SHA2(@PASSWORD,256) and CARGO = 'Admin'";

                    //Crear el dataadapter
                    MySqlCommand sentencia = new MySqlCommand(select);
                    //Asignar los parámetros
                    sentencia.Parameters.AddWithValue("@USERNAME", USERNAME);
                    sentencia.Parameters.AddWithValue("@PASSWORD", PASSWORD);

                    sentencia.Connection = Conexion.conexion;

                    using (MySqlDataReader reader = sentencia.ExecuteReader())
                    {
                        // Si el lector tiene alguna fila, significa que se encontró un usuario con las características especificadas
                        if (reader.HasRows)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
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
    }
}
