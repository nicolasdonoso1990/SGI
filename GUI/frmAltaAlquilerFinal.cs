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

        public frmAltaAlquilerFinal()
        {
            InitializeComponent();
            this.LlenarCampos();

        }

        public frmAltaAlquilerFinal(Entidades.Propiedad prop, Entidades.Unidad uni, Entidades.Inquilino inq,DateTime fecInicio,DateTime fecFin)
        {
          
            this.prop = prop;
            this.uni = uni;
            this.inq = inq;
            this.fechaIni = fecInicio;
            this.fechaFin = fecFin;

        }


        public void LlenarCampos()
        {
        txtInquilino.Text=inq.dni;
        txtPropiedad.Text=prop.direccion;
        txtUnidad.Text=uni.cod_unidad.ToString();
        
        
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            UnidadLogic unLog = new UnidadLogic();
            unLog.CambiaEstadoAlquilado(uni);

            Alquiler alq=new Alquiler();
            alq.cod_unidad = uni.cod_unidad;
            alq.nro_inquilino = inq.nro_inquilino;

            AlquilerLogic alqLog = new AlquilerLogic();
            Int32 numero= alqLog.AltaAlquiler(alq);

            Contrato cont = new Contrato();
            cont.cod_unidad = uni.cod_unidad;
            cont.nro_alquiler = numero;
            cont.descripcion_unidad = uni.descripcion;
            cont.fecha_realizacion = fechaFin;
            cont.fecha_caducidad = fechaFin;
            cont.anexo = txtContrato.Text;

            ContratoLogic contLog = new ContratoLogic();
            contLog.AltaContrato(cont);

            MessageBox.Show("El Alquiler fue dado de alta con exito", "Alta Alquiler");
            this.Dispose();

        }
    }
}
