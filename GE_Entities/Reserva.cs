using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GE_Entities
{
    public class Reserva
    {

        public Reserva()
        {
            Empleados = new List<Empleado>();
            Servicios = new List<Servicio>();
            Excedentes = new List<Excedente>();
        }

        public Int64 ID { get; set; }
        public Evento Evento { get; set; }
        public Cliente Cliente { get; set; }
        public List<Empleado> Empleados { get; set; }
        public List<Servicio> Servicios { get; set; }
        public List<Excedente> Excedentes { get; set; }
        [System.ComponentModel.DisplayName("Cant. Adultos")]
        public int CantidadAdultos { get; set; }
        [System.ComponentModel.DisplayName("Cant. Niños")]
        public int CantidadNiños { get; set; }
        [System.ComponentModel.DisplayName("Mto. Pagado")]
        public double MontoPagado { get; set; }
        [System.ComponentModel.DisplayName("Mto. Total")]
        public double MontoTotal { get; set; }
        [System.ComponentModel.DisplayName("Fecha Hora Inicio")]
        public DateTime FechaHoraInicio { get; set; }
        [System.ComponentModel.DisplayName("Fecha Hora Fin")]
        public DateTime FechaHoraFin { get; set; }
        [System.ComponentModel.DisplayName("Cant. Bebidas")]
        public int CantidadBebidas { get; set; }
        public string Estado { get; set; }
        public string Usuario { get; set; }
        [System.ComponentModel.DisplayName("Fecha Hora")]
        public DateTime FechaHora { get; set; }
        [System.ComponentModel.Browsable(false)]
        public string DVH { get; set; }

        public void AgregarServicio(Servicio servicio)
        {
            if (!Servicios.Contains(servicio))
            {
                Servicios.Add(servicio);
            }
        }

        public void QuitarServicio(Servicio servicio)
        {
            if (Servicios.Contains(servicio))
            {
                Servicios.Remove(servicio);
            }
        }

        public void AgregarExcedente(Excedente excedente)
        {
            Excedentes.Add(excedente);
        }
    }
}
