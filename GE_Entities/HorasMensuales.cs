using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GE_Entities
{
    public class HorasMensuales
    {

        public Empleado Empleado { get; set; }
        public double Periodo1 { get; set; }
        public double Periodo2 { get; set; }
        public double Periodo3 { get; set; }
        public double Periodo4 { get; set; }
        public double Periodo5 { get; set; }
        public double Total { get; set; }
        public double TotalPagar { get; set; }

        public void CalcularTotal()
        {
            Total = Periodo1 + Periodo2 + Periodo3 + Periodo4 + Periodo5;
            TotalPagar = Total * Empleado.Cargo.ValorPorHora;
        }

    }
}
