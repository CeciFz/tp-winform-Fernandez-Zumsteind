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

        private void btnVerCatalogo_Click(object sender, EventArgs e)
        {
            frmCatalogo catalogo = new frmCatalogo();
            catalogo.ShowDialog();
        }

        private void btnAdministrar_Click(object sender, EventArgs e)
        {
            frmmenu menu = new frmmenu();
            menu.ShowDialog();
        }
    }
}
