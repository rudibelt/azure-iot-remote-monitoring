using System.Web.Mvc;
using Microsoft.Azure.Devices.Applications.RemoteMonitoring.DeviceAdmin.Web.Security;

namespace Microsoft.Azure.Devices.Applications.RemoteMonitoring.DeviceAdmin.Web.Controllers
{
    public class AdvancedController : Controller
    {
        [RequirePermission(Permission.ViewAdvanced)]
        public ActionResult CellularConn()
        {
            return View();
        }

        [RequirePermission(Permission.ViewAdvanced)]
        public ActionResult HealthBeat()
        {
            return View();
        }

        [RequirePermission(Permission.ViewAdvanced)]
        public ActionResult LogicApps()
        {
            return View();
        }
    }
}