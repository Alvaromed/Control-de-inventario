using Control_de_inventario.ConboBox;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad;
using Negocio;

namespace Control_de_inventario
{
    public partial class FormProveedores : Form
    {
        public FormProveedores()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FormProveedores_Load(object sender, EventArgs e)
        {

            comboEstado.Items.Add(new OPcionCombo() { Valor = 1, Texto = "Activo" });
            comboEstado.Items.Add(new OPcionCombo() { Valor = 0, Texto = "Desactivado" });

            comboEstado.DisplayMember = "Texto";
            comboEstado.ValueMember = "Valor";
            comboEstado.SelectedIndex = 0;

            //Permite buscar y llenar el combo de busqueda para saber que columna es la que hará en la búsqueda
            foreach (DataGridViewColumn column in dataProveedor.Columns)
            {

                if (column.Visible == true && column.Name != "btnSeleccionarProveedor")
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
                 dataProveedor.Rows.Add(new object[] {"",
                 item.IdProveedor,
                 item.Documento,
                 item.RazonSocial,
                 item.Correo,
                 item.Telefono,
                 item.Estado == true ?  1 : 0,
                 item.Estado == true ? "Activo" : "Desactivado",

                });

            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {


            string mensaje = string.Empty;

            Proveedor proveedor = new Proveedor()
            {

                //Lenado de todos los campos dentro de FormProveedors
                IdProveedor = Convert.ToInt32(txtId.Text),
                Documento = txtDocumento.Text,
                RazonSocial = txtRazonSocial.Text,
                Correo = txtCorreo.Text,
                Telefono = txtTelefono.Text,
                Estado = Convert.ToInt32(((OPcionCombo)comboEstado.SelectedItem).Valor) == 1 ? true : false

            };

            //Condición para crear un Proveedor nuevo sin que seleccione alguno de los demás
            if (proveedor.IdProveedor == 0)
            {
                //Ejecución del método Registrar que se encuentra en la clase N_Proveedor, dandole a idProveedorGenerado el valor necesario para ser comparado 
                int idProveedorGenerado = new N_Proveedor().Registrar(proveedor, out mensaje);

                if (idProveedorGenerado != 0)
                {
                    dataProveedor.Rows.Add(new object[] {"",idProveedorGenerado,
                    txtDocumento.Text,
                    txtRazonSocial.Text,
                    txtCorreo.Text,
                    txtTelefono.Text,
                    ((OPcionCombo)comboEstado.SelectedItem).Valor.ToString(),
                    ((OPcionCombo)comboEstado.SelectedItem).Texto.ToString(),
                    });

                    MessageBox.Show("Proveedor: " + txtRazonSocial.Text + " registrado exitosamente", "Registro Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    BorrarCampos();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }

            }

            else
            {
                bool editar = new N_Proveedor().Edit(proveedor, out mensaje);

                if (editar == true)
                {
                    DataGridViewRow fila = dataProveedor.Rows[Convert.ToInt32(txtIndiceFila.Text)];

                    fila.Cells["IdProveedor"].Value = txtId.Text;
                    fila.Cells["Documento"].Value = txtDocumento.Text;
                    fila.Cells["RazonSocial"].Value = txtRazonSocial.Text;
                    fila.Cells["Correo"].Value = txtCorreo.Text;
                    fila.Cells["Telefono"].Value = txtTelefono.Text;
                    fila.Cells["EstadoValor"].Value = ((OPcionCombo)comboEstado.SelectedItem).Valor.ToString();
                    fila.Cells["Estado"].Value = ((OPcionCombo)comboEstado.SelectedItem).Texto.ToString();

                    MessageBox.Show("Proveedor: " + txtRazonSocial.Text + " a sido modificado correctamente", "Edición de Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            txtDocumento.Text = "";
            txtRazonSocial.Text = "";
            txtCorreo.Text = "";
            txtTelefono.Text = "";
            comboEstado.SelectedIndex = 0;

            txtDocumento.Select();
        }

        private void dataProveedor_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

            if (e.ColumnIndex == 8)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var width = Properties.Resources.icons8_trash_25.Width;
                var heigth = Properties.Resources.icons8_trash_25.Height;

                var x = e.CellBounds.Left + (e.CellBounds.Width - width) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - heigth) / 2;

                e.Graphics.DrawImage(Properties.Resources.icons8_trash_25, new Rectangle(x, y, width, heigth));
                e.Handled = true;

            }

        }

        private void dataProveedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            //Aquí hacemos que en el DataGridView cada que seleccionemos btnSeleccionarUsuario que está antes de Usuario, mande los datos de esa columna
            //hacia los TextBox y así poder editar la información de el usuario seleccionado
            if (dataProveedor.Columns[e.ColumnIndex].Name == "btnSeleccionarProveedor")
            {

                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    txtIndiceFila.Text = indice.ToString();
                    txtId.Text = dataProveedor.Rows[indice].Cells["IdProveedor"].Value.ToString();
                    txtDocumento.Text = dataProveedor.Rows[indice].Cells["Documento"].Value.ToString();
                    txtRazonSocial.Text = dataProveedor.Rows[indice].Cells["RazonSocial"].Value.ToString();
                    txtCorreo.Text = dataProveedor.Rows[indice].Cells["Correo"].Value.ToString();
                    txtTelefono.Text = dataProveedor.Rows[indice].Cells["Telefono"].Value.ToString();
                    


                 


                    //Permite encontrar si el usuario seleccionado  está activo 
                    foreach (OPcionCombo oPcionCombo in comboEstado.Items)
                    {
                        if (Convert.ToInt32(oPcionCombo.Valor) == Convert.ToInt32(dataProveedor.Rows[indice].Cells["EstadoValor"].Value))
                        {
                            int indice_combo = comboEstado.Items.IndexOf(oPcionCombo);
                            comboEstado.SelectedIndex = indice_combo;
                            break;
                        }
                    }


                }

            }

            if (dataProveedor.Columns[e.ColumnIndex].Name == "btnEliminarProveedor")
            {
                //string usuarioNombre = dataProveedor.CurrentRow.Cells[2].Value.ToString();
                string nombre = dataProveedor.CurrentRow.Cells[3].Value.ToString();

                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    txtIndiceFila.Text = indice.ToString();
                    txtId.Text = dataProveedor.Rows[indice].Cells["IdProveedor"].Value.ToString();


                    DialogResult questionProducto = MessageBox.Show("¿Desea eliminar el proveedor: " + nombre + " de la lista?", "Eliminacion de producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (questionProducto == DialogResult.Yes)
                    {
                        string mensaje = string.Empty;

                        Proveedor proveedor = new Proveedor()
                        {

                            //Lenado de todos los campos dentro de FormUsuarios
                            IdProveedor = Convert.ToInt32(txtId.Text),

                        };

                        bool eliminar = new N_Proveedor().Delete(proveedor, out mensaje);
                        if (eliminar)
                        {
                            dataProveedor.Rows.RemoveAt(Convert.ToInt32(txtIndiceFila.Text));
                            BorrarCampos();
                        }
                        else
                        {
                            MessageBox.Show(mensaje, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }

                }
            }


        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtId.Text) != 0)
            {
                if (MessageBox.Show("¿Desea eliminar al proveedor?", "Eliminación de proveedor", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    string mensaje = string.Empty;

                    Proveedor proveedor= new Proveedor()
                    {

                        //Lenado de todos los campos dentro de FormUsuarios
                        IdProveedor = Convert.ToInt32(txtId.Text),

                    };

                    bool eliminar = new N_Proveedor().Delete(proveedor, out mensaje);
                    if (eliminar)
                    {
                        dataProveedor.Rows.RemoveAt(Convert.ToInt32(txtIndiceFila.Text));
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

            if (progressBarListaProductos.Value ==2500 )
            {
                //Nos ayudará a filtrar la columna de búsqueda
                string columna = ((OPcionCombo)comboBuscar.SelectedItem).Valor.ToString();

                if (dataProveedor.Rows.Count > 0)
                {
                    progressBarListaProductos.Value = 1;
                    foreach (DataGridViewRow fila in dataProveedor.Rows)
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
                    this.btnBuscar.Cursor = Cursors.Hand;
                }
            }

            
        }

        private void btnRestablecerBusqueda_Click(object sender, EventArgs e)
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
                progressBarListaProductos.Value = 1;
                txtBuscar.Text = "";

                foreach (DataGridViewRow fila in dataProveedor.Rows)
                {
                    fila.Visible = true;
                    progressBarListaProductos.Visible = false;
                }
                this.btnBuscar.Cursor = Cursors.Hand;
            }
            



        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            BorrarCampos();
        }
    }


}
