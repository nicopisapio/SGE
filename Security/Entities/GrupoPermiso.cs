using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security.Entities
{
    public class GrupoPermiso : PermisoBase
    {

        public List<PermisoBase> Permisos { get; set; }

        public GrupoPermiso()
        {
            this.Permisos = new List<PermisoBase>();
        }

        public override bool VerificarPermiso(string descripcion)
        {

            bool bValida = false;

            if (this.Descripcion.Equals(descripcion))
            {
                bValida = true;
            }

            foreach (PermisoBase permiso in Permisos)
            {
                bValida = permiso.VerificarPermiso(descripcion) || bValida;   
            }

            return bValida;
        }

        public override bool TieneHijos()
        {
            return true;
        }

        public override bool AgregarHijo(PermisoBase hijo)
        {
            if (!Permisos.Contains(hijo))
            {
                this.Permisos.Add(hijo);
                return true;
            }
            else
            {
                return false;
            }
        }

        public override bool RemoverHijo(PermisoBase hijo)
        {
            if (Permisos.Contains(hijo))
            {
                this.Permisos.RemoveAll(x => x.ID == hijo.ID);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
