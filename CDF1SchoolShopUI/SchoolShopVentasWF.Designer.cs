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
            txtVentaTotal = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgSchoolShop).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 39);
            label1.Name = "label1";
            label1.Size = new Size(88, 17);
            label1.TabIndex = 0;
            label1.Text = "Elija Producto";
            // 
            // cbProducto
            // 
            cbProducto.FormattingEnabled = true;
            cbProducto.Location = new Point(142, 29);
            cbProducto.Name = "cbProducto";
            cbProducto.Size = new Size(243, 25);
            cbProducto.TabIndex = 1;
            cbProducto.SelectedIndexChanged += cbProducto_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.SizeAll;
            label2.Location = new Point(29, 85);
            label2.Name = "label2";
            label2.Size = new Size(64, 17);
            label2.TabIndex = 2;
            label2.Text = "Cantidad ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 142);
            label3.Name = "label3";
            label3.Size = new Size(44, 17);
            label3.TabIndex = 3;
            label3.Text = "Precio";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(171, 82);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(214, 25);
            txtCantidad.TabIndex = 4;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(142, 134);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(243, 25);
            txtPrecio.TabIndex = 5;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(394, 176);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 29);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dgSchoolShop
            // 
            dgSchoolShop.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgSchoolShop.Location = new Point(54, 246);
            dgSchoolShop.Name = "dgSchoolShop";
            dgSchoolShop.Size = new Size(288, 150);
            dgSchoolShop.TabIndex = 7;
            // 
            // txtVentaTotal
            // 
            txtVentaTotal.Location = new Point(39, 192);
            txtVentaTotal.Name = "txtVentaTotal";
            txtVentaTotal.Size = new Size(260, 25);
            txtVentaTotal.TabIndex = 8;
            // 
            // SchoolShopVentasWF
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(521, 393);
            Controls.Add(txtVentaTotal);
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
        private TextBox txtVentaTotal;
    }
}