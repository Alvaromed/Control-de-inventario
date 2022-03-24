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
    public class D_Venta
    {

        public int Obtener()
        {

            int id = 0;

            using (SqlConnection connection = new SqlConnection(Conexion.conexion))
            {
                try
                {
                    StringBuilder query = new StringBuilder();

                    query.AppendLine("SELECT Count(*)+1 FROM VENTA");
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


        public bool Registrar(Venta venta, DataTable detalleVenta, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;
            using (SqlConnection connection = new SqlConnection(Conexion.conexion))
            {
                try
                {

                    SqlCommand cmd = new SqlCommand("Sp_RegistrarVenta", connection);


                    /*
                     * CREATE PROCEDURE Sp_RegistrarVenta(
                        @IdUsuario int,
                        @TipoDocumento varchar(55),
                        @NumeroDocumento varchar(55),
                        @MontoPago decimal(5,2),
                        @MontoCambio decimal(5,2),
                        @MontoTotal decimal (5,2),
                        @DetalleVenta [EDetalle_Venta] READONLY,
                        
                        
                        @Resultado bit output,
                        @Mensaje varchar(500) output
                        
                        )
                    
                    )*/
                    cmd.Parameters.AddWithValue("IdUsuario", venta.objUsuario.IdUsuario);
                    cmd.Parameters.AddWithValue("TipoDocumento", venta.TipoDocumento);
                    cmd.Parameters.AddWithValue("NumeroDocumento", venta.NumeroDocumento);
                    cmd.Parameters.AddWithValue("MontoPago",venta.MontoPago);
                    cmd.Parameters.AddWithValue("MontoCambio",venta.MontoCambio);
                    cmd.Parameters.AddWithValue("MontoTotal", venta.MontoTotal);
                    cmd.Parameters.AddWithValue("DetalleCompra", detalleVenta);

                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

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



        public bool RestarStock(int idProducto, int cantidad)
        {
            bool respuesta = true;

            using(SqlConnection connection = new SqlConnection(Conexion.conexion))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("UPDATE producto set stock = stock - @cantidad WHERE idProducto = @idProducto");
                    SqlCommand cmd = new SqlCommand(query.ToString(), connection);
                    cmd.Parameters.AddWithValue("@cantidad", cantidad);
                    cmd.Parameters.AddWithValue("@idProducto", idProducto);

                    cmd.CommandType = CommandType.Text;
                    connection.Open();


                    /*
                     * ExecuteNonQuery ejecuta la instrucción en la conexión y devuelve el número de filas afectadas
                     * 
                     * si es correcto tiene que ser > 0 y devuelva true, si no false
                     * **/
                    respuesta = cmd.ExecuteNonQuery() > 0 ? true : false;
                }
                catch (Exception ex)
                {

                    respuesta = false;
                }
            }
            return respuesta;
        }



        public bool SumarStock(int idProducto, int cantidad)
        {
            bool respuesta = true;

            using (SqlConnection connection = new SqlConnection(Conexion.conexion))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("UPDATE producto set stock = stock + @cantidad WHERE idProducto = @idProducto");
                    SqlCommand cmd = new SqlCommand(query.ToString(), connection);
                    cmd.Parameters.AddWithValue("@cantidad", cantidad);
                    cmd.Parameters.AddWithValue("@idProducto", idProducto);

                    cmd.CommandType = CommandType.Text;
                    connection.Open();


                    /*
                     * ExecuteNonQuery ejecuta la instrucción en la conexión y devuelve el número de filas afectadas
                     * 
                     * si es correcto tiene que ser > 0 y devuelva true, si no false
                     * **/
                    respuesta = cmd.ExecuteNonQuery() > 0 ? true : false;
                }
                catch (Exception ex)
                {

                    respuesta = false;
                }
            }
            return respuesta;
        }


    }
}
