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
            this.btnPropiedad = new System.Windows.Forms.Button();
            this.txtDireccionPropiedad = new System.Windows.Forms.TextBox();
            this.lblDireccionPropiedad = new System.Windows.Forms.Label();
            this.dataPropiedad = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUnidad = new System.Windows.Forms.Button();
            this.dataUnidad = new System.Windows.Forms.DataGridView();
            this.codigoUnidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descrip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.met = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtboxFiltroDni = new System.Windows.Forms.TextBox();
            this.lblDNI = new System.Windows.Forms.Label();
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
            this.txtDescripcionUnidad = new System.Windows.Forms.TextBox();
            this.lblDireccionUnidad = new System.Windows.Forms.Label();
            this.btnAlquiler = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataPropiedad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataUnidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataInquilino)).BeginInit();
            this.grpAlquiler.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPropiedad
            // 
            this.btnPropiedad.Location = new System.Drawing.Point(217, 307);
            this.btnPropiedad.Name = "btnPropiedad";
            this.btnPropiedad.Size = new System.Drawing.Size(88, 29);
            this.btnPropiedad.TabIndex = 8;
            this.btnPropiedad.Text = "Seleccionar";
            this.btnPropiedad.UseVisualStyleBackColor = true;
            this.btnPropiedad.Visible = false;
            this.btnPropiedad.Click += new System.EventHandler(this.btnPropiedad_Click);
            // 
            // txtDireccionPropiedad
            // 
            this.txtDireccionPropiedad.Location = new System.Drawing.Point(87, 98);
            this.txtDireccionPropiedad.Name = "txtDireccionPropiedad";
            this.txtDireccionPropiedad.Size = new System.Drawing.Size(222, 20);
            this.txtDireccionPropiedad.TabIndex = 7;
            this.txtDireccionPropiedad.Visible = false;
            this.txtDireccionPropiedad.TextChanged += new System.EventHandler(this.txtDireccionPropiedad_TextChanged);
            // 
            // lblDireccionPropiedad
            // 
            this.lblDireccionPropiedad.AutoSize = true;
            this.lblDireccionPropiedad.Location = new System.Drawing.Point(21, 100);
            this.lblDireccionPropiedad.Name = "lblDireccionPropiedad";
            this.lblDireccionPropiedad.Size = new System.Drawing.Size(55, 13);
            this.lblDireccionPropiedad.TabIndex = 6;
            this.lblDireccionPropiedad.Text = "Direccion:";
            this.lblDireccionPropiedad.Visible = false;
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
            this.dataPropiedad.Location = new System.Drawing.Point(14, 134);
            this.dataPropiedad.Name = "dataPropiedad";
            this.dataPropiedad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataPropiedad.Size = new System.Drawing.Size(546, 152);
            this.dataPropiedad.TabIndex = 1;
            this.dataPropiedad.Visible = false;
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
            // btnUnidad
            // 
            this.btnUnidad.Location = new System.Drawing.Point(904, 307);
            this.btnUnidad.Name = "btnUnidad";
            this.btnUnidad.Size = new System.Drawing.Size(88, 29);
            this.btnUnidad.TabIndex = 9;
            this.btnUnidad.Text = "Seleccionar";
            this.btnUnidad.UseVisualStyleBackColor = true;
            this.btnUnidad.Visible = false;
            this.btnUnidad.Click += new System.EventHandler(this.btnUnidades_Click);
            // 
            // dataUnidad
            // 
            this.dataUnidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataUnidad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoUnidad,
            this.descrip,
            this.met});
            this.dataUnidad.Location = new System.Drawing.Point(679, 134);
            this.dataUnidad.Name = "dataUnidad";
            this.dataUnidad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataUnidad.Size = new System.Drawing.Size(546, 152);
            this.dataUnidad.TabIndex = 0;
            this.dataUnidad.Visible = false;
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
            // txtboxFiltroDni
            // 
            this.txtboxFiltroDni.Location = new System.Drawing.Point(626, 370);
            this.txtboxFiltroDni.Name = "txtboxFiltroDni";
            this.txtboxFiltroDni.Size = new System.Drawing.Size(100, 20);
            this.txtboxFiltroDni.TabIndex = 4;
            this.txtboxFiltroDni.Visible = false;
            this.txtboxFiltroDni.TextChanged += new System.EventHandler(this.txtDNI_TextChanged);
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(543, 373);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(67, 13);
            this.lblDNI.TabIndex = 3;
            this.lblDNI.Text = "Ingrese DNI:";
            this.lblDNI.Visible = false;
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
            this.dataInquilino.Location = new System.Drawing.Point(359, 416);
            this.dataInquilino.MultiSelect = false;
            this.dataInquilino.Name = "dataInquilino";
            this.dataInquilino.ReadOnly = true;
            this.dataInquilino.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataInquilino.Size = new System.Drawing.Size(552, 195);
            this.dataInquilino.TabIndex = 1;
            this.dataInquilino.Visible = false;
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
            this.btnSalir.Location = new System.Drawing.Point(453, 627);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(88, 29);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Visible = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Location = new System.Drawing.Point(24, 25);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(67, 13);
            this.lblFechaInicio.TabIndex = 7;
            this.lblFechaInicio.Text = "Fecha inicio:";
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Location = new System.Drawing.Point(334, 25);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(54, 13);
            this.lblFechaFin.TabIndex = 8;
            this.lblFechaFin.Text = "Fecha fin:";
            // 
            // fecha1
            // 
            this.fecha1.Location = new System.Drawing.Point(98, 21);
            this.fecha1.Name = "fecha1";
            this.fecha1.Size = new System.Drawing.Size(200, 20);
            this.fecha1.TabIndex = 9;
            // 
            // fecha2
            // 
            this.fecha2.Location = new System.Drawing.Point(392, 21);
            this.fecha2.Name = "fecha2";
            this.fecha2.Size = new System.Drawing.Size(200, 20);
            this.fecha2.TabIndex = 10;
            // 
            // btnFecha
            // 
            this.btnFecha.Location = new System.Drawing.Point(638, 17);
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
            this.grpAlquiler.Controls.Add(this.txtDescripcionUnidad);
            this.grpAlquiler.Controls.Add(this.lblDireccionUnidad);
            this.grpAlquiler.Controls.Add(this.btnAlquiler);
            this.grpAlquiler.Controls.Add(this.btnSalir);
            this.grpAlquiler.Controls.Add(this.btnUnidad);
            this.grpAlquiler.Controls.Add(this.txtboxFiltroDni);
            this.grpAlquiler.Controls.Add(this.btnPropiedad);
            this.grpAlquiler.Controls.Add(this.lblDNI);
            this.grpAlquiler.Controls.Add(this.dataInquilino);
            this.grpAlquiler.Controls.Add(this.dataUnidad);
            this.grpAlquiler.Controls.Add(this.btnFecha);
            this.grpAlquiler.Controls.Add(this.txtDireccionPropiedad);
            this.grpAlquiler.Controls.Add(this.fecha2);
            this.grpAlquiler.Controls.Add(this.lblDireccionPropiedad);
            this.grpAlquiler.Controls.Add(this.dataPropiedad);
            this.grpAlquiler.Controls.Add(this.fecha1);
            this.grpAlquiler.Controls.Add(this.lblFechaFin);
            this.grpAlquiler.Controls.Add(this.lblFechaInicio);
            this.grpAlquiler.Location = new System.Drawing.Point(21, 12);
            this.grpAlquiler.Name = "grpAlquiler";
            this.grpAlquiler.Size = new System.Drawing.Size(1258, 718);
            this.grpAlquiler.TabIndex = 9;
            this.grpAlquiler.TabStop = false;
            this.grpAlquiler.Text = "Datos Alquiler";
            // 
            // txtDescripcionUnidad
            // 
            this.txtDescripcionUnidad.Location = new System.Drawing.Point(797, 97);
            this.txtDescripcionUnidad.Name = "txtDescripcionUnidad";
            this.txtDescripcionUnidad.Size = new System.Drawing.Size(222, 20);
            this.txtDescripcionUnidad.TabIndex = 13;
            this.txtDescripcionUnidad.Visible = false;
            this.txtDescripcionUnidad.TextChanged += new System.EventHandler(this.txtDescripcionUnidad_TextChanged);
            // 
            // lblDireccionUnidad
            // 
            this.lblDireccionUnidad.AutoSize = true;
            this.lblDireccionUnidad.Location = new System.Drawing.Point(688, 98);
            this.lblDireccionUnidad.Name = "lblDireccionUnidad";
            this.lblDireccionUnidad.Size = new System.Drawing.Size(103, 13);
            this.lblDireccionUnidad.TabIndex = 12;
            this.lblDireccionUnidad.Text = "Descripción Unidad:";
            this.lblDireccionUnidad.Visible = false;
            // 
            // btnAlquiler
            // 
            this.btnAlquiler.Location = new System.Drawing.Point(697, 627);
            this.btnAlquiler.Name = "btnAlquiler";
            this.btnAlquiler.Size = new System.Drawing.Size(88, 29);
            this.btnAlquiler.TabIndex = 11;
            this.btnAlquiler.Text = "Seleccionar";
            this.btnAlquiler.UseVisualStyleBackColor = true;
            this.btnAlquiler.Visible = false;
            this.btnAlquiler.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmAltaAlquiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(1322, 742);
            this.Controls.Add(this.grpAlquiler);
            this.Name = "frmAltaAlquiler";
            this.Text = "Alta Alquiler";
            ((System.ComponentModel.ISupportInitialize)(this.dataPropiedad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataUnidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataInquilino)).EndInit();
            this.grpAlquiler.ResumeLayout(false);
            this.grpAlquiler.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPropiedad;
        private System.Windows.Forms.TextBox txtDireccionPropiedad;
        private System.Windows.Forms.Label lblDireccionPropiedad;
        private System.Windows.Forms.DataGridView dataPropiedad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn metros;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.Button btnUnidad;
        private System.Windows.Forms.DataGridView dataUnidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoUnidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn descrip;
        private System.Windows.Forms.DataGridViewTextBoxColumn met;
        private System.Windows.Forms.TextBox txtboxFiltroDni;
        private System.Windows.Forms.Label lblDNI;
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
        private System.Windows.Forms.Button btnAlquiler;
        private System.Windows.Forms.TextBox txtDescripcionUnidad;
        private System.Windows.Forms.Label lblDireccionUnidad;
    }
}