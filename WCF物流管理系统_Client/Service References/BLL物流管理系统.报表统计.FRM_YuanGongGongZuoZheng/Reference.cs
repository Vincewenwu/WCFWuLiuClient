﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.34014
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCF物流管理系统_Client.BLL物流管理系统.报表统计.FRM_YuanGongGongZuoZheng {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BLL物流管理系统.报表统计.FRM_YuanGongGongZuoZheng.FRM_YuanGongGongZuoZheng")]
    public interface FRM_YuanGongGongZuoZheng {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_YuanGongGongZuoZheng/btnShangChuan_Click_UpdateYuanGong", ReplyAction="http://tempuri.org/FRM_YuanGongGongZuoZheng/btnShangChuan_Click_UpdateYuanGongRes" +
            "ponse")]
        int btnShangChuan_Click_UpdateYuanGong(byte[] 照片);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_YuanGongGongZuoZheng/FRM_YuanGongGongZuoZhengDaYin_Load_Ch" +
            "aXunYuanGong", ReplyAction="http://tempuri.org/FRM_YuanGongGongZuoZheng/FRM_YuanGongGongZuoZhengDaYin_Load_Ch" +
            "aXunYuanGongResponse")]
        System.Data.DataSet FRM_YuanGongGongZuoZhengDaYin_Load_ChaXunYuanGong();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface FRM_YuanGongGongZuoZhengChannel : WCF物流管理系统_Client.BLL物流管理系统.报表统计.FRM_YuanGongGongZuoZheng.FRM_YuanGongGongZuoZheng, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FRM_YuanGongGongZuoZhengClient : System.ServiceModel.ClientBase<WCF物流管理系统_Client.BLL物流管理系统.报表统计.FRM_YuanGongGongZuoZheng.FRM_YuanGongGongZuoZheng>, WCF物流管理系统_Client.BLL物流管理系统.报表统计.FRM_YuanGongGongZuoZheng.FRM_YuanGongGongZuoZheng {
        
        public FRM_YuanGongGongZuoZhengClient() {
        }
        
        public FRM_YuanGongGongZuoZhengClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public FRM_YuanGongGongZuoZhengClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FRM_YuanGongGongZuoZhengClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FRM_YuanGongGongZuoZhengClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int btnShangChuan_Click_UpdateYuanGong(byte[] 照片) {
            return base.Channel.btnShangChuan_Click_UpdateYuanGong(照片);
        }
        
        public System.Data.DataSet FRM_YuanGongGongZuoZhengDaYin_Load_ChaXunYuanGong() {
            return base.Channel.FRM_YuanGongGongZuoZhengDaYin_Load_ChaXunYuanGong();
        }
    }
}
