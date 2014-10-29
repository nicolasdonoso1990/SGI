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
    public partial class frmAltaReparacion : Form
    {
        public frmAltaReparacion()
        {
            InitializeComponent();
        }

   

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmAltaReparacion_Load(object sender, EventArgs e)
        {
            LlenarTablas();

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Int32 cantidadFilasSeleccionadas = dgvUnidad.Rows.GetRowCount(DataGridViewElementStates.Selected);
            Unidad unidadSeleccionada = new Unidad();
            Contratista contratistaSeleccionado = new Contratista();
            Reparacion reparacionCreada = new Reparacion();

            if (cantidadFilasSeleccionadas > 0)
            {

                DataGridViewRow filaUnidad = dgvUnidad.CurrentRow; //devuelve la fila que esta siendo seleccionada
                string codUnidadString = filaUnidad.Cells[1].Value.ToString(); //el [1] indica la posicion del codigo de unidad
                var codigoUnidad = Int32.Parse(codUnidadString);

                DataGridViewRow filaContratista = dgvContratista.CurrentRow; //devuelve la fila que esta siendo seleccionada
                string codContratistaString = filaContratista.Cells[0].Value.ToString(); //el [1] indica la posicion del codigo de unidad
                var codigoContratista = Int32.Parse(codContratistaString);

                gpbReparacion.Enabled = true;

                Reparacion reparacion = new Reparacion();
                reparacion.cod_unidad = codigoUnidad;
                reparacion.cod_contratista = codigoContratista;
                reparacion.detalles = this.txtDetalles.Text;
                reparacion.observaciones = this.txtObservaciones.Text;
                reparacion.fecha = this.dtpFecha.Value.Date;
                reparacion.valor = Int32.Parse(this.txtValor.Text);

                ReparacionLogic reparacionLogic = new ReparacionLogic();
                reparacionLogic.altaReparacion(reparacion);

                MessageBox.Show("La reparacion fue dada de alta con éxito", "Operación exitosa");


            }
        }
        #region Métodos
        
            
        


        private void LlenarTablas()
        {
            // TODO: This line of code loads data into the 'inmobiliariaDataSetContratistas.Contratistas' table. You can move, or remove it, as needed.
            this.contratistasTableAdapter.Fill(this.inmobiliariaDataSetContratistas.Contratistas);
            // TODO: This line of code loads data into the 'inmobiliariaDataSetUnidades.Unidades' table. You can move, or remove it, as needed.
            this.unidadesTableAdapter.Fill(this.inmobiliariaDataSetUnidades.Unidades);
        }

     
    }
}
        #endregion Métodos