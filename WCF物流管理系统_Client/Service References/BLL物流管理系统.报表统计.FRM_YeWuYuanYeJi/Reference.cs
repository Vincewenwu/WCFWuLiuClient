﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.34014
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCF物流管理系统_Client.BLL物流管理系统.报表统计.FRM_YeWuYuanYeJi {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BLL物流管理系统.报表统计.FRM_YeWuYuanYeJi.FRM_YeWuYuanYeJi")]
    public interface FRM_YeWuYuanYeJi {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_YeWuYuanYeJi/FRM_YeWuYuanYeJi_Load_ChaXunDingDan", ReplyAction="http://tempuri.org/FRM_YeWuYuanYeJi/FRM_YeWuYuanYeJi_Load_ChaXunDingDanResponse")]
        System.Data.DataSet FRM_YeWuYuanYeJi_Load_ChaXunDingDan();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface FRM_YeWuYuanYeJiChannel : WCF物流管理系统_Client.BLL物流管理系统.报表统计.FRM_YeWuYuanYeJi.FRM_YeWuYuanYeJi, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FRM_YeWuYuanYeJiClient : System.ServiceModel.ClientBase<WCF物流管理系统_Client.BLL物流管理系统.报表统计.FRM_YeWuYuanYeJi.FRM_YeWuYuanYeJi>, WCF物流管理系统_Client.BLL物流管理系统.报表统计.FRM_YeWuYuanYeJi.FRM_YeWuYuanYeJi {
        
        public FRM_YeWuYuanYeJiClient() {
        }
        
        public FRM_YeWuYuanYeJiClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public FRM_YeWuYuanYeJiClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FRM_YeWuYuanYeJiClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FRM_YeWuYuanYeJiClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataSet FRM_YeWuYuanYeJi_Load_ChaXunDingDan() {
            return base.Channel.FRM_YeWuYuanYeJi_Load_ChaXunDingDan();
        }
    }
}
