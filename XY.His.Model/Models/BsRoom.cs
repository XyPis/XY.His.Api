using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class BsRoom
    {
        public BsRoom()
        {
            this.BsItemDrugs = new List<BsItemDrug>();
            this.BsItemDrugs1 = new List<BsItemDrug>();
            this.HuOuts = new List<HuOut>();
            this.RmAdjustDtls = new List<RmAdjustDtl>();
            this.RmAppDrugs = new List<RmAppDrug>();
            this.RmApplbacks = new List<RmApplback>();
            this.RmBacks = new List<RmBack>();
            this.BsRoomGroups = new List<BsRoomGroup>();
            this.RmKsBacks = new List<RmKsBack>();
            this.RmKsOuts = new List<RmKsOut>();
            this.RmLoses = new List<RmLose>();
            this.RmMoves = new List<RmMove>();
            this.RmMoves1 = new List<RmMove>();
            this.RmOtherIns = new List<RmOtherIn>();
            this.RmOutOths = new List<RmOutOth>();
            this.RmOuts = new List<RmOut>();
            this.RmPks = new List<RmPk>();
            this.RmPies = new List<RmPy>();
            this.RmSplits = new List<RmSplit>();
            this.RmChecks = new List<RmCheck>();
            this.RmStoreLogs = new List<RmStoreLog>();
            this.Rmstores = new List<Rmstore>();
            this.RmUnderLines = new List<RmUnderLine>();
            this.RmZyBacks = new List<RmZyBack>();
            this.RmZyOuts = new List<RmZyOut>();
            this.BsUserRooms = new List<BsUserRoom>();
            this.InDrugReqs = new List<InDrugReq>();
            this.BsRoomWindows = new List<BsRoomWindow>();
        }

        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public short LsInOut { get; set; }
        public int LocationId { get; set; }
        public short LsRoomType { get; set; }
        public string WbCode { get; set; }
        public string PyCode { get; set; }
        public short OrderBy { get; set; }
        public bool IsActive { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
        public virtual ICollection<BsItemDrug> BsItemDrugs { get; set; }
        public virtual ICollection<BsItemDrug> BsItemDrugs1 { get; set; }
        public virtual ICollection<HuOut> HuOuts { get; set; }
        public virtual ICollection<RmAdjustDtl> RmAdjustDtls { get; set; }
        public virtual ICollection<RmAppDrug> RmAppDrugs { get; set; }
        public virtual ICollection<RmApplback> RmApplbacks { get; set; }
        public virtual ICollection<RmBack> RmBacks { get; set; }
        public virtual ICollection<BsRoomGroup> BsRoomGroups { get; set; }
        public virtual ICollection<RmKsBack> RmKsBacks { get; set; }
        public virtual ICollection<RmKsOut> RmKsOuts { get; set; }
        public virtual ICollection<RmLose> RmLoses { get; set; }
        public virtual ICollection<RmMove> RmMoves { get; set; }
        public virtual ICollection<RmMove> RmMoves1 { get; set; }
        public virtual ICollection<RmOtherIn> RmOtherIns { get; set; }
        public virtual ICollection<RmOutOth> RmOutOths { get; set; }
        public virtual ICollection<RmOut> RmOuts { get; set; }
        public virtual ICollection<RmPk> RmPks { get; set; }
        public virtual ICollection<RmPy> RmPies { get; set; }
        public virtual ICollection<RmSplit> RmSplits { get; set; }
        public virtual ICollection<RmCheck> RmChecks { get; set; }
        public virtual ICollection<RmStoreLog> RmStoreLogs { get; set; }
        public virtual ICollection<Rmstore> Rmstores { get; set; }
        public virtual ICollection<RmUnderLine> RmUnderLines { get; set; }
        public virtual ICollection<RmZyBack> RmZyBacks { get; set; }
        public virtual ICollection<RmZyOut> RmZyOuts { get; set; }
        public virtual ICollection<BsUserRoom> BsUserRooms { get; set; }
        public virtual ICollection<InDrugReq> InDrugReqs { get; set; }
        public virtual ICollection<BsRoomWindow> BsRoomWindows { get; set; }
    }
}
