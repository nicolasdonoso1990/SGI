﻿namespace GUI
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
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSeleccionarInquilino = new System.Windows.Forms.Button();
            this.lblFiltroDni = new System.Windows.Forms.Label();
            this.txtboxFiltroDni = new System.Windows.Forms.TextBox();
            this.grpboxUnidad = new System.Windows.Forms.GroupBox();
            this.txtboxNroInquilino = new System.Windows.Forms.TextBox();
            this.lblNombreInquilino = new System.Windows.Forms.Label();
            this.btnSeleccionarUnidad = new System.Windows.Forms.Button();
            this.lblFiltrarDescripcion = new System.Windows.Forms.Label();
            this.txtboxFiltroDescripcion = new System.Windows.Forms.TextBox();
            this.dgvUnidades = new System.Windows.Forms.DataGridView();
            this.grpboxPago = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnRegistarPago = new System.Windows.Forms.Button();
            this.txtboxMonto = new System.Windows.Forms.TextBox();
            this.txtboxSaldoActual = new System.Windows.Forms.TextBox();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Domicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.direccion.DataPropertyName = "direccion";
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
            // 
            // grpboxUnidad
            // 
            this.grpboxUnidad.Controls.Add(this.txtboxNroInquilino);
            this.grpboxUnidad.Controls.Add(this.lblNombreInquilino);
            this.grpboxUnidad.Controls.Add(this.btnSeleccionarUnidad);
            this.grpboxUnidad.Controls.Add(this.lblFiltrarDescripcion);
            this.grpboxUnidad.Controls.Add(this.txtboxFiltroDescripcion);
            this.grpboxUnidad.Controls.Add(this.dgvUnidades);
            this.grpboxUnidad.Location = new System.Drawing.Point(605, 12);
            this.grpboxUnidad.Name = "grpboxUnidad";
            this.grpboxUnidad.Size = new System.Drawing.Size(305, 306);
            this.grpboxUnidad.TabIndex = 4;
            this.grpboxUnidad.TabStop = false;
            this.grpboxUnidad.Text = "Seleccione Unidad";
            // 
            // txtboxNroInquilino
            // 
            this.txtboxNroInquilino.Location = new System.Drawing.Point(112, 31);
            this.txtboxNroInquilino.Name = "txtboxNroInquilino";
            this.txtboxNroInquilino.Size = new System.Drawing.Size(176, 20);
            this.txtboxNroInquilino.TabIndex = 5;
            // 
            // lblNombreInquilino
            // 
            this.lblNombreInquilino.AutoSize = true;
            this.lblNombreInquilino.Location = new System.Drawing.Point(6, 34);
            this.lblNombreInquilino.Name = "lblNombreInquilino";
            this.lblNombreInquilino.Size = new System.Drawing.Size(49, 13);
            this.lblNombreInquilino.TabIndex = 4;
            this.lblNombreInquilino.Text = "Inquilino:";
            // 
            // btnSeleccionarUnidad
            // 
            this.btnSeleccionarUnidad.Location = new System.Drawing.Point(76, 277);
            this.btnSeleccionarUnidad.Name = "btnSeleccionarUnidad";
            this.btnSeleccionarUnidad.Size = new System.Drawing.Size(152, 23);
            this.btnSeleccionarUnidad.TabIndex = 3;
            this.btnSeleccionarUnidad.Text = "Seleccionar Unidad";
            this.btnSeleccionarUnidad.UseVisualStyleBackColor = true;
            // 
            // lblFiltrarDescripcion
            // 
            this.lblFiltrarDescripcion.AutoSize = true;
            this.lblFiltrarDescripcion.Location = new System.Drawing.Point(6, 68);
            this.lblFiltrarDescripcion.Name = "lblFiltrarDescripcion";
            this.lblFiltrarDescripcion.Size = new System.Drawing.Size(112, 13);
            this.lblFiltrarDescripcion.TabIndex = 2;
            this.lblFiltrarDescripcion.Text = "Filtrar por Descripción:";
            // 
            // txtboxFiltroDescripcion
            // 
            this.txtboxFiltroDescripcion.Location = new System.Drawing.Point(116, 65);
            this.txtboxFiltroDescripcion.Name = "txtboxFiltroDescripcion";
            this.txtboxFiltroDescripcion.Size = new System.Drawing.Size(176, 20);
            this.txtboxFiltroDescripcion.TabIndex = 1;
            // 
            // dgvUnidades
            // 
            this.dgvUnidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Domicilio,
            this.Descripcion,
            this.m2});
            this.dgvUnidades.Location = new System.Drawing.Point(22, 88);
            this.dgvUnidades.Name = "dgvUnidades";
            this.dgvUnidades.Size = new System.Drawing.Size(270, 183);
            this.dgvUnidades.TabIndex = 0;
            // 
            // grpboxPago
            // 
            this.grpboxPago.Controls.Add(this.textBox2);
            this.grpboxPago.Controls.Add(this.textBox1);
            this.grpboxPago.Controls.Add(this.lblDescripcion);
            this.grpboxPago.Controls.Add(this.lblDireccion);
            this.grpboxPago.Controls.Add(this.dtpFecha);
            this.grpboxPago.Controls.Add(this.btnRegistarPago);
            this.grpboxPago.Controls.Add(this.txtboxMonto);
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(67, 62);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(280, 73);
            this.textBox2.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(67, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(280, 20);
            this.textBox1.TabIndex = 11;
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
            // 
            // btnRegistarPago
            // 
            this.btnRegistarPago.Location = new System.Drawing.Point(650, 41);
            this.btnRegistarPago.Name = "btnRegistarPago";
            this.btnRegistarPago.Size = new System.Drawing.Size(98, 39);
            this.btnRegistarPago.TabIndex = 6;
            this.btnRegistarPago.Text = "Registar Pago";
            this.btnRegistarPago.UseVisualStyleBackColor = true;
            // 
            // txtboxMonto
            // 
            this.txtboxMonto.Location = new System.Drawing.Point(434, 86);
            this.txtboxMonto.Name = "txtboxMonto";
            this.txtboxMonto.Size = new System.Drawing.Size(200, 20);
            this.txtboxMonto.TabIndex = 5;
            // 
            // txtboxSaldoActual
            // 
            this.txtboxSaldoActual.Location = new System.Drawing.Point(434, 36);
            this.txtboxSaldoActual.Name = "txtboxSaldoActual";
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
            this.lblMonto.Location = new System.Drawing.Point(353, 89);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(40, 13);
            this.lblMonto.TabIndex = 1;
            this.lblMonto.Text = "Monto:";
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
            // Codigo
            // 
            this.Codigo.DataPropertyName = "cod";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Visible = false;
            // 
            // Domicilio
            // 
            this.Domicilio.DataPropertyName = "dom";
            this.Domicilio.HeaderText = "Domicilio";
            this.Domicilio.Name = "Domicilio";
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "des";
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            // 
            // m2
            // 
            this.m2.DataPropertyName = "mcuadrados";
            this.m2.HeaderText = "m2";
            this.m2.Name = "m2";
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
        private System.Windows.Forms.Label lblFiltrarDescripcion;
        private System.Windows.Forms.TextBox txtboxFiltroDescripcion;
        private System.Windows.Forms.DataGridView dgvUnidades;
        private System.Windows.Forms.GroupBox grpboxPago;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.TextBox txtboxMonto;
        private System.Windows.Forms.TextBox txtboxSaldoActual;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button btnRegistarPago;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgvInquilinos;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtboxNroInquilino;
        private System.Windows.Forms.Label lblNombreInquilino;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Domicilio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn m2;

    }
}