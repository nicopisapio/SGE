using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GE_DAL.Excepciones
{
    [Serializable]
    public class DALException : Exception
    {

        public DALException(string clase, string metodo, string tipo)
        {
            this.Clase = clase;
            this.Metodo = metodo;
            this.Tipo = tipo;
        }

        public DALException(string clase, string metodo, string tipo, string mensaje)
            :base(mensaje)
        {
            this.Clase = clase;
            this.Metodo = metodo;
            this.Tipo = tipo;
        }

        public DALException(string clase, string metodo, string tipo, string mensaje, Exception innerException)
            :base(mensaje, innerException)
        {
            this.Clase = clase;
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

        /// <summary>
        /// Devuelve el nombre de la clase donde se produjo la Excepció.
        /// </summary>
        public string Clase { get; set; }

    }
}
