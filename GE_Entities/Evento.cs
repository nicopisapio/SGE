using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GE_Entities
{
    public class Evento
    {

        public int ID { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        [System.ComponentModel.DisplayName("Precio Bloque Extra")]
        public double PrecioBloqueExtra { get; set; }
        [System.ComponentModel.DisplayName("Cant. Niños")]
        public int CantidadNiños { get; set; }
        [System.ComponentModel.DisplayName("Cant. Adultos")]
        public int CantidadAdultos { get; set; }
        [System.ComponentModel.DisplayName("Precio Decena Extra")]
        public double PrecioDecenaExtra { get; set; }
        public Int16 Estado { get; set; }
        [System.ComponentModel.Browsable(false)]
        public string DVH { get; set; }

        public override string ToString()
        {
            return this.Descripcion;
        }
    }
}
