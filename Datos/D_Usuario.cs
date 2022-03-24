using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using Entidad;

namespace Datos
{
    public class D_Usuario
    {
            public List<Usuario> List()
        {
            List<Usuario> lista = new List<Usuario>();

            using (SqlConnection objconexion = new SqlConnection(Conexion.conexion))
            {
                try
                {
                    StringBuilder query = new StringBuilder();

                    query.AppendLine("select u.IdUsuario,u.UsuarioLogin,u.NombreCompleto,u.Correo,u.Pass,u.Estado, r.IdRol, r.Descripcion from usuario u");
                    query.AppendLine("inner join ROL r on r.IdRol = u.IdRol");


                    //                    select u.IdUsuario,u.UsuarioLogin,u.NombreCompleto,u.Correo,u.Pass,u.Estado, r.IdRol, r.Descripcion from usuario u
                    //inner join ROL r on r.IdRol = u.IdRol

                    SqlCommand cmd = new SqlCommand(query.ToString(), objconexion);
                    cmd.CommandType = CommandType.Text;

                    objconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader()) 
                    {
                        while (dr.Read())
                        {
                            lista.Add( new Usuario()
                            {
                                IdUsuario = Convert.ToInt32(dr["IdUsuario"]),
                                UsuarioLogin = dr["UsuarioLogin"].ToString(),
                                NombreCompleto = dr ["NombreCompleto"].ToString(),
                                Correo = dr ["Correo"].ToString(),
                                Pass = dr ["Pass"].ToString(),
                                Estado = Convert.ToBoolean(dr["Estado"]),
                                objRol = new Rol() { IdRol = Convert.ToInt32(dr["IdRol"]), Descripcion = dr["Descripcion"].ToString() }

                            });
                        }
                    }
                }
                catch (Exception e)
                {
                    lista = new List<Usuario>();
                    
                }
            }
            return lista;
        }


        public int Registrar (Usuario usuario, out string Mensaje)
        {

            int idUsuarioGenerado = 0;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection objconexion = new SqlConnection(Conexion.conexion))
                {
                    SqlCommand cmd = new SqlCommand("SP_REGISTRARUSUARIO", objconexion);

                    //Añadiendo valores con los parametros(entrada) predefinidos a usar en el Procedimiento Almacenado
                    cmd.Parameters.AddWithValue("UsuarioLogin",usuario.UsuarioLogin);
                    cmd.Parameters.AddWithValue("NombreCompleto", usuario.NombreCompleto);
                    cmd.Parameters.AddWithValue("Correo", usuario.Correo);
                    cmd.Parameters.AddWithValue("Pass", usuario.Pass);
                    cmd.Parameters.AddWithValue("IdRol", usuario.objRol.IdRol);
                    cmd.Parameters.AddWithValue("Estado", usuario.Estado);


                    //Parametros (salida) que obtiene a partir del procedimiento almacenado "SP_REGISTRARUSUARIO"
                    cmd.Parameters.Add("IdUsuarioResultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar,500).Direction = ParameterDirection.Output;


                    cmd.CommandType = CommandType.StoredProcedure;

                    objconexion.Open();

                    cmd.ExecuteNonQuery();
                    idUsuarioGenerado =Convert.ToInt32(  cmd.Parameters["IdUsuarioResultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();


                }

                //CREATE PROC SP_REGISTRARUSUARIO(

                //@UsuarioLogin varchar(50),
                //@NombreCompleto varchar(100),
                //@Correo varchar(100),
                //@Pass varchar(100),
                //@IdRol int,
                //@Estado bit,
                //@IdUsuarioResultado int output,
                //@Mensaje varchar(500) output
                //)
                //as

            }
            catch (Exception e)
            {
                idUsuarioGenerado = 0;
                Mensaje = e.Message;

            }

            return idUsuarioGenerado;
        }



        public bool Edit(Usuario usuario, out string mensaje)
        {

            bool respuesta = false;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection objconexion = new SqlConnection(Conexion.conexion))
                {
                    SqlCommand cmd = new SqlCommand("SP_EDITARUSUARIO", objconexion);

                    //Añadiendo valores con los parametros(entrada) predefinidos a usar en el Procedimiento Almacenado
                    cmd.Parameters.AddWithValue("IdUsuario", usuario.IdUsuario);
                    cmd.Parameters.AddWithValue("UsuarioLogin", usuario.UsuarioLogin);
                    cmd.Parameters.AddWithValue("NombreCompleto", usuario.NombreCompleto);
                    cmd.Parameters.AddWithValue("Correo", usuario.Correo);
                    cmd.Parameters.AddWithValue("Pass", usuario.Pass);
                    cmd.Parameters.AddWithValue("IdRol", usuario.objRol.IdRol);
                    cmd.Parameters.AddWithValue("Estado", usuario.Estado);


                    //Parametros (salida) que obtiene a partir del procedimiento almacenado "SP_EDITARUSUARIO"
                    cmd.Parameters.Add("Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar,500).Direction = ParameterDirection.Output;


                    cmd.CommandType = CommandType.StoredProcedure;

                    objconexion.Open();

                    cmd.ExecuteNonQuery();
                    respuesta = Convert.ToBoolean(cmd.Parameters["Respuesta"].Value);
                    mensaje = cmd.Parameters["Mensaje"].Value.ToString();


                }

                //CREATE PROC SP_EDITARUSUARIO(

                //@IdUsuario int,
                //@UsuarioLogin varchar(50),
                //@NombreCompleto varchar(100),
                //@Correo varchar(100),
                //@Pass varchar(100),
                //@IdRol int,
                //@Estado bit,
                //@Respuesta bit output,
                //@Mensaje varchar(500) output
                //)
                //as

            }
            catch (Exception e)
            {
                respuesta = false;
                mensaje = e.Message;

            }

            return respuesta;
        }



        public bool Delete(Usuario usuario, out string mensaje)
        {

            bool respuesta = false;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection objconexion = new SqlConnection(Conexion.conexion))
                {
                    SqlCommand cmd = new SqlCommand("SP_ELIMINARUSUARIO", objconexion);

                    //Añadiendo valores con los parametros(entrada) predefinidos a usar en el Procedimiento Almacenado
                    cmd.Parameters.AddWithValue("IdUsuario", usuario.IdUsuario);
                   

                    //Parametros (salida) que obtiene a partir del procedimiento almacenado "SP_EDITARUSUARIO"
                    cmd.Parameters.Add("Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar,500).Direction = ParameterDirection.Output;


                    cmd.CommandType = CommandType.StoredProcedure;

                    objconexion.Open();

                    cmd.ExecuteNonQuery();
                    respuesta = Convert.ToBoolean(cmd.Parameters["Respuesta"].Value);
                    mensaje = cmd.Parameters["Mensaje"].Value.ToString();


                }

                //CREATE PROC SP_ELIMINARUSUARIO(

                ////@IdUsuario int,
                ////@Respuesta bit output,
                ////@Mensaje varchar(500) output
                ////)
                ////as

            }
            catch (Exception e)
            {
                respuesta = false;
                mensaje = e.Message;

            }

            return respuesta;
        }


    }
}
