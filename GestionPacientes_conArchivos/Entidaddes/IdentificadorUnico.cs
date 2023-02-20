using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class IdentificadorUnico
    {
        private const string rutaRelativaArchivo = "Ids/UltimoIdObraSocial";
        private static IdentificadorUnico identificador;
        private static int id;

        /// <summary>
        /// Constructor estatico de la clase IdentificadorUnico. Inicializa un objeto de tipo IdentificadorUnico.
        /// Lee el archivo de Ids y los carga en el sistema.
        /// </summary>
        static IdentificadorUnico()
        {
            if (!IdentificadorUnico.LeerArchivoDeIds())
            {
                IdentificadorUnico.identificador = new IdentificadorUnico();
                IdentificadorUnico.Identificador.Id = 0;
            }
        }

        /// <summary>
        /// Retorna el objeto estatico que contiene el ultimo id de las notas.
        /// </summary>
        public static IdentificadorUnico Identificador
        {
            get
            {
                return IdentificadorUnico.identificador;
            }
            private set
            {
                IdentificadorUnico.identificador = value;
            }
        }

        /// <summary>
        /// Propiedad para Serializacion. Obtiene y setea el id de la ultima nota. 
        /// </summary>
        public int Id
        {
            get
            {
                return IdentificadorUnico.id;
            }
            set
            {
                IdentificadorUnico.id = value;
            }
        }

        /// <summary>
        /// Obtiene un Id Unico para una Nota
        /// </summary>
        /// <returns>Id Unico para una Nota</returns>
        /// <exception cref="Exception">Error externo.</exception>
        public int ObtenerIdUnico()
        {
            int retorno = ++this.Id;

            try
            {
                this.GuardarArchivo();
            }
            catch (Exception ex) 
            { }

            return retorno;
        }

        /// <summary>
        /// Guarda los ids en un archivo.
        /// </summary>
        /// <exception cref="Exception">Error externo.</exception>
        private bool GuardarArchivo()
        {
            try
            {
                return SerializadorXml<IdentificadorUnico>.GuardarXml(IdentificadorUnico.rutaRelativaArchivo, IdentificadorUnico.Identificador);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error externo al sistema al intentar serializar los Ids. Clase IdentificadorUnico. Revisar InnerException", ex);
            }
        }

        /// <summary>
        /// Obtiene los datos de IDS que estan respaldados en un archivo, y lo carga al sistema.
        /// </summary>
        /// <returns>True si leyo el archivo sin problemas, caso contrario False.</returns>
        private static bool LeerArchivoDeIds()
        {
            try
            {
                IdentificadorUnico.Identificador =  SerializadorXml<IdentificadorUnico>.LeerXml(IdentificadorUnico.rutaRelativaArchivo);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
