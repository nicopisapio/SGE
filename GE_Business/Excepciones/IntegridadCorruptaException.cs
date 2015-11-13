using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GE_Business.Excepciones
{
    [Serializable]
    public class IntegridadCorruptaException : Exception
    {

        public IntegridadCorruptaException(string mensaje)
            : base(mensaje) { }

        public IntegridadCorruptaException(string mensaje, Exception innerException)
            : base(mensaje, innerException) { }

    }
}
