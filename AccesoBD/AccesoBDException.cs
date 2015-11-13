using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoBD
{
    [Serializable]
    public class AccesoBDException : Exception
    {

        public AccesoBDException(string conString)
            : base() 
        {
            this.ConnectionString = conString;
        }

        public AccesoBDException(string conString, string mensaje)
            : base(mensaje) 
        {
            this.ConnectionString = conString;
        }

        public AccesoBDException(string conString, string mensaje, Exception innerException)
            : base(mensaje, innerException) 
        {
            this.ConnectionString = conString;
        }

        public string ConnectionString { get; private set; }
    }
}
