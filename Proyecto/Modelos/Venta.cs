using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Venta
    {
        public int ID { get; set; }
        public DateTime FECHA { get; set; }
        public double MONTO { get; set; }
        public int ID_USUARIO { get; set; }
        public int ID_CLIENTE { get; set; }
        public String NOMBRE_USUARIO { get; set; }

        

    }
}
