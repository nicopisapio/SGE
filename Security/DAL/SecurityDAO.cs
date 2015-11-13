using System.Data;
using Security.Entities;
using AccesoBD;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using Security.Excepciones;

namespace Security.DAL
{
    public class SecurityDAO
    {
        
        public Usuario TraerUsuario(string idUsuario)
        {

            try
            {
                Usuario usuario = null;

                using (SqlConnection conexion = Conexion.ObtenerInstancia().CrearConexionSQL())
                {

                    using (SqlCommand comando = conexion.CreateCommand())
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.CommandText = "SPS_Usuario";
                        comando.Parameters.Add(new SqlParameter("@Id_Usuario", idUsuario));

                        comando.Connection.Open();

                        SqlDataReader dataReader = comando.ExecuteReader(CommandBehavior.CloseConnection);

                        while (dataReader.Read())
                        {
                            usuario = new Usuario();

                            usuario.Nombre = dataReader["ID_USUARIO"].ToString();
                            usuario.Clave = dataReader["CLAVE"].ToString();
                            usuario.Perfil = TraerPermiso(Convert.ToInt16(dataReader["PERFIL"]));
                            usuario.Idioma = TraerIdioma(dataReader["IDIOMA"].ToString());

                        }
                    }

                }

                return usuario;
            }
            catch (AccesoBDException ex)
            {
                throw new SecurityDAOException("TraerUsuario", "AccesoBD", ex.Message, ex);
            }
            catch (SqlException ex)
            {
                throw new SecurityDAOException("TraerUsuario", "SQL", ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new SecurityDAOException("TraerUsuario", "General: " + ex.GetType().ToString(), ex.Message, ex);
            }

        }

