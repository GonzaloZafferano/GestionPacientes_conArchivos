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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp2
{
    public partial class frmAltaPaciente : Form
    {
        private int dni;

        public frmAltaPaciente(int dni)
        {
            InitializeComponent();
            this.AplicarTema();

            this.dni = dni;
            this.LoadInitialData();

            if(dni == 0)
            {
                this.Text = "Alta de Paciente";
                this.btnGuardar.Text = "Guardar";
                this.btnEliminar.Visible = false;
            }
            else
            {
                this.loadForm(Paciente.ObtenerPaciente(dni));
                this.Text = "Modificacion de Paciente";
                this.btnGuardar.Text = "Modificar";
                this.btnEliminar.Visible = true;
            }
        }

        private void LoadInitialData()
        {           
            var obrasSociales = ObraSocial.ObrasSociales.Select(x => new { Text = $"{x.Nombre} - {x.Cuit}", Value = x.Id }).OrderBy(x=> x.Text).ToList();
            obrasSociales.Insert(0, new { Text = string.Empty, Value = -1});

            this.cmbObraSocial.DisplayMember = "Text";         
            this.cmbObraSocial.ValueMember = "Value";
            this.cmbObraSocial.DataSource = obrasSociales;
        }

        private void save()
        {
            try
            {
               Paciente paciente = loadObject();

                if (paciente is not null)
                {
                    if(this.dni == 0)
                        paciente.Guardar();
                    else
                        paciente.Actualizar();  

                    MessageBox.Show("Datos guardados: " + paciente.ToString(),"Paciente guardado con exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.clearForm();
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch(DatoInvalidoException ex)
            {               
                MessageBox.Show("Ha ocurrido un error al intentar guardar el paciente: " + Environment.NewLine + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loadForm(Paciente paciente)
        {
            if(paciente is not null)
            {
                this.txtNombre.Text = paciente.Nombre;
                this.txtApellido.Text = paciente.Apellido;
                this.txtFechaNacimiento.Text = paciente.FechaNacimiento.ToString("dd/MM/yyyy");
                this.txtAfiliado.Text = paciente.NumeroAfiliado;
                this.txtCuit.Text = paciente.Cuit;
                this.txtDni.Text = paciente.Dni.ToString();
                this.txtDiagnostico.Text = paciente.Diagnostico;
                this.cmbObraSocial.SelectedValue = paciente.IdObraSocial;   
            }
        }

        private void clearForm()
        {
            this.txtNombre.Clear();
            this.txtApellido.Clear();
            this.txtFechaNacimiento.Clear(); 
            this.txtAfiliado.Clear(); 
            this.txtCuit.Clear(); 
            this.txtDni.Clear(); 
            this.txtDiagnostico.Clear();
            this.cmbObraSocial.SelectedValue = -1;
        }

        private Paciente loadObject()
        {
            string nombre = this.txtNombre.Text;
            string apellido = this.txtApellido.Text;
            _ = DateTime.TryParse(this.txtFechaNacimiento.Text, out DateTime fechaNacimiento);
            string numeroAfiliado = this.txtAfiliado.Text;
            string cuit = this.txtCuit.Text;
            _ = int.TryParse(this.txtDni.Text, out int dni);
            string diagnostico = this.txtDiagnostico.Text;
            _ = int.TryParse(this.cmbObraSocial.SelectedValue.ToString(), out int idObraSocial);

            return new Paciente(nombre, apellido, fechaNacimiento, idObraSocial, numeroAfiliado, dni, cuit, diagnostico);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.save();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = MessageBox.Show($"Esta por eliminar el paciente {Paciente.ObtenerPaciente(this.dni)?.ToString()} {Environment.NewLine}¿Esta seguro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    Paciente.EliminarPaciente(this.dni);
                    this.DialogResult = DialogResult.OK;
                }
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
                else if (control is System.Windows.Forms.Button boton)
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
