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
    public class D_Rol
    {
        public List<Rol> List()
        {
            List<Rol> lista = new List<Rol>();

            using (SqlConnection objconexion = new SqlConnection(Conexion.conexion))
            {
                try
                {
                    //StringBuilder nos permite hacer saltos de línea
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select IdRol,Descripcion from ROL");
                  


                    //select p.IdRol,p.NombreMenu from PERMISO p
                    //inner join Rol r on r.IdRol = p.IdRol
                    //inner join USUARIO u on u.IdRol = r.IdRol

                    //where u.IdUsuario = 2

                    // string query = "select IdUsuario,UsuarioLogin,NombreCompleto,Correo,Pass,Estado from usuario";

                    SqlCommand cmd = new SqlCommand(query.ToString(), objconexion);

                    //Parameter.Addwithvalue nos sirve para tomar el parametro y remplazarlo por el valor del objeto dado después de la coma
                    cmd.CommandType = CommandType.Text;

                    objconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Rol()
                            {
                                IdRol = Convert.ToInt32(dr["IdRol"]),
                                Descripcion = dr["Descripcion"].ToString()
                            });
                        }
                    }
                }
                catch (Exception e)
                {
                    lista = new List<Rol>();

                }
            }
            return lista;
        }
    }
}
