﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCFClient.WCFHost_WAS {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WCFHost_WAS.IProduct")]
    public interface IProduct {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProduct/DoWork", ReplyAction="http://tempuri.org/IProduct/DoWorkResponse")]
        void DoWork();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProduct/DoWork", ReplyAction="http://tempuri.org/IProduct/DoWorkResponse")]
        System.Threading.Tasks.Task DoWorkAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProduct/GetProduct", ReplyAction="http://tempuri.org/IProduct/GetProductResponse")]
        string GetProduct(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProduct/GetProduct", ReplyAction="http://tempuri.org/IProduct/GetProductResponse")]
        System.Threading.Tasks.Task<string> GetProductAsync(string name);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IProductChannel : WCFClient.WCFHost_WAS.IProduct, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ProductClient : System.ServiceModel.ClientBase<WCFClient.WCFHost_WAS.IProduct>, WCFClient.WCFHost_WAS.IProduct {
        
        public ProductClient() {
        }
        
        public ProductClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProductClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void DoWork() {
            base.Channel.DoWork();
        }
        
        public System.Threading.Tasks.Task DoWorkAsync() {
            return base.Channel.DoWorkAsync();
        }
        
        public string GetProduct(string name) {
            return base.Channel.GetProduct(name);
        }
        
        public System.Threading.Tasks.Task<string> GetProductAsync(string name) {
            return base.Channel.GetProductAsync(name);
        }
    }
}
