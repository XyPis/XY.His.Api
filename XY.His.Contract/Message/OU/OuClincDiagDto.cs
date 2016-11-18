using System;
using System.Collections.Generic;

namespace XY.His.Contract.Message.OU
{
    [Serializable]
    public partial class OuClincDiagDto : DtoBase
    {
        public int MzRegId { get; set; }
        public int ListNum { get; set; }
        public Nullable<int> IcdId { get; set; }
        public string IllDesc { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public Nullable<short> LsDiagType { get; set; }
        public Nullable<int> SequenceNum { get; set; }
    }
}
