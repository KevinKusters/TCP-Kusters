using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Dominio;
using System.Data.SqlClient;

namespace Negocio
{
    public class ClienteNegocio
    {
        public List<Cliente> Listarclientes()
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            List<Cliente> listado = new List<Cliente>();
            Cliente nuevo;
            try
            {
                conexion.ConnectionString = DataAccessManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select c.id, c.nombre, c.apellido, c.contacto, c.localidad from clientes as c";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    nuevo = new Cliente();
                    nuevo.id = lector.GetInt32(0);
                    nuevo.nombre = lector.GetString(1);
                    nuevo.apellido = lector.GetString(2);
                    nuevo.contacto = lector.GetString(3);

                    listado.Add(nuevo);
                }

                return listado;

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
