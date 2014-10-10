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
        public FrmLogin()
        {
            InitializeComponent();
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
            string usu = txtUsuario.Text;
            string pass = txtContraseña.Text;
            string tipo = comboBox1.SelectedItem.ToString();


            AdministradorLogic admLog = new AdministradorLogic();

            admin = admLog.BuscaAdministrador(usu, pass, tipo);

            if (admin.contrasena == pass) 
            {

                frmMenu menu = new frmMenu(admin);
                this.LimpiarPantalla();
                menu.ShowDialog();
                
            
            }


        }
    }
}
