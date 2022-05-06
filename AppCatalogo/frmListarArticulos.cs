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

namespace AppCatalogo
{
    public partial class frmListadoArticulos : Form
    {
        public frmListadoArticulos()
        {
            InitializeComponent();
        }

        private void frmListadoArticulos_Load(object sender, EventArgs e)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            dgvArticulos.DataSource = articuloNegocio.listarArticulos();

            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            dgvCategoria.DataSource = categoriaNegocio.listarCategoria();

            MarcaNegocio MarcaNegocio = new MarcaNegocio();
            dgvMarca.DataSource = MarcaNegocio.listarMarca();

        }
    }
}
