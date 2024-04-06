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
            lista = new ListBox();
            button1 = new Button();
            txtCodigo = new TextBox();
            txtDescripcion = new TextBox();
            txtPrecio = new TextBox();
            txtExistencia = new TextBox();
            cbCategoria = new ComboBox();
            btnGuardar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // lista
            // 
            lista.FormattingEnabled = true;
            lista.ItemHeight = 15;
            lista.Location = new Point(31, 234);
            lista.Name = "lista";
            lista.Size = new Size(464, 154);
            lista.TabIndex = 4;
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
            // txtCodigo
            // 
            txtCodigo.AcceptsReturn = true;
            txtCodigo.Location = new Point(409, 12);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(183, 23);
            txtCodigo.TabIndex = 7;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(409, 52);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(183, 23);
            txtDescripcion.TabIndex = 8;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(409, 97);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(183, 23);
            txtPrecio.TabIndex = 9;
            // 
            // txtExistencia
            // 
            txtExistencia.Location = new Point(409, 145);
            txtExistencia.Name = "txtExistencia";
            txtExistencia.Size = new Size(183, 23);
            txtExistencia.TabIndex = 10;
            // 
            // cbCategoria
            // 
            cbCategoria.FormattingEnabled = true;
            cbCategoria.Location = new Point(409, 189);
            cbCategoria.Name = "cbCategoria";
            cbCategoria.Size = new Size(183, 23);
            cbCategoria.TabIndex = 11;
            cbCategoria.SelectedIndexChanged += cbCategoria_SelectedIndexChanged;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(517, 241);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 12;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(278, 18);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 13;
            label1.Text = "Codigo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(278, 55);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 14;
            label2.Text = "Descripcion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(278, 100);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 15;
            label3.Text = "Precio unitario";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(278, 145);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 16;
            label4.Text = "Exitencia";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(278, 192);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 17;
            label5.Text = "Categoria";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ButtonFace;
            label6.Font = new Font("Modern No. 20", 11.249999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(-116, 97);
            label6.Name = "label6";
            label6.Size = new Size(82, 17);
            label6.TabIndex = 18;
            label6.Text = "Inventario";
            // 
            // ScchoolShopInventarioWF
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(635, 417);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnGuardar);
            Controls.Add(cbCategoria);
            Controls.Add(txtExistencia);
            Controls.Add(txtPrecio);
            Controls.Add(txtDescripcion);
            Controls.Add(txtCodigo);
            Controls.Add(button1);
            Controls.Add(lista);
            Name = "ScchoolShopInventarioWF";
            Text = "SchoolShopInventarioWF";
            Load += ScchoolShopInventarioWF_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ContextMenuStrip contextMenuStrip1;
        private ListBox lista;
        private Button button1;
        private TextBox txtCodigo;
        private TextBox txtDescripcion;
        private TextBox txtPrecio;
        private TextBox txtExistencia;
        private ComboBox cbCategoria;
        private Button btnGuardar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}