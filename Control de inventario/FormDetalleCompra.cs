using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using Negocio;

namespace Control_de_inventario
{
    public partial class FormDetalleCompra : Form
    {
        public FormDetalleCompra()
        {
            InitializeComponent();
        }

        private void FormDetalleCompra_Load(object sender, EventArgs e)
        {
            txtBuscar.Focus();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            progressBarListaProductos.Visible = true;



            //timerProgreso_Tick(sender,e);
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

                Compra compra = new N_Compra().ObtenerCompra(txtBuscar.Text);

                if (compra.IdCompra != 0)
                {
                    txtBuscar.BackColor = Color.Honeydew;

                    txtNumeroDocumentoBuscar.Text = compra.NumeroDocumento;

                    txtFecha.Text = compra.fechaRegistro;
                    txtTipoDocumento.Text = compra.TipoDocumento;
                    txtUsuario.Text = compra.objUsuario.UsuarioLogin;
                    txtNumeroDocumentoProveedor.Text = compra.objProveedor.Documento;
                    txtRazonSocial.Text = compra.objProveedor.RazonSocial;


                    dataDetalleCompra.Rows.Clear();
                    foreach (Detalle_Compra dc in compra.objListDetalleCompra)
                    {
                        dataDetalleCompra.Rows.Add(new object[] { dc.objProducto.Nombre, dc.objProducto.Descripcion, dc.PrecioCompra, dc.Cantidad, dc.MontoTotal });
                    }

                    txtMontoTotal.Text = compra.MontoTotal.ToString("0.00");
                    progressBarListaProductos.Visible = false;
                }
                else
                {
                    txtBuscar.BackColor = Color.MistyRose;

                    txtUsuario.Text = string.Empty;
                    txtTipoDocumento.Text = string.Empty;
                    txtFecha.Text = string.Empty;
                    txtNumeroDocumentoProveedor.Text = string.Empty;
                    txtRazonSocial.Text = string.Empty;
                    txtNumeroDocumentoBuscar.Text = string.Empty;


                    dataDetalleCompra.Rows.Clear();
                    progressBarListaProductos.Visible = false;

                    MessageBox.Show("Compra inexistente\nFavor de verificar el número de documento", "Numero de Documento", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                txtBuscar.BackColor = Color.WhiteSmoke;

                txtUsuario.Text = string.Empty;
                txtTipoDocumento.Text = string.Empty;
                txtFecha.Text = string.Empty;
                txtNumeroDocumentoProveedor.Text = string.Empty;
                txtRazonSocial.Text = string.Empty;
                txtNumeroDocumentoBuscar.Text = string.Empty;

                txtMontoTotal.Text = string.Empty;

                dataDetalleCompra.Rows.Clear();
            }
        }

      

        private void btnExcel_Click(object sender, EventArgs e)
        {
            if(txtTipoDocumento.Text == "")
            {
                MessageBox.Show("No hay registros que exportar","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }

            string htmlTexto = Properties.Resources.pdf_ticket.ToString();
            E_Negocio negocio = new N_Negocio().ObtenerDatos();

            htmlTexto = htmlTexto.Replace("@nombrenegocio",negocio.Nombre.ToUpper());
            htmlTexto = htmlTexto.Replace("@docnegocio",negocio.RFC);
            htmlTexto = htmlTexto.Replace("@direcnegocio",negocio.Direccion);


            htmlTexto = htmlTexto.Replace("@tipodocumento", txtTipoDocumento.Text.ToUpper());
            htmlTexto = htmlTexto.Replace("@numerodocumento", txtNumeroDocumentoBuscar.Text);


            htmlTexto = htmlTexto.Replace("@docproveedor", txtNumeroDocumentoProveedor.Text);
            htmlTexto = htmlTexto.Replace("@nombreproveedor", txtRazonSocial.Text);
            htmlTexto = htmlTexto.Replace("@fecharegistro", txtFecha.Text);
            htmlTexto = htmlTexto.Replace("@usuarioregistro", txtUsuario.Text);


            string filas = string.Empty;

            foreach (DataGridViewRow fila in dataDetalleCompra.Rows)
            {
                filas += "<tr>";
                filas += "<td>" + fila.Cells["Producto"].Value.ToString() + "</td>";
                filas += "<td>" + fila.Cells["Descripcion"].Value.ToString() + "</td>";
                filas += "<td>" + fila.Cells["PrecioCompra"].Value.ToString() + "</td>";
                filas += "<td>" + fila.Cells["Cantidad"].Value.ToString() + "</td>";
                filas += "<td>" + fila.Cells["SubTotal"].Value.ToString() + "</td>";
                filas += "</tr>";

            }

            htmlTexto = htmlTexto.Replace("@filas", filas);
            htmlTexto = htmlTexto.Replace("@montototal", txtMontoTotal.Text);


            /*
             * Creación de directorio para guardar los archivos de detalle_compra
             * **/

            string carpeta = @"C:\ControlInventario\DetalleCompras";
            if (!Directory.Exists(carpeta))
            {
                Directory.CreateDirectory(carpeta);
            }

            SaveFileDialog saveFile = new SaveFileDialog();
            //string formatoHora = DateTime.Now.ToString("dd-MM-yyyy HH-mm-ss");
            saveFile.FileName = string.Format("DETALLE_COMPRA_" + txtNumeroDocumentoBuscar.Text + ".pdf");
            saveFile.Filter = "Pdf Files| *.pdf";
            saveFile.InitialDirectory = @"C:\ControlInventario\DetalleCompras";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(saveFile.FileName,FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4,25,25,25,25);

                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();


                    //Ya que el pdf está creado, se abre para poder insertar el logo,
                    // es algo opcional

                    bool obtenido = true;
                    byte[] byteImage = new N_Negocio().ObtenerLogo(out obtenido);

                    if (obtenido)
                    {
                        iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(byteImage);

                        img.ScaleToFit(60, 60);

                        img.Alignment = iTextSharp.text.Image.UNDERLYING;
                        img.SetAbsolutePosition(pdfDoc.Left,pdfDoc.GetTop(51));

                        pdfDoc.Add(img);
                    }

                    using (StringReader sr = new StringReader(htmlTexto))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }
                    pdfDoc.Close();
                    stream.Close();

                    MessageBox.Show("Documento generado","Creación de PDF",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }


            //string Filepath = @"C:\ControlInventario\DetalleCompras\COMPRA_" + txtNumeroDocumentoBuscar.Text + ".pdf";
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

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {

                btnBuscar_Click(sender, e);

            }
        }
    }
}
