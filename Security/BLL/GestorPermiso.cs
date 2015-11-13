using Security.DAL;
using Security.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security.BLL
{
    public class GestorPermiso
    {

        SecurityDAO securityDAO = new SecurityDAO();

        private static GestorPermiso instancia = new GestorPermiso();

        private GestorPermiso() { }

        public static GestorPermiso ObtenerInstancia()
        {
            return instancia;
        }


        public bool CrearPermiso(PermisoBase permiso)
        {

            try
            {
                return securityDAO.InsertarPermiso(permiso);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public bool ActualizarPermiso(GrupoPermiso grupoPermiso)
        {

            try
            {
                return securityDAO.ActualizarPermiso(grupoPermiso);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool EliminarPermiso(GrupoPermiso grupoPermiso)
        {
            try
            {
                return securityDAO.EliminarPermiso(grupoPermiso);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
