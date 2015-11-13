using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GE_Business.Excepciones
{
    [Serializable]
    public class AplicacionBloqueadaException : Exception
    {

        public AplicacionBloqueadaException(string mensaje)
            : base(mensaje) { }

        public AplicacionBloqueadaException(string mensaje, Exception innerException)
            : base(mensaje, innerException) { }

    }
}
