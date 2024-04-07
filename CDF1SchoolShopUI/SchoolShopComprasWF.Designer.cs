namespace CDF1SchoolShopUI
{
    partial class SchoolShopComprasWF
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
            cbProducto = new ComboBox();
            cbCantidad = new ComboBox();
            cbProveedor = new ComboBox();
            cbCosto = new ComboBox();
            dataGridView1 = new DataGridView();
            Producto = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Proveedor = new DataGridViewTextBoxColumn();
            Costo = new DataGridViewTextBoxColumn();
            btnAgregar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 43);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 0;
            label1.Text = "Producto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(82, 95);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 1;
            label2.Text = "Cantidad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(81, 139);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 2;
            label3.Text = "Proveedor";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(81, 191);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 3;
            label4.Text = "Costo";
            // 
            // cbProducto
            // 
            cbProducto.FormattingEnabled = true;
            cbProducto.Items.AddRange(new object[] { "Regla", "Lapicero", "Lapiz", "Borrador grande", "Sacapunta de metal", "Pliego de cartulina", "Resma Papel bond", "Fastener Plastico", "Tijera", "Cuaderno #1", "Cuaderno #3", "Caja de colores 12/U", "Caja de colores 24/U", "Plumon", "Silicon liquido", "Hoja de foami", "Hoja de foami brillante", "Corrector", "Tirro" });
            cbProducto.Location = new Point(144, 35);
            cbProducto.Name = "cbProducto";
            cbProducto.Size = new Size(160, 23);
            cbProducto.TabIndex = 4;
            cbProducto.SelectedIndexChanged += cbProducto_SelectedIndexChanged;
            // 
            // cbCantidad
            // 
            cbCantidad.FormattingEnabled = true;
            cbCantidad.Location = new Point(144, 92);
            cbCantidad.Name = "cbCantidad";
            cbCantidad.Size = new Size(160, 23);
            cbCantidad.TabIndex = 5;
            // 
            // cbProveedor
            // 
            cbProveedor.FormattingEnabled = true;
            cbProveedor.Location = new Point(148, 131);
            cbProveedor.Name = "cbProveedor";
            cbProveedor.Size = new Size(160, 23);
            cbProveedor.TabIndex = 6;
            // 
            // cbCosto
            // 
            cbCosto.FormattingEnabled = true;
            cbCosto.Location = new Point(144, 183);
            cbCosto.Name = "cbCosto";
            cbCosto.Size = new Size(160, 23);
            cbCosto.TabIndex = 7;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Producto, Cantidad, Proveedor, Costo });
            dataGridView1.Location = new Point(82, 269);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(450, 150);
            dataGridView1.TabIndex = 8;
            // 
            // Producto
            // 
            Producto.HeaderText = "producto";
            Producto.Name = "Producto";
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "cantidad";
            Cantidad.Name = "Cantidad";
            // 
            // Proveedor
            // 
            Proveedor.HeaderText = "proveedor";
            Proveedor.Name = "Proveedor";
            // 
            // Costo
            // 
            Costo.HeaderText = "costo";
            Costo.Name = "Costo";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(229, 229);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(147, 23);
            btnAgregar.TabIndex = 9;
            btnAgregar.Text = "Agregar Compras";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // SchoolShopComprasWF
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAgregar);
            Controls.Add(dataGridView1);
            Controls.Add(cbCosto);
            Controls.Add(cbProveedor);
            Controls.Add(cbCantidad);
            Controls.Add(cbProducto);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SchoolShopComprasWF";
            Text = "SchoolShopComprasWF";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cbProducto;
        private ComboBox cbCantidad;
        private ComboBox cbProveedor;
        private ComboBox cbCosto;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Proveedor;
        private DataGridViewTextBoxColumn Costo;
        private Button btnAgregar;
    }
}