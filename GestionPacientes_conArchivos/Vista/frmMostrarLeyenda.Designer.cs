namespace WinFormsApp2
{
    partial class frmMostrarLeyenda
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
            this.rTxtLeyenda = new System.Windows.Forms.RichTextBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.rTxtParametros = new System.Windows.Forms.RichTextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblArgumentos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rTxtLeyenda
            // 
            this.rTxtLeyenda.Location = new System.Drawing.Point(12, 135);
            this.rTxtLeyenda.Name = "rTxtLeyenda";
            this.rTxtLeyenda.Size = new System.Drawing.Size(476, 452);
            this.rTxtLeyenda.TabIndex = 0;
            this.rTxtLeyenda.Text = "";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(406, 593);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(82, 38);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(12, 593);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(83, 38);
            this.btnMostrar.TabIndex = 2;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // rTxtParametros
            // 
            this.rTxtParametros.Location = new System.Drawing.Point(11, 27);
            this.rTxtParametros.Name = "rTxtParametros";
            this.rTxtParametros.Size = new System.Drawing.Size(477, 63);
            this.rTxtParametros.TabIndex = 3;
            this.rTxtParametros.Text = "";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(12, 117);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(62, 15);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.Text = "Resultado:";
            // 
            // lblArgumentos
            // 
            this.lblArgumentos.AutoSize = true;
            this.lblArgumentos.Location = new System.Drawing.Point(11, 9);
            this.lblArgumentos.Name = "lblArgumentos";
            this.lblArgumentos.Size = new System.Drawing.Size(308, 15);
            this.lblArgumentos.TabIndex = 5;
            this.lblArgumentos.Text = "Ingrese los argumentos, de ser necesario, separados por *";
            // 
            // frmMostrarLeyenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 643);
            this.Controls.Add(this.lblArgumentos);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.rTxtParametros);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.rTxtLeyenda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMostrarLeyenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Leyenda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rTxtLeyenda;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.RichTextBox rTxtParametros;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblArgumentos;
    }
}