using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security.Entities
{
    public class Usuario
    {

        public string Nombre { get; set; }
        [System.ComponentModel.Browsable(false)]
        public string Clave { get; set; }
        public PermisoBase Perfil { get; set; }
        public Idioma Idioma { get; set; }
        [System.ComponentModel.Browsable(false)]
        public string DVH { get; set; }

    }
}
