using Control_de_inventario.ConboBox;
using Control_de_inventario.SegundosFormCompras;
using Entidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_de_inventario
{
    public partial class FormCompras : Form
    {

        private Usuario usuario;
        public FormCompras(Usuario objUsuario = null)
        {
            usuario = objUsuario;
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void FormCompras_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(usuario.NombreCompleto);
           

           comboTipoDocumento.Items.Add(new OPcionCombo() { Valor = "Ticket", Texto = "Ticket" });
           comboTipoDocumento.Items.Add(new OPcionCombo() { Valor = "Factura", Texto = "Factura" });
           
           comboTipoDocumento.DisplayMember = "Texto";
           comboTipoDocumento.ValueMember = "Valor";
           comboTipoDocumento.SelectedIndex = 0;


            txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy HH:MM:ss");

            txtIdProveedor.Text = "0";
            txtIdProducto.Text = "0";

        }

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            using (var segundoForm = new SF_Proveedor())
            {
                var resultado = segundoForm.ShowDialog(); 

                if(resultado == DialogResult.OK)
                {
                    txtIdProveedor.Text = segundoForm.proveedor.IdProveedor.ToString();
                    txtNumDocumento.Text = segundoForm.proveedor.Documento;
                    comboRazonSocial.Text = segundoForm.proveedor.RazonSocial;

                }
                else
                {
                    txtNumDocumento.Select();
                }
            }
        }
    }
}
