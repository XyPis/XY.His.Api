using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class InYBBalance
    {
        public int ID { get; set; }
        public string INVONO { get; set; }
        public int LSPAYTYPE { get; set; }
        public int HOSPID { get; set; }
        public int PATTYPEID { get; set; }
        public System.DateTime FROMDATE { get; set; }
        public System.DateTime TODATE { get; set; }
        public int CHARGEDAYS { get; set; }
        public Nullable<decimal> BEPRICE { get; set; }
        public string TALLYNO { get; set; }
        public decimal FACTGET { get; set; }
        public decimal INSURANCE { get; set; }
        public decimal PAYSELF { get; set; }
        public decimal AMOUNTPAY { get; set; }
        public decimal DEPOSIT { get; set; }
        public decimal COMPLEMENT { get; set; }
        public decimal ARREARAGE { get; set; }
        public decimal ADDFEE { get; set; }
        public string REMARK { get; set; }
        public System.DateTime OPERTIME { get; set; }
        public int OPERID { get; set; }
        public bool ISCANCEL { get; set; }
        public Nullable<System.DateTime> CANCELOPERTIME { get; set; }
        public Nullable<int> CANCELOPERID { get; set; }
        public string CANCELMEMO { get; set; }
        public Nullable<int> INVOLASTID { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public Nullable<int> HOSPITALID { get; set; }
        public string NAME { get; set; }
        public string INPATNO { get; set; }
        public decimal SUMFEE { get; set; }
        public decimal AMOUNTINSURANCE { get; set; }
        public decimal AMOUNTFACT { get; set; }
        public System.DateTime INTIME { get; set; }
        public System.DateTime OUTTIME { get; set; }
        public byte[] REPORTCONTENT { get; set; }
    }
}
