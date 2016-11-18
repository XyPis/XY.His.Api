using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class GblLastId
    {
        public int ID { get; set; }
        public string TableName { get; set; }
        public Nullable<int> LastId { get; set; }
        public Nullable<System.DateTime> LastTime { get; set; }
    }
}
