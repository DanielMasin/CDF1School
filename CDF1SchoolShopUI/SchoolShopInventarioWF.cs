using CDF1SchoolShopDAL;
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
        public SchoolShopInventarioWF()
        {
            InitializeComponent();
            inventarioDAL = new InventarioDAL();//instancia de DAL
        }

        

        private void button2_Click(object sender, EventArgs e)
        {

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

        
    }
}
