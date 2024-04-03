using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CDF1SchoolShopEN;
using CDF1SchoolShopBL;

namespace CDF1SchoolShopUI
{
    public partial class SchoolShopVentasWF : Form
    {
        public SchoolShopVentasWF()
        {
            InitializeComponent();
        }

        private void cbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPrecio.Enabled = false;
            cbProducto.Items.Add("Regla");
            cbProducto.Items.Add("Lapicero");
            cbProducto.Items.Add("Lapiz");
            cbProducto.Items.Add("Borrador grande");
            cbProducto.Items.Add("Sacapunta de metal");
            cbProducto.Items.Add("Pliego de cartulina");
            cbProducto.Items.Add("Resma Papel bond");
            cbProducto.Items.Add("Fastener Plastico");
            cbProducto.Items.Add("Tijera");
            cbProducto.Items.Add("Cuaderno #1");
            cbProducto.Items.Add("Cuaderno #3");
            cbProducto.Items.Add("Caja de colores 12/U");
            cbProducto.Items.Add("Caja de colores 24/U");
            cbProducto.Items.Add("Plumon");
            cbProducto.Items.Add("Silicon liquido");
            cbProducto.Items.Add("Hoja de foami");
            cbProducto.Items.Add("Hoja de foami brillante");
            cbProducto.Items.Add("Corrector");
            cbProducto.Items.Add("Tirro");
            cbProducto.SelectedIndex = 0;

        }
    }
}
