using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GE_Entities
{
    public class HorasSemanales
    {

        public Empleado Empleado { get; set; }
        public double Lunes { get; set; }
        public double Martes { get; set; }
        public double Miercoles { get; set; }
        public double Jueves { get; set; }
        public double Viernes { get; set; }
        public double Sabado { get; set; }
        public double Domingo { get; set; }
        public double Total { get; set; }

        public void CalcularTotal()
        {
            Total = Lunes + Martes + Miercoles + Jueves + Viernes + Sabado + Domingo;
        }
    }
}
