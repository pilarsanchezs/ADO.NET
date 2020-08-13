using ADO.NET.Dominio;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET.Persistencia
{
    class FacturaRepository
    {
        //inserta objeto factura
        public void Insertar(Factura factura)
        {
            using (SqlConnection conexion =
            new SqlConnection(CadenaConexion()))
            {
                conexion.Open();
                String sql = "insert into " +
                    "Facturas(numero, concepto) " +
                    "values (@Numero, @Concepto)";
                SqlCommand comando = new SqlCommand(sql, conexion);
                comando.Parameters.AddWithValue("@Numero", factura.Numero);
                comando.Parameters.AddWithValue("@Concepto", factura.Concepto);

                comando.ExecuteNonQuery();

            }
        }

        public void Borrar(Factura factura)
        {

            using (SqlConnection conexion =
            new SqlConnection(CadenaConexion()))
            {
                conexion.Open();
                String sql = "delete from Facturas where Numero=@Numero";

                SqlCommand comando = new SqlCommand(sql, conexion);
                comando.Parameters.AddWithValue("@Numero", factura.Numero);
                comando.ExecuteNonQuery();

            }
        }

        public Factura BuscarUno(int numero)
        {

            using (SqlConnection conexion =
          new SqlConnection(CadenaConexion()))
            {
                conexion.Open();
                String sql = "select * from Facturas where Numero=@Numero";

                SqlCommand comando = new SqlCommand(sql, conexion);
                comando.Parameters.AddWithValue("@Numero", numero);
                SqlDataReader lector = comando.ExecuteReader();

                if (lector.Read())
                {
                    Factura factura = new Factura
                       (Convert.ToInt32(lector["numero"]),
                       lector["concepto"].ToString());
                    return factura;

                }
                else
                {
                    return null;
                }
            }


        }

        public List<Factura> BuscarTodos()
        {

            List<Factura> lista = new List<Factura>();
            using (SqlConnection conexion =
          new SqlConnection(CadenaConexion()))
            {
                conexion.Open();
                String sql = "select * from Facturas";
                SqlCommand comando = new SqlCommand(sql, conexion);

                SqlDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    lista.Add(new Factura
                        (Convert.ToInt32(lector["numero"]),
                        lector["concepto"].ToString()));

                }

                return lista;
            }


        }
        


        private static string CadenaConexion()
        {
            ConnectionStringSettings settings =
                ConfigurationManager
                .ConnectionStrings["miconexion"];
            String cadena = settings.ConnectionString;
            return cadena;
        }
    }
}
