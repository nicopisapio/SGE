using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GE_Entities
{
    public class Booking
    {

        public Booking(Int64 reserva, string cliente, DateTime inicio, DateTime fin)
        {
            this.IdReserva = reserva;
            this.Cliente = cliente;
            this.HoraInicio = inicio;
            this.HoraFin = fin;
        }

        [System.ComponentModel.DisplayName("ID Reserva")]
        public Int64 IdReserva { get; set; }
        public string Cliente { get; set; }
        [System.ComponentModel.DisplayName("Hora Inicio")]
        public DateTime HoraInicio { get; set; }
        [System.ComponentModel.DisplayName("Hora Fin")]
        public DateTime HoraFin { get; set; }

    }
}
