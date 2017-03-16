using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication8.Models; 
namespace MvcApplication8.Controllers
{
    public class CrystalReportController : Controller
    {
        //
        // GET: /CrystalReport/       
            public ActionResult ReportView() 
        {
            CrystalViewModel model = new CrystalViewModel(); 
            string content = Url.Content("~/Reports/ReportView.aspx"); 
            model.ReportPath = content;
            return View("ReportView", model); 
        }
            //
            // GET: /CrystalReport2/       
            public ActionResult ReportBill()
            {
                Reportbill_VModel model = new Reportbill_VModel();
                string content = Url.Content("~/Reports/ReportView2.aspx");
                model.ReportBillPath = content;
                return View("ReportBill", model);
            } 
    }
}
