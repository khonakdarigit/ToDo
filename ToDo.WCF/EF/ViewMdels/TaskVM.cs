using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ToDo.WCF.EF.ViewMdels
{
    [DataContract]
    [Serializable]
    public class TaskVM
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]


        public string Title { get; set; }
        [DataMember]

        public System.DateTimeOffset CreationDate { get; set; }
        [DataMember]

        public bool IsComplete { get; set; }
        [DataMember]

        public Nullable<System.DateTimeOffset> DoneDate { get; set; }
        [DataMember]

        public int UserId { get; set; }
        [DataMember]

        public int TaskLogCount { get; set; }
        [DataMember]

        public List<TaskLogVM> TaskLogs { get; set; }
    }
}