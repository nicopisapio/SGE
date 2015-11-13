using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GE_Entities
{
    public class Cargo
    {

        public int ID { get; set; }
        public string Descripcion { get; set; }
        public double ValorPorHora { get; set; }

        public override string ToString()
        {
            return Descripcion;
        }

    }
}
