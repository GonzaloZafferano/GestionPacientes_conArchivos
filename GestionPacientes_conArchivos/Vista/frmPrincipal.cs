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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            Paciente.OnError += this.mostrarMensaje;
            ObraSocial.OnError += this.mostrarMensaje;
            Leyenda.OnError += this.mostrarMensaje;

            InitializeComponent();
            var pacientes = Paciente.Pacientes;
            var obrasSociales = ObraSocial.ObrasSociales;
            var leyenda = new Leyenda().LeyendaString;

            this.AplicarTema();
        }

        private void btnAltaObraSocial_Click(object sender, EventArgs e)
        {
            frmAltaObraSocial altaOs = new frmAltaObraSocial(0);
            altaOs.ShowDialog();
        }

       
        private void mostrarMensaje(string mensaje)
        {
            MessageBox.Show(mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnListaPacientes_Click(object sender, EventArgs e)
        {
            frmListaPacientes p = new frmListaPacientes();
            p.ShowDialog();
        }

        private void btnObrasSociales_Click(object sender, EventArgs e)
        {
            frmListaOS os = new frmListaOS();
            os.ShowDialog();
        }

        private void btnObtenerLeyendas_Click(object sender, EventArgs e)
        {
            frmLeyenda l = new frmLeyenda();
            l.ShowDialog();
        }

        private void btnMostrarLeyenda_Click(object sender, EventArgs e)
        {
            frmMostrarLeyenda frmMostrarLeyenda = new frmMostrarLeyenda();
            frmMostrarLeyenda.ShowDialog();
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
