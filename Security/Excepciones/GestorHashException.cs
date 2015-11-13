using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security.Excepciones
{
    [Serializable]
    public class GestorHashException : Exception
    {

        public GestorHashException(string metodo, string tipo)
        {
            this.Metodo = metodo;
            this.Tipo = tipo;
        }

        public GestorHashException(string metodo, string tipo, string mensaje)
            :base(mensaje)
        {
            this.Metodo = metodo;
            this.Tipo = tipo;
        }

        public GestorHashException(string metodo, string tipo, string mensaje, Exception innerException)
            :base(mensaje, innerException)
        {
            this.Metodo = metodo;
            this.Tipo = tipo;
        }

        /// <summary>
        /// Devuelve el nombre del método donde se produjo la Excepción.
        /// </summary>
        public string Metodo { get; private set; }

        /// <summary>
        /// Devuelve el tipo de Excepción que se produjo.
        /// </summary>
        public string Tipo { get; set; }
    }
}
