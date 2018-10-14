﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebserviceTestExer.JasonWebservice {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://jasonexeruri.org/", ConfigurationName="JasonWebservice.MyWebServiceSoap")]
    public interface MyWebServiceSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://jasonexeruri.org/HelloWorld", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string HelloWorld();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://jasonexeruri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<string> HelloWorldAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://jasonexeruri.org/Plus", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int Plus(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://jasonexeruri.org/Plus", ReplyAction="*")]
        System.Threading.Tasks.Task<int> PlusAsync(int x, int y);
        
        // CODEGEN: Generating message contract since message GetUsersRequest has headers
        [System.ServiceModel.OperationContractAttribute(Action="http://jasonexeruri.org/GetUsers", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        WebserviceTestExer.JasonWebservice.GetUsersResponse GetUsers(WebserviceTestExer.JasonWebservice.GetUsersRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://jasonexeruri.org/GetUsers", ReplyAction="*")]
        System.Threading.Tasks.Task<WebserviceTestExer.JasonWebservice.GetUsersResponse> GetUsersAsync(WebserviceTestExer.JasonWebservice.GetUsersRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://jasonexeruri.org/")]
    public partial class CustomSoapHeaders : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string userNameField;
        
        private string passWordField;
        
        private System.Xml.XmlAttribute[] anyAttrField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string UserName {
            get {
                return this.userNameField;
            }
            set {
                this.userNameField = value;
                this.RaisePropertyChanged("UserName");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string PassWord {
            get {
                return this.passWordField;
            }
            set {
                this.passWordField = value;
                this.RaisePropertyChanged("PassWord");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public System.Xml.XmlAttribute[] AnyAttr {
            get {
                return this.anyAttrField;
            }
            set {
                this.anyAttrField = value;
                this.RaisePropertyChanged("AnyAttr");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://jasonexeruri.org/")]
    public partial class WebserviceUser : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int idField;
        
        private string nameField;
        
        private string profileField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                this.RaisePropertyChanged("Id");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
                this.RaisePropertyChanged("Name");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string Profile {
            get {
                return this.profileField;
            }
            set {
                this.profileField = value;
                this.RaisePropertyChanged("Profile");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetUsers", WrapperNamespace="http://jasonexeruri.org/", IsWrapped=true)]
    public partial class GetUsersRequest {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://jasonexeruri.org/")]
        public WebserviceTestExer.JasonWebservice.CustomSoapHeaders CustomSoapHeaders;
        
        public GetUsersRequest() {
        }
        
        public GetUsersRequest(WebserviceTestExer.JasonWebservice.CustomSoapHeaders CustomSoapHeaders) {
            this.CustomSoapHeaders = CustomSoapHeaders;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetUsersResponse", WrapperNamespace="http://jasonexeruri.org/", IsWrapped=true)]
    public partial class GetUsersResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://jasonexeruri.org/", Order=0)]
        public WebserviceTestExer.JasonWebservice.WebserviceUser[] GetUsersResult;
        
        public GetUsersResponse() {
        }
        
        public GetUsersResponse(WebserviceTestExer.JasonWebservice.WebserviceUser[] GetUsersResult) {
            this.GetUsersResult = GetUsersResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface MyWebServiceSoapChannel : WebserviceTestExer.JasonWebservice.MyWebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MyWebServiceSoapClient : System.ServiceModel.ClientBase<WebserviceTestExer.JasonWebservice.MyWebServiceSoap>, WebserviceTestExer.JasonWebservice.MyWebServiceSoap {
        
        public MyWebServiceSoapClient() {
        }
        
        public MyWebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MyWebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MyWebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MyWebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string HelloWorld() {
            return base.Channel.HelloWorld();
        }
        
        public System.Threading.Tasks.Task<string> HelloWorldAsync() {
            return base.Channel.HelloWorldAsync();
        }
        
        public int Plus(int x, int y) {
            return base.Channel.Plus(x, y);
        }
        
        public System.Threading.Tasks.Task<int> PlusAsync(int x, int y) {
            return base.Channel.PlusAsync(x, y);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebserviceTestExer.JasonWebservice.GetUsersResponse WebserviceTestExer.JasonWebservice.MyWebServiceSoap.GetUsers(WebserviceTestExer.JasonWebservice.GetUsersRequest request) {
            return base.Channel.GetUsers(request);
        }
        
        public WebserviceTestExer.JasonWebservice.WebserviceUser[] GetUsers(WebserviceTestExer.JasonWebservice.CustomSoapHeaders CustomSoapHeaders) {
            WebserviceTestExer.JasonWebservice.GetUsersRequest inValue = new WebserviceTestExer.JasonWebservice.GetUsersRequest();
            inValue.CustomSoapHeaders = CustomSoapHeaders;
            WebserviceTestExer.JasonWebservice.GetUsersResponse retVal = ((WebserviceTestExer.JasonWebservice.MyWebServiceSoap)(this)).GetUsers(inValue);
            return retVal.GetUsersResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebserviceTestExer.JasonWebservice.GetUsersResponse> WebserviceTestExer.JasonWebservice.MyWebServiceSoap.GetUsersAsync(WebserviceTestExer.JasonWebservice.GetUsersRequest request) {
            return base.Channel.GetUsersAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebserviceTestExer.JasonWebservice.GetUsersResponse> GetUsersAsync(WebserviceTestExer.JasonWebservice.CustomSoapHeaders CustomSoapHeaders) {
            WebserviceTestExer.JasonWebservice.GetUsersRequest inValue = new WebserviceTestExer.JasonWebservice.GetUsersRequest();
            inValue.CustomSoapHeaders = CustomSoapHeaders;
            return ((WebserviceTestExer.JasonWebservice.MyWebServiceSoap)(this)).GetUsersAsync(inValue);
        }
    }
}