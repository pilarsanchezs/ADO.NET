using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET.Dominio
{
    class Factura
    {
        //SOBRECARGA CONSTRUCTOR
        public Factura(int numero)
        {
            Numero = numero;
        }

        public Factura(int numero, string concepto)
        {
            Numero = numero;
            Concepto = concepto;
        }

        public int Numero { get; set; }
        public string Concepto { get; set; }
    }
}
