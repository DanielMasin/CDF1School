using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CDF1SchoolShopBL;
using CDF1SchoolShopEN;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CDF1SchoolShopUI
{
    public partial class SchoolShopComprasWF : Form
    {
        public event EventHandler ComprasRealizada;
        public SchoolShopComprasWF(SchoolShopProveedoresWF _ProveedoresForm)
        {
            InitializeComponent();
            cbProducto.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void cbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cbProducto.SelectedItem != null)
            {
                string Producto = cbProducto.SelectedItem.ToString();
                int Cantidad = Convert.ToInt32(txtCantidad.Text);
                string Proveedor = cbProveedor.Text;
                string Costo = cbCosto.Text;

                // Ahora usamos la capa de negocio para agregar la compra
                //CompraBL.AgregarCompra(Producto, Cantidad, Proveedor, Costo);

                // Asumiendo que quieras seguir mostrando en la interfaz:
                dataGridView1.Rows.Add(Producto, Cantidad, Proveedor, "$" + Costo);
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un valor en todos los campos.");
            }
            ComprasRealizada?.Invoke(this, EventArgs.Empty);
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            SchoolShopMenuWF MenuFormulario = new SchoolShopMenuWF();
            MenuFormulario.Show();
            this.Close();
        }
    }
}
