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
     public class D_Productos
    {
        public List<Producto> List()
        {
            List<Producto> lista = new List<Producto>();

            using (SqlConnection objconexion = new SqlConnection(Conexion.conexion))
            {
                try
                {
                    StringBuilder query = new StringBuilder();

                    query.AppendLine("SELECT IdProducto,Codigo,Nombre,c.IdCategoria,p.Descripcion,c.NombreCategoria,Stock,PrecioCompra,PrecioVenta, p.Estado  from PRODUCTO p");
                    query.AppendLine("INNER JOIN CATEGORIA c ON c.IdCategoria = p.IdCategoria");


                    // SELECT IdProducto,Codigo,Nombre,c.IdCategoria,p.Descripcion[DescripcionProducto],c.NombreCategoria,Stock,PrecioCompra,PrecioVenta, p.Estado  from PRODUCTO p
                    // INNER JOIN CATEGORIA c ON c.IdCategoria = p.IdCategoria

                    SqlCommand cmd = new SqlCommand(query.ToString(), objconexion);
                    cmd.CommandType = CommandType.Text;

                    objconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Producto()
                            {
                                IdProducto = Convert.ToInt32(dr["IdProducto"]),
                                Codigo = dr["Codigo"].ToString(),
                                Nombre = dr["Nombre"].ToString(),
                                objCategoria = new Categoria() { IdCategoria = Convert.ToInt32(dr["IdCategoria"]) , NombreCategoria = dr["NombreCategoria"].ToString()},
                                Descripcion = dr["Descripcion"].ToString(),
                                Stock = Convert.ToInt32( dr["Stock"].ToString()),
                                PrecioCompra = Convert.ToDecimal(dr["PrecioCompra"].ToString()),
                                PrecioVenta = Convert.ToDecimal(dr["PrecioVenta"].ToString()),
                                Estado = Convert.ToBoolean(dr["Estado"]),
                                
                            });
                        }
                    }
                }
                catch (Exception e)
                {
                    lista = new List<Producto>();

                }
            }
            return lista;
        }


        public int Registrar(Producto producto, out string Mensaje)
        {

            int idProductoGenerado = 0;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection objconexion = new SqlConnection(Conexion.conexion))
                {
                    SqlCommand cmd = new SqlCommand("SP_REGISTRARPRODUCTO", objconexion);

                    //Añadiendo valores con los parametros(entrada) predefinidos a usar en el Procedimiento Almacenado
                    cmd.Parameters.AddWithValue("Codigo", producto.Codigo);
                    cmd.Parameters.AddWithValue("Nombre", producto.Nombre);
                    cmd.Parameters.AddWithValue("IdCategoria", producto.objCategoria.IdCategoria);
                    cmd.Parameters.AddWithValue("Descripcion", producto.Descripcion);
                    cmd.Parameters.AddWithValue("Estado", producto.Estado);


                    //Parametros (salida) que obtiene a partir del procedimiento almacenado "SP_REGISTRARProducto"
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;


                    cmd.CommandType = CommandType.StoredProcedure;

                    objconexion.Open();

                    cmd.ExecuteNonQuery();
                    idProductoGenerado = Convert.ToInt32(cmd.Parameters["Resultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();


                }

                //CREATE PROC SP_REGISTRARPRODUCTO(
                //@Codigo varchar(50),
                //@Nombre varchar(50),
                //@IdCategoria int,
                //@Descripcion varchar(95),
                //@Estado bit,
                //@Resultado int output,
                //@Mensaje varchar(500) output
                //)

            }
            catch (Exception e)
            {
                idProductoGenerado = 0;
                Mensaje = e.Message;

            }

            return idProductoGenerado;
        }



        public bool Edit(Producto producto, out string mensaje)
        {

            bool respuesta = false;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection objconexion = new SqlConnection(Conexion.conexion))
                {
                    SqlCommand cmd = new SqlCommand("SP_EDITARPRODUCTO", objconexion);

                    //Añadiendo valores con los parametros(entrada) predefinidos a usar en el Procedimiento Almacenado
                    cmd.Parameters.AddWithValue("IdProducto", producto.IdProducto);
                    cmd.Parameters.AddWithValue("Codigo", producto.Codigo);
                    cmd.Parameters.AddWithValue("Nombre", producto.Nombre);
                    cmd.Parameters.AddWithValue("IdCategoria",producto.objCategoria.IdCategoria);
                    cmd.Parameters.AddWithValue("Descripcion", producto.Descripcion);
                    cmd.Parameters.AddWithValue("Estado", producto.Estado);


                    //Parametros (salida) que obtiene a partir del procedimiento almacenado "SP_EDITARProducto"
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;


                    cmd.CommandType = CommandType.StoredProcedure;

                    objconexion.Open();

                    cmd.ExecuteNonQuery();
                    respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                    mensaje = cmd.Parameters["Mensaje"].Value.ToString();


                }

                //CREATE PROC SP_EDITARPRODUCTO(
                //@IdProducto int,
                //@Codigo varchar(50),
                //@Nombre varchar(50),
                //@IdCategoria int,
                //@Descripcion varchar(95),
                //@Estado bit,
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



        public bool Delete(Producto producto, out string mensaje)
        {

            bool respuesta = false;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection objconexion = new SqlConnection(Conexion.conexion))
                {
                    SqlCommand cmd = new SqlCommand("SP_ELIMINARProducto", objconexion);

                    //Añadiendo valores con los parametros(entrada) predefinidos a usar en el Procedimiento Almacenado
                    cmd.Parameters.AddWithValue("IdProducto",producto.IdProducto);
                    //cmd.Parameters.AddWithValue("Nombre", producto.Nombre);


                    //Parametros (salida) que obtiene a partir del procedimiento almacenado "SP_EDITARProducto"
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;


                    cmd.CommandType = CommandType.StoredProcedure;

                    objconexion.Open();

                    cmd.ExecuteNonQuery();
                    respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                    mensaje = cmd.Parameters["Mensaje"].Value.ToString();


                }

                //CREATE PROC SP_ELIMINARPRODUCTO(
                //@IdProducto int,
                //@Nombre varchar(50),
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



     }
}
