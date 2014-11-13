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
    public partial class frmReportePagosRealizados : Form
    {
        public frmReportePagosRealizados()
        {
            InitializeComponent();
        }

        private void alquileresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.alquileresBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.inmobiliariaDataSet);

        }

        private void frmReportePagosRealizados_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inmobiliariaDataSet.Unidades' table. You can move, or remove it, as needed.
            this.unidadesTableAdapter.Fill(this.inmobiliariaDataSet.Unidades);
            // TODO: This line of code loads data into the 'inmobiliariaDataSet.Propiedades' table. You can move, or remove it, as needed.
            this.propiedadesTableAdapter.Fill(this.inmobiliariaDataSet.Propiedades);
            // TODO: This line of code loads data into the 'inmobiliariaDataSet.Pagos_alquiler' table. You can move, or remove it, as needed.
            this.pagos_alquilerTableAdapter.Fill(this.inmobiliariaDataSet.Pagos_alquiler);
            // TODO: This line of code loads data into the 'inmobiliariaDataSet.Inquilinos' table. You can move, or remove it, as needed.
            this.inquilinosTableAdapter.Fill(this.inmobiliariaDataSet.Inquilinos);
            // TODO: This line of code loads data into the 'inmobiliariaDataSet.Alquileres' table. You can move, or remove it, as needed.
            this.alquileresTableAdapter.Fill(this.inmobiliariaDataSet.Alquileres);

            ReportePagosRealizados rep = new ReportePagosRealizados();

            rep.SetDataSource(inmobiliariaDataSet);

            this.crystalReportViewer1.ReportSource = rep;



        }
    }
}
