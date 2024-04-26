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
            AccesoDatos datos2 = new AccesoDatos();

            try
            {
                //datos.setearConsulta("select A.Id as IdArti, A.Codigo, A.Nombre, A.Descripcion,A.Precio,A.IdMarca,C.Id, M.Descripcion as des_marca,C.Descripcion as des_Categoria from ARTICULOS A, MARCAS M ,CATEGORIAS C where A.IdMarca = M.Id and A.IdCategoria = C.Id");
                
                datos.setearConsulta("select A.Id as IdArti, A.Codigo, A.Nombre," +
                                         " A.Descripcion, A.Precio,A.IdMarca,C.Id," +
                                         " M.Descripcion as des_marca, " +
                                         "C.Descripcion as des_Categoria " +
                                         "from ARTICULOS A, MARCAS M , CATEGORIAS C " +
                                         "where A.IdMarca = M.Id and A.IdCategoria = C.Id");
                datos.ejecutarLectura();

                datos2.setearConsulta("select I.Id, I.IdArticulo, I.ImagenUrl " +
                                      "from IMAGENES I , ARTICULOS A  where IdArticulo = A.Id ");
                datos2.ejecutarLectura();

                
            List<Articulo> lista1 = new List<Articulo>();

                while (datos.Lector.Read())
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

                    aux.Id_marca = (int)datos.Lector["IdMarca"];
                    aux.Id_cate = (int)datos.Lector["Id"];


                    if (!(datos.Lector["des_marca"] is DBNull))
                    {
                        aux.des_marca = (string)datos.Lector["des_marca"];
                    }
                    if (!(datos.Lector["des_categoria"] is DBNull))
                    {
                        aux.des_categoria = (string)datos.Lector["des_categoria"];
                    }                   

                    lista.Add(aux);
                }

                List<Articulo> lista2 = new List<Articulo>();


                /*while (datos2.Lector.Read())
                {
                    Articulo aux1 = new Articulo();
                    
                    //IMAGENES
                    if (!(datos2.Lector["ImagenUrl"] is DBNull))
                    {
                        aux1.urlImagen = (string)datos2.Lector["ImagenUrl"];
                    }

                    aux1.IdArticulo = (int)datos2.Lector["IdArticulo"];

                    aux1.Id_imagen = (int)datos2.Lector["Id_img"];

                    lista2.Add(aux1);
                }

                int num1 = lista1.Count;
                int num2 = lista2.Count;

                Articulo aux2 = new Articulo();
                Articulo aux3 = new Articulo();

                for (int i = 0; i < num1; i++)
                {

                    Articulo aux4 = new Articulo();

                         aux2 = lista1[i];

                        for (int k = 0; k < num2; k++)
                        {

                        aux3 = lista2[k]; 
                        

                            if (aux2.Id == aux3.IdArticulo)
                            {
                                aux4.Id = aux2.Id;
                                aux4.Cod_Articulo = aux2.Cod_Articulo;
                                aux4.Nombre_Articulo = aux2.Nombre_Articulo;
                                aux4._Descripcion = aux2._Descripcion;
                                aux4.Precio = aux2.Precio;
                                aux4.Id_marca = aux2.Id_marca;
                                aux4.Id_cate = aux2.Id_cate;
                                aux4.des_marca = aux2.des_marca;
                                aux4.des_categoria = aux2.des_categoria;

                                aux4.urlImagen = aux3.urlImagen;
                                aux4.IdArticulo = aux3.IdArticulo;
                                aux4.Id_imagen = aux3.Id_imagen;


                                lista.Add(aux4);
                            }
                        }
                 }*/

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
                string consulta = "INSERT INTO Articulos (Codigo, Nombre, Descripcion," +
                                  "IdMarca,IdCategoria, Precio) " +
                                  "VALUES ('" + Art.Cod_Articulo + "','" + Art.Nombre_Articulo +"'" +
                                  ",'" + Art._Descripcion + "',"+ Art.Id_marca +"," +
                                  ""+ Art.Id_cate +","+ Art.Precio +")";

                datos.setearConsulta(consulta);
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
                datos.setearConsulta("update ARTICULOS set Codigo = '" + modificar.Cod_Articulo + "" +
                                    "', Nombre = '" + modificar.Nombre_Articulo + "" +
                                    "', Descripcion = '" + modificar._Descripcion + "'" +
                                    ", IdMarca = " + modificar.Id_marca +"," +
                                    " IdCategoria = " + modificar.Id_cate + " ," +
                                    "Precio = " + modificar.Precio + "" +
                                    " where Id = "+ modificar.Id +"");

                datos.setearParametro("Codigo", modificar.Cod_Articulo);
                datos.setearParametro("Nombre", modificar.Nombre_Articulo);
                datos.setearParametro("Descripcion", modificar._Descripcion);               
                
                datos.setearParametro("Id", modificar.Id);
                datos.setearParametro("IdMarca", modificar.Id_marca);
                datos.setearParametro("IdCategoria", modificar.Id_cate);
                datos.setearParametro("Precio", modificar.Precio);

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
