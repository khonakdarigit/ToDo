using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ToDo.WCF.EF;

namespace ToDo.WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service_TaskLog" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service_TaskLog.svc or Service_TaskLog.svc.cs at the Solution Explorer and start debugging.
    public class Service_TaskLog : IService_TaskLog
    {
        private Model_TaskyContainer db = new Model_TaskyContainer();

        public TaskLog AddNewTaskLog(TaskLog taskLog)
        {
            taskLog.CreationDate = DateTime.Now;
            db.TaskLogs.Add(taskLog);
            db.SaveChanges();

            return taskLog;

        }

        public bool DeleteTaskLog(int TaskLogId)
        {
            var RemoveTaskLog=db.TaskLogs.FirstOrDefault(c => c.Id == TaskLogId);
            db.TaskLogs.Remove(RemoveTaskLog);
            db.SaveChanges() ;
            return true;
        }

        public List<TaskLog> GetAllTaskLog(int taskId)
        {
            return db.TaskLogs.Where(c => c.TaskId == taskId).OrderByDescending(c => c.CreationDate).ToList();
        }

        public TaskLog UpdateTaskLog(TaskLog taskLog)
        {
            db.TaskLogs.AddOrUpdate(taskLog);
            db.SaveChanges();
            return taskLog;
        }
    }
}
