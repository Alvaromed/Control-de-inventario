
namespace Control_de_inventario
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.lblTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboUsuario = new System.Windows.Forms.ComboBox();
            this.btnEntrar = new Control_de_inventario.DesignButtons.RJButton();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.btnAcceder = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Coral;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(348, 43);
            this.lblTitle.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Coral;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Location = new System.Drawing.Point(0, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(348, 23);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Coral;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "CONTROL DE INVENTARIO";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(138, 163);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(165, 20);
            this.txtPassword.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Usuario";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Contraseña";
            // 
            // comboUsuario
            // 
            this.comboUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboUsuario.FormattingEnabled = true;
            this.comboUsuario.Location = new System.Drawing.Point(138, 106);
            this.comboUsuario.Name = "comboUsuario";
            this.comboUsuario.Size = new System.Drawing.Size(165, 23);
            this.comboUsuario.TabIndex = 1;
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnEntrar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnEntrar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnEntrar.BorderRadius = 13;
            this.btnEntrar.BorderSize = 0;
            this.btnEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrar.FlatAppearance.BorderSize = 0;
            this.btnEntrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.ForeColor = System.Drawing.Color.Black;
            this.btnEntrar.Image = global::Control_de_inventario.Properties.Resources.unlockBueno;
            this.btnEntrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEntrar.Location = new System.Drawing.Point(100, 215);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnEntrar.Size = new System.Drawing.Size(150, 33);
            this.btnEntrar.TabIndex = 3;
            this.btnEntrar.Text = "Acceder";
            this.btnEntrar.TextColor = System.Drawing.Color.Black;
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.Color.Coral;
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = global::Control_de_inventario.Properties.Resources.minimizar2;
            this.btnMinimizar.Location = new System.Drawing.Point(266, 12);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(29, 31);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 11;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Coral;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::Control_de_inventario.Properties.Resources.close1;
            this.btnCerrar.Location = new System.Drawing.Point(301, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(35, 35);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnCerrar.TabIndex = 10;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(202)))));
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btnCancelar.IconColor = System.Drawing.Color.Black;
            this.btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelar.IconSize = 20;
            this.btnCancelar.Location = new System.Drawing.Point(2, 276);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(87, 24);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Salir";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAcceder
            // 
            this.btnAcceder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(255)))), ((int)(((byte)(210)))));
            this.btnAcceder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAcceder.FlatAppearance.BorderSize = 0;
            this.btnAcceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcceder.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnAcceder.IconColor = System.Drawing.Color.Black;
            this.btnAcceder.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAcceder.IconSize = 20;
            this.btnAcceder.Location = new System.Drawing.Point(98, 277);
            this.btnAcceder.Name = "btnAcceder";
            this.btnAcceder.Size = new System.Drawing.Size(101, 23);
            this.btnAcceder.TabIndex = 7;
            this.btnAcceder.Text = "Acceder";
            this.btnAcceder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAcceder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAcceder.UseVisualStyleBackColor = false;
            this.btnAcceder.Visible = false;
            this.btnAcceder.Click += new System.EventHandler(this.iconButton1_Click);
            this.btnAcceder.Paint += new System.Windows.Forms.PaintEventHandler(this.FormaRedonda);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(348, 300);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.comboUsuario);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAcceder);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de Inventario";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton btnAcceder;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private System.Windows.Forms.ComboBox comboUsuario;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private DesignButtons.RJButton btnEntrar;
    }
}