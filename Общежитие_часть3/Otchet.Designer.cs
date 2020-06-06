namespace Общежитие_часть3
{
    partial class Otchet
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
            this.Общежитие1DataSet = new Общежитие_часть3.Общежитие1DataSet();
            this.StudentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.StudentsTableAdapter = new Общежитие_часть3.Общежитие1DataSetTableAdapters.StudentsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Общежитие1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet_Otchet";
            reportDataSource1.Value = this.StudentsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Общежитие_часть3.Report_Otchet.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1070, 399);
            this.reportViewer1.TabIndex = 0;
            // 
            // Общежитие1DataSet
            // 
            this.Общежитие1DataSet.DataSetName = "Общежитие1DataSet";
            this.Общежитие1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // StudentsBindingSource
            // 
            this.StudentsBindingSource.DataMember = "Students";
            this.StudentsBindingSource.DataSource = this.Общежитие1DataSet;
            // 
            // StudentsTableAdapter
            // 
            this.StudentsTableAdapter.ClearBeforeFill = true;
            // 
            // Otchet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 399);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Otchet";
            this.Text = "Otchet";
            this.Load += new System.EventHandler(this.Otchet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Общежитие1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource StudentsBindingSource;
        private Общежитие1DataSet Общежитие1DataSet;
        private Общежитие1DataSetTableAdapters.StudentsTableAdapter StudentsTableAdapter;
    }
}