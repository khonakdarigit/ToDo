using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToDo.Web
{
    public static class ServiceUser
    {
        public static Tasky.Models.Account.ServiceUserLoginModel login { get; set; } = new Tasky.Models.Account.ServiceUserLoginModel()
        {
            Username = "WEB_APP",
            Password = "WEB_APP_PASS"
        };
    }
}