using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ToDo.WCF.EF;

namespace ToDo.WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService_TaskManager" in both code and config file together.
    [ServiceContract]
    public interface IService_TaskManager
    {
        [OperationContract]
        Task AddNewTask(Task task);

        [OperationContract]
        List<Task> GetAllTasks(Guid userGuid);

        [OperationContract]
        Task UpdateTask(Task task);

        [OperationContract]
        bool DeleteTask(Task task);
    }
}
