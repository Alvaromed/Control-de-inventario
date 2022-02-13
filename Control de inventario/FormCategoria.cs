
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Control_de_inventario.ConboBox;
using Entidad;
using Negocio;

namespace Control_de_inventario
{
    public partial class FormCategoria : Form
    {
        public FormCategoria()
        {
            InitializeComponent();
        }

        

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtIndiceFila_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRestablecerBusqueda_Click(object sender, EventArgs e)
        {

        }

        private void comboEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboRol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtConfirPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void lblUsuarioLogin_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormCategoria_Load(object sender, EventArgs e)
        {
            comboEstado.Items.Add(new OPcionCombo() { Valor = 1, Texto = "Activo" });
            comboEstado.Items.Add(new OPcionCombo() { Valor = 0, Texto = "Desactivado" });

            comboEstado.DisplayMember = "Texto";
            comboEstado.ValueMember = "Valor";
            comboEstado.SelectedIndex = 0;

            //Permite buscar y llenar el combo de busqueda para saber que columna es la que hará en la búsqueda
            foreach (DataGridViewColumn column in dataCategorias.Columns)
            {

                if (column.Visible == true && column.Name != "btnSeleccionarCategoria")
                {
                    comboBuscar.Items.Add(new OPcionCombo() { Valor = column.Name, Texto = column.HeaderText });
                }

            }

            comboBuscar.DisplayMember = "Texto";
            comboBuscar.ValueMember = "Valor";
            comboBuscar.SelectedIndex = 0;


            //Muesta todos los usuarios
            List<Categoria> listaCategoria = new N_Categoria().List();

            foreach (Categoria item in listaCategoria)
            {
                dataCategorias.Rows.Add(new object[] {"",item.IdCategoria,
                 item.NombreCategoria,
                 item.Estado == true ?  1 : 0,
                 item.Estado == true ? "Activo" : "Desactivado",

                });

            }


        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {

            string mensaje = string.Empty;

            Categoria categoria = new Categoria()
            {

                //Lenado de todos los campos dentro de FormUsuarios
                IdCategoria = Convert.ToInt32(txtId.Text),
                NombreCategoria = txtCategoria.Text,
                Estado = Convert.ToInt32(((OPcionCombo)comboEstado.SelectedItem).Valor) == 1 ? true : false

            };

            //Condición para crear un usuario nuevo sin que seleccione alguno de los demás
            if (categoria.IdCategoria == 0)
            {
                //Ejecución del método Registrar que se encuentra en la clase N_usuario, dandole a idUsuarioGenerado el valor necesario para ser comparado 
                int idCategoriaGenerado = new N_Categoria().Registrar(categoria, out mensaje);

                if (idCategoriaGenerado != 0)
                {
                    dataCategorias.Rows.Add(new object[] 
                    {
                        "",idCategoriaGenerado,txtCategoria.Text,
                        ((OPcionCombo)comboEstado.SelectedItem).Valor.ToString(),
                        ((OPcionCombo)comboEstado.SelectedItem).Texto.ToString(),
                    });

                    MessageBox.Show("Categoria: " + txtCategoria.Text.ToUpper() + " registrado exitosamente", "Registro categoría", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    BorrarCampos();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }

            }

            else
            {
                bool editar = new N_Categoria().Edit(categoria, out mensaje);

                if (editar == true)
                {
                    DataGridViewRow fila = dataCategorias.Rows[Convert.ToInt32(txtIndiceFila.Text)];

                    fila.Cells["IdCategoria"].Value = txtId.Text;
                    fila.Cells["NombreCategoria"].Value = txtCategoria.Text;
                    fila.Cells["EstadoValor"].Value = ((OPcionCombo)comboEstado.SelectedItem).Valor.ToString();
                    fila.Cells["Estado"].Value = ((OPcionCombo)comboEstado.SelectedItem).Texto.ToString();

                    MessageBox.Show("Categoria: " + txtCategoria.Text.ToUpper() + " a sido modificado correctamente", "Edición de categoría", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            txtCategoria.Text = "";
            comboEstado.SelectedIndex = 0;
            
            txtCategoria.Select();
        }

        private void dataCategorias_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void dataCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            //Aquí hacemos que en el DataGridView cada que seleccionemos btnSeleccionarUsuario que está antes de Usuario, mande los datos de esa columna
            //hacia los TextBox y así poder editar la información de el usuario seleccionado
            if (dataCategorias.Columns[e.ColumnIndex].Name == "btnSeleccionarCategoria")
            {

                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    txtIndiceFila.Text = indice.ToString();
                    txtId.Text = dataCategorias.Rows[indice].Cells["IdCategoria"].Value.ToString();
                    txtCategoria.Text = dataCategorias.Rows[indice].Cells["NombreCategoria"].Value.ToString();


                    //Permite encontrar si el usuario seleccionado  está activo 
                    foreach (OPcionCombo oPcionCombo in comboEstado.Items)
                    {
                        if (Convert.ToInt32(oPcionCombo.Valor) == Convert.ToInt32(dataCategorias.Rows[indice].Cells["EstadoValor"].Value))
                        {
                            int indice_combo = comboEstado.Items.IndexOf(oPcionCombo);
                            comboEstado.SelectedIndex = indice_combo;
                            break;
                        }
                    }


                }

            }

        }

        private void btnBorrar_Click_1(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtId.Text) != 0)
            {
                if (MessageBox.Show("¿Desea eliminar la categoría "+ txtCategoria.Text.ToUpper()+"?", "Eliminación de categoría", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    string mensaje = string.Empty;

                    Categoria categoria = new Categoria()
                    {

                        //Lenado de todos los campos dentro de FormUsuarios
                        IdCategoria = Convert.ToInt32(txtId.Text),

                    };

                    bool eliminar = new N_Categoria().Delete(categoria, out mensaje);
                    if (eliminar)
                    {
                        dataCategorias.Rows.RemoveAt(Convert.ToInt32(txtIndiceFila.Text));
                        BorrarCampos();
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {

            //Nos ayudará a filtrar la columna de búsqueda
            string columna = ((OPcionCombo)comboBuscar.SelectedItem).Valor.ToString();

            if (dataCategorias.Rows.Count > 0)
            {
                foreach (DataGridViewRow fila in dataCategorias.Rows)
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

        private void btnRestablecerBusqueda_Click_1(object sender, EventArgs e)
        {
            txtBuscar.Text = "";

            foreach (DataGridViewRow fila in dataCategorias.Rows)
            {
                fila.Visible = true;
            }
        }

        
    }
}
