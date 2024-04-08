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
    public partial class SchoolShop1MenuWF : Form
    {
        public SchoolShop1MenuWF()
        {
            InitializeComponent();
        }

        private void AgregarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SchoolShopAgregarWF AgregarFormulario = new SchoolShopAgregarWF();
            AgregarFormulario.Show();
            this.Close();
        }

        private void AgregarProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SchoolShopProveedoresWF ProveedorFormulario = new SchoolShopProveedoresWF();
            ProveedorFormulario.Show();
            this.Close();
        }

        private void ComprasAProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SchoolShopComprasWF ComprasFormulario = new SchoolShopComprasWF();
            ComprasFormulario.Show();
            this.Close();
        }

        private void VentasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SchoolShopVentasWF VentasFormulario = new SchoolShopVentasWF();
            VentasFormulario.Show();
            this.Close();
        }
    }
}
