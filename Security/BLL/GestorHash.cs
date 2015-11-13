using Security.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Security.Excepciones;

namespace Security.BLL
{
    public class GestorHash
    {
        private const int tamañoValorSal = 4;
        private static GestorHash instancia = new GestorHash();

        private GestorHash() { }

        public static GestorHash ObtenerInstancia()
        {
            return instancia;
        }

        private string GenerarValorSal()
        {

            try
            {

                UnicodeEncoding utf16 = new UnicodeEncoding();

                if (utf16 != null)
                {

                    Random random = new Random(unchecked((int)DateTime.Now.Ticks));

                    if (random != null)
                    {

                        byte[] bytesValorSal = new byte[tamañoValorSal];

                        random.NextBytes(bytesValorSal);

                        string valorSal = utf16.GetString(bytesValorSal);

                        return valorSal;
                    }
                }

                return null;

            }
            catch (Exception ex)
            {
                throw new GestorHashException("GenerarValorSal", "General: " + ex.GetType().ToString(), ex.Message, ex);
            }
        }

        public string HashPassword(string password, string valorSal = null)
        {

            try
            {

                UnicodeEncoding encoding = new UnicodeEncoding();
                HashAlgorithm hash = HashAlgorithm.Create("SHA256");

                if (password != null && hash != null && encoding != null)
                {

                    if (valorSal == null)
                    {
                        valorSal = GenerarValorSal();
                    }

                    byte[] bytesValorSal = new byte[tamañoValorSal];

                    bytesValorSal = Encoding.Unicode.GetBytes(valorSal);

                    byte[] bytesDatos = new byte[tamañoValorSal + encoding.GetByteCount(password)];
                    byte[] bytesPassword = encoding.GetBytes(password);

                    bytesValorSal.CopyTo(bytesDatos, 0);
                    bytesPassword.CopyTo(bytesDatos, tamañoValorSal);

                    byte[] bytesHash = hash.ComputeHash(bytesDatos);

                    string passwordHasheado = valorSal;

                    foreach (byte hexa in bytesHash)
                    {
                        passwordHasheado += hexa.ToString("X2", CultureInfo.InvariantCulture.NumberFormat);
                    }

                    return passwordHasheado;
                }

                return null;

            }
            catch (Exception ex)
            {
                throw new GestorHashException("HashPassword", "General: " + ex.GetType().ToString(), ex.Message, ex);
            }
        }

        public bool VerificarPasswordHash(string passIngresado, string passUsuario)
        {

            try
            {

                int salLength = 2;

                if (string.IsNullOrEmpty(passUsuario) || string.IsNullOrEmpty(passIngresado) || passUsuario.Length < salLength)
                {
                    return false;
                }

                string valorSal = passUsuario.Substring(0, salLength);

                string passwordHasheado = HashPassword(passIngresado, valorSal);

                if (passUsuario.Equals(passwordHasheado, StringComparison.Ordinal)) return true;

                return false;

            }
            catch (Exception ex)
            {
                throw new GestorHashException("VerificarPasswordHash", "General: " + ex.GetType().ToString(), ex.Message, ex);
            }
        }
        
        public string GenerarHashDatos(Usuario usuario)
        {

            try
            {
                byte[] bytesDatos;

                UnicodeEncoding ue = new UnicodeEncoding();
                HashAlgorithm hash = HashAlgorithm.Create("SHA256");

                byte[] bytesUsuario = ue.GetBytes(usuario.Nombre);
                byte[] bytesClave = ue.GetBytes(usuario.Clave);
                byte[] bytesPerfil = BitConverter.GetBytes(usuario.Perfil.ID);
                byte[] bytesIdioma = ue.GetBytes(usuario.Idioma.ID);

                bytesDatos = new byte[bytesUsuario.Length + bytesClave.Length + bytesPerfil.Length + bytesIdioma.Length];
                bytesUsuario.CopyTo(bytesDatos, 0);
                bytesClave.CopyTo(bytesDatos, bytesUsuario.Length);
                bytesPerfil.CopyTo(bytesDatos, bytesClave.Length);
                bytesIdioma.CopyTo(bytesDatos, bytesPerfil.Length);

                byte[] bytesHash = hash.ComputeHash(bytesDatos);

                string hashDatos = "";

                foreach (byte hexdigit in bytesHash)
                {
                    hashDatos += hexdigit.ToString("X2", CultureInfo.InvariantCulture.NumberFormat);
                }

                return hashDatos;
                
            }
            catch (Exception ex)
            {
                throw new GestorHashException("GenerarHashDatos", "General: " + ex.GetType().ToString(), ex.Message, ex);
            }

        }

        public string GenerarHashDatos(List<string> datos)
        {

            try
            {

                byte[] bytesDatos;

                UnicodeEncoding ue = new UnicodeEncoding();
                HashAlgorithm hash = HashAlgorithm.Create("SHA256");

                bytesDatos = datos.SelectMany(d => ue.GetBytes(d)).ToArray();

                byte[] bytesHash = hash.ComputeHash(bytesDatos);

                string hashDatos = "";

                foreach (byte hexdigit in bytesHash)
                {
                    hashDatos += hexdigit.ToString("X2", CultureInfo.InvariantCulture.NumberFormat);
                }

                return hashDatos;

            }
            catch (Exception ex)
            {
                throw new GestorHashException("GenerarHashDatos", "General: " + ex.GetType().ToString(), ex.Message, ex);
            }

        }
    }
}
