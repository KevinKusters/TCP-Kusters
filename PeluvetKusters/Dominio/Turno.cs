using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Turno
    {

        public int id;
        Cliente cli;
        Animal ani;
        Empleado emp;
        Servicio serv;
        public DateTime fecha { get; set; }
    }
}
