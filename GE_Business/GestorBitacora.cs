using GE_DAL;
using GE_Entities;
using Security.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GE_Business
{
    public class GestorBitacora
    {

        private BitacoraDAO bitacoraDAO = new BitacoraDAO();

        private static GestorBitacora instancia = new GestorBitacora();

        private GestorBitacora() { }

        public static GestorBitacora ObtenerInstancia()
        {
            return instancia;
        }

        public bool GrabarLog(Bitacora bitacora)
        {
            try
            {

                return bitacoraDAO.InsertarBitacoraBD(bitacora);


            }
            catch (Exception)
            {
                throw;
            }
        }

        public void GrabarLogTxt(Bitacora bitacora)
        {

            string archivo = ConfigurationManager.AppSettings["ErrorPath"].ToString();

            if (!Directory.Exists(archivo))
            {
                Directory.CreateDirectory(archivo);
            }

            archivo += "LogError_" + DateTime.Now.ToString("yyyyMMdd") + ".log";

            //string mensajeError = "Usuario: " + bitacora.IDUsuario + Environment.NewLine;
            //mensajeError += "Tipo: " + bitacora.Tipo + Environment.NewLine;
            //mensajeError += "Mensaje: " + bitacora.Mensaje + Environment.NewLine;
            //mensajeError += "Fecha: " + bitacora.FechaHora + Environment.NewLine;

            string mensajeError = bitacora.ToString();

            File.AppendAllText(archivo, mensajeError);

        }

        public List<Bitacora> ConsultarBitacora(string tipo)
        {
            List<Bitacora> registrosBitacora = null;

            try
            {
                registrosBitacora = bitacoraDAO.ConsultarBitacora(tipo);

                return registrosBitacora;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Bitacora> ConsultarBitacora(DateTime fecha)
        {
            List<Bitacora> registrosBitacora = null;

            try
            {
                registrosBitacora = bitacoraDAO.ConsultarBitacora(fecha);

                return registrosBitacora;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Bitacora> ConsultarBitacora(string tipo, DateTime fecha)
        {
            List<Bitacora> registrosBitacora = null;

            try
            {
                registrosBitacora = bitacoraDAO.ConsultarBitacora(tipo, fecha);

                return registrosBitacora;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Bitacora> ConsultarBitacora(string tipo, DateTime fecha, Usuario usuario)
        {
            List<Bitacora> registrosBitacora = null;

            try
            {
                registrosBitacora = bitacoraDAO.ConsultarBitacora(tipo, fecha, usuario);

                return registrosBitacora;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Bitacora> ConsultarBitacora(DateTime fecha, Usuario usuario)
        {
            List<Bitacora> registrosBitacora = null;

            try
            {
                registrosBitacora = bitacoraDAO.ConsultarBitacora(fecha, usuario);

                return registrosBitacora;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
