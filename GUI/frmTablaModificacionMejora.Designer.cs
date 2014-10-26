namespace GUI
{
    partial class frmTablaModificacionMejora
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
            this.mejorasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inmobiliariaDataSetMejorasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inmobiliariaDataSetMejoras = new GUI.InmobiliariaDataSetMejoras();
            this.mejorasTableAdapter = new GUI.InmobiliariaDataSetMejorasTableAdapters.MejorasTableAdapter();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gpbMejora = new System.Windows.Forms.GroupBox();
            this.lblNumeroMejora = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtDetalles = new System.Windows.Forms.TextBox();
            this.lblDetalles = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.gpbSeleccionMejora = new System.Windows.Forms.GroupBox();
            this.dgvMejora = new System.Windows.Forms.DataGridView();
            this.codcontratistaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nromejoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codunidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacionesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detallesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBaja = new System.Windows.Forms.Button();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.mejorasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inmobiliariaDataSetMejorasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inmobiliariaDataSetMejoras)).BeginInit();
            this.gpbMejora.SuspendLayout();
            this.gpbSeleccionMejora.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMejora)).BeginInit();
            this.SuspendLayout();
            // 
            // mejorasBindingSource
            // 
            this.mejorasBindingSource.DataMember = "Mejoras";
            this.mejorasBindingSource.DataSource = this.inmobiliariaDataSetMejorasBindingSource;
            // 
            // inmobiliariaDataSetMejorasBindingSource
            // 
            this.inmobiliariaDataSetMejorasBindingSource.DataSource = this.inmobiliariaDataSetMejoras;
            this.inmobiliariaDataSetMejorasBindingSource.Position = 0;
            // 
            // inmobiliariaDataSetMejoras
            // 
            this.inmobiliariaDataSetMejoras.DataSetName = "InmobiliariaDataSetMejoras";
            this.inmobiliariaDataSetMejoras.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mejorasTableAdapter
            // 
            this.mejorasTableAdapter.ClearBeforeFill = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(39, 441);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(86, 31);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // gpbMejora
            // 
            this.gpbMejora.BackColor = System.Drawing.Color.Transparent;
            this.gpbMejora.Controls.Add(this.label2);
            this.gpbMejora.Controls.Add(this.textBox2);
            this.gpbMejora.Controls.Add(this.label1);
            this.gpbMejora.Controls.Add(this.textBox1);
            this.gpbMejora.Controls.Add(this.txtFecha);
            this.gpbMejora.Controls.Add(this.lblFecha);
            this.gpbMejora.Controls.Add(this.lblNumeroMejora);
            this.gpbMejora.Controls.Add(this.txtNumero);
            this.gpbMejora.Controls.Add(this.lblValor);
            this.gpbMejora.Controls.Add(this.txtValor);
            this.gpbMejora.Controls.Add(this.btnRegistrar);
            this.gpbMejora.Controls.Add(this.txtDetalles);
            this.gpbMejora.Controls.Add(this.lblDetalles);
            this.gpbMejora.Controls.Add(this.lblTelefono);
            this.gpbMejora.Controls.Add(this.txtObservaciones);
            this.gpbMejora.Location = new System.Drawing.Point(732, 12);
            this.gpbMejora.Name = "gpbMejora";
            this.gpbMejora.Size = new System.Drawing.Size(277, 460);
            this.gpbMejora.TabIndex = 12;
            this.gpbMejora.TabStop = false;
            this.gpbMejora.Text = "Modificar datos de mejora";
            // 
            // lblNumeroMejora
            // 
            this.lblNumeroMejora.AutoSize = true;
            this.lblNumeroMejora.Enabled = false;
            this.lblNumeroMejora.Location = new System.Drawing.Point(14, 46);
            this.lblNumeroMejora.Name = "lblNumeroMejora";
            this.lblNumeroMejora.Size = new System.Drawing.Size(81, 13);
            this.lblNumeroMejora.TabIndex = 12;
            this.lblNumeroMejora.Text = "Numero mejora:";
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
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
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
            // gpbSeleccionMejora
            // 
            this.gpbSeleccionMejora.BackColor = System.Drawing.Color.Transparent;
            this.gpbSeleccionMejora.Controls.Add(this.dgvMejora);
            this.gpbSeleccionMejora.Controls.Add(this.btnBaja);
            this.gpbSeleccionMejora.Controls.Add(this.btnSeleccionar);
            this.gpbSeleccionMejora.Location = new System.Drawing.Point(12, 12);
            this.gpbSeleccionMejora.Name = "gpbSeleccionMejora";
            this.gpbSeleccionMejora.Size = new System.Drawing.Size(679, 387);
            this.gpbSeleccionMejora.TabIndex = 11;
            this.gpbSeleccionMejora.TabStop = false;
            this.gpbSeleccionMejora.Text = "Seleccione Mejora";
            // 
            // dgvMejora
            // 
            this.dgvMejora.AllowUserToAddRows = false;
            this.dgvMejora.AllowUserToDeleteRows = false;
            this.dgvMejora.AutoGenerateColumns = false;
            this.dgvMejora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMejora.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codcontratistaDataGridViewTextBoxColumn,
            this.nromejoraDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.valorDataGridViewTextBoxColumn,
            this.codunidadDataGridViewTextBoxColumn,
            this.observacionesDataGridViewTextBoxColumn,
            this.detallesDataGridViewTextBoxColumn});
            this.dgvMejora.DataSource = this.mejorasBindingSource;
            this.dgvMejora.Location = new System.Drawing.Point(27, 43);
            this.dgvMejora.Name = "dgvMejora";
            this.dgvMejora.ReadOnly = true;
            this.dgvMejora.Size = new System.Drawing.Size(627, 292);
            this.dgvMejora.TabIndex = 6;
            // 
            // codcontratistaDataGridViewTextBoxColumn
            // 
            this.codcontratistaDataGridViewTextBoxColumn.DataPropertyName = "cod_contratista";
            this.codcontratistaDataGridViewTextBoxColumn.HeaderText = "Contratista";
            this.codcontratistaDataGridViewTextBoxColumn.Name = "codcontratistaDataGridViewTextBoxColumn";
            this.codcontratistaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nromejoraDataGridViewTextBoxColumn
            // 
            this.nromejoraDataGridViewTextBoxColumn.DataPropertyName = "nro_mejora";
            this.nromejoraDataGridViewTextBoxColumn.HeaderText = "Mejora";
            this.nromejoraDataGridViewTextBoxColumn.Name = "nromejoraDataGridViewTextBoxColumn";
            this.nromejoraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorDataGridViewTextBoxColumn
            // 
            this.valorDataGridViewTextBoxColumn.DataPropertyName = "valor";
            this.valorDataGridViewTextBoxColumn.HeaderText = "Valor";
            this.valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            this.valorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codunidadDataGridViewTextBoxColumn
            // 
            this.codunidadDataGridViewTextBoxColumn.DataPropertyName = "cod_unidad";
            this.codunidadDataGridViewTextBoxColumn.HeaderText = "Unidad";
            this.codunidadDataGridViewTextBoxColumn.Name = "codunidadDataGridViewTextBoxColumn";
            this.codunidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // observacionesDataGridViewTextBoxColumn
            // 
            this.observacionesDataGridViewTextBoxColumn.DataPropertyName = "observaciones";
            this.observacionesDataGridViewTextBoxColumn.HeaderText = "Observaciones";
            this.observacionesDataGridViewTextBoxColumn.Name = "observacionesDataGridViewTextBoxColumn";
            this.observacionesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // detallesDataGridViewTextBoxColumn
            // 
            this.detallesDataGridViewTextBoxColumn.DataPropertyName = "detalles";
            this.detallesDataGridViewTextBoxColumn.HeaderText = "Detalles";
            this.detallesDataGridViewTextBoxColumn.Name = "detallesDataGridViewTextBoxColumn";
            this.detallesDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(55, 322);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(40, 13);
            this.lblFecha.TabIndex = 14;
            this.lblFecha.Text = "Fecha:";
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(105, 319);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(106, 20);
            this.txtFecha.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(4, 356);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Codigo contratista:";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(105, 353);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(106, 20);
            this.textBox1.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(20, 386);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Numero mejora:";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(105, 383);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(106, 20);
            this.textBox2.TabIndex = 19;
            // 
            // frmTablaModificacionMejora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 484);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.gpbMejora);
            this.Controls.Add(this.gpbSeleccionMejora);
            this.Name = "frmTablaModificacionMejora";
            this.Text = "Modificar mejora";
            this.Load += new System.EventHandler(this.frmTablaModificacionMejora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mejorasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inmobiliariaDataSetMejorasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inmobiliariaDataSetMejoras)).EndInit();
            this.gpbMejora.ResumeLayout(false);
            this.gpbMejora.PerformLayout();
            this.gpbSeleccionMejora.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMejora)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource inmobiliariaDataSetMejorasBindingSource;
        private InmobiliariaDataSetMejoras inmobiliariaDataSetMejoras;
        private System.Windows.Forms.BindingSource mejorasBindingSource;
        private InmobiliariaDataSetMejorasTableAdapters.MejorasTableAdapter mejorasTableAdapter;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox gpbMejora;
        private System.Windows.Forms.Label lblNumeroMejora;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txtDetalles;
        private System.Windows.Forms.Label lblDetalles;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.GroupBox gpbSeleccionMejora;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.DataGridView dgvMejora;
        private System.Windows.Forms.DataGridViewTextBoxColumn codcontratistaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nromejoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codunidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacionesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detallesDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label lblFecha;
    }
}