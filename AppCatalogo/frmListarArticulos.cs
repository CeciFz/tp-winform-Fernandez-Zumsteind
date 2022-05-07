using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Dominio;

namespace AppCatalogo
{
    public partial class frmListarArticulos : Form
    {

        private List<Articulo> listaArticulos;

        public frmListarArticulos()
        {
            InitializeComponent();
        }


        private void cargarArticulos()
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            try
            {
                listaArticulos = articuloNegocio.listarArticulos();
                dgvArticulos.DataSource = listaArticulos;
                dgvArticulos.Columns["Id"].Visible = false;
                dgvArticulos.Columns["ImagenUrl"].Visible = false;
                pbxFotoArticulo.Load(listaArticulos[0].ImagenUrl);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }


            private void frmListarArticulos_Load(object sender, EventArgs e)
        {

                cargarArticulos();  
            /* ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            dgvArticulos.DataSource = articuloNegocio.listarArticulos();
           
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            dgvCategoria.DataSource = categoriaNegocio.listarCategoria();

            MarcaNegocio MarcaNegocio = new MarcaNegocio();
            dgvMarca.DataSource = MarcaNegocio.listarMarca();*/

        }

        private void cargarImagen(String imgArticulo)
        {
            try
            {
                pbxFotoArticulo.Load(imgArticulo);
            }
            catch (Exception ex)
            {
                pbxFotoArticulo.Load("https://diccionarioactual.com/wp-content/uploads/2017/10/disponible-768x768.png");
            }

        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            Articulo imgArticulo = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            cargarImagen(imgArticulo.ImagenUrl);
        }
    }
}
