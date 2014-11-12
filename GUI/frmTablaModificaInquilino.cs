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
using System.Data.Entity;


namespace GUI
{
    public partial class frmTablaModificaInquilino : Form
    {

        public IEnumerable<Inquilino> ListaInquilinos { get; set; }



        public frmTablaModificaInquilino()
        {
            InitializeComponent();

            this.CompletarGrilla();
            this.lblErrorCompletar.Visible = false;
                


        }



        public void CompletarGrilla() 
        {


            dgvInquilinos.AutoGenerateColumns = false;
            InquilinoLogic InLog = new InquilinoLogic();

            ListaInquilinos = InLog.TodosInquilinos();
            dgvInquilinos.DataSource = ListaInquilinos;
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Int32 cantidadFilasSeleccionadas = dgvInquilinos.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (cantidadFilasSeleccionadas > 0) 
            {

                DataGridViewRow fila = dgvInquilinos.CurrentRow; //devuelve la fila que esta siendo seleccionada

                string dni =  fila.Cells[2].Value.ToString(); //el [2] indica la posicion del dni

                InquilinoLogic InLog = new InquilinoLogic();

                Inquilino inq = InLog.BuscaInquilino(dni);

                groupBox2.Enabled = true;

                txtApellido.Text = inq.apellido;
                txtContraseña.Text = inq.contrasena;
                txtDireccion.Text = inq.direccion;
                txtDni.Text = inq.dni;
                txtMail.Text = inq.e_mail;
                txtNombre.Text = inq.nombre;
                txtNumInq.Text = inq.nro_inquilino.ToString();
                txtTelefono.Text = inq.telefono;
                txtUsuario.Text = inq.usuario; 


                
              

                ListaInquilinos = InLog.TodosInquilinos();
                dgvInquilinos.DataSource = ListaInquilinos;

               



            }



        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {

            int a; //Variable a, a la cual asignada la comparación

            int cero = 0;
            string filtro = txtBusca.Text;

            if (cero != (a = String.Compare(txtBusca.Text, ""))) //Si la comparación da 0 no hay diferncias, por lo tanto el extbox está en blanco
            {
                InquilinoLogic inLog = new InquilinoLogic();
                ListaInquilinos = inLog.TodosInquilinos();

                List<Inquilino> listaFiltrada = (from inqui in ListaInquilinos
                                                 where inqui.dni.ToString().Contains(filtro)
                                                 select inqui).ToList();
                dgvInquilinos.DataSource = listaFiltrada;



            }

            else
            {
                this.CompletarGrilla();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Int32 cantidadFilasSeleccionadas = dgvInquilinos.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (cantidadFilasSeleccionadas > 0)
            {


                if (MessageBox.Show("¿Dar de baja inquilino?. Confirme", "Dar de baja inquilino", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    DataGridViewRow fila = dgvInquilinos.CurrentRow; //devuelve la fila que esta siendo seleccionada

                    string dni = fila.Cells[2].Value.ToString(); 
                    InquilinoLogic InLog = new InquilinoLogic();
                    InLog.BajaInquilino(dni);
                    MessageBox.Show("El inquilino fue dado de baja de forma exitosa.", "Dar de baja Inquilino");


                    List<Inquilino> ListaInquilinos = new List<Inquilino>();
                    ListaInquilinos = InLog.TodosInquilinos();
                    dgvInquilinos.DataSource = ListaInquilinos;


                }
                
                


                
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            
            //Empiezan las validaciones
             
             bool todolleno = true; // Si la variable se pone en False, falta llenar algo

            if (0 == string.Compare("",txtNombre.Text ))
            {
                txtNombre.BackColor = Color.Red;
                todolleno = false;
            }

            if (0 == string.Compare("",txtApellido.Text ))
            {
                txtApellido.BackColor = Color.Red;
                todolleno = false;
            }

            if (0 == string.Compare("",txtDireccion.Text ))
            {
                txtDireccion.BackColor = Color.Red;
                todolleno = false;
            }

            if (0 == string.Compare("", txtDni.Text))
            {
                txtDni.BackColor = Color.Red;
                todolleno = false;
            }

            if (txtTelefono.Text == "")
            {
                txtTelefono.BackColor = Color.Red;
                todolleno = false;
            }
           
            if (txtUsuario.Text != "" || txtContraseña.Text != "")
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
                lblErrorCompletar.Visible = false;

                /*Esto está buenísimo.
                 * Acá el gran Donoso pasa todo
                 * el contenido de los TextBox como
                 * un arrglo de strings. Seguro que anda más
                 * rápido que enviando un objeto.
                 * Gracias por tanta magia Nico. Yo me hubiera complicado
                 * muchísimo. Le doy a este código 4 Dijsktras.*/
                string[] datos = new string[10];
                datos[0] = txtNumInq.Text;
                datos[1] = txtNombre.Text;
                datos[2] = txtApellido.Text;
                datos[3] = txtContraseña.Text;
                datos[4] = txtDireccion.Text;
                datos[5] = txtDni.Text;
                datos[6] = txtMail.Text;
                datos[7] = txtTelefono.Text;
                datos[8] = txtUsuario.Text;

                InquilinoLogic InLog = new InquilinoLogic();

                InLog.ModificaInquilino(datos);

                MessageBox.Show("Los cambios fueron realizados con exito", "Modificacion de inquilino");


                List<Inquilino> ListaInquilinos = new List<Inquilino>();
                ListaInquilinos = InLog.TodosInquilinos();
                dgvInquilinos.DataSource = ListaInquilinos;

                txtApellido.Clear();
                txtContraseña.Clear();
                txtDireccion.Clear();
                txtDni.Clear();
                txtMail.Clear();
                txtNombre.Clear();
                txtTelefono.Clear();
                txtUsuario.Clear();
                txtNumInq.Clear();

            }

             else
             {
                 lblErrorCompletar.Visible = true;
             }


        }

        private void txtNumInq_KeyPress(object sender, KeyPressEventArgs e)
        {
            
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

