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
            this.RellenarGrillaInquilinos();
        }

        public void RellenarGrillaInquilinos()
        {
            dgvInquilinos.AutoGenerateColumns = false;
            InquilinoLogic inLog = new InquilinoLogic();
            ListaInquilinos =inLog.TodosInquilinos();
            dgvInquilinos.DataSource = ListaInquilinos;
            

        }
    }
}
