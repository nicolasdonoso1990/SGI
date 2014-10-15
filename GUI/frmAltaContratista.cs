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
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

     

        
    }
}
