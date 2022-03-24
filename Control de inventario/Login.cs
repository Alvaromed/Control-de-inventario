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
            this.toolMessage.SetToolTip(txtPassword, "Introduce la contraseña");
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
        {
            
        }
        //{
        //    this.Close();
        //}

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            comboUsuario.Select();
            Cursor = Cursors.Default;
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
            
            if (MessageBox.Show("¿Deseas salir de la aplicación?", "Cierre de aplicación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }

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
            btnEntrar.Visible = false;

           // progressBarListaProductos.Visible = true;
            ProgressBar.Visible = true;
            



            
            int valorMinimo, valorMaximo;
            valorMinimo = progressBarListaProductos.Minimum = 1;
            valorMaximo = progressBarListaProductos.Maximum = 1500;
            valorMinimo = ProgressBar.Minimum = 1;
            valorMaximo = ProgressBar.Maximum = 1500;


            for (int i = valorMinimo; i <= valorMaximo; i++)
            {
                this.Cursor = Cursors.WaitCursor;
                ProgressBar.Value = i;
                ProgressBar.PerformStep();

                progressBarListaProductos.Value = i;
                progressBarListaProductos.PerformStep();
                this.btnEntrar.Cursor = Cursors.WaitCursor;

            }
            if (ProgressBar.Value == 1500)
            {
                List<Usuario> Prueba = new N_Usuario().List();
                Usuario objUsuario = new N_Usuario().List().Where(u => u.UsuarioLogin == comboUsuario.Text && u.Pass == txtPassword.Text).FirstOrDefault();

                /*Condición para validar si el usuario existe y le da acceso*/
                if (objUsuario != null)
                {
                    progressBarListaProductos.Value = 1;
                    Inicio inicio = new Inicio(objUsuario);

                    inicio.Show();
                    this.Hide();
                    progressBarListaProductos.Visible = false;
                    ProgressBar.Visible = false;

                    inicio.FormClosing += form_cierre;
                }
                else
                {
                    progressBarListaProductos.Value = 1;
                    progressBarListaProductos.Visible = false;
                    ProgressBar.Value = 1;
                    ProgressBar.Visible = false;
                    MessageBox.Show("Usuario o contraseña incorrecto", "Error inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
            this.btnEntrar.Cursor = Cursors.Hand;
            this.Cursor = Cursors.Default;

            btnEntrar.Visible = true;

            
        }

        private void comboUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnEntrar_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                
                rjButton1_Click(sender, e);
                
            }
        }

        private void comboUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtPassword.Focus();
            }
            if (e.KeyChar == Convert.ToChar(Keys.Space))
            {
                SendKeys.Send( "{F4}");
            }
        }
    }
}
