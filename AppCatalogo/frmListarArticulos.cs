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
        string opcion = "lista";  // modifica, elimina, filtra, detalle

        public frmListarArticulos()
        {
            InitializeComponent();
        }

        public frmListarArticulos(string opcion)
        {
            this.opcion = opcion;
            InitializeComponent();

            if (opcion == "modifica")
            {
                lbltitulo.Text = "Modificar artículos";
                lblInstrucciones.Text = "Hacer doble click sobre el artículo que desea modificar";
                Text = "Modificar artículos";
            }
            else if (opcion == "elimina")
            {
                lblInstrucciones.Text = "Seleccione el artículo de la lista y presione Eliminar";
                Text = "Eliminar artículos";
                lbltitulo.Text = "Eliminar artículos";
            }
            else if (opcion == "detalle")
            {
                lblInstrucciones.Text = "Hacer doble click sobre el artículo que desea consultar";
                Text = "Detalle de artículos";
                lbltitulo.Text = "Detalle de artículos";
            }
            cargarArticulos();

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
                dgvArticulos.Columns["Precio"].DefaultCellStyle.Format = "0.00";
                pbxFotoArticulo.Load(listaArticulos[0].ImagenUrl);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }


        private void frmListarArticulos_Load(object sender, EventArgs e)
        {
            if (opcion == "filtra")
            {
                lblFiltro.Visible = true;
                btnBuscar.Visible = true;
                txtfiltro.Visible = true;
            }
            else if (opcion == "elimina")
            {
                btnEliminar.Visible = true;
            }

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
            if (opcion == "modifica")
            {
                Articulo eleccion;
                eleccion = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                frmArticulo modificarArticulo = new frmArticulo(eleccion , opcion);
                modificarArticulo.ShowDialog();
                cargarArticulos();
            }
            else if (opcion == "detalle")
            {
                Articulo eleccion;
                eleccion = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                frmArticulo detalleArticulo = new frmArticulo(eleccion , opcion);
                detalleArticulo.ShowDialog();
                cargarArticulos();
            }
        }

       //Buscar por filtro de nombre
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            List<Articulo> listafiltrada;
            listafiltrada = listaArticulos.FindAll (x => x.Codigo == txtfiltro.Text);
            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listafiltrada;
        }


        //ELIMINA POR NUMERO DE ID ARTICULO
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo seleccionado;
            try
            {

                DialogResult respuesta = MessageBox.Show("¿Desea eliminar el artículo seleccionado?","Eliminando artículo",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    negocio.eliminar(seleccionado.Id);
                    MessageBox.Show("Artículo eliminado");
                    cargarArticulos();
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
