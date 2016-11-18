using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace XY.His.Contract.Message.BS
{
    [Serializable]
    public partial class BsLocationDto : DtoBase
    {
        public string Code { get; set; }

        
        public string Name { get; set; }

        
        public Nullable<int> HospitalId { get; set; }

        
        public short LsInOut { get; set; }

        
        public bool IsForwomen { get; set; }

        
        public string PhoneCode { get; set; }

        
        public decimal MedicineRatio { get; set; }

        
        public short OrderBy { get; set; }

        
        public bool IsActive { get; set; }

        
        public string F1 { get; set; }

        
        public string F2 { get; set; }

        
        public string F3 { get; set; }

        
        public string F4 { get; set; }

        
        public short IconIndex { get; set; }

        
        public Nullable<int> SpecialityId { get; set; }

        
        public Nullable<short> BedSum { get; set; }

        
        public string BaSysCode { get; set; }

        
        public string Director { get; set; }

        
        public Nullable<int> DeptTypeId { get; set; }

        
        public Nullable<bool> IsCostApp { get; set; }

        
        public Nullable<short> AppLevel { get; set; }

        
        public string PyCode { get; set; }

        
        public string WbCode { get; set; }

        
        public Nullable<int> Area { get; set; }

        
        public string F5 { get; set; }

        
        public string F6 { get; set; }

        
        public string F7 { get; set; }

        
        public string F8 { get; set; }

        
        public Nullable<int> OuRoomId { get; set; }

        
        public Nullable<int> InRoomId { get; set; }

        
        public Nullable<bool> IsPriceSub { get; set; }
    }
}
