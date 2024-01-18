using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Tasky.Models.Tools;
using ToDo.WCF.EF;

namespace ToDo.WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service_TaskManager" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service_TaskManager.svc or Service_TaskManager.svc.cs at the Solution Explorer and start debugging.
    public class Service_TaskManager : IService_TaskManager
    {
        private Model_TaskyContainer db = new Model_TaskyContainer();

        public Task AddNewTask(Task task)
        {
            try
            {
                task.CreationDate = DateTime.Now;
                task.DoneDate = DateTime.Now;
                db.Tasks.Add(task);
                var res = db.SaveChanges();
                if (res == 1)
                {
                    return task;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                Service_Log service_Log = new Service_Log();

                service_Log.NewLog(new Log
                {
                    Date = DateTime.Now,
                    LogTitle = ex.Message,
                    LogDetail = ex.StackTrace,
                    LogLevel = LogLevel.Error.ToString(),
                });
            }
            return null;

        }

        public List<Task> GetAllTasks(Guid userGuid)
        {
            return db.Tasks.Where(c => c.User.GUID == userGuid).OrderByDescending(c=>c.CreationDate).ToList();
        }
    }
}
