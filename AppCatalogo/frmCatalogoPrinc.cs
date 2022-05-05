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
    public partial class frmCatalogoPrinc : Form
    {
        public frmCatalogoPrinc()
        {
            InitializeComponent();
        }

        private void frmCatalogoPrinc_Load(object sender, EventArgs e)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            dgvArticulos.DataSource = articuloNegocio.listarArticulos();

            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            dgvCategoria.DataSource = categoriaNegocio.listarCategoria();

            MarcaNegocio MarcaNegocio = new MarcaNegocio();
            dgvMarca.DataSource = MarcaNegocio.listarMarca();

        }

        private void dgvArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void entrar_Click(object sender, EventArgs e)
        {
             frmmenu ventana = new frmmenu();
            ///ventana.MdiParent = this;

            ventana.ShowDialog();
            


        }

        private void dgvCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
