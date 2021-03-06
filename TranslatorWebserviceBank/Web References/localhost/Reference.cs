﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace TranslatorWebserviceBank.localhost {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="LoanServiceSoap", Namespace="http://tempuri.org/")]
    public partial class LoanService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback LoanRequestSendToReplyToOperationCompleted;
        
        private System.Threading.SendOrPostCallback LoanRequestOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public LoanService() {
            this.Url = global::TranslatorWebserviceBank.Properties.Settings.Default.TranslatorWebserviceBank_localhost_LoanService;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event LoanRequestSendToReplyToCompletedEventHandler LoanRequestSendToReplyToCompleted;
        
        /// <remarks/>
        public event LoanRequestCompletedEventHandler LoanRequestCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/LoanRequestSendToReplyTo", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool LoanRequestSendToReplyTo(string ssn, int creditScore, double loanAmount, int months, string replyTo, int correlationID) {
            object[] results = this.Invoke("LoanRequestSendToReplyTo", new object[] {
                        ssn,
                        creditScore,
                        loanAmount,
                        months,
                        replyTo,
                        correlationID});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void LoanRequestSendToReplyToAsync(string ssn, int creditScore, double loanAmount, int months, string replyTo, int correlationID) {
            this.LoanRequestSendToReplyToAsync(ssn, creditScore, loanAmount, months, replyTo, correlationID, null);
        }
        
        /// <remarks/>
        public void LoanRequestSendToReplyToAsync(string ssn, int creditScore, double loanAmount, int months, string replyTo, int correlationID, object userState) {
            if ((this.LoanRequestSendToReplyToOperationCompleted == null)) {
                this.LoanRequestSendToReplyToOperationCompleted = new System.Threading.SendOrPostCallback(this.OnLoanRequestSendToReplyToOperationCompleted);
            }
            this.InvokeAsync("LoanRequestSendToReplyTo", new object[] {
                        ssn,
                        creditScore,
                        loanAmount,
                        months,
                        replyTo,
                        correlationID}, this.LoanRequestSendToReplyToOperationCompleted, userState);
        }
        
        private void OnLoanRequestSendToReplyToOperationCompleted(object arg) {
            if ((this.LoanRequestSendToReplyToCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.LoanRequestSendToReplyToCompleted(this, new LoanRequestSendToReplyToCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/LoanRequest", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string LoanRequest(string ssn, int creditScore, double loanAmount, int months) {
            object[] results = this.Invoke("LoanRequest", new object[] {
                        ssn,
                        creditScore,
                        loanAmount,
                        months});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void LoanRequestAsync(string ssn, int creditScore, double loanAmount, int months) {
            this.LoanRequestAsync(ssn, creditScore, loanAmount, months, null);
        }
        
        /// <remarks/>
        public void LoanRequestAsync(string ssn, int creditScore, double loanAmount, int months, object userState) {
            if ((this.LoanRequestOperationCompleted == null)) {
                this.LoanRequestOperationCompleted = new System.Threading.SendOrPostCallback(this.OnLoanRequestOperationCompleted);
            }
            this.InvokeAsync("LoanRequest", new object[] {
                        ssn,
                        creditScore,
                        loanAmount,
                        months}, this.LoanRequestOperationCompleted, userState);
        }
        
        private void OnLoanRequestOperationCompleted(object arg) {
            if ((this.LoanRequestCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.LoanRequestCompleted(this, new LoanRequestCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void LoanRequestSendToReplyToCompletedEventHandler(object sender, LoanRequestSendToReplyToCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LoanRequestSendToReplyToCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal LoanRequestSendToReplyToCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void LoanRequestCompletedEventHandler(object sender, LoanRequestCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LoanRequestCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal LoanRequestCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591