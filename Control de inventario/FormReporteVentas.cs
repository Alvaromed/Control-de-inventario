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
using System.Windows.Forms.DataVisualization.Charting;

namespace Control_de_inventario
{
    public partial class FormReporteVentas : Form
    {
        public static string conexion = ConfigurationManager.ConnectionStrings["con"].ToString();
        SqlCommand cmd;
        SqlDataReader dr;

        public FormReporteVentas()
        {
            InitializeComponent();
        }

        ArrayList listaCategorias = new ArrayList();
        ArrayList listaCantProductos = new ArrayList();


        ArrayList listaCategoriasVentas = new ArrayList();
        ArrayList listaCantidadVentasCategoria = new ArrayList();

        ArrayList listaVentasPorUsuario = new ArrayList();
        ArrayList listaCantidadVentasPorUsuario = new ArrayList();

        ArrayList listaProductosVenta = new ArrayList();
        ArrayList listaNumeroProductosVenta = new ArrayList();


        private void FormReporteVentas_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columna in dataReportesCompra.Columns)
            {
                comboBuscar.Items.Add(new OPcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
            }

            comboBuscar.DisplayMember = "Texto";
            comboBuscar.ValueMember = "Valor";
            comboBuscar.SelectedIndex = 0;

            ArrayList lista = new ArrayList();
            ArrayList lista2 = new ArrayList();
            lista.Add("");
            lista2.Add(1);

            
            //GraficaCategorias();
            chartVentaPorUsuario.Titles.Add("Ventas de Productos por Empleado");
            chartCategoriasVentas.Titles.Add("Categoria Más Vendida");
            chartProductosVenta.Titles.Add("Productos Vendidos");

            
            chartVentaPorUsuario.Series[0].Points.DataBindXY(lista, lista2);
            chartCategoriasVentas.Series[0].Points.DataBindXY(lista, lista2);
            chartProductosVenta.Series[0].Points.DataBindXY(lista, lista2);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
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

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            

            progressBarListaProductos.Visible = true;

            int valorMinimo, valorMaximo;
            valorMinimo = progressBarListaProductos.Minimum = 1;
            valorMaximo = progressBarListaProductos.Maximum = 2500;

            for (int i = valorMinimo; i <= valorMaximo; i++)
            {
                progressBarListaProductos.Value = i;
                progressBarListaProductos.PerformStep();
                this.btnBuscar.Cursor = Cursors.WaitCursor;

            }

            if (progressBarListaProductos.Value == 2500)
            {
                

                List<ReporteVentas> listaReporteVentas = new List<ReporteVentas>();

                listaReporteVentas = new N_Reporte().Ventas(txtFechaInicio.Value.ToString(), txtFechaFin.Value.ToString());

                dataReportesCompra.Rows.Clear();
                

                foreach (ReporteVentas rv in listaReporteVentas)
                {
                    dataReportesCompra.Rows.Add(new object[]
                        {
                        rv.FechaRegistro,
                        rv.TipoDocumento,
                        rv.NumeroDocumento,
                        rv.MontoTotal,
                        rv.Usuario,
                        rv.CodigoProducto,
                        rv.NombreProducto,
                        rv.DescripcionProducto,
                        rv.NombreCategoria,
                        rv.PrecioVenta,
                        rv.Cantidad,
                        rv.SubTotal
                        }
                        );
                    //Series series = chartProductosPreferidos.Series.Add(rv.NombreProducto.ToString());
                    //series.Points.Add(Convert.ToDouble(rv.SubTotal));

                }
                
                GraficaVentasPorEmpleado();
                GraficaVentasPorCategoria();
                GraficaVentasPorProducto();


                progressBarListaProductos.Visible = false;
                //CalcularTotal();
                CalcularTotalVenta();



                


            }
            
        }

        //private decimal CalcularTotal()
        //{
        //    decimal total = 0;

        //    if (dataReportesCompra.Rows.Count >= 0)
        //    {
        //        foreach (DataGridViewRow fila in dataReportesCompra.Rows)
        //        {
        //            total += Convert.ToDecimal(fila.Cells["SubTotal"].Value.ToString());
        //        }

