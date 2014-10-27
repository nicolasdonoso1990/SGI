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
    public partial class frmTablaModificacionReparacion : frmTablaModificacionMejora
    {
        public frmTablaModificacionReparacion()
        {
            InitializeComponent();
        }

        protected override void LlenarTabla()
        {
            //this.reparacionesTableAdapter.Fill(this.inmobiliariaDataSetReparaciones.Reparaciones);
        }
        private void frmTablaModificacionReparacion_Load(object sender, EventArgs e)
        {

        }
    }
}
