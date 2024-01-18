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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service_UserManager" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service_UserManager.svc or Service_UserManager.svc.cs at the Solution Explorer and start debugging.
    public class Service_UserManager : IService_UserManager
    {
        private Model_TaskyContainer db = new Model_TaskyContainer();

        public User GetNewUSer()
        {
            try
            {
                User user = new User()
                {
                    CreationDate = DateTime.Now,
                    GUID = Guid.NewGuid(),
                };

                db.Users.Add(user);

                var res = db.SaveChanges();
                if (res == 1)
                {
                    return user;
                }
                else { return null; }
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
    }
}
