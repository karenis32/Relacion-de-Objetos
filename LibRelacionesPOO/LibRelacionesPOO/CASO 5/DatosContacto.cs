﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibRelacionesPOO.CASO_5
{
    public class DatosContacto
    {
        public string Domicilio { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public Cliente cliente { get; set; }
        public Empleado empleado { get; set; }
    }
}
