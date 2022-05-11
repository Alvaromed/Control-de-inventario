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
using FontAwesome.Sharp;
using Negocio;
using Control_de_inventario.SegundosFormCompras;

namespace Control_de_inventario
{
   
    public partial class Inicio : Form
    {
        private static Usuario usuarioActual;
        private static IconMenuItem MenuACtual = null;
        private static Form FormularioActual = null;
        
        public Inicio(Usuario objUsuario)
        {
            
            usuarioActual = objUsuario;
            InitializeComponent();
        }
        /*
        **  Si queremos hacer que no inicie sesión y poder entrar directo 
        //public Inicio(Usuario objUsuario = null)
        //{
        //    if (objUsuario == null)
        //        usuarioActual = new Usuario() { NombreCompleto = "Ayuda", IdUsuario = 1 };

        //    else
        //         usuarioActual = objUsuario;

        //    InitializeComponent();
        //}
        */

        private void label1_Click(object sender, EventArgs e)
        {
            formOpen((IconMenuItem)sender, new FormClientes());
        }

        private void menuClientes_Click(object sender, EventArgs e)
        {
            formOpen((IconMenuItem)sender, new FormClientes());
        }

        private void menuUsuarios_Click(object sender, EventArgs e)
        {
         
            formOpen((IconMenuItem)sender,new FormUsuarios());
        }

        private void Inicio_FormClosing(object sender, FormClosingEventArgs e)
        {

            //DialogResult cierreForm = MessageBox.Show("¿desea salir al login?","",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            //if (cierreForm == DialogResult.Yes)
            //{
            //    Login login = new Login();
            //    login.Show();
            //    this.Close();
            //}
            //if (MessageBox.Show("¿Deseas cerrar sesión?", "Cierre de Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //{
            //    Application.Exit();
            //}

        }

        private void formOpen(IconMenuItem menu, Form formulario)
        {
            if (MenuACtual != null)
            {
                MenuACtual.BackColor = Color.White;
            }

            menu.BackColor = Color.Gold;
            MenuACtual = menu;

            //Muestra el formulario correspondiente dentro del Panel Contenido
            if (FormularioActual != null)
            {
                FormularioActual.Close();
            }
            //El formulario Actual se convierte en el formulario a mostrar
            FormularioActual = formulario;

            //Configuración del formulario
            formulario.TopLevel = false;

            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.LightGray;

            panelBienvenida.Visible = false;
            lblWelcome.Visible = false;
            lblUsuario.Visible = false;

            //Agrega el formulario a contenido
            contenido.Controls.Add(formulario);
            formulario.Show();
            

        }

            private void labelUsu_Click(object sender, EventArgs e)
        {

        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            //Visualiza los permisos que tiene la persona que inicia sesión
            List<Permiso> listPermisos = new N_Permiso().List(usuarioActual.IdUsuario);

            //Restringe la lista de menu's que puede ver el usuario por su respectivo rol
            foreach (IconMenuItem iconMenu in Menu.Items)
            {
                //Any = determina si una secuencia tiene elementos
                bool existe = listPermisos.Any(m => m.NombreMenu == iconMenu.Name);
                
                if (existe == false)
                {
                    iconMenu.Visible = false;
                }
            }
            
            labelUsu.Text = usuarioActual.UsuarioLogin;
            lblUsuario.Text = usuarioActual.UsuarioLogin;
            //this.MaximumSize = SystemInformation.PrimaryMonitorMaximizedWindowSize;
            //this.WindowState = FormWindowState.Maximized;
        }

        private void menuHerramientas_Click(object sender, EventArgs e)
        {
           
        }

        private void categoria_Click(object sender, EventArgs e)
        {
            formOpen(menuConfiguracion, new FormCategoria());
            
        }

        private void producto_Click(object sender, EventArgs e)
        {
            formOpen(menuConfiguracion, new FormProducto());
        }

        private void menuInfo_Click(object sender, EventArgs e)
        {
            formOpen(menuConfiguracion, new FormInfo());
        }

        private void registrarVenta_Click(object sender, EventArgs e)
        {
            formOpen(menuVentas, new FormVentas(usuarioActual));
        }

