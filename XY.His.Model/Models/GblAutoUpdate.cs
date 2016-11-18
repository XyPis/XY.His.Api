using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class GblAutoUpdate
    {
        public int ID { get; set; }
        public string PathName { get; set; }
        public byte[] FileContent { get; set; }
        public Nullable<System.DateTime> OldVersion { get; set; }
        public System.DateTime NewVersion { get; set; }
        public string UpLoadHostName { get; set; }
        public string UpLoadIp { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public string DownLoadHostNames { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public string HospitalIds { get; set; }
    }
}
