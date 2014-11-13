using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reportes
{
    public partial class frmReporteInquilinosHabilitados : Form
    {
        public frmReporteInquilinosHabilitados()
        {
            InitializeComponent();
        }

        private void inquilinosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.inquilinosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.inmobiliariaDataSet);

        }

        private void frmReporteInquilinosHabilitados_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inmobiliariaDataSet.Inquilinos' table. You can move, or remove it, as needed.
            this.inquilinosTableAdapter.Fill(this.inmobiliariaDataSet.Inquilinos);

            ReporteInquilinosHabilitados rep = new ReporteInquilinosHabilitados();

            rep.SetDataSource(inmobiliariaDataSet);

            this.crystalReportViewer1.ReportSource = rep;

        }
    }
}
