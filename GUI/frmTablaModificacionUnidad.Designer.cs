namespace GUI
{
    partial class frmTablaModificacionUnidad
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
            this.groupDatosUni = new System.Windows.Forms.GroupBox();
            this.lblErrorCompletar = new System.Windows.Forms.Label();
            this.btnLimpiaCampos = new System.Windows.Forms.Button();
            this.lblCodUnidad = new System.Windows.Forms.Label();
            this.btnFoto4 = new System.Windows.Forms.Button();
            this.btnFoto3 = new System.Windows.Forms.Button();
            this.btnFoto2 = new System.Windows.Forms.Button();
            this.btnRegistra = new System.Windows.Forms.Button();
            this.foto4 = new System.Windows.Forms.PictureBox();
            this.foto3 = new System.Windows.Forms.PictureBox();
            this.foto2 = new System.Windows.Forms.PictureBox();
            this.foto1 = new System.Windows.Forms.PictureBox();
            this.btnFoto1 = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtMetro = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblMetro = new System.Windows.Forms.Label();
            this.groupUnidades = new System.Windows.Forms.GroupBox();
            this.btnBajaUni = new System.Windows.Forms.Button();
            this.btnModificarUni = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.codigoUnidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descrip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.met = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupPropiedades = new System.Windows.Forms.GroupBox();
            this.btnSeleccionarPropiedad = new System.Windows.Forms.Button();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupDatosUni.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foto4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foto3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foto2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foto1)).BeginInit();
            this.groupUnidades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupPropiedades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupDatosUni
            // 
            this.groupDatosUni.BackColor = System.Drawing.Color.Transparent;
            this.groupDatosUni.Controls.Add(this.lblErrorCompletar);
            this.groupDatosUni.Controls.Add(this.btnLimpiaCampos);
            this.groupDatosUni.Controls.Add(this.lblCodUnidad);
            this.groupDatosUni.Controls.Add(this.btnFoto4);
            this.groupDatosUni.Controls.Add(this.btnFoto3);
            this.groupDatosUni.Controls.Add(this.btnFoto2);
            this.groupDatosUni.Controls.Add(this.btnRegistra);
            this.groupDatosUni.Controls.Add(this.foto4);
            this.groupDatosUni.Controls.Add(this.foto3);
            this.groupDatosUni.Controls.Add(this.foto2);
            this.groupDatosUni.Controls.Add(this.foto1);
            this.groupDatosUni.Controls.Add(this.btnFoto1);
            this.groupDatosUni.Controls.Add(this.txtCodigo);
            this.groupDatosUni.Controls.Add(this.txtDescripcion);
            this.groupDatosUni.Controls.Add(this.txtMetro);
            this.groupDatosUni.Controls.Add(this.lblDescripcion);
            this.groupDatosUni.Controls.Add(this.lblMetro);
            this.groupDatosUni.Enabled = false;
            this.groupDatosUni.Location = new System.Drawing.Point(39, 361);
            this.groupDatosUni.Name = "groupDatosUni";
            this.groupDatosUni.Size = new System.Drawing.Size(1190, 313);
            this.groupDatosUni.TabIndex = 7;
            this.groupDatosUni.TabStop = false;
            this.groupDatosUni.Text = "Datos Unidad";
            // 
            // lblErrorCompletar
            // 
            this.lblErrorCompletar.AutoSize = true;
            this.lblErrorCompletar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorCompletar.ForeColor = System.Drawing.Color.Red;
            this.lblErrorCompletar.Location = new System.Drawing.Point(134, 266);
            this.lblErrorCompletar.Name = "lblErrorCompletar";
            this.lblErrorCompletar.Size = new System.Drawing.Size(220, 26);
            this.lblErrorCompletar.TabIndex = 27;
            this.lblErrorCompletar.Text = "Error. Olvido rellenar algunos campos,\r\n               por favor, completelos.";
            this.lblErrorCompletar.Visible = false;
            // 
            // btnLimpiaCampos
            // 
            this.btnLimpiaCampos.Image = global::GUI.Properties.Resources.limpiar;
            this.btnLimpiaCampos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiaCampos.Location = new System.Drawing.Point(25, 251);
            this.btnLimpiaCampos.Name = "btnLimpiaCampos";
            this.btnLimpiaCampos.Size = new System.Drawing.Size(87, 42);
            this.btnLimpiaCampos.TabIndex = 26;
            this.btnLimpiaCampos.Text = "Limpiar Campos";
            this.btnLimpiaCampos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiaCampos.UseVisualStyleBackColor = true;
            this.btnLimpiaCampos.Click += new System.EventHandler(this.btnLimpiaCampos_Click);
            // 
            // lblCodUnidad
            // 
            this.lblCodUnidad.AutoSize = true;
            this.lblCodUnidad.Location = new System.Drawing.Point(22, 35);
            this.lblCodUnidad.Name = "lblCodUnidad";
            this.lblCodUnidad.Size = new System.Drawing.Size(80, 13);
            this.lblCodUnidad.TabIndex = 25;
            this.lblCodUnidad.Text = "Codigo Unidad:";
            // 
            // btnFoto4
            // 
            this.btnFoto4.Location = new System.Drawing.Point(1027, 112);
            this.btnFoto4.Name = "btnFoto4";
            this.btnFoto4.Size = new System.Drawing.Size(64, 22);
            this.btnFoto4.TabIndex = 24;
            this.btnFoto4.Text = "Cargar";
            this.btnFoto4.UseVisualStyleBackColor = true;
            this.btnFoto4.Click += new System.EventHandler(this.btnFoto4_Click);
            // 
            // btnFoto3
            // 
            this.btnFoto3.Location = new System.Drawing.Point(846, 112);
            this.btnFoto3.Name = "btnFoto3";
            this.btnFoto3.Size = new System.Drawing.Size(60, 22);
            this.btnFoto3.TabIndex = 23;
            this.btnFoto3.Text = "Cargar";
            this.btnFoto3.UseVisualStyleBackColor = true;
            this.btnFoto3.Click += new System.EventHandler(this.btnFoto3_Click);
            // 
            // btnFoto2
            // 
            this.btnFoto2.Location = new System.Drawing.Point(668, 112);
            this.btnFoto2.Name = "btnFoto2";
            this.btnFoto2.Size = new System.Drawing.Size(59, 22);
            this.btnFoto2.TabIndex = 22;
            this.btnFoto2.Text = "Cargar";
            this.btnFoto2.UseVisualStyleBackColor = true;
            this.btnFoto2.Click += new System.EventHandler(this.btnFoto2_Click);
            // 
            // btnRegistra
            // 
            this.btnRegistra.Image = global::GUI.Properties.Resources.ok;
            this.btnRegistra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistra.Location = new System.Drawing.Point(440, 251);
            this.btnRegistra.Name = "btnRegistra";
            this.btnRegistra.Size = new System.Drawing.Size(87, 42);
            this.btnRegistra.TabIndex = 8;
            this.btnRegistra.Text = "Registrar";
            this.btnRegistra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistra.UseVisualStyleBackColor = true;
            this.btnRegistra.Click += new System.EventHandler(this.btnRegistra_Click);
            // 
            // foto4
            // 
            this.foto4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.foto4.Location = new System.Drawing.Point(984, 19);
            this.foto4.Name = "foto4";
            this.foto4.Size = new System.Drawing.Size(156, 87);
            this.foto4.TabIndex = 21;
            this.foto4.TabStop = false;
            // 
            // foto3
            // 
            this.foto3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.foto3.Location = new System.Drawing.Point(800, 19);
            this.foto3.Name = "foto3";
            this.foto3.Size = new System.Drawing.Size(156, 87);
            this.foto3.TabIndex = 20;
            this.foto3.TabStop = false;
            // 
            // foto2
            // 
            this.foto2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.foto2.Location = new System.Drawing.Point(628, 19);
            this.foto2.Name = "foto2";
            this.foto2.Size = new System.Drawing.Size(156, 87);
            this.foto2.TabIndex = 19;
            this.foto2.TabStop = false;
            // 
            // foto1
            // 
            this.foto1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.foto1.Location = new System.Drawing.Point(440, 19);
            this.foto1.Name = "foto1";
            this.foto1.Size = new System.Drawing.Size(156, 87);
            this.foto1.TabIndex = 18;
            this.foto1.TabStop = false;
            this.foto1.Click += new System.EventHandler(this.foto1_Click);
            // 
            // btnFoto1
            // 
            this.btnFoto1.Location = new System.Drawing.Point(493, 112);
            this.btnFoto1.Name = "btnFoto1";
            this.btnFoto1.Size = new System.Drawing.Size(55, 22);
            this.btnFoto1.TabIndex = 17;
            this.btnFoto1.Text = "Cargar";
            this.btnFoto1.UseVisualStyleBackColor = true;
            this.btnFoto1.Click += new System.EventHandler(this.btnFoto1_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(108, 32);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(110, 20);
            this.txtCodigo.TabIndex = 10;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(108, 112);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(222, 110);
            this.txtDescripcion.TabIndex = 7;
            this.txtDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescripcion_KeyPress);
            // 
            // txtMetro
            // 
            this.txtMetro.Location = new System.Drawing.Point(108, 70);
            this.txtMetro.Name = "txtMetro";
            this.txtMetro.Size = new System.Drawing.Size(75, 20);
            this.txtMetro.TabIndex = 6;
            this.txtMetro.TextChanged += new System.EventHandler(this.txtMetro_TextChanged);
            this.txtMetro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMetro_KeyPress);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(36, 117);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 3;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // lblMetro
            // 
            this.lblMetro.AutoSize = true;
            this.lblMetro.Location = new System.Drawing.Point(6, 73);
            this.lblMetro.Name = "lblMetro";
            this.lblMetro.Size = new System.Drawing.Size(96, 13);
            this.lblMetro.TabIndex = 2;
            this.lblMetro.Text = "Metros Cuadrados:";
            // 
            // groupUnidades
            // 
            this.groupUnidades.BackColor = System.Drawing.Color.Transparent;
            this.groupUnidades.Controls.Add(this.btnBajaUni);
            this.groupUnidades.Controls.Add(this.btnModificarUni);
            this.groupUnidades.Controls.Add(this.dataGridView2);
            this.groupUnidades.Enabled = false;
            this.groupUnidades.Location = new System.Drawing.Point(677, 12);
            this.groupUnidades.Name = "groupUnidades";
            this.groupUnidades.Size = new System.Drawing.Size(581, 308);
            this.groupUnidades.TabIndex = 6;
            this.groupUnidades.TabStop = false;
            this.groupUnidades.Text = "Unidades";
            // 
            // btnBajaUni
            // 
            this.btnBajaUni.Image = global::GUI.Properties.Resources.eliminar;
            this.btnBajaUni.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBajaUni.Location = new System.Drawing.Point(408, 251);
            this.btnBajaUni.Name = "btnBajaUni";
            this.btnBajaUni.Size = new System.Drawing.Size(94, 40);
            this.btnBajaUni.TabIndex = 10;
            this.btnBajaUni.Text = "Elimimar";
            this.btnBajaUni.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBajaUni.UseVisualStyleBackColor = true;
            this.btnBajaUni.Click += new System.EventHandler(this.btnBajaUni_Click);
            // 
            // btnModificarUni
            // 
            this.btnModificarUni.Image = global::GUI.Properties.Resources.editar;
            this.btnModificarUni.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarUni.Location = new System.Drawing.Point(105, 251);
            this.btnModificarUni.Name = "btnModificarUni";
            this.btnModificarUni.Size = new System.Drawing.Size(94, 40);
            this.btnModificarUni.TabIndex = 9;
            this.btnModificarUni.Text = "Modificar";
            this.btnModificarUni.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificarUni.UseVisualStyleBackColor = true;
            this.btnModificarUni.Click += new System.EventHandler(this.btnModificarUni_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoUnidad,
            this.descrip,
            this.met});
            this.dataGridView2.Location = new System.Drawing.Point(18, 33);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(546, 194);
            this.dataGridView2.TabIndex = 0;
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
            // groupPropiedades
            // 
            this.groupPropiedades.BackColor = System.Drawing.Color.Transparent;
            this.groupPropiedades.Controls.Add(this.btnSeleccionarPropiedad);
            this.groupPropiedades.Controls.Add(this.txtDireccion);
            this.groupPropiedades.Controls.Add(this.lblDireccion);
            this.groupPropiedades.Controls.Add(this.dataGridView1);
            this.groupPropiedades.Location = new System.Drawing.Point(10, 12);
            this.groupPropiedades.Name = "groupPropiedades";
            this.groupPropiedades.Size = new System.Drawing.Size(625, 308);
            this.groupPropiedades.TabIndex = 5;
            this.groupPropiedades.TabStop = false;
            this.groupPropiedades.Text = "Propiedades";
            // 
            // btnSeleccionarPropiedad
            // 
            this.btnSeleccionarPropiedad.Location = new System.Drawing.Point(240, 246);
            this.btnSeleccionarPropiedad.Name = "btnSeleccionarPropiedad";
            this.btnSeleccionarPropiedad.Size = new System.Drawing.Size(88, 29);
            this.btnSeleccionarPropiedad.TabIndex = 8;
            this.btnSeleccionarPropiedad.Text = "Seleccionar";
            this.btnSeleccionarPropiedad.UseVisualStyleBackColor = true;
            this.btnSeleccionarPropiedad.Click += new System.EventHandler(this.btnSeleccionarPropiedad_Click);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(87, 30);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(222, 20);
            this.txtDireccion.TabIndex = 7;
            this.txtDireccion.TextChanged += new System.EventHandler(this.txtDireccion_TextChanged);
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.ciudad,
            this.direccion,
            this.metros,
            this.descripcion});
            this.dataGridView1.Location = new System.Drawing.Point(19, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(546, 152);
            this.dataGridView1.TabIndex = 1;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "cod_propiedad";
            this.Codigo.HeaderText = "Codigo Propiedad";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Visible = false;
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
            this.descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.descripcion.DataPropertyName = "descripcion";
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::GUI.Properties.Resources.cancelar;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(479, 688);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(87, 42);
            this.btnSalir.TabIndex = 25;
            this.btnSalir.Text = "Cancelar";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // frmTablaModificacionUnidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(1362, 742);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.groupDatosUni);
            this.Controls.Add(this.groupUnidades);
            this.Controls.Add(this.groupPropiedades);
            this.Name = "frmTablaModificacionUnidad";
            this.Text = "Modificacion Unidad";
            this.groupDatosUni.ResumeLayout(false);
            this.groupDatosUni.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foto4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foto3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foto2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foto1)).EndInit();
            this.groupUnidades.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupPropiedades.ResumeLayout(false);
            this.groupPropiedades.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupDatosUni;
        private System.Windows.Forms.Button btnFoto4;
        private System.Windows.Forms.Button btnFoto3;
        private System.Windows.Forms.Button btnFoto2;
        private System.Windows.Forms.PictureBox foto4;
        private System.Windows.Forms.PictureBox foto3;
        private System.Windows.Forms.PictureBox foto2;
        private System.Windows.Forms.PictureBox foto1;
        private System.Windows.Forms.Button btnFoto1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnRegistra;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtMetro;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblMetro;
        private System.Windows.Forms.GroupBox groupUnidades;
        private System.Windows.Forms.Button btnBajaUni;
        private System.Windows.Forms.Button btnModificarUni;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupPropiedades;
        private System.Windows.Forms.Button btnSeleccionarPropiedad;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblCodUnidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoUnidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn descrip;
        private System.Windows.Forms.DataGridViewTextBoxColumn met;
        private System.Windows.Forms.Button btnLimpiaCampos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn metros;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.Label lblErrorCompletar;

    }
}