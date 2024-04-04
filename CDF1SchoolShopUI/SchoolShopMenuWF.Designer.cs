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
            toolStripMenuItem1 = new ToolStripMenuItem();
            agregarProductosToolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { productosToolStripMenuItem, proveedoresToolStripMenuItem, ajustesToolStripMenuItem, toolStripMenuItem1 });
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
            agregarProveedoresToolStripMenuItem.Size = new Size(68, 22);
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
            cerrarSeccionToolStripMenuItem.Size = new Size(68, 22);
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { agregarProductosToolStripMenuItem1 });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(58, 21);
            toolStripMenuItem1.Text = "Ventas";
            // 
            // agregarProductosToolStripMenuItem1
            // 
            agregarProductosToolStripMenuItem1.Name = "agregarProductosToolStripMenuItem1";
            agregarProductosToolStripMenuItem1.Size = new Size(187, 22);
            agregarProductosToolStripMenuItem1.Text = "Agregar Productos";
            agregarProductosToolStripMenuItem1.Click += agregarProductosToolStripMenuItem1_Click;
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
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem agregarProductosToolStripMenuItem1;
    }
}