using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class CKMachineImage
    {
        public int ID { get; set; }
        public int LabID { get; set; }
        public string SampleNum { get; set; }
        public int MachineID { get; set; }
        public byte[] LabImage { get; set; }
        public string ImageType { get; set; }
        public bool IsDisplay { get; set; }
        public short OrderBy { get; set; }
    }
}
