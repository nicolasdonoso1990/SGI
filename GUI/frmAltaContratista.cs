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
using Negocio;

namespace GUI
{
    public partial class frmAltaContratista : Form
    {
        public frmAltaContratista()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            if (txtApellido.Text == "") 
            {
                txtApellido.BackColor = Color.Red;
            
            }
            if (txtDireccion.Text == "") 
            {
                txtDireccion.BackColor = Color.Red;
            }
            if (txtDisponibilidad.Text == "") 
            {
                txtDisponibilidad.BackColor = Color.Red;
            }
            if (txtNombre.Text == "") 
            {
                txtNombre.BackColor = Color.Red;
            }
            if (txtTelefono.Text == "") 
            {
                txtTelefono.BackColor = Color.Red;
            }

            if (txtApellido.Text != "" && txtDireccion.Text != "" && txtDisponibilidad.Text != "" && txtNombre.Text != "" && txtTelefono.Text != "")
            {
                lblErrorCompletar.Visible = false;
                //Instancio un contratista y se lo paso a la capa de Datos
                Contratista contratista = new Contratista();
                contratista.apellido = txtApellido.Text;
                contratista.direccion = txtDireccion.Text;
                contratista.disponibilidad = txtDireccion.Text;
                contratista.nombre = txtNombre.Text;
                contratista.telefono = txtTelefono.Text;

                ContratistaLogic contratistaLogic = new ContratistaLogic();

                contratistaLogic.altaContratista(contratista);
                MessageBox.Show("El contratista fue dado de alta con exito", "Alta Contratista");

                if (MessageBox.Show("¿Desea agregar otro Contratista?. Confirme", "Otro contratista", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    txtApellido.Text = "";
                    txtDireccion.Text = "";
                    txtDisponibilidad.Text = "";
                    txtNombre.Text = "";
                    txtTelefono.Text = "";


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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
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

        private void txtDisponibilidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtDisponibilidad.BackColor = Color.White;
        }

       

     

        
    }
}
