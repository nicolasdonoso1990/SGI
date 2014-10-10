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

                comboBox1.SelectedIndex = comboBox1.FindString(pro.ciudad.ToString());

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

            

        }

        private void btnRegistra_Click(object sender, EventArgs e)
        {
            string[] datos = new string[5];

            datos[0] = codigo.ToString();
            datos[1] = comboBox1.SelectedItem.ToString();
            datos[2] = txtDir.Text;
            datos[3] = txtMetro.Text;
            datos[4] = txtDescripcion.Text;


            PropiedadLogic proLog = new PropiedadLogic();

            proLog.ModificaPropiedad(datos);


            MessageBox.Show("Los cambios fueron realizados con exito", "Modificacion de Propiedad");

            txtDescripcion.Clear();
            txtDir.Clear();
            txtMetro.Clear();

            ListaPropiedades = proLog.todasPropiedades();
            dataGridView1.DataSource = ListaPropiedades;



        }




    }
}
