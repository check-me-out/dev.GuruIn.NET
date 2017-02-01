using System;
using System.Web.Mvc;

namespace Sample.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Version()
        {
            var ver = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            var builtOn = new DateTime(2000, 1, 1);
            builtOn = builtOn.AddDays(ver.Build);
            var buildNumber = (DateTime.Now.Year - 2000) + builtOn.DayOfYear.ToString("#000");
            builtOn = builtOn.AddSeconds(ver.Revision * 2);

            return Content(string.Format("<div style=\"font-family: Verdana; font-size: 13px\">DLL version: {0}<br /> Build number: {1} (built on {2})</div>", ver, buildNumber, builtOn), "text/html");
        }
    }
}