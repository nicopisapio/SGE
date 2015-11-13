using System;
using Security.Entities;
using Security.DAL;
using Security.Excepciones;

namespace Security.BLL
{
    public class GestorLogin
    {

        SecurityDAO usuarioDAO = new SecurityDAO();
        
        private static GestorLogin instancia = new GestorLogin();

        public Usuario Usuario { get; protected set; }

        private GestorLogin() { }

        public static GestorLogin ObtenerInstancia()
        {
            return instancia;
        }

        public bool IniciarSesion(string userName, string userPassword)
        {

            try
            {

                Usuario user = usuarioDAO.TraerUsuario(userName);

                if (user != null && GestorHash.ObtenerInstancia().VerificarPasswordHash(userPassword, user.Clave))
                {

                    this.Usuario = user;
                    return true;
                }
                else
                {
                    throw new LoginFallidoException("Usuario o Password incorrecto.");
                }

            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool IniciarSesion(string userName, string userPassword, bool desconectado)
        {

            try
            {

                if (desconectado)
                {
                    Usuario user = usuarioDAO.TraerUsuarioConfig(userName);

                    if (user != null && GestorHash.ObtenerInstancia().VerificarPasswordHash(userPassword, user.Clave))
                    {

                        this.Usuario = user;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }

                return false;

            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool VerificarPermiso(string IdPermiso)
        {

            if (this.Usuario.Perfil.VerificarPermiso(IdPermiso))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void RecargarUsuario()
        {
            try
            {

                Usuario user = usuarioDAO.TraerUsuario(Usuario.Nombre);

                Usuario = user;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void CerrarSesion()
        {

            this.Usuario = null;
        }

    }
}
