using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Winform
{
    public static class ServiceUser
    {
        public static Tasky.Models.Account.ServiceUserLoginModel login { get; set; } = new Tasky.Models.Account.ServiceUserLoginModel()
        {
            Username = "WIN_APP",
            Password = "WIN_APP_PASS"
        };
    }
}
