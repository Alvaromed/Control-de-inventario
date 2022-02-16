
namespace Control_de_inventario
{
    partial class FormNegocio
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtRFC = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardar = new Control_de_inventario.DesignButtons.RJButton();
            this.btnLogo = new Control_de_inventario.DesignButtons.RJButton();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Coral;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(63, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(276, 23);
            this.label3.TabIndex = 54;
            this.label3.Text = "Configuración de Negocio ";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(520, 450);
            this.label2.TabIndex = 53;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(this.txtRFC);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnLogo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Logo);
            this.groupBox1.Location = new System.Drawing.Point(16, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 297);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(22, 181);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(211, 20);
            this.txtDireccion.TabIndex = 9;
            // 
            // txtRFC
            // 
            this.txtRFC.Location = new System.Drawing.Point(22, 122);
            this.txtRFC.Name = "txtRFC";
            this.txtRFC.Size = new System.Drawing.Size(211, 20);
            this.txtRFC.TabIndex = 8;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(22, 75);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(211, 20);
            this.txtNombre.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Dirección";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "RFC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(365, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Logo";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Silver;
            this.btnGuardar.BackgroundColor = System.Drawing.Color.Silver;
            this.btnGuardar.BorderColor = System.Drawing.Color.Black;
            this.btnGuardar.BorderRadius = 16;
            this.btnGuardar.BorderSize = 0;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSalmon;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSalmon;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.Color.Black;
            this.btnGuardar.Image = global::Control_de_inventario.Properties.Resources.save_color;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(51, 217);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnGuardar.Size = new System.Drawing.Size(145, 35);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar Cambios";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.TextColor = System.Drawing.Color.Black;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLogo
            // 
            this.btnLogo.BackColor = System.Drawing.Color.Silver;
            this.btnLogo.BackgroundColor = System.Drawing.Color.Silver;
            this.btnLogo.BorderColor = System.Drawing.Color.Black;
            this.btnLogo.BorderRadius = 16;
            this.btnLogo.BorderSize = 0;
            this.btnLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogo.FlatAppearance.BorderSize = 0;
            this.btnLogo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PapayaWhip;
            this.btnLogo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PapayaWhip;
            this.btnLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogo.ForeColor = System.Drawing.Color.Black;
            this.btnLogo.Image = global::Control_de_inventario.Properties.Resources.save_image;
            this.btnLogo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogo.Location = new System.Drawing.Point(322, 217);
            this.btnLogo.Name = "btnLogo";
            this.btnLogo.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnLogo.Size = new System.Drawing.Size(117, 35);
            this.btnLogo.TabIndex = 2;
            this.btnLogo.Text = "Subir Logo";
            this.btnLogo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogo.TextColor = System.Drawing.Color.Black;
            this.btnLogo.UseVisualStyleBackColor = false;
            this.btnLogo.Click += new System.EventHandler(this.btnLogo_Click);
            // 
            // Logo
            // 
            this.Logo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Logo.Location = new System.Drawing.Point(290, 59);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(173, 142);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // FormNegocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "FormNegocio";
            this.Text = "FormNegocio";
            this.Load += new System.EventHandler(this.FormNegocio_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private DesignButtons.RJButton btnLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Logo;
        private DesignButtons.RJButton btnGuardar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtRFC;
        private System.Windows.Forms.TextBox txtNombre;
    }
}