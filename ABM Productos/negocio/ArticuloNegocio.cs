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
                datos.setearConsulta("select A.Id as IdArti, A.Codigo, A.Nombre, A.Descripcion, " +
                                     "A.Precio,A.IdMarca,C.Id, M.Descripcion as des_marca, +" +
                                     "C.Descripcion as des_Categoria from ARTICULOS A, MARCAS M ," +
                                     " CATEGORIAS C where A.IdMarca = M.Id and +" +
                                     "A.IdCategoria = C.Id");
                datos.ejecutarLectura();

                while(datos.Lector.Read())
                {
                    Articulo aux = new Articulo();

                    aux.Id = (int)datos.Lector["IdArti"];                    

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

                    if (!(datos.Lector["des_marca"] is DBNull))
                    {
                        aux.des_marca = (string)datos.Lector["des_marca"];
                    }
                    if (!(datos.Lector["des_categoria"] is DBNull))
                    {
                        aux.des_categoria = (string)datos.Lector["des_categoria"];
                    }

                    aux.Id_marca= (int)datos.Lector["IdMarca"];
                    aux.Id_cate= (int)datos.Lector["Id"];


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
                // Combinar las tres consultas en una sola
                string consulta = "INSERT INTO Articulos (Codigo, Nombre, Descripcion,IdMarca,IdCategoria, Precio) " +
                                  "VALUES ('" + Art.Cod_Articulo + "','" + Art.Nombre_Articulo +
                                  "','" + Art._Descripcion + "'," + Art.Id_marca + "," + Art.Id_cate + "," + Art.Precio + ")";
                                  
                                  
                                  
                                  /*+"INSERT INTO MARCAS (Descripcion) VALUES('" + Art.des_marca + "');" +
                                  "INSERT INTO CATEGORIAS (Descripcion) VALUES('" + Art.des_categoria + "');";*/

                
                datos.setearConsulta(consulta);                
                datos.ejecutarAccion();

               /* datos.setearConsulta("insert into Articulos (Codigo, Nombre, Descripcion, Precio) values ('" + Art.Cod_Articulo + "','" + Art.Nombre_Articulo + "','" + Art._Descripcion + "'," + Art.Precio + ")");
                datos.ejecutarAccion();                                
                datos.setearConsulta("insert into MARCAS (Descripcion) values('" + Art.des_marca + "')");
                datos.ejecutarAccion();                
                datos.setearConsulta("insert into CATEGORIAS(Descripcion) values('" + Art.des_categoria + "')");
               
                datos.ejecutarAccion();*/
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
                datos.setearParametro("des_marca", modificar.des_marca);
                datos.setearParametro("des_categoria", modificar.des_categoria);

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
