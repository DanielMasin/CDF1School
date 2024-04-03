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

namespace CDF1SchoolShopUI
{
    public partial class SchoolShopLoginWF : Form
    {
        public SchoolShopLoginWF()
        {
            InitializeComponent();
        }

        private void btnIniciarSeccion_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtUsuario.Text;
            string contra = txtContra.Text;
            if (LoginBL.VerificarCredenciales(nombreUsuario, contra))
            {
                MessageBox.Show("¡Inicio de sesión exitoso!");
                
                SchoolShopMenuWF MenuFormulario = new SchoolShopMenuWF();
                MenuFormulario.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas. Inténtalo de nuevo.");
            }


        }
    }
}
