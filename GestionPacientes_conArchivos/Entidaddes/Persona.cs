using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        private string nombre;
        private string apellido;
        private DateTime fechaNacimiento;

        public Persona() { }
        public Persona(string nombre, string apellido, DateTime fechaNacimiento)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.FechaNacimiento = fechaNacimiento;
        }

        [Browsable(false)]
        public string Nombre 
        {
            get => nombre;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new DatoInvalidoException("Debe ingresar un nombre.");
                else
                    this.nombre = value.DarFormatoDeNombre();
            }        
        }

        [Browsable(false)]
        public string Apellido
        {
            get => apellido;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new DatoInvalidoException("Debe ingresar un apellido.");
                else
                    this.apellido = value.DarFormatoDeNombre(); 
            }
        }
        
        public string NombreCompleto
        {
            get
            {
                return this.nombre + " " + this.apellido; 
            }
        }
       
        public DateTime FechaNacimiento 
        { 
            get => fechaNacimiento; 
            set
            {
                if(value < new DateTime(1960,01,01) || value > DateTime.Now) 
                    throw new DatoInvalidoException("Debe ingresar una fecha valida.");
                else
                    this.fechaNacimiento = value;
            }
        }
    }
}
