
namespace Control_de_inventario
{
    partial class FormProducto
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
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.comboBuscar = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIndiceFila = new System.Windows.Forms.TextBox();
            this.dataProductos = new System.Windows.Forms.DataGridView();
            this.btnSeleccionarUsuario = new System.Windows.Forms.DataGridViewButtonColumn();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.comboCategoría = new System.Windows.Forms.ComboBox();
            this.comboEstado = new System.Windows.Forms.ComboBox();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblUsuarioLogin = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.progressBarListaProductos = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRestablecerBusqueda = new FontAwesome.Sharp.IconButton();
            this.btnExcel = new FontAwesome.Sharp.IconButton();
            this.btnBorrar = new FontAwesome.Sharp.IconButton();
            this.btnLimpiar = new FontAwesome.Sharp.IconButton();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataProductos)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscar.Location = new System.Drawing.Point(183, 17);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(121, 20);
            this.txtBuscar.TabIndex = 9;
            // 
            // comboBuscar
            // 
            this.comboBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBuscar.FormattingEnabled = true;
            this.comboBuscar.Location = new System.Drawing.Point(75, 16);
            this.comboBuscar.Name = "comboBuscar";
            this.comboBuscar.Size = new System.Drawing.Size(102, 21);
            this.comboBuscar.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(11, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 21);
            this.label11.TabIndex = 57;
            this.label11.Text = "Buscar:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(27, 16);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(20, 20);
            this.txtId.TabIndex = 55;
            this.txtId.Text = "0";
            this.txtId.Visible = false;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Georgia", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(0, 7);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.label4.Size = new System.Drawing.Size(308, 38);
            this.label4.TabIndex = 54;
            this.label4.Text = "Lista de Productos Registrados";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.BackColor = System.Drawing.Color.Coral;
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.label9.Size = new System.Drawing.Size(918, 451);
            this.label9.TabIndex = 56;
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtIndiceFila
            // 
            this.txtIndiceFila.Location = new System.Drawing.Point(65, 16);
            this.txtIndiceFila.Name = "txtIndiceFila";
            this.txtIndiceFila.Size = new System.Drawing.Size(20, 20);
            this.txtIndiceFila.TabIndex = 61;
            this.txtIndiceFila.Text = "*";
            this.txtIndiceFila.Visible = false;
            // 
            // dataProductos
            // 
            this.dataProductos.AllowUserToAddRows = false;
            this.dataProductos.AllowUserToDeleteRows = false;
            this.dataProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnSeleccionarUsuario,
            this.IdProducto,
            this.Codigo,
            this.Nombre,
            this.IdCategoria,
            this.Descripcion,
            this.Categoria,
            this.Stock,
            this.PrecioCompra,
            this.PrecioVenta,
            this.EstadoValor,
            this.Estado});
            this.dataProductos.Location = new System.Drawing.Point(253, 110);
            this.dataProductos.MultiSelect = false;
            this.dataProductos.Name = "dataProductos";
            this.dataProductos.ReadOnly = true;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dataProductos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataProductos.RowTemplate.Height = 28;
            this.dataProductos.Size = new System.Drawing.Size(653, 328);
            this.dataProductos.TabIndex = 12;
            this.dataProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataUsuarios_CellContentClick);
            this.dataProductos.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataProductos_CellMouseMove);
            this.dataProductos.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataUsuarios_CellPainting);
            this.dataProductos.MouseHover += new System.EventHandler(this.dataProductos_MouseHover);
            // 
            // btnSeleccionarUsuario
            // 
            this.btnSeleccionarUsuario.HeaderText = "";
            this.btnSeleccionarUsuario.Name = "btnSeleccionarUsuario";
            this.btnSeleccionarUsuario.ReadOnly = true;
            // 
            // IdProducto
            // 
            this.IdProducto.HeaderText = "IdProducto";
            this.IdProducto.Name = "IdProducto";
            this.IdProducto.ReadOnly = true;
            this.IdProducto.Visible = false;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // IdCategoria
            // 
            this.IdCategoria.HeaderText = "IdCategoría";
            this.IdCategoria.Name = "IdCategoria";
            this.IdCategoria.ReadOnly = true;
            this.IdCategoria.Visible = false;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoría";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            // 
            // Stock
            // 
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            // 
            // PrecioCompra
            // 
            this.PrecioCompra.HeaderText = "Precio Compra";
            this.PrecioCompra.Name = "PrecioCompra";
            this.PrecioCompra.ReadOnly = true;
            // 
            // PrecioVenta
            // 
            this.PrecioVenta.HeaderText = "Precio Venta";
            this.PrecioVenta.Name = "PrecioVenta";
            this.PrecioVenta.ReadOnly = true;
            // 
            // EstadoValor
            // 
            this.EstadoValor.HeaderText = "EstadoValor";
            this.EstadoValor.Name = "EstadoValor";
            this.EstadoValor.ReadOnly = true;
            this.EstadoValor.Visible = false;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(50, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(295, 23);
            this.label3.TabIndex = 52;
            this.label3.Text = "Configuración de Productos";
            // 
            // comboCategoría
            // 
            this.comboCategoría.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCategoría.FormattingEnabled = true;
            this.comboCategoría.Location = new System.Drawing.Point(27, 238);
            this.comboCategoría.Name = "comboCategoría";
            this.comboCategoría.Size = new System.Drawing.Size(187, 21);
            this.comboCategoría.TabIndex = 4;
            // 
            // comboEstado
            // 
            this.comboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEstado.FormattingEnabled = true;
            this.comboEstado.Location = new System.Drawing.Point(27, 292);
            this.comboEstado.Name = "comboEstado";
            this.comboEstado.Size = new System.Drawing.Size(187, 21);
            this.comboEstado.TabIndex = 5;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(27, 135);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(187, 20);
            this.txtNombreProducto.TabIndex = 2;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(27, 185);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(187, 20);
            this.txtDescripcion.TabIndex = 3;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(27, 87);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(187, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(24, 222);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 41;
            this.label10.Text = "Categoría";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(24, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "Nombre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(24, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "Estado";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(24, 169);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(63, 13);
            this.lblNombre.TabIndex = 36;
            this.lblNombre.Text = "Descripción";
            // 
            // lblUsuarioLogin
            // 
            this.lblUsuarioLogin.AutoSize = true;
            this.lblUsuarioLogin.BackColor = System.Drawing.Color.White;
            this.lblUsuarioLogin.Location = new System.Drawing.Point(24, 70);
            this.lblUsuarioLogin.Name = "lblUsuarioLogin";
            this.lblUsuarioLogin.Size = new System.Drawing.Size(40, 13);
            this.lblUsuarioLogin.TabIndex = 35;
            this.lblUsuarioLogin.Text = "Código";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 451);
            this.label2.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 33;
            // 
            // toolMensaje
            // 
            this.toolMensaje.AutoPopDelay = 2000;
            this.toolMensaje.InitialDelay = 100;
            this.toolMensaje.ReshowDelay = 100;
            // 
            // progressBarListaProductos
            // 
            this.progressBarListaProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarListaProductos.Location = new System.Drawing.Point(551, 8);
            this.progressBarListaProductos.Name = "progressBarListaProductos";
            this.progressBarListaProductos.Size = new System.Drawing.Size(97, 14);
            this.progressBarListaProductos.TabIndex = 66;
            this.progressBarListaProductos.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(253, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(653, 50);
            this.panel1.TabIndex = 67;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.btnBuscar);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.txtBuscar);
            this.panel3.Controls.Add(this.comboBuscar);
            this.panel3.Location = new System.Drawing.Point(295, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(358, 50);
            this.panel3.TabIndex = 69;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBuscar.FlatAppearance.BorderSize = 2;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnBuscar.IconColor = System.Drawing.Color.Black;
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscar.IconSize = 15;
            this.btnBuscar.Location = new System.Drawing.Point(310, 17);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(37, 21);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Coral;
            this.panel2.Controls.Add(this.progressBarListaProductos);
            this.panel2.Controls.Add(this.btnRestablecerBusqueda);
            this.panel2.Controls.Add(this.btnExcel);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(253, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(650, 48);
            this.panel2.TabIndex = 68;
            // 
            // btnRestablecerBusqueda
            // 
            this.btnRestablecerBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestablecerBusqueda.BackColor = System.Drawing.Color.Silver;
            this.btnRestablecerBusqueda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestablecerBusqueda.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRestablecerBusqueda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btnRestablecerBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestablecerBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestablecerBusqueda.IconChar = FontAwesome.Sharp.IconChar.TrashRestore;
            this.btnRestablecerBusqueda.IconColor = System.Drawing.Color.Black;
            this.btnRestablecerBusqueda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRestablecerBusqueda.IconSize = 13;
            this.btnRestablecerBusqueda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRestablecerBusqueda.Location = new System.Drawing.Point(513, 24);
            this.btnRestablecerBusqueda.Name = "btnRestablecerBusqueda";
            this.btnRestablecerBusqueda.Size = new System.Drawing.Size(135, 23);
            this.btnRestablecerBusqueda.TabIndex = 11;
            this.btnRestablecerBusqueda.Text = "Restablecer búsqueda";
            this.btnRestablecerBusqueda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRestablecerBusqueda.UseVisualStyleBackColor = false;
            this.btnRestablecerBusqueda.Click += new System.EventHandler(this.btnRestablecerBusqueda_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcel.BackColor = System.Drawing.Color.Silver;
            this.btnExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnExcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.btnExcel.IconColor = System.Drawing.Color.Green;
            this.btnExcel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExcel.IconSize = 15;
            this.btnExcel.Location = new System.Drawing.Point(462, 24);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(45, 23);
            this.btnExcel.TabIndex = 62;
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBorrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBorrar.FlatAppearance.BorderSize = 2;
            this.btnBorrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnBorrar.IconColor = System.Drawing.Color.Black;
            this.btnBorrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBorrar.IconSize = 18;
            this.btnBorrar.Location = new System.Drawing.Point(135, 362);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(79, 29);
            this.btnBorrar.TabIndex = 7;
            this.btnBorrar.Text = "Eliminar";
            this.btnBorrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBorrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLimpiar.FlatAppearance.BorderSize = 2;
            this.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnLimpiar.IconColor = System.Drawing.Color.Black;
            this.btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiar.IconSize = 18;
            this.btnLimpiar.Location = new System.Drawing.Point(165, 16);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(43, 29);
            this.btnLimpiar.TabIndex = 13;
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGuardar.FlatAppearance.BorderSize = 2;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnGuardar.IconColor = System.Drawing.Color.Black;
            this.btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardar.IconSize = 18;
            this.btnGuardar.Location = new System.Drawing.Point(27, 362);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(79, 29);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // FormProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 451);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtIndiceFila);
            this.Controls.Add(this.dataProductos);
            this.Controls.Add(this.comboCategoría);
            this.Controls.Add(this.comboEstado);
            this.Controls.Add(this.txtNombreProducto);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblUsuarioLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Name = "FormProducto";
            this.Text = "FormProducto";
            this.Load += new System.EventHandler(this.FormProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataProductos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnRestablecerBusqueda;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ComboBox comboBuscar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton btnBorrar;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtIndiceFila;
        private System.Windows.Forms.DataGridView dataProductos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboCategoría;
        private System.Windows.Forms.ComboBox comboEstado;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblUsuarioLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionarUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private FontAwesome.Sharp.IconButton btnExcel;
        private System.Windows.Forms.ToolTip toolMensaje;
        private System.Windows.Forms.ProgressBar progressBarListaProductos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}