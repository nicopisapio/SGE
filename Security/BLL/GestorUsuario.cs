using Security.DAL;
using Security.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security.BLL
{
    public class GestorUsuario
    {

        SecurityDAO securityDAO = new SecurityDAO();

        private static GestorUsuario instancia = new GestorUsuario();

        private GestorUsuario() { }

        public static GestorUsuario ObtenerInstancia()
        {
            return instancia;
        }

        public List<Usuario> ConsultarUsuarios()
        {

            List<Usuario> listaUsuarios = null;

            try
            {
                listaUsuarios = securityDAO.TraerTodosUsuarios();
            }
            catch (Exception e)
            {
                
                throw e;

            }

            return listaUsuarios;
        }

        public List<GrupoPermiso> ConsultarPermisos()
        {

            List<GrupoPermiso> listaPermisos = null;

            try
            {
                listaPermisos = securityDAO.TraerGruposPermiso();
            }
            catch (Exception e)
            {
                throw e;
            }

            return listaPermisos;
        }

        public List<PermisoBase> ConsultarTodosPermisos()
        {

            List<PermisoBase> listaPermisos = null;

            try
            {
                listaPermisos = securityDAO.TraerTodosPermisos();
            }
            catch (Exception e)
            {
                throw e;
            }

            return listaPermisos;
        }

        public bool CrearUsuario(Usuario usuario)
        {
            try
            {
                return securityDAO.InsertarUsuario(usuario);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public bool ActualizarUsuario(Usuario usuario)
        {
            try
            {
                return securityDAO.ActualizarUsuario(usuario);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool EliminarUsuario(Usuario usuario)
        {
            try
            {
                return securityDAO.EliminarUsuario(usuario);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
