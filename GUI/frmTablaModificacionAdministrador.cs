using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Entidades;

namespace GUI
{
    public partial class frmTablaModificacionAdministrador : Form
    {

        public IEnumerable<Administrador> ListaAdministradores { get; set; }

        public Administrador administra { get; set; }

        public frmTablaModificacionAdministrador(Administrador admin)
        {
            InitializeComponent();


            administra = admin;

            this.RellenarGrilla();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Int32 cantidadFilasSeleccionadas = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (cantidadFilasSeleccionadas > 0)
            {

                DataGridViewRow fila = dataGridView1.CurrentRow; //devuelve la fila que esta siendo seleccionada

                string numero = fila.Cells[0].Value.ToString(); //el [2] indica la posicion del dni

                AdministradorLogic adLog = new AdministradorLogic();

                Administrador admin = adLog.BuscaAdministradorNumero(numero);

                groupBox2.Enabled = true;

                txtContraseña.Text = admin.contrasena;
                txtNum.Text = admin.IDadmin.ToString();
                txtUsuario.Text = admin.usuario;
                comboBox1.SelectedIndex = comboBox1.FindString(admin.tipo);





                ListaAdministradores = adLog.TodosAdministradores();
                dataGridView1.DataSource = ListaAdministradores;








            }

        }


        public void RellenarGrilla()
        {


            dataGridView1.AutoGenerateColumns = false;
            AdministradorLogic adLog = new AdministradorLogic();

          
            ListaAdministradores = adLog.TodosAdministradores();
            dataGridView1.DataSource = ListaAdministradores;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
             Int32 cantidadFilasSeleccionadas = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);

             if (cantidadFilasSeleccionadas > 0)
             {

                 if (MessageBox.Show("¿Esta seguro que desea dar de baja este administrador?. Confirme", "Baja Administrador", MessageBoxButtons.YesNo) == DialogResult.Yes)
                 {



                     DataGridViewRow fila = dataGridView1.CurrentRow; //devuelve la fila que esta siendo seleccionada

                     string numero = fila.Cells[0].Value.ToString(); //el [2] indica la posicion del dni

                     AdministradorLogic adLog = new AdministradorLogic();

                     adLog.BajaAdministrador(numero);

                     MessageBox.Show("El administrador fue dado de baja con exito", "Baja de administrador");
                     
                     ListaAdministradores = adLog.TodosAdministradores();
                     dataGridView1.DataSource = ListaAdministradores;
                 }

             }
           
           
           }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string[] datos = new string[4];
            datos[0] = txtNum.Text;
            datos[1] = comboBox1.SelectedItem.ToString();
            datos[2] = txtContraseña.Text;
            datos[3] = txtUsuario.Text;


            AdministradorLogic adLog = new AdministradorLogic();

            adLog.ModificaAdministrador(datos);
            MessageBox.Show("La modificacion fue realizada con exito", "Modificacion Inquilino");

            txtNum.Clear();
            txtContraseña.Clear();
            txtUsuario.Clear();

            ListaAdministradores = adLog.TodosAdministradores();
            dataGridView1.DataSource = ListaAdministradores;


        }

      

   


    }
}
