﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ToDo.Winform.ServiceReference_TaskLog {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TaskLog", Namespace="http://schemas.datacontract.org/2004/07/ToDo.WCF.EF")]
    [System.SerializableAttribute()]
    public partial class TaskLog : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTimeOffset CreationDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ToDo.Winform.ServiceReference_TaskLog.Task TaskField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TaskIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TitleField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTimeOffset CreationDate {
            get {
                return this.CreationDateField;
            }
            set {
                if ((this.CreationDateField.Equals(value) != true)) {
                    this.CreationDateField = value;
                    this.RaisePropertyChanged("CreationDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ToDo.Winform.ServiceReference_TaskLog.Task Task {
            get {
                return this.TaskField;
            }
            set {
                if ((object.ReferenceEquals(this.TaskField, value) != true)) {
                    this.TaskField = value;
                    this.RaisePropertyChanged("Task");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int TaskId {
            get {
                return this.TaskIdField;
            }
            set {
                if ((this.TaskIdField.Equals(value) != true)) {
                    this.TaskIdField = value;
                    this.RaisePropertyChanged("TaskId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Title {
            get {
                return this.TitleField;
            }
            set {
                if ((object.ReferenceEquals(this.TitleField, value) != true)) {
                    this.TitleField = value;
                    this.RaisePropertyChanged("Title");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Task", Namespace="http://schemas.datacontract.org/2004/07/ToDo.WCF.EF")]
    [System.SerializableAttribute()]
    public partial class Task : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTimeOffset CreationDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTimeOffset> DoneDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsCompleteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<ToDo.Winform.ServiceReference_TaskLog.TaskLog> TaskLogsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TitleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ToDo.Winform.ServiceReference_TaskLog.User UserField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int UserIdField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTimeOffset CreationDate {
            get {
                return this.CreationDateField;
            }
            set {
                if ((this.CreationDateField.Equals(value) != true)) {
                    this.CreationDateField = value;
                    this.RaisePropertyChanged("CreationDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTimeOffset> DoneDate {
            get {
                return this.DoneDateField;
            }
            set {
                if ((this.DoneDateField.Equals(value) != true)) {
                    this.DoneDateField = value;
                    this.RaisePropertyChanged("DoneDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsComplete {
            get {
                return this.IsCompleteField;
            }
            set {
                if ((this.IsCompleteField.Equals(value) != true)) {
                    this.IsCompleteField = value;
                    this.RaisePropertyChanged("IsComplete");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<ToDo.Winform.ServiceReference_TaskLog.TaskLog> TaskLogs {
            get {
                return this.TaskLogsField;
            }
            set {
                if ((object.ReferenceEquals(this.TaskLogsField, value) != true)) {
                    this.TaskLogsField = value;
                    this.RaisePropertyChanged("TaskLogs");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Title {
            get {
                return this.TitleField;
            }
            set {
                if ((object.ReferenceEquals(this.TitleField, value) != true)) {
                    this.TitleField = value;
                    this.RaisePropertyChanged("Title");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ToDo.Winform.ServiceReference_TaskLog.User User {
            get {
                return this.UserField;
            }
            set {
                if ((object.ReferenceEquals(this.UserField, value) != true)) {
                    this.UserField = value;
                    this.RaisePropertyChanged("User");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int UserId {
            get {
                return this.UserIdField;
            }
            set {
                if ((this.UserIdField.Equals(value) != true)) {
                    this.UserIdField = value;
                    this.RaisePropertyChanged("UserId");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/ToDo.WCF.EF")]
    [System.SerializableAttribute()]
    public partial class User : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTimeOffset> CreationDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid GUIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<ToDo.Winform.ServiceReference_TaskLog.Task> TasksField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserNameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTimeOffset> CreationDate {
            get {
                return this.CreationDateField;
            }
            set {
                if ((this.CreationDateField.Equals(value) != true)) {
                    this.CreationDateField = value;
                    this.RaisePropertyChanged("CreationDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid GUID {
            get {
                return this.GUIDField;
            }
            set {
                if ((this.GUIDField.Equals(value) != true)) {
                    this.GUIDField = value;
                    this.RaisePropertyChanged("GUID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<ToDo.Winform.ServiceReference_TaskLog.Task> Tasks {
            get {
                return this.TasksField;
            }
            set {
                if ((object.ReferenceEquals(this.TasksField, value) != true)) {
                    this.TasksField = value;
                    this.RaisePropertyChanged("Tasks");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserName {
            get {
                return this.UserNameField;
            }
            set {
                if ((object.ReferenceEquals(this.UserNameField, value) != true)) {
                    this.UserNameField = value;
                    this.RaisePropertyChanged("UserName");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference_TaskLog.IService_TaskLog")]
    public interface IService_TaskLog {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_TaskLog/GetAllTaskLog", ReplyAction="http://tempuri.org/IService_TaskLog/GetAllTaskLogResponse")]
        System.Collections.Generic.List<ToDo.Winform.ServiceReference_TaskLog.TaskLog> GetAllTaskLog(Tasky.Models.Account.ServiceUserLoginModel loginUser, int TaskId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_TaskLog/GetAllTaskLog", ReplyAction="http://tempuri.org/IService_TaskLog/GetAllTaskLogResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<ToDo.Winform.ServiceReference_TaskLog.TaskLog>> GetAllTaskLogAsync(Tasky.Models.Account.ServiceUserLoginModel loginUser, int TaskId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_TaskLog/AddNewTaskLog", ReplyAction="http://tempuri.org/IService_TaskLog/AddNewTaskLogResponse")]
        ToDo.Winform.ServiceReference_TaskLog.TaskLog AddNewTaskLog(Tasky.Models.Account.ServiceUserLoginModel loginUser, ToDo.Winform.ServiceReference_TaskLog.TaskLog taskLog);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_TaskLog/AddNewTaskLog", ReplyAction="http://tempuri.org/IService_TaskLog/AddNewTaskLogResponse")]
        System.Threading.Tasks.Task<ToDo.Winform.ServiceReference_TaskLog.TaskLog> AddNewTaskLogAsync(Tasky.Models.Account.ServiceUserLoginModel loginUser, ToDo.Winform.ServiceReference_TaskLog.TaskLog taskLog);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_TaskLog/UpdateTaskLog", ReplyAction="http://tempuri.org/IService_TaskLog/UpdateTaskLogResponse")]
        ToDo.Winform.ServiceReference_TaskLog.TaskLog UpdateTaskLog(Tasky.Models.Account.ServiceUserLoginModel loginUser, ToDo.Winform.ServiceReference_TaskLog.TaskLog taskLog);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_TaskLog/UpdateTaskLog", ReplyAction="http://tempuri.org/IService_TaskLog/UpdateTaskLogResponse")]
        System.Threading.Tasks.Task<ToDo.Winform.ServiceReference_TaskLog.TaskLog> UpdateTaskLogAsync(Tasky.Models.Account.ServiceUserLoginModel loginUser, ToDo.Winform.ServiceReference_TaskLog.TaskLog taskLog);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_TaskLog/DeleteTaskLog", ReplyAction="http://tempuri.org/IService_TaskLog/DeleteTaskLogResponse")]
        bool DeleteTaskLog(Tasky.Models.Account.ServiceUserLoginModel loginUser, int TaskLogId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_TaskLog/DeleteTaskLog", ReplyAction="http://tempuri.org/IService_TaskLog/DeleteTaskLogResponse")]
        System.Threading.Tasks.Task<bool> DeleteTaskLogAsync(Tasky.Models.Account.ServiceUserLoginModel loginUser, int TaskLogId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService_TaskLogChannel : ToDo.Winform.ServiceReference_TaskLog.IService_TaskLog, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service_TaskLogClient : System.ServiceModel.ClientBase<ToDo.Winform.ServiceReference_TaskLog.IService_TaskLog>, ToDo.Winform.ServiceReference_TaskLog.IService_TaskLog {
        
        public Service_TaskLogClient() {
        }
        
        public Service_TaskLogClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service_TaskLogClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service_TaskLogClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service_TaskLogClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.List<ToDo.Winform.ServiceReference_TaskLog.TaskLog> GetAllTaskLog(Tasky.Models.Account.ServiceUserLoginModel loginUser, int TaskId) {
            return base.Channel.GetAllTaskLog(loginUser, TaskId);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<ToDo.Winform.ServiceReference_TaskLog.TaskLog>> GetAllTaskLogAsync(Tasky.Models.Account.ServiceUserLoginModel loginUser, int TaskId) {
            return base.Channel.GetAllTaskLogAsync(loginUser, TaskId);
        }
        
        public ToDo.Winform.ServiceReference_TaskLog.TaskLog AddNewTaskLog(Tasky.Models.Account.ServiceUserLoginModel loginUser, ToDo.Winform.ServiceReference_TaskLog.TaskLog taskLog) {
            return base.Channel.AddNewTaskLog(loginUser, taskLog);
        }
        
        public System.Threading.Tasks.Task<ToDo.Winform.ServiceReference_TaskLog.TaskLog> AddNewTaskLogAsync(Tasky.Models.Account.ServiceUserLoginModel loginUser, ToDo.Winform.ServiceReference_TaskLog.TaskLog taskLog) {
            return base.Channel.AddNewTaskLogAsync(loginUser, taskLog);
        }
        
        public ToDo.Winform.ServiceReference_TaskLog.TaskLog UpdateTaskLog(Tasky.Models.Account.ServiceUserLoginModel loginUser, ToDo.Winform.ServiceReference_TaskLog.TaskLog taskLog) {
            return base.Channel.UpdateTaskLog(loginUser, taskLog);
        }
        
        public System.Threading.Tasks.Task<ToDo.Winform.ServiceReference_TaskLog.TaskLog> UpdateTaskLogAsync(Tasky.Models.Account.ServiceUserLoginModel loginUser, ToDo.Winform.ServiceReference_TaskLog.TaskLog taskLog) {
            return base.Channel.UpdateTaskLogAsync(loginUser, taskLog);
        }
        
        public bool DeleteTaskLog(Tasky.Models.Account.ServiceUserLoginModel loginUser, int TaskLogId) {
            return base.Channel.DeleteTaskLog(loginUser, TaskLogId);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteTaskLogAsync(Tasky.Models.Account.ServiceUserLoginModel loginUser, int TaskLogId) {
            return base.Channel.DeleteTaskLogAsync(loginUser, TaskLogId);
        }
    }
}
