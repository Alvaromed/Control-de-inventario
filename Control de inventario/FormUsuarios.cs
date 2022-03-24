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
    public partial class FormUsuarios : Form
    {
        public FormUsuarios()
        {
            InitializeComponent();
            this.toolMessage.SetToolTip(txtUsuario, "Introduce el usuario");
            this.toolMessage.SetToolTip(txtNombre, "Introduce el nombre");
            this.toolMessage.SetToolTip(txtCorreo, "Introduce el correo");
            this.toolMessage.SetToolTip(txtPass, "Introduce la contraseña");
            this.toolMessage.SetToolTip(txtConfirPass, "Introduce la confirmación de contraseña");
            this.toolMessage.SetToolTip(btnBuscar, "Buscar");






        }


        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            comboEstado.Items.Add(new OPcionCombo() { Valor = 1,Texto = "Activo"});
            comboEstado.Items.Add(new OPcionCombo() { Valor = 0, Texto = "Desactivado" });

            comboEstado.DisplayMember = "Texto";
            comboEstado.ValueMember = "Valor";
            comboEstado.SelectedIndex = 0;

            //Obtener la lista de los roles
            List<Rol> listRol = new N_Rol().List();

            foreach (Rol item in listRol)
            {
                comboRol.Items.Add(new OPcionCombo() { Valor = item.IdRol, Texto = item.Descripcion });
            }
                comboRol.DisplayMember = "Texto";
                comboRol.ValueMember = "Valor";
                comboRol.SelectedIndex = 0;
            

            //Permite buscar y llenar el combo de busqueda para saber que columna es la que hará en la búsqueda
            foreach (DataGridViewColumn column in dataUsuarios.Columns)
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
            List<Usuario> listaUsuarios = new N_Usuario().List();

            foreach (Usuario item in listaUsuarios)
            {
                dataUsuarios.Rows.Add(new object[] {"",item.IdUsuario,item.UsuarioLogin,item.NombreCompleto,item.Correo,item.Pass,
                 item.objRol.IdRol,
                 item.objRol.Descripcion,
                 item.Estado == true ?  1 : 0,
                 item.Estado == true ? "Activo" : "Desactivado",

                });

            }
         

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            string mensaje = string.Empty;

            Usuario usuario = new Usuario()
            {

                //Lenado de todos los campos dentro de FormUsuarios
                IdUsuario = Convert.ToInt32(txtId.Text),
                UsuarioLogin = txtUsuario.Text,
                NombreCompleto = txtNombre.Text,
                Correo = txtCorreo.Text,
                Pass = txtPass.Text,
                objRol = new Rol() { IdRol = Convert.ToInt32( ((OPcionCombo)comboRol.SelectedItem).Valor) },
                Estado = Convert.ToInt32(((OPcionCombo)comboEstado.SelectedItem).Valor) == 1 ? true : false
            
            };

            //Condición para crear un usuario nuevo sin que seleccione alguno de los demás
            if (usuario.IdUsuario == 0)
            {
                //Ejecución del método Registrar que se encuentra en la clase N_usuario, dandole a idUsuarioGenerado el valor necesario para ser comparado 
                int idUsuarioGenerado = new N_Usuario().Registrar(usuario, out mensaje);

                if (idUsuarioGenerado != 0)
                {
                    dataUsuarios.Rows.Add(new object[] {"",idUsuarioGenerado,txtUsuario.Text,txtNombre.Text,txtCorreo.Text,txtPass.Text,
                    ((OPcionCombo)comboRol.SelectedItem).Valor.ToString(),
                    ((OPcionCombo)comboRol.SelectedItem).Texto.ToString(),
                    ((OPcionCombo)comboEstado.SelectedItem).Valor.ToString(),
                    ((OPcionCombo)comboEstado.SelectedItem).Texto.ToString(),
                    });

                    MessageBox.Show("Usuario: " + txtUsuario.Text + " registrado exitosamente", "Registro Usuario", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    BorrarCampos();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }

            }

            else
            {
                bool editar = new N_Usuario().Edit(usuario, out mensaje);

                if (editar == true )
                {
                    DataGridViewRow fila = dataUsuarios.Rows[Convert.ToInt32( txtIndiceFila.Text)];

                    fila.Cells["IdUsuario"].Value = txtId.Text;
                    fila.Cells["UsuarioLogin"].Value = txtUsuario.Text;
                    fila.Cells["NombreCompleto"].Value = txtNombre.Text;
                    fila.Cells["Correo"].Value = txtCorreo.Text;
                    fila.Cells["Pass"].Value = txtPass.Text;
                    fila.Cells["Pass"].Value = txtConfirPass.Text;
                    fila.Cells["IdRol"].Value = ((OPcionCombo)comboRol.SelectedItem).Valor.ToString();
                    fila.Cells["Rol"].Value = ((OPcionCombo)comboRol.SelectedItem).Texto.ToString();
                    fila.Cells["EstadoValor"].Value = ((OPcionCombo)comboEstado.SelectedItem).Valor.ToString();
                    fila.Cells["Estado"].Value = ((OPcionCombo)comboEstado.SelectedItem).Texto.ToString();

                    MessageBox.Show("Usuario: " + txtUsuario.Text + " a sido modificado correctamente", "Edición de usuario",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
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
            txtUsuario.Text = "";
            txtNombre.Text = "";
            txtCorreo.Text = "";
            txtPass.Text = "";
            txtConfirPass.Text = "";
            comboRol.SelectedIndex = 0;
            comboEstado.SelectedIndex = 0;

            txtUsuario.Select();
        }

        private void label11_Click(object sender, EventArgs e)
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



            if (e.ColumnIndex == 10)
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
        

        private void dataUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                
            //Aquí hacemos que en el DataGridView cada que seleccionemos btnSeleccionarUsuario que está antes de Usuario, mande los datos de esa columna
            //hacia los TextBox y así poder editar la información de el usuario seleccionado
            if (dataUsuarios.Columns[e.ColumnIndex].Name == "btnSeleccionarUsuario")
            {

                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    txtIndiceFila.Text = indice.ToString();
                    txtId.Text = dataUsuarios.Rows[indice].Cells["IdUsuario"].Value.ToString();
                    txtUsuario.Text = dataUsuarios.Rows[indice].Cells["UsuarioLogin"].Value.ToString();
                    txtNombre.Text = dataUsuarios.Rows[indice].Cells["NombreCompleto"].Value.ToString();
                    txtCorreo.Text = dataUsuarios.Rows[indice].Cells["Correo"].Value.ToString();
                    txtPass.Text = dataUsuarios.Rows[indice].Cells["Pass"].Value.ToString();
                    txtConfirPass.Text = dataUsuarios.Rows[indice].Cells["Pass"].Value.ToString();


                    //Permite encontrar que Rol tiene el usuario seleccionado
                    foreach(OPcionCombo oPcionCombo in comboRol.Items)
                    {
                        if (Convert.ToInt32(oPcionCombo.Valor) == Convert.ToInt32(dataUsuarios.Rows[indice].Cells["IdRol"].Value))
                        {
                            int indice_combo = comboRol.Items.IndexOf(oPcionCombo);
                            comboRol.SelectedIndex = indice_combo;
                            break;
                        }
                    }


                    //Permite encontrar si el usuario seleccionado  está activo 
                    foreach (OPcionCombo oPcionCombo in comboEstado.Items)
                    {
                        if (Convert.ToInt32(oPcionCombo.Valor) == Convert.ToInt32(dataUsuarios.Rows[indice].Cells["EstadoValor"].Value))
                        {
                            int indice_combo = comboEstado.Items.IndexOf(oPcionCombo);
                            comboEstado.SelectedIndex = indice_combo;
                            break;
                        }
                    }


                }

            }

            if (dataUsuarios.Columns[e.ColumnIndex].Name == "btnEliminarUsuario")
            {
                string usuarioNombre = dataUsuarios.CurrentRow.Cells[2].Value.ToString();
                string nombre = dataUsuarios.CurrentRow.Cells[3].Value.ToString();

                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    txtIndiceFila.Text = indice.ToString();
                    txtId.Text = dataUsuarios.Rows[indice].Cells["IdUsuario"].Value.ToString();


                    DialogResult questionProducto = MessageBox.Show("¿Desea eliminar el usuario: " + usuarioNombre + ", nombre:" + nombre + " de la lista?", "Eliminacion de producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (questionProducto == DialogResult.Yes)
                    {
                        string mensaje = string.Empty;

                        Usuario usuario = new Usuario()
                        {

                            //Lenado de todos los campos dentro de FormUsuarios
                            IdUsuario = Convert.ToInt32(txtId.Text),

                        };

                        bool eliminar = new N_Usuario().Delete(usuario, out mensaje);
                        if (eliminar)
                        {
                            dataUsuarios.Rows.RemoveAt(Convert.ToInt32(txtIndiceFila.Text));
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
            if (Convert.ToInt32(txtId.Text) !=0)
            {
                if(MessageBox.Show("¿Desea eliminar al usuario?","Eliminación de usuario",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    string mensaje = string.Empty;

                    Usuario usuario = new Usuario()
                    {

                        //Lenado de todos los campos dentro de FormUsuarios
                        IdUsuario = Convert.ToInt32(txtId.Text),
                      
                    };

                    bool eliminar = new N_Usuario().Delete(usuario, out mensaje);
                    if(eliminar)
                    {
                        dataUsuarios.Rows.RemoveAt(Convert.ToInt32( txtIndiceFila.Text));
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

            if (progressBarListaProductos.Value == 2500)
            {
                //Nos ayudará a filtrar la columna de búsqueda
                string columna = ((OPcionCombo)comboBuscar.SelectedItem).Valor.ToString();

                if (dataUsuarios.Rows.Count > 0)
                {
                    progressBarListaProductos.Value = 1;
                    foreach (DataGridViewRow fila in dataUsuarios.Rows)
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
            txtBuscar.Text = "";
            
            foreach (DataGridViewRow fila in dataUsuarios.Rows)
            {
                fila.Visible = true;
            }
        }

        private void FormUsuarios_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            BorrarCampos();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
