using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GE_Entities
{
    public class Direccion
    {

        public string Calle { get; set; }
        public int Altura { get; set; }
        public int Piso { get; set; }
        public string Departamento { get; set; }
        public string Localidad { get; set; }


        public override string ToString()
        {
            string aux = Calle + " " + Altura + " - " + Localidad;

            if (!Departamento.Equals("N/A"))
            {
                aux += " - " + Piso + " " + Departamento;
            }

            return aux;
        }
    }
}
