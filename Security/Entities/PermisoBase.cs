using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security.Entities
{
    public abstract class PermisoBase : IEquatable<PermisoBase>
    {

        public int ID { get; set; }
        public string Descripcion { get; set; }
        public int Accion { get; set; }

        public abstract bool VerificarPermiso(string descripcion);
        public abstract bool TieneHijos();
        public abstract bool AgregarHijo(PermisoBase hijo);
        public abstract bool RemoverHijo(PermisoBase hijo);

        public override string ToString()
        {
            return this.Descripcion;
        }

        public bool Equals(PermisoBase other)
        {
            if (this.ID == other.ID)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
