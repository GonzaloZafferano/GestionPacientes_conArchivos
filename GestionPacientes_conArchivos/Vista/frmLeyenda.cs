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
    public partial class frmLeyenda : Form
    {
        public frmLeyenda()
        {
            InitializeComponent();
            this.AplicarTema();

            this.rTxt.Text = new Leyenda().LeyendaString;
            this.lblAyuda.Text = @"{0} : Nombre paciente 
{1}: Numero Afiliado 
{2} : Nombre de Obra Social 
{3} : Cuit del paciente 
{4} : Diagnostico 
{5} : Dni 
{6} : Fecha de nacimiento 
{7} : Tipo de factura 
{8} : Cuit Obra Social 
{9} Detalle de Obra Social
{11} Parametro adicional 1
{12} Parametro adicional 2
{13} Parametro adicional 3
etc.";
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string texto = this.rTxt.Text;

                Leyenda l = new Leyenda(texto);

                if (l.Guardar())
                {
                    MessageBox.Show("Leyenda guardada: " + Environment.NewLine + l.LeyendaString, "Leyenda guardada con exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (DatoInvalidoException ex)
            {
                MessageBox.Show("Ha ocurrido un error al intentar guardar la leyenda: " + Environment.NewLine + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
