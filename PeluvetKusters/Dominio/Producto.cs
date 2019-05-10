using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Producto
    {
        public int idProducto { get; set; }
        public string descripcion { get; set; }
        public int precio { get; set; }
        Proveedor prov;

    }
}
