using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public  class DetallesVenta
    {
        public String NOMBRE_PRODUCTO { get; set; }
        public int CANTIDAD { get; set; } 
        public double PRECIOUNITARIO { get; set; }
        public double PRECIOCONEXTRA { get; set; }
        public String COMENTARIOS { get; set; }
        public int ID_ORDEN { get; set; }
        public int ID_PRODUCTO { get; set; }
        public double TOTAL { get; set; }

      
        public override bool Equals(object obj)
        {
            DetallesVenta other = (DetallesVenta)obj;
            return (NOMBRE_PRODUCTO== other.NOMBRE_PRODUCTO &&
                    PRECIOUNITARIO == other.PRECIOUNITARIO &&
                    PRECIOCONEXTRA == other.PRECIOCONEXTRA &&
                    COMENTARIOS == other.COMENTARIOS&&
                    ID_ORDEN== other.ID_ORDEN &&
                    ID_PRODUCTO == other.ID_PRODUCTO);
        }

    }
}