        //        txtTotal.Text = total.ToString("0.00");
        //    }
        //    return total;
        //}

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

        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (dataReportesCompra.Rows.Count < 1)
            {
                MessageBox.Show("No existe registro para crear el excel", "Sin datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

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
                                      filas.Cells[11].Value.ToString()
                                      //filas.Cells[12].Value.ToString(),
                                      //filas.Cells[13].Value.ToString(),
                                      //filas.Cells[14].Value.ToString()

                            }
                            );
                    }

                }
                string carpeta = @"C:\ControlInventario\Reporte_Ventas";
                if (!Directory.Exists(carpeta))
                {
                    Directory.CreateDirectory(carpeta);
                }


                SaveFileDialog saveFile = new SaveFileDialog();
                string formatoHora = DateTime.Now.ToString("dd-MM-yyyy HH-mm-ss");
                var nombreArchivo = saveFile.FileName = string.Format("Reporte_Ventas_" + formatoHora + ".xlsx");
                saveFile.Filter = "Excel Files | *.xlsx";
                saveFile.InitialDirectory = @"C:\ControlInventario\Reporte_Ventas";

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

                        //ws.Cell("A1").Value = "Total Compra";
                        //ws.Cell("A2").Value = txtTotal.Text;

                        ws.Cell("C1").Value = "Total Ganancia";
                        ws.Cell("C2").Value = txtGanancia.Text;

                        hoja.ColumnsUsed().AdjustToContents();
                        ws.ColumnsUsed().AdjustToContents();
                        //Aquí guardamos eñ archivo excel con el nombre asignado previamente
                        excel.SaveAs(saveFile.FileName);
                        MessageBox.Show("Reporte: " + nombreArchivo + " generado", "Reporte Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch
                    {
                        MessageBox.Show("Error al generar el reporte" + nombreArchivo +"", "Reporte Excel", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
            }

        private void btnGrafico_Click(object sender, EventArgs e)
        {
            FormGraficosVentas graficosVentas = new FormGraficosVentas();
            graficosVentas.Show();
        }


        //private void GraficaCategorias()
        //{
        //    using (SqlConnection connection = new SqlConnection(conexion))
        //    {
        //        cmd = new SqlCommand("ProductosPorCategoria2", connection);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        connection.Open();
        //        dr = cmd.ExecuteReader();

        //        while (dr.Read())
        //        {
        //            listaCategorias.Add(dr.GetString(0));
        //            listaCantProductos.Add(dr.GetInt32(1));
        //        }
        //        chartProductosPorCategoria.Series[0].Points.DataBindXY(listaCategorias, listaCantProductos);
        //        dr.Close();
        //        connection.Close();
        //    }
        //}


        /*
         * 
         * Método que nos ayuda a llenar la gráfica mediante un procedimiento almacenado el cual nos
         * devuelve las ventas que hizo algún empleado en las fechas estimadas mediante los DateTime
         * 
         * **/
        private void GraficaVentasPorEmpleado()
        {
            

            using (SqlConnection connection = new SqlConnection(conexion))
            {
                cmd = new SqlCommand("VENTASEMPLEADOS", connection);
                cmd.Parameters.AddWithValue("FechaInicio", txtFechaInicio.Value.ToString());
                cmd.Parameters.AddWithValue("FechaFin",  txtFechaFin.Value.ToString());
                cmd.CommandType = CommandType.StoredProcedure;
                connection.Open();
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    listaVentasPorUsuario.Add(dr.GetString(0));
                    listaCantidadVentasPorUsuario.Add(dr.GetInt32(1));
                }
                
                
                dr.Close();
                
                chartVentaPorUsuario.Series[0].Points.DataBindXY(listaVentasPorUsuario, listaCantidadVentasPorUsuario);

                listaVentasPorUsuario.Clear();
                listaCantidadVentasPorUsuario.Clear();
                connection.Close();
            }
            
        }


        /*
        * 
        * Método que nos ayuda a llenar la gráfica mediante un procedimiento almacenado el cual nos
        * devuelve de que categría se venden más productos en las fechas estimadas mediante los DateTime
        * 
        * **/
        private void GraficaVentasPorCategoria()
        {


            using (SqlConnection connection = new SqlConnection(conexion))
            {
                cmd = new SqlCommand("VENTASCATEGORIAS", connection);
                cmd.Parameters.AddWithValue("FechaInicio", txtFechaInicio.Value.ToString());
                cmd.Parameters.AddWithValue("FechaFin", txtFechaFin.Value.ToString());
                cmd.CommandType = CommandType.StoredProcedure;
                connection.Open();
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    listaCategoriasVentas.Add(dr.GetString(0));
                    listaCantidadVentasCategoria.Add(dr.GetInt32(1));
                }


                dr.Close();

                chartCategoriasVentas.Series[0].Points.DataBindXY(listaCategoriasVentas, listaCantidadVentasCategoria);

                listaCategoriasVentas.Clear();
                listaCantidadVentasCategoria.Clear();
                connection.Close();
            }

        }


        private void GraficaVentasPorProducto()
        {


            using (SqlConnection connection = new SqlConnection(conexion))
            {
                cmd = new SqlCommand("VENTASPRODUCTO", connection);
                cmd.Parameters.AddWithValue("FechaInicio", txtFechaInicio.Value.ToString());
                cmd.Parameters.AddWithValue("FechaFin", txtFechaFin.Value.ToString());
                cmd.CommandType = CommandType.StoredProcedure;
                connection.Open();
                dr = cmd.ExecuteReader();
                
                while (dr.Read())
                {
                    listaProductosVenta.Add(dr.GetString(0));
                    listaNumeroProductosVenta.Add(dr.GetInt32(1));
                }


                dr.Close();

                chartProductosVenta.Series[0].Points.DataBindXY(listaProductosVenta, listaNumeroProductosVenta);

                listaProductosVenta.Clear();
                listaNumeroProductosVenta.Clear();
                connection.Close();
            }

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
