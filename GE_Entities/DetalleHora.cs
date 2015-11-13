using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GE_Entities
{
    public class DetalleHora
    {

        public Empleado Empleado { get; set; }
        public DateTime FechaHoraInicio { get; set; }
        public DateTime FechaHoraFin { get; set; }
        public double CantidadHorasTrabajadas { get; set; }

        public void CalcularHorasTrabajadas()
        {

            this.CantidadHorasTrabajadas = FechaHoraFin.Subtract(FechaHoraInicio).TotalHours;

        }

    }
}
