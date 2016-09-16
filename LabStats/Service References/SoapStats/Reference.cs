﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LabStats.SoapStats {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SoapStats.StatisticsSoap")]
    public interface StatisticsSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetCurrentStats", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet GetCurrentStats();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetCurrentStats", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> GetCurrentStatsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetGroupedCurrentStats", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        LabStats.SoapStats.GroupStat[] GetGroupedCurrentStats();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetGroupedCurrentStats", ReplyAction="*")]
        System.Threading.Tasks.Task<LabStats.SoapStats.GroupStat[]> GetGroupedCurrentStatsAsync();
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class GroupStat : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int groupIdField;
        
        private string groupNameField;
        
        private int offCountField;
        
        private int availableCountField;
        
        private int unavailableCountField;
        
        private int inUseCountField;
        
        private bool hasPublishedScheduleField;
        
        private bool isAvailableField;
        
        private int totalCountField;
        
        private string groupDescriptionField;
        
        private bool reservableField;
        
        private System.Nullable<int> parentGroupIdField;
        
        private string parentGroupNameField;
        
        private int childGroupCountField;
        
        private float percentInUseField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int groupId {
            get {
                return this.groupIdField;
            }
            set {
                this.groupIdField = value;
                this.RaisePropertyChanged("groupId");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string groupName {
            get {
                return this.groupNameField;
            }
            set {
                this.groupNameField = value;
                this.RaisePropertyChanged("groupName");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public int offCount {
            get {
                return this.offCountField;
            }
            set {
                this.offCountField = value;
                this.RaisePropertyChanged("offCount");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public int availableCount {
            get {
                return this.availableCountField;
            }
            set {
                this.availableCountField = value;
                this.RaisePropertyChanged("availableCount");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public int unavailableCount {
            get {
                return this.unavailableCountField;
            }
            set {
                this.unavailableCountField = value;
                this.RaisePropertyChanged("unavailableCount");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public int inUseCount {
            get {
                return this.inUseCountField;
            }
            set {
                this.inUseCountField = value;
                this.RaisePropertyChanged("inUseCount");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public bool hasPublishedSchedule {
            get {
                return this.hasPublishedScheduleField;
            }
            set {
                this.hasPublishedScheduleField = value;
                this.RaisePropertyChanged("hasPublishedSchedule");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public bool isAvailable {
            get {
                return this.isAvailableField;
            }
            set {
                this.isAvailableField = value;
                this.RaisePropertyChanged("isAvailable");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public int totalCount {
            get {
                return this.totalCountField;
            }
            set {
                this.totalCountField = value;
                this.RaisePropertyChanged("totalCount");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=9)]
        public string groupDescription {
            get {
                return this.groupDescriptionField;
            }
            set {
                this.groupDescriptionField = value;
                this.RaisePropertyChanged("groupDescription");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=10)]
        public bool reservable {
            get {
                return this.reservableField;
            }
            set {
                this.reservableField = value;
                this.RaisePropertyChanged("reservable");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=11)]
        public System.Nullable<int> parentGroupId {
            get {
                return this.parentGroupIdField;
            }
            set {
                this.parentGroupIdField = value;
                this.RaisePropertyChanged("parentGroupId");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=12)]
        public string parentGroupName {
            get {
                return this.parentGroupNameField;
            }
            set {
                this.parentGroupNameField = value;
                this.RaisePropertyChanged("parentGroupName");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=13)]
        public int childGroupCount {
            get {
                return this.childGroupCountField;
            }
            set {
                this.childGroupCountField = value;
                this.RaisePropertyChanged("childGroupCount");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=14)]
        public float percentInUse {
            get {
                return this.percentInUseField;
            }
            set {
                this.percentInUseField = value;
                this.RaisePropertyChanged("percentInUse");
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
    public interface StatisticsSoapChannel : LabStats.SoapStats.StatisticsSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class StatisticsSoapClient : System.ServiceModel.ClientBase<LabStats.SoapStats.StatisticsSoap>, LabStats.SoapStats.StatisticsSoap {
        
        public StatisticsSoapClient() {
        }
        
        public StatisticsSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public StatisticsSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public StatisticsSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public StatisticsSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataSet GetCurrentStats() {
            return base.Channel.GetCurrentStats();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GetCurrentStatsAsync() {
            return base.Channel.GetCurrentStatsAsync();
        }
        
        public LabStats.SoapStats.GroupStat[] GetGroupedCurrentStats() {
            return base.Channel.GetGroupedCurrentStats();
        }
        
        public System.Threading.Tasks.Task<LabStats.SoapStats.GroupStat[]> GetGroupedCurrentStatsAsync() {
            return base.Channel.GetGroupedCurrentStatsAsync();
        }
    }
}