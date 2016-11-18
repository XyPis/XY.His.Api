using System;
using System.Collections.Generic;

namespace XY.His.Domain.BS
{
    public partial class BsUser : EntityBase
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public string Reason { get; set; }
        public short LsInputWay { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
        public Nullable<bool> IsUserInputWB { get; set; }
        public Nullable<bool> IsUserInputPY { get; set; }
        public Nullable<bool> IsUserInputCode { get; set; }
        public Nullable<bool> IsUserInputName { get; set; }
        public Nullable<bool> IsUserInputStrokeCode { get; set; }
        public Nullable<bool> IsUserInputEngDesc { get; set; }
        public string Introduce { get; set; }
        public string PicturePath { get; set; }
        public string Address { get; set; }
        public string Mobile { get; set; }
        public Nullable<int> LevelId { get; set; }
        public Nullable<int> DocLevId { get; set; }
        public Nullable<int> HospitalId { get; set; }
        public Nullable<int> CareGroupId { get; set; }
        public Nullable<int> CareGroupId1 { get; set; }
        public string F5 { get; set; }
        public string CertIdNo { get; set; }
        public string PyCode { get; set; }
        public string WbCode { get; set; }
        public Nullable<bool> IsUserInputF1 { get; set; }
    }
}
