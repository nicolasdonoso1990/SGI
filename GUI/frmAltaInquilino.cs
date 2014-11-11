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
            //Empiezan las Validaciones

            string mensaje = "";   // Si se llena el mensaje es porque hay algún campo imortante en blanco

            if (0 == string.Compare("",txtNombre.Text ))
            {
                mensaje = mensaje + "Nombre\n";
            }

            if (0 == string.Compare("",txtApellido.Text ))
            {
                mensaje = mensaje + "Apellido\n";
            }

            if (0 == string.Compare("",txtDireccion.Text ))
            {
                mensaje = mensaje + "Dirección\n";
            }

            if (0 == string.Compare("", txtdni.Text))
            {
                mensaje = mensaje + "DNI\n";
            }

            if (txtUsuario.Enabled==true)
            {
                        if (0 == string.Compare("",txtUsuario.Text ))
                 {
                        mensaje=mensaje+"Usuario\n";
                 }
                     if (0 == string.Compare("", txtContraseña.Text))
                 {
                     mensaje=mensaje+"Contraseña\n";
                   }

            }

            if (0 != string.Compare("", mensaje))
            {
                MessageBox.Show("Los siguientes campos faltan ser rellenados:\n" + mensaje, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                Inquilino inq = new Inquilino();
                inq.apellido = txtApellido.Text;
                inq.direccion = txtDireccion.Text;
                inq.dni = txtdni.Text;
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
                    txtdni.Clear();
                    txtMail.Clear();
                    txtNombre.Clear();
                    txtTelefono.Clear();
                    txtUsuario.Clear();

                    check1.CheckState = 0;
                    check2.CheckState = 0;
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
}
