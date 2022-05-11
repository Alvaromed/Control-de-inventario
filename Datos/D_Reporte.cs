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
    public class D_Reporte
    {
        public List<ReporteCompras> Compra(string fechaInicio, string fechaFin,int idProveedor)
        {
            List<ReporteCompras> lista = new List<ReporteCompras>();

            using (SqlConnection objconexion = new SqlConnection(Conexion.conexion))
            {
                try
                {
                    StringBuilder query = new StringBuilder();

                    SqlCommand cmd = new SqlCommand("sp_ReporteCompras", objconexion);
                    cmd.Parameters.AddWithValue("FechaInicio",fechaInicio);
                    cmd.Parameters.AddWithValue("FechaFin",fechaFin);
                    cmd.Parameters.AddWithValue("IdProveedor",idProveedor);
                    cmd.CommandType = CommandType.StoredProcedure;
                    objconexion.Open();


                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new ReporteCompras()
                            {
                                FechaRegistro = dr["FechaRegistro"].ToString(),
                                TipoDocumento = dr["TipoDocumento"].ToString(),
                                NumeroDocumento = dr["NumeroDocumento"].ToString(),
                                MontoTotal = dr["MontoTotal"].ToString(),
                                Usuario = dr["Usuario"].ToString(),
                                NumeroProveedor = dr["NumeroProveedor"].ToString(),
                                Proveedor = dr["Proveedor"].ToString(),
                                CodigoProducto = dr["CodigoProducto"].ToString(),
                                NombreProducto = dr["NombreProducto"].ToString(),
                                DescripcionProducto = dr["DescripcionProducto"].ToString(),
                                NombreCategoria = dr["NombreCategoria"].ToString(),
                                PrecioCompra = dr["PrecioCompra"].ToString(),
                                PrecioVenta = dr["PrecioVenta"].ToString(),
                                Cantidad = dr["Cantidad"].ToString(),
                                SubTotal = dr["SubTotal"].ToString()




                                //public string Proveedor { get; set; }
                                // public string CodigoProducto { get; set; }
                                // public string NombreProducto { get; set; }
                                // public string DescripcionProducto { get; set; }
                                // public string NombreCategoria { get; set; }
                                // public string PrecioCompra { get; set; }
                                // public string PrecioVenta { get; set; }
                                // public string Cantidad { get; set; }
                                // public string SubTotal { get; set; }


                            });
                        }
                    }
                }
                catch (Exception e)
                {
                    lista = new List<ReporteCompras>();

                }
            }
            return lista;
        }



        public List<ReporteVentas> Venta(string fechaInicio, string fechaFin)
        {
            List<ReporteVentas> lista = new List<ReporteVentas>();

            using (SqlConnection objconexion = new SqlConnection(Conexion.conexion))
            {
                try
                {
                    StringBuilder query = new StringBuilder();

                    SqlCommand cmd = new SqlCommand("sp_ReporteVentas", objconexion);
                    cmd.Parameters.AddWithValue("FechaInicio", fechaInicio);
                    cmd.Parameters.AddWithValue("FechaFin", fechaFin);
                    
                    cmd.CommandType = CommandType.StoredProcedure;
                    objconexion.Open();


                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new ReporteVentas()
                            {
                                FechaRegistro = dr["FechaRegistro"].ToString(),
                                TipoDocumento = dr["TipoDocumento"].ToString(),
                                NumeroDocumento = dr["NumeroDocumento"].ToString(),
                                MontoTotal = dr["MontoTotal"].ToString(),
                                Usuario = dr["Usuario"].ToString(),
                                CodigoProducto = dr["CodigoProducto"].ToString(),
                                NombreProducto = dr["NombreProducto"].ToString(),
                                DescripcionProducto = dr["DescripcionProducto"].ToString(),
                                NombreCategoria = dr["NombreCategoria"].ToString(),
                                
                                PrecioVenta = dr["PrecioVenta"].ToString(),
                                Cantidad = dr["Cantidad"].ToString(),
                                SubTotal = dr["SubTotal"].ToString()




                                 //   public string FechaRegistro { get; set; }
                                 //public string TipoDocumento { get; set; }
                                 //public string NumeroDocumento { get; set; }
                                 //public string MontoTotal { get; set; }
                                 //public string Usuario { get; set; }
                                 //public string CodigoProducto { get; set; }
                                 //public string NombreProducto { get; set; }
                                 //public string DescripcionProducto { get; set; }
                                 //public string NombreCategoria { get; set; }
                                 //public string PrecioVenta { get; set; }
                                 //public string Cantidad { get; set; }
                                 //public string SubTotal { get; set; }


                            });
                        }
                        dr.Close();
                    }
                    objconexion.Close();
                }
                catch (Exception e)
                {
                    lista = new List<ReporteVentas>();

                }
            }
            return lista;
        }


    }
}
