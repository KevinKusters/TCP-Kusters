﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Empleado:Persona
    {
        public int id;        
        public string contacto { get; set; }
        public string puesto { get; set; }
    }
}
