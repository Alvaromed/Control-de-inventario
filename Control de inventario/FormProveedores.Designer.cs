
namespace Control_de_inventario
{
    partial class FormProveedores
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnRestablecerBusqueda = new FontAwesome.Sharp.IconButton();
            this.txtIndiceFila = new System.Windows.Forms.TextBox();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.comboBuscar = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataProveedor = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBorrar = new FontAwesome.Sharp.IconButton();
            this.btnLimpiar = new FontAwesome.Sharp.IconButton();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.comboEstado = new System.Windows.Forms.ComboBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblUsuarioLogin = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSeleccionarProveedor = new System.Windows.Forms.DataGridViewButtonColumn();
            this.IdProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RazonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataProveedor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRestablecerBusqueda
            // 
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
            this.btnRestablecerBusqueda.Location = new System.Drawing.Point(755, 411);
            this.btnRestablecerBusqueda.Name = "btnRestablecerBusqueda";
            this.btnRestablecerBusqueda.Size = new System.Drawing.Size(135, 23);
            this.btnRestablecerBusqueda.TabIndex = 53;
            this.btnRestablecerBusqueda.Text = "Restablecer búsqueda";
            this.btnRestablecerBusqueda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRestablecerBusqueda.UseVisualStyleBackColor = false;
            this.btnRestablecerBusqueda.Click += new System.EventHandler(this.btnRestablecerBusqueda_Click);
            // 
            // txtIndiceFila
            // 
            this.txtIndiceFila.Location = new System.Drawing.Point(55, 13);
            this.txtIndiceFila.Name = "txtIndiceFila";
            this.txtIndiceFila.Size = new System.Drawing.Size(20, 20);
            this.txtIndiceFila.TabIndex = 59;
            this.txtIndiceFila.Text = "*";
            this.txtIndiceFila.Visible = false;
            // 
            // btnBuscar
            // 
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
            this.btnBuscar.Location = new System.Drawing.Point(853, 206);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(37, 21);
            this.btnBuscar.TabIndex = 52;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(726, 206);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(121, 20);
            this.txtBuscar.TabIndex = 51;
            // 
            // comboBuscar
            // 
            this.comboBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBuscar.FormattingEnabled = true;
            this.comboBuscar.Location = new System.Drawing.Point(618, 205);
            this.comboBuscar.Name = "comboBuscar";
            this.comboBuscar.Size = new System.Drawing.Size(102, 21);
            this.comboBuscar.TabIndex = 50;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Coral;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(554, 205);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 21);
            this.label11.TabIndex = 58;
            this.label11.Text = "Buscar:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(-28, 13);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(20, 20);
            this.txtId.TabIndex = 56;
            this.txtId.Text = "0";
            this.txtId.Visible = false;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Coral;
            this.label4.Font = new System.Drawing.Font("Georgia", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(84, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(345, 38);
            this.label4.TabIndex = 55;
            this.label4.Text = "Lista de Proveedores Registrados";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dataProveedor
            // 
            this.dataProveedor.AllowUserToAddRows = false;
            this.dataProveedor.AllowUserToDeleteRows = false;
            this.dataProveedor.BackgroundColor = System.Drawing.Color.Coral;
            this.dataProveedor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataProveedor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataProveedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnSeleccionarProveedor,
            this.IdProveedor,
            this.Documento,
            this.RazonSocial,
            this.Correo,
            this.Telefono,
            this.EstadoValor,
            this.Estado});
            this.dataProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataProveedor.Location = new System.Drawing.Point(16, 238);
            this.dataProveedor.MultiSelect = false;
            this.dataProveedor.Name = "dataProveedor";
            this.dataProveedor.ReadOnly = true;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            this.dataProveedor.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataProveedor.RowTemplate.Height = 28;
            this.dataProveedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataProveedor.Size = new System.Drawing.Size(874, 167);
            this.dataProveedor.TabIndex = 32;
            this.dataProveedor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataProveedor_CellContentClick);
            this.dataProveedor.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataProveedor_CellPainting);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(304, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(318, 23);
            this.label3.TabIndex = 54;
            this.label3.Text = "Configuración de Proveedores";
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
            this.btnBorrar.Location = new System.Drawing.Point(755, 128);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(101, 29);
            this.btnBorrar.TabIndex = 49;
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
            this.btnLimpiar.Location = new System.Drawing.Point(755, 84);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(101, 29);
            this.btnLimpiar.TabIndex = 48;
            this.btnLimpiar.Text = "Limpiar";
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
            this.btnGuardar.Location = new System.Drawing.Point(755, 41);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(101, 29);
            this.btnGuardar.TabIndex = 46;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // comboEstado
            // 
            this.comboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEstado.FormattingEnabled = true;
            this.comboEstado.Location = new System.Drawing.Point(249, 107);
            this.comboEstado.Name = "comboEstado";
            this.comboEstado.Size = new System.Drawing.Size(121, 21);
            this.comboEstado.TabIndex = 39;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(17, 108);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(187, 20);
            this.txtCorreo.TabIndex = 37;
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(249, 58);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(187, 20);
            this.txtRazonSocial.TabIndex = 36;
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(17, 59);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(187, 20);
            this.txtDocumento.TabIndex = 33;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(246, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 47;
            this.label10.Text = "Estado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(14, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "Correo";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(246, 42);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(70, 13);
            this.lblNombre.TabIndex = 38;
            this.lblNombre.Text = "Razón Social";
            // 
            // lblUsuarioLogin
            // 
            this.lblUsuarioLogin.AutoSize = true;
            this.lblUsuarioLogin.BackColor = System.Drawing.Color.White;
            this.lblUsuarioLogin.Location = new System.Drawing.Point(14, 42);
            this.lblUsuarioLogin.Name = "lblUsuarioLogin";
            this.lblUsuarioLogin.Size = new System.Drawing.Size(62, 13);
            this.lblUsuarioLogin.TabIndex = 35;
            this.lblUsuarioLogin.Text = "Documento";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(911, 184);
            this.label2.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Coral;
            this.label9.Location = new System.Drawing.Point(0, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(910, 258);
            this.label9.TabIndex = 57;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(17, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(20, 20);
            this.textBox1.TabIndex = 60;
            this.textBox1.Text = "0";
            this.textBox1.Visible = false;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(484, 59);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(187, 20);
            this.txtTelefono.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(481, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 62;
            this.label1.Text = "Teléfono";
            // 
            // btnSeleccionarProveedor
            // 
            this.btnSeleccionarProveedor.FillWeight = 10F;
            this.btnSeleccionarProveedor.HeaderText = "";
            this.btnSeleccionarProveedor.Name = "btnSeleccionarProveedor";
            this.btnSeleccionarProveedor.ReadOnly = true;
            this.btnSeleccionarProveedor.Width = 35;
            // 
            // IdProveedor
            // 
            this.IdProveedor.HeaderText = "IdProveedor";
            this.IdProveedor.Name = "IdProveedor";
            this.IdProveedor.ReadOnly = true;
            this.IdProveedor.Visible = false;
            // 
            // Documento
            // 
            this.Documento.FillWeight = 120F;
            this.Documento.HeaderText = "Documento";
            this.Documento.Name = "Documento";
            this.Documento.ReadOnly = true;
            this.Documento.Width = 145;
            // 
            // RazonSocial
            // 
            this.RazonSocial.FillWeight = 150F;
            this.RazonSocial.HeaderText = "Razón Social";
            this.RazonSocial.Name = "RazonSocial";
            this.RazonSocial.ReadOnly = true;
            this.RazonSocial.Width = 220;
            // 
            // Correo
            // 
            this.Correo.FillWeight = 130F;
            this.Correo.HeaderText = "Correo";
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            this.Correo.Width = 200;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Teléfono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
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
            this.Estado.Width = 113;
            // 
            // FormProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 459);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnRestablecerBusqueda);
            this.Controls.Add(this.txtIndiceFila);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.comboBuscar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataProveedor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.comboEstado);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtRazonSocial);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblUsuarioLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Name = "FormProveedores";
            this.Text = "FormProveedores";
            this.Load += new System.EventHandler(this.FormProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataProveedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnRestablecerBusqueda;
        private System.Windows.Forms.TextBox txtIndiceFila;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ComboBox comboBuscar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataProveedor;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton btnBorrar;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private System.Windows.Forms.ComboBox comboEstado;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblUsuarioLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionarProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn RazonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}