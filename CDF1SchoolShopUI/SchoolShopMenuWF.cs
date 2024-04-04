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
    public partial class SchoolShopMenuWF : Form
    {
        public SchoolShopMenuWF()
        {
            InitializeComponent();
        }

        private void agregarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SchoolShopAgregarWF AgregarFormulario = new SchoolShopAgregarWF();
            AgregarFormulario.Show();
            this.Close();
        }

        private void ajusteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void agregarProveedoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SchoolShopProveedoresWF ProveedoresFormulario = new SchoolShopProveedoresWF();
            ProveedoresFormulario.Show();
            this.Close();
        }

        private void productosToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            SchoolShopInventarioWF InventarioFormulario = new SchoolShopInventarioWF();
            InventarioFormulario.Show();
            this.Close();
        }

        private void comprasHechasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SchoolShopComprasWF ComprasFormulario = new SchoolShopComprasWF();
            ComprasFormulario.Show();
            this.Close();
        }

        private void agregarProductosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SchoolShopAgregarWF AgregarFormulario = new SchoolShopAgregarWF();
            AgregarFormulario.Show();
            this.Close();
        }

        private void ventasTotalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SchoolShopVentasWF VentasFormulario = new SchoolShopVentasWF();
            VentasFormulario.Show();
            this.Close();
        }
    }
}

