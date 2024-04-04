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
        int indice = 0;
        double Precio = 0;
        public SchoolShopVentasWF()
        {
            InitializeComponent();
        }


        private void cbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            indice = cbProducto.SelectedIndex;
            switch (indice)
            {
                case 1:
                    Precio = 0.25;
                    break;
                case 2:
                    Precio = 0.25;
                    break;
                case 3:
                    Precio = 0.25;
                    break;
                case 4:
                    Precio = 0.50;
                    break;
                case 5:
                    Precio = 0.45;
                    break;
                case 6:
                    Precio = 0.25;
                    break;
                case 7:
                    Precio = 0.40;
                    break;
                case 8:
                    Precio = 0.15;
                    break;
                case 9:
                    Precio = 1.25;
                    break;
                case 10:
                    Precio = 1.10;
                    break;
                case 11:
                    Precio = 1.25;
                    break;
                case 12:
                    Precio = 3.55;
                    break;
                case 13:
                    Precio = 3.75;
                    break;
                case 14:
                    Precio = 1.25;
                    break;
                case 15:
                    Precio = 1.65;
                    break;
                case 16:
                    Precio = 0.25;
                    break;
                case 17:
                    Precio = 0.55;
                    break;
                case 18:
                    Precio = 1.00;
                    break;
                case 19:
                    Precio = 0.85;
                    break;
            }
            txtPrecio.Text = Precio.ToString();
        }

        private void SchoolShopVentasWF_Load(object sender, EventArgs e)
        {
            txtPrecio.Enabled = false;

            cbProducto.Items.Add("Seleccione producto");
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var VentasEN = new VentasEN
            {
                Producto = cbProducto.Text,
                Cantidad = txtCantidad.Text,
                Precio = txtPrecio.Text,

            };
            if (VentasEN != null)
            {
                var VentasBL = new VentasBL();
                VentasBL.GuardarVentasEN(VentasEN);
                var ListVentasBL = VentasBL.ObtenerTodosVentasEN();
                dgSchoolShop.DataSource = null;
                dgSchoolShop.DataSource = ListVentasBL;
            }
        }
    }
}
