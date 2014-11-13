using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Reportes;

namespace Reportes
{
    public partial class frmReporte1 : Form
    {
        public frmReporte1()
        {
            InitializeComponent();
        }

        private void frmReporte1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inmobiliariaDataSet.Cuenta_corriente' table. You can move, or remove it, as needed.
            this.cuenta_corrienteTableAdapter.Fill(this.inmobiliariaDataSet.Cuenta_corriente);
            // TODO: This line of code loads data into the 'inmobiliariaDataSet.Inquilinos' table. You can move, or remove it, as needed.
            this.inquilinosTableAdapter.Fill(this.inmobiliariaDataSet.Inquilinos);


            ReporteCuentasCorrientes rep = new ReporteCuentasCorrientes();

            rep.SetDataSource(inmobiliariaDataSet);

            this.crystalReportViewer1.ReportSource = rep;
            
           
        }

        private void inquilinosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.inquilinosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.inmobiliariaDataSet);

        }
    }
}
