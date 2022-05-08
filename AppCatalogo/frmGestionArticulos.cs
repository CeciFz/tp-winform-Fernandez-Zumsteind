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
    public partial class frmmenu : Form
    {

        public frmmenu()
        {
            InitializeComponent();
        }

        private void buttoneliminar_Click(object sender, EventArgs e)
        {

        }

        private void v_Load(object sender, EventArgs e)
        {

        }

        private void buttonlistar_Click(object sender, EventArgs e)
        {
            frmListarArticulos ventana = new frmListarArticulos();
            ventana.ShowDialog();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            frmArticulo altaArticulo = new frmArticulo();
            altaArticulo.ShowDialog();
        }

        private void buttonmodificar_Click(object sender, EventArgs e)
        {
            frmListarArticulos seleccionarArticulo  = new frmListarArticulos(true); 
            seleccionarArticulo.ShowDialog();   
        }

        private void buttonbuscar_Click(object sender, EventArgs e)
        {
            frmListarArticulos ventana = new frmListarArticulos(false);
            ventana.ShowDialog();
        }
    }
}
