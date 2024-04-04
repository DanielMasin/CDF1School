namespace CDF1SchoolShopUI
{
    partial class SchoolShopVentasWF
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
            cbProducto = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            txtCantidad = new TextBox();
            txtPrecio = new TextBox();
            btnAgregar = new Button();
            dgSchoolShop = new DataGridView();
            btnAtras = new Button();
            ((System.ComponentModel.ISupportInitialize)dgSchoolShop).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 34);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 0;
            label1.Text = "Elija Producto";
            // 
            // cbProducto
            // 
            cbProducto.FormattingEnabled = true;
            cbProducto.Location = new Point(142, 26);
            cbProducto.Name = "cbProducto";
            cbProducto.Size = new Size(243, 23);
            cbProducto.TabIndex = 1;
            cbProducto.SelectedIndexChanged += cbProducto_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.SizeAll;
            label2.Location = new Point(29, 75);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 2;
            label2.Text = "Cantidad ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 125);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 3;
            label3.Text = "Precio";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(171, 72);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(214, 23);
            txtCantidad.TabIndex = 4;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(142, 118);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(243, 23);
            txtPrecio.TabIndex = 5;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.IndianRed;
            btnAgregar.Location = new Point(389, 166);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 26);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dgSchoolShop
            // 
            dgSchoolShop.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgSchoolShop.Location = new Point(54, 217);
            dgSchoolShop.Name = "dgSchoolShop";
            dgSchoolShop.Size = new Size(288, 132);
            dgSchoolShop.TabIndex = 7;
            // 
            // btnAtras
            // 
            btnAtras.Location = new Point(419, 351);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(75, 23);
            btnAtras.TabIndex = 8;
            btnAtras.Text = "Atras";
            btnAtras.UseVisualStyleBackColor = true;
            btnAtras.Click += btnAtras_Click;
            // 
            // SchoolShopVentasWF
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(506, 397);
            Controls.Add(btnAtras);
            Controls.Add(dgSchoolShop);
            Controls.Add(btnAgregar);
            Controls.Add(txtPrecio);
            Controls.Add(txtCantidad);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cbProducto);
            Controls.Add(label1);
            Name = "SchoolShopVentasWF";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SchoolShopVentasWF";
            Load += SchoolShopVentasWF_Load;
            ((System.ComponentModel.ISupportInitialize)dgSchoolShop).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbProducto;
        private Label label2;
        private Label label3;
        private TextBox txtCantidad;
        private TextBox txtPrecio;
        private Button btnAgregar;
        private DataGridView dgSchoolShop;
        private Button btnAtras;
    }
}