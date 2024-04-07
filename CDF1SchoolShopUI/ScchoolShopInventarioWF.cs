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
using CDF1SchoolShopDAL;


namespace CDF1SchoolShopUI
{
    public partial class ScchoolShopInventarioWF : Form
    {
        private InventarioDAL inventarioDAL;
        public ScchoolShopInventarioWF()
        {
            InitializeComponent();
            inventarioDAL = new InventarioDAL();//instancia de DAL
        }

        private void ScchoolShopInventarioWF_Load(object sender, EventArgs e)
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

        private void listaInventario_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListaInventario.Columns.Clear();//borra duplicados

            ListaInventario.Columns.Add("Codigo", 200);
            ListaInventario.Columns.Add("Producto", 150);
            ListaInventario.Columns.Add("Marca", 200);
            ListaInventario.Columns.Add("Cantidad", 300);
            ListaInventario.Columns.Add("Precio unitario", 200);
            ListaInventario.Columns.Add("Inversion en inventario", 5, 000);
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCodigo.Text)&&
                !string.IsNullOrWhiteSpace(txtPrecio.Text) &&
                !string.IsNullOrWhiteSpace(txtMarca.Text) &&
                cbProducto.SelectedIndex != -1) 
            {
                int codigo = int.Parse(txtCodigo.Text);
                decimal precio = decimal.Parse(txtPrecio.Text);
                string marca = txtMarca.Text;
                string producto = cbProducto.SelectedItem.ToString();

                InventarioEN productoEncontrado =  InventarioDAL.Buscar(codigo, precio, marca, producto);
            }
        }
    }
}