﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.34014
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCF物流管理系统_Client.BLL物流管理系统.配载发货.PeiZaiFaHuo_ShiShiPeiZai {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BLL物流管理系统.配载发货.PeiZaiFaHuo_ShiShiPeiZai.PeiZaiFaHuo_ShiShiPeiZai")]
    public interface PeiZaiFaHuo_ShiShiPeiZai {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/PeiZaiFaHuo_ShiShiPeiZai/frmPeiZaiFaHuo_ShiShiPeiZai_Selectcbo" +
            "LanShouZhuangTai", ReplyAction="http://tempuri.org/PeiZaiFaHuo_ShiShiPeiZai/frmPeiZaiFaHuo_ShiShiPeiZai_Selectcbo" +
            "LanShouZhuangTaiResponse")]
        System.Data.DataSet frmPeiZaiFaHuo_ShiShiPeiZai_SelectcboLanShouZhuangTai();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/PeiZaiFaHuo_ShiShiPeiZai/frmPeiZaiFaHuo_ShiShiPeiZai_Selectcbo" +
            "WiangDian", ReplyAction="http://tempuri.org/PeiZaiFaHuo_ShiShiPeiZai/frmPeiZaiFaHuo_ShiShiPeiZai_Selectcbo" +
            "WiangDianResponse")]
        System.Data.DataSet frmPeiZaiFaHuo_ShiShiPeiZai_SelectcboWiangDian();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/PeiZaiFaHuo_ShiShiPeiZai/frmPeiZaiFaHuo_ShiShiPeiZai_LoadFenBa" +
            "o", ReplyAction="http://tempuri.org/PeiZaiFaHuo_ShiShiPeiZai/frmPeiZaiFaHuo_ShiShiPeiZai_LoadFenBa" +
            "oResponse")]
        System.Data.DataSet frmPeiZaiFaHuo_ShiShiPeiZai_LoadFenBao();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/PeiZaiFaHuo_ShiShiPeiZai/frmPeiZaiFaHuo_ShiShiPeiZai_SelectPei" +
            "ZaiFenBao", ReplyAction="http://tempuri.org/PeiZaiFaHuo_ShiShiPeiZai/frmPeiZaiFaHuo_ShiShiPeiZai_SelectPei" +
            "ZaiFenBaoResponse")]
        System.Data.DataSet frmPeiZaiFaHuo_ShiShiPeiZai_SelectPeiZaiFenBao(string 单据编号, int 寄件网点ID, int 收货网点ID, int 货物揽收状态ID, System.DateTime 起始时间, System.DateTime 结束时间);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/PeiZaiFaHuo_ShiShiPeiZai/frmPeiZaiFaHuo_ShiShiPeiZai_UpdateFen" +
            "BaoSuoDingFou", ReplyAction="http://tempuri.org/PeiZaiFaHuo_ShiShiPeiZai/frmPeiZaiFaHuo_ShiShiPeiZai_UpdateFen" +
            "BaoSuoDingFouResponse")]
        int frmPeiZaiFaHuo_ShiShiPeiZai_UpdateFenBaoSuoDingFou(int 分包ID);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface PeiZaiFaHuo_ShiShiPeiZaiChannel : WCF物流管理系统_Client.BLL物流管理系统.配载发货.PeiZaiFaHuo_ShiShiPeiZai.PeiZaiFaHuo_ShiShiPeiZai, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PeiZaiFaHuo_ShiShiPeiZaiClient : System.ServiceModel.ClientBase<WCF物流管理系统_Client.BLL物流管理系统.配载发货.PeiZaiFaHuo_ShiShiPeiZai.PeiZaiFaHuo_ShiShiPeiZai>, WCF物流管理系统_Client.BLL物流管理系统.配载发货.PeiZaiFaHuo_ShiShiPeiZai.PeiZaiFaHuo_ShiShiPeiZai {
        
        public PeiZaiFaHuo_ShiShiPeiZaiClient() {
        }
        
        public PeiZaiFaHuo_ShiShiPeiZaiClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PeiZaiFaHuo_ShiShiPeiZaiClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PeiZaiFaHuo_ShiShiPeiZaiClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PeiZaiFaHuo_ShiShiPeiZaiClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataSet frmPeiZaiFaHuo_ShiShiPeiZai_SelectcboLanShouZhuangTai() {
            return base.Channel.frmPeiZaiFaHuo_ShiShiPeiZai_SelectcboLanShouZhuangTai();
        }
        
        public System.Data.DataSet frmPeiZaiFaHuo_ShiShiPeiZai_SelectcboWiangDian() {
            return base.Channel.frmPeiZaiFaHuo_ShiShiPeiZai_SelectcboWiangDian();
        }
        
        public System.Data.DataSet frmPeiZaiFaHuo_ShiShiPeiZai_LoadFenBao() {
            return base.Channel.frmPeiZaiFaHuo_ShiShiPeiZai_LoadFenBao();
        }
        
        public System.Data.DataSet frmPeiZaiFaHuo_ShiShiPeiZai_SelectPeiZaiFenBao(string 单据编号, int 寄件网点ID, int 收货网点ID, int 货物揽收状态ID, System.DateTime 起始时间, System.DateTime 结束时间) {
            return base.Channel.frmPeiZaiFaHuo_ShiShiPeiZai_SelectPeiZaiFenBao(单据编号, 寄件网点ID, 收货网点ID, 货物揽收状态ID, 起始时间, 结束时间);
        }
        
        public int frmPeiZaiFaHuo_ShiShiPeiZai_UpdateFenBaoSuoDingFou(int 分包ID) {
            return base.Channel.frmPeiZaiFaHuo_ShiShiPeiZai_UpdateFenBaoSuoDingFou(分包ID);
        }
    }
}
