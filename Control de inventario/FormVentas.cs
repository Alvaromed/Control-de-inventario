using Control_de_inventario.ConboBox;
using Control_de_inventario.SegundosFormCompras;
using Entidad;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_de_inventario
{
    public partial class FormVentas : Form
    {
        private Usuario usuario;

        public FormVentas(Usuario objUsuario = null)
        {
            usuario = objUsuario;

            InitializeComponent();
        }

        public FormVentas()
        {
            InitializeComponent();
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormVentas_Load(object sender, EventArgs e)
        {
            comboTipoDocumento.Items.Add(new OPcionCombo() { Valor = "Ticket", Texto = "Ticket" });
            comboTipoDocumento.Items.Add(new OPcionCombo() { Valor = "Factura", Texto = "Factura" });

            comboTipoDocumento.DisplayMember = "Texto";
            comboTipoDocumento.ValueMember = "Valor";
            comboTipoDocumento.SelectedIndex = 0;

            txtIdProducto.Text = "0";

            txtPagaCon.Text = "0.00";
            txtCambio.Text = "0.00";
            txtTotalPagar.Text = "0.00";

            
        }

        private void timerHoraVenta_Tick(object sender, EventArgs e)
        {
            txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
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
                    txtPrecioVenta.Text = segundoForm.producto.PrecioVenta.ToString("0.00");
                    txtStock.Text = segundoForm.producto.Stock.ToString();

                    numericCantidad.Select();
                }
                else
                {
                    txtCodigo.Select();
                }
            }
        }

        private void txtPagaCon_TextChanged(object sender, EventArgs e)
        {
            //if (txtPagaCon.Select() && txtPagaCon.Text == string.Empty)
            //{
            //    txtPagaCon.Text = "0.00";
            //}

            //txtPagaCon.Text == string.Empty
        }

        private void txtPagaCon_Click(object sender, EventArgs e)
        {
            if (txtPagaCon.Text == "0.00")
            {
                txtPagaCon.Text = string.Empty;
            }
        }

        private void txtPagaCon_CursorChanged(object sender, EventArgs e)
        {
           
        }

        private void txtPagaCon_TabIndexChanged(object sender, EventArgs e)
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
                    txtPrecioVenta.Text = producto.PrecioVenta.ToString(); 
                    txtStock.Text = producto.Stock.ToString();

                    numericCantidad.Select();

                }
                else
                {
                    txtCodigo.BackColor = Color.MistyRose;
                    txtIdProducto.Text = "0";
                    txtProducto.Text = string.Empty;
                    txtDescripcion.Text = string.Empty;
                    txtPrecioVenta.Text = string.Empty;
                    txtStock.Text = string.Empty;
                }
            }
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
           
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

            if (!decimal.TryParse(txtPrecioVenta.Text, out precioVenta))
            {
                MessageBox.Show("Precio  \nEl formato utilizado para llenar el recuadro es incorrecto", "Formato Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPrecioVenta.Select();
                return;
            }

            if (Convert.ToInt32(txtStock.Text) > Convert.ToInt32(numericCantidad.Value.ToString()))
            {
            
            /**
            * Recorrido de la tabla dataProductosVenta para saber si el id de producto ya se encuentra registrado y así no hacer registros dobles 
            */
                foreach (DataGridViewRow fila in dataProductosVenta.Rows)
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
                        string mensaje = string.Empty;
                        bool respuesta = new N_Venta().RestarStock(
                            Convert.ToInt32(txtIdProducto.Text),
                            Convert.ToInt32(numericCantidad.Value.ToString())
                            );
                        if (respuesta)
                        {
                            dataProductosVenta.Rows.Add(new object[]
                         {
                        txtIdProducto.Text,
                        txtProducto.Text,
                        txtDescripcion.Text,
                        precioVenta.ToString("0.00"),
                        numericCantidad.Value.ToString(),
                        (numericCantidad.Value * precioVenta).ToString("0.00")

                         }
                         );
                            CalcularTotal();
                            LimpiarProducto();
                            txtCodigo.Select();
                            
                        }

                     
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
                
                
                

            }
            else
            {
                MessageBox.Show("El Stock debe de ser mayor que la cantidad a vender", "Falta producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

       

        private void dataProductosVenta_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 6)
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

        private void dataProductosVenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataProductosVenta.Columns[e.ColumnIndex].Name == "btnEliminarProducto")
            {
                string producto = dataProductosVenta.CurrentRow.Cells[1].Value.ToString();
                string descripcion = dataProductosVenta.CurrentRow.Cells[2].Value.ToString();

                int indice = e.RowIndex;

                if (indice >= 0)
                {


                    DialogResult questionProducto = MessageBox.Show("¿Desea eliminar el producto: " + producto + ", " + descripcion + " de la lista?", "Eliminacion de producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (questionProducto == DialogResult.Yes)
                    {
                        bool respuesta = new N_Venta().SumarStock(

                           Convert.ToInt32( dataProductosVenta.Rows[indice].Cells["IdProducto"].Value.ToString()),
                           Convert.ToInt32(dataProductosVenta.Rows[indice].Cells["Cantidad"].Value.ToString())

                            );

                        dataProductosVenta.Rows.RemoveAt(indice);
                        CalcularTotal();
                        CalcularCambio();
                    }
                    if (indice ==0)
                    {
                        txtPagaCon.Text = "0.00";
                        
                        txtCambio.Text = "0.00";
                    }

                }
            }
        }

        

        private void txtPagaCon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (txtPagaCon.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
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

        private void txtPagaCon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter || e.KeyData == Keys.Space)
            {
                if (txtPagaCon.Text == string.Empty)
                {
                    txtPagaCon.Text = "0.00";
                }
                CalcularCambio();
            }

            
        }


        private void LimpiarProducto()
        {
            txtIdProducto.Text = "0";
            txtCodigo.Text = "";
            txtCodigo.BackColor = Color.White;
            txtProducto.Text = "";
            txtDescripcion.Text = "";
            txtStock.Text = string.Empty;
            txtPrecioVenta.Text = "";
            numericCantidad.Value = 1;
        }

        private decimal CalcularTotal()
        {
            decimal total = 0;

            if (dataProductosVenta.Rows.Count >= 0)
            {
                foreach (DataGridViewRow fila in dataProductosVenta.Rows)
                {
                    total += Convert.ToDecimal(fila.Cells["SubTotal"].Value.ToString());
                }

                txtTotalPagar.Text = total.ToString("0.00");
            }
            return total;
        }

        private void CalcularCambio()
        {
            decimal totalPago = Convert.ToDecimal(txtTotalPagar.Text);
            decimal pago;

            if (txtPagaCon.Text.Trim() == "0.00")
            {
                txtPagaCon.Text = "0";
                CalcularCambio();
                return;
            }

            if (decimal.TryParse(txtPagaCon.Text.Trim(), out pago))
            {
                if (pago > totalPago)
                {
                    decimal cambio = pago - totalPago;

                    txtCambio.Text = cambio.ToString("0.00");
                }
                else if(pago < totalPago)
                {
                    txtCambio.Text = "0.00";
                    MessageBox.Show("Debe pagar con la misma o mayor cantidad del total", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else if(pago == totalPago)
                    txtCambio.Text = "0.00";

            }


        }

        private void numericCantidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter   || e.KeyData == Keys.Space)
            {
                btnAgregarProducto_Click( sender, e);

        }   }

        private void btnRegistrarProductos_Click(object sender, EventArgs e)
        {

        }
    }
}
