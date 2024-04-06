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
                    sentencia.Connection = Conexion.conexion;
                    for ( int i =0; i < detalles.Count(); i++)
                    {
                        sentencia.Parameters.AddWithValue("@ID_ORDEN", detalles[i].ID_ORDEN);
                        sentencia.Parameters.AddWithValue("@ID_PRODUCTO", detalles[i].ID_PRODUCTO);
                        sentencia.Parameters.AddWithValue("@PRECIOUNITARIO", detalles[i].PRECIOUNITARIO);
                        sentencia.Parameters.AddWithValue("@PRECIOCONEXTRA", detalles[i].PRECIOCONEXTRA);
                        sentencia.Parameters.AddWithValue("@CANTIDAD", detalles[i].CANTIDAD);
                        sentencia.Parameters.AddWithValue("@COMENTARIOS", detalles[i].COMENTARIOS);

                        

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
