namespace CDF1SchoolShopUI
{
    partial class SchoolShopAgregarWF
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
            dgSchoolShop = new DataGridView();
            cbProducto = new ComboBox();
            txtCantidad = new TextBox();
            txtPrecioUnitario = new TextBox();
            btnGuardar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgSchoolShop).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(111, 34);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 0;
            label1.Text = "Producto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(111, 87);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 1;
            label2.Text = "Cantidad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(111, 135);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 2;
            label3.Text = "Precio";
            // 
            // dgSchoolShop
            // 
            dgSchoolShop.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgSchoolShop.Location = new Point(197, 229);
            dgSchoolShop.Name = "dgSchoolShop";
            dgSchoolShop.Size = new Size(466, 139);
            dgSchoolShop.TabIndex = 3;
            dgSchoolShop.CellContentClick += dgSchoolShop_CellContentClick;
            // 
            // cbProducto
            // 
            cbProducto.FormattingEnabled = true;
            cbProducto.Items.AddRange(new object[] { "Regla", "Lapicero", "Lapiz", "Borrador grande", "Sacapunta de metal", "Pliego de cartulina", "Resma Papel bond", "Fastener Plastico", "Tijera", "Cuaderno #1", "Cuaderno #3", "Caja de colores 12/U", "Caja de colores 24/U", "Plumon", "Silicon liquido", "Hoja de foami", "Hoja de foami brillante", "Corrector", "Tirro", "" });
            cbProducto.Location = new Point(244, 34);
            cbProducto.Name = "cbProducto";
            cbProducto.Size = new Size(377, 23);
            cbProducto.TabIndex = 4;
            cbProducto.SelectedIndexChanged += cbProducto_SelectedIndexChanged;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(244, 79);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(377, 23);
            txtCantidad.TabIndex = 5;
            // 
            // txtPrecioUnitario
            // 
            txtPrecioUnitario.Location = new Point(244, 132);
            txtPrecioUnitario.Name = "txtPrecioUnitario";
            txtPrecioUnitario.Size = new Size(377, 23);
            txtPrecioUnitario.TabIndex = 6;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(358, 176);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Registrar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // SchoolShopAgregarWF
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 380);
            Controls.Add(btnGuardar);
            Controls.Add(txtPrecioUnitario);
            Controls.Add(txtCantidad);
            Controls.Add(cbProducto);
            Controls.Add(dgSchoolShop);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SchoolShopAgregarWF";
            Text = "SchoolShopAgregarWF";
            Load += SchoolShopAgregarWF_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgSchoolShop).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView dgSchoolShop;
        private ComboBox cbProducto;
        private TextBox txtCantidad;
        private TextBox txtPrecioUnitario;
        private Button btnGuardar;
    }
}