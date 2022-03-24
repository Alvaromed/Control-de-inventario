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
 public class D_Compras
    {
        
        public int Obtener()
        {

            int id = 0;

            using (SqlConnection connection = new SqlConnection(Conexion.conexion))
            {
                try
                {
                    StringBuilder query = new StringBuilder();

                    query.AppendLine("SELECT Count(*)+1 FROM COMPRA");
                    SqlCommand cmd = new SqlCommand(query.ToString(), connection);
                    cmd.CommandType = CommandType.Text;

                    connection.Open();

                    id = Convert.ToInt32(cmd.ExecuteScalar());

                }
                catch (Exception ex)
                {

                    id = 0;
                    
                }
            }

            return id;
        }

        public bool Registrar(Compra compra, DataTable detalleCompra, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;
            using (SqlConnection connection = new SqlConnection(Conexion.conexion))
            {
                try
                {
                    
                    SqlCommand cmd = new SqlCommand("Sp_RegistrarCompra", connection);
                    

                    /*CREATE PROCEDURE Sp_RegistrarCompra(
                    @IdUsuario int,
                    @IdProveedor int,
                    @TipoDocumento varchar(55),
                    @NumeroDocumento varchar(55),
                    @MontoTotal decimal (5,2),
                    @DetalleCompra [EDetalle_Compra] READONLY,
                    @Resultado bit output,
                    @Mensaje varchar(500) output
                    
                    )*/
                    cmd.Parameters.AddWithValue("IdUsuario",compra.objUsuario.IdUsuario);
                    cmd.Parameters.AddWithValue("IdProveedor", compra.objProveedor.IdProveedor);
                    cmd.Parameters.AddWithValue("TipoDocumento", compra.TipoDocumento);
                    cmd.Parameters.AddWithValue("NumeroDocumento",compra.NumeroDocumento);
                    cmd.Parameters.AddWithValue("MontoTotal",compra.MontoTotal);
                    cmd.Parameters.AddWithValue("DetalleCompra",detalleCompra);

                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar,500).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.StoredProcedure;

                    connection.Open();
                    cmd.ExecuteNonQuery();

                    

                    respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                    mensaje = cmd.Parameters["Mensaje"].Value.ToString();

                }
                catch (Exception ex)
                {

                    respuesta = false;
                    mensaje = ex.Message + ex.TargetSite;

                }
            }

           

            return respuesta;
        }


        public Compra ObtenerCompra(string numero)
        {
            Compra compra = new Compra();




            using (SqlConnection objconexion = new SqlConnection(Conexion.conexion))
            {
                try
                {
                    StringBuilder query = new StringBuilder();

                    /*
                     * SELECT c.IdCompra,
                       u.UsuarioLogin,
                       pr.Documento,pr.RazonSocial,
                       c.TipoDocumento,c.NumeroDocumento,c.MontoTotal,CONVERT(char(19),c.FechaRegistro,20)[FechaRegistro]
                       FROM COMPRA c 
                       inner join USUARIO u on u.IdUsuario = c.IdUsuario
                       inner join PROVEEDOR pr on pr.IdProveedor = c.IdProveedor
                       WHERE C.NumeroDocumento = '00001'
                     * 
                     * **/


                    query.AppendLine("SELECT c.IdCompra,");
                    query.AppendLine("u.UsuarioLogin,");
                    query.AppendLine("pr.Documento,pr.RazonSocial,");
                    query.AppendLine("c.TipoDocumento,c.NumeroDocumento,c.MontoTotal,CONVERT(char(19),c.FechaRegistro,20)[FechaRegistro]");
                    query.AppendLine(" FROM COMPRA c ");
                    query.AppendLine("inner join USUARIO u on u.IdUsuario = c.IdUsuario");
                    query.AppendLine("inner join PROVEEDOR pr on pr.IdProveedor = c.IdProveedor");
                    query.AppendLine("WHERE C.NumeroDocumento = @NumeroDocumento");



                    //                    select u.IdUsuario,u.UsuarioLogin,u.NombreCompleto,u.Correo,u.Pass,u.Estado, r.IdRol, r.Descripcion from usuario u
                    //inner join ROL r on r.IdRol = u.IdRol

                    SqlCommand cmd = new SqlCommand(query.ToString(), objconexion);
                    cmd.Parameters.AddWithValue("@NumeroDocumento", numero);

                    cmd.CommandType = CommandType.Text;

                    objconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {

                            compra = new Compra()
                            {
                                IdCompra = Convert.ToInt32(dr["IdCompra"]),
                                objUsuario = new Usuario() { UsuarioLogin = dr["UsuarioLogin"].ToString() },
                                objProveedor = new Proveedor() { Documento = dr["Documento"].ToString(),RazonSocial = dr["RazonSocial"].ToString() },
                                TipoDocumento = dr["TipoDocumento"].ToString(),
                                NumeroDocumento = dr["NumeroDocumento"].ToString(),
                                MontoTotal = Convert.ToDecimal( dr["MontoTotal"].ToString()),
                                fechaRegistro = dr["FechaRegistro"].ToString()



                            };

                            //lista.Add(new Usuario()
                            //{
                            //    IdUsuario = Convert.ToInt32(dr["IdUsuario"]),
                            //    UsuarioLogin = dr["UsuarioLogin"].ToString(),
                            //    NombreCompleto = dr["NombreCompleto"].ToString(),
                            //    Correo = dr["Correo"].ToString(),
                            //    Pass = dr["Pass"].ToString(),
                            //    Estado = Convert.ToBoolean(dr["Estado"]),
                            //    objRol = new Rol() { IdRol = Convert.ToInt32(dr["IdRol"]), Descripcion = dr["Descripcion"].ToString() }

                            //});
                        }
                    }
                }
                catch (Exception e)
                {
                    compra = new Compra();

                }
            }

            return compra;

        }



        public List<Detalle_Compra> ObtenerDetalleCompra(int idCompra)
        {
            List<Detalle_Compra> detalle_Compra = new List<Detalle_Compra>();

            try
            {
                using(SqlConnection connection =  new SqlConnection(Conexion.conexion))
                {
                    connection.Open();
                    StringBuilder query = new StringBuilder();

                    /*
                     * SELECT p.Nombre,p.Descripcion,dc.PrecioCompra,dc.Cantidad,dc.MontoTotal
                       FROM DETALLE_COMPRA dc 
                       inner join PRODUCTO p ON p.IdProducto = dc.IdProducto
                       WHERE dc.IdCompra=1
                     * 
                     * **/

                    query.AppendLine("SELECT p.Nombre,p.Descripcion,dc.PrecioCompra,dc.Cantidad,dc.MontoTotal");
                    query.AppendLine("FROM DETALLE_COMPRA dc ");
                    query.AppendLine("inner join PRODUCTO p ON p.IdProducto = dc.IdProducto");
                    query.AppendLine("WHERE dc.IdCompra= @IdCompra");


                    SqlCommand cmd = new SqlCommand(query.ToString(), connection);
                    cmd.Parameters.AddWithValue("@IdCompra", idCompra);
                    cmd.CommandType = System.Data.CommandType.Text;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while(dr.Read())
                        {
                            detalle_Compra.Add(new Detalle_Compra()
                            {
                                objProducto = new Producto() { Nombre= dr["Nombre"].ToString(), Descripcion = dr["Descripcion"].ToString() },
                                PrecioCompra = Convert.ToDecimal(dr["PrecioCompra"].ToString()),
                                Cantidad = Convert.ToInt32(dr["Cantidad"].ToString()),
                                MontoTotal = Convert.ToDecimal(dr["MontoTotal"].ToString()),


                            });
                        }
                    }


                }
            }
            catch (Exception)
            {

                detalle_Compra = new List<Detalle_Compra>();
            }

            return detalle_Compra;
        }
        
    }
}
