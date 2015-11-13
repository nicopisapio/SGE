using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GE_Entities
{
    public class Bitacora
    {

        public Int64 ID { get; set; }
        public string IDUsuario { get; set; }
        public string Tipo { get; set; }
        public string Mensaje { get; set; }
        public DateTime FechaHora { get; set; }

        public override string ToString()
        {
            string linea = "Usuario: ".PadLeft(9, ' ') + IDUsuario + Environment.NewLine;
            linea += "Tipo: ".PadLeft(9, ' ') + Tipo + Environment.NewLine;
            linea += "Mensaje: ".PadLeft(9, ' ') + Mensaje + Environment.NewLine;
            linea += "Fecha: ".PadLeft(9, ' ') + FechaHora.ToString() + Environment.NewLine + Environment.NewLine;

            return linea;
        }
    }
}
