﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class CategoriaNegocio
    {
        public List<Categoria> listar()
        {
            List<Categoria>listaCategorias = new List<Categoria>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Select Id,Descripcion from CATEGORIAS");
                datos.ejecutarLectura();
                
                while(datos.Lector.Read())
                {
                    Categoria aux= new Categoria();
                    aux.Id= (int)datos.Lector["Id"];
                    aux.Descripcion= (string)datos.Lector["Descripcion"];
                    listaCategorias.Add(aux);

                }

                return listaCategorias;
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
        public void agregar(Categoria nueva)
        {
            AccesoDatos datos= new AccesoDatos();
            try
            {
                datos.setearConsulta("Insert into CATEGORIAS(Descripcion)values('" + nueva.Descripcion + "')");
                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally {
                datos.cerrarConexion();
            }

        }
    }
}
