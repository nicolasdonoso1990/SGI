namespace GUI
{
    partial class frmTablaModificacionReparacion
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gpbReparacion = new System.Windows.Forms.GroupBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblUnidad = new System.Windows.Forms.Label();
            this.txtUnidad = new System.Windows.Forms.TextBox();
            this.lblContratista = new System.Windows.Forms.Label();
            this.txtContratista = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblNumeroReparacion = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtDetalles = new System.Windows.Forms.TextBox();
            this.lblDetalles = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.gpbSeleccionReparacion = new System.Windows.Forms.GroupBox();
            this.dgvReparacion = new System.Windows.Forms.DataGridView();
            this.btnBaja = new System.Windows.Forms.Button();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.inmobiliariaDataSet1 = new GUI.InmobiliariaDataSet1();
            this.reparacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reparacionesTableAdapter = new GUI.InmobiliariaDataSet1TableAdapters.ReparacionesTableAdapter();
            this.nroreparacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codcontratistaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codunidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detallesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacionesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpbReparacion.SuspendLayout();
            this.gpbSeleccionReparacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReparacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inmobiliariaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reparacionesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(39, 441);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(86, 31);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // gpbReparacion
            // 
            this.gpbReparacion.BackColor = System.Drawing.Color.Transparent;
            this.gpbReparacion.Controls.Add(this.dtpFecha);
            this.gpbReparacion.Controls.Add(this.lblUnidad);
            this.gpbReparacion.Controls.Add(this.txtUnidad);
            this.gpbReparacion.Controls.Add(this.lblContratista);
            this.gpbReparacion.Controls.Add(this.txtContratista);
            this.gpbReparacion.Controls.Add(this.lblFecha);
            this.gpbReparacion.Controls.Add(this.lblNumeroReparacion);
            this.gpbReparacion.Controls.Add(this.txtNumero);
            this.gpbReparacion.Controls.Add(this.lblValor);
            this.gpbReparacion.Controls.Add(this.txtValor);
            this.gpbReparacion.Controls.Add(this.btnRegistrar);
            this.gpbReparacion.Controls.Add(this.txtDetalles);
            this.gpbReparacion.Controls.Add(this.lblDetalles);
            this.gpbReparacion.Controls.Add(this.lblTelefono);
            this.gpbReparacion.Controls.Add(this.txtObservaciones);
            this.gpbReparacion.Location = new System.Drawing.Point(697, 12);
            this.gpbReparacion.Name = "gpbReparacion";
            this.gpbReparacion.Size = new System.Drawing.Size(312, 460);
            this.gpbReparacion.TabIndex = 15;
            this.gpbReparacion.TabStop = false;
            this.gpbReparacion.Text = "Modificar datos de mejora";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(104, 322);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 20;
            // 
            // lblUnidad
            // 
            this.lblUnidad.AutoSize = true;
            this.lblUnidad.Enabled = false;
            this.lblUnidad.Location = new System.Drawing.Point(20, 386);
            this.lblUnidad.Name = "lblUnidad";
            this.lblUnidad.Size = new System.Drawing.Size(80, 13);
            this.lblUnidad.TabIndex = 18;
            this.lblUnidad.Text = "Codigo Unidad:";
            // 
            // txtUnidad
            // 
            this.txtUnidad.Enabled = false;
            this.txtUnidad.Location = new System.Drawing.Point(105, 383);
            this.txtUnidad.Name = "txtUnidad";
            this.txtUnidad.Size = new System.Drawing.Size(106, 20);
            this.txtUnidad.TabIndex = 19;
            // 
            // lblContratista
            // 
            this.lblContratista.AutoSize = true;
            this.lblContratista.Enabled = false;
            this.lblContratista.Location = new System.Drawing.Point(4, 356);
            this.lblContratista.Name = "lblContratista";
            this.lblContratista.Size = new System.Drawing.Size(95, 13);
            this.lblContratista.TabIndex = 16;
            this.lblContratista.Text = "Codigo contratista:";
            // 
            // txtContratista
            // 
            this.txtContratista.Enabled = false;
            this.txtContratista.Location = new System.Drawing.Point(105, 353);
            this.txtContratista.Name = "txtContratista";
            this.txtContratista.Size = new System.Drawing.Size(106, 20);
            this.txtContratista.TabIndex = 17;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(58, 322);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(40, 13);
            this.lblFecha.TabIndex = 14;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblNumeroReparacion
            // 
            this.lblNumeroReparacion.AutoSize = true;
            this.lblNumeroReparacion.Enabled = false;
            this.lblNumeroReparacion.Location = new System.Drawing.Point(-1, 46);
            this.lblNumeroReparacion.Name = "lblNumeroReparacion";
            this.lblNumeroReparacion.Size = new System.Drawing.Size(100, 13);
            this.lblNumeroReparacion.TabIndex = 12;
            this.lblNumeroReparacion.Text = "Numero reparacion:";
            // 
            // txtNumero
            // 
            this.txtNumero.Enabled = false;
            this.txtNumero.Location = new System.Drawing.Point(105, 43);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(106, 20);
            this.txtNumero.TabIndex = 13;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(61, 82);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(34, 13);
            this.lblValor.TabIndex = 10;
            this.lblValor.Text = "Valor:";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(105, 79);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(106, 20);
            this.txtValor.TabIndex = 11;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(105, 433);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 1;
            this.btnRegistrar.Text = "Modificar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // txtDetalles
            // 
            this.txtDetalles.Location = new System.Drawing.Point(104, 229);
            this.txtDetalles.Multiline = true;
            this.txtDetalles.Name = "txtDetalles";
            this.txtDetalles.Size = new System.Drawing.Size(161, 84);
            this.txtDetalles.TabIndex = 9;
            // 
            // lblDetalles
            // 
            this.lblDetalles.AutoSize = true;
            this.lblDetalles.Location = new System.Drawing.Point(55, 232);
            this.lblDetalles.Name = "lblDetalles";
            this.lblDetalles.Size = new System.Drawing.Size(48, 13);
            this.lblDetalles.TabIndex = 7;
            this.lblDetalles.Text = "Detalles:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(17, 123);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(81, 13);
            this.lblTelefono.TabIndex = 5;
            this.lblTelefono.Text = "Observaciones:";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(104, 120);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(160, 103);
            this.txtObservaciones.TabIndex = 6;
            // 
            // gpbSeleccionReparacion
            // 
            this.gpbSeleccionReparacion.BackColor = System.Drawing.Color.Transparent;
            this.gpbSeleccionReparacion.Controls.Add(this.dgvReparacion);
            this.gpbSeleccionReparacion.Controls.Add(this.btnBaja);
            this.gpbSeleccionReparacion.Controls.Add(this.btnSeleccionar);
            this.gpbSeleccionReparacion.Location = new System.Drawing.Point(12, 12);
            this.gpbSeleccionReparacion.Name = "gpbSeleccionReparacion";
            this.gpbSeleccionReparacion.Size = new System.Drawing.Size(679, 387);
            this.gpbSeleccionReparacion.TabIndex = 14;
            this.gpbSeleccionReparacion.TabStop = false;
            this.gpbSeleccionReparacion.Text = "Seleccione Reparacion";
            // 
            // dgvReparacion
            // 
            this.dgvReparacion.AllowUserToAddRows = false;
            this.dgvReparacion.AllowUserToDeleteRows = false;
            this.dgvReparacion.AutoGenerateColumns = false;
            this.dgvReparacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReparacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nroreparacionDataGridViewTextBoxColumn,
            this.codcontratistaDataGridViewTextBoxColumn,
            this.codunidadDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.valorDataGridViewTextBoxColumn,
            this.detallesDataGridViewTextBoxColumn,
            this.observacionesDataGridViewTextBoxColumn});
            this.dgvReparacion.DataSource = this.reparacionesBindingSource;
            this.dgvReparacion.Location = new System.Drawing.Point(27, 43);
            this.dgvReparacion.Name = "dgvReparacion";
            this.dgvReparacion.ReadOnly = true;
            this.dgvReparacion.Size = new System.Drawing.Size(627, 292);
            this.dgvReparacion.TabIndex = 6;
            // 
            // btnBaja
            // 
            this.btnBaja.Location = new System.Drawing.Point(477, 350);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(86, 31);
            this.btnBaja.TabIndex = 5;
            this.btnBaja.Text = "Dar de Baja";
            this.btnBaja.UseVisualStyleBackColor = true;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(105, 350);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(86, 31);
            this.btnSeleccionar.TabIndex = 2;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            // 
            // inmobiliariaDataSet1
            // 
            this.inmobiliariaDataSet1.DataSetName = "InmobiliariaDataSet1";
            this.inmobiliariaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reparacionesBindingSource
            // 
            this.reparacionesBindingSource.DataMember = "Reparaciones";
            this.reparacionesBindingSource.DataSource = this.inmobiliariaDataSet1;
            // 
            // reparacionesTableAdapter
            // 
            this.reparacionesTableAdapter.ClearBeforeFill = true;
            // 
            // nroreparacionDataGridViewTextBoxColumn
            // 
            this.nroreparacionDataGridViewTextBoxColumn.DataPropertyName = "nro_reparacion";
            this.nroreparacionDataGridViewTextBoxColumn.HeaderText = "nro_reparacion";
            this.nroreparacionDataGridViewTextBoxColumn.Name = "nroreparacionDataGridViewTextBoxColumn";
            this.nroreparacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codcontratistaDataGridViewTextBoxColumn
            // 
            this.codcontratistaDataGridViewTextBoxColumn.DataPropertyName = "cod_contratista";
            this.codcontratistaDataGridViewTextBoxColumn.HeaderText = "cod_contratista";
            this.codcontratistaDataGridViewTextBoxColumn.Name = "codcontratistaDataGridViewTextBoxColumn";
            this.codcontratistaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codunidadDataGridViewTextBoxColumn
            // 
            this.codunidadDataGridViewTextBoxColumn.DataPropertyName = "cod_unidad";
            this.codunidadDataGridViewTextBoxColumn.HeaderText = "cod_unidad";
            this.codunidadDataGridViewTextBoxColumn.Name = "codunidadDataGridViewTextBoxColumn";
            this.codunidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorDataGridViewTextBoxColumn
            // 
            this.valorDataGridViewTextBoxColumn.DataPropertyName = "valor";
            this.valorDataGridViewTextBoxColumn.HeaderText = "valor";
            this.valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            this.valorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // detallesDataGridViewTextBoxColumn
            // 
            this.detallesDataGridViewTextBoxColumn.DataPropertyName = "detalles";
            this.detallesDataGridViewTextBoxColumn.HeaderText = "detalles";
            this.detallesDataGridViewTextBoxColumn.Name = "detallesDataGridViewTextBoxColumn";
            this.detallesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // observacionesDataGridViewTextBoxColumn
            // 
            this.observacionesDataGridViewTextBoxColumn.DataPropertyName = "observaciones";
            this.observacionesDataGridViewTextBoxColumn.HeaderText = "observaciones";
            this.observacionesDataGridViewTextBoxColumn.Name = "observacionesDataGridViewTextBoxColumn";
            this.observacionesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmTablaModificacionReparacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 481);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.gpbReparacion);
            this.Controls.Add(this.gpbSeleccionReparacion);
            this.Name = "frmTablaModificacionReparacion";
            this.Text = "frmTablaModificacionReparacion";
            this.Load += new System.EventHandler(this.frmTablaModificacionReparacion_Load);
            this.gpbReparacion.ResumeLayout(false);
            this.gpbReparacion.PerformLayout();
            this.gpbSeleccionReparacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReparacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inmobiliariaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reparacionesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox gpbReparacion;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblUnidad;
        private System.Windows.Forms.TextBox txtUnidad;
        private System.Windows.Forms.Label lblContratista;
        private System.Windows.Forms.TextBox txtContratista;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblNumeroReparacion;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txtDetalles;
        private System.Windows.Forms.Label lblDetalles;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.GroupBox gpbSeleccionReparacion;
        private System.Windows.Forms.DataGridView dgvReparacion;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Button btnSeleccionar;
        private InmobiliariaDataSet1 inmobiliariaDataSet1;
        private System.Windows.Forms.BindingSource reparacionesBindingSource;
        private InmobiliariaDataSet1TableAdapters.ReparacionesTableAdapter reparacionesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroreparacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codcontratistaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codunidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detallesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacionesDataGridViewTextBoxColumn;
    }
}