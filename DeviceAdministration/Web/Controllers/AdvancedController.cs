using System.Web.Mvc;
using Microsoft.Azure.Devices.Applications.RemoteMonitoring.DeviceAdmin.Web.Security;

namespace Microsoft.Azure.Devices.Applications.RemoteMonitoring.DeviceAdmin.Web.Controllers
{
    public class AdvancedController : Controller
    {
        [RequirePermission(Permission.CellularConn)]
        public ActionResult CellularConn()
        {
            return View();
        }

        [RequirePermission(Permission.HealthBeat)]
        public ActionResult HealthBeat()
        {
            return View();
        }

        [RequirePermission(Permission.LogicApps)]
        public ActionResult LogicApps()
        {
            return View();
        }

        public PartialViewResult ApiRegistration()
        {
            return PartialView("_ApiRegistration");
        }

        public PartialViewResult DeviceAssociation()
        {
            return PartialView("_DeviceAssociation");
        }

        public PartialViewResult SelectAdvancedProcess()
        {
            return PartialView("_SelectAdvancedProcess");
        }
    }
}