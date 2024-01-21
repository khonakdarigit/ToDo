using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tasky.Models.Account;

namespace ToDo.WCF.ServiceUser
{
    public static class ServiceUserData
    {
        public static List<ServiceUserLoginModel> lstServiceUserData { get; set; } = new List<ServiceUserLoginModel>()
        {
            new ServiceUserLoginModel(){ Username="WIN_APP",Password="WIN_APP_PASS"},
            new ServiceUserLoginModel(){ Username="WEB_APP",Password="WEB_APP_PASS"}
        };

        public static bool CheckUser(ServiceUserLoginModel serviceUserLoginModel)
        {
            if (lstServiceUserData.Any(c =>
                c.Username == serviceUserLoginModel.Username &&
                c.Password == serviceUserLoginModel.Password))
            {
                return true;
            }
            else
            {
                throw new Exception("Invalid User");
            }
        }
    }
}