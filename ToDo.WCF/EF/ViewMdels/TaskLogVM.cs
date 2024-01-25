using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ToDo.WCF.EF.ViewMdels
{
    [DataContract]
    public class TaskLogVM
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public System.DateTimeOffset CreationDate { get; set; }
        [DataMember]
        public int TaskId { get; set; }
    }
}