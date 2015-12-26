namespace MedicalStoreManagementSystem
{
    partial class DealerReportUI
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Dealer_tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicalstoremanagementDataSet = new MedicalStoreManagementSystem.medicalstoremanagementDataSet();
            this.Dealer_tableTableAdapter = new MedicalStoreManagementSystem.medicalstoremanagementDataSetTableAdapters.Dealer_tableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Dealer_tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalstoremanagementDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "medicalstoremanagement";
            reportDataSource1.Value = this.Dealer_tableBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "MedicalStoreManagementSystem.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(27, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(812, 425);
            this.reportViewer1.TabIndex = 0;
            // 
            // Dealer_tableBindingSource
            // 
            this.Dealer_tableBindingSource.DataMember = "Dealer_table";
            this.Dealer_tableBindingSource.DataSource = this.medicalstoremanagementDataSet;
            // 
            // medicalstoremanagementDataSet
            // 
            this.medicalstoremanagementDataSet.DataSetName = "medicalstoremanagementDataSet";
            this.medicalstoremanagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Dealer_tableTableAdapter
            // 
            this.Dealer_tableTableAdapter.ClearBeforeFill = true;
            // 
            // DealerReportUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 463);
            this.Controls.Add(this.reportViewer1);
            this.Name = "DealerReportUI";
            this.Text = "DealerReportUI";
            this.Load += new System.EventHandler(this.DealerReportUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dealer_tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalstoremanagementDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Dealer_tableBindingSource;
        private medicalstoremanagementDataSet medicalstoremanagementDataSet;
        private medicalstoremanagementDataSetTableAdapters.Dealer_tableTableAdapter Dealer_tableTableAdapter;
    }
}