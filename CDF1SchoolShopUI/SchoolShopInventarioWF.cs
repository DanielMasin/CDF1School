using CDF1SchoolShopBL;
using CDF1SchoolShopDAL;
using CDF1SchoolShopEN;
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
    public partial class SchoolShopInventarioWF : Form
    {
        private InventarioDAL inventarioDAL;
        private SchoolShopComprasWF SchoolShopComprasWF;//LLamo los dos eventos
        private SchoolShopVentasWF SchoolShopVentasWF;

        public SchoolShopInventarioWF()
        {
            InitializeComponent();
            inventarioDAL = new InventarioDAL();
        }


        private void ListaInventario_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListaInventario.Columns.Clear();//borra duplicados

            ListaInventario.Columns.Add("Codigo", 200);
            ListaInventario.Columns.Add("Producto", 150);
            ListaInventario.Columns.Add("Marca", 200);
            ListaInventario.Columns.Add("Cantidad", 300);
            ListaInventario.Columns.Add("Precio unitario", 200);
            ListaInventario.Columns.Add("Inversion en inventario", 5, 000);
        }

        private void SchoolShopInventarioWF_Load(object sender, EventArgs e)
        {
            cbProducto.Items.Add("Reglas");
            cbProducto.Items.Add("Lapiceros");
            cbProducto.Items.Add("Lapiz");
            cbProducto.Items.Add("Borradores Grandes");
            cbProducto.Items.Add("Sacapunta de metal");
            cbProducto.Items.Add("Pliegos de cartulina");
            cbProducto.Items.Add("Resma Papel bond");
            cbProducto.Items.Add("Fastener Plastico");
            cbProducto.Items.Add("Tijeras");
            cbProducto.Items.Add("Cuaderno#1 Espiral");
            cbProducto.Items.Add("Cuaderno #3");
            cbProducto.Items.Add("Caja de colores 12U");
            cbProducto.Items.Add("Caja de colores 24U");
            cbProducto.Items.Add("Plumones");
            cbProducto.Items.Add("Silicon Liquido");
            cbProducto.Items.Add("Hojas de foami");
            cbProducto.Items.Add("Hojas de foami brillantes");
            cbProducto.Items.Add("Corrector");
            cbProducto.Items.Add("Tirro");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCodigo.Text) &&
                !string.IsNullOrWhiteSpace(txtMarca.Text) &&
                cbProducto.SelectedIndex != -1)
            {
                int codigo = int.Parse(txtCodigo.Text);
                string marca = txtMarca.Text;
                string producto = cbProducto.SelectedItem.ToString();

            }
        }

        private void btnMostrarInventario_Click(object sender, EventArgs e)
        {
            List<InventarioEN> inventario = inventarioDAL.ObtenerTodosInventarioEN();//Obtener datos de dal

            ListaInventario.Items.Clear();

            foreach (InventarioEN producto in inventario)
            {
                ListViewItem item = new ListViewItem(producto.Codigo.ToString());
                item.SubItems.Add(producto.Producto.ToString());
                item.SubItems.Add(producto.Marca.ToString());
                item.SubItems.Add(producto.Preciounitario.ToString());
                item.SubItems.Add(producto.Inversioneninventario.ToString());

                ListaInventario.Items.Add(item);
            }

        }

        



        private void btnAtras_Click(object sender, EventArgs e)
        {
            SchoolShop1MenuWF MenuFormulario = new SchoolShop1MenuWF();
            MenuFormulario.Show();
            this.Close();
        }

        private void btnAgregarCompra_Click_1(object sender, EventArgs e)
        {
            int Codigo = int.Parse(txtCodigo.Text);
            int Cantidad = int.Parse(txtCantidad.Text);

            ComprasBL.AgregarCompra(Cantidad);

            // Actualizar el ListView
            btnMostrarInventario_Click(sender, e); // Llamar al método para mostrar el inventario
        }

        private void btnAgregarVenta_Click_1(object sender, EventArgs e)
        {
            int Codigo = int.Parse(txtCodigo.Text);
            int Cantidad = int.Parse(txtCantidad.Text);

            // Agrega la venta al inventario 
            VentasBL.AgregarVentas(Cantidad);

            // Actualizar el ListView (si es necesario)
            btnMostrarInventario_Click(sender, e); //
        }
        public SchoolShopInventarioWF(SchoolShopComprasWF ComprasForm, SchoolShopVentasWF VentasForm)
        {
            this.SchoolShopComprasWF = ComprasForm;
            this.SchoolShopVentasWF = VentasForm;

            ComprasForm.ComprasRealizada += ComprasForm_CompraRealizada;
            VentasForm.Ventascompleta += VentasForm_VentaCompleta;
        }
    }
}
