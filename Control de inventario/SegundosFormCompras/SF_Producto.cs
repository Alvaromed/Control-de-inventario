using Control_de_inventario.ConboBox;
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

namespace Control_de_inventario.SegundosFormCompras
{
    public partial class SF_Producto : Form
    {
        public Producto producto { get; set; }
        

        public SF_Producto()
        {
            InitializeComponent();
        }

        private void SF_Producto_Load(object sender, EventArgs e)
        {


            //Permite buscar y llenar el combo de busqueda para saber que columna es la que hará en la búsqueda
            foreach (DataGridViewColumn column in dataProductos.Columns)
            {

                if (column.Visible == true )
                {
                    comboBuscar.Items.Add(new OPcionCombo() { Valor = column.Name, Texto = column.HeaderText });
                }

            }

            comboBuscar.DisplayMember = "Texto";
            comboBuscar.ValueMember = "Valor";
            comboBuscar.SelectedIndex = 0;


            //Muesta todos los prductos
            List<Producto> listaProductos = new N_Producto().List();

            foreach (Producto item in listaProductos)
            {
                dataProductos.Rows.Add(new object[]

                 {
                 item.IdProducto,
                 item.Codigo,
                 item.Nombre,
                 item.Descripcion,
                 item.objCategoria.NombreCategoria,
                 item.Stock,
                 item.PrecioCompra,
                 item.PrecioVenta,
                

                });

            }

        }

        private void dataProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = e.RowIndex;
            int Columna = e.ColumnIndex;

            if (fila >= 0 && Columna > 0)
            {
                producto = new Producto()
                {
                    IdProducto = Convert.ToInt32(dataProductos.Rows[fila].Cells["IdProducto"].Value.ToString()),
                    Codigo = dataProductos.Rows[fila].Cells["Codigo"].Value.ToString(),
                    Nombre = dataProductos.Rows[fila].Cells["Nombre"].Value.ToString(),
                    Descripcion = dataProductos.Rows[fila].Cells["Descripcion"].Value.ToString(),
                    //objCategoria = dataProductos.Rows[fila].Cells["Categoria"].Value.ToString(),
                    Stock = Convert.ToInt32(dataProductos.Rows[fila].Cells["Stock"].Value.ToString()),
                    PrecioCompra = Convert.ToDecimal(dataProductos.Rows[fila].Cells["PrecioCompra"].Value.ToString()),
                    PrecioVenta = Convert.ToDecimal(dataProductos.Rows[fila].Cells["PrecioVenta"].Value.ToString()),



                };

                this.DialogResult = DialogResult.OK;
                this.Close();
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
    }
}
