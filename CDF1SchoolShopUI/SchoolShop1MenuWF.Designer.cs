namespace CDF1SchoolShopUI
{
    partial class SchoolShop1MenuWF
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
            comprasAProveedoresToolStripMenuItem = new ToolStripMenuItem();
            ventasToolStripMenuItem = new ToolStripMenuItem();
            ventasToolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { productosToolStripMenuItem, proveedoresToolStripMenuItem, ventasToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // productosToolStripMenuItem
            // 
            productosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agregarProductosToolStripMenuItem });
            productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            productosToolStripMenuItem.Size = new Size(73, 20);
            productosToolStripMenuItem.Text = "Productos";
            // 
            // agregarProductosToolStripMenuItem
            // 
            agregarProductosToolStripMenuItem.Name = "agregarProductosToolStripMenuItem";
            agregarProductosToolStripMenuItem.Size = new Size(173, 22);
            agregarProductosToolStripMenuItem.Text = "Agregar Productos";
            agregarProductosToolStripMenuItem.Click += AgregarProductosToolStripMenuItem_Click;
            // 
            // proveedoresToolStripMenuItem
            // 
            proveedoresToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agregarProveedoresToolStripMenuItem, comprasAProveedoresToolStripMenuItem });
            proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            proveedoresToolStripMenuItem.Size = new Size(84, 20);
            proveedoresToolStripMenuItem.Text = "Proveedores";
            // 
            // agregarProveedoresToolStripMenuItem
            // 
            agregarProveedoresToolStripMenuItem.Name = "agregarProveedoresToolStripMenuItem";
            agregarProveedoresToolStripMenuItem.Size = new Size(199, 22);
            agregarProveedoresToolStripMenuItem.Text = "Agregar Proveedores";
            agregarProveedoresToolStripMenuItem.Click += AgregarProveedoresToolStripMenuItem_Click;
            // 
            // comprasAProveedoresToolStripMenuItem
            // 
            comprasAProveedoresToolStripMenuItem.Name = "comprasAProveedoresToolStripMenuItem";
            comprasAProveedoresToolStripMenuItem.Size = new Size(199, 22);
            comprasAProveedoresToolStripMenuItem.Text = "Compras a Proveedores";
            comprasAProveedoresToolStripMenuItem.Click += ComprasAProveedoresToolStripMenuItem_Click;
            // 
            // ventasToolStripMenuItem
            // 
            ventasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ventasToolStripMenuItem1 });
            ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            ventasToolStripMenuItem.Size = new Size(53, 20);
            ventasToolStripMenuItem.Text = "Ventas";
            // 
            // ventasToolStripMenuItem1
            // 
            ventasToolStripMenuItem1.Name = "ventasToolStripMenuItem1";
            ventasToolStripMenuItem1.Size = new Size(180, 22);
            ventasToolStripMenuItem1.Text = "Ventas";
            ventasToolStripMenuItem1.Click += VentasToolStripMenuItem1_Click;
            // 
            // SchoolShop1MenuWF
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "SchoolShop1MenuWF";
            Text = "SchoolShop1MenuWF";
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
        private ToolStripMenuItem comprasAProveedoresToolStripMenuItem;
        private ToolStripMenuItem ventasToolStripMenuItem;
        private ToolStripMenuItem ventasToolStripMenuItem1;
    }
}