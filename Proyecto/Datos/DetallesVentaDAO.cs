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

                    String select = @"SELECT * FROM DETALLES_ORDEN WHERE ID_ORDEN = @ID";

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
    }
}
