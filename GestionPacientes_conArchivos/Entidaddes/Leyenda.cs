using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Leyenda
    {
        public static event ErrorAlCargarLista OnError;
        private string leyenda;

        public string LeyendaString 
        {
            get
            {
                try
                {
                    if (string.IsNullOrWhiteSpace(this.leyenda))
                        this.leyenda = SerializadorXml<Leyenda>.LeerXml("Leyenda").LeyendaString;
                }
                catch (Exception ex)
                {
                    //Leyenda.OnError.Invoke("No se encontro una leyenda.");
                }
                return this.leyenda;
            }
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new DatoInvalidoException("La leyenda es invalida");
                }
                this.leyenda = value;
            } 
        }

        public Leyenda() { }

        public Leyenda(string leyendaString)
        {
            this.LeyendaString = leyendaString;
        }

        public bool Guardar()
        {
            return SerializadorXml<Leyenda>.GuardarXml("Leyenda", this);
        }

        public string ObtenerTextoDeLeyenda(string texto)
        {
            StringBuilder sb = new StringBuilder();

            foreach(var paciente in Paciente.Pacientes)
            {
                string nombreCompleto = paciente.NombreCompleto;
                string numeroAfiliado = paciente.NumeroAfiliado;
                string nombreOS = paciente.ObraSocial;
                string cuitPaciente = paciente.Cuit;
                string diagnostico = paciente.Diagnostico;
                string dni = paciente.Dni.ToString();
                string fechaNacimiento = paciente.FechaNacimiento.ToString("dd/MM/yyyy");

                var obraSocial = ObraSocial.ObtenerObraSocial(paciente.IdObraSocial);
                string tipoFactura = obraSocial?.Factura;
                string cuitOS = obraSocial?.Cuit;
                string detallesOS = obraSocial?.Detalle;

                sb.AppendLine();
                ArrayList parametros = new ArrayList() { nombreCompleto, numeroAfiliado, nombreOS, cuitPaciente, diagnostico, dni, fechaNacimiento, tipoFactura, cuitOS, detallesOS, Environment.NewLine };
                parametros.AddRange(texto.Split('*'));
                sb.AppendFormat(this.LeyendaString, parametros.ToArray());
            }
            return sb.ToString();
        }
    }
}
