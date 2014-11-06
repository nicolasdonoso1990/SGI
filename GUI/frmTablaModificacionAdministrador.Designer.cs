namespace GUI
{
    partial class frmTablaModificacionAdministrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTablaModificacionAdministrador));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nroAdmin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.lblAclaracion = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.lblTipoUsuario = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.inmobiliariaDataSet1 = new GUI.InmobiliariaDataSet();
            this.lblErrorTabla = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblErrorCampos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inmobiliariaDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(761, 513);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SGI V1.0";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nroAdmin,
            this.usuario});
            this.dataGridView1.Location = new System.Drawing.Point(42, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(244, 195);
            this.dataGridView1.TabIndex = 1;
            // 
            // nroAdmin
            // 
            this.nroAdmin.DataPropertyName = "IDadmin";
            this.nroAdmin.HeaderText = "Numero";
            this.nroAdmin.Name = "nroAdmin";
            // 
            // usuario
            // 
            this.usuario.DataPropertyName = "usuario";
            this.usuario.HeaderText = "Usuario";
            this.usuario.Name = "usuario";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblErrorTabla);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.txtBusca);
            this.groupBox1.Controls.Add(this.lblAclaracion);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(24, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 390);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione Administrador";
            // 
            // button3
            // 
            this.button3.Image = global::GUI.Properties.Resources.eliminar;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(258, 291);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 31);
            this.button3.TabIndex = 7;
            this.button3.Text = "Eliminar";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtBusca
            // 
            this.txtBusca.Location = new System.Drawing.Point(131, 30);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(170, 20);
            this.txtBusca.TabIndex = 6;
            // 
            // lblAclaracion
            // 
            this.lblAclaracion.AutoSize = true;
            this.lblAclaracion.Location = new System.Drawing.Point(28, 33);
            this.lblAclaracion.Name = "lblAclaracion";
            this.lblAclaracion.Size = new System.Drawing.Size(82, 13);
            this.lblAclaracion.TabIndex = 5;
            this.lblAclaracion.Text = "Ingrese usuario:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "Seleccionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Image = global::GUI.Properties.Resources.cancelar;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(55, 464);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 40);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cancelar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.lblErrorCampos);
            this.groupBox2.Controls.Add(this.btnLimpiar);
            this.groupBox2.Controls.Add(this.txtNum);
            this.groupBox2.Controls.Add(this.lblNumero);
            this.groupBox2.Controls.Add(this.cmbTipo);
            this.groupBox2.Controls.Add(this.lblTipoUsuario);
            this.groupBox2.Controls.Add(this.txtContraseña);
            this.groupBox2.Controls.Add(this.lblContraseña);
            this.groupBox2.Controls.Add(this.txtUsuario);
            this.groupBox2.Controls.Add(this.btnRegistrar);
            this.groupBox2.Controls.Add(this.lblUsuario);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(489, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(285, 291);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ingrese datos a modificar";
            // 
            // txtNum
            // 
            this.txtNum.Enabled = false;
            this.txtNum.Location = new System.Drawing.Point(114, 43);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(38, 20);
            this.txtNum.TabIndex = 8;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(35, 46);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(79, 13);
            this.lblNumero.TabIndex = 7;
            this.lblNumero.Text = "Numero Admin:";
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Seleccione un tipo",
            "Administrador",
            "SuperUsuario"});
            this.cmbTipo.Location = new System.Drawing.Point(114, 77);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(121, 21);
            this.cmbTipo.TabIndex = 6;
            // 
            // lblTipoUsuario
            // 
            this.lblTipoUsuario.AutoSize = true;
            this.lblTipoUsuario.Location = new System.Drawing.Point(44, 80);
            this.lblTipoUsuario.Name = "lblTipoUsuario";
            this.lblTipoUsuario.Size = new System.Drawing.Size(70, 13);
            this.lblTipoUsuario.TabIndex = 5;
            this.lblTipoUsuario.Text = "Tipo Usuario:";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(114, 147);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(97, 20);
            this.txtContraseña.TabIndex = 4;
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(44, 150);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(64, 13);
            this.lblContraseña.TabIndex = 3;
            this.lblContraseña.Text = "Contraseña:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(114, 113);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(97, 20);
            this.txtUsuario.TabIndex = 3;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Image = global::GUI.Properties.Resources.editar;
            this.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrar.Location = new System.Drawing.Point(166, 235);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(85, 37);
            this.btnRegistrar.TabIndex = 1;
            this.btnRegistrar.Text = "Modificar";
            this.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(62, 116);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(46, 13);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "Usuario:";
            // 
            // inmobiliariaDataSet1
            // 
            this.inmobiliariaDataSet1.DataSetName = "InmobiliariaDataSet";
            this.inmobiliariaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblErrorTabla
            // 
            this.lblErrorTabla.AutoSize = true;
            this.lblErrorTabla.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorTabla.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorTabla.ForeColor = System.Drawing.Color.Red;
            this.lblErrorTabla.Location = new System.Drawing.Point(39, 352);
            this.lblErrorTabla.Name = "lblErrorTabla";
            this.lblErrorTabla.Size = new System.Drawing.Size(294, 13);
            this.lblErrorTabla.TabIndex = 14;
            this.lblErrorTabla.Text = "Error. Por favor, seleccione un elemento de la tabla";
            this.lblErrorTabla.Visible = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Image = global::GUI.Properties.Resources.limpiar;
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.Location = new System.Drawing.Point(47, 235);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(85, 37);
            this.btnLimpiar.TabIndex = 15;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblErrorCampos
            // 
            this.lblErrorCampos.AutoSize = true;
            this.lblErrorCampos.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorCampos.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorCampos.ForeColor = System.Drawing.Color.Red;
            this.lblErrorCampos.Location = new System.Drawing.Point(61, 196);
            this.lblErrorCampos.Name = "lblErrorCampos";
            this.lblErrorCampos.Size = new System.Drawing.Size(190, 13);
            this.lblErrorCampos.TabIndex = 15;
            this.lblErrorCampos.Text = "Error. Complete campos faltante";
            this.lblErrorCampos.Visible = false;
            // 
            // frmTablaModificacionAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(823, 535);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTablaModificacionAdministrador";
            this.Text = "Modificacion Administrador";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inmobiliariaDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.Label lblAclaracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroAdmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label lblTipoUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lblUsuario;
        private InmobiliariaDataSet inmobiliariaDataSet1;
        private System.Windows.Forms.Label lblErrorTabla;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblErrorCampos;
    }
}