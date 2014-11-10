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
    public partial class frmRegistrarPago : Form
    {
        public IEnumerable<Inquilino> ListaInquilinos { get; set; }

        public frmRegistrarPago()
        {
            InitializeComponent();
            this.rellenarGrillaInquilinos();
            this.trabadoInicial();

        }

        public void rellenarGrillaInquilinos()
        {
            dgvInquilinos.AutoGenerateColumns = false;
            InquilinoLogic inLog = new InquilinoLogic();
            ListaInquilinos =inLog.TodosInquilinos();
            dgvInquilinos.DataSource = ListaInquilinos;
            

        }

        public void trabadoInicial()
        {
            grpboxUnidad.Enabled = false;
            grpboxPago.Enabled = false;

        }

        private void btnSeleccionarInquilino_Click(object sender, EventArgs e)
        {
            Int32 cantFilasSelec = dgvInquilinos.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (cantFilasSelec > 0)
            {
                DataGridViewRow fila = dgvInquilinos.CurrentRow; //devuelve la fila que esta siendo seleccionada
                
                //El número de inquilino está como no visible en las columnas de Inquilino
                Int32 numero = Convert.ToInt32(fila.Cells[0].Value);

                string nom = fila.Cells[1].Value.ToString();

                string ape = fila.Cells[2].Value.ToString();

                //Junto nombre y apellido extraídos de las filas
                string nombrecompleto = ape + " " + nom;

                grpboxUnidad.Enabled = true;

                txtboxNombreInquilino.Text = nombrecompleto;

                    llenarGrillaUnidades(numero);
                
         

            }
        }

        private void llenarGrillaUnidades(Int32 numero)
        {
            AlquilerLogic al = new AlquilerLogic(); //Creo objeto de negocio
            

            var lista=al.UnidadesAlquiladasActualesDeUnInquilino(numero);  //Mando el número para buscar todas las unidades de un Inquilino


            dgvUnidades.AutoGenerateColumns = false;



            var lis = lista.Cast<object>().ToList(); //Paso el IEnumerable a Lista así puede usarse como DATASOURCE

            
            dgvUnidades.DataSource = null; /*Una buena práctica en el VisualFoxPro era poner
                                            * el datasource en null 
                                            */ 


            dgvUnidades.DataSource = lis; //cargo el datasource con el IEnumerable transformado a List

            dgvUnidades.Refresh(); //Mando un refresh por las dudas

        
            
        }

        private void btnSeleccionarUnidad_Click(object sender, EventArgs e)
        {
            Int32 cantFilasSelec = dgvUnidades.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (cantFilasSelec > 0)
            {
                DataGridViewRow fila = dgvUnidades.CurrentRow; //devuelve la fila que esta siendo seleccionada

                //El código de unidad está como no visible en las columnas de la grilla dgvUnidades
                Int32 codUni = Convert.ToInt32(fila.Cells[0].Value);

                Int32 numeroInq = Convert.ToInt32(fila.Cells[2].Value);

                string domicilio = fila.Cells[4].Value.ToString();

                string descripcion = fila.Cells[5].Value.ToString();

                grpboxPago.Enabled = true;
 
                txtboxDireccion.Text = domicilio;

                txtboxDescripcion.Text = descripcion;

                this.TraerSaldoActual(numeroInq);

                this.TraerValorMensual(numeroInq, codUni);

               
               



            }

           
        }

        public void TraerSaldoActual( int numeroInq)
        {
            CuentaCorrienteLogic ccl = new CuentaCorrienteLogic();

            double saldo = ccl.TraerSaldoInquilino(numeroInq);// Aquí va el Método que trae el saldo actual del Inquilino

            txtboxSaldoActual.Text = Convert.ToString(saldo);
        }

        public void TraerValorMensual(Int32 numeroInq, Int32 codUni)
        {
            AlquilerLogic al = new AlquilerLogic();

            Int32 nroAlquiler = al.BuscarNumeroAlquiler(numeroInq, codUni); //Buscamos el código de Alquiler

            ContratoLogic cl = new ContratoLogic();

            Int32 nroContrato = cl.BuscarNroContrato(nroAlquiler);   // Buscamos el número de contrato

            ValorMensualLogic vml = new ValorMensualLogic();

            DateTime fechaElegida = this.dtpFecha.Value;

            Int32 valorMensual = vml.BuscarValorPago(nroContrato,fechaElegida);

            this.txtboxMontoMensual.Text = Convert.ToString(valorMensual);
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {

            DataGridViewRow fila = dgvUnidades.CurrentRow; //devuelve la fila que esta siendo seleccionada
            Int32 codUni = Convert.ToInt32(fila.Cells[0].Value);

                Int32 numeroInq = Convert.ToInt32(fila.Cells[2].Value);

                this.TraerValorMensual(numeroInq, codUni);
        }

        private void btnRegistarPago_Click(object sender, EventArgs e)
        {
            string monto= txtboxMontoaPagar.Text;

          DialogResult dialogResult = MessageBox.Show("Usted va a registrar un pago de $" + monto + "¿Desea continuar?", "¡Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

           if (dialogResult==DialogResult.Yes) { this.RegistrarPago(); }

        }

        public void RegistrarPago()
        {

            DataGridViewRow fila = dgvUnidades.CurrentRow; //devuelve la fila que esta siendo seleccionada
            Int32 codUni = Convert.ToInt32(fila.Cells[0].Value);

            Int32 numeroInq = Convert.ToInt32(fila.Cells[2].Value);

            AlquilerLogic al = new AlquilerLogic();

            Int32 nroAlquiler = al.BuscarNumeroAlquiler(numeroInq, codUni);

            Pago_alquiler pa = new Pago_alquiler();

            pa.cod_unidad = codUni;

            pa.fecha = this.dtpFecha.Value;

            pa.monto = Convert.ToInt32(txtboxMontoaPagar.Text);

            pa.nro_inquilino = numeroInq;

            pa.nro_alquiler = nroAlquiler;

            Pagos_AlquilerLogic pal = new Pagos_AlquilerLogic();

            pal.AltaPagos_Alquiler(pa);





        }
    }
}
