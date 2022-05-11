
namespace Control_de_inventario
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.menuUsuarios = new FontAwesome.Sharp.IconMenuItem();
            this.menuConfiguracion = new FontAwesome.Sharp.IconMenuItem();
            this.categoria = new FontAwesome.Sharp.IconMenuItem();
            this.producto = new FontAwesome.Sharp.IconMenuItem();
            this.negocio = new FontAwesome.Sharp.IconMenuItem();
            this.menuProducto = new FontAwesome.Sharp.IconMenuItem();
            this.menuVentas = new FontAwesome.Sharp.IconMenuItem();
            this.registrarVenta = new FontAwesome.Sharp.IconMenuItem();
            this.detalleVenta = new FontAwesome.Sharp.IconMenuItem();
            this.menuCompras = new FontAwesome.Sharp.IconMenuItem();
            this.registrarCompra = new FontAwesome.Sharp.IconMenuItem();
            this.detalleCompra = new FontAwesome.Sharp.IconMenuItem();
            this.menuProveedores = new FontAwesome.Sharp.IconMenuItem();
            this.menuReportes = new FontAwesome.Sharp.IconMenuItem();
            this.reportesCompras = new FontAwesome.Sharp.IconMenuItem();
            this.reporteVentas = new FontAwesome.Sharp.IconMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Total = new FontAwesome.Sharp.IconMenuItem();
            this.menuInfo = new FontAwesome.Sharp.IconMenuItem();
            this.Titulo = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.contenido = new System.Windows.Forms.Panel();
            this.panelBienvenida = new System.Windows.Forms.Panel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHoraSistema = new System.Windows.Forms.Label();
            this.labelUsu = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timerSistema = new System.Windows.Forms.Timer(this.components);
            this.Menu.SuspendLayout();
            this.contenido.SuspendLayout();
            this.panelBienvenida.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Menu.AutoSize = false;
            this.Menu.BackColor = System.Drawing.Color.White;
            this.Menu.Dock = System.Windows.Forms.DockStyle.None;
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuUsuarios,
            this.menuConfiguracion,
            this.menuProducto,
            this.menuVentas,
            this.menuCompras,
            this.menuProveedores,
            this.menuReportes,
            this.menuInfo});
            this.Menu.Location = new System.Drawing.Point(0, 56);
            this.Menu.Name = "Menu";
            this.Menu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Menu.ShowItemToolTips = true;
            this.Menu.Size = new System.Drawing.Size(2350, 24);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "menuStrip1";
            this.Menu.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Menu_Scroll);
            // 
            // menuUsuarios
            // 
            this.menuUsuarios.ForeColor = System.Drawing.SystemColors.ControlText;
            this.menuUsuarios.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.menuUsuarios.IconColor = System.Drawing.Color.Black;
            this.menuUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuUsuarios.Name = "menuUsuarios";
            this.menuUsuarios.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.menuUsuarios.Size = new System.Drawing.Size(80, 20);
            this.menuUsuarios.Text = "Usuarios";
            this.menuUsuarios.Click += new System.EventHandler(this.menuUsuarios_Click);
            this.menuUsuarios.MouseLeave += new System.EventHandler(this.menuUsuarios_MouseLeave);
            this.menuUsuarios.MouseHover += new System.EventHandler(this.menuUsuarios_MouseHover);
            // 
            // menuConfiguracion
            // 
            this.menuConfiguracion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoria,
            this.producto,
            this.negocio});
            this.menuConfiguracion.IconChar = FontAwesome.Sharp.IconChar.Toolbox;
            this.menuConfiguracion.IconColor = System.Drawing.Color.Black;
            this.menuConfiguracion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuConfiguracion.Name = "menuConfiguracion";
            this.menuConfiguracion.Size = new System.Drawing.Size(111, 20);
            this.menuConfiguracion.Text = "Configuración";
            this.menuConfiguracion.Click += new System.EventHandler(this.menuHerramientas_Click);
            // 
            // categoria
            // 
            this.categoria.IconChar = FontAwesome.Sharp.IconChar.Folder;
            this.categoria.IconColor = System.Drawing.Color.Black;
            this.categoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.categoria.Name = "categoria";
            this.categoria.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.categoria.Size = new System.Drawing.Size(168, 22);
            this.categoria.Text = "Categorias";
            this.categoria.Click += new System.EventHandler(this.categoria_Click);
            this.categoria.MouseLeave += new System.EventHandler(this.categoria_MouseLeave);
            this.categoria.MouseHover += new System.EventHandler(this.categoria_MouseHover);
            // 
            // producto
            // 
            this.producto.IconChar = FontAwesome.Sharp.IconChar.ObjectGroup;
            this.producto.IconColor = System.Drawing.Color.Black;
            this.producto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.producto.Name = "producto";
            this.producto.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
            this.producto.Size = new System.Drawing.Size(168, 22);
            this.producto.Text = "Produto";
            this.producto.Click += new System.EventHandler(this.producto_Click);
            this.producto.MouseLeave += new System.EventHandler(this.producto_MouseLeave);
            this.producto.MouseHover += new System.EventHandler(this.producto_MouseHover);
            // 
            // negocio
            // 
            this.negocio.IconChar = FontAwesome.Sharp.IconChar.Building;
            this.negocio.IconColor = System.Drawing.Color.Black;
            this.negocio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.negocio.Name = "negocio";
            this.negocio.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.N)));
            this.negocio.Size = new System.Drawing.Size(168, 22);
            this.negocio.Text = "Negocio";
            this.negocio.Click += new System.EventHandler(this.negocio_Click);
            this.negocio.MouseLeave += new System.EventHandler(this.negocio_MouseLeave);
            this.negocio.MouseHover += new System.EventHandler(this.negocio_MouseHover);
            // 
            // menuProducto
            // 
            this.menuProducto.IconChar = FontAwesome.Sharp.IconChar.BoxOpen;
            this.menuProducto.IconColor = System.Drawing.Color.Black;
            this.menuProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuProducto.Name = "menuProducto";
            this.menuProducto.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.menuProducto.Size = new System.Drawing.Size(89, 20);
            this.menuProducto.Text = "Productos";
            this.menuProducto.Click += new System.EventHandler(this.menuProducto_Click);
            this.menuProducto.MouseLeave += new System.EventHandler(this.menuProducto_MouseLeave);
            this.menuProducto.MouseHover += new System.EventHandler(this.menuProducto_MouseHover);
            // 
            // menuVentas
            // 
            this.menuVentas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarVenta,
            this.detalleVenta});
            this.menuVentas.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.menuVentas.IconColor = System.Drawing.Color.Black;
            this.menuVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuVentas.Name = "menuVentas";
            this.menuVentas.Size = new System.Drawing.Size(69, 20);
            this.menuVentas.Text = "Ventas";
            // 
            // registrarVenta
            // 
            this.registrarVenta.IconChar = FontAwesome.Sharp.IconChar.Barcode;
            this.registrarVenta.IconColor = System.Drawing.Color.Black;
            this.registrarVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.registrarVenta.Name = "registrarVenta";
            this.registrarVenta.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.registrarVenta.Size = new System.Drawing.Size(174, 22);
            this.registrarVenta.Text = "Registrar";
            this.registrarVenta.Click += new System.EventHandler(this.registrarVenta_Click);
            this.registrarVenta.MouseLeave += new System.EventHandler(this.registrarVenta_MouseLeave);
            this.registrarVenta.MouseHover += new System.EventHandler(this.registrarVenta_MouseHover);
            // 
            // detalleVenta
            // 
            this.detalleVenta.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
            this.detalleVenta.IconColor = System.Drawing.Color.Black;
            this.detalleVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.detalleVenta.Name = "detalleVenta";
            this.detalleVenta.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.V)));
            this.detalleVenta.Size = new System.Drawing.Size(174, 22);
            this.detalleVenta.Text = "Detalle";
            this.detalleVenta.Click += new System.EventHandler(this.detalleVenta_Click);
            this.detalleVenta.MouseLeave += new System.EventHandler(this.detalleVenta_MouseLeave);
            this.detalleVenta.MouseHover += new System.EventHandler(this.detalleVenta_MouseHover);
            // 
            // menuCompras
            // 
            this.menuCompras.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarCompra,
            this.detalleCompra});
            this.menuCompras.IconChar = FontAwesome.Sharp.IconChar.DollyFlatbed;
            this.menuCompras.IconColor = System.Drawing.Color.Black;
            this.menuCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuCompras.Name = "menuCompras";
            this.menuCompras.Size = new System.Drawing.Size(83, 20);
            this.menuCompras.Text = "Compras";
            // 
            // registrarCompra
            // 
            this.registrarCompra.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.registrarCompra.IconColor = System.Drawing.Color.Black;
            this.registrarCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.registrarCompra.Name = "registrarCompra";
            this.registrarCompra.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.registrarCompra.Size = new System.Drawing.Size(175, 22);
            this.registrarCompra.Text = "Agregar";
            this.registrarCompra.Click += new System.EventHandler(this.registrarCompra_Click);
            this.registrarCompra.MouseLeave += new System.EventHandler(this.registrarCompra_MouseLeave);
            this.registrarCompra.MouseHover += new System.EventHandler(this.registrarCompra_MouseHover);
            // 
            // detalleCompra
            // 
            this.detalleCompra.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
            this.detalleCompra.IconColor = System.Drawing.Color.Black;
            this.detalleCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.detalleCompra.Name = "detalleCompra";
            this.detalleCompra.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.C)));
            this.detalleCompra.Size = new System.Drawing.Size(175, 22);
            this.detalleCompra.Text = "Detalle";
            this.detalleCompra.Click += new System.EventHandler(this.detalleCompra_Click);
            this.detalleCompra.MouseLeave += new System.EventHandler(this.detalleCompra_MouseLeave);
            this.detalleCompra.MouseHover += new System.EventHandler(this.detalleCompra_MouseHover);
            // 
            // menuProveedores
            // 
            this.menuProveedores.IconChar = FontAwesome.Sharp.IconChar.Elementor;
            this.menuProveedores.IconColor = System.Drawing.Color.Black;
            this.menuProveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuProveedores.Name = "menuProveedores";
            this.menuProveedores.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menuProveedores.Size = new System.Drawing.Size(100, 20);
            this.menuProveedores.Text = "Proveedores";
            this.menuProveedores.Click += new System.EventHandler(this.menuProveedores_Click);
            this.menuProveedores.MouseLeave += new System.EventHandler(this.menuProveedores_MouseLeave);
            this.menuProveedores.MouseHover += new System.EventHandler(this.menuProveedores_MouseHover);
            // 
            // menuReportes
            // 
            this.menuReportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportesCompras,
            this.reporteVentas,
            this.toolStripSeparator1,
            this.Total});
            this.menuReportes.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.menuReportes.IconColor = System.Drawing.Color.Black;
            this.menuReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuReportes.Name = "menuReportes";
            this.menuReportes.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.menuReportes.Size = new System.Drawing.Size(81, 20);
            this.menuReportes.Text = "Reportes";
            this.menuReportes.ToolTipText = "Ver reportes";
            this.menuReportes.Click += new System.EventHandler(this.menuReportes_Click);
            this.menuReportes.MouseLeave += new System.EventHandler(this.menuReportes_MouseLeave);
            this.menuReportes.MouseHover += new System.EventHandler(this.menuReportes_MouseHover);
            // 
            // reportesCompras
            // 
            this.reportesCompras.IconChar = FontAwesome.Sharp.IconChar.ChartPie;
            this.reportesCompras.IconColor = System.Drawing.Color.Black;
            this.reportesCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.reportesCompras.Name = "reportesCompras";
            this.reportesCompras.Size = new System.Drawing.Size(122, 22);
            this.reportesCompras.Text = "Compras";
            this.reportesCompras.Click += new System.EventHandler(this.iconMenuItem1_Click);
            // 
            // reporteVentas
            // 
            this.reporteVentas.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.reporteVentas.IconColor = System.Drawing.Color.Black;
            this.reporteVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.reporteVentas.Name = "reporteVentas";
            this.reporteVentas.Size = new System.Drawing.Size(122, 22);
            this.reporteVentas.Text = "Ventas";
            this.reporteVentas.Click += new System.EventHandler(this.iconMenuItem2_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(119, 6);
            // 
            // Total
            // 
            this.Total.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Total.IconColor = System.Drawing.Color.Black;
            this.Total.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(122, 22);
            this.Total.Text = "Total";
            this.Total.Click += new System.EventHandler(this.Total_Click);
            // 
            // menuInfo
            // 
            this.menuInfo.IconChar = FontAwesome.Sharp.IconChar.Info;
            this.menuInfo.IconColor = System.Drawing.Color.Black;
            this.menuInfo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuInfo.Name = "menuInfo";
            this.menuInfo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.menuInfo.Size = new System.Drawing.Size(56, 20);
            this.menuInfo.Text = "Info";
            this.menuInfo.Click += new System.EventHandler(this.menuInfo_Click);
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = false;
            this.Titulo.BackColor = System.Drawing.Color.Coral;
            this.Titulo.Location = new System.Drawing.Point(0, 0);
            this.Titulo.Name = "Titulo";
            this.Titulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Titulo.Size = new System.Drawing.Size(1904, 56);
            this.Titulo.TabIndex = 1;
            this.Titulo.Text = "menuStrip2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Coral;
            this.label1.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(875, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "InventoryDA";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // contenido
            // 
            this.contenido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contenido.Controls.Add(this.panelBienvenida);
            this.contenido.Location = new System.Drawing.Point(0, 83);
            this.contenido.Name = "contenido";
            this.contenido.Size = new System.Drawing.Size(1904, 912);
            this.contenido.TabIndex = 3;
            // 
            // panelBienvenida
            // 
            this.panelBienvenida.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBienvenida.Controls.Add(this.lblUsuario);
            this.panelBienvenida.Controls.Add(this.lblWelcome);
            this.panelBienvenida.Location = new System.Drawing.Point(12, 67);
            this.panelBienvenida.Name = "panelBienvenida";
            this.panelBienvenida.Size = new System.Drawing.Size(1875, 794);
            this.panelBienvenida.TabIndex = 4;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Font = new System.Drawing.Font("Perpetua Titling MT", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(992, 365);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(410, 72);
            this.lblUsuario.TabIndex = 4;
            this.lblUsuario.Text = "Usuario";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblWelcome
            // 
            this.lblWelcome.Font = new System.Drawing.Font("Perpetua Titling MT", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(636, 365);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(359, 72);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Bienvenido";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblHoraSistema);
            this.panel1.Controls.Add(this.labelUsu);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 1001);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1904, 40);
            this.panel1.TabIndex = 3;
            // 
            // lblHoraSistema
            // 
            this.lblHoraSistema.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHoraSistema.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblHoraSistema.Location = new System.Drawing.Point(1710, 13);
            this.lblHoraSistema.Name = "lblHoraSistema";
            this.lblHoraSistema.Size = new System.Drawing.Size(179, 22);
            this.lblHoraSistema.TabIndex = 2;
            this.lblHoraSistema.Text = "HoraSistema";
            this.lblHoraSistema.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHoraSistema.MouseLeave += new System.EventHandler(this.lblHoraSistema_MouseLeave);
            this.lblHoraSistema.MouseHover += new System.EventHandler(this.lblHoraSistema_MouseHover);
            // 
            // labelUsu
            // 
            this.labelUsu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelUsu.AutoSize = true;
            this.labelUsu.BackColor = System.Drawing.Color.Transparent;
            this.labelUsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsu.Location = new System.Drawing.Point(76, 13);
            this.labelUsu.Name = "labelUsu";
            this.labelUsu.Size = new System.Drawing.Size(63, 17);
            this.labelUsu.TabIndex = 1;
            this.labelUsu.Text = "labelUsu";
            this.labelUsu.Click += new System.EventHandler(this.labelUsu_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Usuario:";
            // 
            // timerSistema
            // 
            this.timerSistema.Enabled = true;
            this.timerSistema.Tick += new System.EventHandler(this.timerSistema_Tick);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.contenido);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Titulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Menu;
            this.MinimumSize = new System.Drawing.Size(902, 611);
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de Inventario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Inicio_FormClosing);
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.contenido.ResumeLayout(false);
            this.panelBienvenida.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.MenuStrip Titulo;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconMenuItem menuUsuarios;
        private FontAwesome.Sharp.IconMenuItem menuConfiguracion;
        private FontAwesome.Sharp.IconMenuItem menuVentas;
        private FontAwesome.Sharp.IconMenuItem menuCompras;
        private FontAwesome.Sharp.IconMenuItem menuProveedores;
        private FontAwesome.Sharp.IconMenuItem menuReportes;
        private FontAwesome.Sharp.IconMenuItem menuInfo;
        private System.Windows.Forms.Panel contenido;
        private System.Windows.Forms.Label labelUsu;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconMenuItem categoria;
        private FontAwesome.Sharp.IconMenuItem producto;
        private FontAwesome.Sharp.IconMenuItem registrarVenta;
        private FontAwesome.Sharp.IconMenuItem detalleVenta;
        private FontAwesome.Sharp.IconMenuItem registrarCompra;
        private FontAwesome.Sharp.IconMenuItem detalleCompra;
        private FontAwesome.Sharp.IconMenuItem negocio;
        private System.Windows.Forms.Label lblHoraSistema;
        private System.Windows.Forms.Timer timerSistema;
        private FontAwesome.Sharp.IconMenuItem menuProducto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel panelBienvenida;
        private System.Windows.Forms.Label lblUsuario;
        private FontAwesome.Sharp.IconMenuItem reportesCompras;
        private FontAwesome.Sharp.IconMenuItem reporteVentas;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private FontAwesome.Sharp.IconMenuItem Total;
    }
}

