using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Tasky.Models.Account;
using ToDo.WCF.EF;

namespace ToDo.WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService_UserManager" in both code and config file together.
    [ServiceContract]
    public interface IService_UserManager
    {
        [OperationContract]
        User GetNewUser(ServiceUserLoginModel loginUser);
        [OperationContract]
        User GetNewWebUser(ServiceUserLoginModel loginUser, string Username);
        [OperationContract]
        User GetUserWithUsername(ServiceUserLoginModel loginUser, string Username);
        [OperationContract]
        User GetUserWithGuid(ServiceUserLoginModel loginUser, Guid guid);
    }
}
