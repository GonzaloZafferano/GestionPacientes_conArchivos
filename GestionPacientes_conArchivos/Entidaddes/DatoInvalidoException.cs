using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DatoInvalidoException : Exception
    {
        /// <summary>
        /// Representa una excepcion ocurrida durante la carga de datos.
        /// </summary>
        /// <param name="message">Mensaje de la excepcion.</param>
        public DatoInvalidoException(string message) : base(message)
        {
        }

        /// <summary>
        /// Representa una excepcion ocurrida durante la carga de datos.
        /// </summary>
        /// <param name="message">Mensaje de la excepcion.</param>
        /// <param name="innerException">Excepcion interna.</param>
        public DatoInvalidoException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}