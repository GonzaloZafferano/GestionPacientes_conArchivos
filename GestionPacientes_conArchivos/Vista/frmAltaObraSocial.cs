using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class frmAltaObraSocial : Form
    {
        private int id;
        public frmAltaObraSocial(int id)
        {
            InitializeComponent();    
            this.AplicarTema();

            this.id = id;
            this.LoadInitialData();

            if (id == 0)
            {
                this.Text = "Alta de Obra Social";
                this.btnGuardar.Text = "Guardar";
                this.btnEliminar.Visible = false;
            }
            else
            {
                this.loadForm(ObraSocial.ObtenerObraSocial(id));
                this.Text = "Modificacion de Obra Social";
                this.btnGuardar.Text = "Modificar";
                this.btnEliminar.Visible = true;
            }
        }

        private void LoadInitialData()
        {
            this.cmbTipoFactura.DisplayMember = "Text";
            this.cmbTipoFactura.ValueMember = "Value";
            var facturas = Factura.ObtenerListadoDeFacturas();
            facturas.Insert(0, new Factura{ Text = string.Empty, Value = -1 });
            this.cmbTipoFactura.DataSource = facturas;
        }

        private void save()
        {
            try
            {
                ObraSocial os = loadObject();

                if (os is not null)
                {
                    if (this.id == 0)
                        os.Guardar();
                    else
                        os.Actualizar();

                    MessageBox.Show("Datos guardados: " + os.ToString(), "Obra Social cargada con exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.clearForm();
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (DatoInvalidoException ex)
            {
                MessageBox.Show("Ha ocurrido un error al intentar guardar la obra social: " + Environment.NewLine + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loadForm(ObraSocial os)
        {
            if (os is not null)
            {
                this.txtNombre.Text = os.Nombre;
                this.cmbTipoFactura.SelectedValue = os.TipoFactura;
                this.txtDetalle.Text = os.Detalle;
                this.txtCuit.Text = os.Cuit;            
            }
        }

        private void clearForm()
        {
            this.txtNombre.Clear();
            this.txtCuit.Clear();
            this.txtDetalle.Clear();
            this.cmbTipoFactura.SelectedValue = -1;
        }

        private ObraSocial loadObject()
        {
            string nombre = this.txtNombre.Text;
            string detalle = this.txtDetalle.Text;
            string cuit = this.txtCuit.Text;
            _ = int.TryParse(this.cmbTipoFactura.SelectedValue.ToString(), out int tipoFactura);

            return new ObraSocial(nombre, tipoFactura, cuit, detalle, this.id);      
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = MessageBox.Show($"Esta por eliminar la obra social {ObraSocial.ObtenerObraSocial(this.id)?.ToString()} {Environment.NewLine}¿Esta seguro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    ObraSocial.EliminarObraSocial(this.id);
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.save();            
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