        public Usuario TraerUsuarioConfig(string nombreUsuario)
        {

            try
            {
                Usuario usuario = new Usuario();

                usuario.Nombre = ConfigurationManager.AppSettings["UsuarioEmergencia"].ToString();
                usuario.Clave = ConfigurationManager.AppSettings["PasswordEmergencia"].ToString();

                if (usuario.Nombre.Equals(nombreUsuario))
                {
                    return usuario;
                }
                else
                {
                    return null;
                }
            }
            catch (AccesoBDException ex)
            {
                throw new SecurityDAOException("TraerUsuarioConfig", "AccesoBD", ex.Message, ex);
            }
            catch (SqlException ex)
            {
                throw new SecurityDAOException("TraerUsuarioConfig", "SQL", ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new SecurityDAOException("TraerUsuarioConfig", "General: " + ex.GetType().ToString(), ex.Message, ex);
            }

        }
        
        public PermisoBase TraerPermiso(int IdPermiso)
        {

            try
            {

                PermisoBase permiso = null;

                using (SqlConnection conexion = Conexion.ObtenerInstancia().CrearConexionSQL())
                {
                    using (SqlCommand comando = conexion.CreateCommand())
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.CommandText = "SPS_Permiso";
                        comando.Parameters.Add(new SqlParameter("@Id_Permiso", IdPermiso));

                        using (SqlDataAdapter dataAdapter = new SqlDataAdapter(comando))
                        {

                            DataTable dt = new DataTable();

                            dataAdapter.Fill(dt);

                            if (dt.Rows.Count > 0)
                            {

                                if (Convert.ToInt16(dt.Rows[0]["ACCION"]) == 0)
                                {
                                    permiso = new GrupoPermiso();
                                }
                                else
                                {
                                    permiso = new Permiso();
                                }

                                permiso.ID = Convert.ToInt16(dt.Rows[0]["ID"]);
                                permiso.Descripcion = dt.Rows[0]["DESCRIPCION"].ToString();

                                if (permiso.TieneHijos())
                                {
                                    List<PermisoBase> permisos = TraerPermisosHijos(permiso.ID);

                                    if (permiso != null)
                                    {
                                        foreach (PermisoBase per in permisos)
                                        {
                                            permiso.AgregarHijo(per);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

                return permiso;

            }
            catch (AccesoBDException ex)
            {
                throw new SecurityDAOException("TraerPermisos", "AccesoBD", ex.Message, ex);
            }
            catch (SqlException ex)
            {
                throw new SecurityDAOException("TraerPermisos", "SQL", ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new SecurityDAOException("TraerPermisos", "General: " + ex.GetType().ToString(), ex.Message, ex);
            }

        }

        public List<PermisoBase> TraerPermisosHijos(int IdPermiso)
        {

            try
            {
                List<PermisoBase> hijos = null;
                PermisoBase permisoHijo = null;

                using (SqlConnection conexion = Conexion.ObtenerInstancia().CrearConexionSQL())
                {
                    using (SqlCommand comando = conexion.CreateCommand())
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.CommandText = "SPS_PermisosHijos";
                        comando.Parameters.Add(new SqlParameter("@PermisoPadre", IdPermiso));

                        using (SqlDataAdapter dataAdapter = new SqlDataAdapter(comando))
                        {

                            DataTable dt = new DataTable();

                            dataAdapter.Fill(dt);

                            if (dt.Rows.Count > 0)
                            {

                                hijos = new List<PermisoBase>();

                                foreach (DataRow row in dt.Rows)
                                {

                                    if (Convert.ToInt16(row["ACCION"]) == 0)
                                    {
                                        permisoHijo = new GrupoPermiso();
                                    }
                                    else
                                    {
                                        permisoHijo = new Permiso();
                                    }

                                    permisoHijo.ID = Convert.ToInt16(row["ID"]);
                                    permisoHijo.Descripcion = row["DESCRIPCION"].ToString();

                                    if (permisoHijo.TieneHijos())
                                    {
                                        List<PermisoBase> permisos = TraerPermisosHijos(permisoHijo.ID);

                                        foreach (PermisoBase per in permisos)
                                        {
                                            permisoHijo.AgregarHijo(per);
                                        }
                                    }

                                    hijos.Add(permisoHijo);

                                }
                            }
                        }
                    }
                }

                return hijos;

            }
            catch (AccesoBDException ex)
            {
                throw new SecurityDAOException("TraerPermisosHijos", "AccesoBD", ex.Message, ex);
            }
            catch (SqlException ex)
            {
                throw new SecurityDAOException("TraerPermisosHijos", "SQL", ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new SecurityDAOException("TraerPermisosHijos", "General: " + ex.GetType().ToString(), ex.Message, ex);
            }

        }

        public Idioma TraerIdioma(string IdIdioma)
        {

            try
            {
                Idioma idioma = null;

                using (SqlConnection conexion = Conexion.ObtenerInstancia().CrearConexionSQL())
                {
                    using (SqlCommand comando = conexion.CreateCommand())
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.CommandText = "SPS_Idioma";
                        comando.Parameters.Add(new SqlParameter("@Id_Idioma", IdIdioma));

                        comando.Connection.Open();

                        SqlDataReader dataReader = comando.ExecuteReader(CommandBehavior.CloseConnection);

                        while (dataReader.Read())
                        {

                            idioma = new Idioma();

                            idioma.ID = dataReader["ID"].ToString();
                            idioma.Nombre = dataReader["NOMBRE"].ToString();

                        }

                        dataReader.Close();
                    }
                }

                return idioma;

            }
            catch (AccesoBDException ex)
            {
                throw new SecurityDAOException("TraerIdioma", "AccesoBD", ex.Message, ex);
            }
            catch (SqlException ex)
            {
                throw new SecurityDAOException("TraerIdioma", "SQL", ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new SecurityDAOException("TraerIdioma", "General: " + ex.GetType().ToString(), ex.Message, ex);
            }
        }

        public List<Usuario> TraerTodosUsuarios()
        {
            try
            {
                List<Usuario> usuarios = new List<Usuario>();
                Usuario usuario = null;

                using (SqlConnection conexion = Conexion.ObtenerInstancia().CrearConexionSQL())
                {

                    using (SqlCommand comando = conexion.CreateCommand())
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.CommandText = "SPS_Usuario_Todos";

                        comando.Connection.Open();

                        SqlDataReader dataReader = comando.ExecuteReader(CommandBehavior.CloseConnection);

                        while (dataReader.Read())
                        {
                            usuario = new Usuario();

                            usuario.Nombre = dataReader["ID_USUARIO"].ToString();
                            usuario.Clave = dataReader["CLAVE"].ToString();
                            usuario.Perfil = TraerPermiso(Convert.ToInt16(dataReader["PERFIL"]));
                            usuario.Idioma = TraerIdioma(dataReader["IDIOMA"].ToString());
                            usuario.DVH = dataReader["DVH"].ToString();

                            usuarios.Add(usuario);
                        }
                    }

                }

                return usuarios;

            }
            catch (AccesoBDException ex)
            {
                throw new SecurityDAOException("TraerTodosUsuarios", "AccesoBD", ex.Message, ex);
            }
            catch (SqlException ex)
            {
                throw new SecurityDAOException("TraerTodosUsuarios", "SQL", ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new SecurityDAOException("TraerTodosUsuarios", "General: " + ex.GetType().ToString(), ex.Message, ex);
            }
        }

        public List<GrupoPermiso> TraerGruposPermiso()
        {

            try
            {
                List<GrupoPermiso> permisos = new List<GrupoPermiso>();
                GrupoPermiso permiso = null;

                using (SqlConnection conexion = Conexion.ObtenerInstancia().CrearConexionSQL())
                {

                    using (SqlCommand comando = conexion.CreateCommand())
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.CommandText = "SPS_Grupos_Permiso";

                        comando.Connection.Open();

                        SqlDataReader dataReader = comando.ExecuteReader(CommandBehavior.CloseConnection);

                        while (dataReader.Read())
                        {
                            permiso = new GrupoPermiso();

                            permiso.ID = Convert.ToInt16(dataReader["ID"]);
                            permiso.Descripcion = dataReader["DESCRIPCION"].ToString();
                            permiso.Accion = Convert.ToInt16(dataReader["ACCION"]);

                            if (permiso.TieneHijos())
                            {
                                List<PermisoBase> permisosHijos = TraerPermisosHijos(permiso.ID);

                                if (permisosHijos != null)
                                {
                                    foreach (PermisoBase per in permisosHijos)
                                    {
                                        permiso.AgregarHijo(per);
                                    }
                                }
                            }

                            permisos.Add(permiso);
                        }
                    }

                }

                return permisos;
            }
            catch (AccesoBDException ex)
            {
                throw new SecurityDAOException("TraerGruposPermiso", "AccesoBD", ex.Message, ex);
            }
            catch (SqlException ex)
            {
                throw new SecurityDAOException("TraerGruposPermiso", "SQL", ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new SecurityDAOException("TraerGruposPermiso", "General: " + ex.GetType().ToString(), ex.Message, ex);
            }
        }

        public List<PermisoBase> TraerTodosPermisos()
        {

            try
            {
                
                List<PermisoBase> permisos = new List<PermisoBase>();
                PermisoBase permiso = null;

                using (SqlConnection conexion = Conexion.ObtenerInstancia().CrearConexionSQL())
                {

                    using (SqlCommand comando = conexion.CreateCommand())
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.CommandText = "SPS_Permiso_Todos";

                        using (SqlDataAdapter dataAdapter = new SqlDataAdapter(comando))
                        {

                            DataTable dt = new DataTable();

                            dataAdapter.Fill(dt);

                            if (dt.Rows.Count > 0)
                            {

                                foreach (DataRow row in dt.Rows)
                                {

                                    if (Convert.ToInt16(row["ACCION"]) == 0)
                                    {
                                        permiso = new GrupoPermiso();
                                    }
                                    else
                                    {
                                        permiso = new Permiso();
                                    }

                                    permiso.ID = Convert.ToInt16(row["ID"]);
                                    permiso.Descripcion = row["DESCRIPCION"].ToString();

                                    if (permiso.TieneHijos())
                                    {
                                        List<PermisoBase> permisosHijos = TraerPermisosHijos(permiso.ID);

                                        if (permisosHijos != null)
                                        {
                                            foreach (PermisoBase per in permisosHijos)
                                            {
                                                permiso.AgregarHijo(per);
                                            }
                                        }
                                    }

                                    permisos.Add(permiso);
                                }

                            }
                        }
                    }

                }

                return permisos;
            }
            catch (AccesoBDException ex)
            {
                throw new SecurityDAOException("TraerTodosPermisos", "AccesoBD", ex.Message, ex);
            }
            catch (SqlException ex)
            {
                throw new SecurityDAOException("TraerTodosPermisos", "SQL", ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new SecurityDAOException("TraerTodosPermisos", "General: " + ex.GetType().ToString(), ex.Message, ex);
            }
        }

        public List<Idioma> TraerTodosIdiomas()
        {

            try
            {
                List<Idioma> idiomas = new List<Idioma>();
                Idioma idioma = null;

                using (SqlConnection conexion = Conexion.ObtenerInstancia().CrearConexionSQL())
                {

                    using (SqlCommand comando = conexion.CreateCommand())
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.CommandText = "SPS_Idioma_Todos";

                        comando.Connection.Open();

                        SqlDataReader dataReader = comando.ExecuteReader(CommandBehavior.CloseConnection);

                        while (dataReader.Read())
                        {
                            idioma = new Idioma();

                            idioma.ID = dataReader["ID"].ToString();
                            idioma.Nombre = dataReader["NOMBRE"].ToString();

                            idiomas.Add(idioma);
                        }
                    }

                }

                return idiomas;
            }
            catch (AccesoBDException ex)
            {
                throw new SecurityDAOException("TraerTodosIdiomas", "AccesoBD", ex.Message, ex);
            }
            catch (SqlException ex)
            {
                throw new SecurityDAOException("TraerTodosIdiomas", "SQL", ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new SecurityDAOException("TraerTodosIdiomas", "General: " + ex.GetType().ToString(), ex.Message, ex);
            }

        }

        public bool InsertarUsuario(Usuario usuario)
        {
            try
            {
                int filasAfectadas = 0;

                using (SqlConnection conexion = Conexion.ObtenerInstancia().CrearConexionSQL())
                {
                    using (SqlCommand comando = conexion.CreateCommand())
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.CommandText = "SPI_Usuario";
                        comando.Parameters.Add(new SqlParameter("@Id_Usuario", usuario.Nombre));
                        comando.Parameters.Add(new SqlParameter("@Clave", usuario.Clave));
                        comando.Parameters.Add(new SqlParameter("@Perfil", usuario.Perfil.ID));
                        comando.Parameters.Add(new SqlParameter("@Idioma", usuario.Idioma.ID));
                        comando.Parameters.Add(new SqlParameter("@DVH", usuario.DVH));

                        comando.Connection.Open();

                        filasAfectadas = comando.ExecuteNonQuery();
                        
                    }
                }

                if (filasAfectadas > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (AccesoBDException ex)
            {
                throw new SecurityDAOException("InsertarUsuario", "AccesoBD", ex.Message, ex);
            }
            catch (SqlException ex)
            {
                throw new SecurityDAOException("InsertarUsuario", "SQL", ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new SecurityDAOException("InsertarUsuario", "General: " + ex.GetType().ToString(), ex.Message, ex);
            }
        }

        public bool ActualizarUsuario(Usuario usuario)
        {
            try
            {
                int filasAfectadas = 0;

                using (SqlConnection conexion = Conexion.ObtenerInstancia().CrearConexionSQL())
                {
                    using (SqlCommand comando = conexion.CreateCommand())
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.CommandText = "SPU_Usuario";
                        comando.Parameters.Add(new SqlParameter("@Id_Usuario", usuario.Nombre));
                        comando.Parameters.Add(new SqlParameter("@Clave", usuario.Clave));
                        comando.Parameters.Add(new SqlParameter("@Perfil", usuario.Perfil.ID));
                        comando.Parameters.Add(new SqlParameter("@Idioma", usuario.Idioma.ID));
                        comando.Parameters.Add(new SqlParameter("@DVH", usuario.DVH));

                        comando.Connection.Open();

                        filasAfectadas = comando.ExecuteNonQuery();

                    }
                }

                if (filasAfectadas > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (AccesoBDException ex)
            {
                throw new SecurityDAOException("ActualizarUsuario", "AccesoBD", ex.Message, ex);
            }
            catch (SqlException ex)
            {
                throw new SecurityDAOException("ActualizarUsuario", "SQL", ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new SecurityDAOException("ActualizarUsuario", "General: " + ex.GetType().ToString(), ex.Message, ex);
            }
        }

        public bool EliminarUsuario(Usuario usuario)
        {
            try
            {
                int filasAfectadas = 0;

                using (SqlConnection conexion = Conexion.ObtenerInstancia().CrearConexionSQL())
                {
                    using (SqlCommand comando = conexion.CreateCommand())
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.CommandText = "SPD_Usuario";
                        comando.Parameters.Add(new SqlParameter("@IdUsuario", usuario.Nombre));

                        comando.Connection.Open();

                        filasAfectadas = comando.ExecuteNonQuery();

                    }
                }

                if (filasAfectadas > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (AccesoBDException ex)
            {
                throw new SecurityDAOException("EliminarUsuario", "AccesoBD", ex.Message, ex);
            }
            catch (SqlException ex)
            {
                throw new SecurityDAOException("EliminarUsuario", "SQL", ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new SecurityDAOException("EliminarUsuario", "General: " + ex.GetType().ToString(), ex.Message, ex);
            }
        }

        public List<Componente> TraerLeyendas(string form, string idIdioma)
        {

            try
            {
                List<Componente> componentes = new List<Componente>();
                Componente componente = null;

                using (SqlConnection conexion = Conexion.ObtenerInstancia().CrearConexionSQL())
                {

                    using (SqlCommand comando = conexion.CreateCommand())
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.CommandText = "SPS_Componentes_Traduccion";
                        comando.Parameters.Add(new SqlParameter("@IdIdioma", idIdioma));
                        comando.Parameters.Add(new SqlParameter("@FormNombre", form));

                        comando.Connection.Open();

                        SqlDataReader dataReader = comando.ExecuteReader(CommandBehavior.CloseConnection);

                        while (dataReader.Read())
                        {
                            componente = new Componente();

                            componente.Idioma = new Idioma();
                            componente.Idioma.ID = dataReader["IDIOMA_ID"].ToString();
                            componente.Idioma.Nombre = dataReader["IDIOMA_NOMBRE"].ToString();

                            componente.Leyenda = new Leyenda();
                            componente.Leyenda.ID = Convert.ToInt16(dataReader["LEYENDA_ID"]);
                            componente.Leyenda.Nombre = dataReader["LEYENDA_NOMBRE"].ToString();

                            componente.Traduccion = dataReader["TRADUCCION"].ToString();
                            
                            componentes.Add(componente);
                        }
                    }

                }

                return componentes;
            }
            catch (AccesoBDException ex)
            {
                throw new SecurityDAOException("TraerLeyendas", "AccesoBD", ex.Message, ex);
            }
            catch (SqlException ex)
            {
                throw new SecurityDAOException("TraerLeyendas", "SQL", ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new SecurityDAOException("TraerLeyendas", "General: " + ex.GetType().ToString(), ex.Message, ex);
            }
        }

        public List<Componente> TraerLeyendasTodas(string idIdioma)
        {

            try
            {
                List<Componente> componentes = new List<Componente>();
                Componente componente = null;

                using (SqlConnection conexion = Conexion.ObtenerInstancia().CrearConexionSQL())
                {

                    using (SqlCommand comando = conexion.CreateCommand())
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.CommandText = "SPS_Componentes_Traduccion_Todos";
                        comando.Parameters.Add(new SqlParameter("@IdIdioma", idIdioma));

                        comando.Connection.Open();

                        SqlDataReader dataReader = comando.ExecuteReader(CommandBehavior.CloseConnection);

                        while (dataReader.Read())
                        {
                            componente = new Componente();

                            componente.Idioma = new Idioma();
                            componente.Idioma.ID = dataReader["IDIOMA_ID"].ToString();
                            componente.Idioma.Nombre = dataReader["IDIOMA_NOMBRE"].ToString();

                            componente.Leyenda = new Leyenda();
                            componente.Leyenda.ID = Convert.ToInt16(dataReader["LEYENDA_ID"]);
                            componente.Leyenda.Nombre = dataReader["LEYENDA_NOMBRE"].ToString();

                            componente.Traduccion = dataReader["TRADUCCION"].ToString();

                            componentes.Add(componente);
                        }
                    }

                }

                return componentes;
            }
            catch (AccesoBDException ex)
            {
                throw new SecurityDAOException("TraerLeyendasTodas", "AccesoBD", ex.Message, ex);
            }
            catch (SqlException ex)
            {
                throw new SecurityDAOException("TraerLeyendasTodas", "SQL", ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new SecurityDAOException("TraerLeyendasTodas", "General: " + ex.GetType().ToString(), ex.Message, ex);
            }
        }

        public Componente TraerLeyenda(string idIdioma, int idLeyenda)
        {

            try
            {

                Componente componente = null;

                using (SqlConnection conexion = Conexion.ObtenerInstancia().CrearConexionSQL())
                {

                    using (SqlCommand comando = conexion.CreateCommand())
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.CommandText = "SPS_Leyenda_Traduccion";
                        comando.Parameters.Add(new SqlParameter("@IdIdioma", idIdioma));
                        comando.Parameters.Add(new SqlParameter("@IdLeyenda", idLeyenda));

                        comando.Connection.Open();

                        SqlDataReader dataReader = comando.ExecuteReader(CommandBehavior.CloseConnection);

                        while (dataReader.Read())
                        {
                            componente = new Componente();

                            componente.Idioma = new Idioma();
                            componente.Idioma.ID = dataReader["IDIOMA_ID"].ToString();
                            componente.Idioma.Nombre = dataReader["IDIOMA_NOMBRE"].ToString();

                            componente.Leyenda = new Leyenda();
                            componente.Leyenda.ID = Convert.ToInt16(dataReader["LEYENDA_ID"]);
                            componente.Leyenda.Nombre = dataReader["LEYENDA_NOMBRE"].ToString();

                            componente.Traduccion = dataReader["TRADUCCION"].ToString();
                            
                        }
                    }

                }

                return componente;
            }
            catch (AccesoBDException ex)
            {
                throw new SecurityDAOException("TraerLeyenda", "AccesoBD", ex.Message, ex);
            }
            catch (SqlException ex)
            {
                throw new SecurityDAOException("TraerLeyenda", "SQL", ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new SecurityDAOException("TraerLeyenda", "General: " + ex.GetType().ToString(), ex.Message, ex);
            }
        }

        public bool InsertarIdioma(Idioma idioma)
        {
            try
            {
                int filasAfectadas = 0;

                using (SqlConnection conexion = Conexion.ObtenerInstancia().CrearConexionSQL())
                {

                    using (SqlCommand comando = conexion.CreateCommand())
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.CommandText = "SPI_Idioma";
                        comando.Parameters.Add(new SqlParameter("@IdIdioma", idioma.ID));
                        comando.Parameters.Add(new SqlParameter("@Nombre", idioma.Nombre));

                        comando.Connection.Open();

                        filasAfectadas = comando.ExecuteNonQuery();

                    }
                }

                if (filasAfectadas > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (AccesoBDException ex)
            {
                throw new SecurityDAOException("InsertarIdioma", "AccesoBD", ex.Message, ex);
            }
            catch (SqlException ex)
            {
                throw new SecurityDAOException("InsertarIdioma", "SQL", ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new SecurityDAOException("InsertarIdioma", "General: " + ex.GetType().ToString(), ex.Message, ex);
            }
        }

        public bool InsertarTraduccion(Componente componente)
        {
            try
            {
                int filasAfectadas = 0;

                using (SqlConnection conexion = Conexion.ObtenerInstancia().CrearConexionSQL())
                {

                    using (SqlCommand comando = conexion.CreateCommand())
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.CommandText = "SPI_Leyenda_Idioma";
                        comando.Parameters.Add(new SqlParameter("@IdIdioma", componente.Idioma.ID));
                        comando.Parameters.Add(new SqlParameter("@IdLeyenda", componente.Leyenda.ID));
                        comando.Parameters.Add(new SqlParameter("@Traduccion", componente.Traduccion));

                        comando.Connection.Open();

                        filasAfectadas = comando.ExecuteNonQuery();

                    }
                }

                if (filasAfectadas > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (AccesoBDException ex)
            {
                throw new SecurityDAOException("InsertarTraduccion", "AccesoBD", ex.Message, ex);
            }
            catch (SqlException ex)
            {
                throw new SecurityDAOException("InsertarTraduccion", "SQL", ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new SecurityDAOException("InsertarTraduccion", "General: " + ex.GetType().ToString(), ex.Message, ex);
            }
        }

        public bool InsertarPermiso(PermisoBase permiso)
        {

            try
            {

                using (SqlConnection conexion = Conexion.ObtenerInstancia().CrearConexionSQL())
                {

                    using (SqlCommand comando = conexion.CreateCommand())
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.CommandText = "SPI_Permiso";
                        comando.Parameters.Add(new SqlParameter("@Descripcion", permiso.Descripcion));
                        comando.Parameters.Add(new SqlParameter("@Accion", permiso.Accion));

                        comando.Connection.Open();

                        permiso.ID = Convert.ToInt32(comando.ExecuteScalar());

                    }
                }

                if (permiso.ID > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (AccesoBDException ex)
            {
                throw new SecurityDAOException("InsertarPermiso", "AccesoBD", ex.Message, ex);
            }
            catch (SqlException ex)
            {
                throw new SecurityDAOException("InsertarPermiso", "SQL", ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new SecurityDAOException("InsertarPermiso", "General: " + ex.GetType().ToString(), ex.Message, ex);
            }
        }

        public bool ActualizarPermiso(GrupoPermiso permiso)
        {
            try
            {

                int filasAfectadas = 0;

                using (SqlConnection conexion = Conexion.ObtenerInstancia().CrearConexionSQL())
                {

                    using (SqlCommand comando = conexion.CreateCommand())
                    {

                        comando.CommandType = CommandType.StoredProcedure;
                        comando.CommandText = "SPD_Permiso_Permiso";
                        comando.Parameters.Add(new SqlParameter("@IdPadre", permiso.ID));

                        comando.Connection.Open();

                        comando.ExecuteNonQuery();

                        comando.CommandText = "SPI_Permiso_Permiso";

                        foreach (PermisoBase per in permiso.Permisos)
                        {
                            comando.Parameters.Clear();
                            comando.Parameters.Add(new SqlParameter("@IdPadre", permiso.ID));
                            comando.Parameters.Add(new SqlParameter("@IdHijo", per.ID));

                            filasAfectadas += comando.ExecuteNonQuery();
                        }
                        
                    }
                }

                if (filasAfectadas > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (AccesoBDException ex)
            {
                throw new SecurityDAOException("ActualizarPermiso", "AccesoBD", ex.Message, ex);
            }
            catch (SqlException ex)
            {
                throw new SecurityDAOException("ActualizarPermiso", "SQL", ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new SecurityDAOException("ActualizarPermiso", "General: " + ex.GetType().ToString(), ex.Message, ex);
            }
        }

        public bool EliminarPermiso(GrupoPermiso permiso)
        {
            try
            {

                int filasAfectadas = 0;

                using (SqlConnection conexion = Conexion.ObtenerInstancia().CrearConexionSQL())
                {

                    using (SqlCommand comando = conexion.CreateCommand())
                    {

                        comando.CommandType = CommandType.StoredProcedure;
                        comando.CommandText = "SPD_Permiso_Permiso";
                        comando.Parameters.Add(new SqlParameter("@IdPadre", permiso.ID));

                        comando.Connection.Open();

                        filasAfectadas = comando.ExecuteNonQuery();

                        comando.CommandText = "SPD_Permiso";
                        comando.Parameters.Clear();
                        comando.Parameters.Add(new SqlParameter("@IdPermiso", permiso.ID));

                        filasAfectadas += comando.ExecuteNonQuery();

                    }
                }

                if (filasAfectadas > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (AccesoBDException ex)
            {
                throw new SecurityDAOException("EliminarPermiso", "AccesoBD", ex.Message, ex);
            }
            catch (SqlException ex)
            {
                throw new SecurityDAOException("EliminarPermiso", "SQL", ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new SecurityDAOException("EliminarPermiso", "General: " + ex.GetType().ToString(), ex.Message, ex);
            }
        }
    }
}
