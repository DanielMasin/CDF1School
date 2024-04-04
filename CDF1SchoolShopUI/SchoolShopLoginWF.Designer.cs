namespace CDF1SchoolShopUI
{
    partial class SchoolShopLoginWF
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
            lblUsuario = new Label();
            lblContra = new Label();
            txtContra = new TextBox();
            txtUsuario = new TextBox();
            btnIniciarSeccion = new Button();
            btnMostrarContra = new Button();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(147, 174);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(151, 15);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Ingrese Nombre de Usuario";
            // 
            // lblContra
            // 
            lblContra.AutoSize = true;
            lblContra.Location = new Point(186, 244);
            lblContra.Name = "lblContra";
            lblContra.Size = new Size(129, 15);
            lblContra.TabIndex = 1;
            lblContra.Text = "Ingrese una contraseña";
            // 
            // txtContra
            // 
            txtContra.Location = new Point(338, 244);
            txtContra.Name = "txtContra";
            txtContra.Size = new Size(317, 23);
            txtContra.TabIndex = 2;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(338, 166);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(317, 23);
            txtUsuario.TabIndex = 3;
            // 
            // btnIniciarSeccion
            // 
            btnIniciarSeccion.Location = new Point(413, 326);
            btnIniciarSeccion.Name = "btnIniciarSeccion";
            btnIniciarSeccion.Size = new Size(148, 37);
            btnIniciarSeccion.TabIndex = 4;
            btnIniciarSeccion.Text = "Ingresar";
            btnIniciarSeccion.UseVisualStyleBackColor = true;
            btnIniciarSeccion.Click += btnIniciarSeccion_Click;
            // 
            // btnMostrarContra
            // 

            btnMostrarContra.Name = "btnMostrarContra";
            btnMostrarContra.Size = new Size(42, 30);
            btnMostrarContra.TabIndex = 5;
            btnMostrarContra.UseVisualStyleBackColor = true;
            btnMostrarContra.Click += btnMostrarContra_Click;
            // 
            // SchoolShopLoginWF
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnMostrarContra);
            Controls.Add(btnIniciarSeccion);
            Controls.Add(txtUsuario);
            Controls.Add(txtContra);
            Controls.Add(lblContra);
            Controls.Add(lblUsuario);
            Name = "SchoolShopLoginWF";
            Text = "SchoolShopLoginWF";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsuario;
        private Label lblContra;
        private TextBox txtContra;
        private TextBox txtUsuario;
        private Button btnIniciarSeccion;
        private Button btnMostrarContra;
    }
}