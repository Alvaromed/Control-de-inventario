using Control_de_inventario.ConboBox;
using Control_de_inventario.SegundosFormCompras;
using Entidad;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_de_inventario
{
    public partial class FormCompras : Form
    {

        private Usuario usuario;

        public FormCompras(Usuario objUsuario = null)
        {
            usuario = objUsuario;

            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void FormCompras_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = usuario.UsuarioLogin;

            List<Proveedor> proveedor = new N_Proveedor().List();

            foreach (Proveedor item in proveedor)
            {
                comboRazonSocial.Items.Add(new OPcionCombo() { Texto = item.RazonSocial });
            }
            comboRazonSocial.DisplayMember = "Texto";//MessageBox.Show(usuario.NombreCompleto);




            comboTipoDocumento.Items.Add(new OPcionCombo() { Valor = "Ticket", Texto = "Ticket" });
            comboTipoDocumento.Items.Add(new OPcionCombo() { Valor = "Factura", Texto = "Factura" });

            comboTipoDocumento.DisplayMember = "Texto";
            comboTipoDocumento.ValueMember = "Valor";
            comboTipoDocumento.SelectedIndex = 0;




            txtIdProveedor.Text = "0";
            txtIdProducto.Text = "0";



            //this.MaximumSize = SystemInformation.PrimaryMonitorMaximizedWindowSize;
            //this.WindowState = FormWindowState.Maximized;

        }

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            using (var segundoForm = new SF_Proveedor())
            {
                var resultado = segundoForm.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    txtIdProveedor.Text = segundoForm.proveedor.IdProveedor.ToString();
                    txtNumDocumento.Text = segundoForm.proveedor.Documento;
                    comboRazonSocial.Text = segundoForm.proveedor.RazonSocial;

                }
                else
                {
                    txtNumDocumento.Select();
                }
            }
        }

        private void txtBuscarProducto_Click(object sender, EventArgs e)
        {

            using (var segundoForm = new SF_Producto())
            {
                var resultado = segundoForm.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    txtIdProducto.Text = segundoForm.producto.IdProducto.ToString();
                    txtCodigo.Text = segundoForm.producto.Codigo;
                    txtProducto.Text = segundoForm.producto.Nombre;
                    txtDescripcion.Text = segundoForm.producto.Descripcion;
                    txtPrecoiCompra.Select();
                }
                else
                {
                    txtCodigo.Select();
                }
            }

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            /*
             *En este if lo que se hace es que si tenemos una entrada de teclado,
             *que en este caso se le asignó a la tecla enter haga lo que está ahí 
             */
            if (e.KeyData == Keys.Enter)
            {
                /*
                 * Estamos generando un objeto de la clase productos tomando la lista generada, 
                 * donde (where) se hace una expresión lambda   
                 * en donde p(productos) .Codigo sea igual a lo que está en la caja de texto 
                 * y el estado del producto sea true, si es así que devuelva los valores asignados o
                 * de lo contrario devuelva un null (FirsOrDefault);
                 */
                Producto producto = new N_Producto().List().Where(p => p.Codigo == txtCodigo.Text  /*&& p.Descripcion == txtDescripcion.Text*/ && p.Estado == true).FirstOrDefault();

                // Si realmente encontró valores 
                if (producto != null)
                {
                    txtCodigo.BackColor = Color.Honeydew;
                    txtIdProducto.Text = producto.IdProducto.ToString();
                    txtProducto.Text = producto.Nombre;
                    txtDescripcion.Text = producto.Descripcion;
                    txtPrecoiCompra.Select();

                }
                else
                {
                    txtCodigo.BackColor = Color.MistyRose;
                    txtIdProducto.Text = "0";
                    txtProducto.Text = "";
                }
            }
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            decimal precioCompra = 0;
            decimal precioVenta = 0;
            bool productoExistente = false;


            if (int.Parse(txtIdProducto.Text) == 0)
            {
                MessageBox.Show("No ha selecionado un producto para el registro", "Producto no registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            /*
             * Esto es para que intetente convertir el precio de compra en decimal, si es correcto devolverá un true pero,
             * tenemos una negación al principio así que devuelve un false
             */
            if (!decimal.TryParse(txtPrecoiCompra.Text, out precioCompra))
            {
                MessageBox.Show("Precio Compra \nEl formato utilizado para llenar el recuadro es incorrecto,\n Utilice números", "Formato Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPrecoiCompra.Select();
                return;
            }
            /*
             * Esto es para que intetente convertir el precio de compra en decimal, si es correcto devolverá un true pero,
             * tenemos una negación al principio así que devuelve un false
             */

            if (!decimal.TryParse(txtPrecioVenta.Text, out precioVenta))
            {
                MessageBox.Show("Precio Venta \nEl formato utilizado para llenar el recuadro es incorrecto,\n Utilice números", "Formato Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPrecioVenta.Select();
                return;
            }

            if (decimal.Parse(txtPrecoiCompra.Text) < decimal.Parse(txtPrecioVenta.Text))
            {
                /**
            * Recorrido de la tabla dataProductosCompra para saber si el id de producto ya se encuentra registrado y así no hacer registros dobles 
            */
                foreach (DataGridViewRow fila in dataProductosCompra.Rows)
                {
                    try
                    {
                        if (fila.Cells["IdProducto"].Value.ToString() == txtIdProducto.Text)
                        {
                            productoExistente = true;
                            break;
                        }
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }





                }

                //Si el producto no existe se procede a hacer el registro del mismo
                try
                {
                    if (!productoExistente)
                    {
                        dataProductosCompra.Rows.Add(new object[]
                            {
                        txtIdProducto.Text,
                        txtProducto.Text,
                        txtDescripcion.Text,
                        precioCompra.ToString("0.00"),
                        precioVenta.ToString("0.00"),

                        numericCantidad.Value.ToString(),
                        (numericCantidad.Value*precioCompra).ToString("0.00"),
                        (numericCantidad.Value*precioVenta).ToString("0.00")

                            }
                            );

                        LimpiarProducto();
                    }
                    else
                    {
                        MessageBox.Show("El producto ya se encuentra en la lista. \n", "Producto registrado previamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

                CalcularTotal();
                CacularTotalGanancia();

            }
            else
            {
                MessageBox.Show("El precio de compra debe ser menor al de venta", "Venta < Compra", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void LimpiarProducto()
        {
            txtIdProducto.Text = "0";
            txtCodigo.Text = "";
            txtCodigo.BackColor = Color.White;
            txtProducto.Text = "";
            txtDescripcion.Text = "";
            txtPrecoiCompra.Text = "";
            txtPrecioVenta.Text = "";
            numericCantidad.Value = 1;
        }

        private decimal CalcularTotal()
        {
            decimal total = 0;

            if (dataProductosCompra.Rows.Count >= 0)
            {
                foreach (DataGridViewRow fila in dataProductosCompra.Rows)
                {
                    total += Convert.ToDecimal(fila.Cells["SubTotal"].Value.ToString());
                }

                txtTotalPagar.Text = total.ToString("0.00");
            }
            return total;
        }

        private void CalcularGananciaIndividual()
        {
            double precioProducto = Convert.ToDouble(txtPrecoiCompra.Text.ToString());
            double ventaProducto = Convert.ToDouble(txtPrecioVenta.ToString());
            double total = ventaProducto - ventaProducto;
            if (dataProductosCompra.Rows.Count >= 0)
            {
                foreach (DataGridViewRow fila in dataProductosCompra.Rows)
                {
                    total += Convert.ToDouble(fila.Cells["GananciaProducto"].Value.ToString());
                }
            }


        }


        private void CacularTotalGanancia()
        {
            decimal totalGanancia = 0;
            decimal ganacia = 0;

            if (dataProductosCompra.Rows.Count >= 0)
            {
                foreach (DataGridViewRow fila in dataProductosCompra.Rows)
                {
                    totalGanancia += Convert.ToDecimal(fila.Cells["SubGanancia"].Value.ToString());
                }
                ganacia = totalGanancia - CalcularTotal();
                txtTotalGanancia.Text = ganacia.ToString("0.00");
            }

        }

        private void dataProductosCompra_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 8)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var width = Properties.Resources.icons8_trash_25.Width;
                var heigth = Properties.Resources.icons8_trash_25.Height;

                var x = e.CellBounds.Left + (e.CellBounds.Width - width) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - heigth) / 2;

                e.Graphics.DrawImage(Properties.Resources.icons8_trash_25, new System.Drawing.Rectangle(x, y, width, heigth));
                e.Handled = true;
            }
        }

        private void dataProductosCompra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataProductosCompra.Columns[e.ColumnIndex].Name == "btnEliminarProducto")
            {
                string producto = dataProductosCompra.CurrentRow.Cells[1].Value.ToString();
                string descripcion = dataProductosCompra.CurrentRow.Cells[2].Value.ToString();

                int indice = e.RowIndex;

                if (indice >= 0)
                {


                    DialogResult questionProducto = MessageBox.Show("¿Desea eliminar el producto: " + producto + ", " + descripcion + " de la lista?", "Eliminacion de producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (questionProducto == DialogResult.Yes)
                    {
                        dataProductosCompra.Rows.RemoveAt(indice);
                        CalcularTotal();
                        CacularTotalGanancia();
                    }

                }
            }

        }

        private void txtPrecoiCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (txtPrecoiCompra.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
                {
                    e.Handled = true;
                }
                else
                {
                    if (Char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ".")
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void txtPrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (txtPrecioVenta.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
                {
                    e.Handled = true;
                }
                else
                {
                    if (Char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ".")
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void txtTotalPagar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrarProductos_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtIdProveedor.Text) == 0)
            {
                
                txtNumDocumento.BackColor = Color.MistyRose;
                MessageBox.Show("Debes selecionar un proveedor", "Proveedor no selecionado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
                return;
            }

            if (dataProductosCompra.Rows.Count < 1)
            {
                MessageBox.Show("Debe de ingresar al menos un producto a la lista para hacer el registro", "Lista vacía", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            /*
             * Creación de un DataTable solicitado para poder hacer el tipo de dato (@DetalleCompra [EDetalle_Compra] READONLY)
             * de la bd para el procedimiento almacenado Sp_RegistrarCompra
             * 
             */

            //CREATE TYPE[dbo].[EDetalle_Compra] AS TABLE(
            //[IdProducto] int NULL,
            //[PrecioCompra] decimal (5,2) NULL,
            //[PrecioVenta] decimal(5, 2) NULL,
            //[Cantidad] int NULL,
            //[MontoTotal] decimal(5, 2)
            //)


            DataTable detalleCompra = new DataTable();

            detalleCompra.Columns.Add("IdProducto", typeof(int));
            detalleCompra.Columns.Add("PrecioCompra", typeof(decimal));
            detalleCompra.Columns.Add("PrecioVenta", typeof(decimal));
            detalleCompra.Columns.Add("Cantidad", typeof(int));
            detalleCompra.Columns.Add("MontoTotal", typeof(decimal));


            foreach (DataGridViewRow fila in dataProductosCompra.Rows)
            {
                detalleCompra.Rows.Add(
                    new object[]
                    {
                       Convert.ToInt32( fila.Cells["IdProducto"].Value.ToString()),
                       fila.Cells["PrecioCompra"].Value.ToString(),
                       fila.Cells["PrecioVenta"].Value.ToString(),
                       fila.Cells["Cantidad"].Value.ToString(),
                       fila.Cells["SubTotal"].Value.ToString(),

                    }

                    );
            }

            /*verificación del id de compra*/
            int id = new N_Compra().Obtener();
            //Cambia el formato del id obtenido anteriormente asignando 0 a la izquierda para darle un mejor formato
            string numeroDocumento = string.Format("{0:00000}", id);

            Compra compra = new Compra()

            {
                objUsuario = new Usuario() { IdUsuario = usuario.IdUsuario },
                objProveedor = new Proveedor() { IdProveedor = Convert.ToInt32(txtIdProveedor.Text) },
                TipoDocumento = ((OPcionCombo)comboTipoDocumento.SelectedItem).Texto,
                NumeroDocumento = numeroDocumento,
                MontoTotal = Convert.ToDecimal(txtTotalPagar.Text)

            };

            string mensaje = string.Empty;

            bool respuesta = new N_Compra().Registrar(compra, detalleCompra, out mensaje);

            if (respuesta == true)
            {
                //var resultado = MessageBox.Show("Número de Compra: " + numeroDocumento + "\n\n¿Desea copiar el número de compras en el portapapeles?", "Compra registrada", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //if (resultado == DialogResult.Yes)
                //{
                //    Clipboard.SetText(numeroDocumento);

                    


                    ////Agregado 18/03/22
                    string htmlTexto = Properties.Resources.ticket.ToString();
                    E_Negocio negocio = new N_Negocio().ObtenerDatos();

                    htmlTexto = htmlTexto.Replace("@nombrenegocio", negocio.Nombre.ToUpper());
                    htmlTexto = htmlTexto.Replace("@docnegocio", negocio.RFC);
                    htmlTexto = htmlTexto.Replace("@direcnegocio", negocio.Direccion);


                    htmlTexto = htmlTexto.Replace("@tipodocumento", comboTipoDocumento.Text.ToUpper());
                    htmlTexto = htmlTexto.Replace("@numerodocumento", numeroDocumento);


                    htmlTexto = htmlTexto.Replace("@docproveedor", txtNumDocumento.Text);
                    htmlTexto = htmlTexto.Replace("@nombreproveedor", comboRazonSocial.Text);
                    htmlTexto = htmlTexto.Replace("@fecharegistro", txtFecha.Text);
                    htmlTexto = htmlTexto.Replace("@usuarioregistro", lblUsuario.Text);


                    string filas = string.Empty;

                    foreach (DataGridViewRow fila in dataProductosCompra.Rows)
                    {
                        filas += "<tr>";
                        filas += "<td>" + fila.Cells["Nombre"].Value.ToString() + "</td>";
                        filas += "<td>" + fila.Cells["Descripcion"].Value.ToString() + "</td>";
                        filas += "<td>" +"$"+ fila.Cells["PrecioCompra"].Value.ToString() + "</td>";
                        filas += "<td>" + fila.Cells["Cantidad"].Value.ToString() + "</td>";
                        filas += "<td>" +"$"+ fila.Cells["SubTotal"].Value.ToString() + "</td>";
                        filas += "</tr>";

                    }

                    htmlTexto = htmlTexto.Replace("@filas", filas);
                    htmlTexto = htmlTexto.Replace("@montototal", txtTotalPagar.Text);

                    


                    /*
                     * Creación de directorio para guardar los archivos de detalle_compra
                     * **/

                    string carpeta = @"C:\ControlInventario\Compras";
                    if (!Directory.Exists(carpeta))
                    {
                        Directory.CreateDirectory(carpeta);
                    }


                    SaveFileDialog saveFile = new SaveFileDialog();
                    //string formatoHora = DateTime.Now.ToString("dd-MM-yyyy HH-mm-ss");
                    saveFile.FileName = string.Format("COMPRA_" + numeroDocumento + ".pdf");
                    saveFile.Filter = "Pdf Files| *.pdf";
                    saveFile.InitialDirectory = @"C:\ControlInventario\Compras";





                    if (saveFile.ShowDialog() == DialogResult.OK)
                    {
                        using (FileStream stream = new FileStream(saveFile.FileName, FileMode.Create))

                        {
                            Document pdfDoc = new Document(PageSize.B4,10,10,10,10);
                        

                            PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                            pdfDoc.Open();


                            //Ya que el pdf está creado, se abre para poder insertar el logo,
                            // es algo opcional

                            //bool obtenido = true;
                            //byte[] byteImage = new N_Negocio().ObtenerLogo(out obtenido);

                            //if (obtenido)
                            //{
                            //    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(byteImage);

                            //    img.ScaleToFit(60, 60);

                            //    img.Alignment = iTextSharp.text.Image.UNDERLYING;
                            //    img.SetAbsolutePosition(pdfDoc.Left, pdfDoc.GetTop(51));

                            //    pdfDoc.Add(img);
                            //}

                            using (StringReader sr = new StringReader(htmlTexto))
                            {
                                XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                            }
                            pdfDoc.Close();
                            stream.Close();

                            MessageBox.Show("Documento generado", "Creación de PDF", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }


                        /*
                         * Aquí es para poder imprimir el ticket
                         * 
                         * 
                         */
                        //string Filepath = @"C:\ControlInventario\DetalleCompras\COMPRA_" + numeroDocumento + ".pdf";
                        //using (PrintDialog Dialog = new PrintDialog())
                        //{
                        //    Dialog.ShowDialog();

                        //    ProcessStartInfo printProcessInfo = new ProcessStartInfo()
                        //    {
                        //        Verb = "print",
                        //        CreateNoWindow = true,
                        //        FileName = Filepath,
                        //        WindowStyle = ProcessWindowStyle.Hidden
                        //    };

                        //    Process printProcess = new Process();
                        //    printProcess.StartInfo = printProcessInfo;
                        //    printProcess.Start();

                        //    printProcess.WaitForInputIdle();

                        //    Thread.Sleep(3000);

                        //    if (false == printProcess.CloseMainWindow())
                        //    {
                        //        printProcess.Kill();
                        //    }
                        // }

                        txtIdProveedor.Text = "0";
                        txtNumDocumento.Text = "";
                        comboRazonSocial.Text = "";
                        dataProductosCompra.Rows.Clear();
                        CalcularTotal();
                        CacularTotalGanancia();
                    }
                //}
            else
            {
                MessageBox.Show(mensaje, "Error Registro Compra", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
                }

        } 

        private void comboRazonSocial_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                Proveedor proveedor = new Proveedor();


                proveedor.RazonSocial = comboRazonSocial.Text.ToString();
                //proveedor.IdProveedor = Convert.ToInt32(txtIdProveedor.Text.ToString());

                string resultado = new N_Proveedor().Consulta(proveedor);

                txtIdProveedor.Text = proveedor.IdProveedor.ToString();
                txtNumDocumento.Text = proveedor.Documento.ToString();
            }
            catch (Exception exs)
            {

                MessageBox.Show("Error: \n"+exs.Message+"---\n"+exs.StackTrace);
            }



        }

        private void txtFecha_TextChanged(object sender, EventArgs e)
        {

        }

        private void timerHoraCompra_Tick(object sender, EventArgs e)
        {
            txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTicket_Click(object sender, EventArgs e)
        {

            //using (File.Create(@"C:\ControlInventario\DetalleCompras\COMPRA_" + numeroDocumento + ".pdf"))

            //{ 
            
            //}
            //    string Filepath = @"C:\ControlInventario\DetalleCompras\COMPRA_" + numeroDocumento + ".pdf";
            //using (PrintDialog Dialog = new PrintDialog())
            //{
            //    Dialog.ShowDialog();

            //    ProcessStartInfo printProcessInfo = new ProcessStartInfo()
            //    {
            //        Verb = "print",
            //        CreateNoWindow = true,
            //        FileName = Filepath,
            //        WindowStyle = ProcessWindowStyle.Hidden
            //    };

            //    Process printProcess = new Process();
            //    printProcess.StartInfo = printProcessInfo;
            //    printProcess.Start();

            //    printProcess.WaitForInputIdle();

            //    Thread.Sleep(3000);

            //    if (false == printProcess.CloseMainWindow())
            //    {
            //        printProcess.Kill();
            //    }
            //}
        }

        private void txtFecha_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
    }
}
