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
    public partial class SF_Proveedor : Form
    {

        public Proveedor proveedor { get; set; }

        public SF_Proveedor()
        {
            InitializeComponent();
        }

        private void SF_Compras_Load(object sender, EventArgs e)
        {

            //Permite buscar y llenar el combo de busqueda para saber que columna es la que hará en la búsqueda
            foreach (DataGridViewColumn column in dataProveedor.Columns)
            {

                if (column.Visible == true )
                {
                    comboBuscar.Items.Add(new OPcionCombo() { Valor = column.Name, Texto = column.HeaderText });
                }

            }

            comboBuscar.DisplayMember = "Texto";
            comboBuscar.ValueMember = "Valor";
            comboBuscar.SelectedIndex = 0;


            //Muesta todos los Proveedors
            List<Proveedor> listaProveedor = new N_Proveedor().List();

            foreach (Proveedor item in listaProveedor)
            {
                dataProveedor.Rows.Add(new object[] {
                 item.IdProveedor,
                 item.Documento,
                 item.RazonSocial,
                

                });

            }

        }

        private void dataProveedor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = e.RowIndex;
            int Columna = e.ColumnIndex;

            if(fila >=0 && Columna >0)
            {
                proveedor = new Proveedor()
                {
                    IdProveedor = Convert.ToInt32(dataProveedor.Rows[fila].Cells["IdProveedor"].Value.ToString()),
                    Documento = dataProveedor.Rows[fila].Cells["Documento"].Value.ToString(),
                    RazonSocial = dataProveedor.Rows[fila].Cells["RazonSocial"].Value.ToString()

                };

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            //Nos ayudará a filtrar la columna de búsqueda
            string columna = ((OPcionCombo)comboBuscar.SelectedItem).Valor.ToString();

            if (dataProveedor.Rows.Count > 0)
            {
                foreach (DataGridViewRow fila in dataProveedor.Rows)
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
