namespace Reportes
{
    partial class frmReportePagosRealizados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.inmobiliariaDataSet = new Reportes.InmobiliariaDataSet();
            this.alquileresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alquileresTableAdapter = new Reportes.InmobiliariaDataSetTableAdapters.AlquileresTableAdapter();
            this.tableAdapterManager = new Reportes.InmobiliariaDataSetTableAdapters.TableAdapterManager();
            this.inquilinosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inquilinosTableAdapter = new Reportes.InmobiliariaDataSetTableAdapters.InquilinosTableAdapter();
            this.pagos_alquilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pagos_alquilerTableAdapter = new Reportes.InmobiliariaDataSetTableAdapters.Pagos_alquilerTableAdapter();
            this.propiedadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.propiedadesTableAdapter = new Reportes.InmobiliariaDataSetTableAdapters.PropiedadesTableAdapter();
            this.unidadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.unidadesTableAdapter = new Reportes.InmobiliariaDataSetTableAdapters.UnidadesTableAdapter();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.inmobiliariaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alquileresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inquilinosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagos_alquilerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propiedadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidadesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // inmobiliariaDataSet
            // 
            this.inmobiliariaDataSet.DataSetName = "InmobiliariaDataSet";
            this.inmobiliariaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alquileresBindingSource
            // 
            this.alquileresBindingSource.DataMember = "Alquileres";
            this.alquileresBindingSource.DataSource = this.inmobiliariaDataSet;
            // 
            // alquileresTableAdapter
            // 
            this.alquileresTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdministradoresTableAdapter = null;
            this.tableAdapterManager.AlquileresTableAdapter = this.alquileresTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ContratistasTableAdapter = null;
            this.tableAdapterManager.ContratosTableAdapter = null;
            this.tableAdapterManager.Cuenta_corrienteTableAdapter = null;
            this.tableAdapterManager.FotosTableAdapter = null;
            this.tableAdapterManager.InquilinosTableAdapter = this.inquilinosTableAdapter;
            this.tableAdapterManager.MejorasTableAdapter = null;
            this.tableAdapterManager.NumeroUltimaFotoTableAdapter = null;
            this.tableAdapterManager.Pagos_alquilerTableAdapter = this.pagos_alquilerTableAdapter;
            this.tableAdapterManager.Pagos_seguroTableAdapter = null;
            this.tableAdapterManager.PropiedadesTableAdapter = this.propiedadesTableAdapter;
            this.tableAdapterManager.ReparacionesTableAdapter = null;
            this.tableAdapterManager.SegurosTableAdapter = null;
            this.tableAdapterManager.UnidadesTableAdapter = this.unidadesTableAdapter;
            this.tableAdapterManager.UpdateOrder = Reportes.InmobiliariaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Valores_mensualesTableAdapter = null;
            // 
            // inquilinosBindingSource
            // 
            this.inquilinosBindingSource.DataMember = "Inquilinos";
            this.inquilinosBindingSource.DataSource = this.inmobiliariaDataSet;
            // 
            // inquilinosTableAdapter
            // 
            this.inquilinosTableAdapter.ClearBeforeFill = true;
            // 
            // pagos_alquilerBindingSource
            // 
            this.pagos_alquilerBindingSource.DataMember = "Pagos_alquiler";
            this.pagos_alquilerBindingSource.DataSource = this.inmobiliariaDataSet;
            // 
            // pagos_alquilerTableAdapter
            // 
            this.pagos_alquilerTableAdapter.ClearBeforeFill = true;
            // 
            // propiedadesBindingSource
            // 
            this.propiedadesBindingSource.DataMember = "Propiedades";
            this.propiedadesBindingSource.DataSource = this.inmobiliariaDataSet;
            // 
            // propiedadesTableAdapter
            // 
            this.propiedadesTableAdapter.ClearBeforeFill = true;
            // 
            // unidadesBindingSource
            // 
            this.unidadesBindingSource.DataMember = "Unidades";
            this.unidadesBindingSource.DataSource = this.inmobiliariaDataSet;
            // 
            // unidadesTableAdapter
            // 
            this.unidadesTableAdapter.ClearBeforeFill = true;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(676, 399);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // frmReportePagosRealizados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 399);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "frmReportePagosRealizados";
            this.Text = "frmReportePagosRealizados";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmReportePagosRealizados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inmobiliariaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alquileresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inquilinosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagos_alquilerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propiedadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidadesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private InmobiliariaDataSet inmobiliariaDataSet;
        private System.Windows.Forms.BindingSource alquileresBindingSource;
        private InmobiliariaDataSetTableAdapters.AlquileresTableAdapter alquileresTableAdapter;
        private InmobiliariaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private InmobiliariaDataSetTableAdapters.InquilinosTableAdapter inquilinosTableAdapter;
        private System.Windows.Forms.BindingSource inquilinosBindingSource;
        private InmobiliariaDataSetTableAdapters.Pagos_alquilerTableAdapter pagos_alquilerTableAdapter;
        private System.Windows.Forms.BindingSource pagos_alquilerBindingSource;
        private InmobiliariaDataSetTableAdapters.PropiedadesTableAdapter propiedadesTableAdapter;
        private System.Windows.Forms.BindingSource propiedadesBindingSource;
        private InmobiliariaDataSetTableAdapters.UnidadesTableAdapter unidadesTableAdapter;
        private System.Windows.Forms.BindingSource unidadesBindingSource;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
    }
}