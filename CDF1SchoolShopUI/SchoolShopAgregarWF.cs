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
    public partial class SchoolShopAgregarWF : Form
    {
        int indice = 0;
        double PrecioUnitario = 0;
        public SchoolShopAgregarWF()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var AgregarProductoEN = new AgregarProductoEN
            {
                Producto = cbProducto.Text,
                Cantidad = txtCantidad.Text,
                PrecioUnitario = PrecioUnitario,
            };
            if (AgregarProductoEN != null)
            {
                var AgregarProductoBL = new AgregarProductoBL();
                AgregarProductoBL.GuardarAgregarProductoEN(AgregarProductoEN);
                var ListAgregarProductoBL = AgregarProductoBL.ObtenerTodoAgregarProductoEN();
                dgSchoolShop.DataSource = null;
                dgSchoolShop.DataSource = ListAgregarProductoBL;
            }
        }

        private void cbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            indice = cbProducto.SelectedIndex;
            switch (indice)
            {
                case 1:
                    PrecioUnitario = 0.25;
                    break;
                case 2:
                    PrecioUnitario = 0.25;
                    break;
                case 3:
                    PrecioUnitario = 0.25;
                    break;
                case 4:
                    PrecioUnitario = 0.50;
                    break;
                case 5:
                    PrecioUnitario = 0.45;
                    break;
                case 6:
                    PrecioUnitario = 0.25;
                    break;
                case 7:
                    PrecioUnitario = 0.40;
                    break;
                case 8:
                    PrecioUnitario = 0.15;
                    break;
                case 9:
                    PrecioUnitario = 1.25;
                    break;
                case 10:
                    PrecioUnitario = 1.10;
                    break;
                case 11:
                    PrecioUnitario = 1.25;
                    break;
                case 12:
                    PrecioUnitario = 3.55;
                    break;
                case 13:
                    PrecioUnitario = 3.75;
                    break;
                case 14:
                    PrecioUnitario = 1.25;
                    break;
                case 15:
                    PrecioUnitario = 1.65;
                    break;
                case 16:
                    PrecioUnitario = 0.25;
                    break;
                case 17:
                    PrecioUnitario = 0.55;
                    break;
                case 18:
                    PrecioUnitario = 1.00;
                    break;
                case 19:
                    PrecioUnitario = 0.85;
                    break;

            }
            txtPrecioUnitario.Text = PrecioUnitario.ToString();
        }
        private void SchoolShopAgregarWF_Load(object sender, EventArgs e)
        {
            txtPrecioUnitario.Enabled = false;


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

        private void dgSchoolShop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SchoolShopAgregarWF_Load_1(object sender, EventArgs e)
        {

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            SchoolShop1MenuWF MenuFormulario = new SchoolShop1MenuWF();
            MenuFormulario.Show();
            this.Close();
        }
    }
}

