using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Tasky.Models.Account
{
    public class ServiceUserLoginModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
