using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Web.Services
{
    public interface IService_TaskyUserData
    {
        ServiceReference_UserManager.User GetTaskyUserWithUsername(string username);
    }
}
