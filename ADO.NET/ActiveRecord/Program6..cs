﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET
{
    class Program6
    {
        static void Main(string[] args)
        {
            FacturaActiveRecord f = FacturaActiveRecord.BuscarUno(1);

            List<LineasFacturaActiveRecord> lista =
                f.BuscarLineas();

           foreach (LineasFacturaActiveRecord lf  in lista)
            {

                Console.WriteLine(lf.ProductoId);
                Console.WriteLine(lf.Unidades);

            }

            List<FacturaLineaDTO> lista2 =
                FacturaActiveRecord.BuscarFacturaLinea();

            foreach (FacturaLineaDTO lf in lista2)
            {

                Console.WriteLine(lf.Unidades);
                Console.WriteLine(lf.NumeroFactura);

            }
            int resultado= FacturaActiveRecord.TotalUnidades();
            Console.WriteLine(resultado);


            Console.ReadLine();


            /*  // -------- BUSCAR TODOS CON FILTRO -------
           FiltroFactura filtro = new FiltroFactura();
            filtro.Concepto = "tablet";
            List<Factura> facturas = repositorio.BuscarTodos(filtro);
            foreach (Factura f in facturas)
            {
                Console.WriteLine(f.Numero + "-" + f.Concepto);

            }
            Console.ReadLine(); *


        }*/
        }
    }
}
