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
    public class D_Permiso
    {
        public List<Permiso> List(int idUsuario)
        {
            List<Permiso> lista = new List<Permiso>();

            using (SqlConnection objconexion = new SqlConnection(Conexion.conexion))
            {
                try
                {
                    //StringBuilder nos permite hacer saltos de línea
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select p.IdRol,p.NombreMenu from PERMISO p");
                    query.AppendLine("inner join Rol r on r.IdRol = p.IdRol");
                    query.AppendLine("inner join USUARIO u on u.IdRol = r.IdRol");
                    query.AppendLine("where u.IdUsuario = @idUsuario");


                    //select p.IdRol,p.NombreMenu from PERMISO p
                    //inner join Rol r on r.IdRol = p.IdRol
                    //inner join USUARIO u on u.IdRol = r.IdRol

                    //where u.IdUsuario = 2

                   // string query = "select IdUsuario,UsuarioLogin,NombreCompleto,Correo,Pass,Estado from usuario";

                    SqlCommand cmd = new SqlCommand(query.ToString(), objconexion);

                    //Parameter.Addwithvalue nos sirve para tomar el parametro y remplazarlo por el valor del objeto dado después de la coma
                    cmd.Parameters.AddWithValue("@idUsuario",idUsuario);
                    cmd.CommandType = CommandType.Text;

                    objconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Permiso()
                            {
                                objRol =  new Rol() { IdRol = Convert.ToInt32(dr["IdRol"]) },
                                NombreMenu = dr["NombreMenu"].ToString(),
                               

                            });
                        }
                    }
                }
                catch (Exception e)
                {
                    lista = new List<Permiso>();
                    
                }
            }
            return lista;
        }
    }
}
