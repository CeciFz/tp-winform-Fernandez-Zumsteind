using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace AppCatalogo
{
    public partial class frmCatalogo : Form
    {
        int i = 0;
        private List<Articulo> listaArticulos;
        int cant;

        public frmCatalogo()
        {
            InitializeComponent();
        }

        private void frmCatalogo_Load(object sender, EventArgs e)
        {
            cargarCatalogo();
        }

        private void cargarCatalogo()
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();

            try
            {
                listaArticulos = articuloNegocio.listarArticulos();
                cant = listaArticulos.Count;

                cargarImagen(listaArticulos[i].ImagenUrl); 
                lblDescripcion.Text = listaArticulos[i].Descripcion;
                lblNombre.Text = listaArticulos[i].Nombre;
                lblDescripcion.Text = listaArticulos[i].Descripcion;
                lblCategoria.Text = listaArticulos[i].Categoria.Descripcion;
                lblMarca.Text = listaArticulos[i].Marca.Descripcion;
                lblPrecio2.Text = listaArticulos[i].Precio.ToString("0.00");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxArt.Load(imagen);
            }
            catch (Exception ex)
            {
                pbxArt.Load("https://www.blackwallst.directory/images/NoImageAvailable.png");
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (i < cant-1)
            {
                i++;               
            } else
            {
                i = 0;
            }

            cargarCatalogo();

        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (i > 0)
            {
                i--;
            }
            else
            {
                i = cant-1;
            }

            cargarCatalogo();
        }
    }
}
