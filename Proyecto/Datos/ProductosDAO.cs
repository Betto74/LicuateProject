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
    public class ProductosDAO
    {

        public Producto getData(int ID)
        {
            Producto prod = null;
            if (Conexion.Conectar())
            {
                try
                {

                    String select = @"SELECT FROM PRODUCTS WHERE ID = @ID";

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
                        prod = new Producto()
                        {
                            ID = Convert.ToInt32(fila["ID"]),
                            NOMBRE = fila["NOMBRE"].ToString(),
                            PRECIO = Convert.ToDouble(fila["PRECIO"]),
                            DESCRIPCION = fila["DESCRIPCION"].ToString(),
                            CATEGORIA = fila["CATEGORIA"].ToString()
                        };

                    }

                    return prod;

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
        /// Obtiene todos los registros de la tabla PRODUCTS de la BD
        /// </summary>
        /// <returns>
        /// Una lista con todos los productos almacenados en la BD
        /// </returns>
        public List<Producto> getAllData()
        {

            List<Producto> invProd = new List<Producto>();
            if (Conexion.Conectar())
            {
                try
                {

                    String select = @"SELECT * FROM PRODUCTS";

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
                            Producto prod = new Producto()
                            {
                                ID = Convert.ToInt32(fila["ID"]),
                                NOMBRE = fila["NOMBRE"].ToString(),
                                PRECIO = Convert.ToDouble(fila["PRECIO"]),
                                DESCRIPCION = fila["DESCRIPCION"].ToString(),
                                CATEGORIA = fila["CATEGORIA"].ToString()


                            };
                            invProd.Add(prod);
                        }

                    }

                    return invProd;

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
        /// Inserta un producto con los parametros especificados
        /// </summary>
        /// <param name="prod">Lista con todas las caracteristicas del producto</param>
        /// <returns>
        ///  true:Si la operación fue exitosa
        /// false: Si la operación no fue existosa
        /// </returns>
        public Boolean insert(Producto prod)
        {

            if (Conexion.Conectar())
            {
                try
                {

                    String select = @"INSERT INTO PRODUCTS (NOMBRE, DESCRIPCION, PRECIO, CATEGORIA)"+
                        "VALUES (@NOMBRE,@DESCRIPCION,@PRECIO,@CATEGORIA);";

                    //Crear el dataadapter
                    MySqlCommand sentencia = new MySqlCommand(select);
                    //Asignar los parámetros
                    sentencia.Parameters.AddWithValue("@NOMBRE", prod.NOMBRE);
                    sentencia.Parameters.AddWithValue("@DESCRIPCION", prod.DESCRIPCION);
                    sentencia.Parameters.AddWithValue("@PRECIO", prod.PRECIO);
                    sentencia.Parameters.AddWithValue("@CATEGORIA", prod.CATEGORIA);
                   


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
        ///  Edita/actualiza la información del  producto especificado
        /// </summary>
        /// <param name="prod">Lista con todas las caracteristicas del producto</param>
        /// <returns>
        ///  true:Si la operación fue exitosa
        /// false: Si la operación no fue existosa
        /// </returns>
        public Boolean update(Producto prod)
        {

            if (Conexion.Conectar())
            {
                try
                {

                    String select = @"UPDATE PRODUCTS "+
                                        "SET NOMBRE = @NOMBRE,"+
                                        "DESCRIPCION = @DESCRIPCION,"+ 
                                        "PRECIO = @PRECIO,"+
                                        "CATEGORIA = @CATEGORIA "+
                                      "WHERE ID = @ID";


                    //Crear el dataadapter
                    MySqlCommand sentencia = new MySqlCommand(select);
                    //Asignar los parámetros
                    sentencia.Parameters.AddWithValue("@NOMBRE", prod.NOMBRE);
                    sentencia.Parameters.AddWithValue("@DESCRIPCION", prod.DESCRIPCION);
                    sentencia.Parameters.AddWithValue("@PRECIO", prod.PRECIO);
                    sentencia.Parameters.AddWithValue("@CATEGORIA", prod.CATEGORIA);
                    sentencia.Parameters.AddWithValue("@ID", prod.ID);



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
        /// Elimina el producto especificado 
        /// </summary>
        /// <param name="ID">Identificador del producto a eliminar</param>
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

                    String select = @"DELETE FROM PRODUCTS WHERE ID = @ID";

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
        
    }

   
}
