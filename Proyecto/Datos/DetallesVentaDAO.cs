using Modelos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DetallesVentaDAO
    {
        /// <summary>
        ///  Obtiene los detalles de la orden que se encuentran almacenados en la BD
        /// </summary>
        /// <param name="ID">Identificador de la orden deseada</param>
        /// <returns>
        /// Una lista con los elementos
        /// </returns>
        public List<DetallesVenta> getData(int ID)
        {
            List<DetallesVenta> invdv = new List<DetallesVenta>();
            if (Conexion.Conectar())
            {
                try
                {

                    String select = @"SELECT D.ID_ORDEN, D.ID_PRODUCTO, D.PRECIOUNITARIO, D.PRECIOCONEXTRA,"+
                                      "D.CANTIDAD, D.COMENTARIOS, P.NOMBRE FROM DETALLES_ORDEN D " +
                                      "JOIN PRODUCTS P ON D.ID_PRODUCTO=P.ID WHERE ID_ORDEN = @ID";

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
                        foreach (DataRow fila in dt.Rows)
                        {
                            DetallesVenta dv = new DetallesVenta()
                            {
                                ID_ORDEN = Convert.ToInt32(fila["ID_ORDEN"]),
                                ID_PRODUCTO = Convert.ToInt32(fila["ID_PRODUCTO"]),
                                NOMBRE_PRODUCTO = fila["NOMBRE"].ToString(),
                                PRECIOUNITARIO = Convert.ToDouble(fila["PRECIOUNITARIO"]),
                                PRECIOCONEXTRA = Convert.ToDouble(fila["PRECIOCONEXTRA"]),
                                CANTIDAD = Convert.ToInt32(fila["CANTIDAD"]),
                                COMENTARIOS = fila["COMENTARIOS"].ToString()


                            };
                            invdv.Add(dv);
                        }

                    }

                    return invdv;

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
        /// Inserta los detalles de orden con los parametros especificados
        /// </summary>
        /// <param name="detalles">Lista con todos los detalles de la orden</param>
        /// <returns>
        /// true:Si la operación fue exitosa
        /// false: Si la operación no fue existosa
        /// </returns>
        public Boolean insert(List<DetallesVenta> detalles)
        {

            if (Conexion.Conectar())
            {
                try
                {

                    String select = @"INSERT INTO DETALLES_ORDEN (ID_ORDEN, ID_PRODUCTO, PRECIOUNITARIO, PRECIOCONEXTRA, CANTIDAD, COMENTARIOS)"+
                                    " VALUES (@ID_ORDEN, @ID_PRODUCTO, @PRECIOUNITARIO, @PRECIOCONEXTRA, @CANTIDAD, @COMENTARIOS);";

                    //Crear el dataadapter
                    MySqlCommand sentencia = new MySqlCommand(select);
                    //Asignar los parámetros
                    sentencia.Parameters.Add("@ID_ORDEN", MySqlDbType.Int32);
                    sentencia.Parameters.Add("@ID_PRODUCTO", MySqlDbType.Int32);
                    sentencia.Parameters.Add("@PRECIOUNITARIO", MySqlDbType.Decimal);
                    sentencia.Parameters.Add("@PRECIOCONEXTRA", MySqlDbType.Decimal);
                    sentencia.Parameters.Add("@CANTIDAD", MySqlDbType.Int32);
                    sentencia.Parameters.Add("@COMENTARIOS", MySqlDbType.VarChar);

                    sentencia.Connection = Conexion.conexion;
                    for ( int i =0; i < detalles.Count(); i++)
                    {
                        sentencia.Parameters["@ID_ORDEN"].Value = detalles[i].ID_ORDEN;
                        sentencia.Parameters["@ID_PRODUCTO"].Value = detalles[i].ID_PRODUCTO;
                        sentencia.Parameters["@PRECIOUNITARIO"].Value = detalles[i].PRECIOUNITARIO;
                        sentencia.Parameters["@PRECIOCONEXTRA"].Value = detalles[i].PRECIOCONEXTRA;
                        sentencia.Parameters["@CANTIDAD"].Value = detalles[i].CANTIDAD;
                        sentencia.Parameters["@COMENTARIOS"].Value = detalles[i].COMENTARIOS;

                        sentencia.ExecuteNonQuery();
                    }
                    



                    
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
        /// Elimina el registro especificado 
        /// </summary>
        /// <param name="ID">Identificador de la orden que se desea eliminar</param>
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

                    String select = @"DELETE FROM DETALLES_ORDEN WHERE ID_ORDEN = @ID";

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
