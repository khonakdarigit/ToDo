﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ToDo.Winform.ServiceReference_Log {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Log", Namespace="http://schemas.datacontract.org/2004/07/ToDo.WCF.EF")]
    [System.SerializableAttribute()]
    public partial class Log : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTimeOffset DateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LogDetailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LogLevelField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LogTitleField;
        
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
        public System.DateTimeOffset Date {
            get {
                return this.DateField;
            }
            set {
                if ((this.DateField.Equals(value) != true)) {
                    this.DateField = value;
                    this.RaisePropertyChanged("Date");
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
        public string LogDetail {
            get {
                return this.LogDetailField;
            }
            set {
                if ((object.ReferenceEquals(this.LogDetailField, value) != true)) {
                    this.LogDetailField = value;
                    this.RaisePropertyChanged("LogDetail");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LogLevel {
            get {
                return this.LogLevelField;
            }
            set {
                if ((object.ReferenceEquals(this.LogLevelField, value) != true)) {
                    this.LogLevelField = value;
                    this.RaisePropertyChanged("LogLevel");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LogTitle {
            get {
                return this.LogTitleField;
            }
            set {
                if ((object.ReferenceEquals(this.LogTitleField, value) != true)) {
                    this.LogTitleField = value;
                    this.RaisePropertyChanged("LogTitle");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference_Log.IService_Log")]
    public interface IService_Log {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_Log/NewLog", ReplyAction="http://tempuri.org/IService_Log/NewLogResponse")]
        void NewLog(ToDo.Winform.ServiceReference_Log.Log log);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_Log/NewLog", ReplyAction="http://tempuri.org/IService_Log/NewLogResponse")]
        System.Threading.Tasks.Task NewLogAsync(ToDo.Winform.ServiceReference_Log.Log log);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService_LogChannel : ToDo.Winform.ServiceReference_Log.IService_Log, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service_LogClient : System.ServiceModel.ClientBase<ToDo.Winform.ServiceReference_Log.IService_Log>, ToDo.Winform.ServiceReference_Log.IService_Log {
        
        public Service_LogClient() {
        }
        
        public Service_LogClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service_LogClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service_LogClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service_LogClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void NewLog(ToDo.Winform.ServiceReference_Log.Log log) {
            base.Channel.NewLog(log);
        }
        
        public System.Threading.Tasks.Task NewLogAsync(ToDo.Winform.ServiceReference_Log.Log log) {
            return base.Channel.NewLogAsync(log);
        }
    }
}
