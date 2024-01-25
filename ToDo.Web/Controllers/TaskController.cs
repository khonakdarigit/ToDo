using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToDo.Web.Services;

namespace ToDo.Web.Controllers
{
    [Authorize]
    public class TaskController : Controller
    {
        private Service_TaskyUserData _service_TaskyUserData;

        public TaskController()
        {
            _service_TaskyUserData = new Services.Service_TaskyUserData();
        }
        // GET: Task
        public ActionResult Index()
        {
            using (var service_TaskManagerClient = new ServiceReference_TaskManager.Service_TaskManagerClient())
            {
                var taskyUser = _service_TaskyUserData.GetTaskyUserWithUsername(User.Identity.GetUserName());

                var lstTask = service_TaskManagerClient.GetAllTasksVM(ServiceUser.login, taskyUser.GUID);
                return View(lstTask);
            }
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ServiceReference_TaskManager.Task model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            using (var service_TaskManagerClient = new ServiceReference_TaskManager.Service_TaskManagerClient())
            {
                var taskyUser = _service_TaskyUserData.GetTaskyUserWithUsername(User.Identity.GetUserName());

                service_TaskManagerClient.AddNewTask(ServiceUser.login, new ServiceReference_TaskManager.Task()
                {
                    IsComplete = false,
                    Title = model.Title,
                    UserId = taskyUser.Id
                });
            }

            return RedirectToAction(nameof(Index));
        }

        public ActionResult Details(int id)
        {
            using (var service_TaskManagerClient = new ServiceReference_TaskManager.Service_TaskManagerClient())
            {
                var taskyUser = _service_TaskyUserData.GetTaskyUserWithUsername(User.Identity.GetUserName());

                var taskVm = service_TaskManagerClient.GetTaskVM(ServiceUser.login, taskyUser.GUID,id);

                return View(taskVm);
            }
        }


        public ActionResult De324tails(int id)
        {
            return View();
        }
    }
}