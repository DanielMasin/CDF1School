namespace CDF1SchoolShopUI
{
    partial class SchoolShopProveedoresWF
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
            lblNombre = new Label();
            lblTelefono = new Label();
            txtNombre = new TextBox();
            dgMostrarProveedor = new DataGridView();
            btnAgregarProveedor = new Button();
            mtxtNumero = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)dgMostrarProveedor).BeginInit();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(99, 61);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(110, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Ingrese su Nombre:";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(99, 115);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(111, 15);
            lblTelefono.TabIndex = 1;
            lblTelefono.Text = "Ingrese su Telefono:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(267, 53);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(341, 23);
            txtNombre.TabIndex = 2;
            // 
            // dgMostrarProveedor
            // 
            dgMostrarProveedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgMostrarProveedor.Location = new Point(135, 259);
            dgMostrarProveedor.Name = "dgMostrarProveedor";
            dgMostrarProveedor.Size = new Size(506, 150);
            dgMostrarProveedor.TabIndex = 3;
            // 
            // btnAgregarProveedor
            // 
            btnAgregarProveedor.Location = new Point(356, 214);
            btnAgregarProveedor.Name = "btnAgregarProveedor";
            btnAgregarProveedor.Size = new Size(75, 23);
            btnAgregarProveedor.TabIndex = 4;
            btnAgregarProveedor.Text = "Agregar";
            btnAgregarProveedor.UseVisualStyleBackColor = true;
            btnAgregarProveedor.Click += btnAgregarProveedor_Click;
            // 
            // mtxtNumero
            // 
            mtxtNumero.Location = new Point(267, 107);
            mtxtNumero.Name = "mtxtNumero";
            mtxtNumero.Size = new Size(341, 23);
            mtxtNumero.TabIndex = 8;
            // 
            // SchoolShopProveedoresWF
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(mtxtNumero);
            Controls.Add(btnAgregarProveedor);
            Controls.Add(dgMostrarProveedor);
            Controls.Add(txtNombre);
            Controls.Add(lblTelefono);
            Controls.Add(lblNombre);
            Name = "SchoolShopProveedoresWF";
            Text = "SchoolShopProveedoresWF";
            ((System.ComponentModel.ISupportInitialize)dgMostrarProveedor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblTelefono;
        private TextBox txtNombre;
        private DataGridView dgMostrarProveedor;
        private Button btnAgregarProveedor;
        private MaskedTextBox mtxtNumero;
    }
}