using Entidad;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_de_inventario
{
    public partial class FormNegocio : Form
    {
        public FormNegocio()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        //Array de bytes en objeto de imagen
        public Image ByteToImage(byte[] imageBytes)
        {
            MemoryStream ms = new MemoryStream();
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image imagen = new Bitmap(ms);

            return imagen;
        }


        private void FormNegocio_Load(object sender, EventArgs e)
        {
            bool obtenido = true;

            byte[] byteToImagen = new N_Negocio().ObtenerLogo(out obtenido);

            if(obtenido )
            {
                Logo.Image = ByteToImage(byteToImagen);
            }

            E_Negocio datos = new N_Negocio().ObtenerDatos();

            txtNombre.Text = datos.Nombre;
            txtRFC.Text = datos.RFC;
            txtDireccion.Text = datos.Direccion;
        }

        private void btnLogo_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.FileName = "Files|*.jpg;*.jpeg;*.png";

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                byte[] byteImagen = File.ReadAllBytes(openFileDialog.FileName);
                bool resouesta = new N_Negocio().actualizarLogo(byteImagen,out mensaje);

                if (resouesta)
                {
                    Logo.Image = ByteToImage(byteImagen);

                }
                else
                    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Stop);


            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            E_Negocio negocio = new E_Negocio()
            {
                Nombre = txtNombre.Text,
                RFC = txtRFC.Text,
                Direccion = txtDireccion.Text
            };

            bool respuesta = new N_Negocio().guardarDatos(negocio, out mensaje);

            if (respuesta)
            {
                MessageBox.Show("Los cambios fueron realizados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo realizar el cambio", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void Logo_Click(object sender, EventArgs e)
        {

        }
    }
}
