using ClosedXML.Excel;
using Control_de_inventario.ConboBox;
using Entidad;
using Negocio;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_de_inventario
{
    public partial class FormReporteCompras : Form
    {

        /*
         * Esto nos sirve para poder hacer la conexión a la base de datos
         * 
         */
        public static string conexion = ConfigurationManager.ConnectionStrings["con"].ToString();
        SqlCommand cmd;
        SqlDataReader dr;

        public FormReporteCompras()
        {
            InitializeComponent();
        }

        /*
         *Estas listas nos sirven para poder almaccenar la información de los procedimientos almacenados y 
         *así poder representarlo mediante gráficas
         * 
         */
        ArrayList listaCompraProducto = new ArrayList();
        ArrayList listaNumeroCompraProducto = new ArrayList();


        ArrayList listaComprasEmpleado = new ArrayList();
        ArrayList listaCantidadComprasEmpleado = new ArrayList();

        ArrayList listaComprasPorCategoria = new ArrayList();
        ArrayList listaCantidadComprasPorCategoria = new ArrayList();

        ArrayList listaCompraProveedores = new ArrayList();
        ArrayList listaNumeroCompraProveedores = new ArrayList();


        private void FormReporteCompras_Load(object sender, EventArgs e)
        {
            List<Proveedor> listaProveedores = new N_Proveedor().List();

            comboRazonSocial.Items.Add(new OPcionCombo() { Valor = 0, Texto = "TODOS" });

            foreach (Proveedor proveedor in listaProveedores)
            {
                comboRazonSocial.Items.Add(new OPcionCombo() { Valor = proveedor.IdProveedor,Texto = proveedor.RazonSocial });
            }
            comboRazonSocial.DisplayMember = "Texto";
            comboRazonSocial.ValueMember = "Valor";
            comboRazonSocial.SelectedIndex = 0;

            foreach (DataGridViewColumn columna in dataReportesCompra.Columns)
            {
                comboBuscar.Items.Add(new OPcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
            }

            comboBuscar.DisplayMember = "Texto";
            comboBuscar.ValueMember = "Valor";
            comboBuscar.SelectedIndex = 0;

            chartComprasEmpleado.Titles.Add("Compras por Empleado");
            chartComprasCategoria.Titles.Add("Compras por Categoría");
            chartCompraProductos.Titles.Add("Compras por Producto");
            chartCompraProveedores.Titles.Add("Compras por Proveedor");

            ArrayList lista = new ArrayList();
            ArrayList lista2 = new ArrayList();
            lista.Add("");
            lista2.Add(1);

            chartCompraProductos.Series[0].Points.DataBindXY(lista, lista2);
            chartCompraProveedores.Series[0].Points.DataBindXY(lista, lista2);
            chartComprasCategoria.Series[0].Points.DataBindXY(lista, lista2);
            chartComprasEmpleado.Series[0].Points.DataBindXY(lista, lista2);


        }

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            int idProveedor = Convert.ToInt32(((OPcionCombo)comboRazonSocial.SelectedItem).Valor.ToString());

            List<ReporteCompras> listaReporteCompras = new List<ReporteCompras>();

            listaReporteCompras = new N_Reporte().Compra(
                txtFechaInicio.Value.ToString(),
                txtFechaFin.Value.ToString(),
                idProveedor
                );


            dataReportesCompra.Rows.Clear();

            foreach (ReporteCompras rc in listaReporteCompras)
            {
                dataReportesCompra.Rows.Add(new object[] {

                    rc.FechaRegistro,
                    rc.TipoDocumento,
                    rc.NumeroDocumento,
                    rc.MontoTotal,
                    rc.Usuario,
                    rc.NumeroProveedor,
                    rc.Proveedor,
                    rc.CodigoProducto,
                    rc.NombreProducto,
                    rc.DescripcionProducto,
                    rc.NombreCategoria,
                    rc.PrecioCompra,
                    rc.PrecioVenta,
                    rc.Cantidad,
                    rc.SubTotal
                    
                });
            }

            CalcularTotal();
            CalcularTotalVenta();
            Double ganacia = Double.Parse(txtVenta.Text)- Double.Parse(txtTotal.Text);
            txtGanancia.Text = ganacia.ToString("0.00");
            GraficaComprasPorCategoria();
            GraficaComprasPorEmpleado();
            GraficaCompraPorProveedores();
            GraficaCompraProducto();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (dataReportesCompra.Rows.Count<1)
            {
                MessageBox.Show("No existe registro para crear el excel","Sin datos",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);

            }
            else
            {

                //Crear una tabla para poder pegarla en Excel
                DataTable dataTable = new DataTable();

                foreach (DataGridViewColumn columna in dataReportesCompra.Columns)
                {
                    
                    
                        dataTable.Columns.Add(columna.HeaderText, typeof(string));
                    
                }

                foreach (DataGridViewRow filas in dataReportesCompra.Rows)
                {
                    if (filas.Visible)
                    {
                        dataTable.Rows.Add(new object[]
                            {
                                      filas.Cells[0].Value.ToString(),
                                      filas.Cells[1].Value.ToString(),
                                      filas.Cells[2].Value.ToString(),
                                      filas.Cells[3].Value.ToString(),
                                      filas.Cells[4].Value.ToString(),
                                      filas.Cells[5].Value.ToString(),
                                      filas.Cells[6].Value.ToString(),
                                      filas.Cells[7].Value.ToString(),
                                      filas.Cells[8].Value.ToString(),
                                      filas.Cells[9].Value.ToString(),
                                      filas.Cells[10].Value.ToString(),
                                      filas.Cells[11].Value.ToString(),
                                      filas.Cells[12].Value.ToString(),
                                      filas.Cells[13].Value.ToString(),
                                      filas.Cells[14].Value.ToString()

                            }
                            );
                    }

                }
                string carpeta = @"C:\ControlInventario\Reporte_Compras";
                if (!Directory.Exists(carpeta))
                {
                    Directory.CreateDirectory(carpeta);
                }


                SaveFileDialog saveFile = new SaveFileDialog();
                string formatoHora = DateTime.Now.ToString("dd-MM-yyyy HH-mm-ss");
                 var nombreArchivo = saveFile.FileName = string.Format("Reporte_Compras_" + formatoHora + ".xlsx");
                saveFile.Filter = "Excel Files | *.xlsx";
                saveFile.InitialDirectory = @"C:\ControlInventario\Reporte_Compras";

                //Condición para cuando el diálogo de creación del archivo es OK 
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        //Creamos el libro excel 
                        XLWorkbook excel = new XLWorkbook();
                    
                        //Creamos la hoja ajustandola a las medidas de nuestro dataTable generado
                        var hoja = excel.Worksheets.Add(dataTable, "Informe");

                        var ws = excel.Worksheets.Add("Totales");

                        ws.Cell("B1").Value = "Total Venta";
                        ws.Cell("B2").Value = txtVenta.Text;

                        ws.Cell("A1").Value = "Total Compra";
                        ws.Cell("A2").Value = txtTotal.Text;

                        ws.Cell("C1").Value = "Total Ganancia";
                        ws.Cell("C2").Value = txtGanancia.Text;

                        hoja.ColumnsUsed().AdjustToContents();
                        ws.ColumnsUsed().AdjustToContents();
                        //Aquí guardamos eñ archivo excel con el nombre asignado previamente
                        excel.SaveAs(saveFile.FileName);
                        MessageBox.Show("Reporte: "+ nombreArchivo + " generado", "Reporte Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch
                    {
                        MessageBox.Show("Error al generar el reporte", "Reporte Excel", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }


            }
        }
        private decimal CalcularTotal()
        {
            decimal total = 0;

            if (dataReportesCompra.Rows.Count >= 0)
            {
                foreach (DataGridViewRow fila in dataReportesCompra.Rows)
                {
                    total += Convert.ToDecimal(fila.Cells["SubTotal"].Value.ToString());
                }

                txtTotal.Text = total.ToString("0.00");
            }
            return total;
        }

        private decimal CalcularTotalVenta()
        {
            decimal total = 0;

            if (dataReportesCompra.Rows.Count >= 0)
            {
                foreach (DataGridViewRow fila in dataReportesCompra.Rows)
                {
                    total += Convert.ToDecimal(fila.Cells["PrecioVenta"].Value.ToString()) * Convert.ToInt32(fila.Cells["Cantidad"].Value.ToString());
                }

                txtVenta.Text = total.ToString("0.00");
            }
            return total;
        }


        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            //Nos ayudará a filtrar la columna de búsqueda
            string columna = ((OPcionCombo)comboBuscar.SelectedItem).Valor.ToString();

            if (dataReportesCompra.Rows.Count > 0)
            {
                progressBarListaProductos.Value = 1;
                foreach (DataGridViewRow fila in dataReportesCompra.Rows)
                {
                    if (fila.Cells[columna].Value.ToString().Trim().ToUpper().Contains(txtBuscar.Text.Trim().ToUpper()))
                    {
                        fila.Visible = true;
                        progressBarListaProductos.Visible = false;

                    }
                    else
                    {
                        fila.Visible = false;
                    }
                }

            }
            this.btnBuscar.Cursor = Cursors.Hand;
        }


        /*
         * 
         * Método que nos ayuda a llenar la gráfica mediante un procedimiento almacenado el cual nos
         * devuelve las ventas que hizo algún empleado en las fechas estimadas mediante los DateTime
         * 
         * **/
        private void GraficaComprasPorCategoria()
        {


            using (SqlConnection connection = new SqlConnection(conexion))
            {
                cmd = new SqlCommand("COMPRACATEGORIA", connection);
                cmd.Parameters.AddWithValue("FechaInicio", txtFechaInicio.Value.ToString());
                cmd.Parameters.AddWithValue("FechaFin", txtFechaFin.Value.ToString());
                cmd.CommandType = CommandType.StoredProcedure;
                connection.Open();
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    listaComprasPorCategoria.Add(dr.GetString(0));
                    listaCantidadComprasPorCategoria.Add(dr.GetInt32(1));
                }


                dr.Close();

                chartComprasCategoria.Series[0].Points.DataBindXY(listaComprasPorCategoria, listaCantidadComprasPorCategoria);

                listaComprasPorCategoria.Clear();
                listaCantidadComprasPorCategoria.Clear();
                connection.Close();
            }

        }


        /*
        * 
        * Método que nos ayuda a llenar la gráfica mediante un procedimiento almacenado el cual nos
        * devuelve de que categría se venden más productos en las fechas estimadas mediante los DateTime
        * 
        * **/
        private void GraficaComprasPorEmpleado()
        {


            using (SqlConnection connection = new SqlConnection(conexion))
            {
                cmd = new SqlCommand("COMPRASUSUARIO", connection);
                cmd.Parameters.AddWithValue("FechaInicio", txtFechaInicio.Value.ToString());
                cmd.Parameters.AddWithValue("FechaFin", txtFechaFin.Value.ToString());
                cmd.CommandType = CommandType.StoredProcedure;
                connection.Open();
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    listaComprasEmpleado.Add(dr.GetString(0));
                    listaCantidadComprasEmpleado.Add(dr.GetInt32(1));
                }


                dr.Close();

                chartComprasEmpleado.Series[0].Points.DataBindXY(listaComprasEmpleado, listaCantidadComprasEmpleado);

                listaComprasEmpleado.Clear();
                listaCantidadComprasEmpleado.Clear();
                connection.Close();
            }

        }


        private void GraficaCompraPorProveedores()
        {


            using (SqlConnection connection = new SqlConnection(conexion))
            {
                cmd = new SqlCommand("COMPRASPROVEEDOR", connection);
                cmd.Parameters.AddWithValue("FechaInicio", txtFechaInicio.Value.ToString());
                cmd.Parameters.AddWithValue("FechaFin", txtFechaFin.Value.ToString());
                cmd.CommandType = CommandType.StoredProcedure;
                connection.Open();
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    listaCompraProveedores.Add(dr.GetString(0));
                    listaNumeroCompraProveedores.Add(dr.GetInt32(1));
                }


                dr.Close();

                chartCompraProveedores.Series[0].Points.DataBindXY(listaCompraProveedores, listaNumeroCompraProveedores);

                listaCompraProveedores.Clear();
                listaNumeroCompraProveedores.Clear();
                connection.Close();
            }

        }


        private void GraficaCompraProducto()
        {


            using (SqlConnection connection = new SqlConnection(conexion))
            {
                cmd = new SqlCommand("COMPRAPRODUCTO", connection);
                cmd.Parameters.AddWithValue("FechaInicio", txtFechaInicio.Value.ToString());
                cmd.Parameters.AddWithValue("FechaFin", txtFechaFin.Value.ToString());
                cmd.CommandType = CommandType.StoredProcedure;
                connection.Open();
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    listaCompraProducto.Add(dr.GetString(0));
                    listaNumeroCompraProducto.Add(dr.GetInt32(1));
                }


                dr.Close();

                chartCompraProductos.Series[0].Points.DataBindXY(listaCompraProducto, listaNumeroCompraProducto);

                listaCompraProducto.Clear();
                listaNumeroCompraProducto.Clear();
                connection.Close();
            }

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void comboBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

