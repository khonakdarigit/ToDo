using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ToDo.WCF.EF;

namespace ToDo.WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService_Log" in both code and config file together.
    [ServiceContract]
    public interface IService_Log
    {
        [OperationContract]
        void NewLog(Log log);
    }
}
