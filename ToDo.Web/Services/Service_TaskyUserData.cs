using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ToDo.Web.ServiceReference_UserManager;

namespace ToDo.Web.Services
{
    public class Service_TaskyUserData : IService_TaskyUserData
    {
        public User GetTaskyUserWithUsername(string username)
        {
            using (var service_UserManagerClient = new Service_UserManagerClient())
            {
                var TaskuUser = service_UserManagerClient.GetUserWithUsername(ServiceUser.login, username);
                return TaskuUser;
            }
        }
    }
}