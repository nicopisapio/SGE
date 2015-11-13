using GE_Business.Excepciones;
using GE_DAL;
using System;

namespace GE_Business
{
    public class GestorBD
    {

        private static class Tabla
        {
            public static string Usuario = "USUARIO";
            public static string Reserva = "RESERVA";
            public static string Evento = "EVENTO";
        }

        private static class Parametro
        {
            public static string AplicacionBloqueada = "App_Bloqueada";
            public static string UltimaVerificacionIntegridad = "Ult_Verif_Int";
        }

        private BDDAO baseDeDatosDAO = new BDDAO();
        private static GestorBD instancia = new GestorBD();

        private GestorBD() { }

        public static GestorBD ObtenerInstancia()
        {
            return instancia;
        }

        public bool RealizarBackup()
        {

            try
            {
                return baseDeDatosDAO.RealizarBackupBD();
            }
            catch (Exception)
            {
                throw;
            }

        }

        public bool RealizarRestore(string archivoBAK)
        {

            try
            {
                return baseDeDatosDAO.RealizarRestoreBD(archivoBAK);
            }
            catch (Exception)
            {
                throw;
            }

        }

        public bool VerificarIntegridadBD()
        {

            bool resultado = false;

            try
            {
                if (!baseDeDatosDAO.VerificarIntegridadBD(Tabla.Usuario) || !baseDeDatosDAO.VerificarIntegridadBD(Tabla.Reserva) || !baseDeDatosDAO.VerificarIntegridadBD(Tabla.Evento))
                {
                    if (baseDeDatosDAO.ActualizarParametro(Parametro.AplicacionBloqueada, "1"))
                    {
                        throw new AplicacionBloqueadaException("La aplicación ha sido bloqueada debido a un fallo en la integridad de datos.");
                    }

                    throw new IntegridadCorruptaException("Se han encontrado inconsistencias en la verificación de integridad de datos. Es posible que su Base de Datos se encuentre corrupta.");
                }
                else
                {
                    baseDeDatosDAO.ActualizarParametro(Parametro.UltimaVerificacionIntegridad, DateTime.Now.ToString("yyyy-MM-dd"));
                    resultado =  true;
                }

                return resultado;
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        public bool ActualizarDVV(string nombreTabla)
        {

            try
            {
                return baseDeDatosDAO.ActualizarDVVBD(nombreTabla);
            }
            catch (Exception)
            {
                throw;
            }

        }

        public bool HayQueVerificarIntegridad()
        {

            bool resultado = false;

            try
            {
                DateTime ultimaVerificacion;

                string valor = baseDeDatosDAO.ConsultarParametro(Parametro.UltimaVerificacionIntegridad);

                if(DateTime.TryParse(valor, out ultimaVerificacion))
                {
                    if(DateTime.Compare(ultimaVerificacion, Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd"))) < 0)
                    {
                        resultado = true;
                    }
                }
                else
                {
                    //Si no se puede convertir la consulta en DateTime, verificamos igualmente.
                    resultado = true;
                }
            }
            catch (Exception)
            {
                throw;
            }

            return resultado;
        }

        public bool AplicacionBloqueada()
        {
            bool resultado = false;

            try
            {

                string valor = baseDeDatosDAO.ConsultarParametro(Parametro.AplicacionBloqueada);

                if (Convert.ToInt16(valor) == 1)
                {
                    resultado = true;
                }

                return resultado;

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
