namespace GUI
{
    partial class frmAltaMejora
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
            this.gpbMejora = new System.Windows.Forms.GroupBox();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.txtDetalles = new System.Windows.Forms.TextBox();
            this.lblDetalles = new System.Windows.Forms.Label();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.gpbUnidad = new System.Windows.Forms.GroupBox();
            this.dgvUnidad = new System.Windows.Forms.DataGridView();
            this.codpropiedadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_unidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inmobiliariaDataSetUnidades = new GUI.InmobiliariaDataSetUnidades();
            this.gpbContratista = new System.Windows.Forms.GroupBox();
            this.dgvContratista = new System.Windows.Forms.DataGridView();
            this.cod_contratista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disponibilidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contratistasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inmobiliariaDataSetContratistas = new GUI.InmobiliariaDataSetContratistas();
            this.unidadesTableAdapter = new GUI.InmobiliariaDataSetUnidadesTableAdapters.UnidadesTableAdapter();
            this.contratistasTableAdapter = new GUI.InmobiliariaDataSetContratistasTableAdapters.ContratistasTableAdapter();
            this.gpbMejora.SuspendLayout();
            this.gpbUnidad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inmobiliariaDataSetUnidades)).BeginInit();
            this.gpbContratista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContratista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratistasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inmobiliariaDataSetContratistas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(1061, 437);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.Text = "Cerrar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // gpbMejora
            // 
            this.gpbMejora.BackColor = System.Drawing.Color.Transparent;
            this.gpbMejora.Controls.Add(this.txtObservaciones);
            this.gpbMejora.Controls.Add(this.txtDetalles);
            this.gpbMejora.Controls.Add(this.lblDetalles);
            this.gpbMejora.Controls.Add(this.lblObservaciones);
            this.gpbMejora.Controls.Add(this.dtpFecha);
            this.gpbMejora.Controls.Add(this.lblFecha);
            this.gpbMejora.Controls.Add(this.lblValor);
            this.gpbMejora.Controls.Add(this.txtValor);
            this.gpbMejora.Location = new System.Drawing.Point(12, 196);
            this.gpbMejora.Name = "gpbMejora";
            this.gpbMejora.Size = new System.Drawing.Size(1124, 232);
            this.gpbMejora.TabIndex = 17;
            this.gpbMejora.TabStop = false;
            this.gpbMejora.Text = "Datos de la mejora";
            this.gpbMejora.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(458, 19);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(289, 188);
            this.txtObservaciones.TabIndex = 19;
            // 
            // txtDetalles
            // 
            this.txtDetalles.Location = new System.Drawing.Point(67, 19);
            this.txtDetalles.Multiline = true;
            this.txtDetalles.Name = "txtDetalles";
            this.txtDetalles.Size = new System.Drawing.Size(289, 188);
            this.txtDetalles.TabIndex = 18;
            // 
            // lblDetalles
            // 
            this.lblDetalles.AutoSize = true;
            this.lblDetalles.Location = new System.Drawing.Point(10, 22);
            this.lblDetalles.Name = "lblDetalles";
            this.lblDetalles.Size = new System.Drawing.Size(48, 13);
            this.lblDetalles.TabIndex = 17;
            this.lblDetalles.Text = "Detalles:";
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Location = new System.Drawing.Point(373, 22);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(81, 13);
            this.lblObservaciones.TabIndex = 16;
            this.lblObservaciones.Text = "Observaciones:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(875, 22);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 15;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(817, 28);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(40, 13);
            this.lblFecha.TabIndex = 14;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(823, 58);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(34, 13);
            this.lblValor.TabIndex = 3;
            this.lblValor.Text = "Valor:";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(875, 55);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(106, 20);
            this.txtValor.TabIndex = 4;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(589, 437);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 1;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // gpbUnidad
            // 
            this.gpbUnidad.Controls.Add(this.dgvUnidad);
            this.gpbUnidad.Location = new System.Drawing.Point(12, 12);
            this.gpbUnidad.Name = "gpbUnidad";
            this.gpbUnidad.Size = new System.Drawing.Size(565, 178);
            this.gpbUnidad.TabIndex = 19;
            this.gpbUnidad.TabStop = false;
            this.gpbUnidad.Text = "Seleccione Unidad:";
            // 
            // dgvUnidad
            // 
            this.dgvUnidad.AllowUserToAddRows = false;
            this.dgvUnidad.AllowUserToDeleteRows = false;
            this.dgvUnidad.AutoGenerateColumns = false;
            this.dgvUnidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnidad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codpropiedadDataGridViewTextBoxColumn,
            this.cod_unidad,
            this.m2DataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn});
            this.dgvUnidad.DataSource = this.unidadesBindingSource;
            this.dgvUnidad.Location = new System.Drawing.Point(13, 19);
            this.dgvUnidad.Name = "dgvUnidad";
            this.dgvUnidad.ReadOnly = true;
            this.dgvUnidad.Size = new System.Drawing.Size(534, 147);
            this.dgvUnidad.TabIndex = 0;
            // 
            // codpropiedadDataGridViewTextBoxColumn
            // 
            this.codpropiedadDataGridViewTextBoxColumn.DataPropertyName = "cod_propiedad";
            this.codpropiedadDataGridViewTextBoxColumn.HeaderText = "Cod Propiedad";
            this.codpropiedadDataGridViewTextBoxColumn.Name = "codpropiedadDataGridViewTextBoxColumn";
            this.codpropiedadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cod_unidad
            // 
            this.cod_unidad.DataPropertyName = "cod_unidad";
            this.cod_unidad.HeaderText = "Cod Unidad";
            this.cod_unidad.Name = "cod_unidad";
            this.cod_unidad.ReadOnly = true;
            // 
            // m2DataGridViewTextBoxColumn
            // 
            this.m2DataGridViewTextBoxColumn.DataPropertyName = "m2";
            this.m2DataGridViewTextBoxColumn.HeaderText = "Mts. Cuadrados";
            this.m2DataGridViewTextBoxColumn.Name = "m2DataGridViewTextBoxColumn";
            this.m2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unidadesBindingSource
            // 
            this.unidadesBindingSource.DataMember = "Unidades";
            this.unidadesBindingSource.DataSource = this.inmobiliariaDataSetUnidades;
            // 
            // inmobiliariaDataSetUnidades
            // 
            this.inmobiliariaDataSetUnidades.DataSetName = "InmobiliariaDataSetUnidades";
            this.inmobiliariaDataSetUnidades.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gpbContratista
            // 
            this.gpbContratista.Controls.Add(this.dgvContratista);
            this.gpbContratista.Location = new System.Drawing.Point(583, 12);
            this.gpbContratista.Name = "gpbContratista";
            this.gpbContratista.Size = new System.Drawing.Size(553, 178);
            this.gpbContratista.TabIndex = 20;
            this.gpbContratista.TabStop = false;
            this.gpbContratista.Text = "Seleccione Contratista:";
            // 
            // dgvContratista
            // 
            this.dgvContratista.AllowUserToAddRows = false;
            this.dgvContratista.AllowUserToDeleteRows = false;
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
            this.dgvContratista.Location = new System.Drawing.Point(6, 19);
            this.dgvContratista.Name = "dgvContratista";
            this.dgvContratista.ReadOnly = true;
            this.dgvContratista.Size = new System.Drawing.Size(534, 147);
            this.dgvContratista.TabIndex = 1;
            // 
            // cod_contratista
            // 
            this.cod_contratista.DataPropertyName = "cod_contratista";
            this.cod_contratista.HeaderText = "Cod Contratista";
            this.cod_contratista.Name = "cod_contratista";
            this.cod_contratista.ReadOnly = true;
            this.cod_contratista.Visible = false;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            this.apellidoDataGridViewTextBoxColumn.DataPropertyName = "apellido";
            this.apellidoDataGridViewTextBoxColumn.HeaderText = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            this.apellidoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            this.direccionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            this.telefonoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // disponibilidadDataGridViewTextBoxColumn
            // 
            this.disponibilidadDataGridViewTextBoxColumn.DataPropertyName = "disponibilidad";
            this.disponibilidadDataGridViewTextBoxColumn.HeaderText = "Disponibilidad";
            this.disponibilidadDataGridViewTextBoxColumn.Name = "disponibilidadDataGridViewTextBoxColumn";
            this.disponibilidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contratistasBindingSource
            // 
            this.contratistasBindingSource.DataMember = "Contratistas";
            this.contratistasBindingSource.DataSource = this.inmobiliariaDataSetContratistas;
            // 
            // inmobiliariaDataSetContratistas
            // 
            this.inmobiliariaDataSetContratistas.DataSetName = "InmobiliariaDataSetContratistas";
            this.inmobiliariaDataSetContratistas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // unidadesTableAdapter
            // 
            this.unidadesTableAdapter.ClearBeforeFill = true;
            // 
            // contratistasTableAdapter
            // 
            this.contratistasTableAdapter.ClearBeforeFill = true;
            // 
            // frmAltaMejora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 472);
            this.Controls.Add(this.gpbContratista);
            this.Controls.Add(this.gpbUnidad);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.gpbMejora);
            this.Controls.Add(this.btnRegistrar);
            this.Name = "frmAltaMejora";
            this.Text = "Crear Mejora";
            this.Load += new System.EventHandler(this.frmAltaMejora_Load);
            this.gpbMejora.ResumeLayout(false);
            this.gpbMejora.PerformLayout();
            this.gpbUnidad.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inmobiliariaDataSetUnidades)).EndInit();
            this.gpbContratista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContratista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratistasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inmobiliariaDataSetContratistas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox gpbMejora;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.TextBox txtDetalles;
        private System.Windows.Forms.Label lblDetalles;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.GroupBox gpbUnidad;
        private System.Windows.Forms.DataGridView dgvUnidad;
        private System.Windows.Forms.GroupBox gpbContratista;
        private System.Windows.Forms.DataGridView dgvContratista;
        private InmobiliariaDataSetUnidades inmobiliariaDataSetUnidades;
        private System.Windows.Forms.BindingSource unidadesBindingSource;
        private InmobiliariaDataSetUnidadesTableAdapters.UnidadesTableAdapter unidadesTableAdapter;
        private InmobiliariaDataSetContratistas inmobiliariaDataSetContratistas;
        private System.Windows.Forms.BindingSource contratistasBindingSource;
        private InmobiliariaDataSetContratistasTableAdapters.ContratistasTableAdapter contratistasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codpropiedadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_unidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn m2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_contratista;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn disponibilidadDataGridViewTextBoxColumn;
    }
}