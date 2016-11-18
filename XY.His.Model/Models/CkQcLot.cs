using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class CkQcLot
    {
        public CkQcLot()
        {
            this.CkQcResults = new List<CkQcResult>();
        }

        public int ID { get; set; }
        public string Code { get; set; }
        public string SampleNum { get; set; }
        public int MachineId { get; set; }
        public System.DateTime ExpiryDate { get; set; }
        public int CtrlId { get; set; }
        public virtual CKMachine CKMachine { get; set; }
        public virtual CkQcControl CkQcControl { get; set; }
        public virtual ICollection<CkQcResult> CkQcResults { get; set; }
    }
}
