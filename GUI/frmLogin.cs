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
    public partial class FrmLogin : Form
    {

        string usu;
        string tipo;
        string pass;


        public FrmLogin()
        {
            InitializeComponent();
            cmbOpcion.SelectedIndex = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


        public void LimpiarPantalla() 
        {
            txtUsuario.Clear();
            txtContraseña.Clear();
        
        
        }


        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Administrador admin = new Administrador();
            admin = null;

            int TipoControl = 0;
            int usuarioControl = 0;
            int passControl = 0;


            if (cmbOpcion.SelectedItem.ToString() == "Seleccione una opción")
            {
               cmbOpcion.BackColor = Color.Red;
               
            }
            else 
            {
                tipo = cmbOpcion.SelectedItem.ToString();
                TipoControl = 1;

            }

            if (txtUsuario.Text == "")
            {
                txtUsuario.BackColor = Color.Red;
            }
            else 
            {
                usuarioControl = 1;           
                usu = txtUsuario.Text.Trim();
            
            }

            if (txtContraseña.Text == "")
            {
                txtContraseña.BackColor = Color.Red;

            }
            else 
            {
                passControl = 1;
                pass = txtContraseña.Text.Trim();
            }


            if (TipoControl == 1 && passControl == 1 && usuarioControl == 1)
            {
                lblErrorCompletar.Visible = false;

                AdministradorLogic admLog = new AdministradorLogic();

                admin = admLog.BuscaAdministrador(usu, pass, tipo);

                if (admin == null)
                {
                    lblErrorInvalido.Visible = true;

                }

                else
                {
                    lblErrorInvalido.Visible = false;

                    if (admin.contrasena == pass)
                    {

                        frmMenu menu = new frmMenu(admin);
                        this.LimpiarPantalla();
                        menu.ShowDialog();


                    }
                    else 
                    {
                        lblErrorInvalido.Visible = true;
                    
                    }

                }



            }
            else 
            {
                lblErrorCompletar.Visible = true;
            
            }

            


        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtUsuario.BackColor = Color.White;
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtContraseña.BackColor = Color.White;
        }

        private void cmbOpcion_MouseClick(object sender, MouseEventArgs e)
        {
            cmbOpcion.BackColor = Color.White;
        }
    }
}
