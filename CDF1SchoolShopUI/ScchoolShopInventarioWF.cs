using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDF1SchoolShopUI
{
    public partial class ScchoolShopInventarioWF : Form
    {
        public ScchoolShopInventarioWF()
        {
            InitializeComponent();
        }

        private void ScchoolShopInventarioWF_Load(object sender, EventArgs e)
        {
            cbCategoria.Items.Add("Reglas");
            cbCategoria.Items.Add("Lapiceros");
            cbCategoria.Items.Add("Lapiz");
            cbCategoria.Items.Add("Borradores Grandes");
            cbCategoria.Items.Add("Sacapunta de metal");
            cbCategoria.Items.Add("Pliegos de cartulina");
            cbCategoria.Items.Add("Resma Papel bond");
            cbCategoria.Items.Add("Fastener Plastico");
            cbCategoria.Items.Add("Tijeras");
            cbCategoria.Items.Add("Cuaderno#1 Espiral");
            cbCategoria.Items.Add("Cuaderno #3");
            cbCategoria.Items.Add("Caja de colores 12U");
            cbCategoria.Items.Add("Caja de colores 24U");
            cbCategoria.Items.Add("Plumones");
            cbCategoria.Items.Add("Silicon Liquido");
            cbCategoria.Items.Add("Hojas de foami");
            cbCategoria.Items.Add("Hojas de foami brillantes");
            cbCategoria.Items.Add("Corrector");
            cbCategoria.Items.Add("Tirro");
        }

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
          
        }
    }
}
