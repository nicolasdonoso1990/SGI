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


namespace GUI
{
    public partial class frmMenu : Form
    {
       

        public Administrador admin { get; set; }
        public frmMenu(Administrador adm)
        {
            InitializeComponent();

            //lblNombreUsuario.Text = adm.usuario;
           


            admin = adm;


            if (adm.tipo == "super")
            {
               
                this.modificarAdministradorToolStripMenuItem.Enabled = true;



            }



        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nuevoAdministradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAltaAdministrador alta = new frmAltaAdministrador(admin);
            alta.ShowDialog();
        }

        private void altaInquilinoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAltaInquilino alta = new frmAltaInquilino();
            alta.ShowDialog();


        }

      

        private void modificarInquilinoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTablaModificaInquilino modifica = new frmTablaModificaInquilino();
            modifica.ShowDialog();
            
        }

        private void modificarAdministradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTablaModificacionAdministrador tablamodifica = new frmTablaModificacionAdministrador(admin);
            tablamodifica.ShowDialog();
        }

 

        private void administradoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void altaPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAltaPropiedad altaPro = new frmAltaPropiedad();
            altaPro.ShowDialog();

        }

        private void modificarPropiedadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTablaModificarPropiedad modPro = new frmTablaModificarPropiedad();
            modPro.ShowDialog();
        }

        private void CerrarStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            this.Dispose();
            
        }

        private void nuevaUnidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAltaUnidad altaUnidad = new frmAltaUnidad();
            altaUnidad.ShowDialog();
        }

        private void propiedadesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void modificarUnidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTablaModificacionUnidad modUni = new frmTablaModificacionUnidad();
            modUni.ShowDialog();
        }


        private void altaContratistaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmAltaContratista altaContratista = new frmAltaContratista();
            altaContratista.ShowDialog();
        }

        private void modificarContratistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTablaModificacionContratista modificarContratista = new frmTablaModificacionContratista();
            modificarContratista.ShowDialog();
        }

        private void miCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMiCuenta miCuenta = new frmMiCuenta(admin);
            miCuenta.ShowDialog();
        }

        private void altaAlquilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAltaAlquiler altaAlqui = new frmAltaAlquiler();
            altaAlqui.ShowDialog();
        }

        private void nuevaMejoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAltaMejora altaMejora = new frmAltaMejora();
            altaMejora.ShowDialog();
        }

        private void modificarMejorasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTablaModificacionMejora modificarMejora = new frmTablaModificacionMejora();
            modificarMejora.ShowDialog();
        }

        private void nuevaReparacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAltaReparacion altaReparacion = new frmAltaReparacion();
            altaReparacion.ShowDialog();
        }

        private void modificarReparacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTablaModificacionReparacion modificarRep = new frmTablaModificacionReparacion();
            modificarRep.ShowDialog();
        }

        private void registrarPagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistrarPago regisPago = new frmRegistrarPago();
            regisPago.ShowDialog();
        }

      



    

     
     



        


     
    }
}
