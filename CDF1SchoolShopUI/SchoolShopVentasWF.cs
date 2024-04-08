using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CDF1SchoolShopEN;// Importa el espacio de nombres para las clases de entidades
using CDF1SchoolShopBL; // Importa el espacio de nombres para la lógica de negocio.

namespace CDF1SchoolShopUI // Define el espacio de nombres del formulario.
{
    public partial class SchoolShopVentasWF : Form// Declaración de la clase SchoolShopVentasWF que hereda de Form.
    {
        int indice = 0;// Variable para almacenar el índice seleccionado en el ComboBox.
        double Precio = 0;// Variable para almacenar el precio del producto seleccionado.
        double ventatotal = 0;// Variable para almacenar el total de la venta.
        public SchoolShopVentasWF()// Constructor de la clase SchoolShopVentasWF.
        {
            InitializeComponent();// Inicializa los componentes del formulario.
        }


        private void cbProducto_SelectedIndexChanged(object sender, EventArgs e)// Manejador de evento para el cambio de selección en el ComboBox de productos.
        {
            indice = cbProducto.SelectedIndex;// Obtiene el índice seleccionado en el ComboBox.
            switch (indice)// Asigna el precio del producto seleccionado según el índice
            {
                case 1:
                    Precio = 0.25;
                    break;
                case 2:
                    Precio = 0.25;
                    break;
                case 3:
                    Precio = 0.25;
                    break;
                case 4:
                    Precio = 0.50;
                    break;
                case 5:
                    Precio = 0.45;
                    break;
                case 6:
                    Precio = 0.25;
                    break;
                case 7:
                    Precio = 0.40;
                    break;
                case 8:
                    Precio = 0.15;
                    break;
                case 9:
                    Precio = 1.25;
                    break;
                case 10:
                    Precio = 1.10;
                    break;
                case 11:
                    Precio = 1.25;
                    break;
                case 12:
                    Precio = 3.55;
                    break;
                case 13:
                    Precio = 3.75;
                    break;
                case 14:
                    Precio = 1.25;
                    break;
                case 15:
                    Precio = 1.65;
                    break;
                case 16:
                    Precio = 0.25;
                    break;
                case 17:
                    Precio = 0.55;
                    break;
                case 18:
                    Precio = 1.00;
                    break;
                case 19:
                    Precio = 0.85;
                    break;
            }
            txtPrecio.Text = Precio.ToString();// Muestra el precio en el TextBox de precio.
        
    }

        private void SchoolShopVentasWF_Load(object sender, EventArgs e)// Manejador de evento Load del formulario.
        {
            txtPrecio.Enabled = false;// Deshabilita la edición del TextBox de precio.
            // Llena el ComboBox de productos con opciones.
            cbProducto.Items.Add("Seleccione producto");
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
            cbProducto.SelectedIndex = 0;// Establece la selección inicial en "Seleccione producto".
        }

        private void btnAgregar_Click(object sender, EventArgs e)// Manejador de evento para el botón Agregar.
        {
            var VentasEN = new VentasEN// Crea una nueva instancia de la clase VentasEN con los datos del formulario.
            {
                Producto = cbProducto.Text,// Obtiene el producto seleccionado en el ComboBox.
                Cantidad = txtCantidad.Text,// Obtiene la cantidad ingresada en el TextBox de cantidad.
                Precio = Precio.ToString(),// Convierte el precio a cadena y lo asigna.

            };

            if (VentasEN != null)// Verifica que la instancia de VentasEN no sea nula.
            {
                var VentasBL = new VentasBL();// Crea una instancia de la clase de lógica de negocio para ventas.
                VentasBL.GuardarVentasEN(VentasEN);// Guarda la venta en la base de datos.
                var ListVentasBL = VentasBL.ObtenerTodosVentasEN();// Obtiene todas las ventas de la base de datos.
                dgSchoolShop.DataSource = null;// Limpia los datos en el DataGridView.
                dgSchoolShop.DataSource = ListVentasBL;// Asigna la lista de ventas como origen de datos del DataGridView.

                //calcular y mostrar el total de precio por cantidad 
                Total();
            }

        }
        private void Total()// Método para calcular el total de precio por cantidad y mostrarlo en el DataGridView.
        {
            foreach (DataGridViewRow row in dgSchoolShop.Rows) // Itera sobre todas las filas del DataGridView.
            {
                //obtener el precio de la fila actual 
                double Precio = Convert.ToDouble(row.Cells["Precio"].Value);// Obtiene el precio de la fila actual.
                int Cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);// Obtiene la cantidad de la fila actual.

                //Calcular el total de precio por cantidad
                double Total = Precio * Cantidad;
                //Mostrar el total de precio por cantidad en la nueva columna
                row.Cells["Total"].Value = Total.ToString("N3");
            }
        }

        private void btnVentaCompleta_Click(object sender, EventArgs e)
        {
            VentaTotal();// Llama al método VentaTotal cuando se hace clic en el botón de Venta Completa.
        }
        private void VentaTotal()
        {
            double Total = 0.0; // Inicializa la variable Total para almacenar el total de la venta.

            foreach (DataGridViewRow row in dgSchoolShop.Rows)
            {// Itera sobre todas las filas del DataGridView.
                double Precio = Convert.ToDouble(row.Cells["Precio"].Value);
                double Cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);

                Total += Precio * Cantidad; // Calcula el total de la venta sumando el precio por la cantidad de cada producto.
            }// Muestra un mensaje de venta completada con el total de la compra formateado como moneda.
            MessageBox.Show("¡Venta Completada!\n\nSu total de compra es " + Total.ToString("c"), "Venta Completada");
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cbProducto.SelectedIndex = 0;// Establece la selección del ComboBox de productos en la primera opción.
            txtCantidad.Text = "";// Limpia el contenido del TextBox de cantidad.
            txtPrecio.Text = "";// Limpia el contenido del TextBox de precio.
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            SchoolShop1MenuWF MenuFormulario = new SchoolShop1MenuWF(); // Crea una nueva instancia del formulario de menú principal
            MenuFormulario.Show();// Muestra el formulario de menú principal
            this.Close();// Cierra el formulario actual.
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if  (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar))
            {
                //Si la tecla presionada no es un numero y no es una tecla de control (Como retroceso o suprimir), se cancela la accion.
                // Si es así, cancela la acción de escribir en el TextBox de cantidad.
                e.Handled = true;
            }
        }
    }
}

