using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Cliente:Persona
    {
        public int id;
        public string contacto { get; set; }
        Localidad loc;
        Animal ani;
    }
}
