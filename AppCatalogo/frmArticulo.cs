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
    public partial class frmArticulo : Form
    {
        private Articulo articulo = null;

        public frmArticulo()
        {
            InitializeComponent();
        }

        public frmArticulo(Articulo articulo, string opcion)
        {
            InitializeComponent();
            this.articulo = articulo;
            if (opcion == "modifica") Text = "Modificar artículo";

            else if (opcion == "detalle")
            {
                Text = "Detalle de artículo";
                txtCodigo.ReadOnly = true;
                txtNombre.ReadOnly = true;
                txtDescripcion.ReadOnly = true;
                txtUrlImg.ReadOnly = true;
                txtPrecio.ReadOnly = true;
                cboCategoria.Enabled = false;
                cboMarca.Enabled = false;
                buttonCancelar.Visible = false;
                buttonConfirmar.Visible = false;
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            if (validaCarga()) return;
            try
            {
                if (articulo == null) articulo = new Articulo();

                articulo.Codigo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.ImagenUrl = txtUrlImg.Text;
                articulo.Marca = (Marca)cboMarca.SelectedItem;
                articulo.Categoria = (Categoria)cboCategoria.SelectedItem;
                articulo.Precio = decimal.Parse(txtPrecio.Text);

                if (articulo.Id != 0)
                {
                    articuloNegocio.modificarArticulo(articulo);
                    MessageBox.Show("Artículo modificado");
                }
                else
                {
                    articuloNegocio.agregarArticulo(articulo);
                    MessageBox.Show("Artículo agregado");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            finally
            {
                Close();
            }
        }

        private void frmArticulo_Load(object sender, EventArgs e)
        {

            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

            try
            {

                cboMarca.DataSource = marcaNegocio.listarMarca();
                cboMarca.ValueMember = "Id";
                cboMarca.DisplayMember = "Descripcion";
                cboCategoria.DataSource = categoriaNegocio.listarCategoria();
                cboCategoria.ValueMember = "Id";
                cboCategoria.DisplayMember = "Descripcion";

                if (articulo != null)  
                {
                    txtCodigo.Text = articulo.Codigo;
                    txtNombre.Text = articulo.Nombre;
                    txtDescripcion.Text = articulo.Descripcion;
                    txtUrlImg.Text = articulo.ImagenUrl;
                    txtPrecio.Text = articulo.Precio.ToString("0.00");

                    cargarImagen(articulo.ImagenUrl);

                    cboCategoria.SelectedValue = articulo.Categoria.Id;
                    cboMarca.SelectedValue = articulo.Marca.Id;
                }

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
                pbxArticulo.Load(imagen);
            }
            catch (Exception ex)
            {
                pbxArticulo.Load("https://www.blackwallst.directory/images/NoImageAvailable.png");
            }
        }

        private void txtUrlImg_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtUrlImg.Text);
        }

        private bool validaCarga()
        {
            if (string.IsNullOrEmpty(txtCodigo.Text) || string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtPrecio.Text))
            {
                MessageBox.Show("Los campos con * son obligatorios");
                return true;
            }

            if (!validaNumeros(txtPrecio.Text))
            {
                 MessageBox.Show("Solo ingresar números en Precio");
                 return true;

            }

            return false;
        }


        private bool validaNumeros (string cadena)
        {
            foreach (char caracter in cadena)
            {
                if (char.IsNumber(caracter))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
