﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.34014
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCF物流管理系统_Client.BLL物流管理系统.配载发货.PeiZaiFaHuoPeiZai_Update {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BLL物流管理系统.配载发货.PeiZaiFaHuoPeiZai_Update.PeiZaiFaHuoPeiZai_Update")]
    public interface PeiZaiFaHuoPeiZai_Update {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/PeiZaiFaHuoPeiZai_Update/FRM_PeiZaiFaHuoPeiZai_SelectPeiZaiFaH" +
            "uoDanBYPeiZaiFaHuoDanID", ReplyAction="http://tempuri.org/PeiZaiFaHuoPeiZai_Update/FRM_PeiZaiFaHuoPeiZai_SelectPeiZaiFaH" +
            "uoDanBYPeiZaiFaHuoDanIDResponse")]
        System.Data.DataSet FRM_PeiZaiFaHuoPeiZai_SelectPeiZaiFaHuoDanBYPeiZaiFaHuoDanID(int 配载发车单ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/PeiZaiFaHuoPeiZai_Update/FRM_PeiZaiFaHuoPeiZai_selectPeiZaiFaH" +
            "uoDanMingXiByFaHuoDanID", ReplyAction="http://tempuri.org/PeiZaiFaHuoPeiZai_Update/FRM_PeiZaiFaHuoPeiZai_selectPeiZaiFaH" +
            "uoDanMingXiByFaHuoDanIDResponse")]
        System.Data.DataSet FRM_PeiZaiFaHuoPeiZai_selectPeiZaiFaHuoDanMingXiByFaHuoDanID(int 配载发车单ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/PeiZaiFaHuoPeiZai_Update/frmPeiZaiFaHuo_Insert_SelectcboWiangD" +
            "ian", ReplyAction="http://tempuri.org/PeiZaiFaHuoPeiZai_Update/frmPeiZaiFaHuo_Insert_SelectcboWiangD" +
            "ianResponse")]
        System.Data.DataSet frmPeiZaiFaHuo_Insert_SelectcboWiangDian();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/PeiZaiFaHuoPeiZai_Update/frmPeiZaiFaHuo_Insert_SelectcboXianLu" +
            "", ReplyAction="http://tempuri.org/PeiZaiFaHuoPeiZai_Update/frmPeiZaiFaHuo_Insert_SelectcboXianLu" +
            "Response")]
        System.Data.DataSet frmPeiZaiFaHuo_Insert_SelectcboXianLu();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/PeiZaiFaHuoPeiZai_Update/frmPeiZaiFaHuo_Update_SelectSiJiBySiJ" +
            "iID", ReplyAction="http://tempuri.org/PeiZaiFaHuoPeiZai_Update/frmPeiZaiFaHuo_Update_SelectSiJiBySiJ" +
            "iIDResponse")]
        System.Data.DataSet frmPeiZaiFaHuo_Update_SelectSiJiBySiJiID(int 司机ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/PeiZaiFaHuoPeiZai_Update/frmPeiZaiFaHuo_Update_SelectcboCheLia" +
            "ng", ReplyAction="http://tempuri.org/PeiZaiFaHuoPeiZai_Update/frmPeiZaiFaHuo_Update_SelectcboCheLia" +
            "ngResponse")]
        System.Data.DataSet frmPeiZaiFaHuo_Update_SelectcboCheLiang(int 车辆ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/PeiZaiFaHuoPeiZai_Update/frmPeiZaiFaHuo_Insert_ConcelFenBaoSuo" +
            "Ding", ReplyAction="http://tempuri.org/PeiZaiFaHuoPeiZai_Update/frmPeiZaiFaHuo_Insert_ConcelFenBaoSuo" +
            "DingResponse")]
        int frmPeiZaiFaHuo_Insert_ConcelFenBaoSuoDing(int 分包ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/PeiZaiFaHuoPeiZai_Update/frmPeiZaiFaHuo_Update_UpdateSiJiZhuan" +
            "gTaiBySiJiID", ReplyAction="http://tempuri.org/PeiZaiFaHuoPeiZai_Update/frmPeiZaiFaHuo_Update_UpdateSiJiZhuan" +
            "gTaiBySiJiIDResponse")]
        int frmPeiZaiFaHuo_Update_UpdateSiJiZhuangTaiBySiJiID(int 司机ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/PeiZaiFaHuoPeiZai_Update/frmPeiZaiFaHuo_Insert_UpdateSiJiZhuan" +
            "gTai", ReplyAction="http://tempuri.org/PeiZaiFaHuoPeiZai_Update/frmPeiZaiFaHuo_Insert_UpdateSiJiZhuan" +
            "gTaiResponse")]
        int frmPeiZaiFaHuo_Insert_UpdateSiJiZhuangTai(int 司机ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/PeiZaiFaHuoPeiZai_Update/frmPeiZaiFaHuo_Update_UpdateCheLiangZ" +
            "huangTaiByID", ReplyAction="http://tempuri.org/PeiZaiFaHuoPeiZai_Update/frmPeiZaiFaHuo_Update_UpdateCheLiangZ" +
            "huangTaiByIDResponse")]
        int frmPeiZaiFaHuo_Update_UpdateCheLiangZhuangTaiByID(int 车辆ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/PeiZaiFaHuoPeiZai_Update/frmPeiZaiFaHuo_Insert_UpdateCheLiangZ" +
            "huangTai", ReplyAction="http://tempuri.org/PeiZaiFaHuoPeiZai_Update/frmPeiZaiFaHuo_Insert_UpdateCheLiangZ" +
            "huangTaiResponse")]
        int frmPeiZaiFaHuo_Insert_UpdateCheLiangZhuangTai(int 车辆ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/PeiZaiFaHuoPeiZai_Update/frmPeiZaiFaHuo_Update_UpdatePeiZaiFaC" +
            "heDanByFaCheDanID", ReplyAction="http://tempuri.org/PeiZaiFaHuoPeiZai_Update/frmPeiZaiFaHuo_Update_UpdatePeiZaiFaC" +
            "heDanByFaCheDanIDResponse")]
        int frmPeiZaiFaHuo_Update_UpdatePeiZaiFaCheDanByFaCheDanID(int 车辆ID, int 司机ID, int 发车网点ID, int 线路ID, int 目的网点ID, System.DateTime 接单时间, int 配载发车单ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/PeiZaiFaHuoPeiZai_Update/frmPeiZaiFaHuo_Update_DeletePeiZaiMin" +
            "gXiByFenBaoID", ReplyAction="http://tempuri.org/PeiZaiFaHuoPeiZai_Update/frmPeiZaiFaHuo_Update_DeletePeiZaiMin" +
            "gXiByFenBaoIDResponse")]
        int frmPeiZaiFaHuo_Update_DeletePeiZaiMingXiByFenBaoID(int 分包ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/PeiZaiFaHuoPeiZai_Update/frmPeiZaiFaHuo_Insert_InsertPeiZaiFaC" +
            "heMingXi", ReplyAction="http://tempuri.org/PeiZaiFaHuoPeiZai_Update/frmPeiZaiFaHuo_Insert_InsertPeiZaiFaC" +
            "heMingXiResponse")]
        int frmPeiZaiFaHuo_Insert_InsertPeiZaiFaCheMingXi(int 配载发车单ID, int 分包ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/PeiZaiFaHuoPeiZai_Update/cboFaHuoWangDian_SelectedIndexChanged" +
            "_ChaXunLuXianLinJu", ReplyAction="http://tempuri.org/PeiZaiFaHuoPeiZai_Update/cboFaHuoWangDian_SelectedIndexChanged" +
            "_ChaXunLuXianLinJuResponse")]
        System.Data.DataSet cboFaHuoWangDian_SelectedIndexChanged_ChaXunLuXianLinJu(int 开始网点ID, int 结束网点ID);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface PeiZaiFaHuoPeiZai_UpdateChannel : WCF物流管理系统_Client.BLL物流管理系统.配载发货.PeiZaiFaHuoPeiZai_Update.PeiZaiFaHuoPeiZai_Update, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PeiZaiFaHuoPeiZai_UpdateClient : System.ServiceModel.ClientBase<WCF物流管理系统_Client.BLL物流管理系统.配载发货.PeiZaiFaHuoPeiZai_Update.PeiZaiFaHuoPeiZai_Update>, WCF物流管理系统_Client.BLL物流管理系统.配载发货.PeiZaiFaHuoPeiZai_Update.PeiZaiFaHuoPeiZai_Update {
        
        public PeiZaiFaHuoPeiZai_UpdateClient() {
        }
        
        public PeiZaiFaHuoPeiZai_UpdateClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PeiZaiFaHuoPeiZai_UpdateClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PeiZaiFaHuoPeiZai_UpdateClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PeiZaiFaHuoPeiZai_UpdateClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataSet FRM_PeiZaiFaHuoPeiZai_SelectPeiZaiFaHuoDanBYPeiZaiFaHuoDanID(int 配载发车单ID) {
            return base.Channel.FRM_PeiZaiFaHuoPeiZai_SelectPeiZaiFaHuoDanBYPeiZaiFaHuoDanID(配载发车单ID);
        }
        
        public System.Data.DataSet FRM_PeiZaiFaHuoPeiZai_selectPeiZaiFaHuoDanMingXiByFaHuoDanID(int 配载发车单ID) {
            return base.Channel.FRM_PeiZaiFaHuoPeiZai_selectPeiZaiFaHuoDanMingXiByFaHuoDanID(配载发车单ID);
        }
        
        public System.Data.DataSet frmPeiZaiFaHuo_Insert_SelectcboWiangDian() {
            return base.Channel.frmPeiZaiFaHuo_Insert_SelectcboWiangDian();
        }
        
        public System.Data.DataSet frmPeiZaiFaHuo_Insert_SelectcboXianLu() {
            return base.Channel.frmPeiZaiFaHuo_Insert_SelectcboXianLu();
        }
        
        public System.Data.DataSet frmPeiZaiFaHuo_Update_SelectSiJiBySiJiID(int 司机ID) {
            return base.Channel.frmPeiZaiFaHuo_Update_SelectSiJiBySiJiID(司机ID);
        }
        
        public System.Data.DataSet frmPeiZaiFaHuo_Update_SelectcboCheLiang(int 车辆ID) {
            return base.Channel.frmPeiZaiFaHuo_Update_SelectcboCheLiang(车辆ID);
        }
        
        public int frmPeiZaiFaHuo_Insert_ConcelFenBaoSuoDing(int 分包ID) {
            return base.Channel.frmPeiZaiFaHuo_Insert_ConcelFenBaoSuoDing(分包ID);
        }
        
        public int frmPeiZaiFaHuo_Update_UpdateSiJiZhuangTaiBySiJiID(int 司机ID) {
            return base.Channel.frmPeiZaiFaHuo_Update_UpdateSiJiZhuangTaiBySiJiID(司机ID);
        }
        
        public int frmPeiZaiFaHuo_Insert_UpdateSiJiZhuangTai(int 司机ID) {
            return base.Channel.frmPeiZaiFaHuo_Insert_UpdateSiJiZhuangTai(司机ID);
        }
        
        public int frmPeiZaiFaHuo_Update_UpdateCheLiangZhuangTaiByID(int 车辆ID) {
            return base.Channel.frmPeiZaiFaHuo_Update_UpdateCheLiangZhuangTaiByID(车辆ID);
        }
        
        public int frmPeiZaiFaHuo_Insert_UpdateCheLiangZhuangTai(int 车辆ID) {
            return base.Channel.frmPeiZaiFaHuo_Insert_UpdateCheLiangZhuangTai(车辆ID);
        }
        
        public int frmPeiZaiFaHuo_Update_UpdatePeiZaiFaCheDanByFaCheDanID(int 车辆ID, int 司机ID, int 发车网点ID, int 线路ID, int 目的网点ID, System.DateTime 接单时间, int 配载发车单ID) {
            return base.Channel.frmPeiZaiFaHuo_Update_UpdatePeiZaiFaCheDanByFaCheDanID(车辆ID, 司机ID, 发车网点ID, 线路ID, 目的网点ID, 接单时间, 配载发车单ID);
        }
        
        public int frmPeiZaiFaHuo_Update_DeletePeiZaiMingXiByFenBaoID(int 分包ID) {
            return base.Channel.frmPeiZaiFaHuo_Update_DeletePeiZaiMingXiByFenBaoID(分包ID);
        }
        
        public int frmPeiZaiFaHuo_Insert_InsertPeiZaiFaCheMingXi(int 配载发车单ID, int 分包ID) {
            return base.Channel.frmPeiZaiFaHuo_Insert_InsertPeiZaiFaCheMingXi(配载发车单ID, 分包ID);
        }
        
        public System.Data.DataSet cboFaHuoWangDian_SelectedIndexChanged_ChaXunLuXianLinJu(int 开始网点ID, int 结束网点ID) {
            return base.Channel.cboFaHuoWangDian_SelectedIndexChanged_ChaXunLuXianLinJu(开始网点ID, 结束网点ID);
        }
    }
}
