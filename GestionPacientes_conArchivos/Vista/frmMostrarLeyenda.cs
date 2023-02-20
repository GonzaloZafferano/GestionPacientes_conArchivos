using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class frmMostrarLeyenda : Form
    {
        public frmMostrarLeyenda()
        {
            InitializeComponent();
            this.AplicarTema();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                string texto = new Leyenda().ObtenerTextoDeLeyenda(this.rTxtParametros.Text);
                this.rTxtLeyenda.Text = texto;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error. Es probable que la leyenda tenga cargados mas parametros adicionales de los ingresados.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AplicarTema()
        {
            this.BackColor = Tema.TemaApp.ColorDeFondoAplicacion;

            foreach (Control control in this.Controls)
            {
                control.ForeColor = Tema.TemaApp.ColorDeLetraAlternativo;

                if (control is Label)
                {
                    control.BackColor = Color.Transparent;
                }
                else if (control is Button boton)
                {
                    boton.BackColor = Tema.TemaApp.ColorDeFondoDeControl;
                    boton.FlatStyle = FlatStyle.Flat;
                    boton.FlatAppearance.BorderSize = 0;
                    boton.FlatAppearance.MouseDownBackColor = Tema.TemaApp.ColorMouseOver;
                    boton.FlatAppearance.MouseOverBackColor = Tema.TemaApp.ColorMouseOver;
                    boton.ForeColor = Tema.TemaApp.ColorDeLetra;
                }
            }
        }
    }
}
