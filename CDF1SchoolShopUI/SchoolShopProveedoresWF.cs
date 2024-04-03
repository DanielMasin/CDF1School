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
    public partial class SchoolShopProveedoresWF : Form
    {
        public SchoolShopProveedoresWF()
        {
            InitializeComponent();
            mtxtNumero.Mask = "0000-0000";
        }

        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            var ProveedoresEN = new ProveedoresEN
            {
                Proveedor = txtNombre.Text,
                Numero = mtxtNumero.Text,

            };
            if (ProveedoresEN != null)
            {
                var ProveedoresBL = new ProveedoresBL();
                ProveedoresBL.GuardarProveedoresEN(ProveedoresEN);
                var ListProveedoresBL = ProveedoresBL.ObtenerTodosProveedoresEN();
                dgMostrarProveedor.DataSource = null;
                dgMostrarProveedor.DataSource = ListProveedoresBL;
            }
        }
    }
}
