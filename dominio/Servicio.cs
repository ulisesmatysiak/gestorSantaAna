﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Servicio
    {
        public int Id { get; set; }

        public string Corte { get; set; }

        public override string ToString()
        {
            return Corte;
        }

        public decimal Valor { get; set; }
    }
}
