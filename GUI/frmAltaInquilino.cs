using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using System.Data.Entity;
using Negocio;


namespace GUI
{
    public partial class frmAltaInquilino : Form
    {
        public frmAltaInquilino()
        {
            InitializeComponent();
        }

        private void check1_CheckedChanged(object sender, EventArgs e)
        {
            this.txtMail.Enabled = true;
        }

        private void check2_CheckedChanged(object sender, EventArgs e)
        {
            this.txtUsuario.Enabled = true;
            this.txtContraseña.Enabled = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "") 
            {
                txtNombre.BackColor = Color.Red;
            }
            
            
            if (txtApellido.Text == "")
            {
                txtApellido.BackColor = Color.Red;
            }

            if (txtDireccion.Text == "")
            {
                txtDireccion.BackColor = Color.Red;
            }
            if (txtDni.Text == "")
            {
                txtDni.BackColor = Color.Red;
            }
            if (txtMail.Text == "")
            {
                txtMail.BackColor = Color.Red;
            }
            if (txtTelefono.Text == "")
            {
                txtTelefono.BackColor = Color.Red;
            }
            if (chkUsuario.Enabled == true)
            {

                if (txtUsuario.Text == "")
                {
                    txtUsuario.BackColor = Color.Red;
                }

                if (txtContraseña.Text == "")
                {
                    txtContraseña.BackColor = Color.Red;
                }

            }

            if (chkUsuario.Enabled == true)
            {

                if (txtApellido.Text != "" && txtDireccion.Text != "" && txtDni.Text != "" && txtMail.Text != "" && txtNombre.Text != "" && txtTelefono.Text != "" && txtUsuario.Text != "" && txtContraseña.Text != "")
                {
                    Inquilino inq = new Inquilino();
                    inq.apellido = txtApellido.Text;
                    inq.direccion = txtDireccion.Text;
                    inq.dni = txtDni.Text;
                    inq.nombre = txtNombre.Text;
                    inq.telefono = txtTelefono.Text;
                    inq.contrasena = "";
                    inq.e_mail = "";
                    inq.usuario = "";
                    inq.estado = "habilitado";
                    if (txtMail.Enabled == true)
                    {
                        inq.e_mail = txtMail.Text;
                    }

                    if (txtUsuario.Enabled == true)
                    {
                        inq.usuario = txtUsuario.Text;
                        inq.contrasena = txtContraseña.Text;

                    }

                    InquilinoLogic InLog = new InquilinoLogic();

                    InLog.AltaInquilino(inq);
                    MessageBox.Show("El Administrador fue dado de alta con exito", "Alta Administrador");



                    if (MessageBox.Show("¿Desea agregar otro inquilino?. Confirme", "Otro inquilino", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        txtApellido.Clear();
                        txtContraseña.Clear();
                        txtDireccion.Clear();
                        txtDni.Clear();
                        txtMail.Clear();
                        txtNombre.Clear();
                        txtTelefono.Clear();
                        txtUsuario.Clear();

                        check1.CheckState = 0;
                        chkUsuario.CheckState = 0;
                        txtMail.Enabled = false;
                        txtUsuario.Enabled = false;
                        txtContraseña.Enabled = false;


                    }
                    else
                    {
                        this.Dispose();
                    }


                }
                else
                {
                    lblErrorCompletar.Visible = true;
                }









            }
            else 
            {
            
                 if (txtApellido.Text != "" && txtDireccion.Text != "" && txtDni.Text != "" && txtMail.Text != "" && txtNombre.Text != "" && txtTelefono.Text != "")
                    {
                        Inquilino inq = new Inquilino();
                        inq.apellido = txtApellido.Text;
                        inq.direccion = txtDireccion.Text;
                        inq.dni = txtDni.Text;
                        inq.nombre = txtNombre.Text;
                        inq.telefono = txtTelefono.Text;
                        inq.contrasena = "";
                        inq.e_mail = "";
                        inq.usuario = "";
                        inq.estado = "habilitado";
                        if (txtMail.Enabled == true)
                        {
                            inq.e_mail = txtMail.Text;
                        }

                        if (txtUsuario.Enabled == true)
                        {
                            inq.usuario = txtUsuario.Text;
                            inq.contrasena = txtContraseña.Text;

                        }

                        InquilinoLogic InLog = new InquilinoLogic();

                        InLog.AltaInquilino(inq);
                        MessageBox.Show("El Administrador fue dado de alta con exito", "Alta Administrador");



                        if (MessageBox.Show("¿Desea agregar otro inquilino?. Confirme", "Otro inquilino", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            txtApellido.Clear();
                            txtContraseña.Clear();
                            txtDireccion.Clear();
                            txtDni.Clear();
                            txtMail.Clear();
                            txtNombre.Clear();
                            txtTelefono.Clear();
                            txtUsuario.Clear();

                            check1.CheckState = 0;
                            chkUsuario.CheckState = 0;
                            txtMail.Enabled = false;
                            txtUsuario.Enabled = false;
                            txtContraseña.Enabled = false;


                        }
                        else
                        {
                            this.Dispose();
                        }

                    }



                }

            
            
            
            
            }
        

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtNombre.BackColor = Color.White;
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtApellido.BackColor = Color.White;
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtDireccion.BackColor = Color.White;
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtTelefono.BackColor = Color.White;
        }

        private void txtMail_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtMail.BackColor = Color.White;
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtDni.BackColor = Color.White;
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtUsuario.BackColor = Color.White;
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtContraseña.BackColor = Color.White;
        }
    }
}
