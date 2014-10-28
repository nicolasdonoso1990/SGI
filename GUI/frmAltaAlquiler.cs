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
        public frmAltaAlquiler()
        {
            InitializeComponent();
        }

        private void btnFecha_Click(object sender, EventArgs e)
        {
            fechaInicioAlq = fecha1.Value.Date;

            fechaFinAlq = fecha2.Value.Date;

            grpPropiedades.Enabled = true;

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


                PropiedadLogic proLog = new PropiedadLogic();
                prop = proLog.buscaPropiedad(codigo);

                grpUnidades.Enabled = true;

                UnidadLogic unLog=new UnidadLogic();

                ListaUnidades = unLog.BuscaUnidades(prop); 

                dataUnidad.AutoGenerateColumns = false;
                dataUnidad.DataSource = ListaUnidades;
            }       
        }

        private void btnUnidades_Click(object sender, EventArgs e)
        {
            Int32 cantidadFilasSeleccionadas = dataUnidad.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (cantidadFilasSeleccionadas > 0)
            {

                

                DataGridViewRow fila = dataUnidad.CurrentRow; //devuelve la fila que esta siendo seleccionada

                string codUni = fila.Cells[0].Value.ToString();

                UnidadLogic unLog = new UnidadLogic();

                uni = unLog.BuscaUnidad(codUni);

                grpInquilino.Enabled = true;

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
            this.Dispose();


        }
     

   
    }
}
