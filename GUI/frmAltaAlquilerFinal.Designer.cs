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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.grpValores = new System.Windows.Forms.GroupBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.fechaHasta = new System.Windows.Forms.DateTimePicker();
            this.fechaDesde = new System.Windows.Forms.DateTimePicker();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.grpDatosAlquiler.SuspendLayout();
            this.grpValores.SuspendLayout();
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
            this.grpDatosAlquiler.Controls.Add(this.btnAceptar);
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
            this.grpDatosAlquiler.Size = new System.Drawing.Size(418, 333);
            this.grpDatosAlquiler.TabIndex = 27;
            this.grpDatosAlquiler.TabStop = false;
            this.grpDatosAlquiler.Text = "Datos Alquiler";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(172, 289);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(92, 23);
            this.btnAceptar.TabIndex = 33;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(297, 583);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 28;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.Location = new System.Drawing.Point(17, 25);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(74, 13);
            this.lblFechaDesde.TabIndex = 28;
            this.lblFechaDesde.Text = "Fecha Desde:";
            // 
            // grpValores
            // 
            this.grpValores.BackColor = System.Drawing.Color.Transparent;
            this.grpValores.Controls.Add(this.btnGuardar);
            this.grpValores.Controls.Add(this.fechaHasta);
            this.grpValores.Controls.Add(this.fechaDesde);
            this.grpValores.Controls.Add(this.txtValor);
            this.grpValores.Controls.Add(this.lblValor);
            this.grpValores.Controls.Add(this.lblFechaHasta);
            this.grpValores.Controls.Add(this.lblFechaDesde);
            this.grpValores.Enabled = false;
            this.grpValores.Location = new System.Drawing.Point(114, 378);
            this.grpValores.Name = "grpValores";
            this.grpValores.Size = new System.Drawing.Size(418, 170);
            this.grpValores.TabIndex = 29;
            this.grpValores.TabStop = false;
            this.grpValores.Text = "Valores Mensuales";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(172, 123);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(92, 23);
            this.btnGuardar.TabIndex = 30;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // fechaHasta
            // 
            this.fechaHasta.Location = new System.Drawing.Point(97, 52);
            this.fechaHasta.Name = "fechaHasta";
            this.fechaHasta.Size = new System.Drawing.Size(200, 20);
            this.fechaHasta.TabIndex = 32;
            // 
            // fechaDesde
            // 
            this.fechaDesde.Location = new System.Drawing.Point(96, 19);
            this.fechaDesde.Name = "fechaDesde";
            this.fechaDesde.Size = new System.Drawing.Size(200, 20);
            this.fechaDesde.TabIndex = 31;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(96, 85);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(113, 20);
            this.txtValor.TabIndex = 27;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(56, 88);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(34, 13);
            this.lblValor.TabIndex = 30;
            this.lblValor.Text = "Valor:";
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Location = new System.Drawing.Point(17, 52);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(71, 13);
            this.lblFechaHasta.TabIndex = 29;
            this.lblFechaHasta.Text = "Fecha Hasta:";
            // 
            // frmAltaAlquilerFinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(644, 652);
            this.Controls.Add(this.grpValores);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.grpDatosAlquiler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAltaAlquilerFinal";
            this.Text = "Alta Alquiler";
            this.grpDatosAlquiler.ResumeLayout(false);
            this.grpDatosAlquiler.PerformLayout();
            this.grpValores.ResumeLayout(false);
            this.grpValores.PerformLayout();
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
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.GroupBox grpValores;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DateTimePicker fechaHasta;
        private System.Windows.Forms.DateTimePicker fechaDesde;
        private System.Windows.Forms.Button btnAceptar;
    }
}