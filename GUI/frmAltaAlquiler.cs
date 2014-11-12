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
    public partial class frmAltaAlquiler : Form
    {
        IEnumerable<Unidad> ListaUnidades { get; set; }
        Propiedad prop;
        Unidad uni;
        Inquilino inq;
        DateTime fechaInicioAlq;
        DateTime fechaFinAlq;
        Int32 codigoPropiedad;
        public frmAltaAlquiler()
        {
            InitializeComponent();
        }

        private void btnFecha_Click(object sender, EventArgs e)
        {
            fechaInicioAlq = fecha1.Value.Date;

            fechaFinAlq = fecha2.Value.Date;

            dataPropiedad.Visible = true;
            txtDireccionPropiedad.Visible = true;
            lblDireccionPropiedad.Visible = true;
            btnPropiedad.Visible = true;
            btnSalir.Visible = true;

            PropiedadLogic propLog = new PropiedadLogic();
            List<Propiedad> propiedades = new List<Propiedad>();
            propiedades = propLog.todasPropiedades();

            dataPropiedad.AutoGenerateColumns = false;
            dataPropiedad.DataSource = propiedades;


        }

        private void btnInquilino_Click(object sender, EventArgs e)
        {
             Int32 cantidadFilasSeleccionadas = dataInquilino.Rows.GetRowCount(DataGridViewElementStates.Selected);

             if (cantidadFilasSeleccionadas > 0)
             {

                 DataGridViewRow fila = dataInquilino.CurrentRow; //devuelve la fila que esta siendo seleccionada

                 string dni = fila.Cells[2].Value.ToString(); //el [2] indica la posicion del dni

                 InquilinoLogic InLog = new InquilinoLogic();

                 inq = InLog.BuscaInquilino(dni);

                 frmAltaAlquilerFinal formFinal = new frmAltaAlquilerFinal(prop,uni,inq,fechaInicioAlq,fechaFinAlq);
                 formFinal.ShowDialog();

             }
        }

        private void btnPropiedad_Click(object sender, EventArgs e)
        {
            Int32 cantidadFilasSeleccionadas = dataPropiedad.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (cantidadFilasSeleccionadas > 0)
            {

                DataGridViewRow fila = dataPropiedad.CurrentRow; //devuelve la fila que esta siendo seleccionada



                string cod = fila.Cells[0].Value.ToString();

                Int32 codigo = Convert.ToInt32(cod);

                this.codigoPropiedad = codigo; //Guardo el código de la propiedad en una Propiedad del form para usarla luego en caso de filtrado

                PropiedadLogic proLog = new PropiedadLogic();
                prop = proLog.buscaPropiedad(codigo);

                dataUnidad.Visible = true;
                lblDireccionUnidad.Visible = true;
                txtDescripcionUnidad.Visible = true;
                btnUnidad.Visible = true;

                UnidadLogic unLog=new UnidadLogic();
                ListaUnidades = unLog.BuscaUnidadesNoAlquiladas(prop);
                
               
                dataUnidad.AutoGenerateColumns = false;
                dataUnidad.DataSource = ListaUnidades;
            }       
        }

        private void btnUnidades_Click(object sender, EventArgs e)
        {

            this.rellenarGrillaInquilinos();

        }


        public void rellenarGrillaInquilinos()
        {
             Int32 cantidadFilasSeleccionadas = dataUnidad.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (cantidadFilasSeleccionadas > 0)
            {

                

                DataGridViewRow fila = dataUnidad.CurrentRow; //devuelve la fila que esta siendo seleccionada

                string codUni = fila.Cells[0].Value.ToString();

                UnidadLogic unLog = new UnidadLogic();

                uni = unLog.BuscaUnidad(codUni);

                lblDNI.Visible=true;
                txtboxFiltroDni.Visible = true;
                dataInquilino.Visible = true;
                btnAlquiler.Visible = true;

                InquilinoLogic InLog = new InquilinoLogic();

                List<Inquilino> ListaInquilinos = new List<Inquilino>();
                ListaInquilinos = InLog.TodosInquilinos();

                dataInquilino.AutoGenerateColumns = false;
                dataInquilino.DataSource = ListaInquilinos;
        

            }

        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            frmAltaAlquilerFinal altaFinal =new frmAltaAlquilerFinal(prop,uni,inq,fechaInicioAlq,fechaFinAlq);
            altaFinal.ShowDialog();
            


        }

        private void grpInquilino_Enter(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Int32 cantidadFilasSeleccionadas = dataInquilino.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (cantidadFilasSeleccionadas > 0)
            {

                DataGridViewRow fila = dataInquilino.CurrentRow; //devuelve la fila que esta siendo seleccionada

                string dni = fila.Cells[2].Value.ToString(); //el [2] indica la posicion del dni

                InquilinoLogic InLog = new InquilinoLogic();

                inq = InLog.BuscaInquilino(dni);

                frmAltaAlquilerFinal formFinal = new frmAltaAlquilerFinal(prop, uni, inq, fechaInicioAlq, fechaFinAlq);
                formFinal.ShowDialog();

            }
        }

        private void txtDireccionPropiedad_TextChanged(object sender, EventArgs e)
        {
            int a; //Variable a, a la cual asignada la comparación

            int cero = 0;
            string filtro = txtDireccionPropiedad.Text;

            PropiedadLogic propLog = new PropiedadLogic();
            List<Propiedad> propiedades = new List<Propiedad>();
            propiedades = propLog.todasPropiedades();

            dataPropiedad.AutoGenerateColumns = false;



            if (cero != (a = String.Compare(txtDireccionPropiedad.Text, ""))) //Si la comparación da 0 no hay diferncias, por lo tanto el extbox está en blanco
            {
                
                List<Propiedad> listaFiltrada = (from prop in propiedades
                                                 where prop.direccion.ToString().Contains(filtro)
                                                 select prop).ToList();


                dataPropiedad.DataSource = listaFiltrada;



            }
            else
            {
                
                dataPropiedad.DataSource = propiedades;
            }
        }

        private void txtDescripcionUnidad_TextChanged(object sender, EventArgs e)
        {

            int a; //Variable a, a la cual asignada la comparación

            int cero = 0;
            string filtro = txtDescripcionUnidad.Text;



            PropiedadLogic proLog = new PropiedadLogic();
            prop = proLog.buscaPropiedad(this.codigoPropiedad);

            UnidadLogic unLog = new UnidadLogic();
            ListaUnidades = unLog.BuscaUnidadesNoAlquiladas(prop);

            dataUnidad.AutoGenerateColumns = false;

            if (cero != (a = String.Compare(txtDescripcionUnidad.Text, ""))) //Si la comparación da 0 no hay diferncias, por lo tanto el textbox está en blanco
            {

                List<Unidad> listaFiltrada = (from uni in ListaUnidades
                                                 where uni.descripcion.ToString().Contains(filtro)
                                                 select uni).ToList();


                dataUnidad.DataSource = listaFiltrada;



            }
            else
            {

                dataUnidad.DataSource = ListaUnidades; 
            }
            

        }

        private void txtDNI_TextChanged(object sender, EventArgs e)
        {
            int a; //Variable a, a la cual asignada la comparación

            int cero = 0;
            string filtro = txtboxFiltroDni.Text;

            if (cero != (a = String.Compare(txtboxFiltroDni.Text, ""))) //Si la comparación da 0 no hay diferncias, por lo tanto el extbox está en blanco
            {
                InquilinoLogic inLog = new InquilinoLogic();
               List<Inquilino> ListaInquilinos = inLog.TodosInquilinos();

                List<Inquilino> listaFiltrada = (from inqui in ListaInquilinos
                                                 where inqui.dni.ToString().Contains(filtro)
                                                 select inqui).ToList();
                this.dataInquilino.DataSource = listaFiltrada;



            }
            else
            {
                this.rellenarGrillaInquilinos();
            }
        }
     

   
    }
}
