using Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class D_Negocio
    {

        public E_Negocio ObtenerDatos()
        {
            E_Negocio negocio = new E_Negocio();

            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.conexion))
                {
                    conexion.Open();

                    string query = "SELECT IdNegocio, Nombre, RFC, Direccion FROM NEGOCIO WHERE IDNegocio = 1";

                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.CommandType = CommandType.Text;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            negocio = new E_Negocio()
                            {
                                IdNegocio = int.Parse(dr["IdNegocio"].ToString()),
                                Nombre = dr["Nombre"].ToString(),
                                RFC = dr["RFC"].ToString(),
                                Direccion = dr["Direccion"].ToString()


                            };
                        }
                    }
                }
            }
            catch
            {
                negocio = new E_Negocio();
            }

            return negocio;
        }
        public bool guardarDatos(E_Negocio negocio, out string mensaje)
        {
            mensaje = string.Empty;
            bool respuesta = true;

            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.conexion))
                {
                    conexion.Open();



                    StringBuilder query = new StringBuilder();
                    query.AppendLine("UPDATE NEGOCIO SET Nombre = @nombre,");
                    query.AppendLine("RFC= @rfc,");
                    query.AppendLine("Direccion = @direccion");
                    query.AppendLine("WHERE IdNegocio = 1");

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.Parameters.AddWithValue("@nombre", negocio.Nombre);
                    cmd.Parameters.AddWithValue("@rfc", negocio.RFC);
                    cmd.Parameters.AddWithValue("@direccion", negocio.Direccion);


                    cmd.CommandType = CommandType.Text;

                    //Si el número de filas afectadas es menor a 1
                    if (cmd.ExecuteNonQuery() < 1)
                    {
                        mensaje = "No se puede actualizar la información";
                        respuesta = false;
                    }


                }                  }
            
            catch (Exception e)
            {
                mensaje = e.Message;
                respuesta = false;
            }
            return respuesta;
        }

        //Obtener imagen desde un array de bits
        public byte[] ObtenerLogo(out bool obtenido)
        {
            obtenido = true;
            byte[] LogoBytes = new byte[0];


            try
            {

                using (SqlConnection conexion = new SqlConnection(Conexion.conexion))
                {
                    conexion.Open();
                    string query = "SELECT Logo FROM NEGOCIO WHERE IDNegocio = 1";

                    SqlCommand cmd = new SqlCommand(query, conexion);



                    cmd.CommandType = CommandType.Text;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {

                            LogoBytes =(byte[]) dr["Logo"];

                        }
                    }
                }
            }
            catch(Exception e)
            {
                obtenido = false;
                LogoBytes = new byte[0];
            }

            return LogoBytes;
        }
      
        public bool actualizarLogo(byte[] imagen,out string mensaje )
        {
            mensaje = string.Empty;
            bool respuesta = true;

            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.conexion))
                {
                    conexion.Open();



                    StringBuilder query = new StringBuilder();
                    query.AppendLine("UPDATE NEGOCIO SET Logo = @imagen");
                    query.AppendLine("WHERE IdNegocio = 1");

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.Parameters.AddWithValue("@imagen", imagen);
                   


                    cmd.CommandType = CommandType.Text;

                    //Si el número de filas afectadas es menor a 1
                    if (cmd.ExecuteNonQuery() < 1)
                    {
                        mensaje = "No se puede actualizar el logo";
                        respuesta = false;
                    }


                }
            }

            catch (Exception e)
            {
                mensaje = e.Message;
                respuesta = false;
            }
            return respuesta;
        }

    }
}
