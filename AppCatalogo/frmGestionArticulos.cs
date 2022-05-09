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

        private void btnListadoArticulos_Click(object sender, EventArgs e)
        {
            frmListarArticulos listado = new frmListarArticulos();
            listado.ShowDialog();
        }

        private void buttonbuscar_Click(object sender, EventArgs e)
        {
            frmListarArticulos ventana = new frmListarArticulos("filtra");
            ventana.ShowDialog();
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            frmListarArticulos ventana = new frmListarArticulos("elimina");
            ventana.ShowDialog();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            frmArticulo altaArticulo = new frmArticulo();
            altaArticulo.ShowDialog();
        }

        private void buttonmodificar_Click(object sender, EventArgs e)
        {
            frmListarArticulos seleccionarArticulo  = new frmListarArticulos("modifica"); 
            seleccionarArticulo.ShowDialog();   
        }
       
        private void buttondetalle_Click(object sender, EventArgs e)
        {
            frmListarArticulos seleccionarArticulo = new frmListarArticulos("detalle");
            seleccionarArticulo.ShowDialog();
        }

    }
}
