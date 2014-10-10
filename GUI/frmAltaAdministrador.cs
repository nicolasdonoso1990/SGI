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
        public frmAltaAdministrador(Administrador adm)
        {

            ad = adm;
            InitializeComponent();
            this.comprobar();

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtContraAdmin.Text == ad.contrasena) 
            {
                groupBox1.Enabled = true;

            
            
            }
            
           

          
            


        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            
            if (txtContraseña1.Text == txtContraseña2.Text) 
            {


                string usu = txtUsuario.Text;

                string contra = txtContraseña1.Text;

                Administrador admin = new Administrador();
                admin.usuario=usu;
                admin.contrasena=contra;
                admin.estado = "habilitado";
                if (comboBox1.Text == "SuperUsuario") 
                {
                    admin.tipo = "super";
                
                }

                if (ad.tipo=="normal") 
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

                }



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
                comboBox1.Enabled = true;
            
            
            }
         //   if (ad.tipo == "normal") 
           // {

             //   comboBox1.SelectedItem = 1;
            
           // }
        
        
        }


    }



}
