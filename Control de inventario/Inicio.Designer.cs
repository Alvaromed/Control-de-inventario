
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.Titulo = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.contenido = new System.Windows.Forms.Panel();
            this.labelUsu = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuUsuarios = new FontAwesome.Sharp.IconMenuItem();
            this.menuConfiguracion = new FontAwesome.Sharp.IconMenuItem();
            this.categoria = new FontAwesome.Sharp.IconMenuItem();
            this.producto = new FontAwesome.Sharp.IconMenuItem();
            this.negocio = new FontAwesome.Sharp.IconMenuItem();
            this.menuVentas = new FontAwesome.Sharp.IconMenuItem();
            this.registrarVenta = new FontAwesome.Sharp.IconMenuItem();
            this.detalleVenta = new FontAwesome.Sharp.IconMenuItem();
            this.menuCompras = new FontAwesome.Sharp.IconMenuItem();
            this.registrarCompra = new FontAwesome.Sharp.IconMenuItem();
            this.detalleCompra = new FontAwesome.Sharp.IconMenuItem();
            this.menuClientes = new FontAwesome.Sharp.IconMenuItem();
            this.menuProveedores = new FontAwesome.Sharp.IconMenuItem();
            this.menuReportes = new FontAwesome.Sharp.IconMenuItem();
            this.menuInfo = new FontAwesome.Sharp.IconMenuItem();
            this.Menu.SuspendLayout();
            this.contenido.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.White;
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuUsuarios,
            this.menuConfiguracion,
            this.menuVentas,
            this.menuCompras,
            this.menuClientes,
            this.menuProveedores,
            this.menuReportes,
            this.menuInfo});
            this.Menu.Location = new System.Drawing.Point(0, 45);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(899, 24);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "menuStrip1";
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = false;
            this.Titulo.BackColor = System.Drawing.Color.Coral;
            this.Titulo.Location = new System.Drawing.Point(0, 0);
            this.Titulo.Name = "Titulo";
            this.Titulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Titulo.Size = new System.Drawing.Size(899, 45);
            this.Titulo.TabIndex = 1;
            this.Titulo.Text = "menuStrip2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Coral;
            this.label1.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(314, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Control de Inventario";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // contenido
            // 
            this.contenido.Controls.Add(this.labelUsu);
            this.contenido.Controls.Add(this.label2);
            this.contenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenido.Location = new System.Drawing.Point(0, 69);
            this.contenido.Name = "contenido";
            this.contenido.Size = new System.Drawing.Size(899, 469);
            this.contenido.TabIndex = 3;
            // 
            // labelUsu
            // 
            this.labelUsu.AutoSize = true;
            this.labelUsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsu.Location = new System.Drawing.Point(79, 443);
            this.labelUsu.Name = "labelUsu";
            this.labelUsu.Size = new System.Drawing.Size(63, 17);
            this.labelUsu.TabIndex = 1;
            this.labelUsu.Text = "labelUsu";
            this.labelUsu.Click += new System.EventHandler(this.labelUsu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 443);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Usuario:";
            // 
            // menuUsuarios
            // 
            this.menuUsuarios.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.menuUsuarios.IconColor = System.Drawing.Color.Black;
            this.menuUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuUsuarios.Name = "menuUsuarios";
            this.menuUsuarios.Size = new System.Drawing.Size(80, 20);
            this.menuUsuarios.Text = "Usuarios";
            this.menuUsuarios.Click += new System.EventHandler(this.menuUsuarios_Click);
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
            this.categoria.Size = new System.Drawing.Size(130, 22);
            this.categoria.Text = "Categorias";
            this.categoria.Click += new System.EventHandler(this.categoria_Click);
            // 
            // producto
            // 
            this.producto.IconChar = FontAwesome.Sharp.IconChar.ObjectGroup;
            this.producto.IconColor = System.Drawing.Color.Black;
            this.producto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.producto.Name = "producto";
            this.producto.Size = new System.Drawing.Size(130, 22);
            this.producto.Text = "Produto";
            this.producto.Click += new System.EventHandler(this.producto_Click);
            // 
            // negocio
            // 
            this.negocio.IconChar = FontAwesome.Sharp.IconChar.Building;
            this.negocio.IconColor = System.Drawing.Color.Black;
            this.negocio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.negocio.Name = "negocio";
            this.negocio.Size = new System.Drawing.Size(130, 22);
            this.negocio.Text = "Negocio";
            this.negocio.Click += new System.EventHandler(this.negocio_Click);
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
            this.registrarVenta.IconChar = FontAwesome.Sharp.IconChar.None;
            this.registrarVenta.IconColor = System.Drawing.Color.Black;
            this.registrarVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.registrarVenta.Name = "registrarVenta";
            this.registrarVenta.Size = new System.Drawing.Size(120, 22);
            this.registrarVenta.Text = "Registrar";
            this.registrarVenta.Click += new System.EventHandler(this.registrarVenta_Click);
            // 
            // detalleVenta
            // 
            this.detalleVenta.IconChar = FontAwesome.Sharp.IconChar.None;
            this.detalleVenta.IconColor = System.Drawing.Color.Black;
            this.detalleVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.detalleVenta.Name = "detalleVenta";
            this.detalleVenta.Size = new System.Drawing.Size(120, 22);
            this.detalleVenta.Text = "Detalle";
            this.detalleVenta.Click += new System.EventHandler(this.detalleVenta_Click);
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
            this.registrarCompra.IconChar = FontAwesome.Sharp.IconChar.None;
            this.registrarCompra.IconColor = System.Drawing.Color.Black;
            this.registrarCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.registrarCompra.Name = "registrarCompra";
            this.registrarCompra.Size = new System.Drawing.Size(180, 22);
            this.registrarCompra.Text = "Agregar";
            this.registrarCompra.Click += new System.EventHandler(this.registrarCompra_Click);
            // 
            // detalleCompra
            // 
            this.detalleCompra.IconChar = FontAwesome.Sharp.IconChar.None;
            this.detalleCompra.IconColor = System.Drawing.Color.Black;
            this.detalleCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.detalleCompra.Name = "detalleCompra";
            this.detalleCompra.Size = new System.Drawing.Size(180, 22);
            this.detalleCompra.Text = "Detalle";
            this.detalleCompra.Click += new System.EventHandler(this.detalleCompra_Click);
            // 
            // menuClientes
            // 
            this.menuClientes.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            this.menuClientes.IconColor = System.Drawing.Color.Black;
            this.menuClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuClientes.Name = "menuClientes";
            this.menuClientes.Size = new System.Drawing.Size(77, 20);
            this.menuClientes.Text = "Clientes";
            this.menuClientes.Click += new System.EventHandler(this.menuClientes_Click);
            // 
            // menuProveedores
            // 
            this.menuProveedores.IconChar = FontAwesome.Sharp.IconChar.Elementor;
            this.menuProveedores.IconColor = System.Drawing.Color.Black;
            this.menuProveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuProveedores.Name = "menuProveedores";
            this.menuProveedores.Size = new System.Drawing.Size(100, 20);
            this.menuProveedores.Text = "Proveedores";
            this.menuProveedores.Click += new System.EventHandler(this.menuProveedores_Click);
            // 
            // menuReportes
            // 
            this.menuReportes.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.menuReportes.IconColor = System.Drawing.Color.Black;
            this.menuReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuReportes.Name = "menuReportes";
            this.menuReportes.Size = new System.Drawing.Size(81, 20);
            this.menuReportes.Text = "Reportes";
            this.menuReportes.Click += new System.EventHandler(this.menuReportes_Click);
            // 
            // menuInfo
            // 
            this.menuInfo.IconChar = FontAwesome.Sharp.IconChar.Info;
            this.menuInfo.IconColor = System.Drawing.Color.Black;
            this.menuInfo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuInfo.Name = "menuInfo";
            this.menuInfo.Size = new System.Drawing.Size(56, 20);
            this.menuInfo.Text = "Info";
            this.menuInfo.Click += new System.EventHandler(this.menuInfo_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 538);
            this.Controls.Add(this.contenido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.Titulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Menu;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de Inventario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Inicio_FormClosing);
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.contenido.ResumeLayout(false);
            this.contenido.PerformLayout();
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
        private FontAwesome.Sharp.IconMenuItem menuClientes;
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
    }
}

