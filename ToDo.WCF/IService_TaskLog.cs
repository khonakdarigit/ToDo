using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ToDo.WCF.EF;

namespace ToDo.WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService_TaskLog" in both code and config file together.
    [ServiceContract]
    public interface IService_TaskLog
    {
        [OperationContract]
        List<TaskLog> GetAllTaskLog(int TaskId);

        [OperationContract]
        TaskLog AddNewTaskLog(TaskLog taskLog);

        [OperationContract]
        TaskLog UpdateTaskLog(TaskLog taskLog);
        [OperationContract]
        bool DeleteTaskLog(int TaskLogId);
    }
}
