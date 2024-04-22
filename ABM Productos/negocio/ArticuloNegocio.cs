using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;
using System.Data.SqlClient;
using System.Data.SqlTypes;
namespace negocio



{
     public class ArticuloNegocio
    {
        public List<Articulo> listar() 
        {

            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("select Codigo, Nombre, Descripcion, Precio from ARTICULOS");
                datos.ejecutarLectura();

                while(datos.Lector.Read())
                {
                    Articulo aux = new Articulo();


                    if (!(datos.Lector.IsDBNull(datos.Lector.GetOrdinal("Codigo"))))
                    {
                        aux.Cod_Articulo = (string)datos.Lector["Codigo"];
                    }
                    if (!(datos.Lector.IsDBNull(datos.Lector.GetOrdinal("Nombre"))))
                    {
                        aux.Nombre_Articulo = (string)datos.Lector["Nombre"];
                    }
                    if (!(datos.Lector.IsDBNull(datos.Lector.GetOrdinal("Descripcion"))))
                    {
                        aux._Descripcion = (string)datos.Lector["Descripcion"];
                    }
                    if (!(datos.Lector["Precio"] is DBNull))
                    {
                        decimal cantidad = (decimal)datos.Lector["Precio"];
                        aux.Precio = (float)cantidad;
                    }

                    lista.Add(aux);
                }
                
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;

            }
            
        }

        public void Agregar(Articulo Art)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("insert into Articulos (Codigo, Nombre, Descripcion, Precio) values ('" + Art.Cod_Articulo + "','" + Art.Nombre_Articulo + "','" + Art._Descripcion + "'," + Art.Precio + ")");
                datos.ejecutarAccion();
            }
            catch (Exception)
            {

                throw;
            }
            finally 
            {
                datos.cerrarConexion();
            }
        
        
        }

    }
}
