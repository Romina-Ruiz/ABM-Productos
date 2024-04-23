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
                datos.setearConsulta("select Id, Codigo, Nombre, Descripcion, Precio from ARTICULOS");
                datos.ejecutarLectura();

                while(datos.Lector.Read())
                {
                    Articulo aux = new Articulo();

                    aux.Id = (int)datos.Lector["Id"];                    

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
        public void Modificar(Articulo modificar)
        {
            AccesoDatos datos = new AccesoDatos();
        
            try
            {
                datos.setearConsulta("update ARTICULOS set Codigo = '" + modificar.Cod_Articulo + "', Nombre = '" + modificar.Nombre_Articulo + "', Descripcion = '" + modificar._Descripcion + "', Precio = " + modificar.Precio + " where Id = "+ modificar.Id +"");
                datos.setearParametro("Codigo", modificar.Cod_Articulo);
                datos.setearParametro("Nombre", modificar.Nombre_Articulo);
                datos.setearParametro("Descripcion", modificar._Descripcion);
                datos.setearParametro("Precio", modificar.Precio);
                datos.setearParametro("Id", modificar.Id);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
        public void eliminar(int id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setearConsulta("delete from ARTICULOS where id = " + id + "");
                datos.setearParametro("Id", id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
