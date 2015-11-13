using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GE_Entities
{
    public class Servicio : IEquatable<Servicio>
    {

        public int ID { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public Int16 Estado { get; set; }


        public override string ToString()
        {
            return this.Descripcion;
        }

        public bool Equals(Servicio other)
        {
            if (this.ID == other.ID)
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
