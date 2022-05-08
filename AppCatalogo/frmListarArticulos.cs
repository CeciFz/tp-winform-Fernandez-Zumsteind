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
        bool modifica = false;

        public frmListarArticulos()
        {
            InitializeComponent();
        }

        public frmListarArticulos(bool modifica)
        {
            InitializeComponent();
            lbltitulo.Text = "Seleccione el artículo que desea modificar";
            this.modifica = modifica;
            cargarArticulos();
        }


        private void cargarArticulos()
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            try
            {
                listaArticulos = articuloNegocio.listarArticulos();
                dgvArticulos.DataSource = listaArticulos;
                dgvArticulos.Columns["Id"].Visible = true;
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

        private void dgvArticulos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (modifica == true)
            {
                Articulo opcion;
                opcion = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                frmArticulo modificarArticulo = new frmArticulo(opcion);
                modificarArticulo.ShowDialog();
                cargarArticulos();
            }
        }

        private void dgvArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void labelFiltro_Click(object sender, EventArgs e)
        {

        }

       //Buscar por filtro de nombre
        private void buttonbuscar_Click(object sender, EventArgs e)
        {
            List<Articulo> listafiltrada;
            listafiltrada = listaArticulos.FindAll (x => x.Codigo == txtfiltro.Text);
            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listafiltrada;
        }


        //ELIMINA POR NUMERO DE ID ARTICULO
        private void buttoneliminar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo seleccionado;
            try
            {
                seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

                negocio.eliminar(seleccionado.Id);

                MessageBox.Show("Eliminacion con exito");

                cargarArticulos();
                
                

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void lbltitulo_Click(object sender, EventArgs e)
        {

        }
    }
}
