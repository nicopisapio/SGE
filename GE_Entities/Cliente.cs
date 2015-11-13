using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GE_Entities
{
    public class Cliente
    {

        public Int64 DU { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public Direccion Direccion { get; set; }
        public string Telefono { get; set; }

        public override string ToString()
        {
            return Apellido + ", " + Nombre;
        }
    }
}
