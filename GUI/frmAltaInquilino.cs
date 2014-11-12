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
            if (this.chckEmail.Checked == true)
            {
                this.txtMail.Enabled = true;
            }
            else
            {
                this.txtMail.Enabled = false;
            }
            
        }

        private void check2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkUsuario.Checked == true)
            {
                this.txtUsuario.Enabled = true;
                this.txtContraseña.Enabled = true;
            }
            else
            {
                this.txtUsuario.Enabled = false;
                this.txtContraseña.Enabled = false;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool todolleno = true;
            if (txtNombre.Text == "") 
            {
                txtNombre.BackColor = Color.Red;
                todolleno = false;
            }
            
            
            if (txtApellido.Text == "")
            {
                txtApellido.BackColor = Color.Red;
                todolleno = false;
            }

            if (txtDireccion.Text == "")
            {
                txtDireccion.BackColor = Color.Red;
                todolleno = false;
            }
            if (txtDni.Text == "")
            {
                txtDni.BackColor = Color.Red;
                todolleno = false;
            }
            if (txtMail.Enabled == true)
            {
                if (txtMail.Text == "")
                {
                    txtMail.BackColor = Color.Red;
                    todolleno = false;
                }
            }
            if (txtTelefono.Text == "")
            {
                txtTelefono.BackColor = Color.Red;
                todolleno = false;
            }
            if (txtUsuario.Enabled == true)
            {

                if (txtUsuario.Text == "")
                {
                    txtUsuario.BackColor = Color.Red;
                    todolleno = false;
                }

                if (txtContraseña.Text == "")
                {
                    txtContraseña.BackColor = Color.Red;
                    todolleno = false;
                }

            }

        

                if (todolleno==true)
                {
                    Inquilino inq = new Inquilino();
                    inq.apellido = txtApellido.Text;
                    inq.direccion = txtDireccion.Text;
                    inq.dni = txtDni.Text;
                    inq.nombre = txtNombre.Text;
                    inq.telefono = txtTelefono.Text;
                    inq.estado = "habilitado";
                    if (txtUsuario.Enabled == true)
                    {
                        inq.contrasena = txtContraseña.Text;
                        inq.usuario = txtUsuario.Text;
                    }
                   
                    if (txtMail.Enabled == true)
                    {
                        inq.e_mail = txtMail.Text;
                    }

                    InquilinoLogic InLog = new InquilinoLogic();

                    InLog.AltaInquilino(inq);
                    MessageBox.Show("El Inquilino fue dado de alta con exito", "Alta Inquilino");

                    lblErrorCompletar.Visible = false;

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

                        chckEmail.CheckState = 0;
                        chkUsuario.CheckState = 0;
                        txtMail.Enabled = false;
                        txtUsuario.Enabled = false;
                        txtContraseña.Enabled = false;
                        lblErrorCompletar.Visible = false;


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
