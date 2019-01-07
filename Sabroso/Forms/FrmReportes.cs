using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sabroso
{
    public partial class FrmReportes : Form
    {
        public ReportParameter[] Parametros { get; set; }
        public BindingSource DataSource { get; set; }
        public string DataSourceName { get; set; }
        public FrmReportes()
        {
            InitializeComponent();
            reportViewerReporte.LocalReport.SetParameters(Parametros);
            reportViewerReporte.LocalReport.DataSources.Add(new ReportDataSource(DataSourceName, DataSource));
        }
        public FrmReportes(string dataSourceName, BindingSource dataSource, ReportParameter[] parametros)
        {
            DataSourceName = dataSourceName;
            Parametros = parametros;
            DataSource = dataSource;
            InitializeComponent();
            reportViewerReporte.LocalReport.SetParameters(Parametros);
            reportViewerReporte.LocalReport.DataSources.Add(new ReportDataSource(DataSourceName, DataSource));
        }
        private void FrmReportes_Load(object sender, EventArgs e)
        {
            
            this.reportViewerReporte.RefreshReport();
            
        }
    }
}
