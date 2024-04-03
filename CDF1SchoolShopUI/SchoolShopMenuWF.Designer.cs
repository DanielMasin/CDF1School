namespace CDF1SchoolShopUI
{
    partial class SchoolShopMenuWF
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
            menuStrip1 = new MenuStrip();
            productosToolStripMenuItem = new ToolStripMenuItem();
            agregarProductosToolStripMenuItem = new ToolStripMenuItem();
            proveedoresToolStripMenuItem = new ToolStripMenuItem();
            agregarProveedoresToolStripMenuItem = new ToolStripMenuItem();
            ajustesToolStripMenuItem = new ToolStripMenuItem();
            cerrarSeccionToolStripMenuItem = new ToolStripMenuItem();
            ventasToolStripMenuItem = new ToolStripMenuItem();
            agregarVentaToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { productosToolStripMenuItem, proveedoresToolStripMenuItem, ajustesToolStripMenuItem, ventasToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 25);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // productosToolStripMenuItem
            // 
            productosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agregarProductosToolStripMenuItem });
            productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            productosToolStripMenuItem.Size = new Size(79, 21);
            productosToolStripMenuItem.Text = "Productos";
            // 
            // agregarProductosToolStripMenuItem
            // 
            agregarProductosToolStripMenuItem.Name = "agregarProductosToolStripMenuItem";
            agregarProductosToolStripMenuItem.Size = new Size(187, 22);
            agregarProductosToolStripMenuItem.Text = "Agregar Productos";
            agregarProductosToolStripMenuItem.Click += agregarProductosToolStripMenuItem_Click;
            // 
            // proveedoresToolStripMenuItem
            // 
            proveedoresToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agregarProveedoresToolStripMenuItem });
            proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            proveedoresToolStripMenuItem.Size = new Size(94, 21);
            proveedoresToolStripMenuItem.Text = "Proveedores";
            // 
            // agregarProveedoresToolStripMenuItem
            // 
            agregarProveedoresToolStripMenuItem.Name = "agregarProveedoresToolStripMenuItem";
            agregarProveedoresToolStripMenuItem.Size = new Size(202, 22);
            agregarProveedoresToolStripMenuItem.Text = "Agregar Proveedores";
            // 
            // ajustesToolStripMenuItem
            // 
            ajustesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cerrarSeccionToolStripMenuItem });
            ajustesToolStripMenuItem.Name = "ajustesToolStripMenuItem";
            ajustesToolStripMenuItem.Size = new Size(61, 21);
            ajustesToolStripMenuItem.Text = "Ajustes";
            // 
            // cerrarSeccionToolStripMenuItem
            // 
            cerrarSeccionToolStripMenuItem.Name = "cerrarSeccionToolStripMenuItem";
            cerrarSeccionToolStripMenuItem.Size = new Size(161, 22);
            cerrarSeccionToolStripMenuItem.Text = "Cerrar Seccion";
            // 
            // ventasToolStripMenuItem
            // 
            ventasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agregarVentaToolStripMenuItem });
            ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            ventasToolStripMenuItem.Size = new Size(58, 21);
            ventasToolStripMenuItem.Text = "Ventas";
            // 
            // agregarVentaToolStripMenuItem
            // 
            agregarVentaToolStripMenuItem.Name = "agregarVentaToolStripMenuItem";
            agregarVentaToolStripMenuItem.Size = new Size(180, 22);
            agregarVentaToolStripMenuItem.Text = "Agregar Venta";
            agregarVentaToolStripMenuItem.Click += agregarVentaToolStripMenuItem_Click;
            // 
            // SchoolShopMenuWF
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 510);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "SchoolShopMenuWF";
            Text = "SchoolShopMenuWF";
            Load += SchoolShopMenuWF_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem productosToolStripMenuItem;
        private ToolStripMenuItem agregarProductosToolStripMenuItem;
        private ToolStripMenuItem proveedoresToolStripMenuItem;
        private ToolStripMenuItem agregarProveedoresToolStripMenuItem;
        private ToolStripMenuItem ajustesToolStripMenuItem;
        private ToolStripMenuItem cerrarSeccionToolStripMenuItem;
        private ToolStripMenuItem ventasToolStripMenuItem;
        private ToolStripMenuItem agregarVentaToolStripMenuItem;
    }
}