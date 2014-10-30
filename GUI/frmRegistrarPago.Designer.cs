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
            this.btnSeleccionarInquilino = new System.Windows.Forms.Button();
            this.lblFiltroDni = new System.Windows.Forms.Label();
            this.txtboxFiltroDni = new System.Windows.Forms.TextBox();
            this.grpboxUnidad = new System.Windows.Forms.GroupBox();
            this.btnSeleccionarUnidad = new System.Windows.Forms.Button();
            this.lblFiltrarDescripcion = new System.Windows.Forms.Label();
            this.txtboxFiltroDescripcion = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grpboxPago = new System.Windows.Forms.GroupBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnRegistarPago = new System.Windows.Forms.Button();
            this.txtboxMonto = new System.Windows.Forms.TextBox();
            this.txtboxSaldoActual = new System.Windows.Forms.TextBox();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnVolveraEmpezar = new System.Windows.Forms.Button();
            this.dgvInquilinos = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grboxInquilino.SuspendLayout();
            this.grpboxUnidad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpboxPago.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInquilinos)).BeginInit();
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
            // btnSeleccionarInquilino
            // 
            this.btnSeleccionarInquilino.Location = new System.Drawing.Point(183, 262);
            this.btnSeleccionarInquilino.Name = "btnSeleccionarInquilino";
            this.btnSeleccionarInquilino.Size = new System.Drawing.Size(152, 23);
            this.btnSeleccionarInquilino.TabIndex = 3;
            this.btnSeleccionarInquilino.Text = "Seleccionar Inquilino";
            this.btnSeleccionarInquilino.UseVisualStyleBackColor = true;
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
            this.grpboxUnidad.Controls.Add(this.btnSeleccionarUnidad);
            this.grpboxUnidad.Controls.Add(this.lblFiltrarDescripcion);
            this.grpboxUnidad.Controls.Add(this.txtboxFiltroDescripcion);
            this.grpboxUnidad.Controls.Add(this.dataGridView1);
            this.grpboxUnidad.Location = new System.Drawing.Point(605, 12);
            this.grpboxUnidad.Name = "grpboxUnidad";
            this.grpboxUnidad.Size = new System.Drawing.Size(305, 306);
            this.grpboxUnidad.TabIndex = 4;
            this.grpboxUnidad.TabStop = false;
            this.grpboxUnidad.Text = "Seleccione Unidad";
            // 
            // btnSeleccionarUnidad
            // 
            this.btnSeleccionarUnidad.Location = new System.Drawing.Point(90, 262);
            this.btnSeleccionarUnidad.Name = "btnSeleccionarUnidad";
            this.btnSeleccionarUnidad.Size = new System.Drawing.Size(152, 23);
            this.btnSeleccionarUnidad.TabIndex = 3;
            this.btnSeleccionarUnidad.Text = "Seleccionar Unidad";
            this.btnSeleccionarUnidad.UseVisualStyleBackColor = true;
            // 
            // lblFiltrarDescripcion
            // 
            this.lblFiltrarDescripcion.AutoSize = true;
            this.lblFiltrarDescripcion.Location = new System.Drawing.Point(6, 31);
            this.lblFiltrarDescripcion.Name = "lblFiltrarDescripcion";
            this.lblFiltrarDescripcion.Size = new System.Drawing.Size(112, 13);
            this.lblFiltrarDescripcion.TabIndex = 2;
            this.lblFiltrarDescripcion.Text = "Filtrar por Descripción:";
            // 
            // txtboxFiltroDescripcion
            // 
            this.txtboxFiltroDescripcion.Location = new System.Drawing.Point(116, 31);
            this.txtboxFiltroDescripcion.Name = "txtboxFiltroDescripcion";
            this.txtboxFiltroDescripcion.Size = new System.Drawing.Size(176, 20);
            this.txtboxFiltroDescripcion.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(270, 183);
            this.dataGridView1.TabIndex = 0;
            // 
            // grpboxPago
            // 
            this.grpboxPago.Controls.Add(this.dtpFecha);
            this.grpboxPago.Controls.Add(this.btnRegistarPago);
            this.grpboxPago.Controls.Add(this.txtboxMonto);
            this.grpboxPago.Controls.Add(this.txtboxSaldoActual);
            this.grpboxPago.Controls.Add(this.lblSaldo);
            this.grpboxPago.Controls.Add(this.lblMonto);
            this.grpboxPago.Controls.Add(this.lblFecha);
            this.grpboxPago.Location = new System.Drawing.Point(12, 339);
            this.grpboxPago.Name = "grpboxPago";
            this.grpboxPago.Size = new System.Drawing.Size(555, 141);
            this.grpboxPago.TabIndex = 4;
            this.grpboxPago.TabStop = false;
            this.grpboxPago.Text = "Ingrese Pago";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(146, 55);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 8;
            // 
            // btnRegistarPago
            // 
            this.btnRegistarPago.Location = new System.Drawing.Point(433, 41);
            this.btnRegistarPago.Name = "btnRegistarPago";
            this.btnRegistarPago.Size = new System.Drawing.Size(98, 39);
            this.btnRegistarPago.TabIndex = 6;
            this.btnRegistarPago.Text = "Registar Pago";
            this.btnRegistarPago.UseVisualStyleBackColor = true;
            // 
            // txtboxMonto
            // 
            this.txtboxMonto.Location = new System.Drawing.Point(146, 79);
            this.txtboxMonto.Name = "txtboxMonto";
            this.txtboxMonto.Size = new System.Drawing.Size(200, 20);
            this.txtboxMonto.TabIndex = 5;
            // 
            // txtboxSaldoActual
            // 
            this.txtboxSaldoActual.Location = new System.Drawing.Point(146, 29);
            this.txtboxSaldoActual.Name = "txtboxSaldoActual";
            this.txtboxSaldoActual.Size = new System.Drawing.Size(200, 20);
            this.txtboxSaldoActual.TabIndex = 3;
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(39, 28);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(69, 13);
            this.lblSaldo.TabIndex = 2;
            this.lblSaldo.Text = "Saldo actual:";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(36, 82);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(40, 13);
            this.lblMonto.TabIndex = 1;
            this.lblMonto.Text = "Monto:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(36, 54);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(43, 13);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "Fecha :";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(695, 418);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(128, 42);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnVolveraEmpezar
            // 
            this.btnVolveraEmpezar.Location = new System.Drawing.Point(695, 353);
            this.btnVolveraEmpezar.Name = "btnVolveraEmpezar";
            this.btnVolveraEmpezar.Size = new System.Drawing.Size(128, 40);
            this.btnVolveraEmpezar.TabIndex = 4;
            this.btnVolveraEmpezar.Text = "Volver a Empezar";
            this.btnVolveraEmpezar.UseVisualStyleBackColor = true;
            // 
            // dgvInquilinos
            // 
            this.dgvInquilinos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInquilinos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            // frmRegistrarPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 492);
            this.Controls.Add(this.btnVolveraEmpezar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.grpboxPago);
            this.Controls.Add(this.grpboxUnidad);
            this.Controls.Add(this.grboxInquilino);
            this.Name = "frmRegistrarPago";
            this.Text = "frmRegistrarPago";
            this.grboxInquilino.ResumeLayout(false);
            this.grboxInquilino.PerformLayout();
            this.grpboxUnidad.ResumeLayout(false);
            this.grpboxUnidad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpboxPago.ResumeLayout(false);
            this.grpboxPago.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInquilinos)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox grpboxPago;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.TextBox txtboxMonto;
        private System.Windows.Forms.TextBox txtboxSaldoActual;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button btnRegistarPago;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnVolveraEmpezar;
        private System.Windows.Forms.DataGridView dgvInquilinos;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;

    }
}