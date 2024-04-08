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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtCodigo = new TextBox();
            txtMarca = new TextBox();
            txtPrecio = new TextBox();
            cbProducto = new ComboBox();
            btnBuscar = new Button();
            btnMostrarInventario = new Button();
            ListaInventario = new ListView();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 37);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "Codigo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 98);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 1;
            label2.Text = "Precio Unitario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 156);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 2;
            label3.Text = "Marca";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(475, 37);
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
            txtMarca.Location = new Point(167, 156);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(245, 23);
            txtMarca.TabIndex = 6;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(176, 98);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(245, 23);
            txtPrecio.TabIndex = 7;
            // 
            // cbProducto
            // 
            cbProducto.FormattingEnabled = true;
            cbProducto.Location = new Point(537, 29);
            cbProducto.Name = "cbProducto";
            cbProducto.Size = new Size(245, 23);
            cbProducto.TabIndex = 8;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(517, 139);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 9;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnMostrarInventario
            // 
            btnMostrarInventario.Location = new Point(643, 139);
            btnMostrarInventario.Name = "btnMostrarInventario";
            btnMostrarInventario.Size = new Size(129, 23);
            btnMostrarInventario.TabIndex = 10;
            btnMostrarInventario.Text = "Mostrar Inventario";
            btnMostrarInventario.UseVisualStyleBackColor = true;
            
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
            // SchoolShopInventarioWF
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ListaInventario);
            Controls.Add(btnMostrarInventario);
            Controls.Add(btnBuscar);
            Controls.Add(cbProducto);
            Controls.Add(txtPrecio);
            Controls.Add(txtMarca);
            Controls.Add(txtCodigo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SchoolShopInventarioWF";
            Text = "SchoolShopInventarioWF";
            Load += SchoolShopInventarioWF_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtCodigo;
        private TextBox txtMarca;
        private TextBox txtPrecio;
        private ComboBox cbProducto;
        private Button btnBuscar;
        private Button btnMostrarInventario;
        private ListView ListaInventario;
    }
}