using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class CkQcControl
    {
        public CkQcControl()
        {
            this.CkItemQcs = new List<CkItemQc>();
            this.CkQcLots = new List<CkQcLot>();
            this.CkQcResults = new List<CkQcResult>();
        }

        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int MachineID { get; set; }
        public virtual ICollection<CkItemQc> CkItemQcs { get; set; }
        public virtual CKMachine CKMachine { get; set; }
        public virtual ICollection<CkQcLot> CkQcLots { get; set; }
        public virtual ICollection<CkQcResult> CkQcResults { get; set; }
    }
}
