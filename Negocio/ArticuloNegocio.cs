﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;


namespace Negocio
{
    public class ArticuloNegocio
    {

        public List<Articulo> listarArticulos()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("select A.Id, A.Codigo, A.Nombre, A.Descripcion, M.Descripcion Marca, C.Descripcion Categoria, A.Precio, A.ImagenUrl from ARTICULOS A, MARCAS M, CATEGORIAS C where M.Id = A.IdMarca AND C.Id = A.IdCategoria");
                datos.lecturaDatos();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];

                    aux.Marca = new Marca();
                    aux.Categoria = new Categoria();

                    aux.Marca.Descripcion = (String)datos.Lector["Marca"];
                    aux.Categoria.Descripcion = (String)datos.Lector["Categoria"];

                    if (!(datos.Lector["ImagenUrl"] is DBNull))  aux.ImagenUrl = (String)datos.Lector["ImagenUrl"];

                    aux.Precio = (decimal)datos.Lector["Precio"];  
                    

                    lista.Add(aux);
                }

                return lista;

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

        public void agregarArticulo(Articulo nuevoArticulo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Insert into ARTICULOS (Codigo, Nombre, Descripcion, ImagenUrl, IdMarca,  IdCategoria, Precio) VALUES (@Codigo, @Nombre, @Descripcion, @ImagenUrl, @IdMarca, @IdCategoria, @Precio)");
                datos.SetearParametro("@Codigo", nuevoArticulo.Codigo);
                datos.SetearParametro("@Nombre", nuevoArticulo.Nombre);
                datos.SetearParametro("@Descripcion", nuevoArticulo.Descripcion);
                datos.SetearParametro("@ImagenUrl", nuevoArticulo.ImagenUrl);
                datos.SetearParametro("@IdMarca", nuevoArticulo.Marca.Id);
                datos.SetearParametro("@IdCategoria", nuevoArticulo.Categoria.Id);
                datos.SetearParametro("@Precio", nuevoArticulo.Precio);
                datos.SetearParametro("@Id", nuevoArticulo.Id);

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

        public void modificarArticulo(Articulo nuevoArticulo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Update ARTICULOS Set Codigo = @Codigo, Nombre =@Nombre, Descripcion = @Descripcion, ImagenUrl = @ImagenUrl, IdMarca = @Marca,  IdCategoria = @IdCategoria, Precio = @Precio where Id = @Id");
                datos.SetearParametro("@Codigo", nuevoArticulo.Codigo);
                datos.SetearParametro("@Nombre", nuevoArticulo.Nombre);
                datos.SetearParametro("@Descripcion", nuevoArticulo.Descripcion);
                datos.SetearParametro("@ImagenUrl", nuevoArticulo.ImagenUrl);
                datos.SetearParametro("@IdMarca", nuevoArticulo.Marca.Id);
                datos.SetearParametro("@IdCategoria", nuevoArticulo.Categoria.Id);
                datos.SetearParametro("@Precio", nuevoArticulo.Precio);
                datos.SetearParametro("@Id", nuevoArticulo.Id);

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

    }
}
