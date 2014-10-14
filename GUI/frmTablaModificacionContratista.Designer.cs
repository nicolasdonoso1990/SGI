namespace GUI
{
    partial class frmTablaModificacionContratista
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
            this.components = new System.ComponentModel.Container();
            this.gpbContratista = new System.Windows.Forms.GroupBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtDisponibilidad = new System.Windows.Forms.TextBox();
            this.lblDisponibilidad = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBaja = new System.Windows.Forms.Button();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.lblInApellido = new System.Windows.Forms.Label();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.dgvContratista = new System.Windows.Forms.DataGridView();
            this.contratistasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inmobiliariaDataSet = new GUI.InmobiliariaDataSet();
            this.contratistasTableAdapter = new GUI.InmobiliariaDataSetTableAdapters.ContratistasTableAdapter();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cod_contratista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disponibilidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpbContratista.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContratista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratistasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inmobiliariaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbContratista
            // 
            this.gpbContratista.BackColor = System.Drawing.Color.Transparent;
            this.gpbContratista.Controls.Add(this.lblCodigo);
            this.gpbContratista.Controls.Add(this.txtCodigo);
            this.gpbContratista.Controls.Add(this.lblNombre);
            this.gpbContratista.Controls.Add(this.txtNombre);
            this.gpbContratista.Controls.Add(this.btnRegistrar);
            this.gpbContratista.Controls.Add(this.txtDisponibilidad);
            this.gpbContratista.Controls.Add(this.lblDisponibilidad);
            this.gpbContratista.Controls.Add(this.lblTelefono);
            this.gpbContratista.Controls.Add(this.txtTelefono);
            this.gpbContratista.Controls.Add(this.lblDireccion);
            this.gpbContratista.Controls.Add(this.txtDireccion);
            this.gpbContratista.Controls.Add(this.lblApellido);
            this.gpbContratista.Controls.Add(this.txtApellido);
            this.gpbContratista.Location = new System.Drawing.Point(744, 22);
            this.gpbContratista.Name = "gpbContratista";
            this.gpbContratista.Size = new System.Drawing.Size(277, 362);
            this.gpbContratista.TabIndex = 9;
            this.gpbContratista.TabStop = false;
            this.gpbContratista.Text = "Modificar datos contratista";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Enabled = false;
            this.lblCodigo.Location = new System.Drawing.Point(27, 46);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 12;
            this.lblCodigo.Text = "Codigo:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(85, 43);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(106, 20);
            this.txtCodigo.TabIndex = 13;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(27, 82);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 10;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(85, 79);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(106, 20);
            this.txtNombre.TabIndex = 11;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(101, 251);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 1;
            this.btnRegistrar.Text = "Modificar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtDisponibilidad
            // 
            this.txtDisponibilidad.Location = new System.Drawing.Point(85, 213);
            this.txtDisponibilidad.Name = "txtDisponibilidad";
            this.txtDisponibilidad.Size = new System.Drawing.Size(106, 20);
            this.txtDisponibilidad.TabIndex = 9;
            // 
            // lblDisponibilidad
            // 
            this.lblDisponibilidad.AutoSize = true;
            this.lblDisponibilidad.Location = new System.Drawing.Point(-1, 216);
            this.lblDisponibilidad.Name = "lblDisponibilidad";
            this.lblDisponibilidad.Size = new System.Drawing.Size(75, 13);
            this.lblDisponibilidad.TabIndex = 7;
            this.lblDisponibilidad.Text = "Disponibilidad:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(22, 182);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(52, 13);
            this.lblTelefono.TabIndex = 5;
            this.lblTelefono.Text = "Telefono:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(85, 179);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(106, 20);
            this.txtTelefono.TabIndex = 6;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(19, 149);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(55, 13);
            this.lblDireccion.TabIndex = 4;
            this.lblDireccion.Text = "Direccion:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(85, 146);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(106, 20);
            this.txtDireccion.TabIndex = 5;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(27, 115);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(47, 13);
            this.lblApellido.TabIndex = 3;
            this.lblApellido.Text = "Apellido:";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(85, 112);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(106, 20);
            this.txtApellido.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnBaja);
            this.groupBox1.Controls.Add(this.txtBusca);
            this.groupBox1.Controls.Add(this.lblInApellido);
            this.groupBox1.Controls.Add(this.btnSeleccionar);
            this.groupBox1.Controls.Add(this.dgvContratista);
            this.groupBox1.Location = new System.Drawing.Point(45, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(658, 362);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione Contratista";
            // 
            // btnBaja
            // 
            this.btnBaja.Location = new System.Drawing.Point(472, 310);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(86, 31);
            this.btnBaja.TabIndex = 5;
            this.btnBaja.Text = "Dar de Baja";
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // txtBusca
            // 
            this.txtBusca.Location = new System.Drawing.Point(123, 25);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(100, 20);
            this.txtBusca.TabIndex = 4;
            // 
            // lblInApellido
            // 
            this.lblInApellido.AutoSize = true;
            this.lblInApellido.Location = new System.Drawing.Point(32, 32);
            this.lblInApellido.Name = "lblInApellido";
            this.lblInApellido.Size = new System.Drawing.Size(85, 13);
            this.lblInApellido.TabIndex = 3;
            this.lblInApellido.Text = "Ingrese Apellido:";
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(105, 310);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(86, 31);
            this.btnSeleccionar.TabIndex = 2;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // dgvContratista
            // 
            this.dgvContratista.AllowUserToAddRows = false;
            this.dgvContratista.AutoGenerateColumns = false;
            this.dgvContratista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContratista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_contratista,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.disponibilidadDataGridViewTextBoxColumn});
            this.dgvContratista.DataSource = this.contratistasBindingSource;
            this.dgvContratista.Location = new System.Drawing.Point(6, 79);
            this.dgvContratista.MultiSelect = false;
            this.dgvContratista.Name = "dgvContratista";
            this.dgvContratista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContratista.Size = new System.Drawing.Size(644, 195);
            this.dgvContratista.TabIndex = 1;
            // 
            // contratistasBindingSource
            // 
            this.contratistasBindingSource.DataMember = "Contratistas";
            this.contratistasBindingSource.DataSource = this.inmobiliariaDataSet;
            // 
            // inmobiliariaDataSet
            // 
            this.inmobiliariaDataSet.DataSetName = "InmobiliariaDataSet";
            this.inmobiliariaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contratistasTableAdapter
            // 
            this.contratistasTableAdapter.ClearBeforeFill = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(51, 415);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(86, 31);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // cod_contratista
            // 
            this.cod_contratista.DataPropertyName = "cod_contratista";
            this.cod_contratista.HeaderText = "cod_contratista";
            this.cod_contratista.Name = "cod_contratista";
            this.cod_contratista.Visible = false;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            this.apellidoDataGridViewTextBoxColumn.DataPropertyName = "apellido";
            this.apellidoDataGridViewTextBoxColumn.HeaderText = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            // 
            // disponibilidadDataGridViewTextBoxColumn
            // 
            this.disponibilidadDataGridViewTextBoxColumn.DataPropertyName = "disponibilidad";
            this.disponibilidadDataGridViewTextBoxColumn.HeaderText = "Disponibilidad";
            this.disponibilidadDataGridViewTextBoxColumn.Name = "disponibilidadDataGridViewTextBoxColumn";
            // 
            // frmTablaModificacionContratista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 458);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.gpbContratista);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmTablaModificacionContratista";
            this.Text = "frmTablaModificacionContratista";
            this.Load += new System.EventHandler(this.frmTablaModificacionContratista_Load);
            this.gpbContratista.ResumeLayout(false);
            this.gpbContratista.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContratista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratistasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inmobiliariaDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbContratista;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txtDisponibilidad;
        private System.Windows.Forms.Label lblDisponibilidad;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.Label lblInApellido;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.DataGridView dgvContratista;
        private InmobiliariaDataSet inmobiliariaDataSet;
        private System.Windows.Forms.BindingSource contratistasBindingSource;
        private InmobiliariaDataSetTableAdapters.ContratistasTableAdapter contratistasTableAdapter;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_contratista;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn disponibilidadDataGridViewTextBoxColumn;
    }
}