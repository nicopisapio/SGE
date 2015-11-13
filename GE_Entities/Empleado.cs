using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GE_Entities
{
    public class Empleado : IEquatable<Empleado>
    {

        public Int64 DU { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public Cargo Cargo { get; set; }
        public Direccion Direccion { get; set; }
        public string Telefono { get; set; }
        public bool Activo { get; set; }

        public override string ToString()
        {
            return Apellido + ", " + Nombre + " - " + Cargo.Descripcion;
        }

        public bool Equals(Empleado other)
        {
            if (DU == other.DU)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}