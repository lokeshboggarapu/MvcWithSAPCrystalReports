using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;
using CrystalDecisions.Shared;
using System.Configuration;
namespace MvcApplication8.Reports
{
    public partial class ReportView2 : System.Web.UI.Page
    {
        CrystalDecisions.CrystalReports.Engine.ReportDocument reportDocument = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadReport();
        }

        protected void Preview_Click(object sender, EventArgs e)
        {
            LoadReport();
        }


        private void LoadReport()
        {
            if (this.reportDocument != null)
            {
                this.reportDocument.Close();
                this.reportDocument.Dispose();
            }
            CrystalReportViewer2.ToolPanelView = CrystalDecisions.Web.ToolPanelViewType.None;
            CrystalReportViewer2.HasToggleGroupTreeButton = false;
            CrystalReportViewer2.HasToggleParameterPanelButton = false;
            NorthwindEntities context = new NorthwindEntities();
            List<Customer> Employeeli = new List<Customer>();
            Employeeli = context.Customers.ToList();
            ReportDocument reportDocument = new ReportDocument();            
            string reportPath = Server.MapPath("~/Reports/CrystalReport2.rpt");
            reportDocument.Load(reportPath);
            reportDocument.SetDataSource(Employeeli);
            CrystalReportViewer2.ReportSource = reportDocument;
        }
       
    }
}