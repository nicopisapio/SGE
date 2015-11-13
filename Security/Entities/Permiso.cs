using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security.Entities
{
    public class Permiso : PermisoBase
    {
        public override bool VerificarPermiso(string descripcion)
        {

            bool bValida = false;

            if (this.Descripcion.Equals(descripcion))
            {
                bValida = true;
            }

            return bValida;
        }

        public override bool TieneHijos()
        {
            return false;
        }

        public override bool AgregarHijo(PermisoBase hijo)
        {
            return false;
        }

        public override bool RemoverHijo(PermisoBase hijo)
        {
            return false;
        }
    }
}
