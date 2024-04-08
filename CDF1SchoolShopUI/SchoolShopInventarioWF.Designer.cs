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
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            cbProducto = new ComboBox();
            button1 = new Button();
            button2 = new Button();
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
            // textBox1
            // 
            textBox1.Location = new Point(176, 29);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(245, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(167, 156);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(245, 23);
            textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(176, 98);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(245, 23);
            textBox4.TabIndex = 7;
            // 
            // cbProducto
            // 
            cbProducto.FormattingEnabled = true;
            cbProducto.Location = new Point(537, 29);
            cbProducto.Name = "cbProducto";
            cbProducto.Size = new Size(245, 23);
            cbProducto.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(517, 139);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 9;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(643, 139);
            button2.Name = "button2";
            button2.Size = new Size(129, 23);
            button2.TabIndex = 10;
            button2.Text = "Mostrar Inventario";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
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
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(cbProducto);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
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
        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox4;
        private ComboBox cbProducto;
        private Button button1;
        private Button button2;
        private ListView ListaInventario;
    }
}