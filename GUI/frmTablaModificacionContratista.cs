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
    public partial class frmTablaModificacionContratista : Form
    {
        public frmTablaModificacionContratista()
        {
            InitializeComponent();
        }

        private void frmTablaModificacionContratista_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inmobiliariaDataSet.Contratistas' table. You can move, or remove it, as needed.
            this.contratistasTableAdapter.Fill(this.inmobiliariaDataSet.Contratistas);

        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            /*Selección de filas. Me va a devolver 1 porque no puedo seleccionar más de una (verificar con Ctrl y Shift)*/
            Int32 cantidadFilasSeleccionadas = dgvContratista.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (cantidadFilasSeleccionadas > 0)
            {

                DataGridViewRow fila = dgvContratista.CurrentRow; //devuelve la fila que esta siendo seleccionada

                string codigo = fila.Cells[0].Value.ToString(); //el [1] indica la posicion del apellido
                /*busco al contratista por apellido*/
                ContratistaLogic contratistaLogic = new ContratistaLogic();
                Contratista contratista = contratistaLogic.buscaContratista(codigo);
                /*Una vez que lo encuentro, habilito la modificación*/
                gpbContratista.Enabled = true;
                /*relleno el formulario de modificación*/
                txtApellido.Text = contratista.apellido;
                txtDireccion.Text = contratista.direccion;
                txtNombre.Text = contratista.nombre;
                txtTelefono.Text = contratista.telefono;
                txtDisponibilidad.Text = contratista.disponibilidad;
                txtCodigo.Text = contratista.cod_contratista.ToString();
                /*Esto actualiza el dataGrid con la informacion despues del borrado o la modificacion*/    
                var listaContratistas = contratistaLogic.getAll();
                dgvContratista.DataSource = listaContratistas;
            }

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            /*Esto está buenísimo.
            * Acá copié una belleza de código de Donoso El Magnífico.
             Lo que hago es meter todo lo de los textboxes en un arreglo de strings.
             No es muy intuitivo pero anda hermosamente perfecto y desafía las convenciones
             * del paradigma orientado a objetos. Esto es el punk de C#.*/
            string[] datos = new string[6];
            datos[0] = txtCodigo.Text;
            datos[1] = txtNombre.Text;
            datos[2] = txtApellido.Text;
            datos[3] = txtDireccion.Text;
            datos[4] = txtTelefono.Text;
            datos[5] = txtDisponibilidad.Text;
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

        private void btnBaja_Click(object sender, EventArgs e)
        {
            
            Int32 cantidadFilasSeleccionadas = dgvContratista.Rows.GetRowCount(DataGridViewElementStates.Selected);
            /*Selección de filas. Me va a devolver 1 porque no puedo seleccionar más de una (verificar con Ctrl y Shift)*/
            if (cantidadFilasSeleccionadas > 0)
            {

                if (MessageBox.Show("¿Está seguro que desea dar de baja a este contratista?. Confirme", "Baja Contratista", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {



                    DataGridViewRow fila = dgvContratista.CurrentRow; //devuelve la fila que esta siendo seleccionada

                    int codigo = int.Parse(fila.Cells[0].Value.ToString()); //el [0] indica la posicion del codigo de contratista(no visible en el form)
                    /*Le paso a la capa de Negocio el código para que borre el contratista*/
                    ContratistaLogic contratistaLogic = new ContratistaLogic();
                    contratistaLogic.bajaContratista(codigo);
                    /*Mensajito de confirmación. La palabra "éxito" produce un alivio enorme en el usuario.*/
                    MessageBox.Show("El contratista fue dado de baja con éxito", "Baja de contratista");
                    /*Acá lleno el DataGridView de nuevo, reflejando la actualización*/
                    var listaContratista = contratistaLogic.getAll();
                    dgvContratista.DataSource = listaContratista;
                }

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

     
    }
}
