
namespace Control_de_inventario
{
    partial class FormVentas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlFondo = new System.Windows.Forms.Panel();
            this.pnlFondo2 = new System.Windows.Forms.Panel();
            this.pnlTotales = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnRegistrarProductos = new Control_de_inventario.DesignButtons.RJButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCambio = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtPagaCon = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtTotalPagar = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.groupInfoProducto = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.numericCantidad = new System.Windows.Forms.NumericUpDown();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnAgregarProducto = new Control_de_inventario.DesignButtons.RJButton();
            this.txtIndiceFila = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.txtBuscarProducto = new FontAwesome.Sharp.IconButton();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupInfoVenta = new System.Windows.Forms.GroupBox();
            this.comboTipoDocumento = new System.Windows.Forms.ComboBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlTabla = new System.Windows.Forms.Panel();
            this.dataProductosVenta = new System.Windows.Forms.DataGridView();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminarProducto = new System.Windows.Forms.DataGridViewButtonColumn();
            this.timerHoraVenta = new System.Windows.Forms.Timer(this.components);
            this.pnlFondo.SuspendLayout();
            this.pnlFondo2.SuspendLayout();
            this.pnlTotales.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupInfoProducto.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCantidad)).BeginInit();
            this.panel4.SuspendLayout();
            this.groupInfoVenta.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlTabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataProductosVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFondo
            // 
            this.pnlFondo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFondo.BackColor = System.Drawing.Color.Coral;
            this.pnlFondo.Controls.Add(this.pnlFondo2);
            this.pnlFondo.Location = new System.Drawing.Point(-1, 0);
            this.pnlFondo.Name = "pnlFondo";
            this.pnlFondo.Size = new System.Drawing.Size(1583, 646);
            this.pnlFondo.TabIndex = 0;
            // 
            // pnlFondo2
            // 
            this.pnlFondo2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFondo2.BackColor = System.Drawing.Color.White;
            this.pnlFondo2.Controls.Add(this.pnlTotales);
            this.pnlFondo2.Controls.Add(this.groupInfoProducto);
            this.pnlFondo2.Controls.Add(this.groupInfoVenta);
            this.pnlFondo2.Controls.Add(this.panel1);
            this.pnlFondo2.Controls.Add(this.pnlTabla);
            this.pnlFondo2.Location = new System.Drawing.Point(13, 12);
            this.pnlFondo2.Name = "pnlFondo2";
            this.pnlFondo2.Size = new System.Drawing.Size(1545, 615);
            this.pnlFondo2.TabIndex = 0;
            // 
            // pnlTotales
            // 
            this.pnlTotales.Controls.Add(this.groupBox4);
            this.pnlTotales.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTotales.Location = new System.Drawing.Point(0, 545);
            this.pnlTotales.Name = "pnlTotales";
            this.pnlTotales.Size = new System.Drawing.Size(1545, 70);
            this.pnlTotales.TabIndex = 31;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.lblUsuario);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.panel3);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.txtCambio);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.txtPagaCon);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.txtTotalPagar);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Location = new System.Drawing.Point(42, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1500, 64);
            this.groupBox4.TabIndex = 31;
            this.groupBox4.TabStop = false;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(653, 22);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 37;
            this.lblUsuario.Text = "Usuario";
            this.lblUsuario.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(134, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 24);
            this.label7.TabIndex = 38;
            this.label7.Text = "$";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.btnRegistrarProductos);
            this.panel3.Location = new System.Drawing.Point(1095, 13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(399, 51);
            this.panel3.TabIndex = 32;
            // 
            // btnRegistrarProductos
            // 
            this.btnRegistrarProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegistrarProductos.BackColor = System.Drawing.Color.Snow;
            this.btnRegistrarProductos.BackgroundColor = System.Drawing.Color.Snow;
            this.btnRegistrarProductos.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnRegistrarProductos.BorderRadius = 20;
            this.btnRegistrarProductos.BorderSize = 0;
            this.btnRegistrarProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarProductos.FlatAppearance.BorderSize = 0;
            this.btnRegistrarProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarProductos.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarProductos.Image = global::Control_de_inventario.Properties.Resources.addTag;
            this.btnRegistrarProductos.Location = new System.Drawing.Point(252, 2);
            this.btnRegistrarProductos.Name = "btnRegistrarProductos";
            this.btnRegistrarProductos.Size = new System.Drawing.Size(144, 41);
            this.btnRegistrarProductos.TabIndex = 17;
            this.btnRegistrarProductos.TextColor = System.Drawing.Color.White;
            this.btnRegistrarProductos.UseVisualStyleBackColor = false;
            this.btnRegistrarProductos.Click += new System.EventHandler(this.btnRegistrarProductos_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(894, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 24);
            this.label3.TabIndex = 37;
            this.label3.Text = "$";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(800, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 24);
            this.label6.TabIndex = 36;
            this.label6.Text = "Cambio:";
            // 
            // txtCambio
            // 
            this.txtCambio.Enabled = false;
            this.txtCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCambio.Location = new System.Drawing.Point(919, 18);
            this.txtCambio.Name = "txtCambio";
            this.txtCambio.Size = new System.Drawing.Size(90, 30);
            this.txtCambio.TabIndex = 35;
            this.txtCambio.Text = "0.00";
            this.txtCambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(466, 22);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(20, 24);
            this.label20.TabIndex = 34;
            this.label20.Text = "$";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(371, 21);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(95, 24);
            this.label18.TabIndex = 33;
            this.label18.Text = "Paga con:";
            // 
            // txtPagaCon
            // 
            this.txtPagaCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPagaCon.Location = new System.Drawing.Point(490, 18);
            this.txtPagaCon.Name = "txtPagaCon";
            this.txtPagaCon.Size = new System.Drawing.Size(90, 30);
            this.txtPagaCon.TabIndex = 31;
            this.txtPagaCon.Text = "0.00";
            this.txtPagaCon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPagaCon.Click += new System.EventHandler(this.txtPagaCon_Click);
            this.txtPagaCon.CursorChanged += new System.EventHandler(this.txtPagaCon_CursorChanged);
            this.txtPagaCon.TabIndexChanged += new System.EventHandler(this.txtPagaCon_TabIndexChanged);
            this.txtPagaCon.TextChanged += new System.EventHandler(this.txtPagaCon_TextChanged);
            this.txtPagaCon.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPagaCon_KeyDown);
            this.txtPagaCon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPagaCon_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(6, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(124, 24);
            this.label15.TabIndex = 29;
            this.label15.Text = "Total a pagar:";
            // 
            // txtTotalPagar
            // 
            this.txtTotalPagar.Enabled = false;
            this.txtTotalPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPagar.Location = new System.Drawing.Point(160, 19);
            this.txtTotalPagar.Name = "txtTotalPagar";
            this.txtTotalPagar.Size = new System.Drawing.Size(90, 30);
            this.txtTotalPagar.TabIndex = 17;
            this.txtTotalPagar.Text = "0.00";
            this.txtTotalPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTotalPagar.TextChanged += new System.EventHandler(this.txtTotalPagar_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(85, 22);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(20, 24);
            this.label16.TabIndex = 17;
            this.label16.Text = "$";
            // 
            // groupInfoProducto
            // 
            this.groupInfoProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupInfoProducto.BackColor = System.Drawing.Color.Transparent;
            this.groupInfoProducto.Controls.Add(this.panel2);
            this.groupInfoProducto.Controls.Add(this.panel4);
            this.groupInfoProducto.Controls.Add(this.txtIndiceFila);
            this.groupInfoProducto.Controls.Add(this.txtDescripcion);
            this.groupInfoProducto.Controls.Add(this.label17);
            this.groupInfoProducto.Controls.Add(this.txtProducto);
            this.groupInfoProducto.Controls.Add(this.txtIdProducto);
            this.groupInfoProducto.Controls.Add(this.txtBuscarProducto);
            this.groupInfoProducto.Controls.Add(this.txtCodigo);
            this.groupInfoProducto.Controls.Add(this.label8);
            this.groupInfoProducto.Controls.Add(this.label9);
            this.groupInfoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupInfoProducto.Location = new System.Drawing.Point(42, 137);
            this.groupInfoProducto.Name = "groupInfoProducto";
            this.groupInfoProducto.Size = new System.Drawing.Size(1489, 94);
            this.groupInfoProducto.TabIndex = 28;
            this.groupInfoProducto.TabStop = false;
            this.groupInfoProducto.Text = "Información Producto";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.txtPrecioVenta);
            this.panel2.Controls.Add(this.txtStock);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.numericCantidad);
            this.panel2.Location = new System.Drawing.Point(974, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(360, 72);
            this.panel2.TabIndex = 35;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(24, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 20);
            this.label13.TabIndex = 11;
            this.label13.Text = "Precio Venta";
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Enabled = false;
            this.txtPrecioVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioVenta.Location = new System.Drawing.Point(42, 38);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(82, 26);
            this.txtPrecioVenta.TabIndex = 12;
            this.txtPrecioVenta.Text = "0.00";
            this.txtPrecioVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtStock
            // 
            this.txtStock.Enabled = false;
            this.txtStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStock.Location = new System.Drawing.Point(154, 38);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(69, 26);
            this.txtStock.TabIndex = 34;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(18, 42);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(18, 20);
            this.label12.TabIndex = 13;
            this.label12.Text = "$";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(150, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "Stock";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(275, 14);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 20);
            this.label14.TabIndex = 14;
            this.label14.Text = "Cantidad";
            // 
            // numericCantidad
            // 
            this.numericCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericCantidad.Location = new System.Drawing.Point(279, 38);
            this.numericCantidad.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericCantidad.Name = "numericCantidad";
            this.numericCantidad.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numericCantidad.Size = new System.Drawing.Size(69, 26);
            this.numericCantidad.TabIndex = 15;
            this.numericCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericCantidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numericCantidad_KeyDown);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.btnAgregarProducto);
            this.panel4.Location = new System.Drawing.Point(1328, 19);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(155, 75);
            this.panel4.TabIndex = 33;
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarProducto.BackColor = System.Drawing.Color.Snow;
            this.btnAgregarProducto.BackgroundColor = System.Drawing.Color.Snow;
            this.btnAgregarProducto.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAgregarProducto.BorderRadius = 20;
            this.btnAgregarProducto.BorderSize = 0;
            this.btnAgregarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarProducto.FlatAppearance.BorderSize = 0;
            this.btnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProducto.ForeColor = System.Drawing.Color.White;
            this.btnAgregarProducto.Image = global::Control_de_inventario.Properties.Resources.add_product;
            this.btnAgregarProducto.Location = new System.Drawing.Point(49, 7);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(103, 65);
            this.btnAgregarProducto.TabIndex = 35;
            this.btnAgregarProducto.TextColor = System.Drawing.Color.White;
            this.btnAgregarProducto.UseVisualStyleBackColor = false;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // txtIndiceFila
            // 
            this.txtIndiceFila.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIndiceFila.Location = new System.Drawing.Point(721, 19);
            this.txtIndiceFila.Name = "txtIndiceFila";
            this.txtIndiceFila.Size = new System.Drawing.Size(20, 26);
            this.txtIndiceFila.TabIndex = 32;
            this.txtIndiceFila.Text = "*";
            this.txtIndiceFila.Visible = false;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Enabled = false;
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(593, 60);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(347, 26);
            this.txtDescripcion.TabIndex = 18;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(589, 34);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(92, 20);
            this.label17.TabIndex = 17;
            this.label17.Text = "Descripción";
            // 
            // txtProducto
            // 
            this.txtProducto.Enabled = false;
            this.txtProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProducto.Location = new System.Drawing.Point(306, 59);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(258, 26);
            this.txtProducto.TabIndex = 7;
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdProducto.Location = new System.Drawing.Point(756, 19);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Size = new System.Drawing.Size(33, 26);
            this.txtIdProducto.TabIndex = 6;
            this.txtIdProducto.Visible = false;
            // 
            // txtBuscarProducto
            // 
            this.txtBuscarProducto.BackColor = System.Drawing.Color.Gainsboro;
            this.txtBuscarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtBuscarProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.txtBuscarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarProducto.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.txtBuscarProducto.IconColor = System.Drawing.Color.Black;
            this.txtBuscarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.txtBuscarProducto.IconSize = 15;
            this.txtBuscarProducto.Location = new System.Drawing.Point(225, 57);
            this.txtBuscarProducto.Name = "txtBuscarProducto";
            this.txtBuscarProducto.Padding = new System.Windows.Forms.Padding(4, 3, 0, 0);
            this.txtBuscarProducto.Size = new System.Drawing.Size(44, 24);
            this.txtBuscarProducto.TabIndex = 4;
            this.txtBuscarProducto.UseVisualStyleBackColor = false;
            this.txtBuscarProducto.Click += new System.EventHandler(this.txtBuscarProducto_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(38, 58);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(167, 26);
            this.txtCodigo.TabIndex = 2;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            this.txtCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigo_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(303, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Producto";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(34, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Código Producto";
            // 
            // groupInfoVenta
            // 
            this.groupInfoVenta.BackColor = System.Drawing.Color.White;
            this.groupInfoVenta.Controls.Add(this.comboTipoDocumento);
            this.groupInfoVenta.Controls.Add(this.txtFecha);
            this.groupInfoVenta.Controls.Add(this.label5);
            this.groupInfoVenta.Controls.Add(this.label4);
            this.groupInfoVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupInfoVenta.Location = new System.Drawing.Point(558, 35);
            this.groupInfoVenta.Name = "groupInfoVenta";
            this.groupInfoVenta.Size = new System.Drawing.Size(566, 115);
            this.groupInfoVenta.TabIndex = 26;
            this.groupInfoVenta.TabStop = false;
            this.groupInfoVenta.Text = "Información Venta";
            // 
            // comboTipoDocumento
            // 
            this.comboTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTipoDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTipoDocumento.FormattingEnabled = true;
            this.comboTipoDocumento.Location = new System.Drawing.Point(313, 72);
            this.comboTipoDocumento.Name = "comboTipoDocumento";
            this.comboTipoDocumento.Size = new System.Drawing.Size(127, 28);
            this.comboTipoDocumento.TabIndex = 3;
            // 
            // txtFecha
            // 
            this.txtFecha.Enabled = false;
            this.txtFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.Location = new System.Drawing.Point(21, 73);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(184, 26);
            this.txtFecha.TabIndex = 2;
            this.txtFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(310, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tipo Documento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Fecha";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(432, 56);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro de Venta";
            // 
            // pnlTabla
            // 
            this.pnlTabla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTabla.Controls.Add(this.dataProductosVenta);
            this.pnlTabla.Location = new System.Drawing.Point(42, 237);
            this.pnlTabla.Name = "pnlTabla";
            this.pnlTabla.Size = new System.Drawing.Size(1489, 302);
            this.pnlTabla.TabIndex = 30;
            // 
            // dataProductosVenta
            // 
            this.dataProductosVenta.AllowUserToAddRows = false;
            this.dataProductosVenta.AllowUserToDeleteRows = false;
            this.dataProductosVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataProductosVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataProductosVenta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataProductosVenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataProductosVenta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataProductosVenta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataProductosVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataProductosVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataProductosVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProducto,
            this.Nombre,
            this.Descripcion,
            this.Precio,
            this.Cantidad,
            this.SubTotal,
            this.btnEliminarProducto});
            this.dataProductosVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataProductosVenta.Location = new System.Drawing.Point(3, 0);
            this.dataProductosVenta.MultiSelect = false;
            this.dataProductosVenta.Name = "dataProductosVenta";
            this.dataProductosVenta.ReadOnly = true;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dataProductosVenta.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataProductosVenta.RowTemplate.Height = 28;
            this.dataProductosVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataProductosVenta.Size = new System.Drawing.Size(1483, 299);
            this.dataProductosVenta.TabIndex = 29;
            this.dataProductosVenta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataProductosVenta_CellContentClick);
            this.dataProductosVenta.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataProductosVenta_CellPainting);
            // 
            // IdProducto
            // 
            this.IdProducto.HeaderText = "IdProducto";
            this.IdProducto.Name = "IdProducto";
            this.IdProducto.ReadOnly = true;
            this.IdProducto.Visible = false;
            // 
            // Nombre
            // 
            this.Nombre.FillWeight = 120F;
            this.Nombre.HeaderText = "Producto";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.FillWeight = 130F;
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "Sub Total";
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.HeaderText = "";
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.ReadOnly = true;
            this.btnEliminarProducto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnEliminarProducto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // timerHoraVenta
            // 
            this.timerHoraVenta.Enabled = true;
            this.timerHoraVenta.Tick += new System.EventHandler(this.timerHoraVenta_Tick);
            // 
            // FormVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 647);
            this.Controls.Add(this.pnlFondo);
            this.Name = "FormVentas";
            this.Text = "FormVentas";
            this.Load += new System.EventHandler(this.FormVentas_Load);
            this.pnlFondo.ResumeLayout(false);
            this.pnlFondo2.ResumeLayout(false);
            this.pnlTotales.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupInfoProducto.ResumeLayout(false);
            this.groupInfoProducto.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCantidad)).EndInit();
            this.panel4.ResumeLayout(false);
            this.groupInfoVenta.ResumeLayout(false);
            this.groupInfoVenta.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlTabla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataProductosVenta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFondo;
        private System.Windows.Forms.Panel pnlFondo2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupInfoVenta;
        private System.Windows.Forms.ComboBox comboTipoDocumento;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupInfoProducto;
        private System.Windows.Forms.TextBox txtIndiceFila;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown numericCantidad;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.TextBox txtIdProducto;
        private FontAwesome.Sharp.IconButton txtBuscarProducto;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlTabla;
        private System.Windows.Forms.DataGridView dataProductosVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridViewButtonColumn btnEliminarProducto;
        private System.Windows.Forms.Panel pnlTotales;
        private DesignButtons.RJButton btnAgregarProducto;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCambio;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtPagaCon;
        private System.Windows.Forms.Label label15;
        private DesignButtons.RJButton btnRegistrarProductos;
        private System.Windows.Forms.TextBox txtTotalPagar;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Timer timerHoraVenta;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblUsuario;
    }
}