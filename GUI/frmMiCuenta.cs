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


    public partial class frmMiCuenta : Form
    {

        public Administrador adm{ get; set; }

        public frmMiCuenta(Administrador admin)
        {
            InitializeComponent();

            adm = admin;


            this.LLenarFormulario();
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            lblContra2.Visible = true;
            lblContra2.Enabled = true;

            txtContraseña2.Visible = true;
            txtContraseña2.Enabled = true;

            btnAceptar.Visible = true;
            btnAceptar.Enabled = true;

            btnModificar.Enabled = false;


        }


        public void LLenarFormulario() 
        {
            txtUsuario.Text = adm.usuario;
            txtContraseña.Text = adm.contrasena;
            txtNum.Text = adm.IDadmin.ToString();
            txtTipo.Text = adm.tipo;
        
        
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtContraseña2.Text == "") 
            {
                txtContraseña2.BackColor = Color.Red;
                lblError.Visible = true;
            
            }


            if (txtContraseña2.Text == txtContraseña.Text) 
            {
                txtUsuario.Enabled = true;
                txtContraseña.Enabled = true;
                lblError.Visible = false;
         
                btnAceptar.Enabled = false;
                btnRegistrar.Visible = true;

                txtContraseña2.Enabled = false;

                
                txtNum.Visible = false;
                txtTipo.Visible = false;
                txtContraseña2.Visible = false;
                lblContra2.Visible = false;
                lblNumero.Visible = false;
                lblTipoUsuario.Visible = false;




            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            int usuarioControl = 0;
            int contraseñaControl = 0;
            string[] datos = new string[4];

            if (txtUsuario.Text == "")
            {
                txtUsuario.BackColor = Color.Red;
            }
            else 
            {
                datos[3] = txtUsuario.Text;
                usuarioControl=1;

            }

            if (txtContraseña.Text == "")
            {
                txtContraseña.BackColor = Color.Red;

            }

            else 
            {
                datos[2] = txtContraseña.Text;
                contraseñaControl = 1;  
            
            }

            if (usuarioControl == 1 && contraseñaControl == 1)
            {

                datos[1] = txtTipo.Text;
                datos[0] = txtNum.Text;


                AdministradorLogic adLog = new AdministradorLogic();
                adLog.ModificaAdministrador(datos);
                lblError.Visible = false;
                lblExito.Visible = true;


            }
            else 
            {
                lblError.Visible = true;
            }
            
         
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose(); 
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtUsuario.BackColor = Color.White;
           
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtContraseña.BackColor = Color.White;
        }

        private void txtContraseña2_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtContraseña2.BackColor = Color.White;
        }

     

    }
}
