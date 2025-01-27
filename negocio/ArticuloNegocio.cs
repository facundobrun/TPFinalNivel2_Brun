using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;

namespace negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            //creo la lista de Articulos:
            List<Articulo> lista = new List<Articulo>();
            //SqlConnection para conectarme a la base de datos:
            SqlConnection conexion = new SqlConnection();
            //Una vez que me conecte, para realizar acciones hago SqlCommand:
            SqlCommand comando = new SqlCommand();
            //Leer la base de datos:
            SqlDataReader lector;

            try
            {
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }

            
        }
    }
}
