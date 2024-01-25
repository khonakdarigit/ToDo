using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Tasky.Models.Account;
using ToDo.WCF.EF;
using ToDo.WCF.EF.ViewMdels;

namespace ToDo.WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService_TaskManager" in both code and config file together.
    [ServiceContract]
    public interface IService_TaskManager
    {
        [OperationContract]
        Task GetTask(ServiceUserLoginModel loginModel, int id);

        [OperationContract]
        TaskVM GetTaskVM(ServiceUserLoginModel loginModel, Guid userGuid, int taskId);

        [OperationContract]
        Task AddNewTask(ServiceUserLoginModel loginUser, Task task);

        [OperationContract]
        List<Task> GetAllTasks(ServiceUserLoginModel loginUser, Guid userGuid);

        [OperationContract]
        List<TaskVM> GetAllTasksVM(ServiceUserLoginModel loginUser, Guid userGuid);

        [OperationContract]
        Task UpdateTask(ServiceUserLoginModel loginUser, Task task);

        [OperationContract]
        bool DeleteTask(ServiceUserLoginModel loginUser, Task task);
    }
}
