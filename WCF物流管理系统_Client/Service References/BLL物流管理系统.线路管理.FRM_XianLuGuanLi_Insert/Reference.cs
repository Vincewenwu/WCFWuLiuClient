﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.34014
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCF物流管理系统_Client.BLL物流管理系统.线路管理.FRM_XianLuGuanLi_Insert {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BLL物流管理系统.线路管理.FRM_XianLuGuanLi_Insert.FRM_XianLuGuanLi_Insert")]
    public interface FRM_XianLuGuanLi_Insert {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_XianLuGuanLi_Insert/FRM_XianLuGuanLi_Insert_Load_ChaXunWan" +
            "gDianXinXi", ReplyAction="http://tempuri.org/FRM_XianLuGuanLi_Insert/FRM_XianLuGuanLi_Insert_Load_ChaXunWan" +
            "gDianXinXiResponse")]
        System.Data.DataSet FRM_XianLuGuanLi_Insert_Load_ChaXunWangDianXinXi();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_XianLuGuanLi_Insert/btnShengChengLuXian_Click_ChaXunXiangL" +
            "inWangDianXinXi", ReplyAction="http://tempuri.org/FRM_XianLuGuanLi_Insert/btnShengChengLuXian_Click_ChaXunXiangL" +
            "inWangDianXinXiResponse")]
        System.Data.DataSet btnShengChengLuXian_Click_ChaXunXiangLinWangDianXinXi();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_XianLuGuanLi_Insert/btnBaoCunXianLu_Click_BaoCunXianLu", ReplyAction="http://tempuri.org/FRM_XianLuGuanLi_Insert/btnBaoCunXianLu_Click_BaoCunXianLuResp" +
            "onse")]
        System.Data.DataSet btnBaoCunXianLu_Click_BaoCunXianLu(string 线路名称, string 助记码);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_XianLuGuanLi_Insert/btnBaoCunXianLu_Click_BaoCunXianLuMing" +
            "Xi", ReplyAction="http://tempuri.org/FRM_XianLuGuanLi_Insert/btnBaoCunXianLu_Click_BaoCunXianLuMing" +
            "XiResponse")]
        System.Data.DataSet btnBaoCunXianLu_Click_BaoCunXianLuMingXi(int 线路ID, int 网点ID, int 上级网点ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_XianLuGuanLi_Insert/btnShengChengLuXian_Click_ChaXunLinJu", ReplyAction="http://tempuri.org/FRM_XianLuGuanLi_Insert/btnShengChengLuXian_Click_ChaXunLinJuR" +
            "esponse")]
        System.Data.DataSet btnShengChengLuXian_Click_ChaXunLinJu();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_XianLuGuanLi_Insert/btnShengChengLuXian_Click_IDChaXunLinJ" +
            "u", ReplyAction="http://tempuri.org/FRM_XianLuGuanLi_Insert/btnShengChengLuXian_Click_IDChaXunLinJ" +
            "uResponse")]
        System.Data.DataSet btnShengChengLuXian_Click_IDChaXunLinJu();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface FRM_XianLuGuanLi_InsertChannel : WCF物流管理系统_Client.BLL物流管理系统.线路管理.FRM_XianLuGuanLi_Insert.FRM_XianLuGuanLi_Insert, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FRM_XianLuGuanLi_InsertClient : System.ServiceModel.ClientBase<WCF物流管理系统_Client.BLL物流管理系统.线路管理.FRM_XianLuGuanLi_Insert.FRM_XianLuGuanLi_Insert>, WCF物流管理系统_Client.BLL物流管理系统.线路管理.FRM_XianLuGuanLi_Insert.FRM_XianLuGuanLi_Insert {
        
        public FRM_XianLuGuanLi_InsertClient() {
        }
        
        public FRM_XianLuGuanLi_InsertClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public FRM_XianLuGuanLi_InsertClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FRM_XianLuGuanLi_InsertClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FRM_XianLuGuanLi_InsertClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataSet FRM_XianLuGuanLi_Insert_Load_ChaXunWangDianXinXi() {
            return base.Channel.FRM_XianLuGuanLi_Insert_Load_ChaXunWangDianXinXi();
        }
        
        public System.Data.DataSet btnShengChengLuXian_Click_ChaXunXiangLinWangDianXinXi() {
            return base.Channel.btnShengChengLuXian_Click_ChaXunXiangLinWangDianXinXi();
        }
        
        public System.Data.DataSet btnBaoCunXianLu_Click_BaoCunXianLu(string 线路名称, string 助记码) {
            return base.Channel.btnBaoCunXianLu_Click_BaoCunXianLu(线路名称, 助记码);
        }
        
        public System.Data.DataSet btnBaoCunXianLu_Click_BaoCunXianLuMingXi(int 线路ID, int 网点ID, int 上级网点ID) {
            return base.Channel.btnBaoCunXianLu_Click_BaoCunXianLuMingXi(线路ID, 网点ID, 上级网点ID);
        }
        
        public System.Data.DataSet btnShengChengLuXian_Click_ChaXunLinJu() {
            return base.Channel.btnShengChengLuXian_Click_ChaXunLinJu();
        }
        
        public System.Data.DataSet btnShengChengLuXian_Click_IDChaXunLinJu() {
            return base.Channel.btnShengChengLuXian_Click_IDChaXunLinJu();
        }
    }
}
