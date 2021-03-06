﻿namespace GUI
{
    partial class frmAltaUnidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAltaUnidad));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblErrorCampos = new System.Windows.Forms.Label();
            this.chkFotos = new System.Windows.Forms.CheckBox();
            this.lblFotos = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblMetro = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnFoto4 = new System.Windows.Forms.Button();
            this.btnFoto3 = new System.Windows.Forms.Button();
            this.btnFoto2 = new System.Windows.Forms.Button();
            this.foto4 = new System.Windows.Forms.PictureBox();
            this.foto3 = new System.Windows.Forms.PictureBox();
            this.foto2 = new System.Windows.Forms.PictureBox();
            this.foto1 = new System.Windows.Forms.PictureBox();
            this.btnFoto1 = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMetro = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foto4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foto3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foto2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foto1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(this.lblDireccion);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(625, 308);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Propiedades";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(411, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 29);
            this.button1.TabIndex = 9;
            this.button1.Text = "Nueva Propiedad";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(77, 250);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 29);
            this.button3.TabIndex = 8;
            this.button3.Text = "Seleccionar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
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
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.txtMetro);
            this.groupBox2.Controls.Add(this.lblErrorCampos);
            this.groupBox2.Controls.Add(this.chkFotos);
            this.groupBox2.Controls.Add(this.lblFotos);
            this.groupBox2.Controls.Add(this.txtCodigo);
            this.groupBox2.Controls.Add(this.lblCodigo);
            this.groupBox2.Controls.Add(this.btnAceptar);
            this.groupBox2.Controls.Add(this.txtDescripcion);
            this.groupBox2.Controls.Add(this.lblDescripcion);
            this.groupBox2.Controls.Add(this.lblMetro);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(660, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(435, 376);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Unidad";
            // 
            // lblErrorCampos
            // 
            this.lblErrorCampos.AutoSize = true;
            this.lblErrorCampos.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorCampos.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorCampos.ForeColor = System.Drawing.Color.Red;
            this.lblErrorCampos.Location = new System.Drawing.Point(101, 294);
            this.lblErrorCampos.Name = "lblErrorCampos";
            this.lblErrorCampos.Size = new System.Drawing.Size(260, 13);
            this.lblErrorCampos.TabIndex = 14;
            this.lblErrorCampos.Text = "Error. Por favor, complete los datos faltantes";
            this.lblErrorCampos.Visible = false;
            // 
            // chkFotos
            // 
            this.chkFotos.AutoSize = true;
            this.chkFotos.Location = new System.Drawing.Point(127, 260);
            this.chkFotos.Name = "chkFotos";
            this.chkFotos.Size = new System.Drawing.Size(52, 17);
            this.chkFotos.TabIndex = 12;
            this.chkFotos.Text = "Fotos";
            this.chkFotos.UseVisualStyleBackColor = true;
            // 
            // lblFotos
            // 
            this.lblFotos.AutoSize = true;
            this.lblFotos.Location = new System.Drawing.Point(6, 261);
            this.lblFotos.Name = "lblFotos";
            this.lblFotos.Size = new System.Drawing.Size(115, 13);
            this.lblFotos.TabIndex = 11;
            this.lblFotos.Text = "¿Desea agregar fotos?";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(122, 33);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(222, 20);
            this.txtCodigo.TabIndex = 10;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(22, 36);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(94, 13);
            this.lblCodigo.TabIndex = 9;
            this.lblCodigo.Text = "Codigo Propiedad:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(210, 330);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(87, 31);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnRegistra_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(122, 112);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(222, 110);
            this.txtDescripcion.TabIndex = 7;
            this.txtDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescripcion_KeyPress);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(50, 112);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 3;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // lblMetro
            // 
            this.lblMetro.AutoSize = true;
            this.lblMetro.Location = new System.Drawing.Point(20, 77);
            this.lblMetro.Name = "lblMetro";
            this.lblMetro.Size = new System.Drawing.Size(96, 13);
            this.lblMetro.TabIndex = 2;
            this.lblMetro.Text = "Metros Cuadrados:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.btnFoto4);
            this.groupBox3.Controls.Add(this.btnFoto3);
            this.groupBox3.Controls.Add(this.btnFoto2);
            this.groupBox3.Controls.Add(this.foto4);
            this.groupBox3.Controls.Add(this.foto3);
            this.groupBox3.Controls.Add(this.foto2);
            this.groupBox3.Controls.Add(this.foto1);
            this.groupBox3.Controls.Add(this.btnFoto1);
            this.groupBox3.Enabled = false;
            this.groupBox3.Location = new System.Drawing.Point(31, 398);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1064, 149);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Fotos";
            // 
            // btnFoto4
            // 
            this.btnFoto4.Location = new System.Drawing.Point(839, 122);
            this.btnFoto4.Name = "btnFoto4";
            this.btnFoto4.Size = new System.Drawing.Size(64, 22);
            this.btnFoto4.TabIndex = 16;
            this.btnFoto4.Text = "Cargar";
            this.btnFoto4.UseVisualStyleBackColor = true;
            this.btnFoto4.Click += new System.EventHandler(this.btnFoto4_Click);
            // 
            // btnFoto3
            // 
            this.btnFoto3.Location = new System.Drawing.Point(587, 121);
            this.btnFoto3.Name = "btnFoto3";
            this.btnFoto3.Size = new System.Drawing.Size(60, 22);
            this.btnFoto3.TabIndex = 15;
            this.btnFoto3.Text = "Cargar";
            this.btnFoto3.UseVisualStyleBackColor = true;
            this.btnFoto3.Click += new System.EventHandler(this.btnFoto3_Click);
            // 
            // btnFoto2
            // 
            this.btnFoto2.Location = new System.Drawing.Point(349, 121);
            this.btnFoto2.Name = "btnFoto2";
            this.btnFoto2.Size = new System.Drawing.Size(59, 22);
            this.btnFoto2.TabIndex = 14;
            this.btnFoto2.Text = "Cargar";
            this.btnFoto2.UseVisualStyleBackColor = true;
            this.btnFoto2.Click += new System.EventHandler(this.btnFoto2_Click);
            // 
            // foto4
            // 
            this.foto4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.foto4.Location = new System.Drawing.Point(775, 29);
            this.foto4.Name = "foto4";
            this.foto4.Size = new System.Drawing.Size(156, 87);
            this.foto4.TabIndex = 13;
            this.foto4.TabStop = false;
            // 
            // foto3
            // 
            this.foto3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.foto3.Location = new System.Drawing.Point(532, 29);
            this.foto3.Name = "foto3";
            this.foto3.Size = new System.Drawing.Size(156, 87);
            this.foto3.TabIndex = 12;
            this.foto3.TabStop = false;
            // 
            // foto2
            // 
            this.foto2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.foto2.Location = new System.Drawing.Point(295, 29);
            this.foto2.Name = "foto2";
            this.foto2.Size = new System.Drawing.Size(156, 87);
            this.foto2.TabIndex = 11;
            this.foto2.TabStop = false;
            // 
            // foto1
            // 
            this.foto1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.foto1.Location = new System.Drawing.Point(32, 29);
            this.foto1.Name = "foto1";
            this.foto1.Size = new System.Drawing.Size(156, 87);
            this.foto1.TabIndex = 10;
            this.foto1.TabStop = false;
            // 
            // btnFoto1
            // 
            this.btnFoto1.Location = new System.Drawing.Point(81, 121);
            this.btnFoto1.Name = "btnFoto1";
            this.btnFoto1.Size = new System.Drawing.Size(55, 22);
            this.btnFoto1.TabIndex = 9;
            this.btnFoto1.Text = "Cargar";
            this.btnFoto1.UseVisualStyleBackColor = true;
            this.btnFoto1.Click += new System.EventHandler(this.btnFoto1_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Image = global::GUI.Properties.Resources.ok;
            this.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrar.Location = new System.Drawing.Point(839, 597);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(95, 42);
            this.btnRegistrar.TabIndex = 17;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::GUI.Properties.Resources.cancelar;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(72, 597);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(95, 42);
            this.btnSalir.TabIndex = 18;
            this.btnSalir.Text = "C ancelar";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(1052, 651);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "SGI V1.0";
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
            this.descripcion.DataPropertyName = "descripcion";
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // txtMetro
            // 
            this.txtMetro.Location = new System.Drawing.Point(122, 74);
            this.txtMetro.Mask = "99999";
            this.txtMetro.Name = "txtMetro";
            this.txtMetro.Size = new System.Drawing.Size(100, 20);
            this.txtMetro.TabIndex = 15;
            this.txtMetro.ValidatingType = typeof(int);
            this.txtMetro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMetro_KeyPress_1);
            // 
            // frmAltaUnidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(1114, 673);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAltaUnidad";
            this.Text = "Alta Unidad";
            this.Load += new System.EventHandler(this.frmAltaUnidad_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.foto4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foto3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foto2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foto1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblMetro;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox foto4;
        private System.Windows.Forms.PictureBox foto3;
        private System.Windows.Forms.PictureBox foto2;
        private System.Windows.Forms.PictureBox foto1;
        private System.Windows.Forms.Button btnFoto1;
        private System.Windows.Forms.Button btnFoto4;
        private System.Windows.Forms.Button btnFoto3;
        private System.Windows.Forms.Button btnFoto2;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkFotos;
        private System.Windows.Forms.Label lblFotos;
        private System.Windows.Forms.Label lblErrorCampos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn metros;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.MaskedTextBox txtMetro;
    }
}