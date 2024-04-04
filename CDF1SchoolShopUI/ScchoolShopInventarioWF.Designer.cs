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
            textBuscar = new TextBox();
            lista = new ListBox();
            btnBuscar = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // textBuscar
            // 
            textBuscar.Location = new Point(26, 38);
            textBuscar.Name = "textBuscar";
            textBuscar.Size = new Size(323, 23);
            textBuscar.TabIndex = 2;
            // 
            // lista
            // 
            lista.FormattingEnabled = true;
            lista.ItemHeight = 15;
            lista.Location = new Point(26, 87);
            lista.Name = "lista";
            lista.Size = new Size(442, 244);
            lista.TabIndex = 4;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(364, 38);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(104, 23);
            btnBuscar.TabIndex = 5;
            btnBuscar.Text = "Buscar Codigo";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(517, 365);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = true;
            // 
            // ScchoolShopInventarioWF
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(697, 417);
            Controls.Add(button1);
            Controls.Add(btnBuscar);
            Controls.Add(lista);
            Controls.Add(textBuscar);
            Name = "ScchoolShopInventarioWF";
            Text = "SchoolShopInventarioWF";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ContextMenuStrip contextMenuStrip1;
        private TextBox textBuscar;
        private ListBox lista;
        private Button btnBuscar;
        private Button button1;
    }
}