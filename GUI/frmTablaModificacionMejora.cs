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
                Mejora mejora = mejoraLogic.buscaMejora(numero);
                /*Una vez que lo encuentro, habilito la modificación*/
                gpbMejora.Enabled = true;
                /*relleno el formulario de modificación*/
                txtNumero.Text = mejora.nro_mejora.ToString();
                txtValor.Text = mejora.valor.ToString();
                txtObservaciones.Text = mejora.observaciones;
                txtDetalles.Text = mejora.detalles;
                /*Esto actualiza el dataGrid con la informacion despues del borrado o la modificacion*/
                var listaMejoras = mejoraLogic.getAll();
                dgvMejora.DataSource = listaMejoras;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string[] datos = new string[6];
            datos[0] = txtNumero.Text;
            datos[1] = txtValor.Text;
            datos[2] = txtObservaciones.Text;
            datos[3] = txtDetalles.Text;
            datos[4] = DateTime.
            /*Acá mando todo a la capa de Negocio*/
            ContratistaLogic contratistaLogic = new ContratistaLogic();
            contratistaLogic.modificarContratista(datos);
            /*Acá lo dejo tranquilo al usuario de que anduvo todo bien*/
            MessageBox.Show("Los cambios fueron realizados con exito", "Modificacion de inquilino");
            /*Acá actualizo el DataGridView con los datos que ahora reflejan el cambio realizado*/
            List<Contratista> listaContratistas = new List<Contratista>();
            listaContratistas = contratistaLogic.getAll();
            dgvContratista.DataSource = listaContratistas;
        }
    }
}
