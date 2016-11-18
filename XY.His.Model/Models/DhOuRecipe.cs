using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class DhOuRecipe
    {
        public int ID { get; set; }
        public Nullable<int> HospitalId { get; set; }
        public Nullable<int> RecId { get; set; }
        public string MzRegNo { get; set; }
        public System.DateTime RegTime { get; set; }
        public int PatId { get; set; }
        public string CardNo { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public string Illness { get; set; }
        public string MedicareNo { get; set; }
        public string PatTypeName { get; set; }
        public string RegTypeName { get; set; }
        public string DiagnDeptName { get; set; }
        public string DoctorName { get; set; }
        public string DoctorCode { get; set; }
        public string DocLevel { get; set; }
        public string RoomNo { get; set; }
        public Nullable<short> LsRepType { get; set; }
        public string RecipeNum { get; set; }
        public Nullable<System.DateTime> RecipeTime { get; set; }
        public Nullable<short> HowMany { get; set; }
        public Nullable<bool> IsPriority { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public string Memo { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public string IcdCode { get; set; }
    }
}
