using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Tasky.Models.Account;
using ToDo.WCF.EF;

namespace ToDo.WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService_TaskLog" in both code and config file together.
    [ServiceContract]
    public interface IService_TaskLog
    {
        [OperationContract]
        TaskLog GetTaskLog(ServiceUserLoginModel loginUser, int Id);
        [OperationContract]
        List<TaskLog> GetAllTaskLog(ServiceUserLoginModel loginUser, int TaskId);

        [OperationContract]
        TaskLog AddNewTaskLog(ServiceUserLoginModel loginUser, TaskLog taskLog);

        [OperationContract]
        TaskLog UpdateTaskLog(ServiceUserLoginModel loginUser, TaskLog taskLog);

        [OperationContract]
        bool DeleteTaskLog(ServiceUserLoginModel loginUser, int TaskLogId);
    }
}
