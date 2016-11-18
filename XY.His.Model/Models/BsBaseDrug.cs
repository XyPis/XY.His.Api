using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class BsBaseDrug
    {
        public BsBaseDrug()
        {
            this.BsBacteriaDrugs = new List<BsBacteriaDrug>();
            this.BsItemDrugs = new List<BsItemDrug>();
            this.CkLabMicDtls = new List<CkLabMicDtl>();
            this.DgDrugTips = new List<DgDrugTip>();
            this.DgIllCures = new List<DgIllCure>();
            this.DgTabus = new List<DgTabu>();
            this.NfInfectDrugs = new List<NfInfectDrug>();
            this.NfInfectTestBacterias = new List<NfInfectTestBacteria>();
        }

        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string PyCode { get; set; }
        public string WbCode { get; set; }
        public short OrderBy { get; set; }
        public bool IsActive { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
        public decimal PriceIn { get; set; }
        public string Memo { get; set; }
        public Nullable<int> GroupMainId { get; set; }
        public Nullable<int> GroupSubId { get; set; }
        public Nullable<int> GroupSubId2 { get; set; }
        public string EngDesc { get; set; }
        public Nullable<short> LsYbType { get; set; }
        public string YbMemo { get; set; }
        public Nullable<int> GroupSubId3 { get; set; }
        public Nullable<int> GroupSubId4 { get; set; }
        public virtual ICollection<BsBacteriaDrug> BsBacteriaDrugs { get; set; }
        public virtual ICollection<BsItemDrug> BsItemDrugs { get; set; }
        public virtual ICollection<CkLabMicDtl> CkLabMicDtls { get; set; }
        public virtual ICollection<DgDrugTip> DgDrugTips { get; set; }
        public virtual ICollection<DgIllCure> DgIllCures { get; set; }
        public virtual ICollection<DgTabu> DgTabus { get; set; }
        public virtual ICollection<NfInfectDrug> NfInfectDrugs { get; set; }
        public virtual ICollection<NfInfectTestBacteria> NfInfectTestBacterias { get; set; }
    }
}
