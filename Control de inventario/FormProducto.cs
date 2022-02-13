using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
using Control_de_inventario.ConboBox;
using Entidad;
using Negocio;

namespace Control_de_inventario
{
    public partial class FormProducto : Form
    {
        public FormProducto()
        {
            InitializeComponent();
            this.toolMensaje.SetToolTip(this.btnExcel, "Descargar lista en Excel");
            this.toolMensaje.SetToolTip(this.btnBuscar, "Buscar");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

      

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void FormProducto_Load(object sender, EventArgs e)
        {
            txtCodigo.Select();
            comboEstado.Items.Add(new OPcionCombo() { Valor = 1, Texto = "Activo" });
            comboEstado.Items.Add(new OPcionCombo() { Valor = 0, Texto = "Desactivado" });

            comboEstado.DisplayMember = "Texto";
            comboEstado.ValueMember = "Valor";
            comboEstado.SelectedIndex = 0;

            //Obtener la lista de los Categorias para el ComboBox
            List<Categoria> listCategoria = new N_Categoria().List();

            foreach (Categoria item in listCategoria)
            {
                comboCategoría.Items.Add(new OPcionCombo() { Valor = item.IdCategoria, Texto = item.NombreCategoria });
            }
            comboCategoría.DisplayMember = "Texto";
            comboCategoría.ValueMember = "Valor";
            comboCategoría.SelectedIndex = 0;
           

            //Permite buscar y llenar el combo de busqueda para saber que columna es la que hará en la búsqueda
            foreach (DataGridViewColumn column in dataProductos.Columns)
            {

                if (column.Visible == true && column.Name != "btnSeleccionarUsuario")
                {
                    comboBuscar.Items.Add(new OPcionCombo() { Valor = column.Name, Texto = column.HeaderText });
                }

            }

            comboBuscar.DisplayMember = "Texto";
            comboBuscar.ValueMember = "Valor";
            comboBuscar.SelectedIndex = 0;


            //Muesta todos los usuarios
            List<Producto> listaProductos = new N_Producto().List();

            foreach (Producto item in listaProductos)
            {
                dataProductos.Rows.Add(new object[] 
                
                 {"",
                 item.IdProducto,
                 item.Codigo,
                 item.Nombre,
                 item.objCategoria.IdCategoria,
                 item.Descripcion,
                 item.objCategoria.NombreCategoria,
                 item.Stock,
                 item.PrecioCompra,
                 item.PrecioVenta,
                 item.Estado == true ?  1 : 0,
                 item.Estado == true ? "Activo" : "Desactivado",

                });

            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            string mensaje = string.Empty;

            Producto producto = new Producto()
            {

                //Lenado de todos los campos dentro de FormUsuarios
                IdProducto = Convert.ToInt32(txtId.Text),
                Codigo  = txtCodigo.Text,
                Nombre = txtNombreProducto.Text,
                Descripcion = txtDescripcion.Text,
               
                objCategoria = new Categoria() { IdCategoria = Convert.ToInt32(((OPcionCombo)comboCategoría.SelectedItem).Valor) },
                Estado = Convert.ToInt32(((OPcionCombo)comboEstado.SelectedItem).Valor) == 1 ? true : false

            };

            //Condición para crear un usuario nuevo sin que seleccione alguno de los demás
            if (producto.IdProducto == 0)
            {
                //Ejecución del método Registrar que se encuentra en la clase N_usuario, dandole a idUsuarioGenerado el valor necesario para ser comparado 
                int idProductoGenerado = new N_Producto().Registrar(producto, out mensaje);

                if (idProductoGenerado != 0)
                {
                    dataProductos.Rows.Add(new object[] {"",
                        idProductoGenerado,
                        txtCodigo.Text,
                        txtNombreProducto.Text,
                        ((OPcionCombo)comboCategoría.SelectedItem).Valor.ToString(),

                        txtDescripcion.Text,
                        ((OPcionCombo)comboCategoría.SelectedItem).Texto.ToString(),
                        "0",
                        "0.00",
                        "0.00",
                        ((OPcionCombo)comboEstado.SelectedItem).Valor.ToString(),
                        ((OPcionCombo)comboEstado.SelectedItem).Texto.ToString(),
                    });

                    MessageBox.Show("Producto: " + txtNombreProducto.Text + " registrado exitosamente", "Registro Producto", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    BorrarCampos();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }

            }

            else
            {
                bool editar = new N_Producto().Edit(producto, out mensaje);

                if (editar == true)
                {
                    DataGridViewRow fila = dataProductos.Rows[Convert.ToInt32(txtIndiceFila.Text)];

                    fila.Cells["IdProducto"].Value = txtId.Text;
                    fila.Cells["Codigo"].Value = txtCodigo.Text;
                    fila.Cells["Nombre"].Value = txtNombreProducto.Text;
                    fila.Cells["IdCategoria"].Value = ((OPcionCombo)comboCategoría.SelectedItem).Valor.ToString();
                    fila.Cells["Descripcion"].Value = txtDescripcion.Text;
                    fila.Cells["Categoria"].Value = ((OPcionCombo)comboCategoría.SelectedItem).Texto.ToString();
                    fila.Cells["EstadoValor"].Value = ((OPcionCombo)comboEstado.SelectedItem).Valor.ToString();
                    fila.Cells["Estado"].Value = ((OPcionCombo)comboEstado.SelectedItem).Texto.ToString();

                    MessageBox.Show("Producto: " + txtNombreProducto.Text + " a sido modificado correctamente", "Edición de Proucto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    BorrarCampos();

                }
                else
                {
                    MessageBox.Show(mensaje, "Error al editar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        

        }


        private void BorrarCampos()
        {
            txtIndiceFila.Text = "-1";
            txtId.Text = "0";
            txtCodigo.Text = "";
            txtNombreProducto.Text = "";
            txtDescripcion.Text = "";
            comboCategoría.SelectedIndex = 0;
            comboEstado.SelectedIndex = 0;

            txtCodigo.Select();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dataUsuarios_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var width = Properties.Resources.check.Width;
                var heigth = Properties.Resources.check.Height;

                var x = e.CellBounds.Left + (e.CellBounds.Width - width) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - heigth) / 2;

                e.Graphics.DrawImage(Properties.Resources.check, new Rectangle(x, y, width, heigth));
                e.Handled = true;
            }
        }

        private void dataUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            //Aquí hacemos que en el DataGridView cada que seleccionemos btnSeleccionarUsuario que está antes de Usuario, mande los datos de esa columna
            //hacia los TextBox y así poder editar la información de el usuario seleccionado
            if (dataProductos.Columns[e.ColumnIndex].Name == "btnSeleccionarUsuario")
            {

                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    txtIndiceFila.Text = indice.ToString();
                    txtId.Text = dataProductos.Rows[indice].Cells["IdProducto"].Value.ToString();
                    txtCodigo.Text = dataProductos.Rows[indice].Cells["Codigo"].Value.ToString();
                    txtNombreProducto.Text = dataProductos.Rows[indice].Cells["Nombre"].Value.ToString();
                    txtDescripcion.Text = dataProductos.Rows[indice].Cells["Descripcion"].Value.ToString();
                  


                    //Permite encontrar que Rol tiene el usuario seleccionado
                    foreach (OPcionCombo oPcionCombo in comboCategoría.Items)
                    {
                        if (Convert.ToInt32(oPcionCombo.Valor) == Convert.ToInt32(dataProductos.Rows[indice].Cells["IdCategoria"].Value))
                        {
                            int indice_combo = comboCategoría.Items.IndexOf(oPcionCombo);
                            comboCategoría.SelectedIndex = indice_combo;
                            break;
                        }
                    }


                    //Permite encontrar si el usuario seleccionado  está activo 
                    foreach (OPcionCombo oPcionCombo in comboEstado.Items)
                    {
                        if (Convert.ToInt32(oPcionCombo.Valor) == Convert.ToInt32(dataProductos.Rows[indice].Cells["EstadoValor"].Value))
                        {
                            int indice_combo = comboEstado.Items.IndexOf(oPcionCombo);
                            comboEstado.SelectedIndex = indice_combo;
                            break;
                        }
                    }


                }

            }

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtId.Text) != 0)
            {
                if (MessageBox.Show("¿Desea eliminar el producto "+txtNombreProducto.Text+"?", "Eliminación de Producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    string mensaje = string.Empty;

                    Producto producto = new Producto()
                    {

                        //Lenado de todos los campos dentro de FormUsuarios
                        IdProducto= Convert.ToInt32(txtId.Text),

                    };

                    bool eliminar = new N_Producto().Delete(producto, out mensaje);
                    if (eliminar)
                    {
                        dataProductos.Rows.RemoveAt(Convert.ToInt32(txtIndiceFila.Text));
                        BorrarCampos();
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Nos ayudará a filtrar la columna de búsqueda
            string columna = ((OPcionCombo)comboBuscar.SelectedItem).Valor.ToString();

            if (dataProductos.Rows.Count > 0)
            {
                foreach (DataGridViewRow fila in dataProductos.Rows)
                {
                    if (fila.Cells[columna].Value.ToString().Trim().ToUpper().Contains(txtBuscar.Text.Trim().ToUpper()))
                    {
                        fila.Visible = true;
                    }
                    else
                    {
                        fila.Visible = false;
                    }
                }
            }
        }

        private void btnRestablecerBusqueda_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = "";

            foreach (DataGridViewRow fila in dataProductos.Rows)
            {
                fila.Visible = true;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            BorrarCampos();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (dataProductos.Rows.Count < 1)
            {
                MessageBox.Show("No hay datos","Lista Vacía");
            }
            else
            {
                //Crear una tabla para poder pegarla en Excel
                DataTable dataTable = new DataTable();

                foreach (DataGridViewColumn columna in dataProductos.Columns)
                {
                    if (columna.HeaderText != "" && columna.Visible)
                    {
                        dataTable.Columns.Add(columna.HeaderText, typeof(string));
                    }
                }

                foreach(DataGridViewRow filas in dataProductos.Rows)
                {
                       if (filas.Visible)
                       {
                           dataTable.Rows.Add(new object[]
                               {
                                      filas.Cells[2].Value.ToString(),
                                      filas.Cells[3].Value.ToString(),
                                      //filas.Cells[4].Value.ToString(),
                                      filas.Cells[5].Value.ToString(),
                                      filas.Cells[6].Value.ToString(),
                                      filas.Cells[7].Value.ToString(),
                                      filas.Cells[8].Value.ToString(),
                                      filas.Cells[9].Value.ToString(),
                                      //filas.Cells[10].Value.ToString(),
                                      filas.Cells[11].Value.ToString(),

                               }
                               );
                       }
                  
                }
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.FileName = string.Format("REPORTE PRODUCTOS_{0}.xlsx",DateTime.Now.ToString("dd-MM-yyyy_HH:mm:ss"));
                saveFile.Filter = "Excel Files | *.xlsx";

                //Condición para cuando el diálogo de creación del archivo es OK 
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        //Creamos el libro excel 
                        XLWorkbook excel = new XLWorkbook();
                        //Creamos la hoja ajustandola a las medidas de nuestro dataTable generado
                        var hoja = excel.Worksheets.Add(dataTable, "Informe");
                            hoja.ColumnsUsed().AdjustToContents();
                        //Aquí guardamos eñ archivo excel con el nombre asignado previamente
                        excel.SaveAs(saveFile.FileName);
                        MessageBox.Show("Reporte generado", "Reporte Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch
                    {
                        MessageBox.Show("Error al generar el reporte", "Reporte Excel", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
               
            }
        }
    }
}
