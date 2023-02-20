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
    public partial class frmListaPacientes : Form
    {
        private int indicePrimeraFilaVisible;
        private int indiceFilaSeleccionada;
        private DataGridViewColumn columnaNombreCompleto;
        private DataGridViewColumn columnaFechaNacimiento;
        private DataGridViewColumn columnaDni;
        private DataGridViewColumn columnaCuit;
        private DataGridViewColumn columnaNumeroAfiliado;
        private DataGridViewColumn columnaObraSocial;
        private DataGridViewColumn columnaDiagnostico;

        public frmListaPacientes()
        {
            InitializeComponent();
            this.AplicarTema();
        }

        public void CrearColumnas()
        {
            this.columnaNumeroAfiliado = new DataGridViewColumn();
            this.columnaNumeroAfiliado.Name = "numeroAfiliado";
            this.columnaNumeroAfiliado.HeaderText = "N° Afil.";
            this.columnaNumeroAfiliado.CellTemplate = new DataGridViewTextBoxCell();
            this.columnaNumeroAfiliado.ReadOnly = true;
            this.columnaNumeroAfiliado.DataPropertyName = "NumeroAfiliado";

            this.columnaDni = new DataGridViewColumn();
            this.columnaDni.Name = "dni";
            this.columnaDni.HeaderText = "Dni";
            this.columnaDni.CellTemplate = new DataGridViewTextBoxCell();
            this.columnaDni.ReadOnly = true;
            this.columnaDni.DataPropertyName = "Dni";

            this.columnaCuit = new DataGridViewColumn();
            this.columnaCuit.Name = "cuit";
            this.columnaCuit.HeaderText = "Cuit";
            this.columnaCuit.CellTemplate = new DataGridViewTextBoxCell();
            this.columnaCuit.ReadOnly = true;
            this.columnaCuit.DataPropertyName = "Cuit";

            this.columnaDiagnostico = new DataGridViewColumn();
            this.columnaDiagnostico.Name = "diagnostico";
            this.columnaDiagnostico.HeaderText = "Diagnostico";
            this.columnaDiagnostico.CellTemplate = new DataGridViewTextBoxCell();
            this.columnaDiagnostico.ReadOnly = true;
            this.columnaDiagnostico.DataPropertyName = "Diagnostico";

            this.columnaObraSocial = new DataGridViewColumn();
            this.columnaObraSocial.Name = "obraSocial";
            this.columnaObraSocial.HeaderText = "Obra Social";
            this.columnaObraSocial.CellTemplate = new DataGridViewTextBoxCell();
            this.columnaObraSocial.ReadOnly = true;
            this.columnaObraSocial.DataPropertyName = "ObraSocial";

            this.columnaNombreCompleto = new DataGridViewColumn();
            this.columnaNombreCompleto.Name = "nombreCompleto";
            this.columnaNombreCompleto.HeaderText = "Nombre";
            this.columnaNombreCompleto.CellTemplate = new DataGridViewTextBoxCell();
            this.columnaNombreCompleto.ReadOnly = true;
            this.columnaNombreCompleto.DataPropertyName = "NombreCompleto";

            this.columnaFechaNacimiento = new DataGridViewColumn();
            this.columnaFechaNacimiento.Name = "fechaNacimiento";
            this.columnaFechaNacimiento.HeaderText = "Fecha Nac.";
            this.columnaFechaNacimiento.CellTemplate = new DataGridViewTextBoxCell();
            this.columnaFechaNacimiento.ReadOnly = true;
            this.columnaFechaNacimiento.DataPropertyName = "FechaNacimiento";
        }

        private void OrganizarDataGrid()
        {
            this.dgPacientes.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.CargarDataSource();

            this.dgPacientes.Columns.Clear();

            this.dgPacientes.Columns.
                    AddRange(
                        this.columnaNombreCompleto,
                        this.columnaDni,
                        this.columnaCuit,
                        this.columnaFechaNacimiento,
                        this.columnaObraSocial,
                        this.columnaNumeroAfiliado,
                        this.columnaDiagnostico);

            this.OrdenarGrilla();
            
            this.DarEstiloADataGrid();


            if (this.indicePrimeraFilaVisible >= 0 && this.indicePrimeraFilaVisible < this.dgPacientes.Rows.Count &&
               this.indiceFilaSeleccionada >= 0 && this.indiceFilaSeleccionada < this.dgPacientes.Rows.Count)
            {
                this.dgPacientes.FirstDisplayedScrollingRowIndex = this.indicePrimeraFilaVisible;
                this.dgPacientes.Rows[this.indiceFilaSeleccionada].Selected = true;
            }
            else
            {
                int indicePrimeraFilaVisible = this.indicePrimeraFilaVisible > 0 ? this.indicePrimeraFilaVisible - 1 : 0;
                int indiceFilaSeleccionada = this.indiceFilaSeleccionada > 0 ? this.indiceFilaSeleccionada - 1 : 0;

                if (indicePrimeraFilaVisible >= 0 && indicePrimeraFilaVisible < this.dgPacientes.Rows.Count &&
                indiceFilaSeleccionada >= 0 && indiceFilaSeleccionada < this.dgPacientes.Rows.Count)
                {
                    this.dgPacientes.FirstDisplayedScrollingRowIndex = indicePrimeraFilaVisible;
                    this.dgPacientes.Rows[indiceFilaSeleccionada].Selected = true;
                }
            }
        }

        private void OrdenarGrilla()
        {
            this.dgPacientes.Columns["nombreCompleto"].DisplayIndex = 0;
            this.dgPacientes.Columns["fechaNacimiento"].DisplayIndex = 1;
            this.dgPacientes.Columns["dni"].DisplayIndex = 2;
            this.dgPacientes.Columns["cuit"].DisplayIndex = 3;
            this.dgPacientes.Columns["obraSocial"].DisplayIndex = 4;
            this.dgPacientes.Columns["numeroAfiliado"].DisplayIndex = 5;
            this.dgPacientes.Columns["diagnostico"].DisplayIndex = 6;
        }

        private void CargarDataSource()
        {
            BindingList<Paciente> pacientesGrilla = new BindingList<Paciente>();

            var pacientes = Paciente.Pacientes.OrderBy(x => x.NombreCompleto).ToList();

            for (int i = 0; i < pacientes.Count; i++)
                pacientesGrilla.Add(pacientes[i]);

            this.dgPacientes.DataSource = null;
            this.dgPacientes.DataSource = pacientesGrilla;
        }
          
        private void DarEstiloADataGrid()
        { 
            this.dgPacientes.Columns["nombreCompleto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgPacientes.Columns["fechaNacimiento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgPacientes.Columns["dni"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgPacientes.Columns["cuit"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgPacientes.Columns["obraSocial"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgPacientes.Columns["numeroAfiliado"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgPacientes.Columns["diagnostico"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dgPacientes.Columns["nombreCompleto"].Width = 200;
            this.dgPacientes.Columns["fechaNacimiento"].Width = 80;
            this.dgPacientes.Columns["dni"].Width = 80;
            this.dgPacientes.Columns["cuit"].Width = 80;
            this.dgPacientes.Columns["obraSocial"].Width = 200;
            this.dgPacientes.Columns["numeroAfiliado"].Width = 80;
            this.dgPacientes.Columns["diagnostico"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAltaPaciente_Click(object sender, EventArgs e)
        {
            frmAltaPaciente altaP = new frmAltaPaciente(0);         

            if(altaP.ShowDialog() == DialogResult.OK)
            {         
                this.OrganizarDataGrid();
            }
        }

        private void frmListaPacientes_Load(object sender, EventArgs e)
        {
            this.CrearColumnas();
            this.OrganizarDataGrid();     
        }

        private void dgPacientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (this.dgPacientes.Rows.Count > e.RowIndex && this.dgPacientes.Columns.Count > e.ColumnIndex)
                {
                    Paciente paciente = this.dgPacientes.Rows[e.RowIndex].DataBoundItem as Paciente;

                    if (paciente is not null)
                    {
                        this.indiceFilaSeleccionada = e.RowIndex;
                        this.indicePrimeraFilaVisible = dgPacientes.FirstDisplayedScrollingRowIndex;

                        frmAltaPaciente p = new frmAltaPaciente(paciente.Dni);                        

                        if (p.ShowDialog() == DialogResult.OK)
                        {
                            this.OrganizarDataGrid();
                        }
                    }
                }
            }
            catch (Exception) { }
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
