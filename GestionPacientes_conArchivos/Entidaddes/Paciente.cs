using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Paciente : Persona
    {
        public static event ErrorAlCargarLista OnError;

        private int idObraSocial;
        private int dni;
        private string cuit;
        private string numeroAfiliado;
        private string diagnostico;
        private static List<Paciente> pacientes;

        public Paciente() { }
        public Paciente(string nombre, string apellido, DateTime fechaNacimiento,
            int idObraSocial, string numeroAfiliado, int dni, string cuit, string diagnostico)
            : base(nombre, apellido, fechaNacimiento)
        {
            this.idObraSocial = idObraSocial;
            this.NumeroAfiliado = numeroAfiliado;
            this.Dni = dni;
            this.Cuit = cuit;
            this.Diagnostico = diagnostico;
        }

        [Browsable(false)]
        public int IdObraSocial
        {
            get => this.idObraSocial;
            set
            {
                if (value == -1 || value == 0)
                    throw new DatoInvalidoException("Debe ingresar una obra social.");
                else
                    this.idObraSocial = value;
            }
        }
          
        public string NumeroAfiliado
        {
            get => this.numeroAfiliado;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new DatoInvalidoException("Debe ingresar un numero de afiliado.");
                else
                    this.numeroAfiliado = value;
            }
        }

        public int Dni
        {
            get => this.dni;
            set
            {
                if (value < 1000000 || value > 99999999)
                    throw new DatoInvalidoException("Debe ingresar un Dni valido.");
                else
                    this.dni = value;
            }
        }

        public string Cuit
        {
            get => this.cuit;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new DatoInvalidoException("Debe ingresar un Cuit.");
                else
                    this.cuit = value;
            }
        }
               
        public string Diagnostico
        {
            get => this.diagnostico;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new DatoInvalidoException("Debe ingresar un diagnostico.");
                else
                    this.diagnostico = value;
            }
        }

        public string ObraSocial
        {
            get { return Entidades.ObraSocial.ObtenerObraSocial(this.IdObraSocial)?.Nombre; }
        }

        public static List<Paciente> Pacientes
        {
            get
            {
                try
                {
                    if (Paciente.pacientes is null)
                        Paciente.pacientes = SerializadorXml<List<Paciente>>.LeerXml("Pacientes");
                }
                catch(Exception ex)
                {
                    Paciente.pacientes = new List<Paciente>();
                    //Paciente.OnError.Invoke("No se encontro una lista de pacientes. Se iniciara una nueva");
                }
                return Paciente.pacientes;      
            }
        }          

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine();
            sb.AppendLine("Nombre:" + this.Nombre);
            sb.AppendLine("Apellido: " + this.Apellido);
            sb.AppendLine("Fecha nac: " + this.FechaNacimiento.ToString("dd/MM/yyyy"));
            sb.AppendLine("Dni: " + this.Dni.ToString());
            sb.AppendLine("Cuit: " + this.Cuit);
            sb.AppendLine("Numero afiliado: " + this.NumeroAfiliado);
            sb.AppendLine("Obra social: " + this.ObraSocial);
            sb.AppendLine("Diagnostico: " + this.Diagnostico);

            return sb.ToString();
        }

        public static Paciente ObtenerPaciente(int dni)
        {
            Paciente p = Paciente.Pacientes.Where(x => x.Dni == dni).FirstOrDefault();
            return p;
        }

        public bool Guardar()
        {
            Paciente.pacientes.Add(this);
            return Paciente.GuardarEnArchivo();
        }

        public bool Actualizar()
        {
            Paciente.pacientes.Remove(Paciente.pacientes.Where(x => x.Dni == this.Dni).FirstOrDefault());
            return this.Guardar();
        }

        public static bool EliminarPaciente(int dni)
        {
            if (Paciente.pacientes.Remove(Paciente.Pacientes.Where(x => x.Dni == dni).FirstOrDefault()))
                return Paciente.GuardarEnArchivo();
            else
                OnError("No se ha podido eliminar la obra social.");
            return false;
        }

        private static bool GuardarEnArchivo()
        {
            return SerializadorXml<List<Paciente>>.GuardarXml("Pacientes", Paciente.pacientes);
        }
    }
}

