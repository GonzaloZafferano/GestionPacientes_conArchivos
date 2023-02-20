using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ObraSocial
    {
        public static event ErrorAlCargarLista OnError;

        private int id;
        private string nombre;
        private int tipoFactura;
        private string cuit;
        private static List<ObraSocial> obrasSociales;

        public ObraSocial() { }
        public ObraSocial(string nombre, int tipoFactura, string cuit, string detalle, int id)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.TipoFactura = tipoFactura;
            this.Cuit = cuit;
            this.Detalle = detalle;
        }

        public int Id
        {
            get { return id; }
            set
            {
                if (value == -1)
                    throw new DatoInvalidoException("Id Invalido.");
                else
                    if(value == 0)                                               
                        this.id = new IdentificadorUnico().ObtenerIdUnico();                    
                    else
                        this.id = value;
            }
        }

        public string Detalle { get; set; }

        public string Nombre 
        { 
            get => nombre;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new DatoInvalidoException("Debe ingresar un nombre para la obra social.");
                else
                    this.nombre = value.DarFormatoDeNombre();
            }
        }
        public int TipoFactura 
        { 
            get => tipoFactura;
            set
            {
                if (value == -1 || value == 0)
                    throw new DatoInvalidoException("Debe ingresar un tipo de factura.");
                else
                    this.tipoFactura = value;
            }
        }

        public string Factura
        {
            get
            {
                return Entidades.Factura.ObtenerNombreFactura(this.tipoFactura);
            }
        }

        public string Cuit 
        { 
            get => cuit;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new DatoInvalidoException("Debe ingresar un cuit.");
                else
                    this.cuit = value;
            }
        }

        public static List<ObraSocial> ObrasSociales
        {
            get
            {
                try
                {
                    if (ObraSocial.obrasSociales is null)
                        ObraSocial.obrasSociales = SerializadorXml<List<ObraSocial>>.LeerXml("ObrasSociales");
                }
                catch (Exception ex)
                {
                    ObraSocial.obrasSociales = new List<ObraSocial>();
                    //ObraSocial.OnError.Invoke("No se encontro una lista de obras sociales. Se iniciara una nueva");
                }
                return ObraSocial.obrasSociales;
            }
        }

        public static ObraSocial ObtenerObraSocial(int id)
        {
            ObraSocial os = ObraSocial.ObrasSociales.Where(x => x.id== id).FirstOrDefault();
            return os;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine();
            sb.AppendLine("Nombre:" + this.Nombre);
            sb.AppendLine("Cuit: " + this.Cuit);
            sb.AppendLine("Tipo Factura: " + this.Factura); 
            sb.AppendLine("Detalle: " + this.Detalle);

            return sb.ToString();
        }

        public static bool EliminarObraSocial(int id)
        {
            if (ObraSocial.ObrasSociales.Remove(ObraSocial.ObrasSociales.Where(x => x.Id == id).FirstOrDefault()))
                return ObraSocial.GuardarEnArchivo();
            else
                OnError("No se ha podido eliminar la obra social.");
            return false;
        }

        public bool Guardar()
        {
            ObraSocial.ObrasSociales.Add(this);
            return ObraSocial.GuardarEnArchivo();
        }
        public bool Actualizar()
        {
            ObraSocial.ObrasSociales.Remove(ObraSocial.ObrasSociales.Where(x => x.Id == this.Id).FirstOrDefault());
            return this.Guardar();
        }

        private static bool GuardarEnArchivo()
        {
            return SerializadorXml<List<ObraSocial>>.GuardarXml("ObrasSociales", ObraSocial.ObrasSociales);
        }
    }
}
