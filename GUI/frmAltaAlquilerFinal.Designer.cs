namespace GUI
{
    partial class frmAltaAlquilerFinal
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
            this.txtUnidad = new System.Windows.Forms.TextBox();
            this.lblUnidad = new System.Windows.Forms.Label();
            this.txtPropiedad = new System.Windows.Forms.TextBox();
            this.lblPropiedad = new System.Windows.Forms.Label();
            this.txtInquilino = new System.Windows.Forms.TextBox();
            this.lblInquilino = new System.Windows.Forms.Label();
            this.txtContrato = new System.Windows.Forms.TextBox();
            this.lblContrato = new System.Windows.Forms.Label();
            this.grpDatosAlquiler = new System.Windows.Forms.GroupBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grpDatosAlquiler.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUnidad
            // 
            this.txtUnidad.Enabled = false;
            this.txtUnidad.Location = new System.Drawing.Point(183, 102);
            this.txtUnidad.Name = "txtUnidad";
            this.txtUnidad.Size = new System.Drawing.Size(34, 20);
            this.txtUnidad.TabIndex = 26;
            // 
            // lblUnidad
            // 
            this.lblUnidad.AutoSize = true;
            this.lblUnidad.Location = new System.Drawing.Point(93, 105);
            this.lblUnidad.Name = "lblUnidad";
            this.lblUnidad.Size = new System.Drawing.Size(84, 13);
            this.lblUnidad.TabIndex = 25;
            this.lblUnidad.Text = "Unidad Numero:";
            // 
            // txtPropiedad
            // 
            this.txtPropiedad.Enabled = false;
            this.txtPropiedad.Location = new System.Drawing.Point(183, 63);
            this.txtPropiedad.Name = "txtPropiedad";
            this.txtPropiedad.Size = new System.Drawing.Size(219, 20);
            this.txtPropiedad.TabIndex = 24;
            // 
            // lblPropiedad
            // 
            this.lblPropiedad.AutoSize = true;
            this.lblPropiedad.Location = new System.Drawing.Point(93, 66);
            this.lblPropiedad.Name = "lblPropiedad";
            this.lblPropiedad.Size = new System.Drawing.Size(83, 13);
            this.lblPropiedad.TabIndex = 23;
            this.lblPropiedad.Text = "Calle propiedad:";
            // 
            // txtInquilino
            // 
            this.txtInquilino.Enabled = false;
            this.txtInquilino.Location = new System.Drawing.Point(183, 32);
            this.txtInquilino.Name = "txtInquilino";
            this.txtInquilino.Size = new System.Drawing.Size(113, 20);
            this.txtInquilino.TabIndex = 22;
            // 
            // lblInquilino
            // 
            this.lblInquilino.AutoSize = true;
            this.lblInquilino.Location = new System.Drawing.Point(106, 35);
            this.lblInquilino.Name = "lblInquilino";
            this.lblInquilino.Size = new System.Drawing.Size(71, 13);
            this.lblInquilino.TabIndex = 21;
            this.lblInquilino.Text = "DNI Inquilino:";
            // 
            // txtContrato
            // 
            this.txtContrato.Location = new System.Drawing.Point(183, 144);
            this.txtContrato.Multiline = true;
            this.txtContrato.Name = "txtContrato";
            this.txtContrato.Size = new System.Drawing.Size(132, 121);
            this.txtContrato.TabIndex = 20;
            // 
            // lblContrato
            // 
            this.lblContrato.AutoSize = true;
            this.lblContrato.Location = new System.Drawing.Point(78, 144);
            this.lblContrato.Name = "lblContrato";
            this.lblContrato.Size = new System.Drawing.Size(99, 26);
            this.lblContrato.TabIndex = 19;
            this.lblContrato.Text = "Cuestiones anexas \r\n            al contrato:";
            // 
            // grpDatosAlquiler
            // 
            this.grpDatosAlquiler.BackColor = System.Drawing.Color.Transparent;
            this.grpDatosAlquiler.Controls.Add(this.btnRegistrar);
            this.grpDatosAlquiler.Controls.Add(this.lblInquilino);
            this.grpDatosAlquiler.Controls.Add(this.txtUnidad);
            this.grpDatosAlquiler.Controls.Add(this.lblContrato);
            this.grpDatosAlquiler.Controls.Add(this.lblUnidad);
            this.grpDatosAlquiler.Controls.Add(this.txtContrato);
            this.grpDatosAlquiler.Controls.Add(this.txtPropiedad);
            this.grpDatosAlquiler.Controls.Add(this.txtInquilino);
            this.grpDatosAlquiler.Controls.Add(this.lblPropiedad);
            this.grpDatosAlquiler.Location = new System.Drawing.Point(114, 12);
            this.grpDatosAlquiler.Name = "grpDatosAlquiler";
            this.grpDatosAlquiler.Size = new System.Drawing.Size(418, 342);
            this.grpDatosAlquiler.TabIndex = 27;
            this.grpDatosAlquiler.TabStop = false;
            this.grpDatosAlquiler.Text = "Datos Alquiler";
            this.grpDatosAlquiler.Enter += new System.EventHandler(this.grpDatosAlquiler_Enter);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(183, 297);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 27;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(297, 391);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 28;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // frmAltaAlquilerFinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(646, 442);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.grpDatosAlquiler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAltaAlquilerFinal";
            this.Text = "Alta Alquiler";
            this.grpDatosAlquiler.ResumeLayout(false);
            this.grpDatosAlquiler.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtUnidad;
        private System.Windows.Forms.Label lblUnidad;
        private System.Windows.Forms.TextBox txtPropiedad;
        private System.Windows.Forms.Label lblPropiedad;
        private System.Windows.Forms.TextBox txtInquilino;
        private System.Windows.Forms.Label lblInquilino;
        private System.Windows.Forms.TextBox txtContrato;
        private System.Windows.Forms.Label lblContrato;
        private System.Windows.Forms.GroupBox grpDatosAlquiler;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnCancelar;
    }
}