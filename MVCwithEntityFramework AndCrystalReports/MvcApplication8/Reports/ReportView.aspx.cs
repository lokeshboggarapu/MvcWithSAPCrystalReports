using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;
using System.Collections;
namespace MvcApplication8.Reports
{
    public partial class ReportView : System.Web.UI.Page
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
            CrystalReportViewer1.HasToggleGroupTreeButton = false;
            CrystalReportViewer1.HasToggleParameterPanelButton = false;

            NorthwindEntities context = new NorthwindEntities();
            List<Customer> Employeeli = new List<Customer>();
            Employeeli = context.Customers.ToList();
             Employeeli.
            ReportDocument reportDocument = new ReportDocument();
            string reportPath = Server.MapPath("~/Reports/CrystalReport1.rpt");
          
            
            reportDocument.Load(reportPath);
            reportDocument.SetDataSource(Employeeli);
            CrystalReportViewer1.ReportSource = reportDocument;
            //  QueryStringParameter functionality test
          //  Response.Redirect("ReportView2.aspx?id=456");
            }
       
    }
    
 }
