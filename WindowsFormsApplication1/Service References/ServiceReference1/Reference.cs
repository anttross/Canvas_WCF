﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApplication1.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="OrderDetailes", Namespace="http://schemas.datacontract.org/2004/07/Canvas_WCF")]
    [System.SerializableAttribute()]
    public partial class OrderDetailes : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int POBField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string addressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int amountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string cityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string clientIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int deliveryMethodField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string fullNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime orderDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int patternField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string phoneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WindowsFormsApplication1.ServiceReference1.Pictures[] picturesListField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WindowsFormsApplication1.ServiceReference1.Text[] textsListField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int zipCodeField;
        
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
        public int POB {
            get {
                return this.POBField;
            }
            set {
                if ((this.POBField.Equals(value) != true)) {
                    this.POBField = value;
                    this.RaisePropertyChanged("POB");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string address {
            get {
                return this.addressField;
            }
            set {
                if ((object.ReferenceEquals(this.addressField, value) != true)) {
                    this.addressField = value;
                    this.RaisePropertyChanged("address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int amount {
            get {
                return this.amountField;
            }
            set {
                if ((this.amountField.Equals(value) != true)) {
                    this.amountField = value;
                    this.RaisePropertyChanged("amount");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string city {
            get {
                return this.cityField;
            }
            set {
                if ((object.ReferenceEquals(this.cityField, value) != true)) {
                    this.cityField = value;
                    this.RaisePropertyChanged("city");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string clientID {
            get {
                return this.clientIDField;
            }
            set {
                if ((object.ReferenceEquals(this.clientIDField, value) != true)) {
                    this.clientIDField = value;
                    this.RaisePropertyChanged("clientID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int deliveryMethod {
            get {
                return this.deliveryMethodField;
            }
            set {
                if ((this.deliveryMethodField.Equals(value) != true)) {
                    this.deliveryMethodField = value;
                    this.RaisePropertyChanged("deliveryMethod");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string fullName {
            get {
                return this.fullNameField;
            }
            set {
                if ((object.ReferenceEquals(this.fullNameField, value) != true)) {
                    this.fullNameField = value;
                    this.RaisePropertyChanged("fullName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime orderDate {
            get {
                return this.orderDateField;
            }
            set {
                if ((this.orderDateField.Equals(value) != true)) {
                    this.orderDateField = value;
                    this.RaisePropertyChanged("orderDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int pattern {
            get {
                return this.patternField;
            }
            set {
                if ((this.patternField.Equals(value) != true)) {
                    this.patternField = value;
                    this.RaisePropertyChanged("pattern");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string phone {
            get {
                return this.phoneField;
            }
            set {
                if ((object.ReferenceEquals(this.phoneField, value) != true)) {
                    this.phoneField = value;
                    this.RaisePropertyChanged("phone");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WindowsFormsApplication1.ServiceReference1.Pictures[] picturesList {
            get {
                return this.picturesListField;
            }
            set {
                if ((object.ReferenceEquals(this.picturesListField, value) != true)) {
                    this.picturesListField = value;
                    this.RaisePropertyChanged("picturesList");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WindowsFormsApplication1.ServiceReference1.Text[] textsList {
            get {
                return this.textsListField;
            }
            set {
                if ((object.ReferenceEquals(this.textsListField, value) != true)) {
                    this.textsListField = value;
                    this.RaisePropertyChanged("textsList");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int zipCode {
            get {
                return this.zipCodeField;
            }
            set {
                if ((this.zipCodeField.Equals(value) != true)) {
                    this.zipCodeField = value;
                    this.RaisePropertyChanged("zipCode");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Pictures", Namespace="http://schemas.datacontract.org/2004/07/Canvas_WCF")]
    [System.SerializableAttribute()]
    public partial class Pictures : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private float angleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] fileBodyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string fileNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private uint fileSizeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private float leftField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private float sizeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private float topField;
        
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
        public float angle {
            get {
                return this.angleField;
            }
            set {
                if ((this.angleField.Equals(value) != true)) {
                    this.angleField = value;
                    this.RaisePropertyChanged("angle");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] fileBody {
            get {
                return this.fileBodyField;
            }
            set {
                if ((object.ReferenceEquals(this.fileBodyField, value) != true)) {
                    this.fileBodyField = value;
                    this.RaisePropertyChanged("fileBody");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string fileName {
            get {
                return this.fileNameField;
            }
            set {
                if ((object.ReferenceEquals(this.fileNameField, value) != true)) {
                    this.fileNameField = value;
                    this.RaisePropertyChanged("fileName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public uint fileSize {
            get {
                return this.fileSizeField;
            }
            set {
                if ((this.fileSizeField.Equals(value) != true)) {
                    this.fileSizeField = value;
                    this.RaisePropertyChanged("fileSize");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public float left {
            get {
                return this.leftField;
            }
            set {
                if ((this.leftField.Equals(value) != true)) {
                    this.leftField = value;
                    this.RaisePropertyChanged("left");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public float size {
            get {
                return this.sizeField;
            }
            set {
                if ((this.sizeField.Equals(value) != true)) {
                    this.sizeField = value;
                    this.RaisePropertyChanged("size");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public float top {
            get {
                return this.topField;
            }
            set {
                if ((this.topField.Equals(value) != true)) {
                    this.topField = value;
                    this.RaisePropertyChanged("top");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Text", Namespace="http://schemas.datacontract.org/2004/07/Canvas_WCF")]
    [System.SerializableAttribute()]
    public partial class Text : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private float angleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string fontColorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string fontFamilyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int fontSizeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private float leftField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string textBodyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private float topField;
        
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
        public float angle {
            get {
                return this.angleField;
            }
            set {
                if ((this.angleField.Equals(value) != true)) {
                    this.angleField = value;
                    this.RaisePropertyChanged("angle");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string fontColor {
            get {
                return this.fontColorField;
            }
            set {
                if ((object.ReferenceEquals(this.fontColorField, value) != true)) {
                    this.fontColorField = value;
                    this.RaisePropertyChanged("fontColor");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string fontFamily {
            get {
                return this.fontFamilyField;
            }
            set {
                if ((object.ReferenceEquals(this.fontFamilyField, value) != true)) {
                    this.fontFamilyField = value;
                    this.RaisePropertyChanged("fontFamily");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int fontSize {
            get {
                return this.fontSizeField;
            }
            set {
                if ((this.fontSizeField.Equals(value) != true)) {
                    this.fontSizeField = value;
                    this.RaisePropertyChanged("fontSize");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public float left {
            get {
                return this.leftField;
            }
            set {
                if ((this.leftField.Equals(value) != true)) {
                    this.leftField = value;
                    this.RaisePropertyChanged("left");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string textBody {
            get {
                return this.textBodyField;
            }
            set {
                if ((object.ReferenceEquals(this.textBodyField, value) != true)) {
                    this.textBodyField = value;
                    this.RaisePropertyChanged("textBody");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public float top {
            get {
                return this.topField;
            }
            set {
                if ((this.topField.Equals(value) != true)) {
                    this.topField = value;
                    this.RaisePropertyChanged("top");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetOrder", ReplyAction="http://tempuri.org/IService1/GetOrderResponse")]
        int GetOrder(WindowsFormsApplication1.ServiceReference1.OrderDetailes order);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetOrder", ReplyAction="http://tempuri.org/IService1/GetOrderResponse")]
        System.Threading.Tasks.Task<int> GetOrderAsync(WindowsFormsApplication1.ServiceReference1.OrderDetailes order);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : WindowsFormsApplication1.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<WindowsFormsApplication1.ServiceReference1.IService1>, WindowsFormsApplication1.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int GetOrder(WindowsFormsApplication1.ServiceReference1.OrderDetailes order) {
            return base.Channel.GetOrder(order);
        }
        
        public System.Threading.Tasks.Task<int> GetOrderAsync(WindowsFormsApplication1.ServiceReference1.OrderDetailes order) {
            return base.Channel.GetOrderAsync(order);
        }
    }
}
