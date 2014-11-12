namespace GUI
{
    partial class frmAltaAdministrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAltaAdministrador));
            this.grpDatosAdmin = new System.Windows.Forms.GroupBox();
            this.lblErrorCampos = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.lblTipoUsuario = new System.Windows.Forms.Label();
            this.txtContraseña2 = new System.Windows.Forms.TextBox();
            this.txtContraseña1 = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblContraseña2 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblAclaracion = new System.Windows.Forms.Label();
            this.txtContraAdmin = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblErrorContra = new System.Windows.Forms.Label();
            this.lblContraIncorrecta = new System.Windows.Forms.Label();
            this.grpDatosAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDatosAdmin
            // 
            this.grpDatosAdmin.BackColor = System.Drawing.Color.Transparent;
            this.grpDatosAdmin.Controls.Add(this.lblErrorCampos);
            this.grpDatosAdmin.Controls.Add(this.cmbTipo);
            this.grpDatosAdmin.Controls.Add(this.lblTipoUsuario);
            this.grpDatosAdmin.Controls.Add(this.txtContraseña2);
            this.grpDatosAdmin.Controls.Add(this.txtContraseña1);
            this.grpDatosAdmin.Controls.Add(this.txtUsuario);
            this.grpDatosAdmin.Controls.Add(this.lblContraseña2);
            this.grpDatosAdmin.Controls.Add(this.btnRegistrar);
            this.grpDatosAdmin.Controls.Add(this.lblContraseña);
            this.grpDatosAdmin.Controls.Add(this.lblUsuario);
            this.grpDatosAdmin.Enabled = false;
            this.grpDatosAdmin.Location = new System.Drawing.Point(138, 116);
            this.grpDatosAdmin.Name = "grpDatosAdmin";
            this.grpDatosAdmin.Size = new System.Drawing.Size(329, 303);
            this.grpDatosAdmin.TabIndex = 0;
            this.grpDatosAdmin.TabStop = false;
            this.grpDatosAdmin.Text = "Ingrese datos del Nuevo Administrador";
            // 
            // lblErrorCampos
            // 
            this.lblErrorCampos.AutoSize = true;
            this.lblErrorCampos.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorCampos.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorCampos.ForeColor = System.Drawing.Color.Red;
            this.lblErrorCampos.Location = new System.Drawing.Point(24, 213);
            this.lblErrorCampos.Name = "lblErrorCampos";
            this.lblErrorCampos.Size = new System.Drawing.Size(260, 13);
            this.lblErrorCampos.TabIndex = 13;
            this.lblErrorCampos.Text = "Error. Por favor, complete los datos faltantes";
            this.lblErrorCampos.Visible = false;
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.Enabled = false;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Seleccione una opcion",
            "Administrador",
            "SuperUsuario"});
            this.cmbTipo.Location = new System.Drawing.Point(99, 47);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(178, 21);
            this.cmbTipo.TabIndex = 12;
            // 
            // lblTipoUsuario
            // 
            this.lblTipoUsuario.AutoSize = true;
            this.lblTipoUsuario.Location = new System.Drawing.Point(24, 50);
            this.lblTipoUsuario.Name = "lblTipoUsuario";
            this.lblTipoUsuario.Size = new System.Drawing.Size(70, 13);
            this.lblTipoUsuario.TabIndex = 11;
            this.lblTipoUsuario.Text = "Tipo Usuario:";
            // 
            // txtContraseña2
            // 
            this.txtContraseña2.Location = new System.Drawing.Point(145, 166);
            this.txtContraseña2.Name = "txtContraseña2";
            this.txtContraseña2.PasswordChar = '*';
            this.txtContraseña2.Size = new System.Drawing.Size(113, 20);
            this.txtContraseña2.TabIndex = 10;
            this.txtContraseña2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContraseña2_KeyPress);
            // 
            // txtContraseña1
            // 
            this.txtContraseña1.Location = new System.Drawing.Point(99, 125);
            this.txtContraseña1.Name = "txtContraseña1";
            this.txtContraseña1.PasswordChar = '*';
            this.txtContraseña1.Size = new System.Drawing.Size(113, 20);
            this.txtContraseña1.TabIndex = 9;
            this.txtContraseña1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContraseña1_KeyPress);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(99, 88);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(113, 20);
            this.txtUsuario.TabIndex = 6;
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);
            // 
            // lblContraseña2
            // 
            this.lblContraseña2.AutoSize = true;
            this.lblContraseña2.Location = new System.Drawing.Point(16, 169);
            this.lblContraseña2.Name = "lblContraseña2";
            this.lblContraseña2.Size = new System.Drawing.Size(126, 13);
            this.lblContraseña2.TabIndex = 8;
            this.lblContraseña2.Text = "Contraseña nuevamente:";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Image = global::GUI.Properties.Resources.ok;
            this.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrar.Location = new System.Drawing.Point(117, 248);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(95, 39);
            this.btnRegistrar.TabIndex = 4;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(30, 128);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(64, 13);
            this.lblContraseña.TabIndex = 7;
            this.lblContraseña.Text = "Contraseña:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(47, 91);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(46, 13);
            this.lblUsuario.TabIndex = 6;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblAclaracion
            // 
            this.lblAclaracion.AutoSize = true;
            this.lblAclaracion.BackColor = System.Drawing.Color.Transparent;
            this.lblAclaracion.Location = new System.Drawing.Point(12, 35);
            this.lblAclaracion.Name = "lblAclaracion";
            this.lblAclaracion.Size = new System.Drawing.Size(272, 13);
            this.lblAclaracion.TabIndex = 1;
            this.lblAclaracion.Text = "Por favor, vuelva a ingresar la contraseña de su cuenta:";
            // 
            // txtContraAdmin
            // 
            this.txtContraAdmin.Location = new System.Drawing.Point(297, 32);
            this.txtContraAdmin.Name = "txtContraAdmin";
            this.txtContraAdmin.PasswordChar = '*';
            this.txtContraAdmin.Size = new System.Drawing.Size(113, 20);
            this.txtContraAdmin.TabIndex = 2;
            this.txtContraAdmin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContraAdmin_KeyPress);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(435, 27);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(95, 28);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::GUI.Properties.Resources.cancelar;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(255, 438);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(95, 39);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(534, 499);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "SGI V1.0";
            // 
            // lblErrorContra
            // 
            this.lblErrorContra.AutoSize = true;
            this.lblErrorContra.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorContra.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorContra.ForeColor = System.Drawing.Color.Red;
            this.lblErrorContra.Location = new System.Drawing.Point(221, 76);
            this.lblErrorContra.Name = "lblErrorContra";
            this.lblErrorContra.Size = new System.Drawing.Size(258, 13);
            this.lblErrorContra.TabIndex = 12;
            this.lblErrorContra.Text = "Error. Por favor, complete con su contraseña";
            this.lblErrorContra.Visible = false;
            // 
            // lblContraIncorrecta
            // 
            this.lblContraIncorrecta.AutoSize = true;
            this.lblContraIncorrecta.BackColor = System.Drawing.Color.Transparent;
            this.lblContraIncorrecta.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraIncorrecta.ForeColor = System.Drawing.Color.Red;
            this.lblContraIncorrecta.Location = new System.Drawing.Point(280, 63);
            this.lblContraIncorrecta.Name = "lblContraIncorrecta";
            this.lblContraIncorrecta.Size = new System.Drawing.Size(167, 13);
            this.lblContraIncorrecta.TabIndex = 13;
            this.lblContraIncorrecta.Text = "Error. Contraseña incorrecta";
            this.lblContraIncorrecta.Visible = false;
            // 
            // frmAltaAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(586, 521);
            this.Controls.Add(this.lblContraIncorrecta);
            this.Controls.Add(this.lblErrorContra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtContraAdmin);
            this.Controls.Add(this.lblAclaracion);
            this.Controls.Add(this.grpDatosAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAltaAdministrador";
            this.Text = "Alta Administrador";
            this.grpDatosAdmin.ResumeLayout(false);
            this.grpDatosAdmin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDatosAdmin;
        private System.Windows.Forms.TextBox txtContraseña2;
        private System.Windows.Forms.TextBox txtContraseña1;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblContraseña2;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lblAclaracion;
        private System.Windows.Forms.TextBox txtContraAdmin;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label lblTipoUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblErrorContra;
        private System.Windows.Forms.Label lblErrorCampos;
        private System.Windows.Forms.Label lblContraIncorrecta;
    }
}