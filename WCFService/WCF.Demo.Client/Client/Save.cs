﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:2.0.50727.8794
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------




[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(ConfigurationName="ISave")]
public interface ISave
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISave/DoWork", ReplyAction="http://tempuri.org/ISave/DoWorkResponse")]
    bool DoWork(WCF.Demo.Model.User user);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
public interface ISaveChannel : ISave, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
public partial class SaveClient : System.ServiceModel.ClientBase<ISave>, ISave
{
    
    public SaveClient()
    {
    }
    
    public SaveClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public SaveClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public SaveClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public SaveClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public bool DoWork(WCF.Demo.Model.User user)
    {
        return base.Channel.DoWork(user);
    }
}