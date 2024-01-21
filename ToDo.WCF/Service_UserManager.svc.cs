using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Security.Policy;
using System.ServiceModel;
using System.Text;
using Tasky.Models.Account;
using Tasky.Models.Tools;
using ToDo.WCF.EF;
using ToDo.WCF.ServiceUser;

namespace ToDo.WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service_UserManager" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service_UserManager.svc or Service_UserManager.svc.cs at the Solution Explorer and start debugging.
    public class Service_UserManager : IService_UserManager
    {
        private Model_TaskyContainer db = new Model_TaskyContainer();

        public User GetNewUser(ServiceUserLoginModel loginModel)
        {
            if (ServiceUserData.CheckUser(loginModel))
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

                    service_Log.NewLog(loginModel, new Log
                    {
                        Date = DateTime.Now,
                        LogTitle = ex.Message,
                        LogDetail = ex.StackTrace,
                        LogLevel = LogLevel.Error.ToString(),
                    });
                }
            }
            return null;
        }

        public User GetNewWebUser(ServiceUserLoginModel loginModel, string Username)
        {
            if (ServiceUserData.CheckUser(loginModel))
            {
                try
                {
                    User user = new User()
                    {
                        CreationDate = DateTime.Now,
                        UserName = Username,
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

                    service_Log.NewLog(loginModel, new Log
                    {
                        Date = DateTime.Now,
                        LogTitle = ex.Message,
                        LogDetail = ex.StackTrace,
                        LogLevel = LogLevel.Error.ToString(),
                    });
                }
            }
            return null;
        }

        public User GetUserWithGuid(ServiceUserLoginModel loginModel, Guid guid)
        {
            if (ServiceUserData.CheckUser(loginModel))
            { 
                return db.Users.FirstOrDefault(c => c.GUID == guid);
            }
            return null;
        }

        public User GetUserWithUsername(ServiceUserLoginModel loginModel, string Username)
        {
            if (ServiceUserData.CheckUser(loginModel))
            {
                return db.Users.FirstOrDefault(c => c.UserName == Username);
            }
            return null;
        }
    }
}
