using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using ToDo.WCF.EF;

namespace ToDo.WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService_UserManager" in both code and config file together.
    [ServiceContract]
    public interface IService_UserManager
    {
        [OperationContract]
        User GetNewUSer();
    }
}
