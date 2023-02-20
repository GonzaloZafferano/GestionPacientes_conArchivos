using System.Windows.Forms;

namespace WinFormsApp2
{
    partial class frmAltaPaciente
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblDiagnostico = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblCuit = new System.Windows.Forms.Label();
            this.lblNAfiliado = new System.Windows.Forms.Label();
            this.lblObraSocial = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtAfiliado = new System.Windows.Forms.TextBox();
            this.txtCuit = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtDiagnostico = new System.Windows.Forms.RichTextBox();
            this.txtFechaNacimiento = new System.Windows.Forms.TextBox();
            this.cmbObraSocial = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblAltaPaciente = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombre.Location = new System.Drawing.Point(132, 54);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PlaceholderText = "nombre";
            this.txtNombre.Size = new System.Drawing.Size(255, 26);
            this.txtNombre.TabIndex = 0;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.Location = new System.Drawing.Point(13, 57);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(64, 18);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblApellido.Location = new System.Drawing.Point(13, 94);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(65, 18);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFechaNacimiento.Location = new System.Drawing.Point(13, 130);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(84, 18);
            this.lblFechaNacimiento.TabIndex = 3;
            this.lblFechaNacimiento.Text = "Fecha Nac";
            // 
            // lblDiagnostico
            // 
            this.lblDiagnostico.AutoSize = true;
            this.lblDiagnostico.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDiagnostico.Location = new System.Drawing.Point(13, 317);
            this.lblDiagnostico.Name = "lblDiagnostico";
            this.lblDiagnostico.Size = new System.Drawing.Size(92, 18);
            this.lblDiagnostico.TabIndex = 4;
            this.lblDiagnostico.Text = "Diagnóstico";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDni.Location = new System.Drawing.Point(13, 276);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(34, 18);
            this.lblDni.TabIndex = 5;
            this.lblDni.Text = "DNI";
            // 
            // lblCuit
            // 
            this.lblCuit.AutoSize = true;
            this.lblCuit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCuit.Location = new System.Drawing.Point(13, 241);
            this.lblCuit.Name = "lblCuit";
            this.lblCuit.Size = new System.Drawing.Size(43, 18);
            this.lblCuit.TabIndex = 6;
            this.lblCuit.Text = "CUIT";
            // 
            // lblNAfiliado
            // 
            this.lblNAfiliado.AutoSize = true;
            this.lblNAfiliado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNAfiliado.Location = new System.Drawing.Point(13, 203);
            this.lblNAfiliado.Name = "lblNAfiliado";
            this.lblNAfiliado.Size = new System.Drawing.Size(81, 18);
            this.lblNAfiliado.TabIndex = 7;
            this.lblNAfiliado.Text = "N° Afiliado";
            // 
            // lblObraSocial
            // 
            this.lblObraSocial.AutoSize = true;
            this.lblObraSocial.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblObraSocial.Location = new System.Drawing.Point(13, 166);
            this.lblObraSocial.Name = "lblObraSocial";
            this.lblObraSocial.Size = new System.Drawing.Size(91, 18);
            this.lblObraSocial.TabIndex = 8;
            this.lblObraSocial.Text = "Obra Social";
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtApellido.Location = new System.Drawing.Point(132, 91);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.PlaceholderText = "apellido";
            this.txtApellido.Size = new System.Drawing.Size(255, 26);
            this.txtApellido.TabIndex = 10;
            // 
            // txtAfiliado
            // 
            this.txtAfiliado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAfiliado.Location = new System.Drawing.Point(132, 200);
            this.txtAfiliado.Name = "txtAfiliado";
            this.txtAfiliado.PlaceholderText = "12345678";
            this.txtAfiliado.Size = new System.Drawing.Size(255, 26);
            this.txtAfiliado.TabIndex = 11;
            // 
            // txtCuit
            // 
            this.txtCuit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCuit.Location = new System.Drawing.Point(132, 238);
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.PlaceholderText = "11-11111111-1";
            this.txtCuit.Size = new System.Drawing.Size(255, 26);
            this.txtCuit.TabIndex = 12;
            // 
            // txtDni
            // 
            this.txtDni.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDni.Location = new System.Drawing.Point(132, 273);
            this.txtDni.Name = "txtDni";
            this.txtDni.PlaceholderText = "11111111";
            this.txtDni.Size = new System.Drawing.Size(255, 26);
            this.txtDni.TabIndex = 13;
            // 
            // txtDiagnostico
            // 
            this.txtDiagnostico.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDiagnostico.Location = new System.Drawing.Point(132, 314);
            this.txtDiagnostico.Name = "txtDiagnostico";
            this.txtDiagnostico.Size = new System.Drawing.Size(255, 114);
            this.txtDiagnostico.TabIndex = 14;
            this.txtDiagnostico.Text = "";
            // 
            // txtFechaNacimiento
            // 
            this.txtFechaNacimiento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtFechaNacimiento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtFechaNacimiento.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFechaNacimiento.Location = new System.Drawing.Point(132, 127);
            this.txtFechaNacimiento.Name = "txtFechaNacimiento";
            this.txtFechaNacimiento.PlaceholderText = "01/01/2020";
            this.txtFechaNacimiento.Size = new System.Drawing.Size(255, 26);
            this.txtFechaNacimiento.TabIndex = 15;
            // 
            // cmbObraSocial
            // 
            this.cmbObraSocial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbObraSocial.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbObraSocial.FormattingEnabled = true;
            this.cmbObraSocial.Location = new System.Drawing.Point(132, 163);
            this.cmbObraSocial.Name = "cmbObraSocial";
            this.cmbObraSocial.Size = new System.Drawing.Size(255, 26);
            this.cmbObraSocial.TabIndex = 16;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGuardar.Location = new System.Drawing.Point(13, 442);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(92, 32);
            this.btnGuardar.TabIndex = 17;
            this.btnGuardar.Text = "Modificar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCerrar.Location = new System.Drawing.Point(312, 442);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 32);
            this.btnCerrar.TabIndex = 18;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEliminar.Location = new System.Drawing.Point(175, 442);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 32);
            this.btnEliminar.TabIndex = 19;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblAltaPaciente
            // 
            this.lblAltaPaciente.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAltaPaciente.Location = new System.Drawing.Point(2, 9);
            this.lblAltaPaciente.Name = "lblAltaPaciente";
            this.lblAltaPaciente.Size = new System.Drawing.Size(423, 42);
            this.lblAltaPaciente.TabIndex = 20;
            this.lblAltaPaciente.Text = "Alta de Paciente";
            this.lblAltaPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmAltaPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 486);
            this.Controls.Add(this.lblAltaPaciente);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cmbObraSocial);
            this.Controls.Add(this.txtFechaNacimiento);
            this.Controls.Add(this.txtDiagnostico);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.txtCuit);
            this.Controls.Add(this.txtAfiliado);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblObraSocial);
            this.Controls.Add(this.lblNAfiliado);
            this.Controls.Add(this.lblCuit);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblDiagnostico);
            this.Controls.Add(this.lblFechaNacimiento);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAltaPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta de Paciente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private TextBox txtNombre;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblFechaNacimiento;
        private Label lblDiagnostico;
        private Label lblDni;
        private Label lblCuit;
        private Label lblNAfiliado;
        private Label lblObraSocial;
        private TextBox txtApellido;
        private TextBox txtAfiliado;
        private TextBox txtCuit;
        private TextBox txtDni;
        private RichTextBox txtDiagnostico;
        private TextBox txtFechaNacimiento;
        private ComboBox cmbObraSocial;

        #endregion

        private Button btnGuardar;
        private Button btnCerrar;
        private Button btnEliminar;
        private Label lblAltaPaciente;
    }
}
