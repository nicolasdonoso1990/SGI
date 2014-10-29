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
    public partial class frmTablaModificacionReparacion : Form
    {
        public Reparacion reparacion { get; set; }
        public frmTablaModificacionReparacion()
        {
            InitializeComponent();
        }

        private void frmTablaModificacionReparacion_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inmobiliariaDataSet1.Reparaciones' table. You can move, or remove it, as needed.
            this.reparacionesTableAdapter.Fill(this.inmobiliariaDataSet1.Reparaciones);

        }
        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            /*Selección de filas. Me va a devolver 1 porque no puedo seleccionar más de una (verificar con Ctrl y Shift)*/
            Seleccionar();
        }

        protected virtual void Seleccionar()
        {
            Int32 cantidadFilasSeleccionadas = dgvReparacion.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (cantidadFilasSeleccionadas > 0)
            {

                DataGridViewRow fila = dgvReparacion.CurrentRow; //devuelve la fila que esta siendo seleccionada

                string numero = fila.Cells[1].Value.ToString(); //el [1] indica la posicion del numero de reparacion
                /*busco la reparacion por numero*/
                ReparacionLogic reparacionLogic = new ReparacionLogic();
                reparacion = reparacionLogic.buscaReparacion(numero);
                /*Una vez que lo encuentro, habilito la modificación*/
                gpbReparacion.Enabled = true;
                /*relleno el formulario de modificación*/
                txtNumero.Text = reparacion.nro_reparacion.ToString();
                txtValor.Text = reparacion.valor.ToString();
                txtObservaciones.Text = reparacion.observaciones;
                txtDetalles.Text = reparacion.detalles;
                dtpFecha.Value = (DateTime)reparacion.fecha;
                txtContratista.Text = reparacion.cod_contratista.ToString();
                txtUnidad.Text = reparacion.cod_unidad.ToString();
                /*Esto actualiza el dataGrid con la informacion despues del borrado o la modificacion*/
                var listaReparacions = reparacionLogic.getAll();
                dgvReparacion.DataSource = listaReparacions;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            Registrar();
        }

        protected virtual void Registrar()
        {
            reparacion.nro_reparacion = int.Parse(txtNumero.Text);
            reparacion.valor = int.Parse(txtValor.Text);
            reparacion.observaciones = txtObservaciones.Text;
            reparacion.detalles = txtDetalles.Text;
            reparacion.fecha = dtpFecha.Value;
            reparacion.cod_contratista = int.Parse(txtContratista.Text);
            reparacion.cod_unidad = int.Parse(txtUnidad.Text);
            /*Acá mando todo a la capa de Negocio*/
            ReparacionLogic reparacionLogic = new ReparacionLogic();
            reparacionLogic.modificarReparacion(reparacion);
            /*Acá lo dejo tranquilo al usuario de que anduvo todo bien*/
            MessageBox.Show("Los cambios fueron realizados con exito", "Modificacion de inquilino");
            /*Acá actualizo el DataGridView con los datos que ahora reflejan el cambio realizado*/
            List<Reparacion> listaReparacions = new List<Reparacion>();
            listaReparacions = reparacionLogic.getAll();
            dgvReparacion.DataSource = listaReparacions;
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {

            Baja();
        }

        protected virtual void Baja()
        {
            Int32 cantidadFilasSeleccionadas = dgvReparacion.Rows.GetRowCount(DataGridViewElementStates.Selected);
            /*Selección de filas. Me va a devolver 1 porque no puedo seleccionar más de una (verificar con Ctrl y Shift)*/
            if (cantidadFilasSeleccionadas > 0)
            {

                if (MessageBox.Show("¿Está seguro que desea dar de baja esta reparacion?. Confirme", "Baja Reparacion", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {



                    DataGridViewRow fila = dgvReparacion.CurrentRow; //devuelve la fila que esta siendo seleccionada

                    int numero = int.Parse(fila.Cells[1].Value.ToString()); //el [0] indica la posicion del codigo de contratista(no visible en el form)
                    /*Le paso a la capa de Negocio el código para que borre el contratista*/
                    ReparacionLogic reparacionLogic = new ReparacionLogic();
                    reparacionLogic.bajaReparacion(numero);
                    /*Mensajito de confirmación. La palabra "éxito" produce un alivio enorme en el usuario.*/
                    MessageBox.Show("El contratista fue dado de baja con éxito", "Baja de contratista");
                    /*Acá lleno el DataGridView de nuevo, reflejando la actualización*/
                    var listaReparacion = reparacionLogic.getAll();
                    dgvReparacion.DataSource = listaReparacion;
                }

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }
    }
}
