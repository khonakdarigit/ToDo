using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Tasky.Models.Account;
using ToDo.WCF.EF;
using ToDo.WCF.ServiceUser;

namespace ToDo.WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service_TaskLog" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service_TaskLog.svc or Service_TaskLog.svc.cs at the Solution Explorer and start debugging.
    public class Service_TaskLog : IService_TaskLog
    {
        private Model_TaskyContainer db = new Model_TaskyContainer();

        public TaskLog GetTaskLog(ServiceUserLoginModel loginModel, int Id)
        {
            if (ServiceUserData.CheckUser(loginModel))
            {
                return db.TaskLogs.FirstOrDefault(t => t.Id == Id);
            }
            return null;
        }

        public TaskLog AddNewTaskLog(ServiceUserLoginModel loginModel, TaskLog taskLog)
        {
            if (ServiceUserData.CheckUser(loginModel))
            {
                taskLog.CreationDate = DateTime.Now;
                db.TaskLogs.Add(taskLog);
                db.SaveChanges();

                return taskLog;
            }
            return null;
        }

        public bool DeleteTaskLog(ServiceUserLoginModel loginModel, int TaskLogId)
        {
            if (ServiceUserData.CheckUser(loginModel))
            {
                var RemoveTaskLog = db.TaskLogs.FirstOrDefault(c => c.Id == TaskLogId);
                db.TaskLogs.Remove(RemoveTaskLog);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public List<TaskLog> GetAllTaskLog(ServiceUserLoginModel loginModel, int taskId)
        {
            if (ServiceUserData.CheckUser(loginModel))
            {
                return db.TaskLogs.Where(c => c.TaskId == taskId).OrderByDescending(c => c.CreationDate).ToList();
            }
            return null;
        }



        public TaskLog UpdateTaskLog(ServiceUserLoginModel loginModel, TaskLog taskLog)
        {
            if (ServiceUserData.CheckUser(loginModel))
            {
                db.TaskLogs.AddOrUpdate(taskLog);
                db.SaveChanges();
                return taskLog;
            }
            return null;
        }
    }
}
