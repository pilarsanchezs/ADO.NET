using ADO.NET.Persistencia;
using ADO.NET.Dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET
{
    class Program7

    {
        static void Main(string[] args)
        {
            FacturaRepository repositorio = new FacturaRepository();
            // -------- INSERTAR -------
            //repositorio.Insertar(new Factura(3, "movil"));
            // -------- BORRAR -------
            //repositorio.Borrar(new Factura(1));
            // -------- BUSCAR UNO  -------
            //Factura factura = repositorio.BuscarUno(1);
            //Console.WriteLine(factura.Concepto);
            // -------- BUSCAR TODOS  -------
            List<Factura> facturas = repositorio.BuscarTodos();
            foreach(Factura f in facturas)
            {
                Console.WriteLine(f.Numero + "-" + f.Concepto);
               
            }
            Console.ReadLine();
        }
    }
}
