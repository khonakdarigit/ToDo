using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ToDo.Web.Controllers
{
    [Authorize]
    public class TaskController : Controller
    {
        // GET: Task
        public ActionResult Index()
        {
            using (var service_UserManagerClient = new ServiceReference_UserManager.Service_UserManagerClient())
            using (var service_TaskManagerClient = new ServiceReference_TaskManager.Service_TaskManagerClient())
            {
                var taskyUser = service_UserManagerClient.GetUserWithUsername(ServiceUser.login, User.Identity.GetUserName());

                var lstTask = service_TaskManagerClient.GetAllTasks(ServiceUser.login, taskyUser.GUID);
                return View(lstTask);
            }
        }
    }
}