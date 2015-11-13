using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security.Excepciones
{
    [Serializable]
    public class LoginFallidoException : Exception
    {

        public LoginFallidoException() { }

        public LoginFallidoException(string mensaje) 
            :base(mensaje) { }

        public LoginFallidoException(string mensaje, Exception innerException)
            :base(mensaje, innerException) { }

    }
}
