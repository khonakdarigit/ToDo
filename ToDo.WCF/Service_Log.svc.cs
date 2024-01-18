using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ToDo.WCF.EF;

namespace ToDo.WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service_Log" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service_Log.svc or Service_Log.svc.cs at the Solution Explorer and start debugging.
    public class Service_Log : IService_Log
    {
        private Model_TaskyContainer db = new Model_TaskyContainer();
        public void NewLog(Log log)
        {
            try
            {
                log.Date = DateTime.Now;

                db.Logs.Add(log);
                db.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                //SaveToFile(log);
            }
        }
    }
}
