﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCF物流管理系统_Client.BLL物流管理系统.出车登记.FRM_ChuCheDengJi {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BLL物流管理系统.出车登记.FRM_ChuCheDengJi.FRM_ChuCheDengJi")]
    public interface FRM_ChuCheDengJi {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_ChuCheDengJi/myPictureBox_Click_ChaXunFenBao", ReplyAction="http://tempuri.org/FRM_ChuCheDengJi/myPictureBox_Click_ChaXunFenBaoResponse")]
        System.Data.DataSet myPictureBox_Click_ChaXunFenBao(string strChuCheID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_ChuCheDengJi/FRM_ChuCheDengJi_Load_ChaXunQuanBuCheLiang", ReplyAction="http://tempuri.org/FRM_ChuCheDengJi/FRM_ChuCheDengJi_Load_ChaXunQuanBuCheLiangRes" +
            "ponse")]
        System.Data.DataSet FRM_ChuCheDengJi_Load_ChaXunQuanBuCheLiang();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_ChuCheDengJi/FRM_ChuCheDengJi_Load_ChaXunCheLiang", ReplyAction="http://tempuri.org/FRM_ChuCheDengJi/FRM_ChuCheDengJi_Load_ChaXunCheLiangResponse")]
        System.Data.DataSet FRM_ChuCheDengJi_Load_ChaXunCheLiang();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_ChuCheDengJi/pb_MouseClick_ChaXunMingXi", ReplyAction="http://tempuri.org/FRM_ChuCheDengJi/pb_MouseClick_ChaXunMingXiResponse")]
        System.Data.DataSet pb_MouseClick_ChaXunMingXi(int 配载发车单ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_ChuCheDengJi/FRM_ChuCheDengJi_Load_ChaXunWangDian", ReplyAction="http://tempuri.org/FRM_ChuCheDengJi/FRM_ChuCheDengJi_Load_ChaXunWangDianResponse")]
        System.Data.DataSet FRM_ChuCheDengJi_Load_ChaXunWangDian();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_ChuCheDengJi/FRM_ChuCheDengJi_Load_ChaXunZhuangTai", ReplyAction="http://tempuri.org/FRM_ChuCheDengJi/FRM_ChuCheDengJi_Load_ChaXunZhuangTaiResponse" +
            "")]
        System.Data.DataSet FRM_ChuCheDengJi_Load_ChaXunZhuangTai();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_ChuCheDengJi/FRM_ChuCheDengJi_tsbChuChe_Click_UpdateChuChe" +
            "", ReplyAction="http://tempuri.org/FRM_ChuCheDengJi/FRM_ChuCheDengJi_tsbChuChe_Click_UpdateChuChe" +
            "Response")]
        int FRM_ChuCheDengJi_tsbChuChe_Click_UpdateChuChe(int 车辆ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_ChuCheDengJi/FRM_ChuCheDengJi_IDChaXunCheLiangZhuangTai", ReplyAction="http://tempuri.org/FRM_ChuCheDengJi/FRM_ChuCheDengJi_IDChaXunCheLiangZhuangTaiRes" +
            "ponse")]
        System.Data.DataSet FRM_ChuCheDengJi_IDChaXunCheLiangZhuangTai(string strCheLiangID);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface FRM_ChuCheDengJiChannel : WCF物流管理系统_Client.BLL物流管理系统.出车登记.FRM_ChuCheDengJi.FRM_ChuCheDengJi, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FRM_ChuCheDengJiClient : System.ServiceModel.ClientBase<WCF物流管理系统_Client.BLL物流管理系统.出车登记.FRM_ChuCheDengJi.FRM_ChuCheDengJi>, WCF物流管理系统_Client.BLL物流管理系统.出车登记.FRM_ChuCheDengJi.FRM_ChuCheDengJi {
        
        public FRM_ChuCheDengJiClient() {
        }
        
        public FRM_ChuCheDengJiClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public FRM_ChuCheDengJiClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FRM_ChuCheDengJiClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FRM_ChuCheDengJiClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataSet myPictureBox_Click_ChaXunFenBao(string strChuCheID) {
            return base.Channel.myPictureBox_Click_ChaXunFenBao(strChuCheID);
        }
        
        public System.Data.DataSet FRM_ChuCheDengJi_Load_ChaXunQuanBuCheLiang() {
            return base.Channel.FRM_ChuCheDengJi_Load_ChaXunQuanBuCheLiang();
        }
        
        public System.Data.DataSet FRM_ChuCheDengJi_Load_ChaXunCheLiang() {
            return base.Channel.FRM_ChuCheDengJi_Load_ChaXunCheLiang();
        }
        
        public System.Data.DataSet pb_MouseClick_ChaXunMingXi(int 配载发车单ID) {
            return base.Channel.pb_MouseClick_ChaXunMingXi(配载发车单ID);
        }
        
        public System.Data.DataSet FRM_ChuCheDengJi_Load_ChaXunWangDian() {
            return base.Channel.FRM_ChuCheDengJi_Load_ChaXunWangDian();
        }
        
        public System.Data.DataSet FRM_ChuCheDengJi_Load_ChaXunZhuangTai() {
            return base.Channel.FRM_ChuCheDengJi_Load_ChaXunZhuangTai();
        }
        
        public int FRM_ChuCheDengJi_tsbChuChe_Click_UpdateChuChe(int 车辆ID) {
            return base.Channel.FRM_ChuCheDengJi_tsbChuChe_Click_UpdateChuChe(车辆ID);
        }
        
        public System.Data.DataSet FRM_ChuCheDengJi_IDChaXunCheLiangZhuangTai(string strCheLiangID) {
            return base.Channel.FRM_ChuCheDengJi_IDChaXunCheLiangZhuangTai(strCheLiangID);
        }
    }
}
