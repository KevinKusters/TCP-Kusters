using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Animal
    {
        public int id { get; set; }
        public int idcliente { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string especie { get; set; }
        Raza raz;
    }
}
