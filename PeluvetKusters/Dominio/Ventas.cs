using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Venta
    {
        public int idVenta { get; set; }
        public int costo { get; set; }
        public DateTime fecha;
        Cliente client;
    }
}
