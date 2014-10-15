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
            if (txtContraseña2.Text == txtContraseña.Text) 
            {
                txtUsuario.Enabled = true;
                txtContraseña.Enabled = true;
              
         
                btnAceptar.Enabled = false;
                btnRegistrar.Visible = true;

                txtContraseña2.Enabled = false;
            
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string[] datos=new string[4];
            datos[0] = txtNum.Text;
            datos[1] = txtTipo.Text;
            datos[2] = txtContraseña.Text;
            datos[3] = txtUsuario.Text;

            AdministradorLogic adLog = new AdministradorLogic();
            adLog.ModificaAdministrador(datos);

        }

     

    }
}
