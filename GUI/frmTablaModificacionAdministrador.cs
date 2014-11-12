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
                lblErrorTabla.Visible = false;
                DataGridViewRow fila = dataGridView1.CurrentRow; //devuelve la fila que esta siendo seleccionada

                string numero = fila.Cells[0].Value.ToString(); //el [2] indica la posicion del dni

                AdministradorLogic adLog = new AdministradorLogic();

                Administrador admin = adLog.BuscaAdministradorNumero(numero);

                groupBox2.Enabled = true;

                txtContraseña.Text = admin.contrasena;
                txtNum.Text = admin.IDadmin.ToString();
                txtUsuario.Text = admin.usuario;
                cmbTipo.SelectedIndex = cmbTipo.FindString(admin.tipo);





                ListaAdministradores = adLog.TodosAdministradores();
                dataGridView1.DataSource = ListaAdministradores;








            }
            else 
            {
                lblErrorTabla.Visible = true;
            
            
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
            int usuBandera = 0;
            int contraBandera = 0;
            int tipoBandera = 0;



            if (txtUsuario.Text == "")
            {
                txtUsuario.BackColor = Color.Red;

            }
            else 
            {
                datos[3] = txtUsuario.Text;
                usuBandera = 1;
            }



            if (txtContraseña.Text == "")
            {
                txtContraseña.BackColor = Color.White;
                
            }
            else 
            {
                datos[2] = txtContraseña.Text;
                contraBandera = 1;
            }



            if (cmbTipo.SelectedItem.ToString() == "Seleccione un tipo")
            {
                cmbTipo.BackColor = Color.Red;

            }
            else 
            {
                datos[1] = cmbTipo.SelectedItem.ToString();
                tipoBandera = 1;
            }


            if (usuBandera == 1 && contraBandera == 1 && tipoBandera == 1)
            {
                datos[0] = txtNum.Text;


                AdministradorLogic adLog = new AdministradorLogic();

                adLog.ModificaAdministrador(datos);
                MessageBox.Show("La modificacion fue realizada con exito", "Modificacion Inquilino");

                txtNum.Clear();
                txtContraseña.Clear();
                txtUsuario.Clear();

                ListaAdministradores = adLog.TodosAdministradores();
                dataGridView1.DataSource = ListaAdministradores;



            }
            else 
            {
                lblErrorCampos.Visible = true;
            
            }
       
           
            


            
            
            
            
            

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNum.Text = "";
            txtContraseña.Text = "";
            txtUsuario.Text = "";
            cmbTipo.SelectedIndex = 0;
        }

      

   


    }
}
