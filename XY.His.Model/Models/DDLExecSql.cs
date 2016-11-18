using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class DDLExecSql
    {
        public int id { get; set; }
        public string EventType { get; set; }
        public string SchemaName { get; set; }
        public string ObjType { get; set; }
        public string ObjName { get; set; }
        public string SqlText { get; set; }
        public Nullable<System.DateTime> ExecDate { get; set; }
        public string Terminal { get; set; }
    }
}
