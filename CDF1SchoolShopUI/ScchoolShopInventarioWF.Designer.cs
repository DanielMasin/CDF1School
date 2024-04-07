namespace CDF1SchoolShopUI
{
    partial class ScchoolShopInventarioWF
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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            button1 = new Button();
            txtCodigo = new TextBox();
            txtPrecio = new TextBox();
            txtMarca = new TextBox();
            cbProducto = new ComboBox();
            btnBuscar = new Button();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ListaInventario = new ListView();
            btnMostrarInventario = new Button();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // button1
            // 
            button1.Location = new Point(579, 386);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = true;
            // 
            // txtCodigo
            // 
            txtCodigo.AcceptsReturn = true;
            txtCodigo.Location = new Point(132, 22);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(195, 23);
            txtCodigo.TabIndex = 7;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(132, 66);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(195, 23);
            txtPrecio.TabIndex = 9;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(132, 115);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(195, 23);
            txtMarca.TabIndex = 10;
            // 
            // cbProducto
            // 
            cbProducto.FormattingEnabled = true;
            cbProducto.Location = new Point(432, 22);
            cbProducto.Name = "cbProducto";
            cbProducto.Size = new Size(222, 23);
            cbProducto.TabIndex = 11;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(432, 119);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 12;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 27);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 13;
            label1.Text = "Codigo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 74);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 15;
            label3.Text = "Precio unitario";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 123);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 16;
            label4.Text = "Marca";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(360, 30);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 17;
            label5.Text = "Producto";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ButtonFace;
            label6.Font = new Font("Modern No. 20", 11.249999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(-76, 101);
            label6.Name = "label6";
            label6.Size = new Size(82, 17);
            label6.TabIndex = 18;
            label6.Text = "Inventario";
            // 
            // ListaInventario
            // 
            ListaInventario.BackColor = SystemColors.InactiveBorder;
            ListaInventario.Location = new Point(23, 166);
            ListaInventario.Name = "ListaInventario";
            ListaInventario.Size = new Size(631, 205);
            ListaInventario.TabIndex = 19;
            ListaInventario.UseCompatibleStateImageBehavior = false;
            ListaInventario.SelectedIndexChanged += listaInventario_SelectedIndexChanged;
            // 
            // btnMostrarInventario
            // 
            btnMostrarInventario.Location = new Point(524, 119);
            btnMostrarInventario.Name = "btnMostrarInventario";
            btnMostrarInventario.Size = new Size(130, 23);
            btnMostrarInventario.TabIndex = 20;
            btnMostrarInventario.Text = "Mostrar Inventario";
            btnMostrarInventario.UseVisualStyleBackColor = true;
            btnMostrarInventario.Click += btnMostrarInventario_Click;
            // 
            // ScchoolShopInventarioWF
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(675, 421);
            Controls.Add(btnMostrarInventario);
            Controls.Add(ListaInventario);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(btnBuscar);
            Controls.Add(cbProducto);
            Controls.Add(txtMarca);
            Controls.Add(txtPrecio);
            Controls.Add(txtCodigo);
            Controls.Add(button1);
            Name = "ScchoolShopInventarioWF";
            Text = "SchoolShopInventarioWF";
            Load += ScchoolShopInventarioWF_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ContextMenuStrip contextMenuStrip1;
        private Button button1;
        private TextBox txtCodigo;
        private TextBox txtPrecio;
        private TextBox txtMarca;
        private ComboBox cbProducto;
        private Button btnBuscar;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ListView ListaInventario;
        private Button btnMostrarInventario;
    }
}