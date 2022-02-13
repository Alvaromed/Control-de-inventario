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
    public class D_Proveedor
    {
        public List<Proveedor> List()
        {
            List<Proveedor> lista = new List<Proveedor>();

            using (SqlConnection objconexion = new SqlConnection(Conexion.conexion))
            {
                try
                {
                    StringBuilder query = new StringBuilder();

                    query.AppendLine("SELECT IdProveedor,Documento,RazonSocial,Telefono,Correo,Estado FROM PROVEEDOR");
                    


                    //                    select u.IdProveedor,u.ProveedorLogin,u.NombreCompleto,u.Correo,u.Pass,u.Estado, r.IdRol, r.Descripcion from Proveedor u
                    //inner join ROL r on r.IdRol = u.IdRol

                    SqlCommand cmd = new SqlCommand(query.ToString(), objconexion);
                    cmd.CommandType = CommandType.Text;

                    objconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Proveedor()
                            {
                                IdProveedor = Convert.ToInt32(dr["IdProveedor"]),
                                Documento = dr["Documento"].ToString(),
                                RazonSocial = dr["RazonSocial"].ToString(),
                                Telefono = dr["Telefono"].ToString(),
                                Correo = dr["Correo"].ToString(),
                                Estado = Convert.ToBoolean(dr["Estado"]),
                                

                            });
                        }
                    }
                }
                catch (Exception e)
                {
                    lista = new List<Proveedor>();

                }
            }
            return lista;
        }


        public int Registrar(Proveedor proveedor, out string Mensaje)
        {

            int idProveedorGenerado = 0;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection objconexion = new SqlConnection(Conexion.conexion))
                {
                    SqlCommand cmd = new SqlCommand("SP_REGISTRARPROVEEDOR", objconexion);

                    //Añadiendo valores con los parametros(entrada) predefinidos a usar en el Procedimiento Almacenado
                    cmd.Parameters.AddWithValue("Documento", proveedor.Documento);
                    cmd.Parameters.AddWithValue("RazonSocial", proveedor.RazonSocial);
                    cmd.Parameters.AddWithValue("Telefono", proveedor.Telefono);
                    cmd.Parameters.AddWithValue("Correo", proveedor.Correo);
                    cmd.Parameters.AddWithValue("Estado", proveedor.Estado);


                    //Parametros (salida) que obtiene a partir del procedimiento almacenado "SP_REGISTRARProveedor"
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;


                    cmd.CommandType = CommandType.StoredProcedure;

                    objconexion.Open();

                    cmd.ExecuteNonQuery();
                    idProveedorGenerado = Convert.ToInt32(cmd.Parameters["Resultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();


                }

                //CREATE PROC SP_REGISTRARPROVEEDOR(

                //@Documento varchar(55),
                //@RazonSocial varchar(55),
                //@Correo varchar(55),
                //@Telefono varchar(55),
                //@Estado bit,
                //@Resultado int output,
                //@Mensaje varchar(500) output
                //)
            }
            catch (Exception e)
            {
                idProveedorGenerado = 0;
                Mensaje = e.Message;

            }

            return idProveedorGenerado;
        }



        public bool Edit(Proveedor Proveedor, out string mensaje)
        {

            bool respuesta = false;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection objconexion = new SqlConnection(Conexion.conexion))
                {
                    SqlCommand cmd = new SqlCommand("SP_EDITARPROVEEDOR", objconexion);

                    //Añadiendo valores con los parametros(entrada) predefinidos a usar en el Procedimiento Almacenado
                    cmd.Parameters.AddWithValue("IdProveedor", Proveedor.IdProveedor);
                    cmd.Parameters.AddWithValue("Documento", Proveedor.Documento);
                    cmd.Parameters.AddWithValue("RazonSocial", Proveedor.RazonSocial);
                    cmd.Parameters.AddWithValue("Telefono", Proveedor.Telefono);
                    cmd.Parameters.AddWithValue("Correo", Proveedor.Correo);
                    cmd.Parameters.AddWithValue("Estado", Proveedor.Estado);


                    //Parametros (salida) que obtiene a partir del procedimiento almacenado "SP_EDITARProveedor"
                    cmd.Parameters.Add("Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;


                    cmd.CommandType = CommandType.StoredProcedure;

                    objconexion.Open();

                    cmd.ExecuteNonQuery();
                    respuesta = Convert.ToBoolean(cmd.Parameters["Respuesta"].Value);
                    mensaje = cmd.Parameters["Mensaje"].Value.ToString();


                }

                //CREATE PROC SP_EDITARPROVEEDOR(

                //@IdProveedor int,
                //@Documento varchar(55),
                //@RazonSocial varchar(55),
                //@Correo varchar(55),
                //@Telefono varchar(55),
                //@Estado bit,
                //@Respuesta bit output,
                //@Mensaje varchar(500) output
                //)

            }
            catch (Exception e)
            {
                respuesta = false;
                mensaje = e.Message;

            }

            return respuesta;
        }



        public bool Delete(Proveedor Proveedor, out string mensaje)
        {

            bool respuesta = false;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection objconexion = new SqlConnection(Conexion.conexion))
                {
                    SqlCommand cmd = new SqlCommand("SP_ELIMINARPROVEEDOR", objconexion);

                    //Añadiendo valores con los parametros(entrada) predefinidos a usar en el Procedimiento Almacenado
                    cmd.Parameters.AddWithValue("IdProveedor", Proveedor.IdProveedor);


                    //Parametros (salida) que obtiene a partir del procedimiento almacenado "SP_EDITARProveedor"
                    cmd.Parameters.Add("Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;


                    cmd.CommandType = CommandType.StoredProcedure;

                    objconexion.Open();

                    cmd.ExecuteNonQuery();
                    respuesta = Convert.ToBoolean(cmd.Parameters["Respuesta"].Value);
                    mensaje = cmd.Parameters["Mensaje"].Value.ToString();


                }
                //CREATE PROC SP_ELIMINARPROVEEDOR(

                //@IdProveedor int,
                //@Respuesta bit output,
                //@Mensaje varchar(500) output
                //)

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
