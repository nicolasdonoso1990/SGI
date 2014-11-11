namespace GUI
{
    partial class frmRegistrarPago
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
            this.grboxInquilino = new System.Windows.Forms.GroupBox();
            this.dgvInquilinos = new System.Windows.Forms.DataGridView();
            this.btnSeleccionarInquilino = new System.Windows.Forms.Button();
            this.lblFiltroDni = new System.Windows.Forms.Label();
            this.txtboxFiltroDni = new System.Windows.Forms.TextBox();
            this.grpboxUnidad = new System.Windows.Forms.GroupBox();
            this.txtboxNombreInquilino = new System.Windows.Forms.TextBox();
            this.lblNombreInquilino = new System.Windows.Forms.Label();
            this.btnSeleccionarUnidad = new System.Windows.Forms.Button();
            this.dgvUnidades = new System.Windows.Forms.DataGridView();
            this.CodigoDeUnidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroAlquiler = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroInquilino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Domicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpboxPago = new System.Windows.Forms.GroupBox();
            this.txtboxMontoMensual = new System.Windows.Forms.TextBox();
            this.lblMontoMensual = new System.Windows.Forms.Label();
            this.txtboxDescripcion = new System.Windows.Forms.TextBox();
            this.txtboxDireccion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnRegistarPago = new System.Windows.Forms.Button();
            this.txtboxSaldoActual = new System.Windows.Forms.TextBox();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblFiltrarDomicilio = new System.Windows.Forms.Label();
            this.txtboxFiltroDescripcion = new System.Windows.Forms.TextBox();
            this.lblNroInquilino = new System.Windows.Forms.Label();
            this.txtboxNroInquilino = new System.Windows.Forms.TextBox();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtboxMontoaPagar = new System.Windows.Forms.MaskedTextBox();
            this.grboxInquilino.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInquilinos)).BeginInit();
            this.grpboxUnidad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnidades)).BeginInit();
            this.grpboxPago.SuspendLayout();
            this.SuspendLayout();
            // 
            // grboxInquilino
            // 
            this.grboxInquilino.Controls.Add(this.dgvInquilinos);
            this.grboxInquilino.Controls.Add(this.btnSeleccionarInquilino);
            this.grboxInquilino.Controls.Add(this.lblFiltroDni);
            this.grboxInquilino.Controls.Add(this.txtboxFiltroDni);
            this.grboxInquilino.Location = new System.Drawing.Point(12, 12);
            this.grboxInquilino.Name = "grboxInquilino";
            this.grboxInquilino.Size = new System.Drawing.Size(555, 306);
            this.grboxInquilino.TabIndex = 0;
            this.grboxInquilino.TabStop = false;
            this.grboxInquilino.Text = "Seleccione Inquilino";
            // 
            // dgvInquilinos
            // 
            this.dgvInquilinos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInquilinos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.nombre,
            this.apellido,
            this.dni,
            this.usuario,
            this.direccion,
            this.telefono});
            this.dgvInquilinos.Location = new System.Drawing.Point(6, 61);
            this.dgvInquilinos.MultiSelect = false;
            this.dgvInquilinos.Name = "dgvInquilinos";
            this.dgvInquilinos.ReadOnly = true;
            this.dgvInquilinos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInquilinos.Size = new System.Drawing.Size(525, 195);
            this.dgvInquilinos.TabIndex = 4;
            // 
            // btnSeleccionarInquilino
            // 
            this.btnSeleccionarInquilino.Location = new System.Drawing.Point(183, 262);
            this.btnSeleccionarInquilino.Name = "btnSeleccionarInquilino";
            this.btnSeleccionarInquilino.Size = new System.Drawing.Size(152, 23);
            this.btnSeleccionarInquilino.TabIndex = 3;
            this.btnSeleccionarInquilino.Text = "Seleccionar Inquilino";
            this.btnSeleccionarInquilino.UseVisualStyleBackColor = true;
            this.btnSeleccionarInquilino.Click += new System.EventHandler(this.btnSeleccionarInquilino_Click);
            // 
            // lblFiltroDni
            // 
            this.lblFiltroDni.AutoSize = true;
            this.lblFiltroDni.Location = new System.Drawing.Point(19, 31);
            this.lblFiltroDni.Name = "lblFiltroDni";
            this.lblFiltroDni.Size = new System.Drawing.Size(75, 13);
            this.lblFiltroDni.TabIndex = 2;
            this.lblFiltroDni.Text = "Filtrar por DNI:";
            // 
            // txtboxFiltroDni
            // 
            this.txtboxFiltroDni.Location = new System.Drawing.Point(100, 31);
            this.txtboxFiltroDni.Name = "txtboxFiltroDni";
            this.txtboxFiltroDni.Size = new System.Drawing.Size(443, 20);
            this.txtboxFiltroDni.TabIndex = 1;
            this.txtboxFiltroDni.TextChanged += new System.EventHandler(this.txtboxFiltroDni_TextChanged);
            // 
            // grpboxUnidad
            // 
            this.grpboxUnidad.Controls.Add(this.txtboxNroInquilino);
            this.grpboxUnidad.Controls.Add(this.lblNroInquilino);
            this.grpboxUnidad.Controls.Add(this.txtboxNombreInquilino);
            this.grpboxUnidad.Controls.Add(this.lblNombreInquilino);
            this.grpboxUnidad.Controls.Add(this.btnSeleccionarUnidad);
            this.grpboxUnidad.Controls.Add(this.lblFiltrarDomicilio);
            this.grpboxUnidad.Controls.Add(this.txtboxFiltroDescripcion);
            this.grpboxUnidad.Controls.Add(this.dgvUnidades);
            this.grpboxUnidad.Location = new System.Drawing.Point(605, 12);
            this.grpboxUnidad.Name = "grpboxUnidad";
            this.grpboxUnidad.Size = new System.Drawing.Size(305, 306);
            this.grpboxUnidad.TabIndex = 4;
            this.grpboxUnidad.TabStop = false;
            this.grpboxUnidad.Text = "Seleccione Unidad";
            // 
            // txtboxNombreInquilino
            // 
            this.txtboxNombreInquilino.Location = new System.Drawing.Point(116, 39);
            this.txtboxNombreInquilino.Name = "txtboxNombreInquilino";
            this.txtboxNombreInquilino.ReadOnly = true;
            this.txtboxNombreInquilino.Size = new System.Drawing.Size(176, 20);
            this.txtboxNombreInquilino.TabIndex = 5;
            // 
            // lblNombreInquilino
            // 
            this.lblNombreInquilino.AutoSize = true;
            this.lblNombreInquilino.Location = new System.Drawing.Point(6, 42);
            this.lblNombreInquilino.Name = "lblNombreInquilino";
            this.lblNombreInquilino.Size = new System.Drawing.Size(104, 13);
            this.lblNombreInquilino.TabIndex = 4;
            this.lblNombreInquilino.Text = "Nombre de Inquilino:";
            // 
            // btnSeleccionarUnidad
            // 
            this.btnSeleccionarUnidad.Location = new System.Drawing.Point(76, 277);
            this.btnSeleccionarUnidad.Name = "btnSeleccionarUnidad";
            this.btnSeleccionarUnidad.Size = new System.Drawing.Size(152, 23);
            this.btnSeleccionarUnidad.TabIndex = 3;
            this.btnSeleccionarUnidad.Text = "Seleccionar Unidad";
            this.btnSeleccionarUnidad.UseVisualStyleBackColor = true;
            this.btnSeleccionarUnidad.Click += new System.EventHandler(this.btnSeleccionarUnidad_Click);
            // 
            // dgvUnidades
            // 
            this.dgvUnidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoDeUnidad,
            this.numeroAlquiler,
            this.numeroInquilino,
            this.Domicilio,
            this.Descripcion,
            this.m2});
            this.dgvUnidades.Location = new System.Drawing.Point(22, 88);
            this.dgvUnidades.MultiSelect = false;
            this.dgvUnidades.Name = "dgvUnidades";
            this.dgvUnidades.ReadOnly = true;
            this.dgvUnidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUnidades.Size = new System.Drawing.Size(270, 183);
            this.dgvUnidades.TabIndex = 0;
            // 
            // CodigoDeUnidad
            // 
            this.CodigoDeUnidad.DataPropertyName = "coduni";
            this.CodigoDeUnidad.HeaderText = "Codigo de Unidad";
            this.CodigoDeUnidad.Name = "CodigoDeUnidad";
            this.CodigoDeUnidad.ReadOnly = true;
            this.CodigoDeUnidad.Visible = false;
            // 
            // numeroAlquiler
            // 
            this.numeroAlquiler.DataPropertyName = "numalq";
            this.numeroAlquiler.HeaderText = "Número de Alquiler";
            this.numeroAlquiler.Name = "numeroAlquiler";
            this.numeroAlquiler.ReadOnly = true;
            this.numeroAlquiler.Visible = false;
            // 
            // numeroInquilino
            // 
            this.numeroInquilino.DataPropertyName = "numinq";
            this.numeroInquilino.HeaderText = "Número de Inquilino";
            this.numeroInquilino.Name = "numeroInquilino";
            this.numeroInquilino.ReadOnly = true;
            this.numeroInquilino.Visible = false;
            // 
            // Domicilio
            // 
            this.Domicilio.DataPropertyName = "dom";
            this.Domicilio.HeaderText = "Domicilio";
            this.Domicilio.Name = "Domicilio";
            this.Domicilio.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "des";
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // m2
            // 
            this.m2.DataPropertyName = "mcuadrados";
            this.m2.HeaderText = "m2";
            this.m2.Name = "m2";
            this.m2.ReadOnly = true;
            // 
            // grpboxPago
            // 
            this.grpboxPago.Controls.Add(this.txtboxMontoaPagar);
            this.grpboxPago.Controls.Add(this.txtboxMontoMensual);
            this.grpboxPago.Controls.Add(this.lblMontoMensual);
            this.grpboxPago.Controls.Add(this.txtboxDescripcion);
            this.grpboxPago.Controls.Add(this.txtboxDireccion);
            this.grpboxPago.Controls.Add(this.lblDescripcion);
            this.grpboxPago.Controls.Add(this.lblDireccion);
            this.grpboxPago.Controls.Add(this.dtpFecha);
            this.grpboxPago.Controls.Add(this.btnRegistarPago);
            this.grpboxPago.Controls.Add(this.txtboxSaldoActual);
            this.grpboxPago.Controls.Add(this.lblSaldo);
            this.grpboxPago.Controls.Add(this.lblMonto);
            this.grpboxPago.Controls.Add(this.lblFecha);
            this.grpboxPago.Location = new System.Drawing.Point(12, 339);
            this.grpboxPago.Name = "grpboxPago";
            this.grpboxPago.Size = new System.Drawing.Size(754, 141);
            this.grpboxPago.TabIndex = 4;
            this.grpboxPago.TabStop = false;
            this.grpboxPago.Text = "Ingrese Pago";
            // 
            // txtboxMontoMensual
            // 
            this.txtboxMontoMensual.Location = new System.Drawing.Point(434, 88);
            this.txtboxMontoMensual.Name = "txtboxMontoMensual";
            this.txtboxMontoMensual.ReadOnly = true;
            this.txtboxMontoMensual.Size = new System.Drawing.Size(200, 20);
            this.txtboxMontoMensual.TabIndex = 14;
            // 
            // lblMontoMensual
            // 
            this.lblMontoMensual.AutoSize = true;
            this.lblMontoMensual.Location = new System.Drawing.Point(353, 91);
            this.lblMontoMensual.Name = "lblMontoMensual";
            this.lblMontoMensual.Size = new System.Drawing.Size(82, 13);
            this.lblMontoMensual.TabIndex = 13;
            this.lblMontoMensual.Text = "Monto mensual:";
            // 
            // txtboxDescripcion
            // 
            this.txtboxDescripcion.Location = new System.Drawing.Point(67, 62);
            this.txtboxDescripcion.Multiline = true;
            this.txtboxDescripcion.Name = "txtboxDescripcion";
            this.txtboxDescripcion.ReadOnly = true;
            this.txtboxDescripcion.Size = new System.Drawing.Size(280, 73);
            this.txtboxDescripcion.TabIndex = 12;
            // 
            // txtboxDireccion
            // 
            this.txtboxDireccion.Location = new System.Drawing.Point(67, 32);
            this.txtboxDireccion.Name = "txtboxDireccion";
            this.txtboxDireccion.ReadOnly = true;
            this.txtboxDireccion.Size = new System.Drawing.Size(280, 20);
            this.txtboxDireccion.TabIndex = 11;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(3, 67);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 10;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(6, 35);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(55, 13);
            this.lblDireccion.TabIndex = 9;
            this.lblDireccion.Text = "Dirección:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(434, 62);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 8;
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
            // 
            // btnRegistarPago
            // 
            this.btnRegistarPago.Location = new System.Drawing.Point(650, 41);
            this.btnRegistarPago.Name = "btnRegistarPago";
            this.btnRegistarPago.Size = new System.Drawing.Size(98, 39);
            this.btnRegistarPago.TabIndex = 6;
            this.btnRegistarPago.Text = "Registar Pago";
            this.btnRegistarPago.UseVisualStyleBackColor = true;
            this.btnRegistarPago.Click += new System.EventHandler(this.btnRegistarPago_Click);
            // 
            // txtboxSaldoActual
            // 
            this.txtboxSaldoActual.Location = new System.Drawing.Point(434, 36);
            this.txtboxSaldoActual.Name = "txtboxSaldoActual";
            this.txtboxSaldoActual.ReadOnly = true;
            this.txtboxSaldoActual.Size = new System.Drawing.Size(200, 20);
            this.txtboxSaldoActual.TabIndex = 3;
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(353, 39);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(69, 13);
            this.lblSaldo.TabIndex = 2;
            this.lblSaldo.Text = "Saldo actual:";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(353, 115);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(79, 13);
            this.lblMonto.TabIndex = 1;
            this.lblMonto.Text = "Monto a pagar:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(353, 68);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(43, 13);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "Fecha :";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(782, 392);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(128, 42);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // lblFiltrarDomicilio
            // 
            this.lblFiltrarDomicilio.AutoSize = true;
            this.lblFiltrarDomicilio.Location = new System.Drawing.Point(6, 68);
            this.lblFiltrarDomicilio.Name = "lblFiltrarDomicilio";
            this.lblFiltrarDomicilio.Size = new System.Drawing.Size(98, 13);
            this.lblFiltrarDomicilio.TabIndex = 2;
            this.lblFiltrarDomicilio.Text = "Filtrar por Domicilio:";
            // 
            // txtboxFiltroDescripcion
            // 
            this.txtboxFiltroDescripcion.Location = new System.Drawing.Point(116, 65);
            this.txtboxFiltroDescripcion.Name = "txtboxFiltroDescripcion";
            this.txtboxFiltroDescripcion.Size = new System.Drawing.Size(176, 20);
            this.txtboxFiltroDescripcion.TabIndex = 1;
            this.txtboxFiltroDescripcion.TextChanged += new System.EventHandler(this.txtboxFiltroDescripcion_TextChanged);
            // 
            // lblNroInquilino
            // 
            this.lblNroInquilino.AutoSize = true;
            this.lblNroInquilino.Location = new System.Drawing.Point(6, 16);
            this.lblNroInquilino.Name = "lblNroInquilino";
            this.lblNroInquilino.Size = new System.Drawing.Size(104, 13);
            this.lblNroInquilino.TabIndex = 6;
            this.lblNroInquilino.Text = "Número de Inquilino:";
            // 
            // txtboxNroInquilino
            // 
            this.txtboxNroInquilino.Location = new System.Drawing.Point(116, 13);
            this.txtboxNroInquilino.Name = "txtboxNroInquilino";
            this.txtboxNroInquilino.ReadOnly = true;
            this.txtboxNroInquilino.Size = new System.Drawing.Size(176, 20);
            this.txtboxNroInquilino.TabIndex = 7;
            // 
            // Código
            // 
            this.Código.DataPropertyName = "nro_inquilino";
            this.Código.HeaderText = "Código";
            this.Código.Name = "Código";
            this.Código.ReadOnly = true;
            this.Código.Visible = false;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // apellido
            // 
            this.apellido.DataPropertyName = "apellido";
            this.apellido.HeaderText = "Apellido";
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            // 
            // dni
            // 
            this.dni.DataPropertyName = "dni";
            this.dni.HeaderText = "DNI";
            this.dni.Name = "dni";
            this.dni.ReadOnly = true;
            // 
            // usuario
            // 
            this.usuario.DataPropertyName = "usuario";
            this.usuario.HeaderText = "Usuario";
            this.usuario.Name = "usuario";
            this.usuario.ReadOnly = true;
            // 
            // direccion
            // 
            this.direccion.DataPropertyName = "dom";
            this.direccion.HeaderText = "Direccion";
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            // 
            // telefono
            // 
            this.telefono.DataPropertyName = "telefono";
            this.telefono.HeaderText = "Telefono";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            // 
            // txtboxMontoaPagar
            // 
            this.txtboxMontoaPagar.Location = new System.Drawing.Point(431, 112);
            this.txtboxMontoaPagar.Mask = "99999";
            this.txtboxMontoaPagar.Name = "txtboxMontoaPagar";
            this.txtboxMontoaPagar.Size = new System.Drawing.Size(203, 20);
            this.txtboxMontoaPagar.TabIndex = 6;
            this.txtboxMontoaPagar.ValidatingType = typeof(int);
            // 
            // frmRegistrarPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 492);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.grpboxPago);
            this.Controls.Add(this.grpboxUnidad);
            this.Controls.Add(this.grboxInquilino);
            this.Name = "frmRegistrarPago";
            this.Text = "frmRegistrarPago";
            this.grboxInquilino.ResumeLayout(false);
            this.grboxInquilino.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInquilinos)).EndInit();
            this.grpboxUnidad.ResumeLayout(false);
            this.grpboxUnidad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnidades)).EndInit();
            this.grpboxPago.ResumeLayout(false);
            this.grpboxPago.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grboxInquilino;
        private System.Windows.Forms.Button btnSeleccionarInquilino;
        private System.Windows.Forms.Label lblFiltroDni;
        private System.Windows.Forms.TextBox txtboxFiltroDni;
        private System.Windows.Forms.GroupBox grpboxUnidad;
        private System.Windows.Forms.Button btnSeleccionarUnidad;
        private System.Windows.Forms.DataGridView dgvUnidades;
        private System.Windows.Forms.GroupBox grpboxPago;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.TextBox txtboxSaldoActual;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button btnRegistarPago;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgvInquilinos;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtboxDescripcion;
        private System.Windows.Forms.TextBox txtboxDireccion;
        private System.Windows.Forms.TextBox txtboxNombreInquilino;
        private System.Windows.Forms.Label lblNombreInquilino;
        private System.Windows.Forms.TextBox txtboxMontoMensual;
        private System.Windows.Forms.Label lblMontoMensual;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoDeUnidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroAlquiler;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroInquilino;
        private System.Windows.Forms.DataGridViewTextBoxColumn Domicilio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn m2;
        private System.Windows.Forms.TextBox txtboxNroInquilino;
        private System.Windows.Forms.Label lblNroInquilino;
        private System.Windows.Forms.Label lblFiltrarDomicilio;
        private System.Windows.Forms.TextBox txtboxFiltroDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.MaskedTextBox txtboxMontoaPagar;

    }
}