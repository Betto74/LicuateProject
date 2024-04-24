using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
namespace Datos
{
    public class VentasDAO
    {
        public Venta getData(int ID)
        {
            Venta venta = new Venta();
            if (Conexion.Conectar())
            {
                try
                {

                    String select = @"SELECT * FROM ORDEN WHERE ID = @ID";

                    //Definir un datatable para que sea llenado
                    DataTable dt = new DataTable();
                    //Crear el dataadapter
                    MySqlCommand sentencia = new MySqlCommand(select);
                    sentencia.Parameters.AddWithValue("@ID", ID);

                    sentencia.Connection = Conexion.conexion;

                    MySqlDataAdapter da = new MySqlDataAdapter(sentencia);


                    //Llenar el datatable
                    da.Fill(dt);

                    //Revisar si hubo resultados
                    if (dt.Rows.Count > 0)
                    {
                        DataRow fila = dt.Rows[0];
                        venta = new Venta()
                        {
                            ID = Convert.ToInt32(fila["ID"]),
                            FECHA = Convert.ToDateTime(fila["FECHA"]),
                            MONTO = Convert.ToDouble(fila["MONTO"]),
                            ID_USUARIO = Convert.ToInt32(fila["ID_USUARIO"]),
                            ID_CLIENTE = Convert.ToInt32(fila["ID_CLIENTE"])
                        };

                    }

                    return venta;

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

        /// <summary>
        /// Obtiene todos los registros de la tabla ORDEN de la BD
        /// </summary>
        /// <returns>
        /// Una lista con todas las ventas almacenadas en la BD
        /// </returns>
        public List<Venta> getAllData()
        {

            List<Venta> lista = new List<Venta>();
            if (Conexion.Conectar())
            {
                try
                {

                    String select = @"SELECT O.ID, O.FECHA, O.MONTO, O.ID_CLIENTE, U.NOMBRE"
                                    + " FROM ORDEN O JOIN USUARIOS U ON O.ID_USUARIO = U.ID ORDER BY O.FECHA ASC;";

                    //Definir un datatable para que sea llenado
                    DataTable dt = new DataTable();
                    //Crear el dataadapter
                    MySqlCommand sentencia = new MySqlCommand(select);


                    sentencia.Connection = Conexion.conexion;

                    MySqlDataAdapter da = new MySqlDataAdapter(sentencia);

                    //Llenar el datatable
                    da.Fill(dt);

                    //Revisar si hubo resultados
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow fila in dt.Rows)
                        {
                            Venta venta = new Venta()
                            {
                                ID = Convert.ToInt32(fila["ID"]),
                                FECHA = Convert.ToDateTime(fila["FECHA"]),
                                MONTO = Convert.ToDouble(fila["MONTO"]),
                                ID_CLIENTE = Convert.ToInt32(fila["ID_CLIENTE"]),
                                NOMBRE_USUARIO = fila["NOMBRE"].ToString()
                            };
                            lista.Add(venta);
                        }

                    }

                    return lista;

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

        /// <summary>
        /// Obtiene todas las ventas realizadas en el rango especificado
        /// </summary>
        /// <param name="FECHAINICIO">Fecha de inicio</param>
        /// <param name="FECHAFIN">Fecha final</param>
        /// <returns>
        /// Una lista con las ventas almacenadas en la BD dentro deL un rango de fechas específicadas 
        /// </returns>
        public List<Venta> getRange(String FECHAINICIO, String FECHAFIN)
        {

            List<Venta> lista = new List<Venta>();
            if (Conexion.Conectar())
            {
                try
                {

                    String select = @"SELECT O.ID, O.FECHA, O.MONTO, O.ID_CLIENTE, U.NOMBRE"
                                    + " FROM ORDEN O JOIN USUARIOS U ON O.ID_USUARIO = U.ID" +
                                    " WHERE DATE(FECHA)>=@FECHAINICIO && DATE(FECHA)<=@FECHAFIN" +
                                    " ORDER BY O.FECHA;";



                    //Definir un datatable para que sea llenado
                    DataTable dt = new DataTable();
                    //Crear el dataadapter
                    MySqlCommand sentencia = new MySqlCommand(select);

                    sentencia.Parameters.AddWithValue("@FECHAINICIO", FECHAINICIO);
                    sentencia.Parameters.AddWithValue("@FECHAFIN", FECHAFIN);


                    sentencia.Connection = Conexion.conexion;

                    MySqlDataAdapter da = new MySqlDataAdapter(sentencia);

                    //Llenar el datatable
                    da.Fill(dt);

                    //Revisar si hubo resultados
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow fila in dt.Rows)
                        {
                            Venta venta = new Venta()
                            {
                                ID = Convert.ToInt32(fila["ID"]),
                                FECHA = Convert.ToDateTime(fila["FECHA"]),
                                MONTO = Convert.ToDouble(fila["MONTO"]),
                                ID_CLIENTE = Convert.ToInt32(fila["ID_CLIENTE"]),
                                NOMBRE_USUARIO = fila["NOMBRE"].ToString()
                            };
                            lista.Add(venta);
                        }

                    }

                    return lista;

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

        /// <summary>
        /// Inserta una orden con los parametros especificados
        /// </summary>
        /// <param name="venta">Lista con todas las caracteristicas de la venta</param>
        /// <returns>
        /// true:Si la operación fue exitosa
        /// false: Si la operación no fue existosa
        /// </returns>
        public Boolean insert(Venta venta)
        {

            if (Conexion.Conectar())
            {
                try
                {

                    String select = @"INSERT INTO ORDEN (ID, FECHA, MONTO, ID_USUARIO, ID_CLIENTE)" +
                        "VALUES (@ID,@FECHA,@MONTO,@ID_USUARIO,@ID_CLIENTE);";

                    //Crear el dataadapter
                    MySqlCommand sentencia = new MySqlCommand(select);
                    //Asignar los parámetros
                    sentencia.Parameters.AddWithValue("@ID", venta.ID);
                    sentencia.Parameters.AddWithValue("@FECHA", venta.FECHA);
                    sentencia.Parameters.AddWithValue("@MONTO", venta.MONTO);
                    sentencia.Parameters.AddWithValue("@ID_USUARIO", venta.ID_USUARIO);
                    sentencia.Parameters.AddWithValue("@ID_CLIENTE", venta.ID_CLIENTE);



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
        ///  Edita/actualiza la información de la orden especificada
        /// </summary>
        /// <param name="MONTO">Cantidad monetaria</param>
        /// <param name="ID">Identificador de la orden</param>
        /// <returns>
        /// true:Si la operación fue exitosa
        /// false: Si la operación no fue existosa
        /// </returns>
        public Boolean update(double MONTO, int ID)
        {

            if (Conexion.Conectar())
            {
                try
                {

                    String select = @"UPDATE ORDEN " +                                                                           
                                        "SET MONTO = @MONTO " +
                                      "WHERE ID = @ID";


                    //Crear el dataadapter
                    MySqlCommand sentencia = new MySqlCommand(select);
                    //Asignar los parámetros
             
                    sentencia.Parameters.AddWithValue("@MONTO", MONTO);
                    sentencia.Parameters.AddWithValue("@ID", ID);
                  


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
        /// Elimina la orden especificada
        /// </summary>
        /// <param name="ID">Identificador de la orden a eliminar</param>
        /// <returns>
        /// true:Si la operación fue exitosa
        /// false: Si la operación no fue existosa
        /// </returns>
        public Boolean delete(int ID)
        {

            if (Conexion.Conectar())
            {
                try
                {

                    String select = @"DELETE FROM ORDEN WHERE ID = @ID";

                    //Crear el dataadapter
                    MySqlCommand sentencia = new MySqlCommand(select);
                    //Asignar los parámetros
                    sentencia.Parameters.AddWithValue("@ID", ID);



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
        /// Obtiene el último ID de la tabla ORDEN
        /// </summary>
        /// <returns>
        /// Devuelve el último ID insertado en la tabla ORDEN
        /// </returns>
        public int getId()
        {
            int ultimoID = 0;

            if (Conexion.Conectar())
            {
                try
                {
                    // Crear la sentencia SQL para obtener el último ID
                    string select = @"SELECT ID FROM ORDEN ORDER BY ID DESC LIMIT 1;";

                    // Crear el comando y asignar la sentencia SQL y la conexión
                    MySqlCommand comando = new MySqlCommand(select, Conexion.conexion);

                    // Ejecutar la consulta y obtener el resultado
                    object resultado = comando.ExecuteScalar();

                    // Verificar si el resultado no es nulo y convertirlo a entero
                    if (resultado != null && resultado != DBNull.Value)
                    {
                        ultimoID = Convert.ToInt32(resultado)+1;
                    }
                    else {
                        ultimoID = 1;
                    }
                    
                }
                finally
                {
                    // Desconectar la base de datos
                    Conexion.Desconectar();
                }
            }
            return ultimoID;

            
        }

        /// <summary>
        /// Obtiene el último ID del cliente de la tabla ORDEN
        /// </summary>
        /// <returns>
        /// Devuelve el último identificador del cliente 
        /// </returns>
        public int getCliente()
        {
            int ultimoID = 0;

            if (Conexion.Conectar())
            {
                try
                {
                    // Crear la sentencia SQL para obtener el último ID
                    string select = @"SELECT ID_CLIENTE FROM ORDEN ORDER BY ID DESC LIMIT 1;";

                    // Crear el comando y asignar la sentencia SQL y la conexión
                    MySqlCommand comando = new MySqlCommand(select, Conexion.conexion);

                    // Ejecutar la consulta y obtener el resultado
                    object resultado = comando.ExecuteScalar();

                    // Verificar si el resultado no es nulo y convertirlo a entero
                    if (resultado != null && resultado != DBNull.Value)
                    {
                        ultimoID = Convert.ToInt32(resultado)+1;
                    }
                    else
                    {
                        ultimoID = 1;
                    }

                }
                finally
                {
                    // Desconectar la base de datos
                    Conexion.Desconectar();
                }
            }
            return ultimoID;


        }

    }



}
