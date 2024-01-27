using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using ToDo.Web.Services;

namespace ToDo.Web.Controllers
{
    public class TaskLogController : Controller
    {
        private Service_TaskyUserData _service_TaskyUserData;
        public TaskLogController()
        {
            _service_TaskyUserData = new Services.Service_TaskyUserData();
        }
        public ActionResult Create(int taskId)
        {
            var model = new ServiceReference_TaskLog.TaskLog() { TaskId = taskId };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ServiceReference_TaskLog.TaskLog model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            using (var service_TaskLogClient = new ServiceReference_TaskLog.Service_TaskLogClient())
            {
                var taskyUser = _service_TaskyUserData.GetTaskyUserWithUsername(User.Identity.GetUserName());


                model = service_TaskLogClient.AddNewTaskLog(ServiceUser.login, model);

                return RedirectToAction("Details", "Task", new { id = model.TaskId });
            }

        }

        public ActionResult Edit(int id)
        {
            using (var service_TaskLogClient = new ServiceReference_TaskLog.Service_TaskLogClient())
            {
                var model = service_TaskLogClient.GetTaskLog(ServiceUser.login, id);
                return View(model);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ServiceReference_TaskLog.TaskLog model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            using (var service_TaskLogClient = new ServiceReference_TaskLog.Service_TaskLogClient())
            {
                var taskLog = service_TaskLogClient.GetTaskLog(ServiceUser.login, model.Id);

                taskLog.Title = model.Title;
                taskLog.Description = model.Description;

                service_TaskLogClient.UpdateTaskLog(ServiceUser.login, taskLog);

                return RedirectToAction("Details", "Task", new { id = taskLog.TaskId });
            }

        }

        public ActionResult Delete(int id)
        {
            using (var service_TaskLogClient = new ServiceReference_TaskLog.Service_TaskLogClient())
            {
                var taskyUser = _service_TaskyUserData.GetTaskyUserWithUsername(User.Identity.GetUserName());

                var taskLog = service_TaskLogClient.GetTaskLog(ServiceUser.login, id);

                service_TaskLogClient.DeleteTaskLog(ServiceUser.login, id);

                return RedirectToAction("Details", "Task", new { id = taskLog.TaskId });
            }
        }
    }
}