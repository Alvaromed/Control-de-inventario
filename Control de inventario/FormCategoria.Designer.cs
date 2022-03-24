
namespace Control_de_inventario
{
    partial class FormCategoria
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnRestablecerBusqueda = new FontAwesome.Sharp.IconButton();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.comboBuscar = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBorrar = new FontAwesome.Sharp.IconButton();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIndiceFila = new System.Windows.Forms.TextBox();
            this.dataCategorias = new System.Windows.Forms.DataGridView();
            this.btnSeleccionarCategoria = new System.Windows.Forms.DataGridViewButtonColumn();
            this.IdCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminarCategoria = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.comboEstado = new System.Windows.Forms.ComboBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lblUsuarioLogin = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.progressBarListaProductos = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataCategorias)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
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
            this.btnRestablecerBusqueda.Location = new System.Drawing.Point(748, 18);
            this.btnRestablecerBusqueda.Name = "btnRestablecerBusqueda";
            this.btnRestablecerBusqueda.Size = new System.Drawing.Size(135, 23);
            this.btnRestablecerBusqueda.TabIndex = 62;
            this.btnRestablecerBusqueda.Text = "Restablecer búsqueda";
            this.btnRestablecerBusqueda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRestablecerBusqueda.UseVisualStyleBackColor = false;
            this.btnRestablecerBusqueda.Click += new System.EventHandler(this.btnRestablecerBusqueda_Click_1);
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
            this.btnBuscar.Location = new System.Drawing.Point(849, 15);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(37, 21);
            this.btnBuscar.TabIndex = 60;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscar.Location = new System.Drawing.Point(722, 15);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(121, 20);
            this.txtBuscar.TabIndex = 59;
            // 
            // comboBuscar
            // 
            this.comboBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBuscar.BackColor = System.Drawing.SystemColors.Window;
            this.comboBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBuscar.FormattingEnabled = true;
            this.comboBuscar.Location = new System.Drawing.Point(614, 14);
            this.comboBuscar.Name = "comboBuscar";
            this.comboBuscar.Size = new System.Drawing.Size(102, 21);
            this.comboBuscar.TabIndex = 58;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(550, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 21);
            this.label11.TabIndex = 57;
            this.label11.Text = "Buscar:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(24, 13);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(20, 20);
            this.txtId.TabIndex = 55;
            this.txtId.Text = "0";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Georgia", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(400, 33);
            this.label4.TabIndex = 54;
            this.label4.Text = "Lista de Categorías";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
            this.btnBorrar.Location = new System.Drawing.Point(24, 10);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(101, 29);
            this.btnBorrar.TabIndex = 51;
            this.btnBorrar.Text = "Eliminar";
            this.btnBorrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBorrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Visible = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click_1);
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
            this.btnGuardar.Location = new System.Drawing.Point(740, 56);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(101, 29);
            this.btnGuardar.TabIndex = 49;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.BackColor = System.Drawing.Color.Coral;
            this.label9.Location = new System.Drawing.Point(-26, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(931, 247);
            this.label9.TabIndex = 56;
            // 
            // txtIndiceFila
            // 
            this.txtIndiceFila.Location = new System.Drawing.Point(62, 13);
            this.txtIndiceFila.Name = "txtIndiceFila";
            this.txtIndiceFila.Size = new System.Drawing.Size(20, 20);
            this.txtIndiceFila.TabIndex = 61;
            this.txtIndiceFila.Text = "*";
            this.txtIndiceFila.Visible = false;
            // 
            // dataCategorias
            // 
            this.dataCategorias.AllowUserToAddRows = false;
            this.dataCategorias.AllowUserToDeleteRows = false;
            this.dataCategorias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataCategorias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataCategorias.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataCategorias.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataCategorias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataCategorias.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataCategorias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataCategorias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCategorias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnSeleccionarCategoria,
            this.IdCategoria,
            this.NombreCategoria,
            this.EstadoValor,
            this.Estado,
            this.btnEliminarCategoria});
            this.dataCategorias.Location = new System.Drawing.Point(24, 177);
            this.dataCategorias.MultiSelect = false;
            this.dataCategorias.Name = "dataCategorias";
            this.dataCategorias.ReadOnly = true;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dataCategorias.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataCategorias.RowTemplate.Height = 28;
            this.dataCategorias.Size = new System.Drawing.Size(860, 214);
            this.dataCategorias.TabIndex = 53;
            this.dataCategorias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataCategorias_CellContentClick);
            this.dataCategorias.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataCategorias_CellPainting);
            // 
            // btnSeleccionarCategoria
            // 
            this.btnSeleccionarCategoria.HeaderText = "";
            this.btnSeleccionarCategoria.Name = "btnSeleccionarCategoria";
            this.btnSeleccionarCategoria.ReadOnly = true;
            // 
            // IdCategoria
            // 
            this.IdCategoria.HeaderText = "IdCategoria";
            this.IdCategoria.Name = "IdCategoria";
            this.IdCategoria.ReadOnly = true;
            this.IdCategoria.Visible = false;
            // 
            // NombreCategoria
            // 
            this.NombreCategoria.HeaderText = "Categoría";
            this.NombreCategoria.Name = "NombreCategoria";
            this.NombreCategoria.ReadOnly = true;
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
            // btnEliminarCategoria
            // 
            this.btnEliminarCategoria.HeaderText = "";
            this.btnEliminarCategoria.Name = "btnEliminarCategoria";
            this.btnEliminarCategoria.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(323, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(258, 23);
            this.label3.TabIndex = 52;
            this.label3.Text = "Categorías de Productos";
            // 
            // comboEstado
            // 
            this.comboEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEstado.FormattingEnabled = true;
            this.comboEstado.Location = new System.Drawing.Point(482, 67);
            this.comboEstado.Name = "comboEstado";
            this.comboEstado.Size = new System.Drawing.Size(114, 21);
            this.comboEstado.TabIndex = 48;
            // 
            // txtCategoria
            // 
            this.txtCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCategoria.Location = new System.Drawing.Point(188, 68);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(172, 20);
            this.txtCategoria.TabIndex = 42;
            this.txtCategoria.TextChanged += new System.EventHandler(this.txtCategoria_TextChanged);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(434, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 41;
            this.label10.Text = "Estado";
            // 
            // lblUsuarioLogin
            // 
            this.lblUsuarioLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsuarioLogin.AutoSize = true;
            this.lblUsuarioLogin.BackColor = System.Drawing.Color.White;
            this.lblUsuarioLogin.Location = new System.Drawing.Point(123, 72);
            this.lblUsuarioLogin.Name = "lblUsuarioLogin";
            this.lblUsuarioLogin.Size = new System.Drawing.Size(44, 13);
            this.lblUsuarioLogin.TabIndex = 35;
            this.lblUsuarioLogin.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(905, 125);
            this.label2.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.BackColor = System.Drawing.Color.Goldenrod;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(905, 44);
            this.label5.TabIndex = 63;
            // 
            // progressBarListaProductos
            // 
            this.progressBarListaProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarListaProductos.Location = new System.Drawing.Point(645, 27);
            this.progressBarListaProductos.Name = "progressBarListaProductos";
            this.progressBarListaProductos.Size = new System.Drawing.Size(97, 14);
            this.progressBarListaProductos.TabIndex = 66;
            this.progressBarListaProductos.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Coral;
            this.panel1.Controls.Add(this.progressBarListaProductos);
            this.panel1.Controls.Add(this.btnRestablecerBusqueda);
            this.panel1.Controls.Add(this.btnBorrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 401);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(905, 49);
            this.panel1.TabIndex = 67;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Goldenrod;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnBuscar);
            this.panel2.Controls.Add(this.txtBuscar);
            this.panel2.Controls.Add(this.comboBuscar);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(0, 120);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(905, 44);
            this.panel2.TabIndex = 68;
            // 
            // FormCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 450);
            this.Controls.Add(this.lblUsuarioLogin);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtIndiceFila);
            this.Controls.Add(this.dataCategorias);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboEstado);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel1);
            this.Name = "FormCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormCategoria";
            this.Load += new System.EventHandler(this.FormCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataCategorias)).EndInit();
            this.panel1.ResumeLayout(false);
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
        private FontAwesome.Sharp.IconButton btnGuardar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtIndiceFila;
        private System.Windows.Forms.DataGridView dataCategorias;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboEstado;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblUsuarioLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar progressBarListaProductos;
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionarCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewButtonColumn btnEliminarCategoria;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}