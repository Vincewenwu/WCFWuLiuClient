﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.34014
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCF物流管理系统_Client.BLL物流管理系统.用户权限管理.BLL_YongHuQuanXian {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BLL物流管理系统.用户权限管理.BLL_YongHuQuanXian.BLL_YongHuQuanXian")]
    public interface BLL_YongHuQuanXian {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BLL_YongHuQuanXian/FRM_YongHuQuanXian_Load_ChaXunYongHu", ReplyAction="http://tempuri.org/BLL_YongHuQuanXian/FRM_YongHuQuanXian_Load_ChaXunYongHuRespons" +
            "e")]
        System.Data.DataSet FRM_YongHuQuanXian_Load_ChaXunYongHu();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BLL_YongHuQuanXian/FRM_YongHuQuanXian_btnYongHu_Del_Click", ReplyAction="http://tempuri.org/BLL_YongHuQuanXian/FRM_YongHuQuanXian_btnYongHu_Del_ClickRespo" +
            "nse")]
        int FRM_YongHuQuanXian_btnYongHu_Del_Click(int 用户ID);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface BLL_YongHuQuanXianChannel : WCF物流管理系统_Client.BLL物流管理系统.用户权限管理.BLL_YongHuQuanXian.BLL_YongHuQuanXian, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BLL_YongHuQuanXianClient : System.ServiceModel.ClientBase<WCF物流管理系统_Client.BLL物流管理系统.用户权限管理.BLL_YongHuQuanXian.BLL_YongHuQuanXian>, WCF物流管理系统_Client.BLL物流管理系统.用户权限管理.BLL_YongHuQuanXian.BLL_YongHuQuanXian {
        
        public BLL_YongHuQuanXianClient() {
        }
        
        public BLL_YongHuQuanXianClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BLL_YongHuQuanXianClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BLL_YongHuQuanXianClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BLL_YongHuQuanXianClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataSet FRM_YongHuQuanXian_Load_ChaXunYongHu() {
            return base.Channel.FRM_YongHuQuanXian_Load_ChaXunYongHu();
        }
        
        public int FRM_YongHuQuanXian_btnYongHu_Del_Click(int 用户ID) {
            return base.Channel.FRM_YongHuQuanXian_btnYongHu_Del_Click(用户ID);
        }
    }
}
