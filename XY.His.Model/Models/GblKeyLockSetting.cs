using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class GblKeyLockSetting
    {
        public int ID { get; set; }
        public short KeyTypeId { get; set; }
        public string KeyValue { get; set; }
        public string WorkStationName { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string LockIp { get; set; }
        public System.DateTime LockTime { get; set; }
        public int SPID { get; set; }
        public System.DateTime LoginTime { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
