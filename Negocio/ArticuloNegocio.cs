using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
//cambio
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
                datos.setearConsulta("select A.Codigo, A.Nombre, A.Descripcion, M.Descripcion Marca, C.Descripcion Categoria, A.Precio, A.ImagenUrl from ARTICULOS A, MARCAS M, CATEGORIAS C where M.Id = A.IdMarca AND C.Id = A.IdCategoria");
                datos.lecturaDatos();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];

                    aux.IdMarca = new Marca();
                    aux.IdCategoria = new Categoria();

                    aux.IdMarca.Descripcion = (String)datos.Lector["Marca"];
                    aux.IdCategoria.Descripcion = (String)datos.Lector["Categoria"];

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

    }
}
