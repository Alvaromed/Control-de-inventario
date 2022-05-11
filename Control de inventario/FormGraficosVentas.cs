using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;


namespace Control_de_inventario
{
    public partial class FormGraficosVentas : Form
    {

        public static string conexion = ConfigurationManager.ConnectionStrings["con"].ToString();
        SqlCommand cmd;
        SqlDataReader dr;

        public FormGraficosVentas()
        {
            InitializeComponent();
        }

        private void FormGraficosVentas_Load(object sender, EventArgs e)
        {
            GraficaCategorias();
            GraficaProductosPref();
            GraficosDatos();
        }

        ArrayList listaCategorias = new ArrayList();
        ArrayList listaCantProductos = new ArrayList();

        ArrayList listaProductos = new ArrayList();
        ArrayList listaCantidad = new ArrayList();

        private void GraficaCategorias()
        {
            using (SqlConnection connection = new SqlConnection(conexion))
            {
                cmd = new SqlCommand("ProductosPorCategoria2", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                connection.Open();
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    listaCategorias.Add(dr.GetString(0));
                    listaCantProductos.Add(dr.GetInt32(1));
                }
                chartProductosPreferidos.Titles.Add("Productos");
                chartProductosPorCategoria.Series[0].Points.DataBindXY(listaCategorias, listaCantProductos);
                dr.Close();
                connection.Close();
            }
        }

        private void GraficaProductosPref()
        {
            using (SqlConnection connection = new SqlConnection(conexion))
            {
                cmd = new SqlCommand("ProdPreferidos", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                connection.Open();
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {

                    listaProductos.Add(dr.GetString(0));
                    listaCantidad.Add(dr.GetInt32(1));
                }
                chartProductosPorCategoria.Titles.Add("Categoría");
                chartProductosPreferidos.Series[0].Points.DataBindXY(listaProductos, listaCantidad);
                dr.Close();
                connection.Close();
            }
        }

        private void GraficosDatos()
        {
            using (SqlConnection connection = new SqlConnection(conexion))
            {
                cmd = new SqlCommand("GraficasTabla", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter total = new SqlParameter("@TotalVentas", 0); total.Direction = ParameterDirection.Output;
                SqlParameter cantProductos = new SqlParameter("@CantProductos", 0); cantProductos.Direction = ParameterDirection.Output;
                SqlParameter cantProductosTotalestal = new SqlParameter("@CantProductosTotales", 0); cantProductosTotalestal.Direction = ParameterDirection.Output;
                SqlParameter NumProveedores = new SqlParameter("@NumProveedores", 0); NumProveedores.Direction = ParameterDirection.Output;
                SqlParameter NumCategorias = new SqlParameter("@NumCategorias", 0); NumCategorias.Direction = ParameterDirection.Output;
                SqlParameter NumUsuarios = new SqlParameter("@NumUsuarios", 0); NumUsuarios.Direction = ParameterDirection.Output;

                cmd.Parameters.Add(total);
                cmd.Parameters.Add(cantProductos);
                cmd.Parameters.Add(cantProductosTotalestal);
                cmd.Parameters.Add(NumProveedores);
                cmd.Parameters.Add(NumCategorias);
                cmd.Parameters.Add(NumUsuarios);


                connection.Open();
                cmd.ExecuteNonQuery();
                lbl.Text = "$ "+cmd.Parameters["@TotalVentas"].Value.ToString();
                lblProductos.Text =  cmd.Parameters["@CantProductos"].Value.ToString();
                lblStock.Text =  cmd.Parameters["@CantProductosTotales"].Value.ToString();
                lblProveedores.Text =  cmd.Parameters["@NumProveedores"].Value.ToString();
                lblCategorias.Text =  cmd.Parameters["@NumCategorias"].Value.ToString();
                lblTrabajadores.Text =  cmd.Parameters["@NumUsuarios"].Value.ToString();



            }
        }

        private void chartProductosPreferidos_Click(object sender, EventArgs e)
        {

        }
    }
}
