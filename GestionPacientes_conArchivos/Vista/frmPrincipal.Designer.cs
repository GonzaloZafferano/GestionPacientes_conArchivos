namespace WinFormsApp2
{
    partial class frmPrincipal
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
            this.btnListaPacientes = new System.Windows.Forms.Button();
            this.btnObrasSociales = new System.Windows.Forms.Button();
            this.btnObtenerLeyendas = new System.Windows.Forms.Button();
            this.btnMostrarLeyenda = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnListaPacientes
            // 
            this.btnListaPacientes.Location = new System.Drawing.Point(12, 43);
            this.btnListaPacientes.Name = "btnListaPacientes";
            this.btnListaPacientes.Size = new System.Drawing.Size(118, 43);
            this.btnListaPacientes.TabIndex = 2;
            this.btnListaPacientes.Text = "Pacientes";
            this.btnListaPacientes.UseVisualStyleBackColor = true;
            this.btnListaPacientes.Click += new System.EventHandler(this.btnListaPacientes_Click);
            // 
            // btnObrasSociales
            // 
            this.btnObrasSociales.Location = new System.Drawing.Point(156, 43);
            this.btnObrasSociales.Name = "btnObrasSociales";
            this.btnObrasSociales.Size = new System.Drawing.Size(118, 43);
            this.btnObrasSociales.TabIndex = 3;
            this.btnObrasSociales.Text = "Obras Sociales";
            this.btnObrasSociales.UseVisualStyleBackColor = true;
            this.btnObrasSociales.Click += new System.EventHandler(this.btnObrasSociales_Click);
            // 
            // btnObtenerLeyendas
            // 
            this.btnObtenerLeyendas.Location = new System.Drawing.Point(12, 116);
            this.btnObtenerLeyendas.Name = "btnObtenerLeyendas";
            this.btnObtenerLeyendas.Size = new System.Drawing.Size(118, 43);
            this.btnObtenerLeyendas.TabIndex = 4;
            this.btnObtenerLeyendas.Text = "Cambiar Leyenda";
            this.btnObtenerLeyendas.UseVisualStyleBackColor = true;
            this.btnObtenerLeyendas.Click += new System.EventHandler(this.btnObtenerLeyendas_Click);
            // 
            // btnMostrarLeyenda
            // 
            this.btnMostrarLeyenda.Location = new System.Drawing.Point(156, 118);
            this.btnMostrarLeyenda.Name = "btnMostrarLeyenda";
            this.btnMostrarLeyenda.Size = new System.Drawing.Size(118, 41);
            this.btnMostrarLeyenda.TabIndex = 5;
            this.btnMostrarLeyenda.Text = "Mostrar Leyenda";
            this.btnMostrarLeyenda.UseVisualStyleBackColor = true;
            this.btnMostrarLeyenda.Click += new System.EventHandler(this.btnMostrarLeyenda_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(262, 23);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Gestion de Pacientes";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 174);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnMostrarLeyenda);
            this.Controls.Add(this.btnObtenerLeyendas);
            this.Controls.Add(this.btnObrasSociales);
            this.Controls.Add(this.btnListaPacientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturacion";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnListaPacientes;
        private System.Windows.Forms.Button btnObrasSociales;
        private System.Windows.Forms.Button btnObtenerLeyendas;
        private System.Windows.Forms.Button btnMostrarLeyenda;
        private System.Windows.Forms.Label lblTitulo;
    }
}