using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace azdeploy.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var addresses = System.Net.Dns.GetHostAddresses(Request.Url.Host);

            var ipHostInfo = Dns.GetHostEntry(Dns.GetHostName()); // `Dns.Resolve()` method is deprecated.
            var ipAddresses = ipHostInfo.AddressList;

            return View((object)ipAddresses);
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
    }
}