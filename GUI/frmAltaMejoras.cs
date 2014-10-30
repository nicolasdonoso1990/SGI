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
    public partial class frmAltaMejora : Form
    {
        public frmAltaMejora()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmAltaMejora_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inmobiliariaDataSetContratistas.Contratistas' table. You can move, or remove it, as needed.
            this.contratistasTableAdapter.Fill(this.inmobiliariaDataSetContratistas.Contratistas);
            // TODO: This line of code loads data into the 'inmobiliariaDataSetUnidades.Unidades' table. You can move, or remove it, as needed.
            this.unidadesTableAdapter.Fill(this.inmobiliariaDataSetUnidades.Unidades);

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Int32 cantidadFilasSeleccionadas = dgvUnidad.Rows.GetRowCount(DataGridViewElementStates.Selected);
            Unidad unidadSeleccionada = new Unidad();
            Contratista contratistaSeleccionado = new Contratista();
            Mejora mejoraCreada = new Mejora();

            if (cantidadFilasSeleccionadas > 0)
            {

                DataGridViewRow filaUnidad = dgvUnidad.CurrentRow; //devuelve la fila que esta siendo seleccionada
                string codUnidadString = filaUnidad.Cells[1].Value.ToString(); //el [1] indica la posicion del codigo de unidad
                var codigoUnidad = Int32.Parse(codUnidadString);

                DataGridViewRow filaContratista = dgvContratista.CurrentRow; //devuelve la fila que esta siendo seleccionada
                string codContratistaString = filaContratista.Cells[0].Value.ToString(); //el [1] indica la posicion del codigo de unidad
                var codigoContratista = Int32.Parse(codContratistaString);

                gpbMejora.Enabled = true;

                Mejora mejora = new Mejora();
                mejora.cod_unidad = codigoUnidad;
                mejora.cod_contratista = codigoContratista;
                mejora.detalles = this.txtDetalles.Text;
                mejora.observaciones = this.txtObservaciones.Text;
                mejora.fecha = this.dtpFecha.Value.Date;
                mejora.valor = Int32.Parse(this.txtValor.Text);
                
                MejoraLogic mejoraLogic = new MejoraLogic();
                mejoraLogic.altaMejora(mejora);

                MessageBox.Show("La mejora fue dada de alta con éxito", "Operación exitosa");


            }
        }
    }
}
    

