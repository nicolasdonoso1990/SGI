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
    public partial class frmAltaAlquilerFinal : Form
    {
        private Entidades.Propiedad prop;
        private Entidades.Unidad uni;
        private Entidades.Inquilino inq;
        private DateTime fechaIni;
        private DateTime fechaFin;
        private Contrato cont;
        public Int32 numero  { get; set; }


        public frmAltaAlquilerFinal(Entidades.Propiedad prop, Entidades.Unidad uni, Entidades.Inquilino inq, DateTime fecInicio, DateTime fecFin)
        {
            InitializeComponent();
            this.prop = prop;
            this.uni = uni;
            this.inq = inq;
            this.fechaIni = fecInicio;
            this.fechaFin = fecFin;
            this.LlenarCampos();

        }


        public void LlenarCampos()
        {
        txtInquilino.Text=inq.dni;
        txtPropiedad.Text=prop.direccion;
        txtUnidad.Text=uni.cod_unidad.ToString();
      
        
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

        }

   
   

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            grpValores.Enabled = true;

            UnidadLogic unLog = new UnidadLogic();
            unLog.CambiaEstadoAlquilado(uni);


            Alquiler alq = new Alquiler();
            alq.cod_unidad = uni.cod_unidad;
            alq.nro_inquilino = inq.nro_inquilino;
            alq.estado = "habilitado";

            AlquilerLogic alqLog = new AlquilerLogic();
            alqLog.AltaAlquiler(alq);


            Int32 numeroAlq = alqLog.UltimoNumeroAlquiler(alq);



            cont = new Contrato();
            cont.cod_unidad = uni.cod_unidad;
            cont.nro_alquiler = numeroAlq;

            
            cont.nro_alquiler = alq.nro_alquiler;
            cont.descripcion_unidad = uni.descripcion;
            cont.fecha_realizacion = fechaFin;
            cont.fecha_caducidad = fechaFin;
            cont.anexo = txtContrato.Text;



            

            ContratoLogic contLog = new ContratoLogic();
            contLog.AltaContrato(cont);


            //MessageBox.Show("El Alquiler fue dado de alta con exito", "Alta Alquiler");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (fechaDesde.Value.Date >= fechaIni && fechaHasta.Value.Date <= fechaFin)
            {


                Valor_mensual valor = new Valor_mensual();
                valor.cod_contrato = cont.cod_contrato;
                valor.fechaDesde = fechaDesde.Value.Date;
                valor.fechaHasta = fechaHasta.Value.Date;
                valor.valor = Convert.ToInt32(txtValor.Text);

                ValorMensualLogic valLog = new ValorMensualLogic();
                valLog.altaValoresMensuales(valor);

                MessageBox.Show("Valor mensual dado de alta con exito.", "Alta Alquiler");



            }

            else 
            {
                MessageBox.Show("Las fechas exceden el tiempo establecido en el contrato", "Error Alta");
            
            }


            if (MessageBox.Show("¿Desea agregar otro valor mensual?. Confirme", "Otro inquilino", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                txtValor.Clear();



            }
            else
            {
                this.Dispose();    
            }



        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
