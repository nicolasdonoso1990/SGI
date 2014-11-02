namespace GUI
{
    partial class frmAltaAlquiler
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
            this.grpPropiedades = new System.Windows.Forms.GroupBox();
            this.btnPropiedad = new System.Windows.Forms.Button();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.dataPropiedad = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpUnidades = new System.Windows.Forms.GroupBox();
            this.btnUnidades = new System.Windows.Forms.Button();
            this.dataUnidad = new System.Windows.Forms.DataGridView();
            this.codigoUnidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descrip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.met = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpInquilino = new System.Windows.Forms.GroupBox();
            this.btnInquilino = new System.Windows.Forms.Button();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataInquilino = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.fecha1 = new System.Windows.Forms.DateTimePicker();
            this.fecha2 = new System.Windows.Forms.DateTimePicker();
            this.btnFecha = new System.Windows.Forms.Button();
            this.grpAlquiler = new System.Windows.Forms.GroupBox();
            this.grpPropiedades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPropiedad)).BeginInit();
            this.grpUnidades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataUnidad)).BeginInit();
            this.grpInquilino.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataInquilino)).BeginInit();
            this.grpAlquiler.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPropiedades
            // 
            this.grpPropiedades.BackColor = System.Drawing.Color.Transparent;
            this.grpPropiedades.Controls.Add(this.btnPropiedad);
            this.grpPropiedades.Controls.Add(this.txtDireccion);
            this.grpPropiedades.Controls.Add(this.lblDireccion);
            this.grpPropiedades.Controls.Add(this.dataPropiedad);
            this.grpPropiedades.Enabled = false;
            this.grpPropiedades.Location = new System.Drawing.Point(444, 12);
            this.grpPropiedades.Name = "grpPropiedades";
            this.grpPropiedades.Size = new System.Drawing.Size(584, 308);
            this.grpPropiedades.TabIndex = 6;
            this.grpPropiedades.TabStop = false;
            this.grpPropiedades.Text = "Propiedades";
            // 
            // btnPropiedad
            // 
            this.btnPropiedad.Location = new System.Drawing.Point(241, 257);
            this.btnPropiedad.Name = "btnPropiedad";
            this.btnPropiedad.Size = new System.Drawing.Size(88, 29);
            this.btnPropiedad.TabIndex = 8;
            this.btnPropiedad.Text = "Seleccionar";
            this.btnPropiedad.UseVisualStyleBackColor = true;
            this.btnPropiedad.Click += new System.EventHandler(this.btnPropiedad_Click);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(87, 30);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(222, 20);
            this.txtDireccion.TabIndex = 7;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(26, 33);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(55, 13);
            this.lblDireccion.TabIndex = 6;
            this.lblDireccion.Text = "Direccion:";
            // 
            // dataPropiedad
            // 
            this.dataPropiedad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPropiedad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.ciudad,
            this.direccion,
            this.metros,
            this.descripcion});
            this.dataPropiedad.Location = new System.Drawing.Point(19, 73);
            this.dataPropiedad.Name = "dataPropiedad";
            this.dataPropiedad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataPropiedad.Size = new System.Drawing.Size(546, 152);
            this.dataPropiedad.TabIndex = 1;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "cod_propiedad";
            this.Codigo.HeaderText = "Codigo Propiedad";
            this.Codigo.Name = "Codigo";
            // 
            // ciudad
            // 
            this.ciudad.DataPropertyName = "ciudad";
            this.ciudad.HeaderText = "Ciudad";
            this.ciudad.Name = "ciudad";
            this.ciudad.ReadOnly = true;
            // 
            // direccion
            // 
            this.direccion.DataPropertyName = "direccion";
            this.direccion.HeaderText = "Direccion";
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            // 
            // metros
            // 
            this.metros.DataPropertyName = "m2";
            this.metros.HeaderText = "Metros Cuadrados";
            this.metros.Name = "metros";
            this.metros.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.DataPropertyName = "descripcion";
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // grpUnidades
            // 
            this.grpUnidades.BackColor = System.Drawing.Color.Transparent;
            this.grpUnidades.Controls.Add(this.btnUnidades);
            this.grpUnidades.Controls.Add(this.dataUnidad);
            this.grpUnidades.Enabled = false;
            this.grpUnidades.Location = new System.Drawing.Point(3, 344);
            this.grpUnidades.Name = "grpUnidades";
            this.grpUnidades.Size = new System.Drawing.Size(581, 299);
            this.grpUnidades.TabIndex = 7;
            this.grpUnidades.TabStop = false;
            this.grpUnidades.Text = "Unidades";
            // 
            // btnUnidades
            // 
            this.btnUnidades.Location = new System.Drawing.Point(261, 248);
            this.btnUnidades.Name = "btnUnidades";
            this.btnUnidades.Size = new System.Drawing.Size(88, 29);
            this.btnUnidades.TabIndex = 9;
            this.btnUnidades.Text = "Seleccionar";
            this.btnUnidades.UseVisualStyleBackColor = true;
            this.btnUnidades.Click += new System.EventHandler(this.btnUnidades_Click);
            // 
            // dataUnidad
            // 
            this.dataUnidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataUnidad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoUnidad,
            this.descrip,
            this.met});
            this.dataUnidad.Location = new System.Drawing.Point(18, 33);
            this.dataUnidad.Name = "dataUnidad";
            this.dataUnidad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataUnidad.Size = new System.Drawing.Size(543, 194);
            this.dataUnidad.TabIndex = 0;
            // 
            // codigoUnidad
            // 
            this.codigoUnidad.DataPropertyName = "cod_unidad";
            this.codigoUnidad.HeaderText = "Codigo Unidad";
            this.codigoUnidad.Name = "codigoUnidad";
            // 
            // descrip
            // 
            this.descrip.DataPropertyName = "descripcion";
            this.descrip.HeaderText = "Descripcion unidad";
            this.descrip.Name = "descrip";
            this.descrip.Width = 300;
            // 
            // met
            // 
            this.met.DataPropertyName = "m2";
            this.met.HeaderText = "Metros Cuadrados";
            this.met.Name = "met";
            // 
            // grpInquilino
            // 
            this.grpInquilino.BackColor = System.Drawing.Color.Transparent;
            this.grpInquilino.Controls.Add(this.btnInquilino);
            this.grpInquilino.Controls.Add(this.txtBusca);
            this.grpInquilino.Controls.Add(this.label1);
            this.grpInquilino.Controls.Add(this.dataInquilino);
            this.grpInquilino.Enabled = false;
            this.grpInquilino.Location = new System.Drawing.Point(653, 344);
            this.grpInquilino.Name = "grpInquilino";
            this.grpInquilino.Size = new System.Drawing.Size(584, 331);
            this.grpInquilino.TabIndex = 8;
            this.grpInquilino.TabStop = false;
            this.grpInquilino.Text = "Seleccione Inquilino";
            // 
            // btnInquilino
            // 
            this.btnInquilino.Location = new System.Drawing.Point(257, 296);
            this.btnInquilino.Name = "btnInquilino";
            this.btnInquilino.Size = new System.Drawing.Size(88, 29);
            this.btnInquilino.TabIndex = 9;
            this.btnInquilino.Text = "Seleccionar";
            this.btnInquilino.UseVisualStyleBackColor = true;
            this.btnInquilino.Click += new System.EventHandler(this.btnInquilino_Click);
            // 
            // txtBusca
            // 
            this.txtBusca.Location = new System.Drawing.Point(105, 29);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(100, 20);
            this.txtBusca.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingrese DNI:";
            // 
            // dataInquilino
            // 
            this.dataInquilino.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataInquilino.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.apellido,
            this.dni,
            this.dataGridViewTextBoxColumn1,
            this.telefono});
            this.dataInquilino.Location = new System.Drawing.Point(13, 80);
            this.dataInquilino.MultiSelect = false;
            this.dataInquilino.Name = "dataInquilino";
            this.dataInquilino.ReadOnly = true;
            this.dataInquilino.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataInquilino.Size = new System.Drawing.Size(552, 195);
            this.dataInquilino.TabIndex = 1;
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
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "direccion";
            this.dataGridViewTextBoxColumn1.HeaderText = "Direccion";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // telefono
            // 
            this.telefono.DataPropertyName = "telefono";
            this.telefono.HeaderText = "Telefono";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(552, 698);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(88, 29);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Location = new System.Drawing.Point(13, 33);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(67, 13);
            this.lblFechaInicio.TabIndex = 7;
            this.lblFechaInicio.Text = "Fecha inicio:";
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Location = new System.Drawing.Point(26, 72);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(54, 13);
            this.lblFechaFin.TabIndex = 8;
            this.lblFechaFin.Text = "Fecha fin:";
            // 
            // fecha1
            // 
            this.fecha1.Location = new System.Drawing.Point(86, 30);
            this.fecha1.Name = "fecha1";
            this.fecha1.Size = new System.Drawing.Size(200, 20);
            this.fecha1.TabIndex = 9;
            // 
            // fecha2
            // 
            this.fecha2.Location = new System.Drawing.Point(86, 65);
            this.fecha2.Name = "fecha2";
            this.fecha2.Size = new System.Drawing.Size(200, 20);
            this.fecha2.TabIndex = 10;
            // 
            // btnFecha
            // 
            this.btnFecha.Location = new System.Drawing.Point(138, 119);
            this.btnFecha.Name = "btnFecha";
            this.btnFecha.Size = new System.Drawing.Size(88, 29);
            this.btnFecha.TabIndex = 9;
            this.btnFecha.Text = "Seleccionar";
            this.btnFecha.UseVisualStyleBackColor = true;
            this.btnFecha.Click += new System.EventHandler(this.btnFecha_Click);
            // 
            // grpAlquiler
            // 
            this.grpAlquiler.BackColor = System.Drawing.Color.Transparent;
            this.grpAlquiler.Controls.Add(this.btnFecha);
            this.grpAlquiler.Controls.Add(this.fecha2);
            this.grpAlquiler.Controls.Add(this.fecha1);
            this.grpAlquiler.Controls.Add(this.lblFechaFin);
            this.grpAlquiler.Controls.Add(this.lblFechaInicio);
            this.grpAlquiler.Location = new System.Drawing.Point(21, 12);
            this.grpAlquiler.Name = "grpAlquiler";
            this.grpAlquiler.Size = new System.Drawing.Size(357, 177);
            this.grpAlquiler.TabIndex = 9;
            this.grpAlquiler.TabStop = false;
            this.grpAlquiler.Text = "Datos fecha Alquiler";
            // 
            // frmAltaAlquiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(1322, 750);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.grpAlquiler);
            this.Controls.Add(this.grpInquilino);
            this.Controls.Add(this.grpUnidades);
            this.Controls.Add(this.grpPropiedades);
            this.Name = "frmAltaAlquiler";
            this.Text = "Alta Alquiler";
            this.grpPropiedades.ResumeLayout(false);
            this.grpPropiedades.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPropiedad)).EndInit();
            this.grpUnidades.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataUnidad)).EndInit();
            this.grpInquilino.ResumeLayout(false);
            this.grpInquilino.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataInquilino)).EndInit();
            this.grpAlquiler.ResumeLayout(false);
            this.grpAlquiler.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPropiedades;
        private System.Windows.Forms.Button btnPropiedad;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.DataGridView dataPropiedad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn metros;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.GroupBox grpUnidades;
        private System.Windows.Forms.Button btnUnidades;
        private System.Windows.Forms.DataGridView dataUnidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoUnidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn descrip;
        private System.Windows.Forms.DataGridViewTextBoxColumn met;
        private System.Windows.Forms.GroupBox grpInquilino;
        private System.Windows.Forms.Button btnInquilino;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataInquilino;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.DateTimePicker fecha1;
        private System.Windows.Forms.DateTimePicker fecha2;
        private System.Windows.Forms.Button btnFecha;
        private System.Windows.Forms.GroupBox grpAlquiler;
    }
}