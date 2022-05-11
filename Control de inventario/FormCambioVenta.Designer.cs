
namespace Control_de_inventario
{
    partial class FormCambioVenta
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCambio2 = new System.Windows.Forms.TextBox();
            this.btnCerrar = new Control_de_inventario.DesignButtons.RJButton();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Su cambio:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCambio2
            // 
            this.txtCambio2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCambio2.Enabled = false;
            this.txtCambio2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCambio2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtCambio2.Location = new System.Drawing.Point(154, 118);
            this.txtCambio2.Name = "txtCambio2";
            this.txtCambio2.Size = new System.Drawing.Size(150, 31);
            this.txtCambio2.TabIndex = 1;
            this.txtCambio2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Peru;
            this.btnCerrar.BackgroundColor = System.Drawing.Color.Peru;
            this.btnCerrar.BorderColor = System.Drawing.Color.IndianRed;
            this.btnCerrar.BorderRadius = 20;
            this.btnCerrar.BorderSize = 2;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(154, 214);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(150, 40);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.TextColor = System.Drawing.Color.White;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(100, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "$";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormCambioVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(444, 292);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.txtCambio2);
            this.Controls.Add(this.label1);
            this.Name = "FormCambioVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCambioVenta";
            this.Load += new System.EventHandler(this.FormCambioVenta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DesignButtons.RJButton btnCerrar;
        public System.Windows.Forms.TextBox txtCambio2;
        private System.Windows.Forms.Label label2;
    }
}