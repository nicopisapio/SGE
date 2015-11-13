using GE_Entities;
using Security.BLL;
using Security.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GE_Business
{
    public class ErrorManager
    {

        private static ErrorManager instancia = new ErrorManager();

        private ErrorManager() { }

        public static ErrorManager ObtenerInstancia()
        {
            return instancia;
        }

        public void LoguearErrorBD(string mensaje)
        {

            Usuario usuario = GestorLogin.ObtenerInstancia().Usuario;

            if (usuario != null)
            {
                Bitacora bitacora = new Bitacora();
                bitacora.IDUsuario = usuario.Nombre;
                bitacora.Tipo = "ERROR";
                bitacora.Mensaje = mensaje;
                bitacora.FechaHora = DateTime.Now;

                if (!GestorBitacora.ObtenerInstancia().GrabarLog(bitacora))
                {
                    GestorBitacora.ObtenerInstancia().GrabarLogTxt(bitacora);
                }

            }
            else
            {
                Bitacora bitacora = new Bitacora();
                bitacora.IDUsuario = "Sistema";
                bitacora.Tipo = "ERROR";
                bitacora.Mensaje = mensaje;
                bitacora.FechaHora = DateTime.Now;

                GestorBitacora.ObtenerInstancia().GrabarLogTxt(bitacora);
            }
        }
        
        public void LoguearErrorBD(Exception ex)
        {

            Usuario usuario = GestorLogin.ObtenerInstancia().Usuario;

            if (usuario != null)
            {
                Bitacora bitacora = new Bitacora();
                bitacora.IDUsuario = usuario.Nombre;
                bitacora.Tipo = "ERROR";
                bitacora.Mensaje = ex.Message;
                bitacora.FechaHora = DateTime.Now;

                if (!GestorBitacora.ObtenerInstancia().GrabarLog(bitacora))
                {
                    GestorBitacora.ObtenerInstancia().GrabarLogTxt(bitacora);
                }

            }
            else
            {
                Bitacora bitacora = new Bitacora();
                bitacora.IDUsuario = "Sistema";
                bitacora.Tipo = "ERROR";
                bitacora.Mensaje = ex.Message;
                bitacora.FechaHora = DateTime.Now;

                GestorBitacora.ObtenerInstancia().GrabarLogTxt(bitacora);
            }
        }

        public void LoguearErrorTxt(Exception ex)
        {

            Usuario usuario = GestorLogin.ObtenerInstancia().Usuario;

            Bitacora bitacora = new Bitacora();
            bitacora.IDUsuario = usuario != null ? usuario.Nombre : "Sistema";
            bitacora.Tipo = "ERROR";
            bitacora.Mensaje = ex.Message;
            bitacora.FechaHora = DateTime.Now;

            GestorBitacora.ObtenerInstancia().GrabarLogTxt(bitacora);
        }

        public string LoguearGenerarMensajeError(Exception ex, int idMensaje, string idIdioma)
        {

            try
            {

                Usuario usuario = GestorLogin.ObtenerInstancia().Usuario;

                if (usuario != null)
                {
                    Bitacora bitacora = new Bitacora();
                    bitacora.IDUsuario = usuario.Nombre;
                    bitacora.Tipo = "ERROR";
                    bitacora.Mensaje = ex.Message;
                    bitacora.FechaHora = DateTime.Now;

                    if(!GestorBitacora.ObtenerInstancia().GrabarLog(bitacora))
                    {
                        GestorBitacora.ObtenerInstancia().GrabarLogTxt(bitacora);
                    }
                    
                }
                else
                {
                    Bitacora bitacora = new Bitacora();
                    bitacora.IDUsuario = "Sistema";
                    bitacora.Tipo = "ERROR";
                    bitacora.Mensaje = ex.Message;
                    bitacora.FechaHora = DateTime.Now;

                    GestorBitacora.ObtenerInstancia().GrabarLogTxt(bitacora);
                }

                Componente componente = GestorIdioma.ObtenerInstancia().TraerLeyenda(idIdioma, idMensaje);

                if (componente != null)
                {
                    return componente.Traduccion;
                }
                else
                {
                    return ex.Message;
                }

            }
            catch (Exception)
            {
                return ex.Message;
            }

        }

        public string LoguearGenerarMensajeError(string mensaje, int idMensaje, string idIdioma)
        {


            try
            {

                Usuario usuario = GestorLogin.ObtenerInstancia().Usuario;

                if (usuario != null)
                {
                    Bitacora bitacora = new Bitacora();
                    bitacora.IDUsuario = usuario.Nombre;
                    bitacora.Tipo = "ERROR";
                    bitacora.Mensaje = mensaje;
                    bitacora.FechaHora = DateTime.Now;

                    if (!GestorBitacora.ObtenerInstancia().GrabarLog(bitacora))
                    {
                        GestorBitacora.ObtenerInstancia().GrabarLogTxt(bitacora);
                    }

                }
                else
                {
                    Bitacora bitacora = new Bitacora();
                    bitacora.IDUsuario = "Sistema";
                    bitacora.Tipo = "ERROR";
                    bitacora.Mensaje = mensaje;
                    bitacora.FechaHora = DateTime.Now;

                    GestorBitacora.ObtenerInstancia().GrabarLogTxt(bitacora);
                }

                Componente componente = GestorIdioma.ObtenerInstancia().TraerLeyenda(idIdioma, idMensaje);

                if (componente != null)
                {
                    return componente.Traduccion;
                }
                else
                {
                    return mensaje;
                }
            }
            catch (Exception)
            {
                return mensaje;
            }

        }

    }
}
