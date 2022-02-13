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
    public class D_Categoria
    {

        //Se genera una lista de las categorias que tenemos
        public List<Categoria> List()
        {
            List<Categoria> lista = new List<Categoria>();

            using (SqlConnection objconexion = new SqlConnection(Conexion.conexion))
            {
                try
                {
                    StringBuilder query = new StringBuilder();

                    query.AppendLine("SELECT IdCategoria,NombreCategoria,Estado FROM CATEGORIA ");

                    //SELECT IdCategoria,NombreCategoria,Estado FROM CATEGORIA


                    SqlCommand cmd = new SqlCommand(query.ToString(), objconexion);
                    cmd.CommandType = CommandType.Text;

                    objconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Categoria()
                            {
                                IdCategoria = Convert.ToInt32(dr["IdCategoria"]),
                                NombreCategoria = dr["NombreCategoria"].ToString(),
                                Estado = Convert.ToBoolean(dr["Estado"]),
                                

                            });
                        }
                    }
                }
                catch (Exception e)
                {
                    lista = new List<Categoria>();

                }
            }
            return lista;
        }

        //Método que realiza el registro de una categoría siempre y cuando cumpla las condiciones del procedimiento almacenado
        public int Registrar(Categoria categoria, out string Mensaje)
        {

            int idCategoriaGenerado = 0;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection objconexion = new SqlConnection(Conexion.conexion))
                {
                    SqlCommand cmd = new SqlCommand("SP_REGISTRARCATEGORIA", objconexion);

                    //Añadiendo valores con los parametros(entrada) predefinidos a usar en el Procedimiento Almacenado
                    cmd.Parameters.AddWithValue("NombreCategoria",categoria.NombreCategoria);
                    cmd.Parameters.AddWithValue("Estado", categoria.Estado);


                    //Parametros (salida) que obtiene a partir del procedimiento almacenado "SP_REGISTRARCategoria"
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;


                    cmd.CommandType = CommandType.StoredProcedure;

                    objconexion.Open();

                    cmd.ExecuteNonQuery();
                    idCategoriaGenerado = Convert.ToInt32(cmd.Parameters["Resultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();


                }

                //CREATE PROC SP_REGISTRARCATEGORIA(
                //@NombreCategoria varchar(95),
                //@Resultado int output,
                //@Mensaje varchar(500) output
                //)

            }
            catch (Exception e)
            {
                idCategoriaGenerado = 0;
                Mensaje = e.Message;

            }

            return idCategoriaGenerado;
        }



        public bool Edit(Categoria Categoria, out string mensaje)
        {

            bool respuesta = false;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection objconexion = new SqlConnection(Conexion.conexion))
                {
                    SqlCommand cmd = new SqlCommand("SP_EDITARCATEGORIA", objconexion);

                    //Añadiendo valores con los parametros(entrada) predefinidos a usar en el Procedimiento Almacenado
                    cmd.Parameters.AddWithValue("IdCategoria", Categoria.IdCategoria);
                    cmd.Parameters.AddWithValue("NombreCategoria", Categoria.NombreCategoria);
                    cmd.Parameters.AddWithValue("Estado", Categoria.Estado);



                    //Parametros (salida) que obtiene a partir del procedimiento almacenado "SP_EDITARCategoria"
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;


                    cmd.CommandType = CommandType.StoredProcedure;

                    objconexion.Open();

                    cmd.ExecuteNonQuery();
                    respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                    mensaje = cmd.Parameters["Mensaje"].Value.ToString();


                }
                //CREATE PROC SP_EDITARCATEGORIA(
                //@IdCategoria int,
                //@NombreCategoria varchar(95),
                //@Resultado bit output,
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



        public bool Delete(Categoria Categoria, out string mensaje)
        {

            bool respuesta = false;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection objconexion = new SqlConnection(Conexion.conexion))
                {
                    SqlCommand cmd = new SqlCommand("SP_ELIMINARCATEGORIA", objconexion);

                    //Añadiendo valores con los parametros(entrada) predefinidos a usar en el Procedimiento Almacenado
                    cmd.Parameters.AddWithValue("IdCategoria", Categoria.IdCategoria);


                    //Parametros (salida) que obtiene a partir del procedimiento almacenado "SP_EDITARCategoria"
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;


                    cmd.CommandType = CommandType.StoredProcedure;

                    objconexion.Open();

                    cmd.ExecuteNonQuery();
                    respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                    mensaje = cmd.Parameters["Mensaje"].Value.ToString();


                }

                //CREATE PROC SP_ELIMINARCATEGORIA(
                // @IdCategoria int,
                // @Resultado bit output,
                // @Mensaje varchar(500) output

                // )

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
