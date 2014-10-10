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
    public partial class frmAltaPropiedad : Form
    {
        public frmAltaPropiedad()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtCiudad_Click(object sender, EventArgs e)
        {

        }

        private void frmAltaPropiedad_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistra_Click(object sender, EventArgs e)
        {


            Propiedad prop = new Propiedad();
            prop.ciudad = comboBox1.Text;
            prop.direccion = txtDireccion.Text;
            prop.m2 = Double.Parse(txtMetro.Text);
            prop.descripcion = txtDescripcion.Text;
            prop.estado = "habilitado";

            PropiedadLogic propLog = new PropiedadLogic();

            propLog.altaPropiedad(prop);


            MessageBox.Show("La propiedad fue dada de alta con exito", "Alta Propiedad");



            if (MessageBox.Show("¿Desea agregar otra Propiedad?. Confirme", "Otra Propiedad", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                txtDescripcion.Clear();
                txtDireccion.Clear();
                txtMetro.Clear();


            }
            else
            {
                this.Dispose();
            }

            

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

   
    }
}
