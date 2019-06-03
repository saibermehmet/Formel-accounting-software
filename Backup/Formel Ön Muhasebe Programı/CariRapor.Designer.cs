namespace Formel_Ön_Muhasebe_Programı
{
    partial class CariRapor
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CariRapor));
            this.StilYonetici = new DevComponents.DotNetBar.StyleManager(this.components);
            this.report_Cari = new Microsoft.Reporting.WinForms.ReportViewer();
            this.MuhasebeDataSet = new Formel_Ön_Muhasebe_Programı.MuhasebeDataSet();
            this.CariListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CariListTableAdapter = new Formel_Ön_Muhasebe_Programı.MuhasebeDataSetTableAdapters.CariListTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.MuhasebeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CariListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // StilYonetici
            // 
            this.StilYonetici.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Black;
            // 
            // report_Cari
            // 
            this.report_Cari.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "MuhasebeDataSet_CariList";
            reportDataSource1.Value = this.CariListBindingSource;
            this.report_Cari.LocalReport.DataSources.Add(reportDataSource1);
            this.report_Cari.LocalReport.ReportEmbeddedResource = "Formel_Ön_Muhasebe_Programı.CariRapor.rdlc";
            this.report_Cari.Location = new System.Drawing.Point(0, 0);
            this.report_Cari.Name = "report_Cari";
            this.report_Cari.Size = new System.Drawing.Size(821, 580);
            this.report_Cari.TabIndex = 0;
            // 
            // MuhasebeDataSet
            // 
            this.MuhasebeDataSet.DataSetName = "MuhasebeDataSet";
            this.MuhasebeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CariListBindingSource
            // 
            this.CariListBindingSource.DataMember = "CariList";
            this.CariListBindingSource.DataSource = this.MuhasebeDataSet;
            // 
            // CariListTableAdapter
            // 
            this.CariListTableAdapter.ClearBeforeFill = true;
            // 
            // CariRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 580);
            this.Controls.Add(this.report_Cari);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CariRapor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CariRapor";
            this.Load += new System.EventHandler(this.CariRapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MuhasebeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CariListBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.StyleManager StilYonetici;
        private Microsoft.Reporting.WinForms.ReportViewer report_Cari;
        private System.Windows.Forms.BindingSource CariListBindingSource;
        private MuhasebeDataSet MuhasebeDataSet;
        private Formel_Ön_Muhasebe_Programı.MuhasebeDataSetTableAdapters.CariListTableAdapter CariListTableAdapter;
    }
}