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
    public partial class frmTablaModificacionMejora : Form
    {
        public Mejora mejora { get; set; }
        public frmTablaModificacionMejora()
        {
            InitializeComponent();
        }

        private void frmTablaModificacionMejora_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inmobiliariaDataSetMejoras.Mejoras' table. You can move, or remove it, as needed.
            this.mejorasTableAdapter.Fill(this.inmobiliariaDataSetMejoras.Mejoras);

        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            /*Selección de filas. Me va a devolver 1 porque no puedo seleccionar más de una (verificar con Ctrl y Shift)*/
            Int32 cantidadFilasSeleccionadas = dgvMejora.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (cantidadFilasSeleccionadas > 0)
            {

                DataGridViewRow fila = dgvMejora.CurrentRow; //devuelve la fila que esta siendo seleccionada

                string numero = fila.Cells[1].Value.ToString(); //el [1] indica la posicion del numero de mejora
                /*busco la mejora por numero*/
                MejoraLogic mejoraLogic = new MejoraLogic();
                mejora = mejoraLogic.buscaMejora(numero);
                /*Una vez que lo encuentro, habilito la modificación*/
                gpbMejora.Enabled = true;
                /*relleno el formulario de modificación*/
                txtNumero.Text = mejora.nro_mejora.ToString();
                txtValor.Text = mejora.valor.ToString();
                txtObservaciones.Text = mejora.observaciones;
                txtDetalles.Text = mejora.detalles;
                dtpFecha.Value = (DateTime)mejora.fecha;
                txtContratista.Text = mejora.cod_contratista.ToString();
                txtUnidad.Text = mejora.cod_unidad.ToString();
                /*Esto actualiza el dataGrid con la informacion despues del borrado o la modificacion*/
                var listaMejoras = mejoraLogic.getAll();
                dgvMejora.DataSource = listaMejoras;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            mejora.nro_mejora = int.Parse(txtNumero.Text);
            mejora.valor = int.Parse(txtValor.Text);
            mejora.observaciones = txtObservaciones.Text;
            mejora.detalles = txtDetalles.Text;
            mejora.fecha = dtpFecha.Value;
            mejora.cod_contratista = int.Parse(txtContratista.Text);
            mejora.cod_unidad = int.Parse(txtUnidad.Text);
            /*Acá mando todo a la capa de Negocio*/
            MejoraLogic mejoraLogic = new MejoraLogic();
            mejoraLogic.modificarMejora(mejora);
            /*Acá lo dejo tranquilo al usuario de que anduvo todo bien*/
            MessageBox.Show("Los cambios fueron realizados con exito", "Modificacion de inquilino");
            /*Acá actualizo el DataGridView con los datos que ahora reflejan el cambio realizado*/
            List<Mejora> listaMejoras = new List<Mejora>();
            listaMejoras = mejoraLogic.getAll();
            dgvMejora.DataSource = listaMejoras;
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {

            Int32 cantidadFilasSeleccionadas = dgvMejora.Rows.GetRowCount(DataGridViewElementStates.Selected);
            /*Selección de filas. Me va a devolver 1 porque no puedo seleccionar más de una (verificar con Ctrl y Shift)*/
            if (cantidadFilasSeleccionadas > 0)
            {

                if (MessageBox.Show("¿Está seguro que desea dar de baja esta mejora?. Confirme", "Baja Mejora", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {



                    DataGridViewRow fila = dgvMejora.CurrentRow; //devuelve la fila que esta siendo seleccionada

                    int numero = int.Parse(fila.Cells[1].Value.ToString()); //el [0] indica la posicion del codigo de contratista(no visible en el form)
                    /*Le paso a la capa de Negocio el código para que borre el contratista*/
                    MejoraLogic mejoraLogic = new MejoraLogic();
                    mejoraLogic.bajaMejora(numero);
                    /*Mensajito de confirmación. La palabra "éxito" produce un alivio enorme en el usuario.*/
                    MessageBox.Show("El contratista fue dado de baja con éxito", "Baja de contratista");
                    /*Acá lleno el DataGridView de nuevo, reflejando la actualización*/
                    var listaMejora = mejoraLogic.getAll();
                    dgvMejora.DataSource = listaMejora;
                }

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
