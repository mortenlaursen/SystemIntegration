﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CreditScoreEnricher.CreditScore {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://service.web.credit.bank.org/", ConfigurationName="CreditScore.CreditScoreService")]
    public interface CreditScoreService {
        
        // CODEGEN: Generating message contract since element name ssn from namespace  is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://service.web.credit.bank.org/CreditScoreService/creditScoreRequest", ReplyAction="http://service.web.credit.bank.org/CreditScoreService/creditScoreResponse")]
        CreditScoreEnricher.CreditScore.creditScoreResponse creditScore(CreditScoreEnricher.CreditScore.creditScoreRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://service.web.credit.bank.org/CreditScoreService/creditScoreRequest", ReplyAction="http://service.web.credit.bank.org/CreditScoreService/creditScoreResponse")]
        System.Threading.Tasks.Task<CreditScoreEnricher.CreditScore.creditScoreResponse> creditScoreAsync(CreditScoreEnricher.CreditScore.creditScoreRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class creditScoreRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="creditScore", Namespace="http://service.web.credit.bank.org/", Order=0)]
        public CreditScoreEnricher.CreditScore.creditScoreRequestBody Body;
        
        public creditScoreRequest() {
        }
        
        public creditScoreRequest(CreditScoreEnricher.CreditScore.creditScoreRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class creditScoreRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string ssn;
        
        public creditScoreRequestBody() {
        }
        
        public creditScoreRequestBody(string ssn) {
            this.ssn = ssn;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class creditScoreResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="creditScoreResponse", Namespace="http://service.web.credit.bank.org/", Order=0)]
        public CreditScoreEnricher.CreditScore.creditScoreResponseBody Body;
        
        public creditScoreResponse() {
        }
        
        public creditScoreResponse(CreditScoreEnricher.CreditScore.creditScoreResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class creditScoreResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int @return;
        
        public creditScoreResponseBody() {
        }
        
        public creditScoreResponseBody(int @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface CreditScoreServiceChannel : CreditScoreEnricher.CreditScore.CreditScoreService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CreditScoreServiceClient : System.ServiceModel.ClientBase<CreditScoreEnricher.CreditScore.CreditScoreService>, CreditScoreEnricher.CreditScore.CreditScoreService {
        
        public CreditScoreServiceClient() {
        }
        
        public CreditScoreServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CreditScoreServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CreditScoreServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CreditScoreServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CreditScoreEnricher.CreditScore.creditScoreResponse CreditScoreEnricher.CreditScore.CreditScoreService.creditScore(CreditScoreEnricher.CreditScore.creditScoreRequest request) {
            return base.Channel.creditScore(request);
        }
        
        public int creditScore(string ssn) {
            CreditScoreEnricher.CreditScore.creditScoreRequest inValue = new CreditScoreEnricher.CreditScore.creditScoreRequest();
            inValue.Body = new CreditScoreEnricher.CreditScore.creditScoreRequestBody();
            inValue.Body.ssn = ssn;
            CreditScoreEnricher.CreditScore.creditScoreResponse retVal = ((CreditScoreEnricher.CreditScore.CreditScoreService)(this)).creditScore(inValue);
            return retVal.Body.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CreditScoreEnricher.CreditScore.creditScoreResponse> CreditScoreEnricher.CreditScore.CreditScoreService.creditScoreAsync(CreditScoreEnricher.CreditScore.creditScoreRequest request) {
            return base.Channel.creditScoreAsync(request);
        }
        
        public System.Threading.Tasks.Task<CreditScoreEnricher.CreditScore.creditScoreResponse> creditScoreAsync(string ssn) {
            CreditScoreEnricher.CreditScore.creditScoreRequest inValue = new CreditScoreEnricher.CreditScore.creditScoreRequest();
            inValue.Body = new CreditScoreEnricher.CreditScore.creditScoreRequestBody();
            inValue.Body.ssn = ssn;
            return ((CreditScoreEnricher.CreditScore.CreditScoreService)(this)).creditScoreAsync(inValue);
        }
    }
}
