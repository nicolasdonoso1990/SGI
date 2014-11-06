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
    public partial class frmAltaAdministrador : Form
    {

        public Administrador ad { get; set; }
        string usu;
        string contra;
      
        public frmAltaAdministrador(Administrador adm)
        {

            ad = adm;
            InitializeComponent();
            this.comprobar();

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if (txtContraAdmin.Text == "") 
            {
                txtContraAdmin.BackColor = Color.Red;
                lblErrorContra.Visible = true;

            
            }
            
            
            if (txtContraAdmin.Text == ad.contrasena) 
            {
                grpDatosAdmin.Enabled = true;
                lblErrorContra.Visible = false;
                txtContraAdmin.Visible = false;
                lblAclaracion.Visible = false;
                btnAceptar.Visible = false;
            
            
            }
            
           

          
            


        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            int usuBandera = 0;
            int contra1Bandera = 0;
            int contra2Bandera = 0;
            int tipoBandera = 0;

            if (cmbTipo.SelectedItem.ToString() == "Seleccione un tipo")
            {
                cmbTipo.BackColor = Color.Red;

            }
            else 
            {
                tipoBandera = 1;
            }



            if (txtUsuario.Text == "")
            {
                txtUsuario.BackColor = Color.Red;

            }
            else 
            {
                usuBandera = 1;
            }

            if (txtContraseña1.Text == "")
            {
                txtContraseña1.BackColor = Color.Red;

            }

            else 
            {
                contra1Bandera = 1;
            }

            if (txtContraseña2.Text == "")
            {
                txtContraseña2.BackColor = Color.Red;

            }

            else 
            {
                contra2Bandera = 1;
            
            }

            if (txtContraseña1.Text == txtContraseña2.Text && usuBandera == 1 && tipoBandera == 1 && contra1Bandera == 1 && contra2Bandera == 1)
            {



                usu = txtUsuario.Text;

                contra = txtContraseña1.Text;

                Administrador admin = new Administrador();
                admin.usuario = usu;
                admin.contrasena = contra;
                admin.estado = "habilitado";
                if (cmbTipo.Text == "SuperUsuario")
                {
                    admin.tipo = "super";

                }

                if (ad.tipo == "normal")
                {
                    admin.tipo = "normal";

                }

                AdministradorLogic adLog = new AdministradorLogic();
                adLog.AltaAdministrador(admin);

                MessageBox.Show("El Administrador fue dado de alta con exito", "Alta Administrador");


                if (MessageBox.Show("¿Desea agregar otro Administrador?. Confirme", "Otro inquilino", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    txtContraseña1.Clear();
                    txtContraseña2.Clear();
                    txtUsuario.Clear();
                    lblErrorCampos.Visible = false;
                }



            }
            else 
            {
                lblErrorCampos.Visible = true;
            }



        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


        public void comprobar() 
        {
            if (ad.tipo == "super") 
            {
                cmbTipo.Enabled = true;
            
            
            }
         //   if (ad.tipo == "normal") 
           // {

             //   comboBox1.SelectedItem = 1;
            
           // }
        
        
        }

        private void txtContraAdmin_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtContraAdmin.BackColor = Color.White;
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtUsuario.BackColor = Color.White;
        }

        private void txtContraseña1_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtContraseña1.BackColor = Color.White;
        }

        private void txtContraseña2_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtContraseña2.BackColor = Color.White;
        }


    }



}
