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

               
                
                    llenarGrillaUnidades(numero);
                
         

            }
        }

        private void llenarGrillaUnidades(Int32 numero)
        {
            AlquilerLogic al = new AlquilerLogic(); //Creo objeto de negocio
            

            var lista=al.UnidadesAlquiladasActualesDeUnInquilino(numero);  //Mando el número para buscar todas las unidades de un Inquilino




            dgvUnidades.AutoGenerateColumns = false;

            var lis=lista.Cast<object>().ToList();
            dgvUnidades.DataSource = null;
            dgvUnidades.DataSource = lis;

            dgvUnidades.Refresh();


            
        }
    }
}
