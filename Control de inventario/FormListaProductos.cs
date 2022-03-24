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

namespace Control_de_inventario
{
    public partial class FormListaProductos : Form
    {
        public Producto producto { get; set; }

        public FormListaProductos()
        {
            InitializeComponent();
        }

        private void FormListaProductos_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn column in dataProductos.Columns)
            {

                if (column.Visible == true)
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

      
        //private void timerProgreso_Tick(object sender, EventArgs e)
        //{
        //    timerProgreso.Start();
        //    this.progressBarListaProductos.Increment(5);
        //    //for (int i = 0; i <= progressBarListaProductos.Maximum ; i++)
        //    //{
                

        //    //}
        //    if(progressBarListaProductos.Value >= progressBarListaProductos.Maximum)
        //    {
        //        timerProgreso.Stop();
        //    }
            
        //}



        private void btnBuscar_Click(object sender, EventArgs e)
        {
            progressBarListaProductos.Visible = true;



            //timerProgreso_Tick(sender,e);
            int valorMinimo,valorMaximo;
            valorMinimo = progressBarListaProductos.Minimum = 1;
            valorMaximo = progressBarListaProductos.Maximum = 2500;
            
            for (int i = valorMinimo; i <= valorMaximo ; i++)
            {
                progressBarListaProductos.Value = i;
                progressBarListaProductos.PerformStep();
                this.btnBuscar.Cursor = Cursors.WaitCursor;

            }
           
            

            if (progressBarListaProductos.Value==2500)
            {
                //Nos ayudará a filtrar la columna de búsqueda
                string columna = ((OPcionCombo)comboBuscar.SelectedItem).Valor.ToString();

                if (dataProductos.Rows.Count > 0)
                {
                    progressBarListaProductos.Value = 1;
                    foreach (DataGridViewRow fila in dataProductos.Rows)
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

       
    }
}
