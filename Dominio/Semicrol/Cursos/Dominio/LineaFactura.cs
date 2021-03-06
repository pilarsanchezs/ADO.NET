﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrol.Cursos.Dominio
{
   public class LineaFactura
    {
        public LineaFactura(int numero, string productoId, int unidades, int facturaNumero)
        {
            Numero = numero;
            ProductoId = productoId;
            Unidades = unidades;
            FacturaNumero = facturaNumero;
        }

        public int Numero { get; set; }
        public string ProductoId { get; set; }
        public int Unidades { get; set; }
        public int FacturaNumero { get; set; }
    }
}
