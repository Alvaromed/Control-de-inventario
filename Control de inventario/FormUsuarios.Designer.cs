
namespace Control_de_inventario
{
    partial class FormUsuarios
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataUsuarios = new System.Windows.Forms.DataGridView();
            this.btnSeleccionarUsuario = new System.Windows.Forms.DataGridViewButtonColumn();
            this.IdUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsuarioLogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminarUsuario = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBuscar = new System.Windows.Forms.ComboBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.btnBorrar = new FontAwesome.Sharp.IconButton();
            this.btnRestablecerBusqueda = new FontAwesome.Sharp.IconButton();
            this.toolMessage = new System.Windows.Forms.ToolTip(this.components);
            this.progressBarListaProductos = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtConfirPass = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.comboRol = new System.Windows.Forms.ComboBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.comboEstado = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new FontAwesome.Sharp.IconButton();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblUsuarioLogin = new System.Windows.Forms.Label();
            this.txtIndiceFila = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataUsuarios)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // dataUsuarios
            // 
            this.dataUsuarios.AllowUserToAddRows = false;
            this.dataUsuarios.AllowUserToDeleteRows = false;
            this.dataUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataUsuarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataUsuarios.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataUsuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnSeleccionarUsuario,
            this.IdUsuario,
            this.UsuarioLogin,
            this.NombreCompleto,
            this.Correo,
            this.Pass,
            this.IdRol,
            this.Rol,
            this.EstadoValor,
            this.Estado,
            this.btnEliminarUsuario});
            this.dataUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataUsuarios.Location = new System.Drawing.Point(15, 234);
            this.dataUsuarios.MultiSelect = false;
            this.dataUsuarios.Name = "dataUsuarios";
            this.dataUsuarios.ReadOnly = true;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dataUsuarios.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataUsuarios.RowTemplate.Height = 28;
            this.dataUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataUsuarios.Size = new System.Drawing.Size(874, 167);
            this.dataUsuarios.TabIndex = 0;
            this.dataUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataUsuarios_CellContentClick);
            this.dataUsuarios.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataUsuarios_CellPainting);
            // 
            // btnSeleccionarUsuario
            // 
            this.btnSeleccionarUsuario.FillWeight = 10F;
            this.btnSeleccionarUsuario.HeaderText = "";
            this.btnSeleccionarUsuario.Name = "btnSeleccionarUsuario";
            this.btnSeleccionarUsuario.ReadOnly = true;
            // 
            // IdUsuario
            // 
            this.IdUsuario.HeaderText = "IdUsuario";
            this.IdUsuario.Name = "IdUsuario";
            this.IdUsuario.ReadOnly = true;
            this.IdUsuario.Visible = false;
            // 
            // UsuarioLogin
            // 
            this.UsuarioLogin.FillWeight = 120F;
            this.UsuarioLogin.HeaderText = "Usuario";
            this.UsuarioLogin.Name = "UsuarioLogin";
            this.UsuarioLogin.ReadOnly = true;
            // 
            // NombreCompleto
            // 
            this.NombreCompleto.FillWeight = 150F;
            this.NombreCompleto.HeaderText = "Nombre Completo";
            this.NombreCompleto.Name = "NombreCompleto";
            this.NombreCompleto.ReadOnly = true;
            // 
            // Correo
            // 
            this.Correo.FillWeight = 130F;
            this.Correo.HeaderText = "Correo";
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            // 
            // Pass
            // 
            this.Pass.HeaderText = "Contraseña";
            this.Pass.Name = "Pass";
            this.Pass.ReadOnly = true;
            this.Pass.Visible = false;
            // 
            // IdRol
            // 
            this.IdRol.HeaderText = "IdRol";
            this.IdRol.Name = "IdRol";
            this.IdRol.ReadOnly = true;
            this.IdRol.Visible = false;
            // 
            // Rol
            // 
            this.Rol.FillWeight = 105F;
            this.Rol.HeaderText = "Rol";
            this.Rol.Name = "Rol";
            this.Rol.ReadOnly = true;
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
            this.Estado.FillWeight = 110F;
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.HeaderText = "";
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Georgia", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(17, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(276, 38);
            this.label4.TabIndex = 24;
            this.label4.Text = "Lista de Usuarios Registrados";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.BackColor = System.Drawing.Color.Coral;
            this.label9.Location = new System.Drawing.Point(0, 184);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(910, 258);
            this.label9.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(530, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 21);
            this.label11.TabIndex = 27;
            this.label11.Text = "Buscar:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // comboBuscar
            // 
            this.comboBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBuscar.FormattingEnabled = true;
            this.comboBuscar.Location = new System.Drawing.Point(594, 22);
            this.comboBuscar.Name = "comboBuscar";
            this.comboBuscar.Size = new System.Drawing.Size(102, 21);
            this.comboBuscar.TabIndex = 11;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscar.Location = new System.Drawing.Point(702, 23);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(121, 20);
            this.txtBuscar.TabIndex = 12;
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
            this.btnBuscar.Location = new System.Drawing.Point(829, 23);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(37, 21);
            this.btnBuscar.TabIndex = 13;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
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
            this.btnBorrar.Location = new System.Drawing.Point(411, 413);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(101, 29);
            this.btnBorrar.TabIndex = 10;
            this.btnBorrar.Text = "Eliminar";
            this.btnBorrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBorrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Visible = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnRestablecerBusqueda
            // 
            this.btnRestablecerBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btnRestablecerBusqueda.Location = new System.Drawing.Point(739, 0);
            this.btnRestablecerBusqueda.Name = "btnRestablecerBusqueda";
            this.btnRestablecerBusqueda.Size = new System.Drawing.Size(135, 23);
            this.btnRestablecerBusqueda.TabIndex = 14;
            this.btnRestablecerBusqueda.Text = "Restablecer búsqueda";
            this.btnRestablecerBusqueda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRestablecerBusqueda.UseVisualStyleBackColor = false;
            this.btnRestablecerBusqueda.Click += new System.EventHandler(this.btnRestablecerBusqueda_Click);
            // 
            // toolMessage
            // 
            this.toolMessage.AutoPopDelay = 2000;
            this.toolMessage.InitialDelay = 100;
            this.toolMessage.ReshowDelay = 100;
            // 
            // progressBarListaProductos
            // 
            this.progressBarListaProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarListaProductos.Location = new System.Drawing.Point(636, 9);
            this.progressBarListaProductos.Name = "progressBarListaProductos";
            this.progressBarListaProductos.Size = new System.Drawing.Size(97, 14);
            this.progressBarListaProductos.TabIndex = 68;
            this.progressBarListaProductos.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Coral;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.comboBuscar);
            this.panel1.Controls.Add(this.txtBuscar);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(15, 184);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(874, 50);
            this.panel1.TabIndex = 69;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(90, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(309, 44);
            this.panel2.TabIndex = 70;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Coral;
            this.panel3.Controls.Add(this.progressBarListaProductos);
            this.panel3.Controls.Add(this.btnRestablecerBusqueda);
            this.panel3.Location = new System.Drawing.Point(15, 407);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(874, 35);
            this.panel3.TabIndex = 70;
            // 
            // txtConfirPass
            // 
            this.txtConfirPass.Location = new System.Drawing.Point(244, 95);
            this.txtConfirPass.Name = "txtConfirPass";
            this.txtConfirPass.PasswordChar = '*';
            this.txtConfirPass.Size = new System.Drawing.Size(187, 20);
            this.txtConfirPass.TabIndex = 6;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(25, 95);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(187, 20);
            this.txtPass.TabIndex = 5;
            // 
            // comboRol
            // 
            this.comboRol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRol.FormattingEnabled = true;
            this.comboRol.Location = new System.Drawing.Point(483, 94);
            this.comboRol.Name = "comboRol";
            this.comboRol.Size = new System.Drawing.Size(142, 21);
            this.comboRol.TabIndex = 7;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCorreo.Location = new System.Drawing.Point(483, 46);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(187, 20);
            this.txtCorreo.TabIndex = 3;
            // 
            // comboEstado
            // 
            this.comboEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEstado.FormattingEnabled = true;
            this.comboEstado.Location = new System.Drawing.Point(706, 45);
            this.comboEstado.Name = "comboEstado";
            this.comboEstado.Size = new System.Drawing.Size(121, 21);
            this.comboEstado.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(244, 46);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(187, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btnGuardar.Location = new System.Drawing.Point(706, 89);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(101, 29);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(25, 47);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(187, 20);
            this.txtUsuario.TabIndex = 1;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btnLimpiar.Location = new System.Drawing.Point(706, 124);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(101, 29);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(703, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Estado";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(241, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Confirmar Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(305, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(280, 23);
            this.label3.TabIndex = 22;
            this.label3.Text = "Configuración de Usuarios";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(22, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Contraseña";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(480, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Rol";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(3, 153);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(20, 20);
            this.txtId.TabIndex = 25;
            this.txtId.Text = "0";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(480, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Correo";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(241, 30);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            // 
            // lblUsuarioLogin
            // 
            this.lblUsuarioLogin.AutoSize = true;
            this.lblUsuarioLogin.BackColor = System.Drawing.Color.White;
            this.lblUsuarioLogin.Location = new System.Drawing.Point(22, 30);
            this.lblUsuarioLogin.Name = "lblUsuarioLogin";
            this.lblUsuarioLogin.Size = new System.Drawing.Size(43, 13);
            this.lblUsuarioLogin.TabIndex = 2;
            this.lblUsuarioLogin.Text = "Usuario";
            // 
            // txtIndiceFila
            // 
            this.txtIndiceFila.Location = new System.Drawing.Point(41, 153);
            this.txtIndiceFila.Name = "txtIndiceFila";
            this.txtIndiceFila.Size = new System.Drawing.Size(20, 20);
            this.txtIndiceFila.TabIndex = 31;
            this.txtIndiceFila.Text = "*";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.btnLimpiar);
            this.panel4.Controls.Add(this.btnGuardar);
            this.panel4.Controls.Add(this.comboEstado);
            this.panel4.Controls.Add(this.txtCorreo);
            this.panel4.Controls.Add(this.comboRol);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(910, 187);
            this.panel4.TabIndex = 71;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Controls.Add(this.txtIndiceFila);
            this.panel5.Controls.Add(this.lblNombre);
            this.panel5.Controls.Add(this.txtId);
            this.panel5.Controls.Add(this.lblUsuarioLogin);
            this.panel5.Controls.Add(this.txtPass);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.txtUsuario);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.txtConfirPass);
            this.panel5.Controls.Add(this.txtNombre);
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(474, 176);
            this.panel5.TabIndex = 32;
            // 
            // FormUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 442);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dataUsuarios);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Name = "FormUsuarios";
            this.Text = "FormUsuarios";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormUsuarios_FormClosing);
            this.Load += new System.EventHandler(this.FormUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataUsuarios)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnBorrar;
        private System.Windows.Forms.DataGridView dataUsuarios;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private FontAwesome.Sharp.IconButton btnRestablecerBusqueda;
        private System.Windows.Forms.ToolTip toolMessage;
        private System.Windows.Forms.ProgressBar progressBarListaProductos;
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionarUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsuarioLogin;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pass;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewButtonColumn btnEliminarUsuario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtConfirPass;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.ComboBox comboRol;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.ComboBox comboEstado;
        private System.Windows.Forms.TextBox txtNombre;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private System.Windows.Forms.TextBox txtUsuario;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblUsuarioLogin;
        private System.Windows.Forms.TextBox txtIndiceFila;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
    }
}