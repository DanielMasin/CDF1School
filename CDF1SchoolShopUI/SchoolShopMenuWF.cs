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
            this.Close();
        }
    }
}
