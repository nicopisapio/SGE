using Security.DAL;
using Security.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security.BLL
{
    public class GestorIdioma
    {
        SecurityDAO securityDAO = new SecurityDAO();

        private static GestorIdioma instancia = new GestorIdioma();

        private GestorIdioma() { }

        public static GestorIdioma ObtenerInstancia()
        {
            return instancia;
        }

        public List<Idioma> ConsultarIdiomas()
        {

            List<Idioma> listaIdiomas = null;

            try
            {
                listaIdiomas = securityDAO.TraerTodosIdiomas();

                return listaIdiomas;

            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool CambiarIdioma(Idioma idioma, Usuario usuario)
        {
            try
            {

                usuario.Idioma = idioma;
                usuario.DVH = GestorHash.ObtenerInstancia().GenerarHashDatos(usuario);

                return securityDAO.ActualizarUsuario(usuario);

            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Componente> TraerLeyendasTodas(string idIdioma)
        {

            try
            {
                return securityDAO.TraerLeyendasTodas(idIdioma);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Componente> TraerLeyendas(string form, string idIdioma)
        {

            try
            {
                return securityDAO.TraerLeyendas(form, idIdioma);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Componente TraerLeyenda(string idIdioma, int idLeyenda)
        {

            try
            {
                return securityDAO.TraerLeyenda(idIdioma, idLeyenda);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void ModificarConfig(Idioma idioma)
        {
            try
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings["Idioma"].Value = idioma.ID;
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool InsertarNuevoIdioma(List<Componente> componentes)
        {
            try
            {
                bool resultado = false;

                resultado = securityDAO.InsertarIdioma(componentes.First().Idioma);

                foreach (Componente componente in componentes)
                {

                    resultado = securityDAO.InsertarTraduccion(componente) && resultado;

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
