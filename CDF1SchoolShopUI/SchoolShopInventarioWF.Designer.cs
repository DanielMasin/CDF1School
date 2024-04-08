namespace CDF1SchoolShopUI
{
    partial class SchoolShopInventarioWF
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtCodigo = new TextBox();
            txtMarca = new TextBox();
            cbProducto = new ComboBox();
            btnBuscar = new Button();
            btnMostrarInventario = new Button();
            ListaInventario = new ListView();
            btnAgregarCompra = new Button();
            btnAgregarVenta = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(108, 37);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "Codigo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(108, 79);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 2;
            label3.Text = "Marca";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(450, 37);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 3;
            label4.Text = "Producto";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(176, 29);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(245, 23);
            txtCodigo.TabIndex = 4;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(176, 76);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(245, 23);
            txtMarca.TabIndex = 6;
            // 
            // cbProducto
            // 
            cbProducto.FormattingEnabled = true;
            cbProducto.Location = new Point(512, 29);
            cbProducto.Name = "cbProducto";
            cbProducto.Size = new Size(245, 23);
            cbProducto.TabIndex = 8;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(584, 161);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 9;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnMostrarInventario
            // 
            btnMostrarInventario.Location = new Point(402, 161);
            btnMostrarInventario.Name = "btnMostrarInventario";
            btnMostrarInventario.Size = new Size(129, 23);
            btnMostrarInventario.TabIndex = 10;
            btnMostrarInventario.Text = "Mostrar Inventario";
            btnMostrarInventario.UseVisualStyleBackColor = true;
            btnMostrarInventario.Click += btnMostrarInventario_Click;
            // 
            // ListaInventario
            // 
            ListaInventario.Location = new Point(62, 206);
            ListaInventario.Name = "ListaInventario";
            ListaInventario.Size = new Size(710, 201);
            ListaInventario.TabIndex = 11;
            ListaInventario.UseCompatibleStateImageBehavior = false;
            ListaInventario.SelectedIndexChanged += ListaInventario_SelectedIndexChanged;
            // 
            // btnAgregarCompra
            // 
            btnAgregarCompra.Location = new Point(62, 161);
            btnAgregarCompra.Name = "btnAgregarCompra";
            btnAgregarCompra.Size = new Size(129, 23);
            btnAgregarCompra.TabIndex = 12;
            btnAgregarCompra.Text = "Actualizar Comprar";
            btnAgregarCompra.UseVisualStyleBackColor = true;
            // 
            // btnAgregarVenta
            // 
            btnAgregarVenta.Location = new Point(230, 161);
            btnAgregarVenta.Name = "btnAgregarVenta";
            btnAgregarVenta.Size = new Size(110, 23);
            btnAgregarVenta.TabIndex = 13;
            btnAgregarVenta.Text = "Actualizar Venta";
            btnAgregarVenta.UseVisualStyleBackColor = true;
            btnAgregarVenta.Click += btnAgregarCompra_Click;
            // 
            // SchoolShopInventarioWF
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAgregarVenta);
            Controls.Add(btnAgregarCompra);
            Controls.Add(ListaInventario);
            Controls.Add(btnMostrarInventario);
            Controls.Add(btnBuscar);
            Controls.Add(cbProducto);
            Controls.Add(txtMarca);
            Controls.Add(txtCodigo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "SchoolShopInventarioWF";
            Text = "SchoolShopInventarioWF";
            Load += SchoolShopInventarioWF_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label4;
        private TextBox txtCodigo;
        private TextBox txtMarca;
        private ComboBox cbProducto;
        private Button btnBuscar;
        private Button btnMostrarInventario;
        private ListView ListaInventario;
        private Button btnAgregarCompra;
        private Button btnAgregarVenta;
    }
}