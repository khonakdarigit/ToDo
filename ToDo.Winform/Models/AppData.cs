﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Winform.Models
{
    public class AppData
    {
        public AppOptions appOptions { get; set; }
        public ServiceReference_UserManager.User User { get; set; }
    }
}
