﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.34014
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCF物流管理系统_Client.BLL物流管理系统.配载发货.PeiZaiFaHuoPeiZai {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BLL物流管理系统.配载发货.PeiZaiFaHuoPeiZai.PeiZaiFaHuoPeiZai")]
    public interface PeiZaiFaHuoPeiZai {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/PeiZaiFaHuoPeiZai/FRM_PeiZaiFaHuoPeiZai_selectPeiZaiFaHuoDan", ReplyAction="http://tempuri.org/PeiZaiFaHuoPeiZai/FRM_PeiZaiFaHuoPeiZai_selectPeiZaiFaHuoDanRe" +
            "sponse")]
        System.Data.DataSet FRM_PeiZaiFaHuoPeiZai_selectPeiZaiFaHuoDan();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/PeiZaiFaHuoPeiZai/FRM_PeiZaiFaHuoPeiZai_selectPeiZaiFaHuoDanMi" +
            "ngXiByFaCheID", ReplyAction="http://tempuri.org/PeiZaiFaHuoPeiZai/FRM_PeiZaiFaHuoPeiZai_selectPeiZaiFaHuoDanMi" +
            "ngXiByFaCheIDResponse")]
        System.Data.DataSet FRM_PeiZaiFaHuoPeiZai_selectPeiZaiFaHuoDanMingXiByFaCheID(int 配载发车单ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/PeiZaiFaHuoPeiZai/FRM_PeiZaiFaHuoPeiZai_SelectFaCheZhuangTaiBy" +
            "PeiZaiFaCheID", ReplyAction="http://tempuri.org/PeiZaiFaHuoPeiZai/FRM_PeiZaiFaHuoPeiZai_SelectFaCheZhuangTaiBy" +
            "PeiZaiFaCheIDResponse")]
        System.Data.DataSet FRM_PeiZaiFaHuoPeiZai_SelectFaCheZhuangTaiByPeiZaiFaCheID(int 配载发车单ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/PeiZaiFaHuoPeiZai/frmPeiZaiFaHuo_Insert_ConcelFenBaoSuoDing", ReplyAction="http://tempuri.org/PeiZaiFaHuoPeiZai/frmPeiZaiFaHuo_Insert_ConcelFenBaoSuoDingRes" +
            "ponse")]
        int frmPeiZaiFaHuo_Insert_ConcelFenBaoSuoDing(int 分包ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/PeiZaiFaHuoPeiZai/frmPeiZaiFaHuo_Update_DeletePeiZaiMingXiByFe" +
            "nBaoID", ReplyAction="http://tempuri.org/PeiZaiFaHuoPeiZai/frmPeiZaiFaHuo_Update_DeletePeiZaiMingXiByFe" +
            "nBaoIDResponse")]
        int frmPeiZaiFaHuo_Update_DeletePeiZaiMingXiByFenBaoID(int 分包ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/PeiZaiFaHuoPeiZai/FRM_PeiZaiFaHuoPeiZai_DeletePeiZaiDanByID", ReplyAction="http://tempuri.org/PeiZaiFaHuoPeiZai/FRM_PeiZaiFaHuoPeiZai_DeletePeiZaiDanByIDRes" +
            "ponse")]
        int FRM_PeiZaiFaHuoPeiZai_DeletePeiZaiDanByID(int 配载发车单ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/PeiZaiFaHuoPeiZai/frmPeiZaiFaHuo_Update_UpdateSiJiZhuangTaiByS" +
            "iJiID", ReplyAction="http://tempuri.org/PeiZaiFaHuoPeiZai/frmPeiZaiFaHuo_Update_UpdateSiJiZhuangTaiByS" +
            "iJiIDResponse")]
        int frmPeiZaiFaHuo_Update_UpdateSiJiZhuangTaiBySiJiID(int 司机ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/PeiZaiFaHuoPeiZai/frmPeiZaiFaHuo_Update_UpdateCheLiangZhuangTa" +
            "iByID", ReplyAction="http://tempuri.org/PeiZaiFaHuoPeiZai/frmPeiZaiFaHuo_Update_UpdateCheLiangZhuangTa" +
            "iByIDResponse")]
        int frmPeiZaiFaHuo_Update_UpdateCheLiangZhuangTaiByID(int 车辆ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/PeiZaiFaHuoPeiZai/FRM_PeiZaiFaHuoPeiZai_SelectCboFaCheZhaungTa" +
            "i", ReplyAction="http://tempuri.org/PeiZaiFaHuoPeiZai/FRM_PeiZaiFaHuoPeiZai_SelectCboFaCheZhaungTa" +
            "iResponse")]
        System.Data.DataSet FRM_PeiZaiFaHuoPeiZai_SelectCboFaCheZhaungTai();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/PeiZaiFaHuoPeiZai/FRM_PeiZaiFaHuoPeiZai_MoHuSelectPeiZaiFaCheD" +
            "an", ReplyAction="http://tempuri.org/PeiZaiFaHuoPeiZai/FRM_PeiZaiFaHuoPeiZai_MoHuSelectPeiZaiFaCheD" +
            "anResponse")]
        System.Data.DataSet FRM_PeiZaiFaHuoPeiZai_MoHuSelectPeiZaiFaCheDan(System.DateTime 起始时间, System.DateTime 结束时间, int 发车状态ID, string 配载发车单号);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/PeiZaiFaHuoPeiZai/FRM_PeiZaiFaHuoPeiZai_SelectWangDianByByXian" +
            "Lu", ReplyAction="http://tempuri.org/PeiZaiFaHuoPeiZai/FRM_PeiZaiFaHuoPeiZai_SelectWangDianByByXian" +
            "LuResponse")]
        System.Data.DataSet FRM_PeiZaiFaHuoPeiZai_SelectWangDianByByXianLu(int 线路ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/PeiZaiFaHuoPeiZai/FRM_PeiZaiFaHuoPeiZai_Load_SelectFaCheZhuang" +
            "Tai", ReplyAction="http://tempuri.org/PeiZaiFaHuoPeiZai/FRM_PeiZaiFaHuoPeiZai_Load_SelectFaCheZhuang" +
            "TaiResponse")]
        System.Data.DataSet FRM_PeiZaiFaHuoPeiZai_Load_SelectFaCheZhuangTai();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/PeiZaiFaHuoPeiZai/FRM_PeiZaiFaHuoPeiZai_btnChuCheShenQing_Clic" +
            "k_UpdateCheLiangZhuangTai", ReplyAction="http://tempuri.org/PeiZaiFaHuoPeiZai/FRM_PeiZaiFaHuoPeiZai_btnChuCheShenQing_Clic" +
            "k_UpdateCheLiangZhuangTaiResponse")]
        int FRM_PeiZaiFaHuoPeiZai_btnChuCheShenQing_Click_UpdateCheLiangZhuangTai(int 配载发车单ID);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface PeiZaiFaHuoPeiZaiChannel : WCF物流管理系统_Client.BLL物流管理系统.配载发货.PeiZaiFaHuoPeiZai.PeiZaiFaHuoPeiZai, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PeiZaiFaHuoPeiZaiClient : System.ServiceModel.ClientBase<WCF物流管理系统_Client.BLL物流管理系统.配载发货.PeiZaiFaHuoPeiZai.PeiZaiFaHuoPeiZai>, WCF物流管理系统_Client.BLL物流管理系统.配载发货.PeiZaiFaHuoPeiZai.PeiZaiFaHuoPeiZai {
        
        public PeiZaiFaHuoPeiZaiClient() {
        }
        
        public PeiZaiFaHuoPeiZaiClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PeiZaiFaHuoPeiZaiClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PeiZaiFaHuoPeiZaiClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PeiZaiFaHuoPeiZaiClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataSet FRM_PeiZaiFaHuoPeiZai_selectPeiZaiFaHuoDan() {
            return base.Channel.FRM_PeiZaiFaHuoPeiZai_selectPeiZaiFaHuoDan();
        }
        
        public System.Data.DataSet FRM_PeiZaiFaHuoPeiZai_selectPeiZaiFaHuoDanMingXiByFaCheID(int 配载发车单ID) {
            return base.Channel.FRM_PeiZaiFaHuoPeiZai_selectPeiZaiFaHuoDanMingXiByFaCheID(配载发车单ID);
        }
        
        public System.Data.DataSet FRM_PeiZaiFaHuoPeiZai_SelectFaCheZhuangTaiByPeiZaiFaCheID(int 配载发车单ID) {
            return base.Channel.FRM_PeiZaiFaHuoPeiZai_SelectFaCheZhuangTaiByPeiZaiFaCheID(配载发车单ID);
        }
        
        public int frmPeiZaiFaHuo_Insert_ConcelFenBaoSuoDing(int 分包ID) {
            return base.Channel.frmPeiZaiFaHuo_Insert_ConcelFenBaoSuoDing(分包ID);
        }
        
        public int frmPeiZaiFaHuo_Update_DeletePeiZaiMingXiByFenBaoID(int 分包ID) {
            return base.Channel.frmPeiZaiFaHuo_Update_DeletePeiZaiMingXiByFenBaoID(分包ID);
        }
        
        public int FRM_PeiZaiFaHuoPeiZai_DeletePeiZaiDanByID(int 配载发车单ID) {
            return base.Channel.FRM_PeiZaiFaHuoPeiZai_DeletePeiZaiDanByID(配载发车单ID);
        }
        
        public int frmPeiZaiFaHuo_Update_UpdateSiJiZhuangTaiBySiJiID(int 司机ID) {
            return base.Channel.frmPeiZaiFaHuo_Update_UpdateSiJiZhuangTaiBySiJiID(司机ID);
        }
        
        public int frmPeiZaiFaHuo_Update_UpdateCheLiangZhuangTaiByID(int 车辆ID) {
            return base.Channel.frmPeiZaiFaHuo_Update_UpdateCheLiangZhuangTaiByID(车辆ID);
        }
        
        public System.Data.DataSet FRM_PeiZaiFaHuoPeiZai_SelectCboFaCheZhaungTai() {
            return base.Channel.FRM_PeiZaiFaHuoPeiZai_SelectCboFaCheZhaungTai();
        }
        
        public System.Data.DataSet FRM_PeiZaiFaHuoPeiZai_MoHuSelectPeiZaiFaCheDan(System.DateTime 起始时间, System.DateTime 结束时间, int 发车状态ID, string 配载发车单号) {
            return base.Channel.FRM_PeiZaiFaHuoPeiZai_MoHuSelectPeiZaiFaCheDan(起始时间, 结束时间, 发车状态ID, 配载发车单号);
        }
        
        public System.Data.DataSet FRM_PeiZaiFaHuoPeiZai_SelectWangDianByByXianLu(int 线路ID) {
            return base.Channel.FRM_PeiZaiFaHuoPeiZai_SelectWangDianByByXianLu(线路ID);
        }
        
        public System.Data.DataSet FRM_PeiZaiFaHuoPeiZai_Load_SelectFaCheZhuangTai() {
            return base.Channel.FRM_PeiZaiFaHuoPeiZai_Load_SelectFaCheZhuangTai();
        }
        
        public int FRM_PeiZaiFaHuoPeiZai_btnChuCheShenQing_Click_UpdateCheLiangZhuangTai(int 配载发车单ID) {
            return base.Channel.FRM_PeiZaiFaHuoPeiZai_btnChuCheShenQing_Click_UpdateCheLiangZhuangTai(配载发车单ID);
        }
    }
}
