namespace GUI
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.grpIngreso = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbOpcion = new System.Windows.Forms.ComboBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblErrorCompletar = new System.Windows.Forms.Label();
            this.lblErrorInvalido = new System.Windows.Forms.Label();
            this.grpIngreso.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(612, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido al Sistema de Gestion Inmobiliaria";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.Image = global::GUI.Properties.Resources.log_in;
            this.btnIngresar.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnIngresar.Location = new System.Drawing.Point(144, 152);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(98, 40);
            this.btnIngresar.TabIndex = 4;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::GUI.Properties.Resources.salir;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.Location = new System.Drawing.Point(307, 358);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(64, 38);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.button2_Click);
            // 
            // grpIngreso
            // 
            this.grpIngreso.BackColor = System.Drawing.Color.Transparent;
            this.grpIngreso.Controls.Add(this.lblErrorInvalido);
            this.grpIngreso.Controls.Add(this.lblErrorCompletar);
            this.grpIngreso.Controls.Add(this.label2);
            this.grpIngreso.Controls.Add(this.cmbOpcion);
            this.grpIngreso.Controls.Add(this.txtContraseña);
            this.grpIngreso.Controls.Add(this.lblContraseña);
            this.grpIngreso.Controls.Add(this.btnIngresar);
            this.grpIngreso.Controls.Add(this.txtUsuario);
            this.grpIngreso.Controls.Add(this.lblUsuario);
            this.grpIngreso.Location = new System.Drawing.Point(143, 67);
            this.grpIngreso.Name = "grpIngreso";
            this.grpIngreso.Size = new System.Drawing.Size(361, 270);
            this.grpIngreso.TabIndex = 3;
            this.grpIngreso.TabStop = false;
            this.grpIngreso.Text = "Ingrese sus datos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tipo de Usuario:";
            // 
            // cmbOpcion
            // 
            this.cmbOpcion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOpcion.FormattingEnabled = true;
            this.cmbOpcion.Items.AddRange(new object[] {
            "Seleccione una opción",
            "Administrador",
            "SuperUsuario"});
            this.cmbOpcion.Location = new System.Drawing.Point(144, 35);
            this.cmbOpcion.Name = "cmbOpcion";
            this.cmbOpcion.Size = new System.Drawing.Size(172, 21);
            this.cmbOpcion.TabIndex = 1;
            this.cmbOpcion.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmbOpcion_MouseClick);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(144, 106);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(148, 20);
            this.txtContraseña.TabIndex = 3;
            this.txtContraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContraseña_KeyPress);
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(74, 109);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(64, 13);
            this.lblContraseña.TabIndex = 7;
            this.lblContraseña.Text = "Contraseña:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(144, 72);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(148, 20);
            this.txtUsuario.TabIndex = 2;
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(92, 75);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(46, 13);
            this.lblUsuario.TabIndex = 6;
            this.lblUsuario.Text = "Usuario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(622, 426);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "SGI V1.0";
            // 
            // lblErrorCompletar
            // 
            this.lblErrorCompletar.AutoSize = true;
            this.lblErrorCompletar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorCompletar.ForeColor = System.Drawing.Color.Red;
            this.lblErrorCompletar.Location = new System.Drawing.Point(6, 213);
            this.lblErrorCompletar.Name = "lblErrorCompletar";
            this.lblErrorCompletar.Size = new System.Drawing.Size(341, 13);
            this.lblErrorCompletar.TabIndex = 7;
            this.lblErrorCompletar.Text = "Error. Por favor complete los campos que aparecen  en rojo";
            this.lblErrorCompletar.Visible = false;
            // 
            // lblErrorInvalido
            // 
            this.lblErrorInvalido.AutoSize = true;
            this.lblErrorInvalido.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorInvalido.ForeColor = System.Drawing.Color.Red;
            this.lblErrorInvalido.Location = new System.Drawing.Point(92, 226);
            this.lblErrorInvalido.Name = "lblErrorInvalido";
            this.lblErrorInvalido.Size = new System.Drawing.Size(214, 13);
            this.lblErrorInvalido.TabIndex = 10;
            this.lblErrorInvalido.Text = "Error. Usuario o contraseña invalidos";
            this.lblErrorInvalido.Visible = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(684, 448);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grpIngreso);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Login";
            this.grpIngreso.ResumeLayout(false);
            this.grpIngreso.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox grpIngreso;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbOpcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblErrorCompletar;
        private System.Windows.Forms.Label lblErrorInvalido;
    }
}

