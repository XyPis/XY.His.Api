using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class VwOuDrugCheck
    {
        public string Name { get; set; }
        public string ItemName { get; set; }
        public string Spec { get; set; }
        public string InvoNo { get; set; }
        public string DoctorName { get; set; }
        public string LocationName { get; set; }
        public short LsInOut { get; set; }
        public bool IsCancel { get; set; }
        public string Code { get; set; }
        public decimal Price { get; set; }
        public decimal Totality { get; set; }
        public string UnitIdName { get; set; }
        public decimal Amount { get; set; }
        public System.DateTime InvoTime { get; set; }
        public string PatientName { get; set; }
        public string SexName { get; set; }
        public Nullable<int> Age { get; set; }
        public string InvItemName { get; set; }
    }
}
