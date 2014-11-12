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
    public partial class frmTablaModificarPropiedad : Form
    {

        public Int32 codigo { get; set; }
        public IEnumerable<Propiedad> ListaPropiedades { get; set; }
        public frmTablaModificarPropiedad()
        {
            InitializeComponent();
            this.llenarGrilla();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("¿Esta seguro que desea dar de baja esa propiedad?. Confirme", "Baja propiedad", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                Int32 cantidadFilasSeleccionadas = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);

                if (cantidadFilasSeleccionadas > 0)
                {

                    DataGridViewRow fila = dataGridView1.CurrentRow; //devuelve la fila que esta siendo seleccionada

                    Int32 codigo = Convert.ToInt32(fila.Cells[0].Value.ToString());

                    PropiedadLogic propLog = new PropiedadLogic();

                    propLog.BajaPropiedad(codigo);


                    ListaPropiedades = propLog.todasPropiedades();
                    dataGridView1.DataSource = ListaPropiedades;


                }



            }
           

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       

        private void button1_Click(object sender, EventArgs e)
        {

            Int32 cantidadFilasSeleccionadas = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (cantidadFilasSeleccionadas > 0)
            {

                DataGridViewRow fila = dataGridView1.CurrentRow; //devuelve la fila que esta siendo seleccionada

                codigo = Convert.ToInt32(fila.Cells[0].Value.ToString());

                PropiedadLogic propLog = new PropiedadLogic();

                Propiedad pro = propLog.buscaPropiedad(codigo);

                groupBox2.Enabled = true;

                cmbCiudad.SelectedIndex = cmbCiudad.FindString(pro.ciudad.ToString());

                txtDir.Text = pro.direccion;
                txtDescripcion.Text = pro.descripcion;
                txtMetro.Text =  pro.m2.ToString();
                



                ListaPropiedades = propLog.todasPropiedades();
                dataGridView1.DataSource = ListaPropiedades;


            }
        }


        public void llenarGrilla()
        {
            
            
            
            dataGridView1.AutoGenerateColumns = false;

            PropiedadLogic propLog = new PropiedadLogic();

            

            ListaPropiedades = propLog.todasPropiedades();

            dataGridView1.DataSource = ListaPropiedades;

            cmbCiudad.SelectedIndex = 0;

        }

        private void btnRegistra_Click(object sender, EventArgs e)
        {
            string[] datos = new string[5];


            if (txtDir.Text == "")
            {
                txtDir.BackColor = Color.Red;
            }
            else 
            {
                datos[2] = txtDir.Text;
            }

            if (txtMetro.Text == "")
            {
                txtMetro.BackColor = Color.Red;
            }
            else 
            {
                datos[3] = txtMetro.Text;
            }

            if (cmbCiudad.SelectedItem.ToString() == "Seleccione una ciudad")
            {
                cmbCiudad.BackColor = Color.Red;
            }

            else 
            {
                datos[1] = cmbCiudad.SelectedItem.ToString();
            }

            if (txtDescripcion.Text == "")
            {
                txtDescripcion.BackColor = Color.Red;
            }

            else 
            {
                datos[4] = txtDescripcion.Text;
            }


            if (txtDescripcion.Text != "" && txtDir.Text != "" && txtMetro.Text != "" && cmbCiudad.SelectedItem.ToString() != "Seleccione una ciudad")
            {

                lblErrorCompletar.Visible = false;
                datos[0] = codigo.ToString();


                PropiedadLogic proLog = new PropiedadLogic();

                proLog.ModificaPropiedad(datos);


                MessageBox.Show("Los cambios fueron realizados con exito", "Modificacion de Propiedad");

                txtDescripcion.Clear();
                txtDir.Clear();
                txtMetro.Clear();

                ListaPropiedades = proLog.todasPropiedades();
                dataGridView1.DataSource = ListaPropiedades;





            }

            else 
            {
                lblErrorCompletar.Visible = true;
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtDescripcion.Text = "";
            txtMetro.Text = "";
            txtDir.Text = "";
            cmbCiudad.SelectedIndex = 0;
        }

        private void txtDir_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtDir.BackColor = Color.White;
        }

        private void txtMetro_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtMetro.BackColor = Color.White;
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtDescripcion.BackColor = Color.White;
        }

        private void cmbCiudad_MouseClick(object sender, MouseEventArgs e)
        {
            cmbCiudad.BackColor = Color.White;
        }




    }
}
