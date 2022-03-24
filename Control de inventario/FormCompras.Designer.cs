
namespace Control_de_inventario
{
    partial class FormCompras
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboTipoDocumento = new System.Windows.Forms.ComboBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtIdProveedor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBuscarProveedor = new FontAwesome.Sharp.IconButton();
            this.comboRazonSocial = new System.Windows.Forms.ComboBox();
            this.txtNumDocumento = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPrecoiCompra = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.numericCantidad = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
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
            this.dataProductosCompra = new System.Windows.Forms.DataGridView();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubGanancia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminarProducto = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label15 = new System.Windows.Forms.Label();
            this.txtTotalPagar = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtTotalGanancia = new System.Windows.Forms.TextBox();
            this.btnRegistrarProductos = new Control_de_inventario.DesignButtons.RJButton();
            this.timerHoraCompra = new System.Windows.Forms.Timer(this.components);
            this.lblUsuario = new System.Windows.Forms.Label();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCantidad)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataProductosCompra)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.pnlForm.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(295, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 23);
            this.label3.TabIndex = 24;
            this.label3.Text = "Registro de Compras";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.comboTipoDocumento);
            this.groupBox1.Controls.Add(this.txtFecha);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(653, 94);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información Compra";
            // 
            // comboTipoDocumento
            // 
            this.comboTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTipoDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTipoDocumento.FormattingEnabled = true;
            this.comboTipoDocumento.Location = new System.Drawing.Point(417, 58);
            this.comboTipoDocumento.Name = "comboTipoDocumento";
            this.comboTipoDocumento.Size = new System.Drawing.Size(129, 28);
            this.comboTipoDocumento.TabIndex = 3;
            // 
            // txtFecha
            // 
            this.txtFecha.Enabled = false;
            this.txtFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.Location = new System.Drawing.Point(20, 58);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(231, 26);
            this.txtFecha.TabIndex = 2;
            this.txtFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFecha.TextChanged += new System.EventHandler(this.txtFecha_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(414, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tipo Documento";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Fecha";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Controls.Add(this.txtNumDocumento);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(17, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(821, 94);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Información Proveedor";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtIdProveedor);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.btnBuscarProveedor);
            this.panel3.Controls.Add(this.comboRazonSocial);
            this.panel3.Location = new System.Drawing.Point(375, 14);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(440, 74);
            this.panel3.TabIndex = 6;
            // 
            // txtIdProveedor
            // 
            this.txtIdProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIdProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdProveedor.Location = new System.Drawing.Point(386, 4);
            this.txtIdProveedor.Name = "txtIdProveedor";
            this.txtIdProveedor.Size = new System.Drawing.Size(30, 26);
            this.txtIdProveedor.TabIndex = 5;
            this.txtIdProveedor.Visible = false;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(129, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Razón Social";
            // 
            // btnBuscarProveedor
            // 
            this.btnBuscarProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarProveedor.BackColor = System.Drawing.Color.Gainsboro;
            this.btnBuscarProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarProveedor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnBuscarProveedor.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnBuscarProveedor.IconColor = System.Drawing.Color.Black;
            this.btnBuscarProveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarProveedor.IconSize = 15;
            this.btnBuscarProveedor.Location = new System.Drawing.Point(364, 38);
            this.btnBuscarProveedor.Name = "btnBuscarProveedor";
            this.btnBuscarProveedor.Padding = new System.Windows.Forms.Padding(4, 3, 0, 0);
            this.btnBuscarProveedor.Size = new System.Drawing.Size(68, 27);
            this.btnBuscarProveedor.TabIndex = 4;
            this.btnBuscarProveedor.UseVisualStyleBackColor = false;
            this.btnBuscarProveedor.Click += new System.EventHandler(this.btnBuscarProveedor_Click);
            // 
            // comboRazonSocial
            // 
            this.comboRazonSocial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboRazonSocial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRazonSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboRazonSocial.FormattingEnabled = true;
            this.comboRazonSocial.Location = new System.Drawing.Point(133, 39);
            this.comboRazonSocial.Name = "comboRazonSocial";
            this.comboRazonSocial.Size = new System.Drawing.Size(186, 28);
            this.comboRazonSocial.TabIndex = 3;
            this.comboRazonSocial.SelectedIndexChanged += new System.EventHandler(this.comboRazonSocial_SelectedIndexChanged);
            // 
            // txtNumDocumento
            // 
            this.txtNumDocumento.Enabled = false;
            this.txtNumDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumDocumento.Location = new System.Drawing.Point(22, 56);
            this.txtNumDocumento.Name = "txtNumDocumento";
            this.txtNumDocumento.Size = new System.Drawing.Size(128, 26);
            this.txtNumDocumento.TabIndex = 2;
            this.txtNumDocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Número Documento";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.panel6);
            this.groupBox3.Controls.Add(this.panel5);
            this.groupBox3.Controls.Add(this.txtIndiceFila);
            this.groupBox3.Controls.Add(this.txtDescripcion);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.txtProducto);
            this.groupBox3.Controls.Add(this.txtIdProducto);
            this.groupBox3.Controls.Add(this.txtBuscarProducto);
            this.groupBox3.Controls.Add(this.txtCodigo);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(22, 161);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1564, 99);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Información Producto";
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.Controls.Add(this.label10);
            this.panel6.Controls.Add(this.txtPrecoiCompra);
            this.panel6.Controls.Add(this.label11);
            this.panel6.Controls.Add(this.label13);
            this.panel6.Controls.Add(this.txtPrecioVenta);
            this.panel6.Controls.Add(this.numericCantidad);
            this.panel6.Controls.Add(this.label12);
            this.panel6.Controls.Add(this.label14);
            this.panel6.Location = new System.Drawing.Point(1006, 17);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(394, 72);
            this.panel6.TabIndex = 34;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(19, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 20);
            this.label10.TabIndex = 8;
            this.label10.Text = "Precio Compra";
            // 
            // txtPrecoiCompra
            // 
            this.txtPrecoiCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoiCompra.Location = new System.Drawing.Point(36, 38);
            this.txtPrecoiCompra.Name = "txtPrecoiCompra";
            this.txtPrecoiCompra.Size = new System.Drawing.Size(84, 26);
            this.txtPrecoiCompra.TabIndex = 9;
            this.txtPrecoiCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecoiCompra_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(19, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 20);
            this.label11.TabIndex = 10;
            this.label11.Text = "$";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(139, 8);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 20);
            this.label13.TabIndex = 11;
            this.label13.Text = "Precio Venta";
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioVenta.Location = new System.Drawing.Point(156, 39);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(82, 26);
            this.txtPrecioVenta.TabIndex = 12;
            this.txtPrecioVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioVenta_KeyPress);
            // 
            // numericCantidad
            // 
            this.numericCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericCantidad.Location = new System.Drawing.Point(279, 39);
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
            this.numericCantidad.Size = new System.Drawing.Size(63, 26);
            this.numericCantidad.TabIndex = 15;
            this.numericCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(139, 43);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(18, 20);
            this.label12.TabIndex = 13;
            this.label12.Text = "$";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(269, 7);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 20);
            this.label14.TabIndex = 14;
            this.label14.Text = "Cantidad";
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Controls.Add(this.btnAgregarProducto);
            this.panel5.Location = new System.Drawing.Point(1397, 17);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(163, 76);
            this.panel5.TabIndex = 33;
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.BackColor = System.Drawing.Color.Snow;
            this.btnAgregarProducto.BackgroundColor = System.Drawing.Color.Snow;
            this.btnAgregarProducto.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAgregarProducto.BorderRadius = 20;
            this.btnAgregarProducto.BorderSize = 0;
            this.btnAgregarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarProducto.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAgregarProducto.FlatAppearance.BorderSize = 0;
            this.btnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProducto.ForeColor = System.Drawing.Color.White;
            this.btnAgregarProducto.Image = global::Control_de_inventario.Properties.Resources.add_product;
            this.btnAgregarProducto.Location = new System.Drawing.Point(90, 0);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(73, 76);
            this.btnAgregarProducto.TabIndex = 16;
            this.btnAgregarProducto.TextColor = System.Drawing.Color.White;
            this.btnAgregarProducto.UseVisualStyleBackColor = false;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // txtIndiceFila
            // 
            this.txtIndiceFila.Location = new System.Drawing.Point(270, 17);
            this.txtIndiceFila.Name = "txtIndiceFila";
            this.txtIndiceFila.Size = new System.Drawing.Size(20, 29);
            this.txtIndiceFila.TabIndex = 32;
            this.txtIndiceFila.Text = "*";
            this.txtIndiceFila.Visible = false;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Enabled = false;
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(573, 63);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(317, 26);
            this.txtDescripcion.TabIndex = 18;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(571, 39);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(92, 20);
            this.label17.TabIndex = 17;
            this.label17.Text = "Descripción";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // txtProducto
            // 
            this.txtProducto.Enabled = false;
            this.txtProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProducto.Location = new System.Drawing.Point(289, 63);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(257, 26);
            this.txtProducto.TabIndex = 7;
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.Location = new System.Drawing.Point(360, 18);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Size = new System.Drawing.Size(33, 29);
            this.txtIdProducto.TabIndex = 6;
            this.txtIdProducto.Visible = false;
            // 
            // txtBuscarProducto
            // 
            this.txtBuscarProducto.BackColor = System.Drawing.Color.Gainsboro;
            this.txtBuscarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtBuscarProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.txtBuscarProducto.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.txtBuscarProducto.IconColor = System.Drawing.Color.Black;
            this.txtBuscarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.txtBuscarProducto.IconSize = 15;
            this.txtBuscarProducto.Location = new System.Drawing.Point(211, 65);
            this.txtBuscarProducto.Name = "txtBuscarProducto";
            this.txtBuscarProducto.Padding = new System.Windows.Forms.Padding(4, 3, 0, 0);
            this.txtBuscarProducto.Size = new System.Drawing.Size(60, 24);
            this.txtBuscarProducto.TabIndex = 4;
            this.txtBuscarProducto.UseVisualStyleBackColor = false;
            this.txtBuscarProducto.Click += new System.EventHandler(this.txtBuscarProducto_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(18, 63);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(187, 26);
            this.txtCodigo.TabIndex = 2;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            this.txtCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigo_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(289, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Producto";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(14, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Código Producto";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // dataProductosCompra
            // 
            this.dataProductosCompra.AllowUserToAddRows = false;
            this.dataProductosCompra.AllowUserToDeleteRows = false;
            this.dataProductosCompra.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataProductosCompra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataProductosCompra.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataProductosCompra.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataProductosCompra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataProductosCompra.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataProductosCompra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataProductosCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataProductosCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProducto,
            this.Nombre,
            this.Descripcion,
            this.PrecioCompra,
            this.PrecioVenta,
            this.Cantidad,
            this.SubTotal,
            this.SubGanancia,
            this.btnEliminarProducto});
            this.dataProductosCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataProductosCompra.Location = new System.Drawing.Point(22, 266);
            this.dataProductosCompra.MultiSelect = false;
            this.dataProductosCompra.Name = "dataProductosCompra";
            this.dataProductosCompra.ReadOnly = true;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dataProductosCompra.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataProductosCompra.RowTemplate.Height = 28;
            this.dataProductosCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataProductosCompra.Size = new System.Drawing.Size(1564, 252);
            this.dataProductosCompra.TabIndex = 28;
            this.dataProductosCompra.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataProductosCompra_CellContentClick);
            this.dataProductosCompra.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataProductosCompra_CellPainting);
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
            // PrecioCompra
            // 
            this.PrecioCompra.FillWeight = 150F;
            this.PrecioCompra.HeaderText = "Precio Compra";
            this.PrecioCompra.Name = "PrecioCompra";
            this.PrecioCompra.ReadOnly = true;
            // 
            // PrecioVenta
            // 
            this.PrecioVenta.FillWeight = 130F;
            this.PrecioVenta.HeaderText = "Precio Venta";
            this.PrecioVenta.Name = "PrecioVenta";
            this.PrecioVenta.ReadOnly = true;
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
            // SubGanancia
            // 
            this.SubGanancia.HeaderText = "SubGanancia";
            this.SubGanancia.Name = "SubGanancia";
            this.SubGanancia.ReadOnly = true;
            this.SubGanancia.Visible = false;
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.HeaderText = "";
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.ReadOnly = true;
            this.btnEliminarProducto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnEliminarProducto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(63, 21);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(106, 20);
            this.label15.TabIndex = 29;
            this.label15.Text = "Total a pagar:";
            // 
            // txtTotalPagar
            // 
            this.txtTotalPagar.Enabled = false;
            this.txtTotalPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPagar.Location = new System.Drawing.Point(218, 18);
            this.txtTotalPagar.Name = "txtTotalPagar";
            this.txtTotalPagar.Size = new System.Drawing.Size(70, 26);
            this.txtTotalPagar.TabIndex = 17;
            this.txtTotalPagar.Text = "0.00";
            this.txtTotalPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTotalPagar.TextChanged += new System.EventHandler(this.txtTotalPagar_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(194, 21);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(18, 20);
            this.label16.TabIndex = 17;
            this.label16.Text = "$";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.txtTotalGanancia);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.btnRegistrarProductos);
            this.groupBox4.Controls.Add(this.txtTotalPagar);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Location = new System.Drawing.Point(594, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(807, 52);
            this.groupBox4.TabIndex = 30;
            this.groupBox4.TabStop = false;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(673, 21);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(18, 20);
            this.label20.TabIndex = 34;
            this.label20.Text = "$";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(524, 20);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(139, 20);
            this.label18.TabIndex = 33;
            this.label18.Text = "Total de ganancia:";
            // 
            // txtTotalGanancia
            // 
            this.txtTotalGanancia.Enabled = false;
            this.txtTotalGanancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalGanancia.Location = new System.Drawing.Point(697, 17);
            this.txtTotalGanancia.Name = "txtTotalGanancia";
            this.txtTotalGanancia.Size = new System.Drawing.Size(70, 26);
            this.txtTotalGanancia.TabIndex = 31;
            this.txtTotalGanancia.Text = "0.00";
            this.txtTotalGanancia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnRegistrarProductos
            // 
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
            this.btnRegistrarProductos.Location = new System.Drawing.Point(344, 9);
            this.btnRegistrarProductos.Name = "btnRegistrarProductos";
            this.btnRegistrarProductos.Size = new System.Drawing.Size(107, 35);
            this.btnRegistrarProductos.TabIndex = 17;
            this.btnRegistrarProductos.TextColor = System.Drawing.Color.White;
            this.btnRegistrarProductos.UseVisualStyleBackColor = false;
            this.btnRegistrarProductos.Click += new System.EventHandler(this.btnRegistrarProductos_Click);
            // 
            // timerHoraCompra
            // 
            this.timerHoraCompra.Enabled = true;
            this.timerHoraCompra.Tick += new System.EventHandler(this.timerHoraCompra_Tick);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(41, 21);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(41, 13);
            this.lblUsuario.TabIndex = 36;
            this.lblUsuario.Text = "label22";
            // 
            // pnlForm
            // 
            this.pnlForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlForm.BackColor = System.Drawing.Color.Coral;
            this.pnlForm.Controls.Add(this.panel1);
            this.pnlForm.Location = new System.Drawing.Point(0, 3);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(1661, 558);
            this.pnlForm.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.dataProductosCompra);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Location = new System.Drawing.Point(12, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1637, 536);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.groupBox2);
            this.panel4.Location = new System.Drawing.Point(739, 54);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(847, 105);
            this.panel4.TabIndex = 29;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.groupBox4);
            this.panel2.Controls.Add(this.lblUsuario);
            this.panel2.Location = new System.Drawing.Point(0, 564);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1661, 58);
            this.panel2.TabIndex = 37;
            // 
            // FormCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1661, 622);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.label1);
            this.Name = "FormCompras";
            this.Text = "FormCompras";
            this.Load += new System.EventHandler(this.FormCompras_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCantidad)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataProductosCompra)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.pnlForm.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboTipoDocumento;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboRazonSocial;
        private System.Windows.Forms.TextBox txtNumDocumento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private FontAwesome.Sharp.IconButton btnBuscarProveedor;
        private System.Windows.Forms.TextBox txtIdProveedor;
        private System.Windows.Forms.GroupBox groupBox3;
        private FontAwesome.Sharp.IconButton txtBuscarProducto;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtIdProducto;
        private System.Windows.Forms.NumericUpDown numericCantidad;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPrecoiCompra;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtProducto;
        private DesignButtons.RJButton btnAgregarProducto;
        private System.Windows.Forms.DataGridView dataProductosCompra;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtTotalPagar;
        private System.Windows.Forms.Label label16;
        private DesignButtons.RJButton btnRegistrarProductos;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtIndiceFila;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtTotalGanancia;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Timer timerHoraCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubGanancia;
        private System.Windows.Forms.DataGridViewButtonColumn btnEliminarProducto;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
    }
}