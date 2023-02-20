namespace WinFormsApp2
{
    partial class frmListaOS
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
            this.dgOS = new System.Windows.Forms.DataGridView();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnAltaOS = new System.Windows.Forms.Button();
            this.lblListaOS = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgOS)).BeginInit();
            this.SuspendLayout();
            // 
            // dgOS
            // 
            this.dgOS.AllowUserToAddRows = false;
            this.dgOS.AllowUserToDeleteRows = false;
            this.dgOS.AllowUserToResizeColumns = false;
            this.dgOS.AllowUserToResizeRows = false;
            this.dgOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOS.Location = new System.Drawing.Point(12, 48);
            this.dgOS.MultiSelect = false;
            this.dgOS.Name = "dgOS";
            this.dgOS.ReadOnly = true;
            this.dgOS.RowHeadersVisible = false;
            this.dgOS.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgOS.RowTemplate.Height = 25;
            this.dgOS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgOS.ShowEditingIcon = false;
            this.dgOS.Size = new System.Drawing.Size(600, 300);
            this.dgOS.TabIndex = 0;
            this.dgOS.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgOS_CellDoubleClick);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(516, 355);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(96, 42);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnAltaOS
            // 
            this.btnAltaOS.Location = new System.Drawing.Point(12, 354);
            this.btnAltaOS.Name = "btnAltaOS";
            this.btnAltaOS.Size = new System.Drawing.Size(96, 42);
            this.btnAltaOS.TabIndex = 2;
            this.btnAltaOS.Text = "Alta Obra Social";
            this.btnAltaOS.UseVisualStyleBackColor = true;
            this.btnAltaOS.Click += new System.EventHandler(this.btnAltaOS_Click);
            // 
            // lblListaOS
            // 
            this.lblListaOS.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblListaOS.Location = new System.Drawing.Point(12, 9);
            this.lblListaOS.Name = "lblListaOS";
            this.lblListaOS.Size = new System.Drawing.Size(600, 23);
            this.lblListaOS.TabIndex = 3;
            this.lblListaOS.Text = "Lista Obras Sociales";
            this.lblListaOS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmListaOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 409);
            this.Controls.Add(this.lblListaOS);
            this.Controls.Add(this.btnAltaOS);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.dgOS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmListaOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Obras Sociales";
            this.Load += new System.EventHandler(this.frmListaOS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgOS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgOS;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnAltaOS;
        private System.Windows.Forms.Label lblListaOS;
    }
}