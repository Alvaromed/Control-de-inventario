using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Entidad;
using Control_de_inventario.ConboBox;
using System.Runtime.InteropServices;

namespace Control_de_inventario
{
    public partial class Login : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
    (
        int nLeftRect, // x-coordinate of upper-left corner
        int nTopRect, // y-coordinate of upper-left corner
        int nRightRect, // x-coordinate of lower-right corner
        int nBottomRect, // y-coordinate of lower-right corner
        int nWidthEllipse, // height of ellipse
        int nHeightEllipse // width of ellipse
        );

        public Login()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

            //List<Usuario> Prueba = new N_Usuario().List();
            //Usuario objUsuario = new N_Usuario().List().Where(u => u.UsuarioLogin == comboUsuario.Text && u.Pass == txtPassword.Text).FirstOrDefault();

            ///*Condición para validar si el usuario existe y le da acceso*/
            //if(objUsuario != null)
            //{
            //    Inicio inicio = new Inicio(objUsuario);

            //    inicio.Show();
            //    this.Hide();

            //    inicio.FormClosing += form_cierre;
            //}
            //else
            //{
            //    MessageBox.Show("Usuario o contraseña incorrecto", "Error inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            

        }

        private void form_cierre(object envio, FormClosingEventArgs e)
        {
            //comboUsuario.Text = "";
            txtPassword.Text = "";
          

            this.Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        //{
        //    if (MessageBox.Show("¿Deseas cerrar sesión?", "Cierre de Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        //    {
        //        Application.Exit();
        //    }
        //}
        {
            this.Close();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            comboUsuario.Select();
            //Obtener la lista de los roles
            List<Usuario> usuario = new N_Usuario().List();

            foreach (Usuario item in usuario)
            {
                comboUsuario.Items.Add(new OPcionCombo() {  Texto = item.UsuarioLogin });
            }
            comboUsuario.DisplayMember = "Texto";
            

           // comboRol.ValueMember = "Valor";
           //comboRol.SelectedIndex = 0;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FormaRedonda(object sender, PaintEventArgs e)
        {
           
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {

            List<Usuario> Prueba = new N_Usuario().List();
            Usuario objUsuario = new N_Usuario().List().Where(u => u.UsuarioLogin == comboUsuario.Text && u.Pass == txtPassword.Text).FirstOrDefault();

            /*Condición para validar si el usuario existe y le da acceso*/
            if (objUsuario != null)
            {
                Inicio inicio = new Inicio(objUsuario);

                inicio.Show();
                this.Hide();

                inicio.FormClosing += form_cierre;
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecto", "Error inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
