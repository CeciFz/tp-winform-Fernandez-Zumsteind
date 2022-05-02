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


        }
    }
}
