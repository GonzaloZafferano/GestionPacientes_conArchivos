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
    public partial class frmListaOS : Form
    {
        private int indicePrimeraFilaVisible;
        private int indiceFilaSeleccionada;
        private DataGridViewColumn columnaNombre;
        private DataGridViewColumn columnaTipoFactura;
        private DataGridViewColumn columnaCuit;
        private DataGridViewColumn columnaDetalles;

        public frmListaOS()
        {
            InitializeComponent();
            this.AplicarTema();
        }


        public void CrearColumnas()
        {
            this.columnaNombre = new DataGridViewColumn();
            this.columnaNombre.Name = "nombre";
            this.columnaNombre.HeaderText = "Nombre";
            this.columnaNombre.CellTemplate = new DataGridViewTextBoxCell();
            this.columnaNombre.ReadOnly = true;
            this.columnaNombre.DataPropertyName = "Nombre";

            this.columnaTipoFactura = new DataGridViewColumn();
            this.columnaTipoFactura.Name = "factura";
            this.columnaTipoFactura.HeaderText = "Factura";
            this.columnaTipoFactura.CellTemplate = new DataGridViewTextBoxCell();
            this.columnaTipoFactura.ReadOnly = true;
            this.columnaTipoFactura.DataPropertyName = "Factura";

            this.columnaCuit = new DataGridViewColumn();
            this.columnaCuit.Name = "cuit";
            this.columnaCuit.HeaderText = "Cuit";
            this.columnaCuit.CellTemplate = new DataGridViewTextBoxCell();
            this.columnaCuit.ReadOnly = true;
            this.columnaCuit.DataPropertyName = "Cuit";

            this.columnaDetalles = new DataGridViewColumn();
            this.columnaDetalles.Name = "detalle";
            this.columnaDetalles.HeaderText = "Detalle";
            this.columnaDetalles.CellTemplate = new DataGridViewTextBoxCell();
            this.columnaDetalles.ReadOnly = true;
            this.columnaDetalles.DataPropertyName = "Detalle";
        }

        private void OrganizarDataGrid()
        {
            this.dgOS.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.CargarDataSource();

            this.dgOS.Columns.Clear();

            this.dgOS.Columns.
                    AddRange(
                        this.columnaCuit,
                        this.columnaNombre,
                        this.columnaTipoFactura,
                        this.columnaDetalles);

            this.OrdenarGrilla();

            this.DarEstiloADataGrid();


            if (this.indicePrimeraFilaVisible >= 0 && this.indicePrimeraFilaVisible < this.dgOS.Rows.Count &&
               this.indiceFilaSeleccionada >= 0 && this.indiceFilaSeleccionada < this.dgOS.Rows.Count)
            {
                this.dgOS.FirstDisplayedScrollingRowIndex = this.indicePrimeraFilaVisible;
                this.dgOS.Rows[this.indiceFilaSeleccionada].Selected = true;
            }
            else
            {
                int indicePrimeraFilaVisible = this.indicePrimeraFilaVisible > 0 ? this.indicePrimeraFilaVisible - 1 : 0;
                int indiceFilaSeleccionada = this.indiceFilaSeleccionada > 0 ? this.indiceFilaSeleccionada - 1 : 0;

                if (indicePrimeraFilaVisible >= 0 && indicePrimeraFilaVisible < this.dgOS.Rows.Count &&
                indiceFilaSeleccionada >= 0 && indiceFilaSeleccionada < this.dgOS.Rows.Count)
                { 
                    this.dgOS.FirstDisplayedScrollingRowIndex = indicePrimeraFilaVisible;
                    this.dgOS.Rows[indiceFilaSeleccionada].Selected = true;
                }
            }
        }

        private void OrdenarGrilla()
        {
            this.dgOS.Columns["nombre"].DisplayIndex = 0;
            this.dgOS.Columns["cuit"].DisplayIndex = 1;           
            this.dgOS.Columns["factura"].DisplayIndex = 2;
            this.dgOS.Columns["detalle"].DisplayIndex = 3;
        }

        private void CargarDataSource()
        {
            BindingList<ObraSocial> osGrilla = new BindingList<ObraSocial>();

            var os = ObraSocial.ObrasSociales.OrderBy(x => x.Nombre).ToList();

            for (int i = 0; i < os.Count; i++)
                osGrilla.Add(os[i]);

            this.dgOS.DataSource = null;
            this.dgOS.DataSource = osGrilla;
        }

        private void DarEstiloADataGrid()
        {
            this.dgOS.Columns["nombre"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgOS.Columns["cuit"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgOS.Columns["factura"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgOS.Columns["detalle"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dgOS.Columns["nombre"].Width = 200;
            this.dgOS.Columns["cuit"].Width = 80;
            this.dgOS.Columns["factura"].Width = 100;
            this.dgOS.Columns["detalle"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAltaOS_Click(object sender, EventArgs e)
        {
            frmAltaObraSocial altaOs = new frmAltaObraSocial(0);

            if (altaOs.ShowDialog() == DialogResult.OK)
            {
                this.OrganizarDataGrid();
            }
        }

        private void dgOS_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (this.dgOS.Rows.Count > e.RowIndex && this.dgOS.Columns.Count > e.ColumnIndex)
                {
                    ObraSocial os = this.dgOS.Rows[e.RowIndex].DataBoundItem as ObraSocial;

                    if (os is not null)
                    {
                        this.indiceFilaSeleccionada = e.RowIndex;
                        this.indicePrimeraFilaVisible = dgOS.FirstDisplayedScrollingRowIndex;

                        frmAltaObraSocial osForm = new frmAltaObraSocial(os.Id);

                        if (osForm.ShowDialog() == DialogResult.OK)
                        {
                            this.OrganizarDataGrid();
                        }
                    }
                }
            }
            catch (Exception) { }
        }

        private void frmListaOS_Load(object sender, EventArgs e)
        {
            this.CrearColumnas();
            this.OrganizarDataGrid();
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
