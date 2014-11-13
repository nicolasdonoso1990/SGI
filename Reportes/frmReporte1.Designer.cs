namespace Reportes
{
    partial class frmReporte1
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
            this.inquilinosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inquilinosTableAdapter = new Reportes.InmobiliariaDataSetTableAdapters.InquilinosTableAdapter();
            this.tableAdapterManager = new Reportes.InmobiliariaDataSetTableAdapters.TableAdapterManager();
            this.cuenta_corrienteTableAdapter = new Reportes.InmobiliariaDataSetTableAdapters.Cuenta_corrienteTableAdapter();
            this.cuenta_corrienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.inmobiliariaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inquilinosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuenta_corrienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // inmobiliariaDataSet
            // 
            this.inmobiliariaDataSet.DataSetName = "InmobiliariaDataSet";
            this.inmobiliariaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdministradoresTableAdapter = null;
            this.tableAdapterManager.AlquileresTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ContratistasTableAdapter = null;
            this.tableAdapterManager.ContratosTableAdapter = null;
            this.tableAdapterManager.Cuenta_corrienteTableAdapter = this.cuenta_corrienteTableAdapter;
            this.tableAdapterManager.FotosTableAdapter = null;
            this.tableAdapterManager.InquilinosTableAdapter = this.inquilinosTableAdapter;
            this.tableAdapterManager.MejorasTableAdapter = null;
            this.tableAdapterManager.NumeroUltimaFotoTableAdapter = null;
            this.tableAdapterManager.Pagos_alquilerTableAdapter = null;
            this.tableAdapterManager.Pagos_seguroTableAdapter = null;
            this.tableAdapterManager.PropiedadesTableAdapter = null;
            this.tableAdapterManager.ReparacionesTableAdapter = null;
            this.tableAdapterManager.SegurosTableAdapter = null;
            this.tableAdapterManager.UnidadesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Reportes.InmobiliariaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Valores_mensualesTableAdapter = null;
            // 
            // cuenta_corrienteTableAdapter
            // 
            this.cuenta_corrienteTableAdapter.ClearBeforeFill = true;
            // 
            // cuenta_corrienteBindingSource
            // 
            this.cuenta_corrienteBindingSource.DataMember = "Cuenta_corriente";
            this.cuenta_corrienteBindingSource.DataSource = this.inmobiliariaDataSet;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(715, 351);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // frmReporte1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 351);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "frmReporte1";
            this.Text = "frmReporte1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmReporte1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inmobiliariaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inquilinosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuenta_corrienteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private InmobiliariaDataSet inmobiliariaDataSet;
        private System.Windows.Forms.BindingSource inquilinosBindingSource;
        private InmobiliariaDataSetTableAdapters.InquilinosTableAdapter inquilinosTableAdapter;
        private InmobiliariaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private InmobiliariaDataSetTableAdapters.Cuenta_corrienteTableAdapter cuenta_corrienteTableAdapter;
        private System.Windows.Forms.BindingSource cuenta_corrienteBindingSource;
        public CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;



    }
}