        private void detalleVenta_Click(object sender, EventArgs e)
        {
            formOpen(menuVentas, new FormDetalleVenta());
        }

        private void registrarCompra_Click(object sender, EventArgs e)
        {
            formOpen(menuCompras, new FormCompras(usuarioActual));
        }

        private void detalleCompra_Click(object sender, EventArgs e)
        {
            formOpen(menuCompras, new FormDetalleCompra());
        }

        private void menuProveedores_Click(object sender, EventArgs e)
        {
            formOpen((IconMenuItem)sender, new FormProveedores());
        }

       

        private void negocio_Click(object sender, EventArgs e)
        {
            formOpen(menuConfiguracion, new FormNegocio());
        }

        private void timerSistema_Tick(object sender, EventArgs e)
        {
            lblHoraSistema.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void menuProducto_Click(object sender, EventArgs e)
        {
            formOpen(menuProducto, new FormListaProductos());
        }

        private void menuUsuarios_MouseHover(object sender, EventArgs e)
        {
            //this.Cursor = Cursors.Hand;
        }

        private void categoria_MouseHover(object sender, EventArgs e)
        {
            cursorHand();
        }

       

        private void producto_MouseHover(object sender, EventArgs e)
        {
            cursorHand();
        }

        private void negocio_MouseHover(object sender, EventArgs e)
        {
            cursorHand();
        }

        private void menuProducto_MouseHover(object sender, EventArgs e)
        {
            cursorHand();
        }

        private void registrarVenta_MouseHover(object sender, EventArgs e)
        {
            cursorHand();
        }

        private void detalleVenta_MouseHover(object sender, EventArgs e)
        {
            cursorHand();
        }

        private void registrarCompra_MouseHover(object sender, EventArgs e)
        {
            cursorHand();
        }

        private void detalleCompra_MouseHover(object sender, EventArgs e)
        {
            cursorHand();
        }

        private void menuProveedores_MouseHover(object sender, EventArgs e)
        {
            cursorHand();
        }

        private void menuReportes_MouseHover(object sender, EventArgs e)
        {
            cursorHand();
        }

        

        private void lblHoraSistema_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.No;
        }

        private void lblHoraSistema_MouseLeave(object sender, EventArgs e)
        {
            cursorDefault();
        }

       

        private void menuUsuarios_MouseLeave(object sender, EventArgs e)
        {
            cursorDefault();
        }

        private void categoria_MouseLeave(object sender, EventArgs e)
        {
            cursorDefault();
        }

        private void producto_MouseLeave(object sender, EventArgs e)
        {
            cursorDefault();
        }

        private void negocio_MouseLeave(object sender, EventArgs e)
        {
            cursorDefault();
        }

        private void menuProducto_MouseLeave(object sender, EventArgs e)
        {
            cursorDefault();
        }

        private void registrarVenta_MouseLeave(object sender, EventArgs e)
        {
            cursorDefault();
        }

        private void detalleVenta_MouseLeave(object sender, EventArgs e)
        {
            cursorDefault();
        }

        private void registrarCompra_MouseLeave(object sender, EventArgs e)
        {
            cursorDefault();
        }

        private void detalleCompra_MouseLeave(object sender, EventArgs e)
        {
            cursorDefault();
        }

        private void menuProveedores_MouseLeave(object sender, EventArgs e)
        {
            cursorDefault();
        }

        private void menuReportes_MouseLeave(object sender, EventArgs e)
        {
            cursorDefault();
        }

        private void cursorHand()
        {
            this.Cursor = Cursors.Hand;
        }

        private void cursorDefault()
        {
            this.Cursor = Cursors.Default;
        }

        private void Menu_Scroll(object sender, ScrollEventArgs e)
        {

        }

   

        private void iconMenuItem1_Click(object sender, EventArgs e)
        {
            formOpen(menuReportes, new FormReporteCompras());
        }

        private void iconMenuItem2_Click(object sender, EventArgs e)
        {
            formOpen(menuReportes, new FormReporteVentas());
        }

        private void menuReportes_Click(object sender, EventArgs e)
        {

        }

        private void Total_Click(object sender, EventArgs e)
        {
            FormGraficosVentas graficosVentas = new FormGraficosVentas();
            graficosVentas.Show();
        }
    }
}
